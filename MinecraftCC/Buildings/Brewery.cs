using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class Brewery : Building {
        public Brewery() {
            _id = BuildingID.Brewery;
            _name = "Brewery";
            _baseScore = 7;
            _radius = 4; //3.5
            _scoreMods = new List<(BuildingID, int)>() { 
                (BuildingID.Brewery, -10), 
                (BuildingID.HopField, 5), 
                (BuildingID.Statue, 4), 
                (BuildingID.Warehouse, 2)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert, BiomeID.Tundra };
        }
    }
}
