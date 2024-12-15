namespace Obiektowe_Studia.LAB4.Zad1
{
    internal class Triangle : Shape
    {
        public Triangle(double x, double y, double height, double width) : base(x, y, height, width)
        {
        }
        public override void Drwa()
        {
            //base.Drwa();
            Console.WriteLine($"Rysujemy trójkąt o współrzędnych x = {X}, y = {Y} o podstawie {Width} i wysokości {Height}\n");
        }
    }
}
