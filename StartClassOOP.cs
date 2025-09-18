using System;

public abstract class Inimene
{
    public string Nimi;
    public int vanus;

    public Inimene(string nimi, int vanus)
    {
        Nimi = nimi;
        Vanus = vanus;

        public Inimene()
        {
        Nimi = "Mati"

            Vanus = 20

        }

        public void Tervita()
        {
            Console.WriteLine("Tere! Mina olen " + Nimi);
        }
        public abstract void Mida_teeb();
        
    }
}