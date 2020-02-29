using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    class Resort : Building {
        public Resort() {
            _id = BuildingID.Resort;
            _name = "Resort";
            _baseScore = 0;
            _radius = 3;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.HopField, 7),
                //(BuildingID.Plateau, 6),
                (BuildingID.Fountain, 5),
                (BuildingID.Park, 5),
                (BuildingID.WaterPlateau, 5),
                (BuildingID.Statue, 4),
                //(BuildingID.Flower, 2),
                (BuildingID.Field, 3),
                (BuildingID.Brewery, 2),
                (BuildingID.Fisher, 2),
                //(BuildingID.Tree, 1),
                (BuildingID.Mill, -3),
                (BuildingID.House, -5),
                (BuildingID.Brickyard, -5),
                (BuildingID.Lumberjack, -5),
                (BuildingID.Mansion, -7),
                (BuildingID.Sawmill, -10),
                //(BuildingID.GoldMine, -10),
                (BuildingID.CityCenter, -10),
                (BuildingID.Mason, -10),
                (BuildingID.Warehouse, -10)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert, BiomeID.Tundra, BiomeID.Mountain };
        }
    }
}
