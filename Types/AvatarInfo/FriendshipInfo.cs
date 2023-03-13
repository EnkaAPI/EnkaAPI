using Newtonsoft.Json;

namespace EnkaAPI.Types.AvatarInfo;

public struct FriendshipInfo
{
	[JsonProperty("expLevel")]
	public byte Level { get; init; }
}