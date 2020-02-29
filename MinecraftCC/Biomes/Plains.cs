using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MinecraftCC.Biomes {
    public class Plains : Biome {
        public Plains() {
            _id = BiomeID.Plains;
            _name = "Plains";
            _color = Brushes.LightGreen;
        }
    }
}
