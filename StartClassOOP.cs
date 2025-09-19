using System;

namespace TARpv24_Ckeel
{
    public abstract class Inimene
    {
        public string Nimi;
        public int Vanus;
        public Pank Konto { get; set; }

        public Inimene(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
            Konto = new Pank();
        }

        public Inimene()
        {
            Nimi = "Mati";
            Vanus = 20;
            Konto = new Pank();
        }

        public void Tervita()
        {
            Console.WriteLine("Tere! Mina olen " + Nimi);
        }

        public abstract void Mida_teeb();
    }

    public interface IKujund
    {
        double ArvutaPindala();
        double ArvutaÜmbermõõt();
    }
}
