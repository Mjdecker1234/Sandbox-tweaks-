# CI Build Notes

## Overview

This repository is configured with GitHub Actions to automatically build the SandboxTweaks mod. However, there are important limitations to understand about CI builds for Mount & Blade II: Bannerlord mods.

## Build Configuration

### Output Path
The `.csproj` file is configured to output the compiled DLL directly to the correct Bannerlord mod folder structure:
- **Output Path**: `bin\Win64_Shipping_Client\`
- **Assembly Name**: `SandboxTweaks.dll`

This matches the structure expected by Bannerlord as specified in `SubModule.xml`.

### Reference Assemblies

The project uses `Bannerlord.ReferenceAssemblies` NuGet package for CI builds. This package provides stripped, metadata-only assemblies for the game's DLLs, allowing the project to compile without requiring a full Bannerlord installation.

**Important**: Reference assemblies are version-specific. The current configuration uses the latest available version, which may not exactly match the game version this mod was originally developed for.

## Known Limitations

### Namespace and API Changes

Bannerlord's API has evolved across versions. The reference assemblies may have:
- Different namespaces for game classes
- Modified or removed APIs
- Reorganized module structures

### Build Warnings in CI

The CI build may show warnings or errors such as:
- Missing namespaces (e.g., `TaleWorlds.CampaignSystem.SandBox.GameComponents`)
- Missing types or methods
- Assembly reference mismatches

**These are expected** when the reference assembly version doesn't exactly match the target game version.

## Recommended Build Process

### For Development
1. **Build locally** with the actual Bannerlord game installed
2. Set the `BANNERLORD_GAME_DIR` environment variable to your game installation path
3. Run `dotnet build` or build through Visual Studio

### For Distribution
1. Build locally with your target Bannerlord version installed
2. Test the mod thoroughly in-game
3. Create a GitHub Release with the compiled DLL
4. The CI workflow will automatically package the release

### For Contributors
If you're contributing to this mod:
1. Ensure you have Bannerlord installed
2. Follow the instructions in `BUILD.md`
3. CI checks will validate that the project structure is correct, even if the build doesn't succeed with reference assemblies

## CI Workflow Behavior

The GitHub Actions workflow (`.github/workflows/build.yml`):
- ✅ Always runs on push and pull requests
- ✅ Validates project configuration
- ✅ Attempts to build with reference assemblies
- ✅ Packages the mod structure (documentation, SubModule.xml, etc.)
- ⚠️  May not produce a working DLL if reference assembly versions don't match
- ✅ Provides build artifacts for manual verification

## Fixing Build Issues

If the CI build fails:

### 1. Namespace Issues
Update `using` statements to match the current Bannerlord API. Reference the game's DLLs to find correct namespaces.

### 2. API Changes
Check Bannerlord's changelog for API modifications. Update code to use current APIs or add compatibility layers.

### 3. Version Pinning
You can specify a specific version of `Bannerlord.ReferenceAssemblies` in the `.csproj`:
```xml
<PackageReference Include="Bannerlord.ReferenceAssemblies" Version="1.2.9.xxxxx" ... />
```
Replace `*` with the version matching your target game version.

## Project Structure

After a successful build, the mod folder should contain:

```
SandboxTweaks/
├── bin/
│   └── Win64_Shipping_Client/
│       └── SandboxTweaks.dll          ← The compiled mod DLL
├── ModuleData/                         ← Mod data files (currently empty)
├── SubModule.xml                       ← Mod manifest
├── README.md
├── CHANGELOG.md
├── INSTALLATION.md
├── LICENSE
├── FEATURES.md
└── BUILD.md
```

## Questions?

- For build issues: See `BUILD.md`
- For installation: See `INSTALLATION.md`
- For features: See `FEATURES.md`
- For code questions: Open an issue on GitHub

---

*Last Updated: 2026-02-11*
