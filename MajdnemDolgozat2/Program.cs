using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


//kezdes: 18:05

namespace MajdnemDolgozat2
{
    internal class Program
    {
       
        static List<Tanulo> Tanulok = new List<Tanulo>();
        static int AktualisHonap=5;

        static void Main(string[] args)
        {
            Feladat02();
            Feladat03();
            Feladat04();
            Feladat05();

            Console.ReadLine();

        }

        private static void Feladat05()
        {

            List<string> ElmaradottakListaja = new List<string>();

            foreach (var item in Tanulok)
            {
                if (item.FinanszirozasFormaja == 0 & item.BefizetettOsszeg < 2600) ElmaradottakListaja.Add(item.Nev);
                
            }

            Console.WriteLine("5. feladat:");
            Console.WriteLine("\tA kovetkezo tanuloknak van tandijelmaradas:");
         
            foreach (var item in ElmaradottakListaja)
            {
                Console.WriteLine($"\t{item}");
            }

        }

        private static void Feladat04()
        {
            int FiukDarabszama = 0;
            int LanyokDarabszama = 0;
            float FiukOsszege = 0;
            float LanyokOsszege =0;

            foreach (var item in Tanulok)
            {
               
                if (item.Nem)
                {
                    FiukOsszege +=  (item.Eredmeny1 + item.Eredmeny2 + item.Eredmeny3 + item.Eredmeny4) / 4;
                    FiukDarabszama++;
                }
                else
                {
                    LanyokOsszege += (item.Eredmeny1 + item.Eredmeny2 + item.Eredmeny3 + item.Eredmeny4) / 4;
                    LanyokDarabszama++;
                }

            }

            Console.WriteLine("4. feladat:");
            Console.WriteLine($"\tFiuk atlagteljesitmenye: {FiukOsszege/FiukDarabszama}%");
            Console.WriteLine($"\tLanyok atlagteljesitmenye: {LanyokOsszege/LanyokDarabszama}%");
        }

        private static void Feladat03()
        {
            Console.WriteLine("3. feladat:");
            Console.WriteLine($"\tA tanfolyamra {Tanulok.Count} fo iratkozott be");
        }

        private static void Feladat02()
        {
            using (var sr = new StreamReader(@"..\\..\\Resources\coursedata.csv", Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    Tanulok.Add( new Tanulo(sr.ReadLine()));
                }
            }
          

        }
    }
}
