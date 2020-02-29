using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC {
    public class Generator {
        List<Map> terrains;
        //List<Building> styledBuildings;
        //List<List<Building>> themesForBuildings;

        private int _terrain;
        private int _buildingStyle;
        private int _villageType;

        public Generator(int terrain, int buildingStyle, int villageType) {
            _terrain = terrain;
            _buildingStyle = buildingStyle;
            _villageType = villageType;
        }

        
    }
}
