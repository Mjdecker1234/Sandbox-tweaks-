using HarmonyLib;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem;
using SandboxTweaks.Settings;

namespace SandboxTweaks.Patches
{
    [HarmonyPatch(typeof(DefaultPregnancyModel), "PregnancyDurationInDays", MethodType.Getter)]
    public class PregnancyDurationPatch
    {
        static bool Prefix(ref float __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnablePregnancyTweaks == true)
            {
                __result = settings.PregnancyDuration;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(DefaultPregnancyModel), "MaternalMortalityProbabilityInLabor", MethodType.Getter)]
    public class MaternalMortalityPatch
    {
        static bool Prefix(ref float __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnablePregnancyTweaks == true)
            {
                __result = settings.LaborDeathChance;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(DefaultPregnancyModel), "StillbirthProbability", MethodType.Getter)]
    public class StillbirthProbabilityPatch
    {
        static bool Prefix(ref float __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnablePregnancyTweaks == true)
            {
                __result = settings.StillbirthChance;
                return false;
            }
            return true;
        }
    }

    // NOTE: Twin chance and female offspring chance are not directly patchable
    // through simple property patches in DefaultPregnancyModel.
    // These would require more complex patches to the pregnancy calculation logic
    // or birth event handlers. Implementation requires deeper game code analysis.
    
    // Placeholder for future twin chance implementation:
    // Would need to patch the actual birth event to generate twins based on TwinChance setting
    
    // Placeholder for female offspring implementation:
    // Would need to patch gender determination logic to use FemaleOffspringChance setting
}

