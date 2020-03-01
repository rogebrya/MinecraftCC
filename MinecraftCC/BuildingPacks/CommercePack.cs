using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinecraftCC.Buildings;

namespace MinecraftCC.BuildingPacks {
    class CommercePack : BuildingPack {
        public CommercePack() {
            _name = "Commerce Pack";
            _buildings = new List<Building> {
                new Market(),
                new Market(),
                new Circus(),
                new Tavern(),
                new Tavern(),
                new Fountain(),
                new House(),
                new House()
            };
        }
    }
}
