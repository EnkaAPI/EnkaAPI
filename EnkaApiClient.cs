using System.Net.Http.Headers;
using ComposableAsync;
using EnkaAPI.Types;
using Newtonsoft.Json;
using RateLimiter;

namespace EnkaAPI;

public class EnkaApiClient
{
    private static HttpClient s_client = null!;
    private static readonly DelegatingHandler s_handler =
        TimeLimiter.GetFromMaxCountByInterval(5, TimeSpan.FromSeconds(1))
            .AsDelegatingHandler();

    public static readonly JsonSerializerSettings SerializationOptions = new()
    {
        MissingMemberHandling = MissingMemberHandling.Ignore,
        NullValueHandling = NullValueHandling.Ignore,
        DefaultValueHandling = DefaultValueHandling.Ignore
    };

    public EnkaApiClient()
    {
        s_client = new HttpClient(s_handler);
        s_client.BaseAddress = new Uri("https://enka.network/api/uid/");
        s_client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json")
        );
    }
    
    public Task<Info> GetInfo(uint uid) 
        => Request<Info>(s_client.GetAsync(uid + "?info"));

    private async Task<T> Request<T>(Task<HttpResponseMessage> task)
    {
        var response = await task;
        response.EnsureSuccessStatusCode();
        var str = await response.Content.ReadAsStringAsync();
        var obj = JsonConvert.DeserializeObject<T>(str, SerializationOptions);

        return obj!;
    }
}