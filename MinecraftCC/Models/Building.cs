using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC {
	public class Building {
		private string _name;
		private int _baseScore;
		private int _modToSelf;
		private double _radius;
		private int _size;
		private List<Biome> _reqBiome;

		private List<(object, int)> _scoreMods;

		public Building() { }

		public Building(string name, int bse, int mod, double radius) {
			_name = name; _baseScore = bse; _modToSelf = mod; _radius = radius;
			//_size = size;
		}

		public string Name { get => _name; set => _name = value; }
		public int BaseScore { get => _baseScore; set => _baseScore = value; }
		public int ModToSelf { get => _modToSelf; set => _modToSelf = value; }
		public double Radius { get => _radius; set => _radius = value; }
		public int Size { get => _size; set => _size = value; }
		public List<(object, int)> ScoreMods { get => _scoreMods; set => _scoreMods = value; }
		public List<Biome> ReqBiome { get => _reqBiome; set => _reqBiome = value; }
	}
}
