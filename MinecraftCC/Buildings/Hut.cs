using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class Hut : Building {
        public Hut() {
            _id = BuildingID.Hut;
            _name = "Hut";
            _baseScore = 4;
            _radius = 10;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.CityCenter, 6),
                (BuildingID.Statue, 2),
                (BuildingID.Shaman, 2),
                (BuildingID.Fisher, 1),
                (BuildingID.Sawmill, -1),
                (BuildingID.Lumberjack, -1),
                (BuildingID.Warehouse, -1),
                (BuildingID.Brickyard, -1),
                (BuildingID.Mill, -1),
                (BuildingID.Mason, -1),
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert, BiomeID.Tundra, BiomeID.Mountain };
        }
    }
}

