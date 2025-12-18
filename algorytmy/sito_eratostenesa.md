# Sito Eratostenesa

Sito Eratostenesa to jeden z najwydajniejszych algorytmów służący do wyznaczania **wszystkich liczb pierwszych** z przedziału $[2, n]$.

----------

## 1. Logika działania

Algorytm opiera się na eliminowaniu (odsiewaniu) wielokrotności liczb, które na pewno nie są pierwsze:
1. Przygotuj tablicę logiczną (np. `bool[]`) o rozmiarze $n+1$ i wypełnij ją początkowo wartością `true`.
2. Indeksy 0 i 1 oznacz jako `false` (nie są to liczby pierwsze).
3. Zacznij od pierwszej liczby pierwszej, czyli $i = 2$.
4. Jeśli liczba $i$ jest oznaczona jako pierwsza (`true`), to przejdź przez wszystkie jej wielokrotności ($i*i, i*i+i, \dots$) i oznacz je jako `false`.
5. Powtarzaj krok 4 dla kolejnych liczb $i$ aż do osiągnięcia pierwiastka z $n$ ($\sqrt{n}$).
6. Liczby, które pozostały oznaczone jako `true`, to szukane liczby pierwsze.



----------

## 2. Implementacja w C#

Wersja zoptymalizowana z wykorzystaniem tablicy typu `bool`.

```csharp
using System;

class Program
{
    static void SitoEratostenesa(int n)
    {
        // 1. Inicjalizacja tablicy o rozmiarze n + 1
        bool[] czyPierwsza = new bool[n + 1];

        // 2. Wypełnienie tablicy wartością true
        for (int i = 2; i <= n; i++)
        {
            czyPierwsza[i] = true;
        }

        // 3. Główna pętla algorytmu (odsiewanie)
        // Sprawdzamy tylko do pierwiastka z n
        for (int i = 2; i * i <= n; i++)
        {
            // Jeśli i jest liczbą pierwszą, wykreślamy jej wielokrotności
            if (czyPierwsza[i] == true)
            {
                // Wielokrotności zaczynamy wykreślać od i * i
                for (int j = i * i; j <= n; j += i)
                {
                    czyPierwsza[j] = false;
                }
            }
        }

        // 4. Wypisanie wyników
        Console.WriteLine($"Liczby pierwsze w przedziale od 2 do {n}:");
        for (int i = 2; i <= n; i++)
        {
            if (czyPierwsza[i])
            {
                Console.Write(i + " ");
            }
        }
    }

    static void Main()
    {
        int zakres = 100;
        SitoEratostenesa(zakres);
    }
}
```
## 3. Implementacja w C++

Wersja zoptymalizowana z dynamiczną alokacją tablicy (użycie `bool*` lub `std::vector<bool>` jest zalecane przy dużych zakresach):

```cpp
#include <iostream>
#include <vector>

using namespace std;

void sitoEratostenesa(int n) {
    // 1. Inicjalizacja tablicy (std::vector<bool> jest bardzo oszczędny pamięciowo)
    vector<bool> czyPierwsza(n + 1, true);

    // 2. Indeksy 0 i 1 nie są liczbami pierwszymi
    czyPierwsza[0] = czyPierwsza[1] = false;

    // 3. Główna pętla sita (odsiewanie)
    // i * i <= n zastępuje użycie funkcji sqrt(n)
    for (int i = 2; i * i <= n; i++) {
        if (czyPierwsza[i]) {
            // Wielokrotności wykreślamy zaczynając od i * i
            for (int j = i * i; j <= n; j += i) {
                czyPierwsza[j] = false;
            }
        }
    }

    // 4. Wypisanie wyników
    cout << "Liczby pierwsze w przedziale od 2 do " << n << ":" << endl;
    for (int i = 2; i <= n; i++) {
        if (czyPierwsza[i]) {
            cout << i << " ";
        }
    }
    cout << endl;
}

int main() {
    int zakres = 100;
    sitoEratostenesa(zakres);
    return 0;
}