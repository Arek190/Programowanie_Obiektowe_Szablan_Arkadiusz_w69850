// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Globalization;
using System.Numerics;

//Console.WriteLine("Hello, World!");
/*
 * Komentarze
 */

//Console.WriteLine(3+3);

//int z, b = 34;
//double c = 34.34;
//short s = 1;
//long longbA = 12312312312312;
//char znak = 'a';
//string name1 = "jan";
//bool type = true;


//Console.WriteLine("wartość liczby b = " + b);
//Console.WriteLine("s = " + s);


//Console.WriteLine("Podaj imię: ");
//string name = Console.ReadLine();
//Console.WriteLine("Twoje imię: " + name);

//Console.WriteLine("Podaj liczbę: ");
//int number = Convert.ToInt32( Console.ReadLine());
//Console.WriteLine("Twoja liczba: " + number);

//int liczba  = 10;
//String tekst = "jan";
//Console.WriteLine("Podaj liczbę: ");
//string input = Console.ReadLine();
//int liczba = int.Parse(input);
//int a = 4;
//if (a==2)
//{
//    Console.WriteLine("ok");
//}else
//{
//    Console.WriteLine("Nie ok!");
//}

//Console.WriteLine("while");
//while (a < 5)
//{
//    Console.WriteLine(a);
//    a++;
//}

//a = 1;
//Console.WriteLine("do while");
//do
//{
//    Console.WriteLine(a);
//    a++;
//}
//while (a < 5);

//Console.WriteLine("for");

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(i);
//}


//string[] name = { "jan", "alina" };
//int[] number = { 1, 2, 3, 3 };

//Console.WriteLine(number[0]);
//Console.WriteLine("Dlugosc tablicy: " + number.Length);

//string[] car = new string[45];
//string[] car1 = new string[4] {"a",  "b", "c", "d" };
//string[] car2 = new string[] { "a", "b", "c", "d" };

//foreach (var item in name)
//{
//    Console.WriteLine(item);
//}


//napisz program obliczający wyróżnik delta i pierwiastki trójmianu kwadratowego

//zadanie1(); <------ Wywołanie zadania 1

// ----------- koniec main ---------------------

static void zadanie1()
{
    // deklaracja zmiennych
    double a = doubleInput();
    double b = doubleInput();
    double c = doubleInput();
    double delta, x1, x2;

    if (a != 0)
    {
        delta = Math.Pow(b, 2) - (4 * a * c);
        if (delta < 0)
        {
            Console.WriteLine("Brak rozwiazania w zbiorze liczb rzeczywistych");
        }
        else if (delta == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine("jedno rozwiazanie x1 = " + x1);
            Console.WriteLine($" Jedno rozwiązanie x1={x1:F2}"); 
        }
        else
        {
            x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Dwa rozwiazania: \t x1 = " + x1 + "\t x2 = " + x2);
            Console.WriteLine($"Dwa rozwiązania: x1 = {x1:F2} \t x2 = {x2:F2}");
        }

        }
        else { Console.WriteLine("To nie jest równanie kwadratowe!"); }
    }

    static double doubleInput()
    {
        Console.WriteLine("Podaj liczbe: ");
        double input = Convert.ToDouble(Console.ReadLine());
        return input;
    }


zadanie2();

/*
2. Napisz kalkulator obliczający: sumę, różnicę, iloczyn, iloraz, potęgę, pierwiastek, oraz wartości
funkcji trygonometrycznych dla zadanego kąta. Użyj biblioteki Math np. Math.Sin(2.5). Proszę
pamiętać, że wartości kąta podawane do funkcji mierzone są miarą łukową. Wyniki działania
algorytmów wyświetlaj na konsoli. Do obsługi menu proszę użyć konstrukcji switch-case oraz pętli while.
*/

static void zadanie2()
{
    menu();

    static void menu()
    {
        //ViewMenu:
        Console.WriteLine("-----------Kalkulator---------");
        Console.WriteLine("1 Suma\n2 Różnica \n3 Iloczyn \n4 Iloraz \n5 Potęga \n6 Pierwiastek \n7 Trygonometria \n8 Wyjście");
        

        while (true) {
            Console.WriteLine("Wybierz opcje: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: Total(); break;
                case 2: Difference(); break;
                case 3: ProductNumber(); break;
                case 4: QuationNumber(); break;
                case 5: PotentationNumber(); break;
                case 6: SquareNumber(); break;
                case 7: TrigonNumber(); break; // zmiana wartosci na ( input *Math.PI) /180
                case 8: Close(); break;
                default: Console.WriteLine("Bledny wybor, wybierz jeszcze raz opcje."); break; //goto ViewMenu;<--- wraca do linii 150 
            }//koniec switch
        }
    }

}

static void TrigonNumber()
{
    double a = doubleInput();
    Console.WriteLine($"Wartość funkcji trygonometrycznej dla kąta: {a} = { (a*Math.PI)/180}");
}

static void SquareNumber()
{
    double a = doubleInput();
    Console.WriteLine($"Pierwiastek liczby {a} = {Math.Sqrt(a)}");
}

static void PotentationNumber()
{
    double a = doubleInput();
    Console.WriteLine($"Potęga liczby {a} = {Math.Pow(a, 2)}");
}

static void QuationNumber()
{
    double a = doubleInput();
    double b = doubleInput();
    Console.WriteLine($"Iloraz {a}/{b} = {a / b}");
}

static void ProductNumber()
{
    double a = doubleInput();
    double b = doubleInput();
    Console.WriteLine($"Iloczyn {a} * {b} = {a * b}");
}

static void Difference()
{
    double a = doubleInput();
    double b = doubleInput();
    Console.WriteLine($"Różnica {a} - {b} = {a - b}");
}

static void Total()
{
    double a = doubleInput();
    double b = doubleInput();
    Console.WriteLine($"Suma {a} + {b} = {a + b}");
}

static void Close()
{
    Console.WriteLine("Koniec programu");
    System.Environment.Exit(1);
}