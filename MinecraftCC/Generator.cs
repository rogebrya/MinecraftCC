using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinecraftCC.Buildings;
using MinecraftCC.BuildingPacks;

// Need to make copy of map for multiple iterations
namespace MinecraftCC {
    public class Generator {
        private Map _map;
        private List<BuildingPack> _buildingPacks;
        private Random rnd = new Random();
        private int _totalScore = 0;
        private List<MapCell> _avaliableSpaces;

        public Generator(Map map, int buildingStyle, int villageType) {
            _map = map;
            _buildingPacks = new List<BuildingPack>(){
                new BrewingPack(),
                new CommercePack(),
                new FarmingPack(),
                new FishingPack(),
                new HousingPack(),
                new LumberPack(),
                new OrnamentalPack(),
                new ReligiousPack(),
            };
        }

        public int TotalScore { get => _totalScore; }

        public void Generate() {
            PlaceStartingPoint();
            GenerateListOfAvaliableSpaces();
            while (_avaliableSpaces.Count > 0 && _avaliableSpaces.Count > (0.3 * _map.XSize * _map.ZSize)) {
                BuildingPack bp = PickBuildingPack();
                List<int> pickedIndicies = new List<int>();
                while (pickedIndicies.Count < bp.Buildings.Count) {
                    Building b = PickBuilding(bp, pickedIndicies);
                    PlaceBuilding(b);
                }
            }
        }


        // Done
        private BuildingPack PickBuildingPack() {
            return _buildingPacks[rnd.Next(0, _buildingPacks.Count)];
        }

        // Done
        private Building PickBuilding(BuildingPack bp, List<int> pickedIndicies) {
            int picked = rnd.Next(0, bp.Buildings.Count); ; 
            while (pickedIndicies.Contains(picked)) {
                picked = rnd.Next(0, bp.Buildings.Count);
            }
            pickedIndicies.Add(picked);
            return bp.Buildings[picked];
        }

        // Done
        private void PlaceStartingPoint() {
            CityCenter center = new CityCenter();
            int x = rnd.Next(0, _map.XSize);
            int z = rnd.Next(0, _map.ZSize);
            while (!center.ReqBiome.Contains(_map.Cells[x, z].Biome.ID)) {
                x = rnd.Next(0, _map.XSize);
                z = rnd.Next(0, _map.ZSize);
            }
            _map.Cells[x, z].Building = center;
        }

        // Done
        private void PlaceBuilding(Building b) {
            int maxBuildingScore = 0;
            List<MapCell> maxBuildingScoreLocations = new List<MapCell>();
            int tempBuildingScore = 0;
            foreach (MapCell mc in _avaliableSpaces) {
                if (b.ReqBiome.Contains(mc.Biome.ID)) {
                    tempBuildingScore = CalculateScore(mc, b);
                    if (tempBuildingScore > maxBuildingScore) {
                        maxBuildingScore = tempBuildingScore;
                        maxBuildingScoreLocations.Clear();
                        maxBuildingScoreLocations.Add(mc);
                    } else if (tempBuildingScore == maxBuildingScore){
                        maxBuildingScoreLocations.Add(mc);
                    }
                }
            }
            if (maxBuildingScoreLocations.Count > 0) {
                maxBuildingScoreLocations[rnd.Next(0, maxBuildingScoreLocations.Count)].Building = b;
                _totalScore += maxBuildingScore;
                _avaliableSpaces.Remove(maxBuildingScoreLocations[rnd.Next(0, maxBuildingScoreLocations.Count)]);
            }
        }

        // Done
        private void GenerateListOfAvaliableSpaces() {
            _avaliableSpaces = new List<MapCell>();
            foreach (MapCell mc in _map.Cells) {
                if (mc.Building == null) {
                    _avaliableSpaces.Add(mc);
                }
            }
        }

        // Done
        private int CalculateScore(MapCell mc, Building b) {
            int score = b.BaseScore;
            List<Building> buildingsInRadius = GetBuildingsInRadius(mc.X, mc.Z, b.Radius);
            if (buildingsInRadius.Count != 0) {
                foreach (Building bInR in buildingsInRadius) {
                    foreach ((BuildingID, int) bi in b.ScoreMods) {
                        if (bi.Item1 == bInR.ID) {
                            score += bi.Item2;
                            break;
                        }
                    }
                }
            }
            return score;
        }

        // Done
        private List<Building> GetBuildingsInRadius(int x, int z, int rad) {
            List<Building> buildings = new List<Building>();
            int xMin = 0;
            int xMax = _map.XSize;
            int zMin = 0;
            int zMax = _map.ZSize;
            if (x - rad > xMin) {
                xMin = x - rad;
            }
            if (x + rad < xMax) {
                xMax = x + rad;
            }
            if (z - rad > zMin) {
                zMin = z - rad;
            }
            if (z + rad < zMax) {
                zMax = z + rad;
            }
            for (int i = xMin; i < xMax; i++) {
                for (int j = zMin; j < zMax; j++) {
                    if (_map.Cells[i, j].Building != null) {
                        buildings.Add(_map.Cells[i, j].Building);
                    }
                }
            }
            return buildings;
        }
    }
}
