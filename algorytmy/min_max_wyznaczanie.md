# Wyznaczanie minimum i maksimum w tablicy

Algorytm polega na przeszukaniu zbioru danych (np. tablicy) w celu znalezienia wartości najmniejszej (minimum) oraz największej (maksimum).

----------

## 1. Logika działania

Najprostsza i najbardziej wydajna metoda polega na jednokrotnym przejściu przez całą tablicę:
1. Zakładamy, że pierwszy element tablicy (indeks 0) jest jednocześnie naszym aktualnym minimum i maksimum.
2. Przechodzimy przez kolejne elementy tablicy (od indeksu 1 do końca).
3. Dla każdego elementu wykonujemy porównanie:
   - Jeśli aktualny element jest **mniejszy** od naszego zapamiętanego minimum -> aktualizujemy minimum.
   - Jeśli aktualny element jest **większy** od naszego zapamiętanego maksimum -> aktualizujemy maksimum.
4. Po sprawdzeniu wszystkich elementów, zapamiętane wartości są ostatecznymi wynikami.



----------

## 2. Implementacja w C#

Poniżej znajduje się implementacja algorytmu dla tablicy liczb całkowitych.

```csharp
using System;

class Program
{
    static void WyznaczMinMax(int[] tablica)
    {
        // 1. Sprawdzenie czy tablica nie jest pusta
        if (tablica == null || tablica.Length == 0)
        {
            Console.WriteLine("Tablica jest pusta.");
            return;
        }

        // 2. Inicjalizacja zmiennych pierwszym elementem tablicy
        int min = tablica[0];
        int max = tablica[0];

        // 3. Przejście przez tablicę od drugiego elementu
        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] < min)
            {
                min = tablica[i]; // Znaleziono nową najmniejszą wartość
            }
            
            if (tablica[i] > max)
            {
                max = tablica[i]; // Znaleziono nową największą wartość
            }
        }

        // 4. Wypisanie wyników
        Console.WriteLine($"Najmniejsza wartość: {min}");
        Console.WriteLine($"Największa wartość: {max}");
    }

    static void Main()
    {
        int[] liczby = { 34, 12, 89, 5, 21, 55, 2 };
        
        WyznaczMinMax(liczby);
        // Wynik: Min: 2, Max: 89
    }
}
```
## 3. Implementacja w C++
```cpp
#include <iostream>
#include <vector>

using namespace std;

void wyznaczMinMax(const vector<int>& tablica) {
    // 1. Sprawdzenie czy tablica nie jest pusta (tzw. wartownik)
    if (tablica.empty()) {
        cout << "Tablica jest pusta." << endl;
        return;
    }

    // 2. Inicjalizacja zmiennych pierwszym elementem
    int min = tablica[0];
    int max = tablica[0];

    // 3. Przejście przez wektor od drugiego elementu
    for (size_t i = 1; i < tablica.size(); i++) {
        if (tablica[i] < min) {
            min = tablica[i]; // Nowe minimum
        }
        if (tablica[i] > max) {
            max = tablica[i]; // Nowe maksimum
        }
    }

    // 4. Wypisanie wyników
    cout << "Najmniejsza wartosc: " << min << endl;
    cout << "Najwieksza wartosc: " << max << endl;
}

int main() {
    vector<int> liczby = { 34, 12, 89, 5, 21, 55, 2 };

    wyznaczMinMax(liczby);

    return 0;
}
```
### Wskazówki (C++):
* vector vs tablica: Użycie std::vector pozwala na łatwe sprawdzenie rozmiaru za pomocą metody .size() oraz bezpieczne przekazywanie danych do funkcji.   

* Stała referencja (const vector<int>&): Przekazujemy tablicę przez referencję, aby nie kopiować całego zbioru danych w pamięci (oszczędność czasu i RAM). Słowo const gwarantuje, że funkcja nie zmieni zawartości oryginalnej tablicy.

* Typ size_t: W pętli for użyliśmy size_t zamiast int. Jest to bezznakowy typ przeznaczony specjalnie do indeksowania kontenerów – zapobiega ostrzeżeniom kompilatora o porównywaniu liczb z ujemnymi (int vs size_t).

* Złożoność: Algorytm wykonuje dokładnie $n-1$ porównań dla minimum i $n-1$ dla maksimum, co daje liniowy czas działania $O(n)$.