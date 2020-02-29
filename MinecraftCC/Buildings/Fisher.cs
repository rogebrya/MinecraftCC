using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    class Fisher : Building {
        public Fisher() {
            _id = BuildingID.Fisher;
            _name = "Fisher";
            _baseScore = 5;
            _radius = 10;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.Fisher, -10),
                (BuildingID.CityCenter, 7),
                (BuildingID.Warehouse, 2),
                (BuildingID.Statue, 2),
                (BuildingID.Hut, 1)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Ocean };
        }
    }
}
