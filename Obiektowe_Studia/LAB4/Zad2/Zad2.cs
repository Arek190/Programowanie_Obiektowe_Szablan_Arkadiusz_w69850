namespace Obiektowe_Studia.LAB4.Zad2
{
    internal class Zad2
    {
        public static void RUN()
        {
    
            Pracownik pracownik = new Pracownik();

            pracownik.SetFirstName("Jan");
            pracownik.SetLastName("Kowalski");
            pracownik.SetPesel("92040512345");

            Console.WriteLine($"Imię: {pracownik.Imie}");
            Console.WriteLine($"Nazwisko: {pracownik.Nazwisko}");
            Console.WriteLine($"Wiek: {pracownik.GetAge()}");
            Console.WriteLine($"Płeć: {pracownik.GetGender()}");
        
    }
    }
}
