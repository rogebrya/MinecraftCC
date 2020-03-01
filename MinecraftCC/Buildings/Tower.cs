using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class Tower : Building {
        public Tower() {
            _id = BuildingID.Tower;
            _name = "Tower";
            _baseScore = 0;
            _radius = 20;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.Tower, -20),
                (BuildingID.Temple, 8),
                (BuildingID.Mason, 5),
                (BuildingID.Mansion, 1),
                (BuildingID.Park, 1),
                //(BuildingID.Wall, 1),
                (BuildingID.House, 1)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert, BiomeID.Tundra, BiomeID.Mountain };
        }
    }
}
