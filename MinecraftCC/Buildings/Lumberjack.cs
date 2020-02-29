using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    class Lumberjack : Building {
        public Lumberjack() {
            _id = BuildingID.Lumberjack;
            _name = "Lumberjack";
            _baseScore = 0;
            _radius = 10;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.Lumberjack, -6),
                (BuildingID.Sawmill, 5),
                (BuildingID.Statue, 4),
                //(BuildingID.Tree, 1),
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert, BiomeID.Tundra };
        }
    }
}
