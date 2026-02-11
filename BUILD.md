# Building Sandbox Tweaks

## Prerequisites

### Required Software
1. **Visual Studio 2019 or 2022** (Community Edition or higher)
   - Workload: .NET desktop development
   - Component: .NET Framework 4.7.2 SDK
   
2. **Mount & Blade II: Bannerlord** (Installed)
   - Steam or Epic Games version
   - Latest version recommended

3. **Git** (Optional, for cloning repository)

### Required Environment Variables

Set the `BANNERLORD_GAME_DIR` environment variable to your Bannerlord installation path:

**Windows (PowerShell):**
```powershell
[Environment]::SetEnvironmentVariable("BANNERLORD_GAME_DIR", "C:\Program Files (x86)\Steam\steamapps\common\Mount & Blade II Bannerlord", "User")
```

**Windows (Command Prompt):**
```cmd
setx BANNERLORD_GAME_DIR "C:\Program Files (x86)\Steam\steamapps\common\Mount & Blade II Bannerlord"
```

**Alternative**: Edit `SandboxTweaks.csproj` and update the `<GameFolder>` path directly.

---

## Build Steps

### Using Visual Studio

1. **Open the Project**
   ```
   Open SandboxTweaks.csproj in Visual Studio
   ```

2. **Restore NuGet Packages**
   - Visual Studio should automatically restore packages
   - Or manually: `Tools > NuGet Package Manager > Restore NuGet Packages`

3. **Build the Project**
   - Select `Release` configuration (recommended for distribution)
   - Platform: `x64`
   - Build > Build Solution (or press `Ctrl+Shift+B`)

4. **Output Location**
   - Compiled DLL: `bin/Release/net472/SandboxTweaks.dll`
   - Copy to: `[Bannerlord]/Modules/SandboxTweaks/bin/Win64_Shipping_Client/`

### Using Command Line (MSBuild)

1. **Open Developer Command Prompt**
   - Start > Visual Studio 2022 > Developer Command Prompt

2. **Navigate to Project Directory**
   ```cmd
   cd path\to\Sandbox-tweaks-
   ```

3. **Restore NuGet Packages**
   ```cmd
   nuget restore SandboxTweaks.csproj
   ```

4. **Build the Project**
   ```cmd
   msbuild SandboxTweaks.csproj /p:Configuration=Release /p:Platform=x64
   ```

5. **Copy Output**
   ```cmd
   copy bin\Release\net472\SandboxTweaks.dll bin\Win64_Shipping_Client\
   ```

### Using dotnet CLI (if SDK is installed)

1. **Build**
   ```bash
   dotnet build SandboxTweaks.csproj -c Release
   ```

2. **Copy Output**
   ```bash
   cp bin/Release/net472/SandboxTweaks.dll bin/Win64_Shipping_Client/
   ```

---

## Installation for Testing

After building:

1. **Copy Mod to Bannerlord Modules**
   ```
   Copy entire SandboxTweaks folder to:
   [Bannerlord]/Modules/SandboxTweaks/
   ```

2. **Ensure Folder Structure**
   ```
   Mount & Blade II Bannerlord/
   └── Modules/
       └── SandboxTweaks/
           ├── bin/
           │   └── Win64_Shipping_Client/
           │       └── SandboxTweaks.dll
           ├── ModuleData/
           ├── SubModule.xml
           └── (other files)
   ```

3. **Enable in Launcher**
   - Launch Bannerlord
   - Go to Mods
   - Enable "Sandbox Tweaks"
   - Ensure proper load order (after Harmony, ButterLib, MCM)

---

## Troubleshooting Build Issues

### Missing References
**Error**: Cannot find TaleWorlds assemblies

**Solution**: 
- Verify `BANNERLORD_GAME_DIR` is set correctly
- Check that Bannerlord is installed
- Ensure path in `.csproj` matches your installation

### NuGet Package Errors
**Error**: Cannot restore NuGet packages

**Solution**:
- Check internet connection
- Update NuGet Package Manager
- Try deleting `packages` folder and restoring again

### .NET Framework Version
**Error**: .NET Framework 4.7.2 not found

**Solution**:
- Install .NET Framework 4.7.2 Developer Pack
- Download from: https://dotnet.microsoft.com/download/dotnet-framework

### Harmony or MCM Version Mismatch
**Error**: Assembly version conflicts

**Solution**:
- Update NuGet packages to latest versions
- Check `SandboxTweaks.csproj` for version specifications
- Ensure installed mods match referenced versions

---

## Building for Distribution

### Release Build Checklist

1. **Update Version Numbers**
   - [ ] `SubModule.xml` - `<Version>` tag
   - [ ] `CHANGELOG.md` - Add release notes
   - [ ] `SandboxTweaks.csproj` - `<Version>` property

2. **Clean Build**
   ```cmd
   msbuild /t:Clean
   msbuild /t:Rebuild /p:Configuration=Release
   ```

3. **Test the Mod**
   - [ ] Load in Bannerlord launcher
   - [ ] Start a campaign
   - [ ] Open MCM settings
   - [ ] Test key features
   - [ ] Check for errors in logs

4. **Prepare Distribution Package**
   ```
   SandboxTweaks/
   ├── bin/
   │   └── Win64_Shipping_Client/
   │       └── SandboxTweaks.dll
   ├── ModuleData/
   ├── SubModule.xml
   ├── README.md
   ├── CHANGELOG.md
   ├── INSTALLATION.md
   ├── LICENSE
   └── FEATURES.md
   ```

5. **Create Archive**
   - Zip the `SandboxTweaks` folder
   - Name: `SandboxTweaks-v1.0.0.zip`
   - Exclude: `.git`, `obj`, `.vs`, source code files (optional)

6. **Upload**
   - Nexus Mods
   - GitHub Releases
   - Other mod hosting platforms

---

## Development Tips

### Hot Reload (Limited)
- Some changes can be tested without full game restart
- Harmony patches apply on mod load
- MCM settings changes are immediate
- Code changes require rebuild and game restart

### Debugging
1. Set Visual Studio to attach to `Bannerlord.exe`
2. Set breakpoints in your code
3. Launch game through Visual Studio debugger
4. Note: Some debugging may not work due to game's anti-cheat/protection

### Logging
- Use `Console.WriteLine()` for debug output
- Check Bannerlord logs: `Documents/Mount and Blade II Bannerlord/`
- Consider adding proper logging framework for production

### Testing Individual Features
- Create test campaigns for different scenarios
- Use MCM to toggle features on/off
- Test with and without other mods
- Verify save game compatibility

---

## Continuous Integration

This repository includes a GitHub Actions workflow (`.github/workflows/build.yml`) that:
1. Checks out code
2. Restores NuGet packages (including Bannerlord.ReferenceAssemblies)
3. Builds the project in Release configuration
4. Packages the mod structure
5. Creates release artifacts

### CI Build Limitations

The CI build uses `Bannerlord.ReferenceAssemblies` NuGet package, which provides metadata-only versions of the game DLLs. This allows compilation without a full game installation, but:

- **Version Mismatches**: Reference assemblies may not exactly match your target game version
- **Namespace Changes**: Game API namespaces may differ between versions
- **Build Warnings**: Some errors/warnings are expected and don't indicate problems with the project structure

**For production builds**, always build locally with the actual game installed. See `CI_BUILD_NOTES.md` for detailed information about CI builds and their limitations.

---

## Contributing

If you're building to contribute:

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Test thoroughly
5. Submit a pull request with:
   - Description of changes
   - Testing performed
   - Any breaking changes noted

---

## License

See [LICENSE](LICENSE) file for details.

---

## Support

For build issues:
- Check this guide thoroughly
- Review error messages carefully
- Search existing issues
- Ask in modding community forums
- Create an issue on GitHub with:
  - Visual Studio version
  - .NET Framework version
  - Bannerlord version
  - Full error message
  - Steps to reproduce

---

*Last Updated: 2026-02-10*
