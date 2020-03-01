using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinecraftCC.Buildings;

namespace MinecraftCC.BuildingPacks {
    class OrnamentalPack : BuildingPack {
        public OrnamentalPack() {
            _name = "Ornamental Pack";
            _buildings = new List<Building> {
                new Fountain(),
                new Fountain(),
                new Park(),
                new Park(),
                new Park(),
                new Tower(),
                new Statue(),
                new Mason()
            };
        }
    }
}
