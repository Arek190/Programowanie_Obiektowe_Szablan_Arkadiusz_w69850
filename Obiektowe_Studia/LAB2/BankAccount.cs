using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class BankAccount
    {
        public BankAccount(decimal saldo, string wlasciciel)
        {
            Saldo = saldo;
            Wlasciciel = wlasciciel;
        }

        public decimal Saldo { get; private set; }
        public string Wlasciciel { get; set; }

        public void Wplata(decimal kwota)
        {
            if (kwota <= 0) {
                Console.WriteLine("Kwota nie może być ujemna");
                return;
            }
            Saldo += kwota;
            Console.WriteLine($"Wpłacono: {kwota:C}. Aktualny stan konta: {Saldo:C}.");
        }

        public void Wyplata(decimal kwota)
        {
            if (kwota <= 0)
            {
                Console.WriteLine("Kwota wypłaty nie może być ujemna");
                return;
            }
            if (kwota > Saldo) 
            {
                Console.WriteLine("Niewystarczająco środków na koncie");
                return;
            }
            Saldo -= kwota;
            Console.WriteLine($"Wpłacono: {kwota:C}. Aktualny stan konta: {Saldo:C}.");
        }

        public void View()
        {
            Console.WriteLine($"Właściciel: {Wlasciciel} \t Saldo: {Saldo}");
        }
    }
}
