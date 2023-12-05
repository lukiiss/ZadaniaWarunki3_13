using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj pierwszą liczbę: ");
        string a = Console.ReadLine();
        float first;
        float.TryParse(a, out first);

        Console.WriteLine("Podaj drugą liczbę: ");
        string b = Console.ReadLine();
        float second;
        float.TryParse(b, out second);

        Console.WriteLine("Podaj numer operacji do wykonania: ");
        Console.WriteLine("1. Dodawanie");
        Console.WriteLine("2. Odejmowanie");
        Console.WriteLine("3. Mnożenie");
        Console.WriteLine("4. Dzielenie");
        string choose = Console.ReadLine();
        int ChoosenOperation;
        int.TryParse(choose, out ChoosenOperation);

        switch (ChoosenOperation)
        {
            case 1:
                float wynikDo = first + second;
                Console.Write("Twój wynik to: ");
                Console.Write(wynikDo);
                break;
            case 2:
                float wynikO = first - second;
                Console.Write("Twój wynik to: ");
                Console.Write(wynikO);
                break;
            case 3:
                float wynikM = first * second;
                Console.Write("Twój wynik to: ");
                Console.Write(wynikM);
                break;
            case 4:
                float wynikDz = first / second;
                Console.Write("Twój wynik to: ");
                Console.Write(wynikDz);
                break;
            default:
                Console.WriteLine("Zła wartość. Spróbuj ponownie.");
                break;
        }

    }
}