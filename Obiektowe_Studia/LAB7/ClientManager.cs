using System;
using System.Collections.Generic;

public class ClientManager
{
    private readonly DatabaseManager dbManager;

    public ClientManager(DatabaseManager dbManager)
    {
        this.dbManager = dbManager;
    }

    public void AddClient(Client client)
    {
        if (ValidationHelper.IsValidEmail(client.Email) && ValidationHelper.IsValidPhoneNumber(client.Telefon))
        {
            dbManager.AddClient(client);
            Console.WriteLine("Klient został dodany.");
        }
        else
        {
            Console.WriteLine("Niepoprawne dane.");
        }
    }

    public void UpdateClient(Client client)
    {
        dbManager.UpdateClient(client);
        Console.WriteLine("Dane klienta zostały zaktualizowane.");
    }

    public void DeleteClient(int id)
    {
        dbManager.DeleteClient(id);
        Console.WriteLine("Klient został usunięty.");
    }

    public void DisplayAllClients()
    {
        var clients = dbManager.GetAllClients();
        foreach (var client in clients)
        {
            Console.WriteLine($"{client.Id}: {client.Imie} {client.Nazwisko}, {client.Email}, {client.Telefon}, {client.DataRejestracji}");
        }
    }

    public void SearchClientsByLastName(string lastName)
    {
        var clients = dbManager.GetClientsByLastName(lastName);
        foreach (var client in clients)
        {
            Console.WriteLine($"{client.Id}: {client.Imie} {client.Nazwisko}, {client.Email}, {client.Telefon}, {client.DataRejestracji}");
        }
    }
}