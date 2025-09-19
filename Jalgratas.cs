using System;

namespace TARpv24_Ckeel
{
    public class Buss : ISõiduk
    {
        public double Kütusekulu100km { get; set; }
        public double LäbitudKm { get; set; }
        public double KütuseHind { get; set; }
        public int ReisijateArv { get; set; }

        public Buss(double kütusekulu100km, double läbitudKm, double kütuseHind, int reisijateArv)
        {
            Kütusekulu100km = kütusekulu100km;
            LäbitudKm = läbitudKm;
            KütuseHind = kütuseHind;
            ReisijateArv = reisijateArv;
        }

        public double ArvutaKulu()
        {
            double liitrid = (Kütusekulu100km / 100.0) * LäbitudKm;
            double koguKulu = liitrid * KütuseHind;
            return koguKulu / ReisijateArv; // jagame reisijate vahel
        }

        public double ArvutaVahemaa() => LäbitudKm;

        public override string ToString()
        {
            return $"Buss: {LäbitudKm} km, kulu per reisija: {ArvutaKulu():F2} €";
        }
    }
}
