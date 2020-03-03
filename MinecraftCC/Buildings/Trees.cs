using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    class Trees : Building {
        public Trees() {
            _id = BuildingID.Trees;
            _name = "Trees";
            _baseScore = 0;
            _radius = 1;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.Trees, 0),
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Forest };
        }
    }
}
