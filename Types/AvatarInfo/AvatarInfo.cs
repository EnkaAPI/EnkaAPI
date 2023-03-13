using Newtonsoft.Json;

namespace EnkaAPI.Types.AvatarInfo;

public struct AvatarInfo
{
	[JsonProperty("avatarId")]
	public uint AvatarId { get; init; }
	
	[JsonProperty("propMap")]
	public Prop Props { get; init; }
	
	[JsonProperty("fightPropMap")]
	public FightProp FightProps { get; init; }
	
	[JsonProperty("fetterInfo")]
	public FriendshipInfo FriendshipInfo { get; init; }
}