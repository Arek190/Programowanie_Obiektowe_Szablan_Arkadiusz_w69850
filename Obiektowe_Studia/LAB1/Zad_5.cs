using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Zad_5
    {
        public static void RUN()
        {
            for (int i = 20; i >= 0; i--)
            {
                // Pomijamy liczby 2, 6, 9, 15, 19
                if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
