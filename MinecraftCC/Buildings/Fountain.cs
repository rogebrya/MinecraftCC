using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class Fountain : Building {
        public Fountain() {
            _id = BuildingID.Fountain;
            _name = "Fountain";
            _baseScore = 0;
            _radius = 4;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.Fountain, -15),
                (BuildingID.CityCenter, 7),
                (BuildingID.Statue, 3),
                (BuildingID.Park, 3),
                (BuildingID.Mansion, 3),
                (BuildingID.House, 2)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert, BiomeID.Tundra };
        }
    }
}
