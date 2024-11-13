using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Zad_7
    {
        public static void RUN()
        {
            {
                // Pobieranie liczby elementów do wprowadzenia
                Console.Write("Ile liczb chcesz wprowadzić? ");
                int n = Convert.ToInt32(Console.ReadLine());

                int[] liczby = new int[n];

                // Wprowadzanie liczb do tablicy
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Podaj liczbę {i + 1}: ");
                    liczby[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Sortowanie bąbelkowe
                BubbleSort(liczby);

                // Wyświetlanie posortowanych liczb
                Console.WriteLine("\nLiczby po posortowaniu:");
                foreach (int liczba in liczby)
                {
                    Console.WriteLine(liczba);
                }
            }

            // Funkcja sortowania bąbelkowego
            static void BubbleSort(int[] array)
            {
                int n = array.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            // Zamiana elementów, jeśli są w złej kolejności
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
        }
    }
}
