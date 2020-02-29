using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    class House : Building {
        public House() {
            _id = BuildingID.House;
            _name = "House";
            _baseScore = 1;
            _radius = 3;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.House, 1),
                (BuildingID.CityCenter, 6),
                (BuildingID.Shaman, 4),
                (BuildingID.Statue, 4),
                //(BuildingID.WallPlateau, 3),
                (BuildingID.Circus, 3),
                (BuildingID.Fountain, 2),
                (BuildingID.Market, 2),
                (BuildingID.Temple, 2),
                (BuildingID.Tavern, 2),
                (BuildingID.Park, 1),
                (BuildingID.Mason, 2),
                //(BuildingID.Wall, -2),
                //(BuildingID.Jewelry, -2)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert, BiomeID.Tundra };
        }
    }
}
