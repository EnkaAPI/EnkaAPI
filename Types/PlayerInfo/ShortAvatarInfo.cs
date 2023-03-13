using Newtonsoft.Json;

namespace EnkaAPI.Types.PlayerInfo;

public struct ShortAvatarInfo
{
	[JsonProperty("avatarId")]
	public uint AvatarId { get; init; }
	
	[JsonProperty("level")]
	public byte Level { get; init; }
}