namespace LAB1
{
    public class Lab1
    {
        public static void RunLab()
        {
            Console.WriteLine("Wybierz zadanie z LAB1 (1-7): ");
            int taskChoice = Convert.ToInt32(Console.ReadLine());

            switch (taskChoice)
            {
                case 1: Zad_1.RUN(); break;
                case 2: Zad_2.RUN(); break;
                case 3: Zad_3.RUN(); break;
                case 4: Zad_4.RUN(); break;
                case 5: Zad_5.RUN(); break;
                case 6: Zad_6.RUN(); break;
                case 7: Zad_7.RUN(); break;
                default:
                    Console.WriteLine("Błędny wybór zadania w LAB1.");
                    break;
            }
        }
    }
}