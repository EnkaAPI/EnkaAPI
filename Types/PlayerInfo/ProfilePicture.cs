using Newtonsoft.Json;

namespace EnkaAPI.Types.PlayerInfo;

public struct ProfilePicture
{
	[JsonProperty("avatarId")]
	public uint AvatarId { get; init; }
}