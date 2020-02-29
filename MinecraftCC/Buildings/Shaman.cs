using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    class Shaman : Building {
        public Shaman() {
            _id = BuildingID.Shaman;
            _name = "Shaman";
            _baseScore = 0;
            _radius = 5;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.Shaman, -13),
                (BuildingID.Statue, 5),
                (BuildingID.Temple, 5),
                //(BuildingID.Flower, 3),
                (BuildingID.Mason, -6),
                (BuildingID.CityCenter, -10)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains };
        }
    }
}
