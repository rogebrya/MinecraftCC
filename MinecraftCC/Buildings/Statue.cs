using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class Statue : Building {
        public Statue() {
            _id = BuildingID.Statue;
            _name = "Statue";
            _baseScore = 15;
            _radius = 5; //10
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.Statue, -25)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert, BiomeID.Tundra, BiomeID.Mountain };
        }
    }
}
