using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinecraftCC.Buildings;

namespace MinecraftCC.BuildingPacks {
    class ReligiousPack : BuildingPack {
        public ReligiousPack() {
            _name = "Religious Pack";
            _buildings = new List<Building> {
                new Mansion(),
                new Mansion(),
                new Statue(),
                new Fountain(),
                new Shaman(),
                new Shaman(),
                new Temple(),
                new Park(),
                new Mason()
            };
        }
    }
}
