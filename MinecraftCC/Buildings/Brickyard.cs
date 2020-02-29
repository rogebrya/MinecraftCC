using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class Brickyard : Building {
        public Brickyard() {
            _id = BuildingID.Brickyard;
            _name = "Brickyard";
            _baseScore = 6;
            _radius = 4;
            _scoreMods = new List<(BuildingID, int)>() { 
                (BuildingID.Brickyard, -8), 
                (BuildingID.Mason, 5), 
                (BuildingID.Warehouse, 4), 
                //(BuildingID.Sandpit, 4), 
                (BuildingID.Statue, 3) 
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert, BiomeID.Tundra };
        }
    }
}
