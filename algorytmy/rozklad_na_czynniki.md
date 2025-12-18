# Rozkład liczby na czynniki pierwsze

Rozkład na czynniki pierwsze polega na przedstawieniu dowolnej liczby złożonej w postaci iloczynu liczb pierwszych.

----------

## 1. Logika działania

Algorytm opiera się na sukcesywnym dzieleniu liczby przez coraz większe dzielniki:
1. Zacznij od najmniejszej liczby pierwszej ($k = 2$).
2. Dopóki liczba $n$ jest podzielna przez $k$ (reszta z dzielenia wynosi 0):
   - Wypisz lub zapisz dzielnik $k$.
   - Podziel liczbę $n$ przez $k$ ($n = n / k$).
3. Jeśli liczba $n$ przestała być podzielna przez $k$, zwiększ $k$ o 1 i powtórz sprawdzanie.
4. Algorytm kończy się, gdy liczba $n$ zostanie zredukowana do 1.



[Image of factor tree for prime factorization of a number]


----------

## 2. Implementacja w C#

Poniżej znajduje się klasyczna implementacja algorytmu z wykorzystaniem zagnieżdżonych pętli `while`.

```csharp
using System;

class Program
{
    static void RozkladNaCzynniki(int n)
    {
        int k = 2; // Najmniejszy potencjalny dzielnik pierwszy

        // Pętla główna wykonuje się dopóki liczba n nie zostanie w pełni rozłożona
        while (n > 1)
        {
            // Pętla wewnętrzna sprawdza ile razy dany dzielnik k mieści się w n
            while (n % k == 0)
            {
                Console.Write(k + " "); // Wypisujemy znaleziony czynnik
                n /= k; // Dzielimy n przez k, aby szukać kolejnych czynników
            }
            
            k++; // Zwiększamy dzielnik o 1
        }
    }

    static void Main()
    {
        int liczba = 120;
        
        Console.Write($"Czynniki pierwsze liczby {liczba} to: ");
        RozkladNaCzynniki(liczba);
        // Przykładowy wynik dla 120: 2 2 2 3 5
    }
}
```
### Wskazówki
* ### Dlaczego k++ działa?
 Może się wydawać, że powinniśmy zwiększać k tylko o liczby pierwsze. Jednak dzięki pętli wewnętrznej, gdy k dotrze do liczby złożonej (np. 4), to wszystkie jej dzielniki pierwsze (np. 2) zostały już dawno wyeliminowane z liczby n. Zatem n % 4 nigdy nie zwróci 0.