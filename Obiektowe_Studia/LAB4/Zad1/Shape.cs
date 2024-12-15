//posiadająca właściwośći X, Y, Height,
//Width oraz virtualną metodę Drwa.

namespace Obiektowe_Studia.LAB4.Zad1
{
    internal class Shape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public Shape(double x, double y, double height, double width)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }

        public virtual void Drwa()
        {
            Console.WriteLine("Rysujemy figurę Shape");
        }
    }
}
