using System;

namespace TARpv24_Ckeel
{
    public class Auto : ISõiduk
    {
        public double Kütusekulu100km { get; set; } // liitrit 100 km kohta
        public double LäbitudKm { get; set; }
        public double KütuseHind { get; set; } // €/liiter

        public Auto(double kütusekulu100km, double läbitudKm, double kütuseHind)
        {
            Kütusekulu100km = kütusekulu100km;
            LäbitudKm = läbitudKm;
            KütuseHind = kütuseHind;
        }

        public double ArvutaKulu()
        {
            double liitrid = (Kütusekulu100km / 100.0) * LäbitudKm;
            return liitrid * KütuseHind;
        }

        public double ArvutaVahemaa() => LäbitudKm;

        public override string ToString()
        {
            return $"Auto: {LäbitudKm} km, kulu: {ArvutaKulu():F2} €";
        }
    }
}
