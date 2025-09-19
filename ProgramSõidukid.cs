using System;
using System.Collections.Generic;

namespace TARpv24_Ckeel
{
    public class ProgramSõidukid
    {
        public static void Main(string[] args)
        {
            List<ISõiduk> sõidukid = new List<ISõiduk>();

            while (true)
            {
                Console.WriteLine("\nVali sõiduk: 1=Auto, 2=Jalgratas, 3=Buss, 0=Välju");
                string valik = Console.ReadLine();
                if (valik == "0") break;

                try
                {
                    switch (valik)
                    {
                        case "1":
                            Console.Write("Kütusekulu 100km kohta: ");
                            double kulu = double.Parse(Console.ReadLine());
                            Console.Write("Läbitud km: ");
                            double km = double.Parse(Console.ReadLine());
                            Console.Write("Kütuse hind €/l: ");
                            double hind = double.Parse(Console.ReadLine());
                            sõidukid.Add(new Auto(kulu, km, hind));
                            break;

                        case "2":
                            Console.Write("Läbitud km: ");
                            double kmBike = double.Parse(Console.ReadLine());
                            sõидukid.Add(new Jalgratas(kmBike));
                            break;

                        case "3":
                            Console.Write("Kütusekulu 100km kohta: ");
                            double kuluB = double.Parse(Console.ReadLine());
                            Console.Write("Läbitud km: ");
                            double kmB = double.Parse(Console.ReadLine());
                            Console.Write("Kütuse hind €/l: ");
                            double hindB = double.Parse(Console.ReadLine());
                            Console.Write("Reisijate arv: ");
                            int reisijad = int.Parse(Console.ReadLine());
                            sõidukid.Add(new Buss(kuluB, kmB, hindB, reisijad));
                            break;

                        default:
                            Console.WriteLine("Tundmatu valik!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Viga andmete sisestamisel: {ex.Message}");
                }
            }

            Console.WriteLine("\n--- Sõidukite tulemused ---");
            double koguKulu = 0;
            foreach (var s in sõidukid)
            {
                Console.WriteLine(s.ToString());
                koguKulu += s.ArvutaKulu();
            }
            Console.WriteLine($"\nKogu kulu kokku: {koguKulu:F2} €");
        }
    }
}
