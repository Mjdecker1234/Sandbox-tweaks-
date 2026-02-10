using HarmonyLib;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using SandboxTweaks.Settings;

namespace SandboxTweaks.Patches
{
    [HarmonyPatch(typeof(DefaultCharacterDevelopmentModel), "CalculateLearningRate", new[] { typeof(Hero), typeof(SkillObject) })]
    public class LearningRatePatch
    {
        static void Postfix(ref float __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableSkillTweaks == true)
            {
                __result *= settings.LearningRateMultiplier;
            }
        }
    }

    [HarmonyPatch(typeof(DefaultCharacterDevelopmentModel), "GetMaxSkillPoint")]
    public class MaxSkillPointPatch
    {
        static void Postfix(ref int __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableSkillTweaks == true)
            {
                __result = settings.SkillLearningLimit;
            }
        }
    }

    [HarmonyPatch(typeof(DefaultCharacterDevelopmentModel), "LevelsPerAttributePoint", MethodType.Getter)]
    public class LevelsPerAttributePointPatch
    {
        static bool Prefix(ref int __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableCharacterDevelopmentTweaks == true)
            {
                __result = settings.LevelsPerAttributePoint;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(DefaultCharacterDevelopmentModel), "FocusPointsPerLevel", MethodType.Getter)]
    public class FocusPointsPerLevelPatch
    {
        static bool Prefix(ref int __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableCharacterDevelopmentTweaks == true)
            {
                __result = settings.FocusPointsPerLevel;
                return false;
            }
            return true;
        }
    }
}
