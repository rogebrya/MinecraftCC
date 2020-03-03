using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class Mill : Building {
        public Mill() {
            _id = BuildingID.Mill;
            _name = "Mill";
            _baseScore = 8;
            _radius = 7;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.Mill, -20),
                (BuildingID.Warehouse, 4),
                (BuildingID.Statue, 4),
                (BuildingID.CityCenter, 3),
                (BuildingID.Field, 4),
                (BuildingID.Mason, 2)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains };
        }
    }
}
