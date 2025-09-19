using System;

namespace TARpv24_Ckeel
{
    public class Õpilane : Inimene
    {
        public string Rühm_Klass;
        public string Kool;

        public Õpilane() { }

        public Õpilane(string nimi, int vanus) : base(nimi, vanus) { }

        public override void Mida_teeb()
        {
            Console.WriteLine($"{Nimi} õpib koolis.");
        }
    }
}
