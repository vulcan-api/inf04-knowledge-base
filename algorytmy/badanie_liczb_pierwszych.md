# Badanie liczb pierwszych

Liczba pierwsza to liczba naturalna większa od 1, która posiada dokładnie dwa dzielniki: 1 oraz samą siebie.

----------

## 1. Logika działania

Najbardziej wydajną metodą sprawdzania pojedynczej liczby jest testowanie dzielników w przedziale od 2 do pierwiastka z tej liczby ($\sqrt{n}$).

- Liczby mniejsze od 2 nie są liczbami pierwszymi.
- Jeśli liczba $n$ posiada dzielnik większy niż 1 i mniejszy lub równy $\sqrt{n}$, to na pewno jest liczbą złożoną.
- Jeśli w tym przedziale nie znajdziemy żadnego dzielnika, liczba jest pierwsza.



----------

## 2. Implementacja w C#

Poniżej znajduje się optymalna implementacja algorytmu. Zwróć uwagę na warunek w pętli `i * i <= n`, który zastępuje kosztowną operację wyciągania pierwiastka.

```csharp
using System;

class Program
{
    static bool CzyPierwsza(int n)
    {
        // 1. Warunek brzegowy: liczby mniejsze od 2 nie są pierwsze
        if (n < 2) 
        {
            return false;
        }

        // 2. Sprawdzanie dzielników od 2 do pierwiastka z n
        // Warunek i * i <= n jest równoważny i <= sqrt(n)
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return false; // Znaleziono dzielnik, liczba nie jest pierwsza
            }
        }

        return true; // Nie znaleziono dzielników, liczba jest pierwsza
    }

    static void Main()
    {
        int liczba = 17;
        
        if (CzyPierwsza(liczba))
            Console.WriteLine($"{liczba} jest liczbą pierwszą.");
        else
            Console.WriteLine($"{liczba} nie jest liczbą pierwszą.");
    }
}
```
----------

### Wskazówki (C#)
- **Wydajność (Brak pierwiastka):** Zastosowanie warunku `i * i <= n` jest **podejściem optymalnym**. W ten sposób unikamy wywoływania metody `Math.Sqrt()`, która jest operacją kosztowną procesorowo (zmiennoprzecinkową). Mnożenie liczb całkowitych jest znacznie szybsze.
- **Klasa Math:** Jeśli zdecydowałbyś się na użycie pierwiastka, musisz skorzystać z klasy statycznej `Math` i metody `Math.Sqrt(n)`. Pamiętaj jednak, że `Math.Sqrt` zwraca typ `double`, więc warunek musiałby wyglądać tak: `i <= Math.Sqrt(n)`.
- **Wartownik (if n < 2):** Zawsze pamiętaj o sprawdzeniu liczb mniejszych od 2 na samym początku. Liczby 0 i 1 nie są ani pierwsze, ani złożone, co jest częstym błędem na egzaminach.
- **Typ zwracany:** Funkcja sprawdzająca (predykat) powinna zawsze zwracać typ `bool`, co pozwala na jej naturalne użycie w instrukcjach warunkowych `if (CzyPierwsza(liczba))`.

## 3. Implementacja w C++

Wersja optymalna z wykorzystaniem pętli sprawdzającej dzielniki do pierwiastka liczby:

```cpp
#include <iostream>

using namespace std;

bool czyPierwsza(int n) {
    // 1. Warunek brzegowy
    if (n < 2) {
        return false;
    }

    // 2. Sprawdzanie dzielników do pierwiastka z n
    // i * i <= n jest wydajniejsze niż używanie funkcji sqrt()
    for (int i = 2; i * i <= n; i++) {
        if (n % i == 0) {
            return false; // Znaleziono dzielnik - liczba złożona
        }
    }

    return true; // Brak dzielników - liczba pierwsza
}

int main() {
    int liczba = 17;

    if (czyPierwsza(liczba)) {
        cout << liczba << " jest liczba pierwsza." << endl;
    } else {
        cout << liczba << " nie jest liczba pierwsza." << endl;
    }

    return 0;
}
```
### Wskazówki (C++)
- **Wydajność:** Używamy zapisu `i * i <= n`, ponieważ jest to **wersja optymalna**. Mnożenie procesora jest znacznie szybsze niż obliczanie pierwiastka kwadratowego.
- **Biblioteka cmath:** Jeśli zdecydowałbyś się na użycie funkcji `sqrt(n)`, musisz na samym początku pliku dodać dyrektywę `#include <cmath>`. Wtedy warunek pętli wyglądałby tak: `i <= sqrt(n)`.
- **Typ logiczny:** W C++ używamy typu `bool`, który przyjmuje wartości `true` lub `false` (pamiętaj o małych literach).