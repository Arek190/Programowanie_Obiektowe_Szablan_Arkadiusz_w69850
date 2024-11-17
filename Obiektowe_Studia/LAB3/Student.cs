using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Student : Osoba
    {
        private string NrAlbumu {  get; set; }

        public Student(string FirstName,string LastName,int Age, string nrAlbumu):
            base(FirstName,LastName,Age)
            {
            NrAlbumu = nrAlbumu;
            }
        public void ViewStudent()
        {
            View();
            Console.WriteLine($"Nr Albumu: {NrAlbumu}");
        }
    }
}
