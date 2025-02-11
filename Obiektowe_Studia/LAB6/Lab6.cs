namespace LAB6;

public class Lab6
{
    public static void RunLab()
    {
        Console.WriteLine("Wybierz zadanie z LAB1 (1-4): ");
        int taskChoice = Convert.ToInt32(Console.ReadLine());

        switch (taskChoice)
        {
            case 1:  Zad1.RUN(); break;
            case 3:  PeselChecker.RUN(); break;
            case 4:  Zad4.RUN(); break;
            default:
                Console.WriteLine("Błędny wybór zadania w LAB6.");
                break;
        }
    }
}