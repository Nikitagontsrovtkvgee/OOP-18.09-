using System;

namespace TARpv24_Ckeel
{
    public class Jalgratas : ISõiduk
    {
        public double LäbitudKm { get; set; }

        public Jalgratas(double läbitudKm)
        {
            LäbitudKm = läbitudKm;
        }

        public double ArvutaKulu() => 0; // Jalgratas ei kasuta kütust

        public double ArvutaVahemaa() => LäbitudKm;

        public override string ToString()
        {
            return $"Jalgratas: {LäbitudKm} km, kulu: {ArvutaKulu():F2} €";
        }
    }
}
