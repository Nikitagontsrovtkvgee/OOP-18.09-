using System;

namespace TARpv24_Ckeel
{
    public class Pank
    {
        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value >= 0)
                    saldo = value;
            }
        }

        public void VõtaRaha(double summa)
        {
            if (summa > 0 && summa <= saldo)
                saldo -= summa;
            else
                Console.WriteLine("Teie kontol pole piisavalt raha.");
        }

        public void LisaRaha(double summa)
        {
            if (summa > 0)
                saldo += summa;
            else
                Console.WriteLine("Vale summa!");
        }
    }
}
