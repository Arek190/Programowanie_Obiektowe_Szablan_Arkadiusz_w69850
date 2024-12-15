using Obiektowe_Studia.LAB4.Zad1;
using Obiektowe_Studia.LAB4.Zad2;

namespace LAB4
{
    public class Lab4
    {
        public static void RunLab()
        {
            Console.WriteLine("Wybierz zadanie z LAB1 (1-7): ");
            int taskChoice = Convert.ToInt32(Console.ReadLine());

            switch (taskChoice)
            {
                case 1: Zad1.RUN(); break;
                case 2: Przyklad.RUN(); break;
                case 3: Przyklad2.RUN(); break;
                case 4: Przyklad3.RUN(); break;
                case 5: Przyklad4.RUN(); break;
                case 6: Przyklad5.RUN(); break;
                case 7: Zad2.RUN(); break;
                default:
                    Console.WriteLine("Błędny wybór zadania w LAB4.");
                    break;
            }
        }
    }
}