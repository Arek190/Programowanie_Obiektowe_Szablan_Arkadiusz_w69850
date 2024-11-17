using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Student
    {
        private string firstName;
        private string lastName;
        private double[] grades;
        private int countGrades;

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public double SredniaOcen
        {
            get
            {
                if (countGrades == 0) return 0;
                double sum = 0;
                for (int i = 0; i < countGrades; i++)
                {
                    sum += grades[i];
                }
                return sum / countGrades; //srednia
            }
        }

        public void AddGrades(double ocena)
        {
            if (ocena < 2 || ocena > 5)
            {
                Console.WriteLine("Ocena musi być z przedziału 2-5");
                return;
            }
            if (countGrades >= grades.Length)
            {
                Console.WriteLine("Nie można dodać więcej ocen. Tablica jest pełna.");
                return;
            }
            grades[countGrades] = ocena;
            countGrades++;
            Console.WriteLine($"Dodano ocenę: {ocena}. Aktualna średnia: {SredniaOcen:F2}");
        }
    }
}
