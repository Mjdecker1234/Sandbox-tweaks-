# Changelog

All notable changes to the Sandbox Tweaks mod will be documented in this file.

## [1.0.0] - 2026-02-10

### Added
- Initial release of Sandbox Tweaks mod
- Complete implementation of all Kaoses Tweaks features (mod #2911):
  - Age Tweaks: Customizable age thresholds for all life stages
  - Item Tweaks: Weight and price multipliers for armor and weapons
  - Battle Rewards Tweaks: Renown, influence, and morale gain multipliers
  - Battle Tweaks: Battle size, morale effects, hideout limits, experience multipliers
  - Campaign & Map Tweaks: Movement speed and damage multipliers
  - Clan & Party Tweaks: Party size, companion limits, unlimited wanderers
  - Workshop Tweaks: Workshop count limits and bankruptcy settings
  - Character Development Tweaks: Attribute and focus point progression
  - Pregnancy & Family Tweaks: Pregnancy duration, mortality rates, offspring chances
  - Crafting Tweaks: XP multipliers for crafting, smelting, and refining
  - Skill & Learning Tweaks: Global XP multipliers and learning rates
  - Other Features: Auto-lock items

### Added - WarSail DLC Features
- Naval Combat Tweaks: Ship speed, battle size, and durability multipliers (settings ready, patches pending)
- Fleet Management: Fleet size limits and ship cost multipliers (settings ready, patches pending)
- Naval Skills: Naval XP multipliers for navigation and seafaring (settings ready, patches pending)
- Port Mechanics: Trade bonus and blockade system tweaks (settings ready, patches pending)
- Nord Faction: Troop strength multipliers for Nord units (settings ready, patches pending)
- **Note**: All WarSail settings are exposed in MCM; actual implementation will follow once DLC APIs are documented

### Technical
- Full MCM (Mod Configuration Menu) integration
- Harmony patches for runtime game modification
- Modular behavior system for campaign events
- Comprehensive settings system with per-feature toggles
- Safe for existing save games
- Compatible with most other mods

### Documentation
- Comprehensive README with feature list
- Detailed installation guide (INSTALLATION.md)
- Configuration recommendations for different playstyles
- Troubleshooting section

### Dependencies
- Harmony v2.2.2+
- ButterLib (latest)
- MCM v5.9.1+
- Bannerlord v1.0.0+ (latest version recommended)

## [Unreleased]

### Planned Features
- Additional naval combat tweaks as WarSail DLC features become better documented
- More granular control over hideout battle mechanics
- Siege equipment and construction tweaks
- Army cohesion tweaks
- Relationship gain/loss multipliers
- Trade and economy tweaks
- Kingdom management tweaks
- More detailed troop experience controls
- Custom troop recruitment settings
- Enhanced compatibility with popular mods

### Known Issues
- Naval patches are placeholders pending WarSail DLC class discovery (settings are functional but patches not yet applied)
- Pregnancy twin chance and female offspring settings are exposed but require complex birth event patching (pending implementation)
- Some damage multiplier patches may not apply to all combat scenarios
- Battle size changes may require game restart to fully apply

### Future Improvements
- Performance optimization for large battle sizes
- More intuitive MCM menu organization
- Preset configurations for different playstyles
- Export/import settings functionality
- Per-skill XP multipliers instead of global only
- More detailed battle statistics and feedback
