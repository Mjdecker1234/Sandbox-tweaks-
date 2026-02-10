using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.GameComponents;
using SandboxTweaks.Settings;

namespace SandboxTweaks.Patches
{
    [HarmonyPatch(typeof(DefaultAgeModel), "BecomeInfantAge", MethodType.Getter)]
    public class BecomeInfantAgePatch
    {
        static bool Prefix(ref int __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableAgeTweaks == true)
            {
                __result = settings.BecomeInfantAge;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(DefaultAgeModel), "BecomeChildAge", MethodType.Getter)]
    public class BecomeChildAgePatch
    {
        static bool Prefix(ref int __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableAgeTweaks == true)
            {
                __result = settings.BecomeChildAge;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(DefaultAgeModel), "BecomeTeenagerAge", MethodType.Getter)]
    public class BecomeTeenagerAgePatch
    {
        static bool Prefix(ref int __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableAgeTweaks == true)
            {
                __result = settings.BecomeTeenagerAge;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(DefaultAgeModel), "HeroComesOfAge", MethodType.Getter)]
    public class HeroComesOfAgePatch
    {
        static bool Prefix(ref int __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableAgeTweaks == true)
            {
                __result = settings.HeroComesOfAge;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(DefaultAgeModel), "BecomeOldAge", MethodType.Getter)]
    public class BecomeOldAgePatch
    {
        static bool Prefix(ref int __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableAgeTweaks == true)
            {
                __result = settings.BecomeOldAge;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(DefaultAgeModel), "MaxAge", MethodType.Getter)]
    public class MaxAgePatch
    {
        static bool Prefix(ref int __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableAgeTweaks == true)
            {
                __result = settings.MaxAge;
                return false;
            }
            return true;
        }
    }
}
