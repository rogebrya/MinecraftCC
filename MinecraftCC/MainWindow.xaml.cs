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
		}

		Map map;

		public void InitializeMap() {
			map = new Map(10, 10, 0);
			for(int i = 0; i < map.Cells.GetUpperBound(0); i++) {
				game.RowDefinitions.Add(new RowDefinition());
				for(int j = 0; j < map.Cells.GetUpperBound(1); j++) {
					game.ColumnDefinitions.Add(new ColumnDefinition());
					TextBlock tb = new TextBlock();
                    tb.Name = "tb_" + j + "_" + i;
                    tb.TextWrapping = TextWrapping.Wrap;
                    tb.TextAlignment = TextAlignment.Center;
                    //tb.Background = Brushes.Black;
                    Border border = new Border();
                    border.BorderBrush = new SolidColorBrush(Colors.Black);
                    border.BorderThickness = new Thickness(1);
					tb.Background = map.Cells[i, j].Biome.Color;
                    game.Children.Add(tb);
                    Grid.SetRow(tb, i);
                    Grid.SetColumn(tb, j);
                    Grid.SetColumn(border, j);
                    Grid.SetRow(border, i);
                    game.Children.Add(border);
                }
			}

		}
		
	}
}
