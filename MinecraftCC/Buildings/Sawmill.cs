using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class Sawmill : Building {
        public Sawmill() {
            _id = BuildingID.Sawmill;
            _name = "Sawmill";
            _baseScore = 0;
            _radius = 4;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.Sawmill, -12),
                (BuildingID.Lumberjack, 7),
                (BuildingID.Warehouse, 6),
                (BuildingID.Statue, 4)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains };
        }
    }
}
