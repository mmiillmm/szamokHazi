using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace szamok
{
    class Program
    {

        static List<int> szamok = new List<int>();

        static void Main(string[] args)
        {
            Beolvasas();

            Osszegzes(); // >a számok összege a listában

            Megszamolas(); // >100 <= szám és >= 550

            Kivalasztas(); // >3437 hányadik indexen van

            Kereses(); // >van-e benne 333 és ha van hol

            Maximum(); // >legnagyobb szám

            Minimum(); // >legkisebb szám

            Console.ReadKey();
        }

        private static void Minimum()
        {
            throw new NotImplementedException();
        }

        private static void Maximum()
        {
            throw new NotImplementedException();
        }

        private static void Kereses()
        {
            throw new NotImplementedException();
        }

        private static void Kivalasztas()
        {
            throw new NotImplementedException();
        }

        private static void Megszamolas()
        {
            throw new NotImplementedException();
        }

        private static void Osszegzes()
        {
        }

        private static void Beolvasas()
        {
            StreamReader beolv = new StreamReader("szamok.txt");

            while (!beolv.EndOfStream)
            {
                string sor = beolv.ReadLine();

                Console.WriteLine(sor);
            }

            beolv.Close();
        }
    }
}
