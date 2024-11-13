using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Zad_6
    {
        public static void RUN()
        {
            while (true)
            {
                Console.Write("Podaj liczbę całkowitą: ");
                int liczba = Convert.ToInt32(Console.ReadLine());

                if (liczba < 0)
                {
                    Console.WriteLine("Liczba ujemna! Koniec programu.");
                    break;
                }

                Console.WriteLine($"Wprowadzona liczba to: {liczba}");
            }
        }
    }
}
