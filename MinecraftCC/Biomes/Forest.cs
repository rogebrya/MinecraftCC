using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MinecraftCC.Biomes {
    public class Forest : Biome {
        public Forest() {
            _id = BiomeID.Forest;
            _name = "Forest";
            _color = Brushes.Green;
        }
    }
}
