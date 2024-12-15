namespace LAB4
{
	internal class Przyklad5
	{
		class MojeWyjatki : Exception
		{
			public MojeWyjatki(string message) : base(message)
			{

			}
		}
		public static void RUN()
		{
			//try
			//{
			//	Console.WriteLine("Podaj licznik:");
			//	int licznik = int.Parse(Console.ReadLine());
			//	Console.WriteLine("Podaj mianownik:");
			//	int mianownik = int.Parse(Console.ReadLine());

			//	int wynik = licznik / mianownik;
			//	Console.WriteLine("Wynik działania: " + wynik);
			//}
			//catch (DivideByZeroException ex)
			//{
			//	Console.WriteLine("Błąd: Nie moża dzielić przez zero!");
			//	Console.WriteLine($"Szegóły błędu: {ex.Message}");
			//}
			//catch (FormatException ex)
			//{
			//	Console.WriteLine("Błąd: Podano nieprawidłwiy typ danych:");
			//	Console.WriteLine($"Szegóły błędu: {ex.Message}");
			//}
			//catch (Exception ex) 
			//{
			//             Console.WriteLine("Wystąpił błąd");
			//             Console.WriteLine($"Szegóły błędu: {ex.Message}");
			//         }

			//finally
			//{
			//	Console.WriteLine("Wykonał się blok finally!");
			//}

			try
			{
				SprawdzLiczbe(-23);
			}
			catch (MojeWyjatki ex)
			{
				Console.WriteLine($"Własny wyjątek {ex.Message}");
			}

			static void SprawdzLiczbe(int liczba)
			{
				if (liczba <= 0)
				{
					throw new MojeWyjatki("Liczba musi być większa od zera!");
				}
			}
		}
	}
}
