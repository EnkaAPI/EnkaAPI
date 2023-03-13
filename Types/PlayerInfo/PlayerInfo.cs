using Newtonsoft.Json;

namespace EnkaAPI.Types.PlayerInfo;

public struct PlayerInfo
{
    [JsonProperty("nickname")]
    public string Nickname { get; init; }
    
    [JsonProperty("level")]
    public byte AdventureRank { get; init; }
    
    [JsonProperty("signature")]
    public string Description { get; init; }

    [JsonProperty("worldLevel")]
    public byte WorldLevel { get; init; }

    [JsonProperty("finishAchievementNum")]
    public ushort AchievementsCount { get; init; }

    [JsonProperty("towerFloorIndex")]
    public byte AbyssFloor { get; init; }

    [JsonProperty("towerLevelIndex")]
    public byte AbyssIndex { get; init; }

    [JsonProperty("showAvatarInfoList")]
    public IEnumerable<ShortAvatarInfo> AvatarInfoList { get; init; }

    [JsonProperty("profilePicture")]
    public ProfilePicture ProfilePicture { get; init; }
}