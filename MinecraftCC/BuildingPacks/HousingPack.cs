using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinecraftCC.Buildings;

namespace MinecraftCC.BuildingPacks {
    class HousingPack : BuildingPack {
        public HousingPack() {
            _name = "Housing Pack";
            _buildings = new List<Building> {
                new House(),
                new House(),
                new House(),
                new House(),
                new Mansion(),
                new Mansion(),
                new Park(),
                new Park()
            };
        }
    }
}
