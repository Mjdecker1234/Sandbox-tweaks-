using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace SandboxTweaks.Settings
{
    public class SandboxTweaksSettings : AttributeGlobalSettings<SandboxTweaksSettings>
    {
        public override string Id => "SandboxTweaksSettings";
        public override string DisplayName => "Sandbox Tweaks";
        public override string FolderName => "SandboxTweaks";
        public override string FormatType => "json2";

        #region Age Tweaks

        [SettingPropertyBool("Enable Age Tweaks", Order = 0, RequireRestart = false, HintText = "Enable or disable age-related tweaks.")]
        [SettingPropertyGroup("Age Tweaks", GroupOrder = 0)]
        public bool EnableAgeTweaks { get; set; } = true;

        [SettingPropertyInteger("Become Infant Age", 0, 125, Order = 1, RequireRestart = false, HintText = "Age when character becomes an infant.")]
        [SettingPropertyGroup("Age Tweaks", GroupOrder = 0)]
        public int BecomeInfantAge { get; set; } = 0;

        [SettingPropertyInteger("Become Child Age", 0, 125, Order = 2, RequireRestart = false, HintText = "Age when character becomes a child.")]
        [SettingPropertyGroup("Age Tweaks", GroupOrder = 0)]
        public int BecomeChildAge { get; set; } = 3;

        [SettingPropertyInteger("Become Teenager Age", 0, 125, Order = 3, RequireRestart = false, HintText = "Age when character becomes a teenager.")]
        [SettingPropertyGroup("Age Tweaks", GroupOrder = 0)]
        public int BecomeTeenagerAge { get; set; } = 14;

        [SettingPropertyInteger("Hero Comes Of Age", 0, 125, Order = 4, RequireRestart = false, HintText = "Age when hero becomes an adult.")]
        [SettingPropertyGroup("Age Tweaks", GroupOrder = 0)]
        public int HeroComesOfAge { get; set; } = 18;

        [SettingPropertyInteger("Become Old Age", 0, 125, Order = 5, RequireRestart = false, HintText = "Age when character becomes old.")]
        [SettingPropertyGroup("Age Tweaks", GroupOrder = 0)]
        public int BecomeOldAge { get; set; } = 47;

        [SettingPropertyInteger("Max Age", 0, 200, Order = 6, RequireRestart = false, HintText = "Maximum age for characters.")]
        [SettingPropertyGroup("Age Tweaks", GroupOrder = 0)]
        public int MaxAge { get; set; } = 128;

        #endregion

        #region Item Tweaks

        [SettingPropertyBool("Enable Item Tweaks", Order = 0, RequireRestart = false, HintText = "Enable or disable item-related tweaks.")]
        [SettingPropertyGroup("Item Tweaks", GroupOrder = 1)]
        public bool EnableItemTweaks { get; set; } = false;

        [SettingPropertyFloatingInteger("Armor Weight Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiplier for armor weight.")]
        [SettingPropertyGroup("Item Tweaks", GroupOrder = 1)]
        public float ArmorWeightMultiplier { get; set; } = 1.0f;

        [SettingPropertyFloatingInteger("Armor Price Multiplier", 0.1f, 10f, Order = 2, RequireRestart = false, HintText = "Multiplier for armor price.")]
        [SettingPropertyGroup("Item Tweaks", GroupOrder = 1)]
        public float ArmorPriceMultiplier { get; set; } = 1.0f;

        [SettingPropertyFloatingInteger("Weapon Weight Multiplier", 0.1f, 10f, Order = 3, RequireRestart = false, HintText = "Multiplier for weapon weight.")]
        [SettingPropertyGroup("Item Tweaks", GroupOrder = 1)]
        public float WeaponWeightMultiplier { get; set; } = 1.0f;

        [SettingPropertyFloatingInteger("Weapon Price Multiplier", 0.1f, 10f, Order = 4, RequireRestart = false, HintText = "Multiplier for weapon price.")]
        [SettingPropertyGroup("Item Tweaks", GroupOrder = 1)]
        public float WeaponPriceMultiplier { get; set; } = 1.0f;

        #endregion

        #region Battle Rewards Tweaks

        [SettingPropertyBool("Enable Battle Rewards Tweaks", Order = 0, RequireRestart = false, HintText = "Enable or disable battle rewards tweaks.")]
        [SettingPropertyGroup("Battle Rewards", GroupOrder = 2)]
        public bool EnableBattleRewardsTweaks { get; set; } = false;

        [SettingPropertyFloatingInteger("Renown Gain Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiplier for renown gained after battles.")]
        [SettingPropertyGroup("Battle Rewards", GroupOrder = 2)]
        public float RenownGainMultiplier { get; set; } = 1.0f;

        [SettingPropertyFloatingInteger("Influence Gain Multiplier", 0.1f, 10f, Order = 2, RequireRestart = false, HintText = "Multiplier for influence gained after battles.")]
        [SettingPropertyGroup("Battle Rewards", GroupOrder = 2)]
        public float InfluenceGainMultiplier { get; set; } = 1.0f;

        [SettingPropertyFloatingInteger("Morale Gain Multiplier", 0.1f, 10f, Order = 3, RequireRestart = false, HintText = "Multiplier for morale gained after battles.")]
        [SettingPropertyGroup("Battle Rewards", GroupOrder = 2)]
        public float MoraleGainMultiplier { get; set; } = 1.0f;

        #endregion

        #region Battle Tweaks

        [SettingPropertyBool("Enable Battle Tweaks", Order = 0, RequireRestart = false, HintText = "Enable or disable battle-related tweaks.")]
        [SettingPropertyGroup("Battle Tweaks", GroupOrder = 3)]
        public bool EnableBattleTweaks { get; set; } = false;

        [SettingPropertyInteger("Battle Size", 50, 2000, Order = 1, RequireRestart = false, HintText = "Maximum number of troops in battle at once.")]
        [SettingPropertyGroup("Battle Tweaks", GroupOrder = 3)]
        public int BattleSize { get; set; } = 500;

        [SettingPropertyFloatingInteger("Battle Morale Multiplier", 0.1f, 10f, Order = 2, RequireRestart = false, HintText = "Multiplier for battle morale effects.")]
        [SettingPropertyGroup("Battle Tweaks", GroupOrder = 3)]
        public float BattleMoraleMultiplier { get; set; } = 1.0f;

        [SettingPropertyInteger("Hideout Troop Limit", 5, 100, Order = 3, RequireRestart = false, HintText = "Maximum troops you can bring to hideout battles.")]
        [SettingPropertyGroup("Battle Tweaks", GroupOrder = 3)]
        public int HideoutTroopLimit { get; set; } = 10;

        [SettingPropertyBool("Continue Battle On Player Death", Order = 4, RequireRestart = false, HintText = "Allow battle to continue after player death.")]
        [SettingPropertyGroup("Battle Tweaks", GroupOrder = 3)]
        public bool ContinueBattleOnPlayerDeath { get; set; } = false;

        [SettingPropertyFloatingInteger("Troop Experience Multiplier", 0.1f, 10f, Order = 5, RequireRestart = false, HintText = "Multiplier for troop experience gained in battles.")]
        [SettingPropertyGroup("Battle Tweaks", GroupOrder = 3)]
        public float TroopExperienceMultiplier { get; set; } = 1.0f;

        #endregion

        #region Campaign & Map Tweaks

        [SettingPropertyBool("Enable Campaign Tweaks", Order = 0, RequireRestart = false, HintText = "Enable or disable campaign and map tweaks.")]
        [SettingPropertyGroup("Campaign & Map", GroupOrder = 4)]
        public bool EnableCampaignTweaks { get; set; } = false;

        [SettingPropertyFloatingInteger("Player Map Speed Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiplier for player party movement speed on map.")]
        [SettingPropertyGroup("Campaign & Map", GroupOrder = 4)]
        public float PlayerMapSpeedMultiplier { get; set; } = 1.0f;

        [SettingPropertyFloatingInteger("Player Damage Multiplier", 0.1f, 10f, Order = 2, RequireRestart = false, HintText = "Multiplier for damage dealt by player.")]
        [SettingPropertyGroup("Campaign & Map", GroupOrder = 4)]
        public float PlayerDamageMultiplier { get; set; } = 1.0f;

        [SettingPropertyFloatingInteger("Player Troop Damage Multiplier", 0.1f, 10f, Order = 3, RequireRestart = false, HintText = "Multiplier for damage dealt by player's troops.")]
        [SettingPropertyGroup("Campaign & Map", GroupOrder = 4)]
        public float PlayerTroopDamageMultiplier { get; set; } = 1.0f;

        #endregion

        #region Clan & Party Tweaks

        [SettingPropertyBool("Enable Clan & Party Tweaks", Order = 0, RequireRestart = false, HintText = "Enable or disable clan and party tweaks.")]
        [SettingPropertyGroup("Clan & Party", GroupOrder = 5)]
        public bool EnableClanTweaks { get; set; } = false;

        [SettingPropertyInteger("Party Size Limit", 1, 10000, Order = 1, RequireRestart = false, HintText = "Maximum party size for player.")]
        [SettingPropertyGroup("Clan & Party", GroupOrder = 5)]
        public int PartySizeLimit { get; set; } = 200;

        [SettingPropertyInteger("Companion Limit", 0, 100, Order = 2, RequireRestart = false, HintText = "Maximum number of companions.")]
        [SettingPropertyGroup("Clan & Party", GroupOrder = 5)]
        public int CompanionLimit { get; set; } = 8;

        [SettingPropertyBool("Unlimited Wanderers", Order = 3, RequireRestart = false, HintText = "Enable unlimited wanderers in taverns.")]
        [SettingPropertyGroup("Clan & Party", GroupOrder = 5)]
        public bool UnlimitedWanderers { get; set; } = false;

        #endregion

        #region Workshop Tweaks

        [SettingPropertyBool("Enable Workshop Tweaks", Order = 0, RequireRestart = false, HintText = "Enable or disable workshop tweaks.")]
        [SettingPropertyGroup("Workshop Tweaks", GroupOrder = 6)]
        public bool EnableWorkshopTweaks { get; set; } = false;

        [SettingPropertyInteger("Workshop Limit", 1, 50, Order = 1, RequireRestart = false, HintText = "Maximum number of workshops player can own.")]
        [SettingPropertyGroup("Workshop Tweaks", GroupOrder = 6)]
        public int WorkshopLimit { get; set; } = 3;

        [SettingPropertyFloatingInteger("Workshop Bankruptcy Threshold", 0.0f, 1.0f, Order = 2, RequireRestart = false, HintText = "Threshold for workshop bankruptcy (0 = never bankrupt, 1 = normal).")]
        [SettingPropertyGroup("Workshop Tweaks", GroupOrder = 6)]
        public float WorkshopBankruptcyThreshold { get; set; } = 1.0f;

        #endregion

        #region Character Development Tweaks

        [SettingPropertyBool("Enable Character Development Tweaks", Order = 0, RequireRestart = false, HintText = "Enable or disable character development tweaks.")]
        [SettingPropertyGroup("Character Development", GroupOrder = 7)]
        public bool EnableCharacterDevelopmentTweaks { get; set; } = false;

        [SettingPropertyInteger("Levels Per Attribute Point", 1, 10, Order = 1, RequireRestart = false, HintText = "Number of levels needed per attribute point.")]
        [SettingPropertyGroup("Character Development", GroupOrder = 7)]
        public int LevelsPerAttributePoint { get; set; } = 4;

        [SettingPropertyInteger("Focus Points Per Level", 1, 10, Order = 2, RequireRestart = false, HintText = "Number of focus points gained per level.")]
        [SettingPropertyGroup("Character Development", GroupOrder = 7)]
        public int FocusPointsPerLevel { get; set; } = 1;

        #endregion

        #region Pregnancy & Family Tweaks

        [SettingPropertyBool("Enable Pregnancy Tweaks", Order = 0, RequireRestart = false, HintText = "Enable or disable pregnancy and family tweaks.")]
        [SettingPropertyGroup("Pregnancy & Family", GroupOrder = 8)]
        public bool EnablePregnancyTweaks { get; set; } = false;

        [SettingPropertyInteger("Pregnancy Duration (Days)", 1, 365, Order = 1, RequireRestart = false, HintText = "Duration of pregnancy in days.")]
        [SettingPropertyGroup("Pregnancy & Family", GroupOrder = 8)]
        public int PregnancyDuration { get; set; } = 36;

        [SettingPropertyFloatingInteger("Labor Death Chance", 0.0f, 1.0f, Order = 2, RequireRestart = false, HintText = "Chance of death during labor (0 = never, 1 = always).")]
        [SettingPropertyGroup("Pregnancy & Family", GroupOrder = 8)]
        public float LaborDeathChance { get; set; } = 0.015f;

        [SettingPropertyFloatingInteger("Stillbirth Chance", 0.0f, 1.0f, Order = 3, RequireRestart = false, HintText = "Chance of stillbirth (0 = never, 1 = always).")]
        [SettingPropertyGroup("Pregnancy & Family", GroupOrder = 8)]
        public float StillbirthChance { get; set; } = 0.01f;

        [SettingPropertyFloatingInteger("Female Offspring Chance", 0.0f, 1.0f, Order = 4, RequireRestart = false, HintText = "Chance of female offspring (0.5 = equal chance).")]
        [SettingPropertyGroup("Pregnancy & Family", GroupOrder = 8)]
        public float FemaleOffspringChance { get; set; } = 0.5f;

        [SettingPropertyFloatingInteger("Twin Chance", 0.0f, 1.0f, Order = 5, RequireRestart = false, HintText = "Chance of twins (0 = never, 1 = always).")]
        [SettingPropertyGroup("Pregnancy & Family", GroupOrder = 8)]
        public float TwinChance { get; set; } = 0.03f;

        #endregion

        #region Crafting Tweaks

        [SettingPropertyBool("Enable Crafting Tweaks", Order = 0, RequireRestart = false, HintText = "Enable or disable crafting tweaks.")]
        [SettingPropertyGroup("Crafting Tweaks", GroupOrder = 9)]
        public bool EnableCraftingTweaks { get; set; } = false;

        [SettingPropertyFloatingInteger("Crafting XP Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiplier for XP gained from crafting.")]
        [SettingPropertyGroup("Crafting Tweaks", GroupOrder = 9)]
        public float CraftingXpMultiplier { get; set; } = 1.0f;

        [SettingPropertyFloatingInteger("Smelting XP Multiplier", 0.1f, 10f, Order = 2, RequireRestart = false, HintText = "Multiplier for XP gained from smelting.")]
        [SettingPropertyGroup("Crafting Tweaks", GroupOrder = 9)]
        public float SmeltingXpMultiplier { get; set; } = 1.0f;

        [SettingPropertyFloatingInteger("Refining XP Multiplier", 0.1f, 10f, Order = 3, RequireRestart = false, HintText = "Multiplier for XP gained from refining.")]
        [SettingPropertyGroup("Crafting Tweaks", GroupOrder = 9)]
        public float RefiningXpMultiplier { get; set; } = 1.0f;

        #endregion

        #region Skill, XP, and Learning Tweaks

        [SettingPropertyBool("Enable Skill & Learning Tweaks", Order = 0, RequireRestart = false, HintText = "Enable or disable skill and learning tweaks.")]
        [SettingPropertyGroup("Skill & Learning", GroupOrder = 10)]
        public bool EnableSkillTweaks { get; set; } = false;

        [SettingPropertyFloatingInteger("Global XP Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Global multiplier for all XP gained.")]
        [SettingPropertyGroup("Skill & Learning", GroupOrder = 10)]
        public float GlobalXpMultiplier { get; set; } = 1.0f;

        [SettingPropertyFloatingInteger("Learning Rate Multiplier", 0.1f, 10f, Order = 2, RequireRestart = false, HintText = "Multiplier for skill learning rate.")]
        [SettingPropertyGroup("Skill & Learning", GroupOrder = 10)]
        public float LearningRateMultiplier { get; set; } = 1.0f;

        [SettingPropertyInteger("Skill Learning Limit", 1, 1023, Order = 3, RequireRestart = false, HintText = "Maximum skill level that can be reached.")]
        [SettingPropertyGroup("Skill & Learning", GroupOrder = 10)]
        public int SkillLearningLimit { get; set; } = 330;

        #endregion

        #region Naval & WarSail DLC Tweaks

        [SettingPropertyBool("Enable Naval Combat Tweaks", Order = 0, RequireRestart = false, HintText = "Enable or disable naval combat tweaks (requires WarSail DLC).")]
        [SettingPropertyGroup("Naval Combat (WarSail)", GroupOrder = 11)]
        public bool EnableNavalCombatTweaks { get; set; } = false;

        [SettingPropertyFloatingInteger("Ship Speed Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiplier for ship movement speed.")]
        [SettingPropertyGroup("Naval Combat (WarSail)", GroupOrder = 11)]
        public float ShipSpeedMultiplier { get; set; } = 1.0f;

        [SettingPropertyFloatingInteger("Naval Battle Size Multiplier", 0.1f, 5f, Order = 2, RequireRestart = false, HintText = "Multiplier for number of ships in naval battles.")]
        [SettingPropertyGroup("Naval Combat (WarSail)", GroupOrder = 11)]
        public float NavalBattleSizeMultiplier { get; set; } = 1.0f;

        [SettingPropertyFloatingInteger("Ship Durability Multiplier", 0.1f, 10f, Order = 3, RequireRestart = false, HintText = "Multiplier for ship hull durability.")]
        [SettingPropertyGroup("Naval Combat (WarSail)", GroupOrder = 11)]
        public float ShipDurabilityMultiplier { get; set; } = 1.0f;

        [SettingPropertyFloatingInteger("Naval XP Multiplier", 0.1f, 10f, Order = 4, RequireRestart = false, HintText = "Multiplier for XP gained from naval skills.")]
        [SettingPropertyGroup("Naval Combat (WarSail)", GroupOrder = 11)]
        public float NavalXpMultiplier { get; set; } = 1.0f;

        [SettingPropertyInteger("Fleet Size Limit", 1, 100, Order = 5, RequireRestart = false, HintText = "Maximum number of ships in player's fleet.")]
        [SettingPropertyGroup("Naval Combat (WarSail)", GroupOrder = 11)]
        public int FleetSizeLimit { get; set; } = 20;

        [SettingPropertyFloatingInteger("Ship Cost Multiplier", 0.1f, 10f, Order = 6, RequireRestart = false, HintText = "Multiplier for ship purchase and maintenance costs.")]
        [SettingPropertyGroup("Naval Combat (WarSail)", GroupOrder = 11)]
        public float ShipCostMultiplier { get; set; } = 1.0f;

        [SettingPropertyBool("Enable Port Blockade Tweaks", Order = 7, RequireRestart = false, HintText = "Enable tweaks for port siege/blockade mechanics.")]
        [SettingPropertyGroup("Naval Combat (WarSail)", GroupOrder = 11)]
        public bool EnablePortBlockadeTweaks { get; set; } = false;

        [SettingPropertyFloatingInteger("Port Trade Bonus Multiplier", 0.1f, 10f, Order = 8, RequireRestart = false, HintText = "Multiplier for trade bonuses at ports.")]
        [SettingPropertyGroup("Naval Combat (WarSail)", GroupOrder = 11)]
        public float PortTradeBonusMultiplier { get; set; } = 1.0f;

        [SettingPropertyFloatingInteger("Nord Faction Troop Multiplier", 0.1f, 10f, Order = 9, RequireRestart = false, HintText = "Multiplier for Nord faction troop strength.")]
        [SettingPropertyGroup("Naval Combat (WarSail)", GroupOrder = 11)]
        public float NordFactionTroopMultiplier { get; set; } = 1.0f;

        #endregion

        #region Other Features

        [SettingPropertyBool("Auto-Lock Items", Order = 0, RequireRestart = false, HintText = "Automatically lock equipped items to prevent selling.")]
        [SettingPropertyGroup("Other Features", GroupOrder = 12)]
        public bool AutoLockItems { get; set; } = false;

        #endregion
    }
}
