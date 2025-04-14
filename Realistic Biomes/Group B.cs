using RimWorld.Planet;
using RimWorld;

namespace RealisticBiomes{
    class HotDesert : BiomeWorker{
        public override float GetScore(Tile tile, int tileID){
            if(tile.WaterCovered){
                return 0f;
            }
            else if(tile.temperature < 18){
                return 0f;
            }
            else if(Program.IsDry(tile.temperature, tile.rainfall) != Dryness.Arid){
                return 0f;
            }
            else{
                return 100f;
            }
        }
    }
    class ColdDesert : BiomeWorker{
        public override float GetScore(Tile tile, int tileID){
            if(tile.WaterCovered){
                return 0f;
            }
            else if(tile.temperature > 18){
                return 0f;
            }
            else if(Program.IsDry(tile.temperature, tile.rainfall) != Dryness.Arid){
                return 0f;
            }
            else{
                return 100f;
            }
        }
    }
    class HotSteppe : BiomeWorker{
        public override float GetScore(Tile tile, int tileID){
            if(tile.WaterCovered){
                return 0f;
            }
            else if(tile.temperature < 18){
                return 0f;
            }
            else if(Program.IsDry(tile.temperature, tile.rainfall) != Dryness.Semiarid){
                return 0f;
            }
            else{
                return 100f;
            }
        }
    }
    class ColdSteppe : BiomeWorker{
        public override float GetScore(Tile tile, int tileID){
            if(tile.WaterCovered){
                return 0f;
            }
            else if(tile.temperature > 18){
                return 0f;
            }
            else if(Program.IsDry(tile.temperature, tile.rainfall) != Dryness.Semiarid){
                return 0f;
            }
            else{
                return 100f;
            }
        }
    }
}