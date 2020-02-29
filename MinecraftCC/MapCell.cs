using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MinecraftCC {
	public class MapCell {
		private int _xCoordinate;
		private int _zCoordinate;
		private int _elevation;	//aka yCoordinate
		private Building _building;
		private Biome _biome;

		public MapCell(int x, int z, Biome b) {
			_xCoordinate = x;
			_zCoordinate = z;
			_biome = b;
		}

		public Building Building { get => _building; set => _building = value; }
		public Biome Biome { get => _biome; set => _biome = value; }
	}
}
