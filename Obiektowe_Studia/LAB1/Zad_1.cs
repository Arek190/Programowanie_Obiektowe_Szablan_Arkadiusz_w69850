using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Zad_1
    {
        public static void RUN()
        {
            // deklaracja zmiennych
            double a = doubleInput();
            double b = doubleInput();
            double c = doubleInput();
            double delta, x1, x2;

            if (a != 0)
            {
                delta = Math.Pow(b, 2) - (4 * a * c);
                if (delta < 0)
                {
                    Console.WriteLine("Brak rozwiazania w zbiorze liczb rzeczywistych");
                }
                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("jedno rozwiazanie x1 = " + x1);
                    Console.WriteLine($" Jedno rozwiązanie x1={x1:F2}");
                }
                else
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Dwa rozwiazania: \t x1 = " + x1 + "\t x2 = " + x2);
                    Console.WriteLine($"Dwa rozwiązania: x1 = {x1:F2} \t x2 = {x2:F2}");
                }

            }
            else { Console.WriteLine("To nie jest równanie kwadratowe!"); }
        }

        public static double doubleInput()
        {
            Console.WriteLine("Podaj liczbe: ");
            double input = Convert.ToDouble(Console.ReadLine());
            return input;
        }
    }
}
