
namespace Obiektowe_Studia.LAB4.Zad2
{

    public abstract class Osoba
    {
        // Pola klasy
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public string Pesel { get; private set; }

        // Metody ustawiające wartości pól
        public virtual void SetFirstName(string imie)
        {
            Imie = imie;
        }

        public virtual void SetLastName(string nazwisko)
        {
            Nazwisko = nazwisko;
        }

        public virtual void SetPesel(string pesel)
        {
            Pesel = pesel;
        }

        // Metoda obliczająca wiek na podstawie PESEL
        public virtual int GetAge()
        {
            if (Pesel == null)
                throw new InvalidOperationException("PESEL nie został ustawiony.");

            // Wyodrębnij rok, miesiąc i dzień urodzenia z PESEL
            int year = int.Parse(Pesel.Substring(0, 2));
            int month = int.Parse(Pesel.Substring(2, 2));
            int day = int.Parse(Pesel.Substring(4, 2));

            // Obsługa roku w zależności od wieku osoby
            if (month > 20) // 2000-2099
            {
                year += 2000;
                month -= 20;
            }
            else // 1900-1999
            {
                year += 1900;
            }

            DateTime birthDate = new DateTime(year, month, day);
            DateTime now = DateTime.Now;

            int age = now.Year - birthDate.Year;
            if (now < birthDate.AddYears(age))
                age--;

            return age;
        }

        // Metoda określająca płeć na podstawie PESEL
        public virtual string GetGender()
        {
            if (Pesel == null)
                throw new InvalidOperationException("PESEL nie został ustawiony.");

            // Pozycja 10 w PESEL wskazuje płeć
            int genderDigit = int.Parse(Pesel.Substring(10, 1));
            return (genderDigit % 2 == 0) ? "Kobieta" : "Mężczyzna";
        }
    }

    // Przykładowa klasa dziedzicząca
    public class Pracownik : Osoba
    {
        public string Stanowisko { get; set; }

        public override void SetFirstName(string imie)
        {
            base.SetFirstName(imie);
            Console.WriteLine($"Ustawiono imię: {imie}");
        }

        public override void SetLastName(string nazwisko)
        {
            base.SetLastName(nazwisko);
            Console.WriteLine($"Ustawiono nazwisko: {nazwisko}");
        }
    }


}
