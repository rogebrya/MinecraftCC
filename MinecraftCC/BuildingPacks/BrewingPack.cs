using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinecraftCC.Buildings;

namespace MinecraftCC.BuildingPacks {
    class BrewingPack : BuildingPack {
        public BrewingPack() {
            _name = "Brewing Pack";
            _buildings = new List<Building> {
                new HopField(),
                new HopField(),
                new HopField(),
                new HopField(),
                new Brewery(),
                new Brewery(),
                new House(),
                new House()
            };
        }
    }
}