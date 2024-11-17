using LAB2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Zad_1
    {
        public static void RUN()
        {

            Console.WriteLine("Podaj imię:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Podaj Nazwisko:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Podaj wiek:");
            int age = int.Parse(Console.ReadLine());

            //tworzenie klasy osoba
            Osoba osoba = new Osoba(firstName,lastName,age);
            osoba.View();


        }
    }
}
