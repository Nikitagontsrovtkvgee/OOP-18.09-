using System;

namespace TARpv24_Ckeel
{
    public class Ehitaja : Töötaja
    {
        public string ObjektiAsukoht;
        public string Tööandja;

        public override void Mida_teeb()
        {
            Console.WriteLine($"{Nimi} ehitab objektil {ObjektiAsukoht}, tööandja on {Tööandja}.");
        }
    }
}
