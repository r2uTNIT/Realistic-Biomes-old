using RimWorld;
using RimWorld.Planet;

namespace RealisticBiomes{
    class Subarctic : BiomeWorker{
        public override float GetScore(Tile tile, int tileID){
            if(tile.WaterCovered){
                return 0f;
            }
            else if(tile.temperature < -4 || tile.temperature > 6){
                return 0f;
            }
            else if(Program.IsDry(tile.temperature, tile.rainfall) != null){
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
    class SubarcticSwamp : BiomeWorker{
        public override float GetScore(Tile tile, int tileID){
            if(tile.WaterCovered){
				return 0f;
			}
			else if(tile.temperature < -4 || tile.temperature > 6){
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