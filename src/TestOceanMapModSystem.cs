using System;
using HarmonyLib;
using Vintagestory.API.Common;

namespace TestOceanMap;

public sealed class TestOceanMapModSystem : ModSystem
{
    public static int LandWidth = int.Parse(Environment.GetEnvironmentVariable("TEST_OCEAN_MAP_LAND") ?? "1");
    public static int OceanWidth = int.Parse(Environment.GetEnvironmentVariable("TEST_OCEAN_MAP_OCEAN") ?? "1");
    
    private Harmony _harmony = null!;

    public override bool ShouldLoad(EnumAppSide forSide) => forSide == EnumAppSide.Server;

    public override void StartPre(ICoreAPI api)
    {
        _harmony = new Harmony(Mod.Info.ModID);
        _harmony.PatchCategory("testoceanmap");
    }

    public override void Dispose()
    {
        _harmony.UnpatchCategory("testoceanmap");
        _harmony = null!;
    }
}
