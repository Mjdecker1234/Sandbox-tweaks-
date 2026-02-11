# Sandbox Tweaks - Installation and Configuration Guide

## System Requirements

- Mount & Blade II: Bannerlord (Latest version recommended)
- .NET Framework 4.7.2 or higher
- Windows 7 SP1 or higher, or compatible operating system

## Required Dependencies

Before installing Sandbox Tweaks, you **must** install these dependencies in the following order:

### 1. Harmony (v2.2.2 or higher)
- **Download**: [Harmony on Nexus Mods](https://www.nexusmods.com/mountandblade2bannerlord/mods/2006)
- **Description**: Framework that allows mods to patch game code at runtime
- **Installation**: Extract to `Bannerlord/Modules/Harmony`

### 2. ButterLib (Latest version)
- **Download**: [ButterLib on Nexus Mods](https://www.nexusmods.com/mountandblade2bannerlord/mods/2018)
- **Description**: Library that provides common utilities for Bannerlord mods
- **Installation**: Extract to `Bannerlord/Modules/Bannerlord.ButterLib`

### 3. Mod Configuration Menu (MCM) (v5.9.1 or higher)
- **Download**: [MCM on Nexus Mods](https://www.nexusmods.com/mountandblade2bannerlord/mods/612)
- **Description**: Provides in-game menu for configuring mod settings
- **Installation**: Extract to `Bannerlord/Modules/Bannerlord.MBOptionScreen`

## Installation Steps

### Manual Installation

1. **Download Sandbox Tweaks**
   - Download the latest release from GitHub or Nexus Mods
   - Extract the archive to a temporary location

2. **Locate Your Bannerlord Installation**
   - Default Steam location: `C:\Program Files (x86)\Steam\steamapps\common\Mount & Blade II Bannerlord`
   - Default Epic Games location: `C:\Program Files\Epic Games\Mount & Blade II Bannerlord`

3. **Copy Mod Files**
   - Copy the `SandboxTweaks` folder to `Bannerlord/Modules/`
   - Your final path should be: `Bannerlord/Modules/SandboxTweaks/`

4. **Enable the Mod**
   - Launch Mount & Blade II: Bannerlord
   - Click "Mods" from the main menu
   - Find "Sandbox Tweaks" in the mod list
   - Check the box to enable it
   - **IMPORTANT**: Ensure the mod load order is:
     1. Harmony
     2. ButterLib
     3. MCM (MBOptionScreen)
     4. Native
     5. SandBoxCore
     6. Sandbox
     7. StoryMode (optional)
     8. **Sandbox Tweaks** ← Should load after the above mods

5. **Apply Changes**
   - Click "Play" to start the game

### Vortex Installation (Nexus Mod Manager)

1. Download Sandbox Tweaks via Vortex
2. Let Vortex install the mod automatically
3. Ensure dependencies are installed
4. Adjust load order if necessary (see step 4 in Manual Installation)

## Configuration

### Accessing Settings

1. **In Main Menu**:
   - Launch Bannerlord
   - Click "Mods" 
   - Select "Sandbox Tweaks"
   - Click "Settings" (if available in launcher)

2. **In-Game** (Recommended):
   - Start or load a campaign
   - Press `ESC` to open the menu
   - Select "Mod Options"
   - Click "Sandbox Tweaks"

### Configuring Settings

All settings are organized into categories:

#### Age Tweaks
- Enable/disable the entire category with the toggle at the top
- Adjust individual age thresholds
- Changes apply to new characters and age transitions

#### Item Tweaks
- Modify weight and price multipliers
- Affects all existing and new items
- Changes take effect immediately

#### Battle Settings
- Adjust battle size (50-2000 troops)
- Modify experience and morale multipliers
- Changes apply to next battle

#### Campaign Settings
- Modify map movement speed
- Adjust damage multipliers for player and troops
- Takes effect immediately

#### Naval Settings (WarSail DLC Required)
- Configure ship-related settings
- Only functional if WarSail DLC is installed
- Safe to configure even without DLC

### Recommended Settings

For a **vanilla-like experience**:
- Keep all multipliers at 1.0
- Keep age settings at default values
- Enable only quality-of-life features like auto-lock items

For **faster progression**:
- Increase XP multipliers (1.5x - 3x)
- Increase renown and influence gains (1.5x - 2x)
- Consider increasing party size limits

For **harder difficulty**:
- Decrease XP multipliers (0.5x - 0.8x)
- Decrease damage multipliers for player (0.8x)
- Increase damage received (increase enemy strength through other means)

For **sandbox freedom**:
- Increase party size limits significantly
- Enable unlimited wanderers
- Increase workshop limits
- Increase companion limits

## Troubleshooting

### Mod doesn't appear in mod list
- Verify all files are in `Bannerlord/Modules/SandboxTweaks/`
- Check that `SubModule.xml` exists in the mod folder
- Ensure you have the latest version of the game

### Settings menu doesn't appear
- Verify MCM is installed and enabled
- Ensure MCM loads before Sandbox Tweaks
- Try restarting the game

### Some features don't work
- Check that the specific feature is enabled in settings
- Verify you have the latest version of dependencies
- Some features may require a new game or campaign restart

### Game crashes on startup
- Verify all dependencies are installed correctly
- Check mod load order (see Installation Steps)
- Disable Sandbox Tweaks temporarily to confirm it's the cause
- Check Bannerlord error logs in `Documents/Mount and Blade II Bannerlord/Crashes/`

### Naval features don't work
- Naval features require the WarSail DLC to be installed
- Ensure WarSail DLC is enabled in the mod menu
- Some naval features may be limited in current implementation

### Conflicts with other mods
- Check if other mods modify the same game mechanics
- Try disabling other mods one at a time to identify conflicts
- Adjust load order - Sandbox Tweaks should load after most gameplay mods

## Compatibility Notes

### Compatible With:
- Most texture and graphics mods
- Quest mods
- UI enhancement mods
- Map expansion mods
- Unit roster mods

### May Conflict With:
- Other tweak/cheat mods that modify similar values
- Mods that heavily modify game models (age, pregnancy, crafting, etc.)
- Other MCM-based configuration mods with overlapping features

### How to Handle Conflicts:
1. Try different load orders
2. Disable conflicting features in one of the mods
3. Choose one mod over the other for specific features
4. Report conflicts on mod page for potential compatibility patches

## Updating the Mod

1. **Before Updating**:
   - Note your current settings (take screenshots)
   - Backup your save games (optional but recommended)

2. **Update Process**:
   - Download the new version
   - Delete old `SandboxTweaks` folder
   - Install new version following installation steps
   - Launch game and reconfigure settings if needed

3. **After Updating**:
   - Verify mod loads correctly
   - Check settings menu
   - Test features you commonly use

## Uninstalling

1. Close Bannerlord completely
2. Delete the `SandboxTweaks` folder from `Bannerlord/Modules/`
3. Launch game and verify mod is no longer listed
4. Continue playing (saved games should work normally)

**Note**: Some changes made while the mod was active may persist in your save file (e.g., increased party size, modified item values). These values will remain until naturally changed by game events.

## Performance Tips

- Higher battle sizes (1000+) require good hardware
- Disable unused feature categories to minimize performance impact
- Large party sizes can slow down campaign map
- Adjust settings based on your system's capabilities

## Save Game Safety

- **Safe to add**: You can add Sandbox Tweaks to existing campaigns
- **Safe to remove**: Removing the mod shouldn't corrupt saves (but modified values may persist)
- **Settings per save**: Each campaign stores its own mod settings
- **Backup recommended**: Always good practice before modding

## Getting Help

If you encounter issues:

1. Check this guide thoroughly
2. Verify all dependencies are correctly installed
3. Check mod page for known issues
4. Review error logs in Bannerlord crash folder
5. Ask for help on mod page or Discord with:
   - Your game version
   - Your mod version
   - List of other installed mods
   - Detailed description of the issue
   - Error logs if available

## Credits and License

- Based on Kaoses Tweaks by Kaoses
- Uses Harmony, ButterLib, and MCM frameworks
- Created for the Bannerlord modding community

For more information, visit the mod page or GitHub repository.
