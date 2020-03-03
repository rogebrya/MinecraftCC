using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MinecraftCC.Biomes {
    public class Ocean : Biome {
        public Ocean() {
            _id = BiomeID.Ocean;
            _name = "Ocean";
            _color = Brushes.DarkBlue;
        }
    }
}
