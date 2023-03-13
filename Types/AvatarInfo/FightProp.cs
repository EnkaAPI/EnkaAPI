using Newtonsoft.Json;

namespace EnkaAPI.Types.AvatarInfo;

public struct FightProp
{
	[JsonProperty("1")]
	public ushort BaseHp { get; init; }
	[JsonProperty("4")]
	public ushort BaseAttack { get; init; }
	[JsonProperty("7")]
	public ushort BaseDefence { get; init; }
	
	[JsonProperty("3")]
	public float HpPercent { get; init; }
	[JsonProperty("6")]
	public float AttackPercent { get; init; }
	[JsonProperty("9")]
	public float DefencePercent { get; init; }
	
	[JsonProperty("2000")]
	public ushort Hp { get; init; }
	[JsonProperty("2001")]
	public ushort Attack { get; init; }
	[JsonProperty("2002")]
	public ushort Defence { get; init; }
	[JsonProperty("28")]
	public ushort ElementalMastery { get; init; }
	
	[JsonProperty("20")]
	public float CritRate { get; init; }
	[JsonProperty("22")]
	public float CritDamage { get; init; }
	[JsonProperty("26")]
	public float HealingBonus { get; init; }
	[JsonProperty("27")]
	public float IncomingHealingBonus { get; init; }
	[JsonProperty("23")]
	public float EnergyRecharge { get; init; }
	
	[JsonProperty("40")]
	public float PyroDamage { get; init; }
	[JsonProperty("42")]
	public float HydroDamage { get; init; }
	[JsonProperty("43")]
	public float DendroDamage { get; init; }
	[JsonProperty("41")]
	public float ElectroDamage { get; init; }
	[JsonProperty("44")]
	public float AnemoDamage { get; init; }
	[JsonProperty("46")]
	public float CryoDamage { get; init; }
	[JsonProperty("45")]
	public float GeoDamage { get; init; }
	[JsonProperty("30")]
	public float PhysicalDamage { get; init; }
	
	[JsonProperty("50")]
	public float PyroResist { get; init; }
	[JsonProperty("52")]
	public float HydroResist { get; init; }
	[JsonProperty("53")]
	public float DendroResist { get; init; }
	[JsonProperty("51")]
	public float ElectroResist { get; init; }
	[JsonProperty("54")]
	public float AnemoResist { get; init; }
	[JsonProperty("56")]
	public float CryoResist { get; init; }
	[JsonProperty("55")]
	public float GeoResist { get; init; }
	[JsonProperty("29")]
	public float PhysicalResist { get; init; }
}