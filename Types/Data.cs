using Newtonsoft.Json;

namespace EnkaAPI.Types;

public class Data : Info
{
	[JsonProperty("uid")]
	public uint Uid { get; init; }
	
	[JsonProperty("avatarInfoList")]
	public IEnumerable<AvatarInfo.AvatarInfo> AvatarInfoList { get; init; }
}