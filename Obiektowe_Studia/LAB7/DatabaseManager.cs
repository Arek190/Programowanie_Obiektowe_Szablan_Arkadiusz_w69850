using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class DatabaseManager
{
    private readonly string connectionString;

    public DatabaseManager(string connectionString)
    {
        this.connectionString = connectionString;
    }

    // Połączenie z bazą danych
    private SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    // Dodanie nowego klienta
    public void AddClient(Client client)
    {
        using (var connection = GetConnection())
        {
            connection.Open();
            var command = new SqlCommand("INSERT INTO Klienci (Imie, Nazwisko, Email, Telefon, DataRejestracji) VALUES (@Imie, @Nazwisko, @Email, @Telefon, @DataRejestracji)", connection);
            command.Parameters.AddWithValue("@Imie", client.Imie);
            command.Parameters.AddWithValue("@Nazwisko", client.Nazwisko);
            command.Parameters.AddWithValue("@Email", client.Email);
            command.Parameters.AddWithValue("@Telefon", client.Telefon);
            command.Parameters.AddWithValue("@DataRejestracji", client.DataRejestracji);

            command.ExecuteNonQuery();
        }
    }

    // Wyszukiwanie wszystkich klientów
    public List<Client> GetAllClients()
    {
        var clients = new List<Client>();

        using (var connection = GetConnection())
        {
            connection.Open();
            var command = new SqlCommand("SELECT * FROM Klienci", connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var client = new Client
                {
                    Id = (int)reader["Id"],
                    Imie = reader["Imie"].ToString(),
                    Nazwisko = reader["Nazwisko"].ToString(),
                    Email = reader["Email"].ToString(),
                    Telefon = reader["Telefon"].ToString(),
                    DataRejestracji = (DateTime)reader["DataRejestracji"]
                };
                clients.Add(client);
            }
        }

        return clients;
    }

    // Zaktualizowanie klienta
    public void UpdateClient(Client client)
    {
        using (var connection = GetConnection())
        {
            connection.Open();
            var command = new SqlCommand("UPDATE Klienci SET Imie = @Imie, Nazwisko = @Nazwisko, Email = @Email, Telefon = @Telefon WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Imie", client.Imie);
            command.Parameters.AddWithValue("@Nazwisko", client.Nazwisko);
            command.Parameters.AddWithValue("@Email", client.Email);
            command.Parameters.AddWithValue("@Telefon", client.Telefon);
            command.Parameters.AddWithValue("@Id", client.Id);

            command.ExecuteNonQuery();
        }
    }

    // Usunięcie klienta
    public void DeleteClient(int id)
    {
        using (var connection = GetConnection())
        {
            connection.Open();
            var command = new SqlCommand("DELETE FROM Klienci WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }
    }

    // Wyszukiwanie klientów po nazwisku
    public List<Client> GetClientsByLastName(string lastName)
    {
        var clients = new List<Client>();

        using (var connection = GetConnection())
        {
            connection.Open();
            var command = new SqlCommand("SELECT * FROM Klienci WHERE Nazwisko LIKE @Nazwisko", connection);
            command.Parameters.AddWithValue("@Nazwisko", "%" + lastName + "%");
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var client = new Client
                {
                    Id = (int)reader["Id"],
                    Imie = reader["Imie"].ToString(),
                    Nazwisko = reader["Nazwisko"].ToString(),
                    Email = reader["Email"].ToString(),
                    Telefon = reader["Telefon"].ToString(),
                    DataRejestracji = (DateTime)reader["DataRejestracji"]
                };
                clients.Add(client);
            }
        }

        return clients;
    }
}
