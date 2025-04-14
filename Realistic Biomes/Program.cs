using Verse;

namespace RealisticBiomes{
    [StaticConstructorOnStartup]
    static class Program{
        static Program(){Log.Message("Ello mate!");}
        
        public static Dryness? IsDry(float temp, float rainfall){
            float rainfall_percent = temp * 5f;
        
            if(rainfall < 10 * (temp - 10) + 3 * rainfall_percent){return Dryness.Arid;}
            else if(rainfall < (10 * (temp - 10) + 3 * rainfall_percent) * 2){return Dryness.Semiarid;}
            else{return null;}
        }
    }
    enum Dryness{
        Arid,
        Semiarid
    }
}