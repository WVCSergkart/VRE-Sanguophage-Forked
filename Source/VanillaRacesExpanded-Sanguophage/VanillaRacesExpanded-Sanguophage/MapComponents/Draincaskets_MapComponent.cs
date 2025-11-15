using System;
using System.Collections.Generic;

using RimWorld;
using Verse;

namespace VanillaRacesExpandedSanguophage
{
    public class Draincaskets_MapComponent : MapComponent
    {
        public List<CompDraincasket> comps = [];

        public Draincaskets_MapComponent(Map map) : base(map)
        {
        }
    }
}
