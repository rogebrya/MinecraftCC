using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class HopField : Building {
        public HopField() {
            _id = BuildingID.HopField;
            _name = "Wheat Field";
            _baseScore = 5;
            _radius = 1; //3
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.HopField, 2),
                (BuildingID.Statue, 4),
                (BuildingID.Brewery, 4),
                (BuildingID.Resort, 3),
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert };
        }
    }
}
