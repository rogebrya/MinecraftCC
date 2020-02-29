using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC {
	public enum BuildingID {
		Brewery,
		Brickyard,
		Circus, 
		CityCenter,
		Field, 
		Fisher, 
		Fountain, 
		//GoldMine, 
		HopField, 
		House, 
		Hut, 
		//Jewelry,
		Lumberjack, 
		Mansion,
		Market,
		Mason, 
		Mill, 
		Park, 
		//Plateau,
		Resort,
		//Sandpit, 
		Sawmill, 
		Shaman,
		Statue,
		Tavern, 
		Temple, 
		Tower, 
		//Wall, 
		//WallPlateau, 
		Warehouse,
		WaterPlateau
	}

	public abstract class Building {
		protected BuildingID _id;
		protected string _name;
		protected int _baseScore;
		protected int _modToSelf;
		protected double _radius;
		protected int _size;
		protected List<BiomeID> _reqBiome;
		protected int _variant;

		protected List<(BuildingID, int)> _scoreMods;

	public double CalculateScore(int xCoordinate, int yCoordinate) {
			double score = BaseScore;
			List<Building> buildingsInRadius = GetBuildingsInRadius(xCoordinate, yCoordinate);
			foreach (Building b in buildingsInRadius) {
				//score
			}
			

			return score;
		}

		private List<Building> GetBuildingsInRadius(int xCoordinate, int yCoordinate) {
			return null;
		}

		public string Name { get => _name; }
		public int BaseScore { get => _baseScore; }
		public int ModToSelf { get => _modToSelf; }
		public double Radius { get => _radius; }
		public int Size { get => _size; }
		public List<(BuildingID, int)> ScoreMods { get => _scoreMods; }
		public List<BiomeID> ReqBiome { get => _reqBiome; }
		public int Variant { get => _variant; set => _variant = value; }
	}
}
