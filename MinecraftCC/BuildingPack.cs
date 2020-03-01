using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC {
    public abstract class BuildingPack {
        protected string _name;
        protected List<Building> _buildings;

        public string Name { get => _name; }
        public List<Building> Buildings { get => _buildings; }
    }
}
