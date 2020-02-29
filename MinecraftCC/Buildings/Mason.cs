using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    class Mason : Building {
        public Mason() {
            _id = BuildingID.Mason;
            _name = "Mason";
            _baseScore = 9;
            _radius = 4;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.Mason, -4),
                (BuildingID.Brickyard, 4),
                (BuildingID.Statue, 3),
                (BuildingID.Warehouse, 3),
                (BuildingID.Tower, 2),
                (BuildingID.Market, 2),
                (BuildingID.CityCenter, 2),
                //(BuildingID.Plateau, 2),
                (BuildingID.Temple, 2),
                //(BuildingID.Wall, 2),
                (BuildingID.Shaman, -5)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Tundra, BiomeID.Mountain };
        }
    }
}
