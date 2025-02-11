using System;
using System.IO;
using Newtonsoft.Json;

namespace LAB6
{
    // Klasa reprezentująca dane do zapisania w pliku
    public class Osoba
    {
        public string NumerAlbumu { get; set; }
    }

    public class Zad1
    {
        public static void RUN()
        {
            // Menu wyboru akcji
            Console.WriteLine("Wybierz akcję:");
            Console.WriteLine("1. Zapisz numer albumu do pliku");
            Console.WriteLine("2. Wczytaj zawartość pliku");

            string wybor = Console.ReadLine();

            if (wybor == "1")
            {
                // Zapisz numer albumu do pliku
                ZapiszNumerAlbumu();
            }
            else if (wybor == "2")
            {
                // Wczytaj i wyświetl zawartość pliku
                WczytajZawartoscPliku();
            }
            else
            {
                Console.WriteLine("Niepoprawny wybór.");
            }
        }

        // Metoda do zapisania numeru albumu do pliku JSON
        static void ZapiszNumerAlbumu()
        {
            // Poproś użytkownika o numer albumu
            Console.Write("Podaj numer albumu: ");
            string numerAlbumu = Console.ReadLine();

            // Utwórz obiekt osoby
            Osoba osoba = new Osoba { NumerAlbumu = numerAlbumu };

            // Poproś o nazwę pliku
            Console.Write("Podaj nazwę pliku do zapisania (np. dane.json): ");
            string nazwaPliku = Console.ReadLine();

            try
            {
                // Konwertuj obiekt osoby na format JSON
                string json = JsonConvert.SerializeObject(osoba, Formatting.Indented);

                // Zapisz JSON do pliku
                File.WriteAllText(nazwaPliku, json);
                Console.WriteLine($"Dane zostały zapisane do pliku {nazwaPliku}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            }
        }

        // Metoda do wczytania zawartości pliku JSON
        static void WczytajZawartoscPliku()
        {
            // Poproś użytkownika o nazwę pliku do wczytania
            Console.Write("Podaj nazwę pliku do wczytania (np. dane.json): ");
            string nazwaPliku = Console.ReadLine();

            try
            {
                // Sprawdź, czy plik istnieje
                if (File.Exists(nazwaPliku))
                {
                    // Wczytaj zawartość pliku
                    string json = File.ReadAllText(nazwaPliku);

                    // Deserializuj JSON do obiektu Osoba
                    Osoba osoba = JsonConvert.DeserializeObject<Osoba>(json);

                    // Wyświetl dane z pliku
                    Console.WriteLine($"Numer albumu zapisany w pliku: {osoba.NumerAlbumu}");
                }
                else
                {
                    Console.WriteLine("Plik o podanej nazwie nie istnieje.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas wczytywania pliku: {ex.Message}");
            }
        }
    }
}
