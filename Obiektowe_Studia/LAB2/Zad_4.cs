using System;

namespace LAB2
{
    internal class Zad_4
    {
        public static void RUN()
        {
            Licz licz1 = new Licz(10);
            Licz licz2 = new Licz(20);

            licz1.Dodaj(5);
            licz1.WypiszStan();

            licz2.Odejmij(7);
            licz2.WypiszStan();

            licz1.Dodaj(3);
            licz1.WypiszStan();
        }
    }
}