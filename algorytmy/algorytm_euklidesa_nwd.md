# Algorytm Euklidesa (NWD)

Algorytm Euklidesa służy do wyznaczania **Największego Wspólnego Dzielnika (NWD)** dwóch liczb całkowitych dodatnich. Jest to największa liczba naturalna, która dzieli obie liczby bez reszty.

----------

## 1. Logika działania

Na egzaminie INF.04 możesz spotkać dwie wersje tego algorytmu:

### Wersja z odejmowaniem (Klasyczna)
- Dopóki obie liczby są od siebie różne ($a \neq b$):
  - Odejmij mniejszą liczbę od większej.
- Gdy liczby staną się równe, ta wartość to szukane NWD.

### Wersja modulo (Zoptymalizowana)
- Dopóki druga liczba ($b$) jest różna od zera ($b \neq 0$):
  - Oblicz resztę z dzielenia $a$ przez $b$ ($r = a \pmod b$).
  - Przypisz $a = b$.
  - Przypisz $b = r$.
- Gdy $b$ wyniesie 0, wynik znajduje się w zmiennej $a$.



----------

## 2. Implementacja w C#

### Wersja przez odejmowanie

```c#
using System;

class Program
{
    static int NWDOdejmowanie(int a, int b)
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

    static void Main()
    {
        Console.WriteLine($"NWD(124, 36) przez odejmowanie: {NWDOdejmowanie(124, 36)}");
    }
}
```
### Wersja przez modulo:
```c#
using System;

class Program
{
    static int NWDModulo(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static void Main()
    {
        Console.WriteLine($"NWD(124, 36) przez modulo: {NWDModulo(124, 36)}");
    }
}
```

### Wskazówki
* Jeśli w poleceniu nie określono metody, używaj modulo – jest szybsza i bardziej odporna na duże różnice między liczbami.
* NWW: Najmniejszą Wspólną Wielokrotność obliczysz wzorem:  $NWW(a, b) = (a \cdot b) / NWD(a, b)$. 

* Pamiętaj: Algorytm działa poprawnie tylko dla liczb dodatnich.