using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MinecraftCC.Biomes {
    public class Desert : Biome {
        public Desert() {
            _id = BiomeID.Desert;
            _name = "Desert";
            _color = Brushes.Tan;
        }
    }
}
