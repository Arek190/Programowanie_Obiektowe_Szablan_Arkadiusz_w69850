using LAB1;

namespace LAB5;

public class Lab5
{
    public static void RunLab()
    {
        Console.WriteLine("Wybierz zadanie z LAB1 (1-3): ");
        int taskChoice = Convert.ToInt32(Console.ReadLine());

        switch (taskChoice)
        {
            case 1: Zad1.RUN(); break;
            case 2: Zad2.RUN(); break;
            case 3: Zad3.RUN(); break;
            default:
                Console.WriteLine("Błędny wybór zadania w LAB5.");
                break;
        }
    }
}