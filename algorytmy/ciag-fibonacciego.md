# Ciąg Fibonacciego (Iteracyjnie)

Powrót na start -> [Start](./root.md)

Ciąg Fibonacciego to ciąg liczb naturalnych, w którym każdy kolejny wyraz (oprócz dwóch pierwszych) jest sumą dwóch poprzednich.

**Początek ciągu:** $0, 1, 1, 2, 3, 5, 8, 13, 21, 34, \dots$

----------

## Logika działania

-   $F(0) = 0$
    
-   $F(1) = 1$
    
-   $F(n) = F(n-1) + F(n-2)$ dla $n > 1$
    

----------

## Implementacja w C#

Na egzaminie INF.04 możesz zostać poproszony o wersję **iteracyjną** (wydajniejszą) lub **rekurencyjną** (krótszą w zapisie).

### Wersja Iteracyjna (Zalecana)

Jest bezpieczniejsza, ponieważ nie obciąża pamięci  i działa bardzo szybko nawet dla dużych $n$.

C#

```csharp
using System;

class Program
{
    static long FibonacciIteracyjny(int n)
    {
        if (n <= 1) return n;

        long poprzednia = 0; // F(0)
        long aktualna = 1;   // F(1)
        long nastepna = 0;

        for (int i = 2; i <= n; i++)
        {
            nastepna = poprzednia + aktualna;
            poprzednia = aktualna;
            aktualna = nastepna;
        }

        return aktualna;
    }

    static void Main()
    {
        int wyraz = 10;
        Console.WriteLine($"{wyraz}. wyraz ciągu Fibonacciego to: {FibonacciIteracyjny(wyraz)}");
        // Wynik: 55
    }
}
```
---
### Wskazówki
-   **Pamiętaj o typach danych:** Wyrazy ciągu Fibonacciego rosną bardzo szybko. Już przy 47. wyrazie przekroczysz zakres standardowego `int` (2 mld). Na egzaminie używaj typu `long`, aby uniknąć błędów przepełnienia.
    
-   **Wartownik:** Zawsze sprawdzaj warunek brzegowy: `if (n <= 1) return n;`, aby uniknąć nieskończonej rekurencji lub błędnych obliczeń dla 0 i 1.
- **Jeśli w zadaniu nie jest narzucone użycie rekurencji, **zawsze wybieraj wersję iteracyjną (z pętlą `for`)**. Jest ona setki razy szybsza i bezpieczniejsza dla pamięci komputera.**
---
# Ciąg Fibonacciego (Rekurencyjnie)

Rekurencja polega na tym, że funkcja wywołuje samą siebie, aby rozwiązać mniejszy podproblem.

----------

## Kod w języku C#

Poniżej znajduje się najprostsza, klasyczna implementacja rekurencyjna:

C#

```csharp
using System;

class Program
{
    // Funkcja rekurencyjna do obliczania n-tego wyrazu
    static long FibonacciRekurencyjny(int n)
    {
        // 1. Warunek stopu (brzegowy) - bez tego funkcja wywoływałaby się w nieskończoność
        if (n <= 1)
        {
            return n;
        }

        // 2. Wywołanie rekurencyjne - suma dwóch poprzednich wyrazów
        return FibonacciRekurencyjny(n - 1) + FibonacciRekurencyjny(n - 2);
    }

    static void Main()
    {
        int n = 7;
        Console.WriteLine($"Wyraz numer {n} ciągu Fibonacciego to: {FibonacciRekurencyjny(n)}");
        // Dla n=7 wynik to 13 (0, 1, 1, 2, 3, 5, 8, 13...)
    }
}
```

## Implementacja w C++ (Iteracyjna)

Wersja iteracyjna jest optymalna pod względem pamięciowym i czasowym. Wykorzystuje proste przypisania w pętli.

C++

```cpp
#include <iostream>
using namespace std;

/**
 * Funkcja oblicza n-ty wyraz ciągu Fibonacciego iteracyjnie.
 * Typ long long pozwala przechowywać znacznie większe liczby niż zwykły int.
 */
long long fibonacciIteracyjny(int n) {
    // Przypadek dla F(0) = 0 i F(1) = 1
    if (n <= 1) return n;

    long long poprzednia = 0; // F(i-2)
    long long aktualna = 1;   // F(i-1)
    long long nastepna = 0;

    // Obliczamy wyrazy od 2 do n
    for (int i = 2; i <= n; i++) {
        nastepna = poprzednia + aktualna; // Suma dwóch poprzednich
        poprzednia = aktualna;            // Przesunięcie okna: stara aktualna staje się poprzednią
        aktualna = nastepna;              // Przesunięcie okna: nowa suma staje się aktualną
    }

    return aktualna;
}

int main() {
    int n = 10;
    // cout służy do wyświetlania danych w konsoli
    cout << n << ". wyraz ciagu to: " << fibonacciIteracyjny(n) << endl;
    return 0;
}

```

----------

## Implementacja w C++ (Rekurencyjna)

Rekurencja w C++ jest bardzo czytelna, ale pamiętaj o jej wadzie: dla dużych `n` (np. $n > 40$) program może się "zawiesić" z powodu ogromnej liczby powtarzających się obliczeń.

C++

```cpp
#include <iostream>
using namespace std;

/**
 * Funkcja oblicza n-ty wyraz ciągu Fibonacciego rekurencyjnie.
 */
long long fibonacciRekurencyjny(int n) {
    // 1. WARUNEK STOPU: zwraca 0 dla n=0 i 1 dla n=1
    if (n <= 1) {
        return n;
    }

    // 2. REKURENCJA: funkcja wywołuje samą siebie dla dwóch mniejszych argumentów
    return fibonacciRekurencyjny(n - 1) + fibonacciRekurencyjny(n - 2);
}

int main() {
    int n = 7;
    // Wyświetlenie wyniku (0, 1, 1, 2, 3, 5, 8, 13...)
    cout << "Wyraz numer " << n << " to: " << fibonacciRekurencyjny(n) << endl;
    return 0;
}
```
