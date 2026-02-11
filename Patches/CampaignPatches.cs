using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using SandboxTweaks.Settings;

namespace SandboxTweaks.Patches
{
    [HarmonyPatch(typeof(MobileParty), "Speed", MethodType.Getter)]
    public class PartySpeedPatch
    {
        static void Postfix(MobileParty __instance, ref float __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableCampaignTweaks == true && __instance?.LeaderHero == Hero.MainHero)
            {
                __result *= settings.PlayerMapSpeedMultiplier;
            }
        }
    }
}
