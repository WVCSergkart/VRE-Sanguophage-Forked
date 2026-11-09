using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;
using RimWorld;
using HarmonyLib;
using System.Reflection;

namespace VanillaRacesExpandedSanguophage
{

    public class HarmonyInstance : Mod
    {
        public HarmonyInstance(ModContentPack content) : base(content)
        {
            harmonyInstance = new Harmony("OskarPotocki.VRESanguophage");
            harmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
        }

        public static Harmony harmonyInstance;
    }

}
