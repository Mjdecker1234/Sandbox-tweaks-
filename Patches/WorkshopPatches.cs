using HarmonyLib;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem;
using SandboxTweaks.Settings;

namespace SandboxTweaks.Patches
{
    [HarmonyPatch(typeof(DefaultWorkshopModel), "GetMaxWorkshopCountForPlayer")]
    public class WorkshopLimitPatch
    {
        static void Postfix(ref int __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableWorkshopTweaks == true)
            {
                __result = settings.WorkshopLimit;
            }
        }
    }
}
