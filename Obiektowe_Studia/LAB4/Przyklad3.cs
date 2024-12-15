using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Przyklad3
    {
        interface IZwierze
        {
            void DajGlos();
        }

        class Pies : IZwierze
        {
            public void DajGlos()
            {
                Console.WriteLine("Pies wydaje dzwiek");
            }
        }

        public static void RUN()
        {
            IZwierze zwierze = new Pies();
            zwierze.DajGlos();
        }
    }
}
