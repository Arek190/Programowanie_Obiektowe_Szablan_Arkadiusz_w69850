using LAB1;
using LAB2;
using LAB3;
using LAB4;
using System;
using System.Threading.Channels;

namespace MojeZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Wybierz laboratorium (1, 2, 3): /0 - Wyjście");
                while (true)
                {
                    Console.Write("Wybierz laboratorium: ");
                    int labChoice = Convert.ToInt32(Console.ReadLine());

                    switch (labChoice)
                    {
                        case 1:
                            Lab1.RunLab(); 
                            break;
                        case 2:
                            Lab2.RunLab();
                            break;
                        case 3:
                            Lab3.RunLab();
                            break;
                        case 4:
                            Lab4.RunLab();
                            break;
                        case 0:
                            Close();
                            break;
                        default:
                            Console.WriteLine("Błędny wybór, wybierz ponownie.");
                            break;
                    }
                }

                static void Close()
                {
                    Console.WriteLine("Koniec programu");
                    System.Environment.Exit(1);
                }
            }
        }
    }
}


