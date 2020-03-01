using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinecraftCC.Buildings;

namespace MinecraftCC.BuildingPacks {
    class FishingPack : BuildingPack {
        public FishingPack() {
            _name = "Fishing Pack";
            _buildings = new List<Building> {
                new Fisher(),
                new Fisher(),
                new Fisher(),
                new WaterPlateau(),
                new WaterPlateau(),
                new House(),
                new House(),
                new Hut(),
                new Warehouse()
            };
        }
    }
}
