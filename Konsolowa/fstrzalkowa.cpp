//funkcje strzałkowe
//Funkcja strzałkowa to skrócona postać funkcji bez nazwy, przypisana do zmiennej
//Funkcja klasyczna jest definiowana osobno, a funkcja strzałkowa bezpośrednio w miejscu użycia

//zwykla funkcja:
int dodaj(int a, int b)
{
    return a + b;
}

//funkcja strzalkowa:
auto dodaj = [](int a, int b) {
    return a + b;
};


//wersja bez f. strzalkowej:
#include <iostream>
using namespace std;

// Funkcja obliczająca NWD
int NWD(int a, int b)
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

int main()
{
    int a, b;

    cout << "Podaj dwie liczby: ";
    cin >> a >> b;

    cout << "NWD = " << NWD(a, b) << endl;

    return 0;
}


//wersja z jej wykorzystaniem:
#include <iostream>
using namespace std;

int main()
{
    // Funkcja strzałkowa obliczająca NWD
    auto NWD = [](int a, int b)
    {
        while (a != b)
        {
            if (a > b)
                a = a - b;
            else
                b = b - a;
        }
        return a;
    };

    int a, b;

    cout << "Podaj dwie liczby: ";
    cin >> a >> b;

    cout << "NWD = " << NWD(a, b) << endl;

    return 0;
}
