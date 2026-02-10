using HarmonyLib;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.Core;
using SandboxTweaks.Settings;

namespace SandboxTweaks.Patches
{
    [HarmonyPatch(typeof(DefaultSmithingModel), "GetSkillXpForRefining")]
    public class RefiningXpPatch
    {
        static void Postfix(ref int __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableCraftingTweaks == true)
            {
                __result = (int)(__result * settings.RefiningXpMultiplier);
            }
        }
    }

    [HarmonyPatch(typeof(DefaultSmithingModel), "GetSkillXpForSmelting")]
    public class SmeltingXpPatch
    {
        static void Postfix(ref int __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableCraftingTweaks == true)
            {
                __result = (int)(__result * settings.SmeltingXpMultiplier);
            }
        }
    }

    [HarmonyPatch(typeof(DefaultSmithingModel), "GetSkillXpForSmithing")]
    public class SmithingXpPatch
    {
        static void Postfix(ref int __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableCraftingTweaks == true)
            {
                __result = (int)(__result * settings.CraftingXpMultiplier);
            }
        }
    }
}
