using System;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "your_connection_string_here";
        var dbManager = new DatabaseManager(connectionString);
        var clientManager = new ClientManager(dbManager);

        Console.WriteLine("Wybierz operację:");
        Console.WriteLine("1 - Dodaj klienta");
        Console.WriteLine("2 - Wyświetl wszystkich klientów");
        Console.WriteLine("3 - Zaktualizuj klienta");
        Console.WriteLine("4 - Usuń klienta");
        Console.WriteLine("5 - Wyszukaj klienta po nazwisku");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                // Dodanie klienta
                Console.WriteLine("Podaj imię:");
                var imie = Console.ReadLine();
                Console.WriteLine("Podaj nazwisko:");
                var nazwisko = Console.ReadLine();
                Console.WriteLine("Podaj e-mail:");
                var email = Console.ReadLine();
                Console.WriteLine("Podaj telefon:");
                var telefon = Console.ReadLine();
                var klient = new Client
                {
                    Imie = imie,
                    Nazwisko = nazwisko,
                    Email = email,
                    Telefon = telefon,
                    DataRejestracji = DateTime.Now
                };
                clientManager.AddClient(klient);
                break;

            case "2":
                clientManager.DisplayAllClients();
                break;

            case "3":
                // Aktualizacja klienta
                break;

            case "4":
                // Usunięcie klienta
                break;

            case "5":
                // Wyszukiwanie klienta
                break;

            default:
                Console.WriteLine("Niepoprawna opcja.");
                break;
        }
    }
}