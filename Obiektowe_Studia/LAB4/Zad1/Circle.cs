namespace Obiektowe_Studia.LAB4.Zad1
{
    internal class Circle : Shape
    {
        public Circle(double x, double y, double radius) : base(x, y, radius, radius)
        {
        }
        public override void Drwa()
        {
            //base.Drwa();
            Console.WriteLine($"Rysujemy koło o środku S = {X}, y = {Y} o promieniu {Width}\n");
        }
    }
}
