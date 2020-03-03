using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MinecraftCC.Biomes {
    public class Mountain : Biome {
        public Mountain() {
            _id = BiomeID.Mountain;
            _name = "Mountain";
            _color = Brushes.Gray;
        }
    }
}
