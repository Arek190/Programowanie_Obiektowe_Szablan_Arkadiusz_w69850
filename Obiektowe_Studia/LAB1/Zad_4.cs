using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Zad_4
    {
        public static void RUN()
        {
            int[] tablica = new int[10];
            int suma = 0;
            int iloczyn = 1;


            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Podaj liczbę {i + 1}: ");
                tablica[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(int liczba in tablica)
            {
                suma = liczba + suma;
            }
            Console.WriteLine("\n Suma wynosi: " + suma);

            foreach (int liczba in tablica)
            {
                iloczyn = liczba * iloczyn;
            }
            Console.WriteLine("\n Iloczyn wynosi: " + iloczyn);

            int srednia = suma/10;

            Console.WriteLine("\n Srednia wynosi: " + srednia);

            int max = tablica.Max();
            int min = tablica.Min();

            Console.WriteLine("\n Wartość maksymalna wynosi: " + max);
            Console.WriteLine("\n Wartośc minimalna wynosi: " + min);
        }
    }
}
