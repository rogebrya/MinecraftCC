using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    class Market : Building {
        public Market() {
            _id = BuildingID.Market;
            _name = "Market";
            _baseScore = -20;
            _radius = 4;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.Market, -35),
                (BuildingID.Warehouse, 20),
                (BuildingID.CityCenter, 5),
                (BuildingID.Statue, 4),
                (BuildingID.Mason, 4),
                (BuildingID.Fisher, 3),
                (BuildingID.Mansion, 2),
                (BuildingID.House, 2)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert, BiomeID.Tundra };
        }
    }
}
