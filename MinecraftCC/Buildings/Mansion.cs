using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class Mansion : Building {
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
