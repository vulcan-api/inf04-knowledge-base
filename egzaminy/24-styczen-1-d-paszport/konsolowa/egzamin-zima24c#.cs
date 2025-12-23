using System;  

class Program
{
    // Funkcja sprawdzająca płeć na podstawie numeru PESEL
    static char SprawdzPlec(string pesel)
    {
        // Pobranie 10 cyfry numeru PESEL
        int cyfra = pesel[9] - '0';  // zamiana znaku na liczbę

        // Sprawdzenie czy cyfra jest parzysta
        if (cyfra % 2 == 0)
            return 'K';   // parzysta - kobieta
        else
            return 'M';   // nieparzysta - mężczyzna
    }

    // Funkcja sprawdzająca poprawność sumy kontrolnej numeru PESEL
    static bool SprawdzSumeKontrolna(string pesel)
    {
        // Tablica wag z arkusza
        int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

        int suma = 0;

        for (int i = 0; i < 10; i++)
        {
            // bierzemy jedną cyfrę PESEL i zamieniamy na liczbę
            int cyfra = pesel[i] - '0';

            // mnożymy cyfrę przez wagę i dodajemy do sumy
            suma += cyfra * wagi[i];
        }

        // bierzemy resztę z dzielenia przez 10
        int M = suma % 10;

        // Zmienna przechowująca wynik końcowy (cyfrę kontrolną)
        int R;

        // Jeżeli reszta wynosi 0
        if (M == 0)
            R = 0;        // to cyfra kontrolna to 0
        else
            R = 10 - M;  // w przeciwnym wypadku 10 - reszta z dzielenia

        // bierzemy ostatnia cyfre PESEL
        int cyfraKontrolna = pesel[10] - '0';

        // Porównanie obliczonej cyfry kontrolnej z tą w numerze PESEL
        if (R == cyfraKontrolna)
            return true;     // PESEL poprawny
        else
            return false;    // PESEL błędny
    }

    static void Main()
    {
        // Zmienna przechowująca numer PESEL jako tekst
        string pesel;

        // pytamy użytkownika o PESEL
        Console.Write("Podaj numer PESEL (11 cyfr): ");

        // Wczytanie numeru PESEL z klawiatury
        pesel = Console.ReadLine();

        // sprawdzamy płeć
        char plec = SprawdzPlec(pesel);

        // Sprawdzenie wyniku funkcji i wypisanie płci
        if (plec == 'K')
            Console.WriteLine("Plec: Kobieta");
        else
            Console.WriteLine("Plec: Mezczyzna");

        // sprawdzamy czy PESEL jest poprawny
        if (SprawdzSumeKontrolna(pesel))
            Console.WriteLine("Suma kontrolna: poprawna");
        else
            Console.WriteLine("Suma kontrolna: niepoprawna");
    }
}
