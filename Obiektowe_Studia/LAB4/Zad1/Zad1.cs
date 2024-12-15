/*Zadanie 1.
using System.Drawing;

Zaimplementuj klasę Shape, posiadającą właściwości X, Y, Height, Width oraz virutalną metodę Draw.
Następnie zaimplementuj klasy:
• Rectangle,
• Triangle,
• Circle
które będą implementować metodę draw poprzez wypisanie na okno konsoli jaką figurę próbujemy
narysować. Następnie napisz program, który do listy List<Shape>, doda po obiekcie każdego typu z klas
dziedziczących. Następnie wywołaj dla każdego elementu w liście funkcję draw.
*/


namespace Obiektowe_Studia.LAB4.Zad1
{

    internal class Zad1
    {
        public static void RUN()
        {

            List<Shape> shapes = new List<Shape>();

            //dodawanie
            shapes.Add(new Rectangle(10, 20, 30, 40));
            shapes.Add(new Triangle(15, 25, 35, 55));
            shapes.Add(new Circle(5, 5, 10));

            foreach (Shape shape in shapes)
                shape.Drwa();


            //Console.ReadKey(); // Metoda która zatrzymuje konsole, oczekuje na znak
        }
    }
}
