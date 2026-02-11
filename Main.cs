using TaleWorlds.MountAndBlade;
using TaleWorlds.Core;
using TaleWorlds.CampaignSystem;
using HarmonyLib;
using System;

namespace SandboxTweaks
{
    public class Main : MBSubModuleBase
    {
        private Harmony? _harmony;

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

            try
            {
                _harmony = new Harmony("com.sandboxtweaks.mod");
                _harmony.PatchAll();
            }
            catch (Exception ex)
            {
                // Log error - in production would use proper logging
                Console.WriteLine($"[Sandbox Tweaks] Error applying Harmony patches: {ex.Message}");
            }
        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);

            if (game.GameType is Campaign)
            {
                CampaignGameStarter campaignStarter = (CampaignGameStarter)gameStarterObject;
                AddBehaviors(campaignStarter);
            }
        }

        private void AddBehaviors(CampaignGameStarter campaignStarter)
        {
            // Add campaign behaviors here
            campaignStarter.AddBehavior(new AgeTweaksBehavior());
            campaignStarter.AddBehavior(new BattleTweaksBehavior());
            campaignStarter.AddBehavior(new ClanTweaksBehavior());
            campaignStarter.AddBehavior(new WorkshopTweaksBehavior());
            campaignStarter.AddBehavior(new PregnancyTweaksBehavior());
            campaignStarter.AddBehavior(new CraftingTweaksBehavior());
            campaignStarter.AddBehavior(new SkillTweaksBehavior());
            campaignStarter.AddBehavior(new NavalTweaksBehavior());
        }

        protected override void OnSubModuleUnloaded()
        {
            base.OnSubModuleUnloaded();
            _harmony?.UnpatchAll("com.sandboxtweaks.mod");
        }
    }
}
