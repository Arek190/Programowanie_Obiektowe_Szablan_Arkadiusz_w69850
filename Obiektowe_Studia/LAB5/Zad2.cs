using System;
using System.Collections.Generic;

namespace LAB5
{
    public enum StatusZamowienia
    {
        Oczekujące,
        Przyjęte,
        Zrealizowane,
        Anulowane
    }

    public class Sklep
    {
        private Dictionary<int, (List<string> Produkty, StatusZamowienia Status)> zamowienia = new Dictionary<int, (List<string>, StatusZamowienia)>();

        public void DodajZamowienie(int numerZamowienia, List<string> produkty)
        {
            if (!zamowienia.ContainsKey(numerZamowienia))
            {
                zamowienia[numerZamowienia] = (produkty, StatusZamowienia.Oczekujące);
                Console.WriteLine($"Dodano zamówienie nr {numerZamowienia}.");
            }
            else
            {
                Console.WriteLine($"Zamówienie nr {numerZamowienia} już istnieje.");
            }
        }

        public void ZmienStatusZamowienia(int numerZamowienia, StatusZamowienia nowyStatus)
        {
            try
            {
                if (!zamowienia.ContainsKey(numerZamowienia))
                    throw new KeyNotFoundException("Zamówienie nie istnieje.");
                
                var (produkty, aktualnyStatus) = zamowienia[numerZamowienia];
                
                if (aktualnyStatus == nowyStatus)
                    throw new ArgumentException("Nowy status nie może być taki sam jak aktualny.");
                
                zamowienia[numerZamowienia] = (produkty, nowyStatus);
                Console.WriteLine($"Zmieniono status zamówienia nr {numerZamowienia} na {nowyStatus}.");
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
        }

        public void WyswietlZamowienia()
        {
            if (zamowienia.Count == 0)
            {
                Console.WriteLine("Brak zamówień.");
                return;
            }

            Console.WriteLine("Lista zamówień:");
            foreach (var zamowienie in zamowienia)
            {
                Console.WriteLine($"Nr {zamowienie.Key}: Status: {zamowienie.Value.Status}, Produkty: {string.Join(", ", zamowienie.Value.Produkty)}");
            }
        }
    }

    public class Zad2
    {
        public static void RUN()
        {
            Sklep sklep = new Sklep();

            // Dodajemy przykładowe zamówienia
            sklep.DodajZamowienie(1, new List<string> { "Laptop", "Myszka" });
            sklep.DodajZamowienie(2, new List<string> { "Telefon", "Etui" });

            // Wyświetlamy zamówienia
            sklep.WyswietlZamowienia();

            // Zmieniamy statusy zamówień
            sklep.ZmienStatusZamowienia(1, StatusZamowienia.Przyjęte);
            sklep.ZmienStatusZamowienia(2, StatusZamowienia.Anulowane);

            // Próbujemy zmienić status nieistniejącego zamówienia (błąd)
            sklep.ZmienStatusZamowienia(3, StatusZamowienia.Zrealizowane);

            // Ponownie wyświetlamy zamówienia
            sklep.WyswietlZamowienia();
        }
    }
}
