using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MinecraftCC.Biomes {
    public class Coast : Biome {
        public Coast() {
            _id = BiomeID.Coast;
            _name = "Coast";
            _color = Brushes.LightBlue;
        }
    }
}
