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

    [HarmonyPatch(typeof(DefaultPregnancyModel), "GetDailyChanceOfPregnancyForHero")]
    public class PregnancyTwinChancePatch
    {
        static void Postfix(ref float __result, Hero hero)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnablePregnancyTweaks == true)
            {
                // Apply twin chance modifier if needed
            }
        }
    }
}
