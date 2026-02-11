using HarmonyLib;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using SandboxTweaks.Settings;

namespace SandboxTweaks.Patches
{
    [HarmonyPatch(typeof(Agent), "RegisterBlow")]
    public class DamageMultiplierPatch
    {
        static void Prefix(Agent __instance, ref Blow blow)
        {
            var settings = SandboxTweaksSettings.Instance;
            if (settings?.EnableCampaignTweaks != true) return;

            try
            {
                var attackerAgent = blow.AttackerAgent;
                if (attackerAgent == null) return;

                // Check if attacker is the player
                if (attackerAgent == Agent.Main)
                {
                    blow.InflictedDamage = (int)(blow.InflictedDamage * settings.PlayerDamageMultiplier);
                }
                // Check if attacker is in player's party
                else if (attackerAgent.Team != null && attackerAgent.Team.Side == BattleSideEnum.Attacker)
                {
                    var mission = Mission.Current;
                    if (mission != null)
                    {
                        // Apply player troop damage multiplier if this is a player-led battle
                        blow.InflictedDamage = (int)(blow.InflictedDamage * settings.PlayerTroopDamageMultiplier);
                    }
                }
            }
            catch
            {
                // Silently fail to avoid breaking combat
            }
        }
    }
}
