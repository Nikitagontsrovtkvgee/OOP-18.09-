namespace TARpv24_Ckeel
{

    public class StartClassOOP
    {
        public static void Main(string[] args)
        {
            Inimene inimenel = new Inimene();
            inimenel.Nimi = "Juku";
            inimenel.Vanus = 12;
            inimenel.Tervita();

            inimenel inimene2 = new inimene("kati", 28);

            Töötaja töötajal = new Töötaja();
            töötajal.Nimi = "Mati";
            töötajal.Vanus = 45;
            töötajal.Ametikoht = "Autojuht";
            töötajal.Tervita();
            töötajal.Töötan();
            //3 Tee ise vähemalt 2 alamklassi ja kasuta neid siin
            //4-5 Tee enda põhiklass ja 2 alamklass ning kasuta neid siin

            Ehitaja ehitajal = new Ehitaja();
            ehitajal.Nimi = "Andor";
            ehitajal.Vanus = 52;
            ehitajal.Tervita();
            ehitajal.objektiAsukoht = "Ehitaja tee 48";
            ehitajal.Töötan();
            ehitajal.tööandja = "Mati";
        }
    }
}