using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MinecraftCC.Biomes {
    public class Tundra : Biome {
        public Tundra() {
            _id = BiomeID.Tundra;
            _name = "Tundra";
            _color = Brushes.White;
        }
    }
}
