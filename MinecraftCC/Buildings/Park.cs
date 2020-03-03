using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class Park : Building {
        public Park() {
            _id = BuildingID.Park;
            _name = "Park";
            _baseScore = 2;
            _radius = 4;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.Resort, 5),
                (BuildingID.Fountain, 4),
                (BuildingID.Temple, 4),
                (BuildingID.HopField, 3),
                (BuildingID.Field, 2),
                //(BuildingID.Plateau, 2),
                (BuildingID.Statue, 2),
                (BuildingID.CityCenter, 2),
                (BuildingID.Trees, 1),
                (BuildingID.House, 1),
                (BuildingID.Mansion, 1),
                //(BuildingID.Wall, -2),
                (BuildingID.Warehouse, -2),
                (BuildingID.Brickyard, -3),
                (BuildingID.Lumberjack, -4),
                (BuildingID.Mill, -4),
                (BuildingID.Sawmill, -5)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert, BiomeID.Tundra };
        }
    }
}
