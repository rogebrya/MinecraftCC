using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCC {
	public class Map {
		private int _xPos;
		private int _yPos;
		private int _zPos;

		private MapCell[] _cells;
		private List<Building> _buildings;
		private List<MapItem> _mapItems;
		private List<Biome> _biomes;

		public Map() { }

		public Map(int xpos, int ypos, int zpos) {
			_xPos = xpos; _yPos = ypos; 
			if(zpos == 0) {
				_zPos = 64;
			}
		}

		public int XPos { get => _xPos; set => _xPos = value; }
		public int YPos { get => _yPos; set => _yPos = value; }
		public int ZPos { get => _zPos; set => _zPos = value; }
		public MapCell[] Cells { get => _cells; set => _cells = value; }
		public List<Building> Buildings { get => _buildings; set => _buildings = value; }
		public List<MapItem> MapItems { get => _mapItems; set => _mapItems = value; }
		public List<Biome> Biomes { get => _biomes; set => _biomes = value; }

		public void FillLists() {
			Biomes = new List<Biome>() { new Biome("Grass", Color.LightGreen), new Biome("Sand", Color.Tan), new Biome("Rock", Color.Gray), 
				new Biome("Water", Color.DarkSlateBlue), new Biome("Cliff", Color.DarkRed), new Biome("Plateau", Color.Brown), new Biome("Wall Plateau", Color.Brown)
			};

			MapItem flower = new MapItem("Flower");
			MapItem goldVein = new MapItem("Gold Vein");
			MapItem tree = new MapItem("Tree");

			Building brewery = new Building("Brewery", 7, -10, 3.5);
			Building brickYard = new Building("Brickyard", 6, -8, 4);
			Building circus = new Building("Circus", 0, -10, 2);
			Building cityCentre = new Building("City Centre", 15, -40, 5);
			Building field = new Building("Field", 3, 2, 2);
			Building fisher = new Building("Fisher", 5, -10, 10);
			Building fountain = new Building("Fountain", 0, -15, 4);
			Building goldMine = new Building("Gold Mine", -20, 0, 1);			
			Building hopField = new Building("Hop Field", 5, 2, 3);
			Building house = new Building("House", 1, 0, 3);
			Building hut = new Building("Hut", 4, 0, 10);
			Building jewelry = new Building("Jewelry", -35, -30, 5);
			Building lumberjack = new Building("Lumberjack", 0, -6, 10);
			Building mansion = new Building("Mansion", 1, 0, 1);
			Building market = new Building("Market", -20, -35, 4);
			Building mason = new Building("Mason", 9, -4, 4);
			Building mill = new Building("Mill", 8, -20, 7);
			Building park = new Building("Park", 2, 0, 4);
			Building plateau = new Building("Plateau", 0, 0, 2);
			Building resort = new Building("Resort Oasis", 0, 0, 3);
			Building sandpit = new Building("Sandpit", 9, -3, 10);
			Building sawmill = new Building("Sawmill", 0, -12, 4);
			Building shaman = new Building("Shaman", 0, -13, 0);
			Building statue = new Building("Statue", 15, -25, 10);
			Building tavern = new Building("Tavern", -15, -15, 5);
			Building temple = new Building("Temple", -75, 0, 1);
			Building tower = new Building("Tower", 0, -20, 20);
			Building wall = new Building("Wall", 2, -2, 3);
			Building wallPlateau = new Building("Wall Plateau", 10, 1, 3);
			Building warehouse = new Building("Warehouse", 0, -15, 5);
			Building waterPlateau = new Building("Water Plateau", 13, 1, 3);

			brewery.ScoreMods = new List<(object, int)>() { (hopField, 5), (statue, 4), (warehouse, 2) };
			brickYard.ScoreMods = new List<(object, int)>() { (mason, 5), (warehouse, 4), (sandpit, 4), (statue, 3) };
			circus.ScoreMods = new List<(object, int)> { (statue, 10), (house, 4), (mansion, -5), (temple, -25) };
			cityCentre.ScoreMods = new List<(object, int)> { (fisher, 7), (statue, 5), (mason, 4), (mill, 2), (shaman, -5), (resort, -15), (cityCentre, -40) };
			field.ReqBiome.Add(Biomes[0]); field.ReqBiome.Add(Biomes[5]);
			field.ScoreMods = new List<(object, int)>() { (mill, 5), (statue, 3), (resort, 3), (field, 2) };
			fisher.ReqBiome.Add(Biomes[3]);
			fisher.ScoreMods = new List<(object, int)>() { (cityCentre, 7), (warehouse, 2), (statue, 2), (hut, 1) };
			fountain.ScoreMods = new List<(object, int)> { (cityCentre, 7), (statue, 3), (park, 3), (mansion, 3), (house, 2), (park, 4) };
			goldMine.ScoreMods = new List<(object, int)> { (goldVein, 35), (warehouse, 10), (jewelry, 10), (statue, 5), (resort, -15) };
			hopField.ReqBiome.Add(Biomes[0]); hopField.ReqBiome.Add(Biomes[1]);
			hopField.ScoreMods = new List<(object, int)>() { (statue, 4), (brewery, 4), (resort, 3), (hopField, 2) };
			house.ScoreMods = new List<(object, int)> { (cityCentre, 6), (shaman, 5), (statue, 4), (wallPlateau, 3), (circus, 3), (fountain, 2), (market, 2), (temple, 2),
				(tavern, 2), (park, 1), (house, 1), (mason, 2), (wall, -2), (jewelry, -2) };
			hut.ScoreMods = new List<(object, int)> { (cityCentre, 6), (statue, 2), (shaman, 2), (fisher, 1), (sawmill, -1), (lumberjack, -1), (warehouse, -1),
				(brickYard, -1), (mill, -1), (mason, -1) };
			jewelry.ReqBiome.Add(Biomes[4]); jewelry.ReqBiome.Add(Biomes[6]);
			jewelry.ScoreMods = new List<(object, int)> { (goldMine, 30), (statue, 6), (mansion, 5), (wall, -3), (house, -4) };
			lumberjack.ScoreMods = new List<(object, int)>() { (sawmill, 5), (statue, 4), (tree, 1) };
			mansion.ScoreMods = new List<(object, int)> { (cityCentre, 8), (shaman, 6), (plateau, 6), (wallPlateau, 6), (statue, 5), (fountain, 3), (park, 2), (market, 2),
				(temple, 2), (jewelry, 2), (mansion, 1), (circus, -3), (wall, -3) };
			market.ReqBiome.Add(Biomes[5]);
			market.ScoreMods = new List<(object, int)> { (warehouse, 20), (cityCentre, 5), (statue, 4), (mason, 4), (fisher, 3), (mansion, 2), (house, 2) };
			mason.ReqBiome.Add(Biomes[4]);
			mason.ScoreMods = new List<(object, int)>() { (brickYard, 4), (statue, 3), (warehouse, 3), (tower, 2), (market, 2), (cityCentre, 2), (plateau, 2), (temple, 2), (wall, 2), (shaman, -5) };
			mill.ScoreMods = new List<(object, int)>() { (warehouse, 4), (statue, 4), (cityCentre, 3), (field, 4), (mason, 2) };
			park.ScoreMods = new List<(object, int)> { (resort, 5), (fountain, 4), (temple, 4), (hopField, 3), (field, 2), (plateau, 2), (statue, 2), (cityCentre, 2), (tree, 1),
				(house, 1), (mansion, 1), (wall, -2), (warehouse, -2), (brickYard, -3), (lumberjack, -4), (mill, -4), (sawmill, -5) };
			plateau.ReqBiome.Add(Biomes[1]); plateau.ReqBiome.Add(Biomes[3]);
			plateau.ScoreMods = new List<(object, int)> { (cityCentre, 10), (mason, 8), (plateau, 5), (statue, 3) };
			resort.ScoreMods = new List<(object, int)> { (hopField, 7), (plateau, 6), (fountain, 5), (park, 5), (waterPlateau, 5), (statue, 4), (flower, 2), (field, 3), (brewery, 2),
				(fisher, 2), (tree, 1), (mill, -3), (house, -5), (brickYard, -5), (lumberjack, -5), (mansion, -7), (sawmill, -10), (goldMine, -10), (cityCentre, -10), (mason, -10), (warehouse, -10) };
			sandpit.ReqBiome.Add(Biomes[1]);
			sandpit.ScoreMods = new List<(object, int)>() { (statue, 3), (brickYard, 3) };
			sawmill.ScoreMods = new List<(object, int)>() { (lumberjack, 7), (warehouse, 6), (statue, 4) };
			shaman.ScoreMods = new List<(object, int)>() { (statue, 5), (temple, 5), (flower, 3), (mason, -6), (cityCentre, -10) };
			tavern.ScoreMods = new List<(object, int)> { (brewery, 18), (cityCentre, 8), (statue, 4), (house, 2) };
			temple.ReqBiome.Add(Biomes[5]);
			temple.ScoreMods = new List<(object, int)> { (statue, 40), (mason, 25), (shaman, 15), (mansion, 10), (wall, 10), (cityCentre, 10), (tower, 10), (house, 8),
				(park, 5), (tavern, -20), (goldMine, -20), (warehouse, -20), (circus, -20), (market, -20), (mill, -20), (brickYard, -20) };
			tower.ScoreMods = new List<(object, int)> { (temple, 8), (mason, 5), (mansion, 1), (park, 1), (wall, 1), (house, 1) };
			wall.ScoreMods = new List<(object, int)> { (temple, 15), (market, 8), (jewelry, 5), (mason, 5), (cityCentre, 4), (plateau, 4), (statue, 4), (park, 2), (mansion, 2), (house, 2) };
			wallPlateau.ReqBiome.Add(Biomes[4]);
			wallPlateau.ScoreMods = new List<(object, int)> { (cityCentre, 4), (statue, 2) };
			warehouse.ScoreMods = new List<(object, int)> { (brickYard, 7), (mill, 7), (goldMine, 7), (fisher, 6), (brewery, 5), (mason, 5), (sawmill, 4), (statue, 4), (resort, -5) };
			waterPlateau.ReqBiome.Add(Biomes[3]);
			waterPlateau.ScoreMods = new List<(object, int)> { (sawmill, 2), (statue, 2), (tree, 1) };
			Buildings = new List<Building>() { 
				brewery, brickYard, circus, cityCentre, field, fisher, fountain, goldMine, hopField, house, hut, jewelry, lumberjack, mansion, market,
				mason, mill, park, plateau, resort, sandpit, sawmill, shaman, tavern, temple, tower, wall, wallPlateau, warehouse
			};
		}
	}

	public class MapCell {

		private bool _hasMapItem;

		private Building _build;
		private MapItem _item;
		private Biome _biome;

		public double Radius { get => _build.Radius; set => _build.Radius = value; }
		public bool HasMapItem { get => _hasMapItem; set => _hasMapItem = value; }
		public Building Build { get => _build; set => _build = value; }
		public MapItem Item { get => _item; set => _item = value; }
		public Biome Biome { get => _biome; set => _biome = value; }
	}

	public class MapItem {
		private string _name;

		public MapItem(string name) {
			_name = name;
		}

		public string Name { get => _name; set => _name = value; }
	}

	public class Biome {
		private string _name;
		private Color _color;

		public Biome(string name, Color color) {
			_name = name; _color = color;
		}

		public string Name { get => _name; set => _name = value; }
		public Color Color { get => _color; set => _color = value; }
	}
}
