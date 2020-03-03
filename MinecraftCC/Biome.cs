using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MinecraftCC {
	public enum BiomeID {
		Coast,
		Desert,
		Forest,
		Mountain,
		Ocean,
		Plains,
		Tundra
	}

	public abstract class Biome {
		protected BiomeID _id;
		protected string _name;
		protected SolidColorBrush _color;

		public BiomeID ID { get => _id; set => _id = value; }
		public string Name { get => _name; set => _name = value; }
		public SolidColorBrush Color { get => _color; set => _color = value; }
	}
}
