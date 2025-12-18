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