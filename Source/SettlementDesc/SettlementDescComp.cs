using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;
using RimWorld.Planet;

namespace SettlementDesc
{
    public class SettlementDescriptionComp : WorldObjectComp
    {
        public Faction Faction => parent.Faction;

        public override string GetDescriptionPart()
        {
            return (Faction.NameColored + " (" + Faction.def.LabelCap + ")\n\n" + Faction.GetReportText).Resolve();
        }
    }
    public class WorldObjectCompProperties_SettlementDescription : WorldObjectCompProperties
    {
        public WorldObjectCompProperties_SettlementDescription()
        {
            base.compClass = typeof(SettlementDescriptionComp);
        }
    }
}
