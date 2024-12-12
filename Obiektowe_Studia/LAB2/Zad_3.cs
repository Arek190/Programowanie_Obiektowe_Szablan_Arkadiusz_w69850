using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Zad_3
    {
        public static void RUN()
        {
            Student student = new Student("Jan", "Nowak");
            student.AddGrades(4);
            student.AddGrades(5);
            student.AddGrades(4);
            student.AddGrades(3);
            student.AddGrades(2);

            Console.WriteLine($"{student.FirstName} {student.LastName}, Średnia ocen: {student.SredniaOcen:F2}");
        }

    }
}
