using Newtonsoft.Json;

namespace EnkaAPI.Types.AvatarInfo;

public struct Prop
{
	[JsonProperty("1001")]
	//[JsonConverter(typeof(PropConverter))]
	public PropInfo Xp { get; init; }
	
	[JsonProperty("1002")]
	public PropInfo Ascension { get; init; }
	
	[JsonProperty("4001")]
	public PropInfo Level { get; init; }
}

public struct PropInfo
{
	[JsonProperty("ival")]
	public uint Value { get; init; }
}

/*public class PropConverter : Newtonsoft.Json.JsonConverter
{
	public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
	{
		
	}

	public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
	{
		return existingValue;
	}

	public override bool CanConvert(Type objectType)
	{
		return true;
	}
}*/