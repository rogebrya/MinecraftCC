using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class Lumberjack : Building {
        public Lumberjack() {
            _id = BuildingID.Lumberjack;
            _name = "Lumber";
            _baseScore = 0;
            _radius = 2; //10
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.Lumberjack, -1), //-6
                (BuildingID.Sawmill, 5),
                (BuildingID.Statue, 2), //4
                (BuildingID.Trees, 10),
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert, BiomeID.Tundra };
        }
    }
}
