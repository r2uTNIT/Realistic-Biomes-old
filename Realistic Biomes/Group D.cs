using RimWorld;
using RimWorld.Planet;

namespace RealisticBiomes{
    class Continental : BiomeWorker{
        public override float GetScore(Tile tile, int tileID){
            if(tile.WaterCovered){
                return 0f;
            }
            else if(tile.temperature < 6 || tile.temperature > 14){
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
	class ContinentalSwamp : BiomeWorker{
		public override float GetScore(Tile tile, int tileID){
			if(tile.WaterCovered){
				return 0f;
			}
			else if(tile.temperature < 6 || tile.temperature > 14){
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