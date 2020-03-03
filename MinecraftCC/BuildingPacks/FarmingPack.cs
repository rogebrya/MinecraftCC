using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinecraftCC.Buildings;

namespace MinecraftCC.BuildingPacks {
    public class FarmingPack : BuildingPack {
        public FarmingPack() {
            _name = "Farming Pack";
            _buildings = new List<Building> {
                new Field(),
                new Field(),
                new Field(),
                new Field(),
                new House(),
                new House(),
                new Mill()
            };
        }
    }
}
