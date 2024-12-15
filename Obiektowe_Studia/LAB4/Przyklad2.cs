using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Przyklad2
    {
        abstract class Figura
        {
            public abstract double ObliczPole();

            public void Info()
            {
                Console.WriteLine("To Jest figura geometryczna \n");
            }
        }

        class Kwadrat : Figura
        {
            private double bok;

            public Kwadrat(double bok)
            {
                this.bok = bok;
            }

            public override double ObliczPole()
            {
                return bok * bok;
            }
        }
        public static void RUN()
        {
            //Figura figura = new Figura(); nie mozna utworzyc obiektu klasy abstrakcyjnej 
            Figura figura1 = new Kwadrat(5);
            figura1.Info();
            Console.WriteLine("Pole kwadratu: " + figura1.ObliczPole());
        }
    }
}
