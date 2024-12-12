namespace LAB2
{
    public class Sumator
    {
        // Prywatne pole Liczby będące tablicą liczb
        private int[] Liczby;

        // Konstruktor inicjujący tablicę
        public Sumator(int[] liczby)
        {
            Liczby = liczby;
        }

        // Metoda zwracająca sumę wszystkich liczb z tablicy
        public int Suma()
        {
            int suma = 0;
            foreach (int liczba in Liczby)
            {
                suma += liczba;
            }
            return suma;
        }

        // Metoda zwracająca sumę liczb podzielnych przez 2
        public int SumaPodziel2()
        {
            int suma = 0;
            foreach (int liczba in Liczby)
            {
                if (liczba % 2 == 0)
                {
                    suma += liczba;
                }
            }
            return suma;
        }

        // Metoda zwracająca liczbę elementów w tablicy
        public int IleElementów()
        {
            return Liczby.Length;
        }

        // Metoda wypisująca wszystkie elementy tablicy
        public void WypiszWszystkieElementy()
        {
            foreach (int liczba in Liczby)
            {
                Console.WriteLine(liczba);
            }
        }

        // Metoda wypisująca elementy tablicy o indeksach >= lowIndex oraz <= highIndex
        public void WypiszElementyWZakresie(int lowIndex, int highIndex)
        {
            // Sprawdzamy zakres, aby uniknąć przekroczenia indeksów
            for (int i = 0; i < Liczby.Length; i++)
            {
                if (i >= lowIndex && i <= highIndex)
                {
                    Console.WriteLine(Liczby[i]);
                }
            }
        }
    }
}