using System;

namespace Biblioteczka
{
    class Program
    {
        static void Main(string[] args)
        {
            Publikacja publikacja1 = new Publikacja(new DateTime(2001, 12, 12), 2.34M);
            Publikacja publikacja2 = new Publikacja(new DateTime(2012, 11, 23), 20.13M);
            Publikacja publikacja3 = new Publikacja(new DateTime(1999, 01, 30), 15.5M);

            Console.WriteLine(publikacja1);
            Console.WriteLine(publikacja2);
            Console.WriteLine(publikacja3);

            Ksiazka ksiazka1 = new Ksiazka(new DateTime(1999, 12, 24), 2.34M, "Fajna ksiunszka", EnumDziedzina.ekonomia);
            Ksiazka ksiazka2 = new Ksiazka(new DateTime(2002, 11, 12), 5.6M, "Infa dla C#", EnumDziedzina.informatyka);
            Ksiazka ksiazka3 = new Ksiazka(new DateTime(2015, 06, 10), 4.4M, "fajne zarządzanie", EnumDziedzina.zarządzanie);

            Console.WriteLine(ksiazka1);
            Console.WriteLine(ksiazka2);
            Console.WriteLine(ksiazka3);

            Biblioteczka biblioteczka = new Biblioteczka("Zażółć gęślą jaźń");
            biblioteczka.Dodaj(ksiazka3);
            Console.WriteLine(biblioteczka);
            biblioteczka.Dodaj(ksiazka2);
            Console.WriteLine(biblioteczka);
            biblioteczka.Dodaj(ksiazka1);
            Console.WriteLine(biblioteczka);

            Console.WriteLine(biblioteczka);

            biblioteczka.ZapiszBin("bin");

            Console.ReadKey();
        }
    }
}
