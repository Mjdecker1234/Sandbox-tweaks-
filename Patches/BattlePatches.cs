using HarmonyLib;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.Core;
using SandboxTweaks.Settings;

namespace SandboxTweaks.Patches
{
    [HarmonyPatch(typeof(DefaultCombatXpModel), "GetXpFromHit")]
    public class CombatXpPatch
    {
        static void Postfix(ref int __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableBattleTweaks == true)
            {
                __result = (int)(__result * settings.TroopExperienceMultiplier);
            }
        }
    }

    [HarmonyPatch(typeof(DefaultBattleRewardModel), "CalculateRenownGain")]
    public class RenownGainPatch
    {
        static void Postfix(ref float __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableBattleRewardsTweaks == true)
            {
                __result *= settings.RenownGainMultiplier;
            }
        }
    }

    [HarmonyPatch(typeof(DefaultBattleRewardModel), "CalculateInfluenceGain")]
    public class InfluenceGainPatch
    {
        static void Postfix(ref float __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableBattleRewardsTweaks == true)
            {
                __result *= settings.InfluenceGainMultiplier;
            }
        }
    }
}
