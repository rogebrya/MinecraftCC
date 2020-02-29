using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class Circus : Building {
        public Circus() {
            _id = BuildingID.Circus;
            _name = "Circus";
            _baseScore = 0;
            _radius = 2;
            _scoreMods = new List<(BuildingID, int)>() { 
                (BuildingID.Circus, -10), 
                (BuildingID.Statue, 10), 
                (BuildingID.House, 4), 
                (BuildingID.Mansion, -5), 
                (BuildingID.Temple, -25)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert, BiomeID.Tundra };
        }
    }
}