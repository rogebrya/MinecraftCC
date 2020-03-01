using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class WaterPlateau : Building {
        public WaterPlateau() {
            _id = BuildingID.WaterPlateau;
            _name = "Water Plateau";
            _baseScore = 13;
            _radius = 3;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.WaterPlateau, 1),
                (BuildingID.Sawmill, 2),
                (BuildingID.Statue, 2),
                //(BuildingID.Tree, 1)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Coast };
        }
    }
}
