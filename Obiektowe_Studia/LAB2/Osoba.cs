using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace LAB2
{
    internal class Osoba
    {
        // definiowanie pól
        //private string firstName;
        //private string lastName;
        //private int age;

        //właściwości
        //public string FirstName { get; set; }
        public string FirstName
        {
            get { return FirstName; }
            //set { firstName = value; }
            set
            {
                if (value.Length > 2) FirstName = value;
                else Console.WriteLine("Imię musi posiadać conajmniej dwa znaki!");
            }
        }
        public string LastName
        {
            get { return LastName; }
            //set { lastName = value; }
            set
            {
                if (value.Length > 2) LastName = value;
                else Console.WriteLine("Nazwisko musi posiadać conajmniej dwa znaki!");
            }
        }
        public int Age
        {
            get { return Age; }
            set
            {
                if (value < 0) { 
                    Console.WriteLine("Wiek nie może być liczbą ujemną!"); 
                    return;
                }
                 Age = value;
            }
        }

        
        public Osoba(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }



        public void View()
            {
                Console.WriteLine($"Imie:\t{FirstName}" + $"\tNazwisko:{LastName}" + $"\tWiek:{Age}");
            }
     }
 }

