namespace Obiektowe_Studia.LAB4.Zad1
{
    internal class Rectangle : Shape
    {
        public Rectangle(double x, double y, double height, double width) : base(x, y, height, width)
        {
        }

        public override void Drwa()
        {
            //base.Drwa();
            Console.WriteLine($"Rysujemy prostokąt o współrzędnych x = {X}, y = {Y} o długośći {Width} i wysokości {Height}\n");
        }

    }
}
