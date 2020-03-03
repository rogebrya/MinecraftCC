using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class CityCenter : Building {
        public CityCenter() {
            _id = BuildingID.CityCenter;
            _name = "City Center";
            _baseScore = 15;
            _radius = 5;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.CityCenter, -40),
                (BuildingID.Fisher, 7),
                (BuildingID.Statue, 5),
                (BuildingID.Mason, 4),
                (BuildingID.Mill, 2),
                (BuildingID.Shaman, -5),
                (BuildingID.Resort, -15)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert, BiomeID.Tundra };
        }
    }
}