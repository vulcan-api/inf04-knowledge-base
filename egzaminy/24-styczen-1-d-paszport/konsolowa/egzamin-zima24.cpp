#include <iostream>   
#include <string>      

using namespace std;    

// Funkcja sprawdzająca płeć na podstawie numeru PESEL
char sprawdzPlec(string pesel)
{
    // Pobranie 10 cyfry numeru PESEL 
    int cyfra = pesel[9] - '0';  // zamiana znaku na liczbę

    // Sprawdzenie czy cyfra jest parzysta
    if (cyfra % 2 == 0)
        return 'K';   // parzysta -> kobieta
    else
        return 'M';   // nieparzysta -> mężczyzna
}

// Funkcja sprawdzająca poprawność sumy kontrolnej numeru PESEL

bool sprawdzSumeKontrolna(string pesel)
{
    // Tablica wag z arkusza
    int wagi[10] = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3};

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
        R = 10 - M;  // w przeciwnym wypadku 10 - reszta

    // bierzemy ostatnia cyfre PESEL
    int cyfraKontrolna = pesel[10] - '0';

    // Porównanie obliczonej cyfry kontrolnej z tą w numerze PESEL
    if (R == cyfraKontrolna)
        return true;     // PESEL poprawny
    else
        return false;    // PESEL błędny
}

int main()
{
    // Zmienna przechowująca numer PESEL jako tekst
    string pesel;

    // pytamy użytkownika o PESEL
    cout << "Podaj numer PESEL (11 cyfr): ";

    // Wczytanie numeru PESEL z klawiatury
    cin >> pesel;

    // sprawdzamy płeć
    char plec = sprawdzPlec(pesel);

    // Sprawdzenie wyniku funkcji i wypisanie płci
    if (plec == 'K')
        cout << "Plec: Kobieta" << endl;
    else
        cout << "Plec: Mezczyzna" << endl;

    // sprawdzamy czy PESEL jest poprawny
    if (sprawdzSumeKontrolna(pesel))
        cout << "Suma kontrolna: poprawna" << endl;
    else
        cout << "Suma kontrolna: niepoprawna" << endl;

    return 0;
}
