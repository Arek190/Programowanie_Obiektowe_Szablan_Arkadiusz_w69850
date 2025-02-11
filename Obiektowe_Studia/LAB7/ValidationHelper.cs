using System;
using System.Text.RegularExpressions;

public static class ValidationHelper
{
    // Sprawdzenie poprawności formatu email
    public static bool IsValidEmail(string email)
    {
        var emailRegex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
        return emailRegex.IsMatch(email);
    }

    // Sprawdzenie poprawności numeru telefonu
    public static bool IsValidPhoneNumber(string phoneNumber)
    {
        var phoneRegex = new Regex(@"^\+?\d{10,15}$");
        return phoneRegex.IsMatch(phoneNumber);
    }
}