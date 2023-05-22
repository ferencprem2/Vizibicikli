using System.IO;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        public static List<Kolcsonzes> kolcsonzesek = new();
        static void Main(string[] args)
        {
            ParseTxtContent();

            //5
            Console.WriteLine($"5.feladat: {kolcsonzesek.Count()}");

            //6.
            Console.WriteLine("6.feladat: Kérek egy nevet:");
            String megadottNev = "Kata";
            Console.WriteLine(megadottNev);
            Console.WriteLine($"\t{megadottNev} kölcsönzései:");

            if (kolcsonzesek.Count(x => x.Nev == megadottNev) == 0)
            {
                Console.WriteLine("Nem volt ilyen nevű kölcsönző!");
            }
            else
            {
                kolcsonzesek.Where(x => x.Nev == megadottNev)
                    .ToList()
                    .ForEach(x => Console.WriteLine($"{x.Eora}:{x.Eperc}-{x.Vora}:{x.Vperc}"));
            }


            //7. feladat
            Console.Write("7. feladat: Adjon meg egy időpontot óra:perc ablakban: ");
            string bekertIdo = Console.ReadLine();
            int bekertOra = Convert.ToInt32(bekertIdo.Split(':')[0]);
            int bekertPerc = Convert.ToInt32(bekertIdo.Split(':')[1]);
            int osszido = bekertOra * 60 + bekertPerc;

            kolcsonzesek.Where(x => x.Eora * 60 + x.Eperc < osszido && osszido < x.Vora * 60 + x.Vperc).ToList()
                .ForEach(x => Console.WriteLine($"{x.Eora}:{x.Eperc}-{x.Vora}:{x.Vperc} : {x.Nev}"));

            //8.
            int napiBevetel = 2400 * (kolcsonzesek.Sum(ob => ob.IdoHossz()) / 30 + 1);
            Console.WriteLine($"8. feladat: A napi bevétel: {napiBevetel} Ft");

            //9.
            StreamWriter sw = new StreamWriter("F.txt");
            kolcsonzesek.Where(x => x.Jazon == 'F')
                .ToList()
                .ForEach(x => sw.WriteLine($"{x.Eora} : {x.Eperc} - {x.Vora}:{x.Vperc} : {x.Nev}"));
            sw.Close();

            //10
            kolcsonzesek.GroupBy(x => x.Jazon)
                .OrderBy(x => x.Key)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Key} - {x.Count()}"));
        }


        static void ParseTxtContent()
        {
            kolcsonzesek = File.ReadAllLines("kolcsonzesek.txt").Skip(1).Select(x => new Kolcsonzes(x)).ToList();
        }
    }
} 