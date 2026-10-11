using System;
using HarmonyLib;
using Vintagestory.ServerMods;

namespace TestOceanMap;

[HarmonyPatchCategory("testoceanmap")]
internal static class WorldGenPatches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(GenMaps), nameof(GenMaps.GetOceanMapGen))]
    private static bool ReplaceOceanMapGeneration(ref MapLayerBase __result)
    {
        __result = new TestOceanMapLayer();
        return false;
    }
}
