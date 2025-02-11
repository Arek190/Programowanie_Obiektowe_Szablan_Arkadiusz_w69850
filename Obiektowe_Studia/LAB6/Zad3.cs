using System;
using System.IO;

namespace LAB6
{
    class PeselChecker
    {
        // Funkcja sprawdzająca, czy PESEL jest żeński (jeśli ósma cyfra jest parzysta)
        static bool CzyPeselZenski(string pesel)
        {
            // Sprawdzamy, czy ósma cyfra jest parzysta
            char cyfraPlec = pesel[9]; // Ósma cyfra (indeks 9)
            return cyfraPlec % 2 == 0; // Parzysta cyfra oznacza kobietę
        }

        public static void RUN()
        {
            string sciezkaPliku = "pesel.txt";

            try
            {
                if (!File.Exists(sciezkaPliku))
                {
                    Console.WriteLine($"Plik {sciezkaPliku} nie istnieje.");
                    return;
                }

                // Wczytanie wszystkich numerów PESEL z pliku
                string[] pesels = File.ReadAllLines(sciezkaPliku);
                int liczbaZenskichPeseli = 0;

                // Iteracja po wszystkich numerach PESEL i sprawdzanie płci
                foreach (string pesel in pesels)
                {
                    if (CzyPeselZenski(pesel))
                    {
                        liczbaZenskichPeseli++;
                    }
                }

                Console.WriteLine($"Liczba żeńskich numerów PESEL: {liczbaZenskichPeseli}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            }
        }
    }
}