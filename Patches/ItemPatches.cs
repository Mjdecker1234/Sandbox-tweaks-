using HarmonyLib;
using TaleWorlds.Core;
using SandboxTweaks.Settings;

namespace SandboxTweaks.Patches
{
    [HarmonyPatch(typeof(ItemObject), "Weight", MethodType.Getter)]
    public class ItemWeightPatch
    {
        static void Postfix(ItemObject __instance, ref float __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableItemTweaks != true) return;

            if (__instance.ItemType == ItemObject.ItemTypeEnum.BodyArmor ||
                __instance.ItemType == ItemObject.ItemTypeEnum.LegArmor ||
                __instance.ItemType == ItemObject.ItemTypeEnum.HeadArmor ||
                __instance.ItemType == ItemObject.ItemTypeEnum.HandArmor ||
                __instance.ItemType == ItemObject.ItemTypeEnum.Cape ||
                __instance.ItemType == ItemObject.ItemTypeEnum.HorseHarness)
            {
                __result *= settings.ArmorWeightMultiplier;
            }
            else if (__instance.ItemType == ItemObject.ItemTypeEnum.OneHandedWeapon ||
                     __instance.ItemType == ItemObject.ItemTypeEnum.TwoHandedWeapon ||
                     __instance.ItemType == ItemObject.ItemTypeEnum.Polearm ||
                     __instance.ItemType == ItemObject.ItemTypeEnum.Bow ||
                     __instance.ItemType == ItemObject.ItemTypeEnum.Crossbow ||
                     __instance.ItemType == ItemObject.ItemTypeEnum.Arrows ||
                     __instance.ItemType == ItemObject.ItemTypeEnum.Bolts ||
                     __instance.ItemType == ItemObject.ItemTypeEnum.Shield ||
                     __instance.ItemType == ItemObject.ItemTypeEnum.Thrown)
            {
                __result *= settings.WeaponWeightMultiplier;
            }
        }
    }

    [HarmonyPatch(typeof(ItemObject), "Value", MethodType.Getter)]
    public class ItemValuePatch
    {
        static void Postfix(ItemObject __instance, ref int __result)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableItemTweaks != true) return;

            if (__instance.ItemType == ItemObject.ItemTypeEnum.BodyArmor ||
                __instance.ItemType == ItemObject.ItemTypeEnum.LegArmor ||
                __instance.ItemType == ItemObject.ItemTypeEnum.HeadArmor ||
                __instance.ItemType == ItemObject.ItemTypeEnum.HandArmor ||
                __instance.ItemType == ItemObject.ItemTypeEnum.Cape ||
                __instance.ItemType == ItemObject.ItemTypeEnum.HorseHarness)
            {
                __result = (int)(__result * settings.ArmorPriceMultiplier);
            }
            else if (__instance.ItemType == ItemObject.ItemTypeEnum.OneHandedWeapon ||
                     __instance.ItemType == ItemObject.ItemTypeEnum.TwoHandedWeapon ||
                     __instance.ItemType == ItemObject.ItemTypeEnum.Polearm ||
                     __instance.ItemType == ItemObject.ItemTypeEnum.Bow ||
                     __instance.ItemType == ItemObject.ItemTypeEnum.Crossbow ||
                     __instance.ItemType == ItemObject.ItemTypeEnum.Arrows ||
                     __instance.ItemType == ItemObject.ItemTypeEnum.Bolts ||
                     __instance.ItemType == ItemObject.ItemTypeEnum.Shield ||
                     __instance.ItemType == ItemObject.ItemTypeEnum.Thrown)
            {
                __result = (int)(__result * settings.WeaponPriceMultiplier);
            }
        }
    }
}
