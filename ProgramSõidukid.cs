using System;
using System.Collections.Generic;
using System.IO;

namespace TARpv24_Ckeel
{
    public class ProgramSõidukid
    {
        public static void Main(string[] args)
        {
            List<ISõiduk> sõidukid = new List<ISõiduk>();

            // --- Failist lugemine (bonus) ---
            if (File.Exists("andmed.txt"))
            {
                Console.WriteLine("Loeme sõidukid failist andmed.txt ...");
                string[] read = File.ReadAllLines("andmed.txt");

                foreach (string rida in read)
                {
                    try
                    {
                        string[] osad = rida.Split(';');
                        switch (osad[0])
                        {
                            case "Auto":
                                sõidukid.Add(new Auto(
                                    double.Parse(osad[1]),
                                    double.Parse(osad[2]),
                                    double.Parse(osad[3])));
                                break;
                            case "Jalgratas":
                                sõidukid.Add(new Jalgratas(double.Parse(osad[1])));
                                break;
                            case "Buss":
                                sõidukid.Add(new Buss(
                                    double.Parse(osad[1]),
                                    double.Parse(osad[2]),
                                    double.Parse(osad[3]),
                                    int.Parse(osad[4])));
                                break;
                            case "Elektritõukeratas":
                                sõidukid.Add(new Elektritõukeratas(
                                    double.Parse(osad[1]),
                                    double.Parse(osad[2]),
                                    double.Parse(osad[3])));
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Viga failist lugemisel: {ex.Message}");
                    }
                }
            }

            // --- Kasutaja sisestamine ---
            while (true)
            {
                Console.WriteLine("\nVali sõiduk: 1=Auto, 2=Jalgratas, 3=Buss, 4=Elektritõukeratas, 0=Välju");
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
                            sõidukid.Add(new Jalgratas(kmBike));
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

                        case "4":
                            Console.Write("Aku kulu (kWh/100km): ");
                            double aku = double.Parse(Console.ReadLine());
                            Console.Write("Läbitud km: ");
                            double kmE = double.Parse(Console.ReadLine());
                            Console.Write("Elektri hind €/kWh: ");
                            double elekter = double.Parse(Console.ReadLine());
                            sõidukid.Add(new Elektritõukeratas(aku, kmE, elekter));
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

            // --- Tulemused ---
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
