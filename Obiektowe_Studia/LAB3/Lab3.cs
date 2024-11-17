namespace LAB3
{
    public class Lab3
    {
        public static void RunLab()
        {
            Console.WriteLine("Wybierz zadanie z LAB1 (1-7): ");
            int taskChoice = Convert.ToInt32(Console.ReadLine());

            switch (taskChoice)
            {
                case 1:  Przyklad.RUN(); break;
                default:
                    Console.WriteLine("Błędny wybór zadania w LAB1.");
                    break;
            }
        }
    }
}