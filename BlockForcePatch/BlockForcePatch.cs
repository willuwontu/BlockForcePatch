using BepInEx;
using HarmonyLib;
using UnityEngine;
using System;

namespace BlockForcePatch
{
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class BlockForcePatch : BaseUnityPlugin
    {
        private const string ModId = "com.willuwontu.rounds.BlockForcePatch";
        private const string ModName = "Block Force Patch";
        public const string Version = "1.0.1"; // What version are we on (major.minor.patch)?

        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
    }
}
