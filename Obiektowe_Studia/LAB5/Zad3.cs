using System;
using System.Collections.Generic;

namespace LAB5
{
    enum Kolor
    {
        Czerwony,
        Niebieski,
        Zielony,
        Żółty,
        Fioletowy
    }

    public class Zad3
    {
        public static void RUN()
        {
            // Lista dostępnych kolorów
            List<Kolor> dostepneKolory = new List<Kolor> 
            { 
                Kolor.Czerwony, 
                Kolor.Niebieski, 
                Kolor.Zielony, 
                Kolor.Żółty, 
                Kolor.Fioletowy 
            };

            Random rand = new Random();
            Kolor wylosowanyKolor = dostepneKolory[rand.Next(dostepneKolory.Count)];

            Console.WriteLine("Zgadnij kolor! Dostępne kolory: Czerwony, Niebieski, Zielony, Żółty, Fioletowy.");

            while (true)
            {
                Console.Write("Podaj kolor: ");
                string input = Console.ReadLine();

                try
                {
                    // Próba przekonwertowania wpisanego koloru na enum
                    if (!Enum.TryParse(input, true, out Kolor wybranyKolor) || !dostepneKolory.Contains(wybranyKolor))
                    {
                        throw new ArgumentException("Podano nieprawidłowy kolor! Spróbuj ponownie.");
                    }

                    if (wybranyKolor == wylosowanyKolor)
                    {
                        Console.WriteLine("Gratulacje! Zgadłeś prawidłowy kolor 🎉");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowy kolor, spróbuj ponownie.");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
            }
        }
    }
}