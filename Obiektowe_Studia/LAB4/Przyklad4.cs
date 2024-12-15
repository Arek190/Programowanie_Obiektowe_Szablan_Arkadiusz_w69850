
namespace LAB4
{
    enum Kolor
    {
        Czerwony,      //0
        Zielony,       //1
        Zółty,         //2
        Niebieski = 10,
        Czarny         //11
    }
    internal class Przyklad4
    {
        public static void RUN()
        {
            Kolor mojKolor = Kolor.Czerwony;
            Console.WriteLine("Wybrany Kolor: " + mojKolor);
        }
    }
}
