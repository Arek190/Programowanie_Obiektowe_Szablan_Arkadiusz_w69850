using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Zad_2
    {
        public static void RUN()
        {
            BankAccount bankAccount = new BankAccount(1000,"Jan Nowak");
            bankAccount.View();
            bankAccount.Wplata(500);
            bankAccount.View();

            Console.WriteLine("Podaj środki do wypłaty:");
            int test = int.Parse(Console.ReadLine());
            bankAccount.Wyplata(test);
        }
    }
}
