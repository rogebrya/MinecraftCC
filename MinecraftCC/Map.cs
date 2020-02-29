using System;
using System.Collections.Generic;
using System.Windows.Media;
using MinecraftCC.Biomes;

namespace MinecraftCC {
	public class Map {
		private int _xSize;
		private int _zSize;
		//private Biome _biome;
		//private int _baseElevation = 64;

		private MapCell[,] _cells;
		private List<Biome> _biomes;

		public Map(int xpos, int zpos) {
			_xSize = xpos; _zSize = zpos;
			_cells = new MapCell[xpos, zpos];
			FillBiomeList();
			FillMap();
		}

		public int XSize { get => _xSize; set => _xSize = value; }
		public int ZSize { get => _zSize; set => _zSize = value; }
		public MapCell[,] Cells { get => _cells; set => _cells = value; }
		public List<Biome> Biomes { get => _biomes; set => _biomes = value; }

		public void FillMap() {
			for (int i = 0; i < XSize; i++) {
				for (int j = 0; j < ZSize; j++) {
					_cells[i, j] = new MapCell(i, j, Biomes[(int)BiomeID.Plains]);
				}
			}
		}

		public void FillBiomeList() {
			Biomes = new List<Biome>();
			Biomes.Add(new Coast());		//0
			Biomes.Add(new Desert());		//1
			Biomes.Add(new Forest());		//2
			Biomes.Add(new Mountain());		//3
			Biomes.Add(new Ocean());		//4
			Biomes.Add(new Plains());		//5
			Biomes.Add(new Tundra());		//6
		}

		/*
		public void FillLists() {
			MapItem flower = new MapItem("Flower");
			MapItem goldVein = new MapItem("Gold Vein");
			MapItem tree = new MapItem("Tree");
			MapItems = new List<MapItem>() { flower, goldVein, tree };

			Building goldMine = new Building("Gold Mine", -20, 0, 1);
			Building jewelry = new Building("Jewelry", -35, -30, 5);
			Building plateau = new Building("Plateau", 0, 0, 2);
			Building sandpit = new Building("Sandpit", 9, -3, 10);
			Building wall = new Building("Wall", 2, -2, 3);
			Building wallPlateau = new Building("Wall Plateau", 10, 1, 3);
			
			goldMine.ScoreMods = new List<(object, int)>() { (goldVein, 35), (warehouse, 10), (jewelry, 10), (statue, 5), (resort, -15) };
			jewelry.ScoreMods = new List<(object, int)>() { (goldMine, 30), (statue, 6), (mansion, 5), (wall, -3), (house, -4) };
			plateau.ScoreMods = new List<(object, int)>() { (cityCentre, 10), (mason, 8), (plateau, 5), (statue, 3) };
			sandpit.ScoreMods = new List<(object, int)>() { (statue, 3), (brickYard, 3) };
			wall.ScoreMods = new List<(object, int)>() { (temple, 15), (market, 8), (jewelry, 5), (mason, 5), (cityCentre, 4), (plateau, 4), (statue, 4), (park, 2), (mansion, 2), (house, 2) };
			wallPlateau.ScoreMods = new List<(object, int)>() { (cityCentre, 4), (statue, 2) };
		}
		*/
	}
}
