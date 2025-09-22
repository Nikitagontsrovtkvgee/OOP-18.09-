using System;

namespace TARpv24_Ckeel
{
    public class Elektritõukeratas : ISõiduk
    {
        public double AkuKuluKwh100km { get; set; } // kWh / 100 km
        public double LäbitudKm { get; set; }
        public double ElektriHind { get; set; } // €/kWh

        public Elektritõukeratas(double akuKuluKwh100km, double läbitudKm, double elektriHind)
        {
            AkuKuluKwh100km = akuKuluKwh100km;
            LäbitudKm = läbitudKm;
            ElektriHind = elektriHind;
        }

        public double ArvutaKulu()
        {
            double kWh = (AkuKuluKwh100km / 100.0) * LäbitudKm;
            return kWh * ElektriHind;
        }

        public double ArvutaVahemaa() => LäbitudKm;

        public override string ToString()
        {
            return $"Elektritõukeratas: {LäbitudKm} km, kulu: {ArvutaKulu():F2} €";
        }
    }
}
