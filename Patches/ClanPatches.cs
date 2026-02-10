using HarmonyLib;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem;
using SandboxTweaks.Settings;

namespace SandboxTweaks.Patches
{
    [HarmonyPatch(typeof(DefaultClanTier), "GetCompanionLimit")]
    public class CompanionLimitPatch
    {
        static void Postfix(ref int __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableClanTweaks == true)
            {
                __result = settings.CompanionLimit;
            }
        }
    }

    [HarmonyPatch(typeof(DefaultPartySizeLimitModel), "GetPartyMemberSizeLimit")]
    public class PartySizeLimitPatch
    {
        static void Postfix(ref int __result, PartyBase party)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableClanTweaks == true && party?.LeaderHero == Hero.MainHero)
            {
                __result = settings.PartySizeLimit;
            }
        }
    }
}
