using System;
using System.Collections.Generic;

namespace LAB5
{
    public enum Operacja
    {
        Dodawanie,
        Odejmowanie,
        Mnożenie,
        Dzielenie
    }

    public class Kalkulator
    {
        private List<double> historiaWynikow = new List<double>();

        public double Oblicz(double liczba1, double liczba2, Operacja operacja)
        {
            double wynik = 0;

            try
            {
                switch (operacja)
                {
                    case Operacja.Dodawanie:
                        wynik = liczba1 + liczba2;
                        break;
                    case Operacja.Odejmowanie:
                        wynik = liczba1 - liczba2;
                        break;
                    case Operacja.Mnożenie:
                        wynik = liczba1 * liczba2;
                        break;
                    case Operacja.Dzielenie:
                        if (liczba2 == 0)
                            throw new DivideByZeroException("Nie można dzielić przez zero!");
                        wynik = liczba1 / liczba2;
                        break;
                }

                historiaWynikow.Add(wynik);
                return wynik;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return double.NaN;
            }
        }

        public void WyswietlHistorie()
        {
            Console.WriteLine("Historia wyników:");
            foreach (var wynik in historiaWynikow)
            {
                Console.WriteLine(wynik);
            }
        }
    }

    public class Zad1
    {
        public static void RUN()
        {
            Kalkulator kalkulator = new Kalkulator();

            while (true)
            {
                try
                {
                    Console.Write("Podaj pierwszą liczbę: ");
                    double liczba1 = double.Parse(Console.ReadLine());

                    Console.Write("Podaj drugą liczbę: ");
                    double liczba2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Wybierz operację: 0 - Dodawanie, 1 - Odejmowanie, 2 - Mnożenie, 3 - Dzielenie");
                    Operacja operacja = (Operacja)int.Parse(Console.ReadLine());

                    double wynik = kalkulator.Oblicz(liczba1, liczba2, operacja);
                    Console.WriteLine($"Wynik: {wynik}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Błąd: Wprowadzono niepoprawne dane. Podaj liczby!");
                }

                Console.Write("Czy chcesz zobaczyć historię wyników? (T/N): ");
                if (Console.ReadLine().ToUpper() == "T")
                {
                    kalkulator.WyswietlHistorie();
                }

                Console.Write("Czy chcesz kontynuować? (T/N): ");
                if (Console.ReadLine().ToUpper() != "T")
                {
                    break;
                }
            }
        }
    }
}
