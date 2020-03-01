using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinecraftCC.Buildings;

namespace MinecraftCC.BuildingPacks {
    class LumberPack : BuildingPack {
        public LumberPack() {
            _name = "Lumber Pack";
            _buildings = new List<Building> {
                new Lumberjack(),
                new Lumberjack(),
                new Sawmill(),
                new House(),
                new House(),
                new Hut()
            };
        }
    }
}
