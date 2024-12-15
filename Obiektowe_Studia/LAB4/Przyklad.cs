using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Przyklad
    {
        class Zwierze
        {
            public virtual void DajGlos()
            {
                Console.WriteLine("Zwierze wydaje dzwiek");
            }
        }

        class Pies : Zwierze
        {
            public override void DajGlos()
            {
                Console.WriteLine("Pies wydaje dzwiek");
            }
        }

        class Kot : Zwierze
        {
            public override void DajGlos()
            {
                Console.WriteLine("Kot wydaje dzwiek");
            }
        }
        public static void RUN()
      {
            Zwierze zwierze = new Pies();
            Zwierze zwierze1 = new Kot();

            zwierze.DajGlos();
            zwierze1.DajGlos();
        }
    }
}

