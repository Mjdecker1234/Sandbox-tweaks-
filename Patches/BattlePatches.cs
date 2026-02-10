using HarmonyLib;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.Core;
using TaleWorlds.Library;
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

    [HarmonyPatch(typeof(DefaultBattleMoraleModel), "GetEffectiveInitialMorale")]
    public class BattleMoralePatch
    {
        static void Postfix(ref float __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableBattleTweaks == true)
            {
                __result *= settings.BattleMoraleMultiplier;
            }
        }
    }

    // Battle size patch
    [HarmonyPatch]
    public class BattleSizePatch
    {
        static bool Prepare()
        {
            return SandboxTweaksSettings.Instance?.EnableBattleTweaks == true;
        }

        [HarmonyPatch(typeof(BannerlordConfig), "BattleSize", MethodType.Getter)]
        [HarmonyPostfix]
        static void BattleSizeGetter(ref int __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableBattleTweaks == true)
            {
                __result = settings.BattleSize;
            }
        }

        [HarmonyPatch(typeof(BannerlordConfig), "BattleSize", MethodType.Setter)]
        [HarmonyPrefix]
        static bool BattleSizeSetter(ref int value)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableBattleTweaks == true)
            {
                value = settings.BattleSize;
            }
            return true;
        }
    }
}

