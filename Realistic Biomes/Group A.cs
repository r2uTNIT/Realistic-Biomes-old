using RimWorld;
using RimWorld.Planet;

namespace RealisticBiomes{
    class TropicalWet : BiomeWorker{
        public override float GetScore(Tile tile, int tileID){
			if(tile.WaterCovered){
            	return 0f;
            }
			else if(tile.temperature < 20){
				return 0f;
			}
			else if(Program.IsDry(tile.temperature, tile.rainfall) != null){
				return 0f;
			}
			else if(tile.rainfall >= 2000){
				return 0f;
			}
            else if(tile.swampiness >= 0.75f){
                return 0f;
            }
			else{
				return 100f;
			}
        }
    }
	class TropicalWetRainforest : BiomeWorker{
        public override float GetScore(Tile tile, int tileID){
			if(tile.WaterCovered){
            	return 0f;
            }
			else if(tile.temperature < 20){
				return 0f;
			}
			else if(Program.IsDry(tile.temperature, tile.rainfall) != null){
				return 0f;
			}
			else if(tile.rainfall < 2000){
				return 0f;
			}
            else if(tile.swampiness >= 0.75f){
                return 0f;
            }
			else{
				return 100f;
			}
		}
    }
	class TropicalWetSwamp : BiomeWorker{
		public override float GetScore(Tile tile, int tileID){
			if(tile.WaterCovered){
				return 0f;
			}
			else if(tile.temperature < 20){
				return 0f;
			}
			else if(Program.IsDry(tile.temperature, tile.rainfall) != null){
				return 0f;
			}
			else if(tile.swampiness < 0.75f){
				return 0f;
			}
			else{
				return 100f;
			}
		}
	}
}