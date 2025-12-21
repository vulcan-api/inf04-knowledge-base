using System;

//funkcje strzałkowe
//Funkcja strzałkowa to skrócona postać funkcji bez nazwy, przypisana do zmiennej
//Funkcja klasyczna jest definiowana osobno, a funkcja strzałkowa bezpośrednio w miejscu użycia

class Program
{
    // ---------------------------------------------
    // zwykła funkcja:
    // ---------------------------------------------
    static int Dodaj(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        // ---------------------------------------------
        // funkcja strzałkowa:
        // ---------------------------------------------
        Func<int, int, int> dodaj = (int a, int b) =>
        {
            return a + b;
        };

        // ---------------------------------------------
        // wersja bez funkcji strzałkowej:
        // ---------------------------------------------

        int a, b;

        Console.Write("Podaj dwie liczby: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("NWD = " + NWD(a, b));

        // ---------------------------------------------
        // wersja z jej wykorzystaniem:
        // ---------------------------------------------

        // Funkcja strzałkowa obliczająca NWD
        Func<int, int, int> NWD_lambda = (int x, int y) =>
        {
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            return x;
        };

        Console.WriteLine("NWD (funkcja strzalkowa) = " + NWD_lambda(a, b));
    }

    // Funkcja obliczająca NWD (wersja klasyczna)
    static int NWD(int a, int b)
    {
        while (a != b)
        {
            if (a > b)
                a = a - b;
            else
                b = b - a;
        }
        return a;
    }
}
