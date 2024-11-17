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
            student.AddGrades(4.5);
            student.AddGrades(3.5);
            student.AddGrades(2);

        }

    }
}
