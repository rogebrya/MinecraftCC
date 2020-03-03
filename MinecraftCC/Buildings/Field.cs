using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC.Buildings {
    public class Field : Building {
        public Field() {
            _id = BuildingID.Field;
            _name = "Potato Field";
            _baseScore = 3;
            _radius = 2;
            _scoreMods = new List<(BuildingID, int)>() {
                (BuildingID.Field, 2),
                (BuildingID.Mill, 5),
                (BuildingID.Statue, 3),
                (BuildingID.Resort, 3)
            };
            _reqBiome = new List<BiomeID>() { BiomeID.Plains };
        }
    }
}