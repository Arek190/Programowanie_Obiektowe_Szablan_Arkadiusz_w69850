using System;

namespace LAB2
{
    internal class Zad_5
    {
        // Metoda główna bez argumentów
        public static void RUN()
        {
            // Przykładowe dane
            int[] liczby = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Tworzymy obiekt klasy Sumator
            Sumator sumator = new Sumator(liczby);

            // Testowanie metod
            Console.WriteLine("Suma wszystkich liczb: " + sumator.Suma());
            Console.WriteLine("Suma liczb podzielnych przez 2: " + sumator.SumaPodziel2());
            Console.WriteLine("Liczba elementów w tablicy: " + sumator.IleElementów());
            Console.WriteLine("Wszystkie elementy:");
            sumator.WypiszWszystkieElementy();
            
            Console.WriteLine("Elementy w zakresie indeksów 2-6:");
            sumator.WypiszElementyWZakresie(2, 6);
        }
    }
}