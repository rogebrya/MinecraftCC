using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MinecraftCC {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
			InitializeMap();
			CreateTestTerrain();
		}

		Map map;
		List<TextBlock> listOfTBs = new List<TextBlock>();

		public void InitializeMap() {
			map = new Map(10, 10);
			for (int i = 0; i < map.XSize; i++) {
				gdGame.RowDefinitions.Add(new RowDefinition());
				gdGame.ColumnDefinitions.Add(new ColumnDefinition());
			}
			for (int i = 0; i < map.XSize; i++) {
				for (int j = 0; j < map.ZSize; j++) {
					TextBlock tb = new TextBlock();
					tb.Name = "tb_" + j + "_" + i;
					tb.TextWrapping = TextWrapping.Wrap;
					tb.TextAlignment = TextAlignment.Center;
					//tb.Background = Brushes.Black;
					Border border = new Border();
					border.BorderBrush = new SolidColorBrush(Colors.Black);
					border.BorderThickness = new Thickness(1);
					tb.Background = map.Cells[i, j].Biome.Color;
					gdGame.Children.Add(tb);
					Grid.SetRow(tb, i);
					Grid.SetColumn(tb, j);
					Grid.SetColumn(border, j);
					Grid.SetRow(border, i);
					gdGame.Children.Add(border);
					listOfTBs.Add(tb);
				}
			}
		}

		public void CreateTestTerrain() {
			List<(int, int, BiomeID)> alterations =  new List<(int, int, BiomeID)>() {
				(0, 0, BiomeID.Desert),
				(0, 1, BiomeID.Desert),
				(0, 2, BiomeID.Desert),
				(0, 3, BiomeID.Desert),
				(1, 0, BiomeID.Desert),
				(1, 1, BiomeID.Desert),
				(1, 2, BiomeID.Desert),
				(1, 3, BiomeID.Desert),
				(2, 1, BiomeID.Desert),
				(2, 2, BiomeID.Desert),
				(3, 2, BiomeID.Desert),
				(9, 4, BiomeID.Coast),
				(9, 5, BiomeID.Ocean),
				(9, 6, BiomeID.Ocean),
				(9, 7, BiomeID.Ocean),
				(8, 4, BiomeID.Coast),
				(8, 5, BiomeID.Coast),
				(8, 6, BiomeID.Coast),
				(8, 7, BiomeID.Ocean),
				(7, 6, BiomeID.Coast),
				(7, 7, BiomeID.Coast),
				(7, 8, BiomeID.Coast),
				(8, 8, BiomeID.Coast),
				(9, 8, BiomeID.Coast),
				(5, 5, BiomeID.Mountain),
				(5, 4, BiomeID.Mountain),
				(4, 3, BiomeID.Mountain),
				(4, 4, BiomeID.Mountain),
				(5, 9, BiomeID.Forest),
				(4, 9, BiomeID.Forest),
				(3, 9, BiomeID.Forest),
				(2, 9, BiomeID.Forest),
				(3, 8, BiomeID.Forest),
				(4, 8, BiomeID.Forest),
				(5, 8, BiomeID.Forest),
				(6, 8, BiomeID.Forest),
				(6, 3, BiomeID.Forest),
				(7, 3, BiomeID.Forest),
				(8, 3, BiomeID.Forest),
				(7, 4, BiomeID.Forest)
			};
			foreach ((int, int, BiomeID) alt in alterations) {
				map.Cells[alt.Item1, alt.Item2].Biome = map.Biomes[(int)(alt.Item3)];
				if (alt.Item3 == BiomeID.Forest) {
					map.Cells[alt.Item1, alt.Item2].Building = new Buildings.Trees();
				}
			}
			UpdateMapDisplay();
		}

		private void btnGenerate_Click(object sender, RoutedEventArgs e) {
			((Button)sender).IsEnabled = false;
			int scoreThreshold = 3 * map.XSize * map.ZSize;
			int totalScore = 0;
			//while (totalScore < scoreThreshold) {
				Generator g = new Generator(map, cbBuildingStyle.SelectedIndex, cbVillageType.SelectedIndex);
				g.Generate();
				totalScore = g.TotalScore;
			//}
			UpdateMapDisplay();
			((Button)sender).IsEnabled = true;
		}

		public void UpdateMapDisplay() {
			int i = 0;
			int j = 0;
			foreach (TextBlock tb in listOfTBs) {
				tb.Background = map.Cells[i, j].Biome.Color;
				if (map.Cells[i, j].Building != null) {
					tb.Text = map.Cells[i, j].Building.Name;
					if (map.Cells[i, j].Biome.Color == Brushes.DarkBlue || map.Cells[i, j].Biome.Color == Brushes.Green) {
						tb.Foreground = new SolidColorBrush(Colors.White);
					}
					if (map.Cells[i, j].Building.ID == BuildingID.CityCenter) {
						tb.Foreground = new SolidColorBrush(Colors.Red);
					}
				}
				j++;
				if (j == map.ZSize) {
					j = 0;
					i++;
				}
			}
		}
	}
}
