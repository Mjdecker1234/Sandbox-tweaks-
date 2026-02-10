using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using SandboxTweaks.Settings;

namespace SandboxTweaks
{
    public class BattleTweaksBehavior : CampaignBehaviorBase
    {
        private SandboxTweaksSettings Settings => SandboxTweaksSettings.Instance!;

        public override void RegisterEvents()
        {
            // Register events for battle tweaks
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
        }

        public override void SyncData(IDataStore dataStore)
        {
            // Sync data if needed
        }

        private void OnSessionLaunched(CampaignGameStarter campaignGameStarter)
        {
            if (Settings.EnableBattleTweaks)
            {
                // Apply battle size settings
                // This would typically involve patching game methods via Harmony
            }
        }
    }
}
