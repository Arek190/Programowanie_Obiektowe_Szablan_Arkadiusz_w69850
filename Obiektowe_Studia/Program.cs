using LAB1;
using System;
using System.Threading.Channels;

namespace MojeZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz numer zadania (1, 2, 3, 4, 5, 6, 7, 8 - Wyjscie): ");
            while (true)
            {
                Console.WriteLine("Wybierz opcje: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: Zad_1.RUN(); break;
                    case 2: Zad_2.RUN(); break;
                    case 3: Zad_3.RUN(); break;
                    case 4: Zad_4.RUN(); break;
                    case 5: Zad_5.RUN(); break;
                    case 6: Zad_6.RUN(); break;
                    case 7: Zad_7.RUN(); break;
                    case 8: Close(); break;
                    default: Console.WriteLine("Bledny wybor, wybierz jeszcze raz opcje."); break;
                }//koniec switch
            }
            static void Close()
            {
                Console.WriteLine("Koniec programu");
                System.Environment.Exit(1);
            }
        }
    }
}


