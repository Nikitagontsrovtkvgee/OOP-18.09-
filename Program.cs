using System;
using System.Numerics;

namespace TARpv24_Ckeel
{
    public class StartClassOOP
    {
        public static void Main(string[] args)
        {
            Õpilane inimenel = new Õpilane();
            inimenel.Nimi = "Juku";
            inimenel.Vanus = 12;
            inimenel.Tervita();

            Õpilane inimene2 = new Õpilane("Kati", 28);

            Töötaja töötajal = new Töötaja();
            töötajal.Nimi = "Mati";
            töötajal.Vanus = 45;
            töötajal.Ametikoht = "Autojuht";
            töötajal.Tervita();
            töötajal.Töötan();
            töötajal.Mida_teeb();

            töötajal.Tunnid = 160;
            double palk = töötajal.ArvutaPalk();
            Console.WriteLine($"Töötaja {töötajal.Nimi} teenib kuus {palk} eurot.");

            Console.WriteLine($"Algne konto on {töötajal.Konto.Saldo} eurot");
            töötajal.Konto.Saldo += 1000;
            Console.WriteLine($"Pärast palka on kontol {töötajal.Konto.Saldo} eurot.");
            töötajal.Konto.VõtaRaha(200);
            Console.WriteLine($"Pärast sularaha võtmist on kontol {töötajal.Konto.Saldo} eurot.");
            töötajal.Konto.LisaRaha(500);
            Console.WriteLine($"Pärast raha lisamist on kontol {töötajal.Konto.Saldo} eurot.");

            //3 Tee ise vähemalt 2 alamklassi ja kasuta neid siin
            //4-5 Tee enda põhiklass ja 2 alamklass ning kasuta neid siin

            Ehitaja ehitajal = new Ehitaja();
            ehitajal.Nimi = "Andor";
            ehitajal.Vanus = 52;
            ehitajal.Tervita();
            ehitajal.objektiAsukoht = "Ehitaja tee 48";
            ehitajal.Töötan();
            ehitajal.tööandja = "Mati";

            Hambaarst hambaarstil = new Hambaarst();
            hambaarstil.Nimi = "Juku";
            hambaarstil.Vanus = 42;
            hambaarstil.Tervita();
            hambaarstil.hambakliinik = "Ravi 7";
            hambaarstil.Töötan();
            hambaarstil.tehnika = "S klass";


        }
    }
}
