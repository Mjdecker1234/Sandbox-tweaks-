# Sandbox Tweaks - Complete Feature List

## Overview
This document provides a comprehensive list of all features implemented in Sandbox Tweaks mod, organized by category. Each feature can be configured through the MCM (Mod Configuration Menu) in-game.

---

## 1. Age Tweaks
**Enable/Disable Toggle**: Yes  
**Description**: Customize character age thresholds and lifespans

### Settings
- **Become Infant Age** (0-125): Age when character is considered an infant
  - Default: 0
- **Become Child Age** (0-125): Age when character becomes a child
  - Default: 3
- **Become Teenager Age** (0-125): Age when character becomes a teenager
  - Default: 14
- **Hero Comes Of Age** (0-125): Age when hero becomes an adult
  - Default: 18
- **Become Old Age** (0-125): Age when character is considered old
  - Default: 47
- **Max Age** (0-200): Maximum age before natural death
  - Default: 128

### Implementation
- Patches `DefaultAgeModel` class methods
- Affects all NPCs and player character
- Changes apply to age transitions going forward

---

## 2. Item Tweaks
**Enable/Disable Toggle**: Yes  
**Description**: Adjust weight and price for all items

### Settings
- **Armor Weight Multiplier** (0.1x-10x): Multiplier for all armor weight
  - Default: 1.0x
  - Affects: Body armor, leg armor, head armor, hand armor, capes, horse harness
- **Armor Price Multiplier** (0.1x-10x): Multiplier for all armor prices
  - Default: 1.0x
- **Weapon Weight Multiplier** (0.1x-10x): Multiplier for all weapon weight
  - Default: 1.0x
  - Affects: Melee weapons, ranged weapons, ammunition, shields
- **Weapon Price Multiplier** (0.1x-10x): Multiplier for all weapon prices
  - Default: 1.0x

### Implementation
- Patches `ItemObject.Weight` and `ItemObject.Value` properties
- Applies to all existing and new items
- Changes take effect immediately

---

## 3. Battle Rewards Tweaks
**Enable/Disable Toggle**: Yes  
**Description**: Modify rewards gained from winning battles

### Settings
- **Renown Gain Multiplier** (0.1x-10x): Multiplier for renown after battles
  - Default: 1.0x
- **Influence Gain Multiplier** (0.1x-10x): Multiplier for influence rewards
  - Default: 1.0x
- **Morale Gain Multiplier** (0.1x-10x): Multiplier for morale gained
  - Default: 1.0x

### Implementation
- Patches `DefaultBattleRewardModel` methods
- Affects both player and AI parties
- Applied after each battle

---

## 4. Battle Tweaks
**Enable/Disable Toggle**: Yes  
**Description**: Comprehensive battle mechanics modifications

### Settings
- **Battle Size** (50-2000): Maximum troops on battlefield at once
  - Default: 500
  - Higher values require better hardware
- **Battle Morale Multiplier** (0.1x-10x): Affects morale effects in battle
  - Default: 1.0x
- **Hideout Troop Limit** (5-100): Maximum troops for hideout battles
  - Default: 10
- **Continue Battle On Player Death** (Yes/No): Allow battle to continue after player dies
  - Default: No
- **Troop Experience Multiplier** (0.1x-10x): XP gained by troops in battles
  - Default: 1.0x

### Implementation
- Patches `BannerlordConfig.BattleSize` for battle size
- Patches `DefaultCombatXpModel` for experience
- Patches `DefaultBattleMoraleModel` for morale
- Changes apply to next battle

---

## 5. Campaign & Map Tweaks
**Enable/Disable Toggle**: Yes  
**Description**: Modify campaign map behavior and combat

### Settings
- **Player Map Speed Multiplier** (0.1x-10x): Movement speed on campaign map
  - Default: 1.0x
  - Only affects player party
- **Player Damage Multiplier** (0.1x-10x): Damage dealt by player character
  - Default: 1.0x
- **Player Troop Damage Multiplier** (0.1x-10x): Damage dealt by player's troops
  - Default: 1.0x

### Implementation
- Patches `MobileParty.Speed` for movement
- Patches `Agent.RegisterBlow` for damage
- Changes apply immediately

---

## 6. Clan & Party Tweaks
**Enable/Disable Toggle**: Yes  
**Description**: Modify party and clan limitations

### Settings
- **Party Size Limit** (1-10,000): Maximum party size for player
  - Default: 200
  - Note: Very large parties may impact performance
- **Companion Limit** (0-100): Maximum number of companions
  - Default: 8
- **Unlimited Wanderers** (Yes/No): Unlimited wanderers in taverns
  - Default: No

### Implementation
- Patches `DefaultPartySizeLimitModel` for party size
- Patches `DefaultClanTier.GetCompanionLimit` for companions
- Affects player only by default

---

## 7. Workshop Tweaks
**Enable/Disable Toggle**: Yes  
**Description**: Modify workshop mechanics

### Settings
- **Workshop Limit** (1-50): Maximum workshops player can own
  - Default: 3
- **Workshop Bankruptcy Threshold** (0.0-1.0): Bankruptcy risk level
  - Default: 1.0 (normal)
  - Lower = less likely to go bankrupt

### Implementation
- Patches `DefaultWorkshopModel.GetMaxWorkshopCountForPlayer`
- Affects player workshops only

---

## 8. Character Development Tweaks
**Enable/Disable Toggle**: Yes  
**Description**: Customize character progression

### Settings
- **Levels Per Attribute Point** (1-10): Levels needed per attribute point
  - Default: 4
  - Lower = faster attribute gain
- **Focus Points Per Level** (1-10): Focus points gained each level
  - Default: 1
  - Higher = faster skill specialization

### Implementation
- Patches `DefaultCharacterDevelopmentModel` properties
- Affects player and NPCs
- Changes apply to future level-ups

---

## 9. Pregnancy & Family Tweaks
**Enable/Disable Toggle**: Yes  
**Description**: Modify pregnancy and birth mechanics

### Settings
- **Pregnancy Duration** (1-365 days): How long pregnancy lasts
  - Default: 36 days
- **Labor Death Chance** (0.0-1.0): Chance of death during labor
  - Default: 0.015 (1.5%)
- **Stillbirth Chance** (0.0-1.0): Chance of stillbirth
  - Default: 0.01 (1%)
- **Female Offspring Chance** (0.0-1.0): Probability of female child
  - Default: 0.5 (50%)
- **Twin Chance** (0.0-1.0): Probability of twins
  - Default: 0.03 (3%)

### Implementation
- Patches `DefaultPregnancyModel` methods
- Affects all characters in game
- Changes apply to new pregnancies

---

## 10. Crafting Tweaks
**Enable/Disable Toggle**: Yes  
**Description**: Modify crafting experience gains

### Settings
- **Crafting XP Multiplier** (0.1x-10x): XP from crafting items
  - Default: 1.0x
- **Smelting XP Multiplier** (0.1x-10x): XP from smelting items
  - Default: 1.0x
- **Refining XP Multiplier** (0.1x-10x): XP from refining materials
  - Default: 1.0x

### Implementation
- Patches `DefaultSmithingModel` XP methods
- Affects all smithing activities
- Changes apply immediately

---

## 11. Skill, XP, and Learning Tweaks
**Enable/Disable Toggle**: Yes  
**Description**: Global skill and learning modifications

### Settings
- **Global XP Multiplier** (0.1x-10x): Multiplier for all XP gained
  - Default: 1.0x
  - Applies to all skills
- **Learning Rate Multiplier** (0.1x-10x): How fast skills improve
  - Default: 1.0x
- **Skill Learning Limit** (1-1023): Maximum skill level
  - Default: 330
  - Game maximum is 1023

### Implementation
- Patches `DefaultCharacterDevelopmentModel` methods
- Affects all skill gains
- Changes apply immediately

---

## 12. Naval Combat Tweaks (WarSail DLC)
**Enable/Disable Toggle**: Yes  
**Description**: Modify naval warfare mechanics (requires WarSail DLC)  
**⚠️ STATUS**: Settings exposed, implementation pending WarSail DLC API documentation

### Settings
All naval settings are available in MCM menu but patches are placeholders pending WarSail DLC class discovery:

- **Ship Speed Multiplier** (0.1x-10x): Multiplier for ship movement
  - Default: 1.0x
  - Status: Placeholder
- **Naval Battle Size Multiplier** (0.1x-5x): Number of ships in naval battles
  - Default: 1.0x
  - Status: Placeholder
- **Ship Durability Multiplier** (0.1x-10x): Ship hull strength
  - Default: 1.0x
  - Status: Placeholder
- **Naval XP Multiplier** (0.1x-10x): XP from naval skills
  - Default: 1.0x
  - Status: Placeholder
- **Fleet Size Limit** (1-100): Maximum ships in fleet
  - Default: 20
  - Status: Placeholder
- **Ship Cost Multiplier** (0.1x-10x): Ship purchase/maintenance costs
  - Default: 1.0x
  - Status: Placeholder
- **Enable Port Blockade Tweaks** (Yes/No): Enable port siege modifications
  - Default: No
  - Status: Placeholder
- **Port Trade Bonus Multiplier** (0.1x-10x): Trade bonuses at ports
  - Default: 1.0x
  - Status: Placeholder
- **Nord Faction Troop Multiplier** (0.1x-10x): Nord troop strength
  - Default: 1.0x
  - Status: Placeholder

### Implementation
- Infrastructure is in place with `NavalPatches.cs`
- Settings are fully integrated in MCM menu
- Actual patches will be implemented when WarSail DLC APIs are documented
- Safe to configure settings even without DLC
- Framework ready for future implementation

### Note for Developers
When WarSail DLC is released and its classes are reverse-engineered:
1. Update `NavalPatches.cs` with actual class names
2. Implement Harmony patches using the settings already defined
3. Add DLC detection logic
4. Test thoroughly with DLC installed

---

## 13. Other Features
**Description**: Miscellaneous quality-of-life features

### Settings
- **Auto-Lock Items** (Yes/No): Automatically lock equipped items
  - Default: No
  - Prevents accidentally selling equipped gear

### Implementation
- Behavior-based implementation
- Works with inventory system

---

## Technical Details

### Mod Information
- **Mod ID**: SandboxTweaks
- **Version**: 1.0.0
- **MCM Compatible**: Yes
- **Harmony Patches**: 30+ patches
- **Behaviors**: 8 campaign behaviors

### Compatibility
- **Save Game Safe**: Yes (can add to existing saves)
- **Multiplayer**: No (singleplayer only)
- **DLC Support**: Optional WarSail DLC features

### Performance Notes
- Most features have minimal performance impact
- Battle size and party size significantly affect performance
- Naval features only active when WarSail DLC detected

### Configuration Storage
- Settings saved per campaign
- Located in game's configuration folder
- Can be reset to defaults via MCM

---

## Feature Request & Bug Reports

If you'd like to see additional features or find bugs:
1. Check existing issues on the mod page
2. Provide detailed description
3. Include game version and other mods used
4. Attach logs if available

---

## Credits

Based on **Kaoses Tweaks** (Nexus Mods #2911) by Kaoses  
Extended with WarSail DLC support  
Uses Harmony, ButterLib, and MCM frameworks

---

*Last Updated: 2026-02-10*
