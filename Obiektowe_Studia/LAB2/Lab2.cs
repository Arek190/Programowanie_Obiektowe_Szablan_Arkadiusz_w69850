﻿namespace LAB2
{
    public class Lab2
    {
        public static void RunLab()
        {
            Console.WriteLine("Wybierz zadanie z LAB2 (1-3): ");
            int taskChoice = Convert.ToInt32(Console.ReadLine());

            switch (taskChoice)
            {
                case 1: Zad_1.RUN(); break;
                case 2: Zad_2.RUN(); break;
                case 3: Zad_3.RUN(); break;
                default:
                    Console.WriteLine("Błędny wybór zadania w LAB2.");
                    break;
            }
        }
    }
}