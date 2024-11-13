using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Zad_3
    {
        public static void RUN()
        {
            int[] tablica = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Podaj liczbę {i + 1}: ");
                tablica[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nPodane liczby to:");
            foreach (int liczba in tablica)
            {
                Console.WriteLine(liczba);
            }

            Console.WriteLine("\n Podane liczby od końca to:");
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(tablica[i]);
            }

            Console.WriteLine("\n Tylko liczby o parzystych indeksach tablicy:");
            for (int i = 9; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Liczba: " + tablica[i] + " Indeks: " + i);
                }
            }
            Console.WriteLine("\n Tylko liczby o nie parzystych indeksach tablicy:");
            for (int i = 9; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("Liczba: " + tablica[i] + " Indeks: " + i);
                }
            }
        }
    }
}
