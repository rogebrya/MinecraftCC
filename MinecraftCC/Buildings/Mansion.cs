using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    class Mansion : Building {
        public Mansion() {
            _id = BuildingID.Mansion;
            _name = "Mansion";
            _baseScore = 1;
            _radius = 1;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.Mansion, 1),
                (BuildingID.CityCenter, 8),
                (BuildingID.Shaman, 6),
                //(BuildingID.Plateau, 6),
                //(BuildingID.WallPlateau, 6),
                (BuildingID.Statue, 5),
                (BuildingID.Fountain, 3),
                (BuildingID.Park, 2),
                (BuildingID.Market, 2),
                (BuildingID.Temple, 2),
                //(BuildingID.Jewelry, 2),
                (BuildingID.Circus, -3),
                //(BuildingID.Wall, -3)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert, BiomeID.Tundra };
        }
    }
}
(cityCentre, 8), (shaman, 6), (plateau, 6), (wallPlateau, 6), (statue, 5), (fountain, 3), (park, 2), (market, 2),
				(temple, 2), (jewelry, 2), (circus, -3), (wall, -3) };