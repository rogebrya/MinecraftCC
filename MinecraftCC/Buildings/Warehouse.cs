using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class Warehouse : Building {
        public Warehouse() {
            _id = BuildingID.Warehouse;
            _name = "Warehouse";
            _baseScore = 0;
            _radius = 5;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.Warehouse, -15),
                (BuildingID.Brickyard, 7),
                (BuildingID.Mill, 7),
                //(BuildingID.GoldMine, 7),
                (BuildingID.Fisher, 6),
                (BuildingID.Brewery, 5),
                (BuildingID.Mason, 5),
                (BuildingID.Sawmill, 4),
                (BuildingID.Statue, 4),
                (BuildingID.Resort, -5)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert, BiomeID.Tundra };
        }
    }
}
