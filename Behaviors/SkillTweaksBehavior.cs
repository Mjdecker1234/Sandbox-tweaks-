using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using SandboxTweaks.Settings;

namespace SandboxTweaks
{
    public class SkillTweaksBehavior : CampaignBehaviorBase
    {
        private SandboxTweaksSettings Settings => SandboxTweaksSettings.Instance!;

        public override void RegisterEvents()
        {
            // Register events for skill and learning tweaks
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
        }

        public override void SyncData(IDataStore dataStore)
        {
            // Sync data if needed
        }

        private void OnSessionLaunched(CampaignGameStarter campaignGameStarter)
        {
            if (Settings.EnableSkillTweaks)
            {
                // Apply skill and learning settings
            }
        }
    }
}
