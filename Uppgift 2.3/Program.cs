using System;

namespace School_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! Hur i hur många dagar vill du låna bilen?");
            string Bilen = Console.ReadLine();
            Console.WriteLine("Hur många kilometer ska du åka?");
            string Kilometer = Console.ReadLine();
            int Längd = int.Parse(Kilometer);
            int Dagar = int.Parse(Bilen);
            int hyrperdag = Dagar * 500;
            int startavgift = + 300;
            int Totalt = hyrperdag + startavgift + Längd;
            Console.WriteLine("Ditt totala pris är, " + Totalt + "kr");
        }
    }
}
