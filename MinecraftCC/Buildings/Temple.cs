using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class Temple : Building {
        public Temple() {
            _id = BuildingID.Temple;
            _name = "Temple";
            _baseScore = -75;
            _radius = 2;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.Tavern, -15),
                (BuildingID.Statue, 40),
                (BuildingID.Mason, 25),
                (BuildingID.Shaman, 15),
                (BuildingID.Mansion, 10),
                //(BuildingID.Wall, 10),
                (BuildingID.CityCenter, 10),
                (BuildingID.Tower, 10),
                (BuildingID.House, 8),
                (BuildingID.Park, 5),
                (BuildingID.Tavern, -20),
                //(BuildingID.GoldMine, -20),
                (BuildingID.Warehouse, -20),
                (BuildingID.Circus, -20),
                (BuildingID.Market, -20),
                (BuildingID.Mill, -20),
                (BuildingID.Brickyard, -20),
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains, BiomeID.Desert, BiomeID.Tundra, BiomeID.Mountain };
        }
    }
}
