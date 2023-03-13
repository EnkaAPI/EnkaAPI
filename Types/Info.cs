using Newtonsoft.Json;

namespace EnkaAPI.Types;

public class Info
{
	[JsonProperty("playerInfo")]
	public PlayerInfo.PlayerInfo PlayerInfo { get; init; }
}