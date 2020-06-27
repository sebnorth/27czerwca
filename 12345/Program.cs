using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12345
{
    class Program
    {
        static void Main(string[] args)
        {

            #region testy1

            
            List<Konto> bank = new List<Konto>();
            bank.Add(new Konto("Zuzia", 500));
            bank.Add(new Konto("Basia", 600));
            bank.Add(new Konto("Czesia", 700));
            bank.Add(new KontoFirmowe("Daria", 1500));
            bank.Add(new KontoFirmowe("Ewa", 2500));
            bank.Add(new KontoFirmowe("Fiona", 3500));

            foreach (Konto konto in bank)
            {
                konto.Wyplata(100);
            }

            foreach (Konto konto in bank)
            {
                Console.WriteLine(konto);
            }

            //bank = bank.OrderBy(konto => konto.Wlasciciel).ToList();

            //bank.Reverse();

            bank = bank.OrderByDescending(konto => konto.Wlasciciel).ToList();

            foreach (Konto konto in bank)
            {
                Console.WriteLine(konto);
            }

            bank.Reverse();

            foreach (Konto konto in bank)
            {
                Console.WriteLine(konto);
            }
            #endregion

            #region testy2

            Console.WriteLine($"Podaj wpłatę");
            int.TryParse(Console.ReadLine(), out int naszawplata);
            ROR ror = new ROR();
            ror.Wplata(naszawplata);
            Console.WriteLine($"Aktualne saldo wynosi: {ror.Saldo}");
            ror.Odsetki();
            Console.WriteLine($"Aktualne saldo wynosi: {ror.Saldo}");

            // zadanie dla Państwa - użyć konstrukcji try catch do obsługi poprawnej wpłaty

            #endregion
            Console.ReadKey();

        }
    }
}
