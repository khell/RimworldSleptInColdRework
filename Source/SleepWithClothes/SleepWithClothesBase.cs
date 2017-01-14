using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;
using HugsLib;
using System.Reflection;
using HugsLib.Utils;
using HugsLib.Settings;
using HugsLib.Source.Detour;

namespace SleepWithClothes
{
    public class SleepWithClothesBase : HugsLib.ModBase
    {
        public override string ModIdentifier
        {
            get
            {
                return "SleepWithClothes";
            }
        }

        private SettingHandle<int>[] sleptColdThoughtSettingHandles = new SettingHandle<int>[3];

        public override void DefsLoaded()
        {
            sleptColdThoughtSettingHandles[0] = Settings.GetHandle<int>("sleptColdThoughtSettingHandle1", "sleptColdThoughtSettingHandle1_title".Translate(), "sleptColdThoughtSettingHandle1_desc".Translate(), -2);
            sleptColdThoughtSettingHandles[1] = Settings.GetHandle<int>("sleptColdThoughtSettingHandle2", "sleptColdThoughtSettingHandle2_title".Translate(), "sleptColdThoughtSettingHandle2_desc".Translate(), -5);
            sleptColdThoughtSettingHandles[2] = Settings.GetHandle<int>("sleptColdThoughtSettingHandle3", "sleptColdThoughtSettingHandle3_title".Translate(), "sleptColdThoughtSettingHandle3_desc".Translate(), -8);
        }

        public override void SettingsChanged()
        {
            base.SettingsChanged();
            DoSleptInColdThoughtDefUpdate();
        }

        public void DoSleptInColdThoughtDefUpdate()
        {
            ThoughtDef def = ThoughtDefOf.SleptInCold;
            for (int i = 0; i < def.stages.Count; i++)
                def.stages[i].baseMoodEffect = sleptColdThoughtSettingHandles[i];
        }
    }
}
