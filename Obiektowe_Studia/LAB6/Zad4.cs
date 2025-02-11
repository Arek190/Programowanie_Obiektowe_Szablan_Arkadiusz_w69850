using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LAB6
{
    class Zad4
    {
        // Klasa reprezentująca pojedynczy wpis w bazie danych
        public class DataEntry
        {
            public Indicator indicator { get; set; }
            public Country country { get; set; }
            public long? value { get; set; }
            public string date { get; set; }
        }

        // Klasa reprezentująca wskaźnik
        public class Indicator
        {
            public string id { get; set; }
            public string value { get; set; }
        }

        // Klasa reprezentująca kraj
        public class Country
        {
            public string id { get; set; }
            public string value { get; set; }
        }

        public static void RUN()
        {
            // Wczytanie danych z pliku db.json
            string filePath = "db.json";
            var data = WczytajDaneZPliku(filePath);

            // Obliczenia dla Indii (1970 - 2000)
            long roznicaIndie = ObliczRoznicePopulacji(data, "India", 1970, 2000);
            Console.WriteLine($"Różnica populacji Indii pomiędzy 1970 a 2000 wynosi: {roznicaIndie}");

            // Obliczenia dla USA (1965 - 2010)
            long roznicaUSA = ObliczRoznicePopulacji(data, "United States", 1965, 2010);
            Console.WriteLine($"Różnica populacji USA pomiędzy 1965 a 2010 wynosi: {roznicaUSA}");

            // Obliczenia dla Chin (1980 - 2018)
            long roznicaChiny = ObliczRoznicePopulacji(data, "China", 1980, 2018);
            Console.WriteLine($"Różnica populacji Chin pomiędzy 1980 a 2018 wynosi: {roznicaChiny}");

            // Interaktywne zapytanie użytkownika o populację dla kraju i roku
            Console.WriteLine("\nWybierz kraj (India, United States, China): ");
            string kraj = Console.ReadLine();
            Console.WriteLine("Podaj rok: ");
            int rok = int.Parse(Console.ReadLine());
            WyswietlPopulacjeDlaRoku(data, kraj, rok);

            // Sprawdzenie różnicy populacji dla wskazanego zakresu lat i kraju
            Console.WriteLine("\nWybierz kraj (India, United States, China): ");
            kraj = Console.ReadLine();
            Console.WriteLine("Podaj pierwszy rok: ");
            int rokStart = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugi rok: ");
            int rokEnd = int.Parse(Console.ReadLine());
            long roznica = ObliczRoznicePopulacjiDlaZakresu(data, kraj, rokStart, rokEnd);
            Console.WriteLine($"Różnica populacji dla {kraj} pomiędzy {rokStart} a {rokEnd} wynosi: {roznica}");

            // Sprawdzanie procentowego wzrostu populacji
            SprawdzProcentowyWzrostPopulacji(data);
        }

        // Wczytuje dane z pliku JSON
        static List<DataEntry> WczytajDaneZPliku(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<DataEntry>>(json);
        }

        // Oblicza różnicę populacji dla wybranego kraju w danym okresie
        static long ObliczRoznicePopulacji(List<DataEntry> data, string kraj, int startYear, int endYear)
        {
            var countryData = new Dictionary<int, long?>();

            // Wybór danych dla kraju
            foreach (var entry in data)
            {
                if (entry.country.value == kraj)
                {
                    if (int.TryParse(entry.date, out int year) && entry.value.HasValue)
                    {
                        countryData[year] = entry.value;
                    }
                }
            }

            // Sprawdzenie czy dane istnieją dla obu lat
            if (countryData.ContainsKey(startYear) && countryData.ContainsKey(endYear))
            {
                return countryData[endYear].Value - countryData[startYear].Value;
            }
            else
            {
                Console.WriteLine($"Brak danych dla lat {startYear} i {endYear} w kraju {kraj}.");
                return 0;
            }
        }

        // Wyswietla populację dla wybranego roku i kraju
        static void WyswietlPopulacjeDlaRoku(List<DataEntry> data, string kraj, int rok)
        {
            var countryData = new Dictionary<int, long?>();

            foreach (var entry in data)
            {
                if (entry.country.value == kraj)
                {
                    if (int.TryParse(entry.date, out int year) && entry.value.HasValue)
                    {
                        countryData[year] = entry.value;
                    }
                }
            }

            if (countryData.ContainsKey(rok))
            {
                Console.WriteLine($"Populacja {kraj} w roku {rok}: {countryData[rok]}");
            }
            else
            {
                Console.WriteLine($"Brak danych dla kraju {kraj} i roku {rok}.");
            }
        }

        // Oblicza różnicę populacji dla wskazanego zakresu lat i kraju
        static long ObliczRoznicePopulacjiDlaZakresu(List<DataEntry> data, string kraj, int startYear, int endYear)
        {
            var countryData = new Dictionary<int, long?>();

            foreach (var entry in data)
            {
                if (entry.country.value == kraj)
                {
                    if (int.TryParse(entry.date, out int year) && entry.value.HasValue)
                    {
                        countryData[year] = entry.value;
                    }
                }
            }

            if (countryData.ContainsKey(startYear) && countryData.ContainsKey(endYear))
            {
                return countryData[endYear].Value - countryData[startYear].Value;
            }
            else
            {
                Console.WriteLine($"Brak danych dla kraju {kraj} lub lat {startYear} i {endYear}.");
                return 0;
            }
        }

        // Sprawdzanie procentowego wzrostu populacji w każdym roku względem poprzedniego
        static void SprawdzProcentowyWzrostPopulacji(List<DataEntry> data)
        {
            var countries = new List<string> { "India", "United States", "China" };

            foreach (var kraj in countries)
            {
                var countryData = new Dictionary<int, long?>();

                foreach (var entry in data)
                {
                    if (entry.country.value == kraj)
                    {
                        if (int.TryParse(entry.date, out int year) && entry.value.HasValue)
                        {
                            countryData[year] = entry.value;
                        }
                    }
                }

                Console.WriteLine($"Procentowy wzrost populacji w {kraj}:");

                var years = new List<int>(countryData.Keys);
                years.Sort();

                for (int i = 1; i < years.Count; i++)
                {
                    int rokPoprzedni = years[i - 1];
                    int rokBiezacy = years[i];
                    long poprzedniaPopulacja = countryData[rokPoprzedni].Value;
                    long biezacaPopulacja = countryData[rokBiezacy].Value;

                    double wzrostProcentowy = (double)(biezacaPopulacja - poprzedniaPopulacja) / poprzedniaPopulacja * 100;
                    Console.WriteLine($"Rok {rokPoprzedni} do {rokBiezacy}: {wzrostProcentowy:F2}%");
                }
            }
        }
    }
}
