using RimWorld;
using RimWorld.Planet;

namespace RealisticBiomes{
    class Tundra : BiomeWorker{
        public override float GetScore(Tile tile, int tileID){
            if(tile.WaterCovered){
                return 0f;
            }
            else if(tile.temperature < -20 || tile.temperature > -4){
                return 0f;
            }
			else{
				return 100f;
			}
        }
    }
    class IceCapLand : BiomeWorker{
        public override float GetScore(Tile tile, int tileID){
            if(tile.WaterCovered){
                return 0f;
            }
            else if(tile.temperature > -20){
                return 0f;
            }
			else{
				return 100f;
			}
        }
    }
    class IceCapSea : BiomeWorker{
        public override float GetScore(Tile tile, int tileID){
            if(!tile.WaterCovered){
                return 0f;
            }
            else if(tile.temperature > -20){
                return 0f;
            }
			else{
				return 100f;
			}
        }
    }
}