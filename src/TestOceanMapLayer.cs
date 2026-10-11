using Vintagestory.API.Util;
using Vintagestory.ServerMods;

namespace TestOceanMap;

public class TestOceanMapLayer() : MapLayerBase(0)
{
    public override int[] GenLayer(int xCoord, int zCoord, int sizeX, int sizeZ)
    {
        var totalWidth = TestOceanMapModSystem.LandWidth + TestOceanMapModSystem.OceanWidth; 
        var isOcean = (xCoord + zCoord) % totalWidth < TestOceanMapModSystem.OceanWidth;
        var map = new int[sizeX * sizeZ].Fill(isOcean ? 0xFF : 0x00);
        return map;
    }
}