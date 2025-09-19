using System;

namespace TARpv24_Ckeel
{
    public class Hambaarst : Töötaja
    {
        public string Hambakliinik;
        public string Technika;

        public override void Mida_teeb()
        {
            Console.WriteLine($"{Nimi} töötab hambaarstina kliinikus {Hambakliinik} ja kasutab {Technika} tehnikat.");
        }
    }
}
