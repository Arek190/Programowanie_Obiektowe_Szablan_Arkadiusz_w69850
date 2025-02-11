namespace MojeZadania.LAB7;

public class Lab7
{
    public static void RunLab()
    {
        Console.WriteLine("Wybierz zadanie z LAB1 (1-7): ");
        int taskChoice = Convert.ToInt32(Console.ReadLine());

        switch (taskChoice)
        {
            case 1:  ; break;
            default:
                Console.WriteLine("Błędny wybór zadania w LAB3.");
                break;
        }
    }
}