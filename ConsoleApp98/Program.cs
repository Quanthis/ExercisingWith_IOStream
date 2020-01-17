using System;
using System.IO;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, nazwa = @"c:\tmp\pomiary.txt";
            FileStream plik = new FileStream(nazwa, FileMode.Open, FileAccess.Read, FileShare.None);
            System.IO.StreamReader odczyt = new StreamReader(plik);
            s = odczyt.ReadLine();
            double średnia, suma = 0, min = Convert.ToDouble(s), max = Convert.ToDouble(s);
            int ile = 0;

            while ((s = odczyt.ReadLine()) != null)
            {
                ile += 1;
                if (Convert.ToDouble(s) < min) min = Convert.ToDouble(s);
                if (Convert.ToDouble(s) > max) max = Convert.ToDouble(s);
                suma += Convert.ToDouble(s);
                
            }
            średnia = (suma / ile);
            odczyt.Close();
            plik.Close();
            Console.WriteLine("Liczba pomiarów: {0}", ile);
            Console.WriteLine("Minimalna temperatura: {0}", min);
            Console.WriteLine("Maksymalna temperatura: {0}", max);
            Console.WriteLine("Średnia temperatura: {0}", średnia);
            Console.ReadKey();
        }
    }
}

