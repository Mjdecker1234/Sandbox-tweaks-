using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using SandboxTweaks.Settings;

namespace SandboxTweaks
{
    public class PregnancyTweaksBehavior : CampaignBehaviorBase
    {
        private SandboxTweaksSettings Settings => SandboxTweaksSettings.Instance!;

        public override void RegisterEvents()
        {
            // Register events for pregnancy tweaks
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
        }

        public override void SyncData(IDataStore dataStore)
        {
            // Sync data if needed
        }

        private void OnSessionLaunched(CampaignGameStarter campaignGameStarter)
        {
            if (Settings.EnablePregnancyTweaks)
            {
                // Apply pregnancy settings
            }
        }
    }
}
