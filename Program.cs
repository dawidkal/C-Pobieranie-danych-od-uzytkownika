using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2NF
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )  // petla w nieskonczonosc
            {
                Console.WriteLine(" Podaj imie");
                string name = Console.ReadLine();

                Console.WriteLine(" Podaj wiek");
                // wiek = int.Parse ( Console.ReadLine()); // konwersja na inta
                int wiek;
                bool rezultat = int.TryParse(Console.ReadLine(), out wiek);// zabespieczy jesli wprowadza niepoprawna wartosc ustawi wieik na 0
                if (wiek > 18)
                {
                    Console.ForegroundColor = ConsoleColor.Green;  // zmiana koloru
                    Console.WriteLine("Masz 18. Pijesz browara");
                }
                else if (rezultat == false)
                {
                    Console.WriteLine("Wprowadziles niepoprawna wartosc wiek");
                }
                else
                {
                    Console.WriteLine("Pijesz mleko");
                }

                Console.WriteLine("Wprowadziles wyraz -> " + name + " wiek " + wiek);
                Console.ReadKey();
                Console.Clear(); //czysci konsole
                Console.ResetColor();
            }
        }

    }
}
