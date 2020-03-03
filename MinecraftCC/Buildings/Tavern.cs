using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class Tavern : Building {
        public Tavern() {
            _id = BuildingID.Tavern;
            _name = "Tavern";
            _baseScore = -15;
            _radius = 5;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.Tavern, -15),
                (BuildingID.Brewery, 18),
                (BuildingID.CityCenter, 8),
                (BuildingID.Statue, 4),
                (BuildingID.House, 2)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert, BiomeID.Tundra };
        }
    }
}
