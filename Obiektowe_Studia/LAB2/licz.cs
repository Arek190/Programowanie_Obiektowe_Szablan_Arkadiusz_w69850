using System;

namespace LAB2
{
    internal class Licz
    {
        private double value;

        public Licz(double initialValue)
        {
            value = initialValue;
        }

        public void Dodaj(double liczba)
        {
            value += liczba;
        }

        public void Odejmij(double liczba)
        {
            value -= liczba;
        }

        public void WypiszStan()
        {
            Console.WriteLine($"Aktualna wartość: {value}");
        }
    }
}