using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Zad_2
    {
        public static void RUN()
        {
            /*
            2. Napisz kalkulator obliczający: sumę, różnicę, iloczyn, iloraz, potęgę, pierwiastek, oraz wartości
            funkcji trygonometrycznych dla zadanego kąta. Użyj biblioteki Math np. Math.Sin(2.5). Proszę
            pamiętać, że wartości kąta podawane do funkcji mierzone są miarą łukową. Wyniki działania
            algorytmów wyświetlaj na konsoli. Do obsługi menu proszę użyć konstrukcji switch-case oraz pętli while.
            */
            menu();

            static void menu()
            {
                //ViewMenu:
                Console.WriteLine("-----------Kalkulator---------");
                Console.WriteLine("1 Suma\n2 Różnica \n3 Iloczyn \n4 Iloraz \n5 Potęga \n6 Pierwiastek \n7 Trygonometria \n8 Wyjście");


                while (true)
                {
                    Console.WriteLine("Wybierz opcje: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: Total(); break;
                        case 2: Difference(); break;
                        case 3: ProductNumber(); break;
                        case 4: QuationNumber(); break;
                        case 5: PotentationNumber(); break;
                        case 6: SquareNumber(); break;
                        case 7: TrigonNumber(); break; // zmiana wartosci na ( input *Math.PI) /180
                        case 8: Close(); break;
                        default: Console.WriteLine("Bledny wybor, wybierz jeszcze raz opcje."); break; //goto ViewMenu;<--- wraca do linii 150 
                    }//koniec switch
                }
            }

        }

        static void TrigonNumber()
        {
            double a = Zad_1.doubleInput();
            Console.WriteLine($"Wartość funkcji trygonometrycznej dla kąta: {a} = {(a * Math.PI) / 180}");
        }

        static void SquareNumber()
        {
            double a = Zad_1.doubleInput();
            Console.WriteLine($"Pierwiastek liczby {a} = {Math.Sqrt(a)}");
        }

        static void PotentationNumber()
        {
            double a = Zad_1.doubleInput();
            Console.WriteLine($"Potęga liczby {a} = {Math.Pow(a, 2)}");
        }

        static void QuationNumber()
        {
            double a = Zad_1.doubleInput();
            double b = Zad_1.doubleInput();
            Console.WriteLine($"Iloraz {a}/{b} = {a / b}");
        }

        static void ProductNumber()
        {
            double a = Zad_1.doubleInput();
            double b = Zad_1.doubleInput();
            Console.WriteLine($"Iloczyn {a} * {b} = {a * b}");
        }

        static void Difference()
        {
            double a = Zad_1.doubleInput();
            double b = Zad_1.doubleInput();
            Console.WriteLine($"Różnica {a} - {b} = {a - b}");
        }

        static void Total()
        {
            double a = Zad_1.doubleInput();
            double b = Zad_1.doubleInput();
            Console.WriteLine($"Suma {a} + {b} = {a + b}");
        }

        static void Close()
        {
            Console.WriteLine("Koniec programu");
            System.Environment.Exit(1);
        }
    }
 }
