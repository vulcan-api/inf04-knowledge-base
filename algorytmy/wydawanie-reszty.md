# Wydawanie Reszty (Zachłanny)

Powrót na start -> [Start](./root.md)

Algorytm ten ma za zadanie wypłacić określoną kwotę przy użyciu jak najmniejszej liczby monet lub banknotów.

----------

## 1. Zasada Działania (Logika)

Algorytm jest **zachłanny**, co oznacza, że w każdym kroku wybiera największy możliwy nominał, który nie przekracza kwoty pozostałej do wydania.

**Kroki algorytmu:**

1.  Przygotuj listę dostępnych nominałów (posortowaną malejąco).
    
2.  Dopóki reszta do wydania jest większa od zera:
    
    -   Znajdź największy nominał mniejszy lub równy pozostałej reszcie.
        
    -   Wydaj ten nominał (odejmij go od reszty).
        
    -   Powtarzaj krok dla tej samej lub mniejszej monety.
        

----------

## 2. Implementacja w C#

Wersja spotykana na egzaminie – operuje na liczbach całkowitych (np. groszach), aby uniknąć problemów z precyzją typu `double`.

C#

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void WydajReszte(int reszta)
    {
        // Dostępne nominały w groszach, posortowane od największego
        int[] nominaly = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        
        Console.WriteLine($"Wydawanie reszty dla kwoty: {reszta / 100.0} zł");

        int i = 0; // Indeks aktualnie rozważanego nominału
        
        while (reszta > 0)
        {
            // Sprawdzamy, ile razy dany nominał mieści się w reszcie
            if (reszta >= nominaly[i])
            {
                int liczbaMonet = reszta / nominaly[i];
                Console.WriteLine($"Nominał {nominaly[i] / 100.0} zł: {liczbaMonet} szt.");
                
                // Aktualizujemy pozostałą resztę (modulo)
                reszta = reszta % nominaly[i];
            }
            
            // Przechodzimy do mniejszego nominału
            i++;
        }
    }

    static void Main()
    {
        // Przykład: chcemy wydać 18 zł i 47 gr
        int kwotaWGroszach = 1847; 
        WydajReszte(kwotaWGroszach);
    }
}

```

----------

## 3. UWAGI
    
-   **Problem precyzji:** Na egzaminie zawsze **przeliczaj złotówki na grosze** (`kwota * 100`). Używanie typu `float` lub `double` przy odejmowaniu pieniędzy może prowadzić do błędów zaokrągleń (np. zamiast 0 zostanie `0.00000001`), co zepsuje pętlę `while`.
    
-   **Ograniczenia:** Algorytm zachłanny działa idealnie dla polskiego systemu walutowego, ale w niektórych fikcyjnych systemach (np. nominały 1, 3, 4) może nie wydać reszty najmniejszą liczbą monet (wtedy stosuje się programowanie dynamiczne).


### Trzeba przeczytać treść zadania i zdecydować, który wybrać, ale na 99% będzie chodzić o zachłanny. Dynamiczny jest na wszelki wypadek!!!
---
# Wydawanie Reszty (Dynamiczny)

Programowanie dynamiczne polega na dzieleniu problemu na mniejsze podproblemy i zapamiętywaniu ich wyników.

## 1. Logika działania

Tworzymy tablicę `minMonety`, gdzie indeks to kwota, którą chcemy wydać, a wartość to minimalna liczba monet potrzebna do jej wydania.

1.  Dla kwoty $0$ potrzebujemy $0$ monet.
    
2.  Dla każdej kolejnej kwoty ($1, 2, 3 \dots$ aż do naszej reszty) sprawdzamy wszystkie dostępne nominały.
    
3.  Jeśli dany nominał jest mniejszy od aktualnej kwoty, sprawdzamy, czy użycie go (czyli $1 + \text{wynik dla kwoty pomniejszonej o ten nominał}$) daje lepszy wynik niż to, co już mamy zapisane.
    

----------

## 2. Implementacja w C#

Ten kod jest bardziej zaawansowany niż wersja zachłanna.

C#

```csharp
using System;

class Program
{
    static int WydajReszteDynamicznie(int[] nominaly, int kwota)
    {
        // Tablica do przechowywania minimalnej liczby monet dla każdej kwoty od 0 do kwota
        // Ustawiamy rozmiar na kwota + 1
        int[] minMonety = new int[kwota + 1];

        // Wypełniamy tablicę dużą wartością (nieskończonością), 
        // bo szukamy minimum
        for (int i = 1; i <= kwota; i++) 
            minMonety[i] = int.MaxValue - 1;

        // Dla kwoty 0 potrzebujemy 0 monet
        minMonety[0] = 0;

        // Obliczamy wyniki dla wszystkich kwot od 1 do docelowej
        for (int i = 1; i <= kwota; i++)
        {
            // Sprawdzamy każdy dostępny nominał
            foreach (int moneta in nominaly)
            {
                if (i >= moneta)
                {
                    // Kluczowe równanie: sprawdzamy czy dodanie tej monety 
                    // poprawia nasz dotychczasowy wynik dla kwoty 'i'
                    minMonety[i] = Math.Min(minMonety[i], 1 + minMonety[i - moneta]);
                }
            }
        }

        return minMonety[kwota];
    }

    static void Main()
    {
        int[] nominaly = { 1, 3, 4 };
        int reszta = 6;

        int wynik = WydajReszteDynamicznie(nominaly, reszta);
        
        Console.WriteLine($"Minimalna liczba monet dla kwoty {reszta} to: {wynik}");
        // W systemie {1, 3, 4} dla kwoty 6 wynik to 2 (dwie monety po 3)
    }
}
```
---

## 4. Implementacja w C++ (Algorytm Zachłanny)

W C++ kluczowe jest użycie operatora `%` (modulo) do szybkiego obliczania pozostałej reszty oraz pętli `for` do przechodzenia przez tablicę nominałów.

C++

```cpp
#include <iostream>
using namespace std;

/**
 * Wydawanie reszty algorytmem zachłannym.
 * @param reszta - kwota do wydania w groszach
 */
void wydajReszteZachlannie(int reszta) {
    // Nominały posortowane malejąco (w groszach)
    int nominaly[] = {500, 200, 100, 50, 20, 10, 5, 2, 1};
    // sizeof(nominaly)/sizeof(int) - obliczanie liczby elementów w tablicy
    int n = sizeof(nominaly) / sizeof(int);

    cout << "Reszta w monetach: " << endl;

    for (int i = 0; i < n; i++) {
        // Sprawdzamy, czy dany nominał jest mniejszy lub równy pozostałej reszcie
        if (reszta >= nominaly[i]) {
            // Obliczamy ile sztuk danego nominału wydać
            int liczbaMonet = reszta / nominaly[i];
            
            // Wypisujemy wynik (dzielimy przez 100.0, aby pokazać zł)
            cout << "Nominal " << nominaly[i] / 100.0 << " zl: " << liczbaMonet << " szt." << endl;
            
            // Obliczamy pozostałą kwotę za pomocą modulo
            reszta %= nominaly[i];
        }
    }
}

int main() {
    // Przykład: 18.47 zł zamieniamy na 1847 groszy
    int kwotaWGroszach = 1847;
    wydajReszteZachlannie(kwotaWGroszach);

    return 0;
}

```

----------

## 5. Implementacja w C++ (Algorytm Dynamiczny)

Wersja dynamiczna w C++ często korzysta z wartości `2147483647` (maksymalny `int`) jako reprezentacji nieskończoności.

C++

```cpp
#include <iostream>
#include <vector>
#include <algorithm> // Dla funkcji min()

using namespace std;

/**
 * Wyznacza minimalną liczbę monet potrzebną do wydania kwoty.
 */
int wydajReszteDynamicznie(int nominaly[], int n, int kwota) {
    // Tworzymy dynamiczną tablicę (vector) o rozmiarze kwota + 1
    // minMonety[i] będzie przechowywać najmniejszą liczbę monet dla kwoty 'i'
    vector<int> minMonety(kwota + 1, 1000000); // 1000000 zastępuje nieskończoność

    // Dla kwoty 0 potrzeba 0 monet
    minMonety[0] = 0;

    // Przechodzimy przez wszystkie kwoty od 1 do celu
    for (int i = 1; i <= kwota; i++) {
        // Dla każdej kwoty sprawdzamy wszystkie dostępne nominały
        for (int j = 0; j < n; j++) {
            if (i >= nominaly[j]) {
                // Relacja rekurencyjna:
                // sprawdzamy, czy lepiej zostać przy obecnym wyniku, 
                // czy wziąć 1 monetę aktualną + wynik dla reszty kwoty
                minMonety[i] = min(minMonety[i], 1 + minMonety[i - nominaly[j]]);
            }
        }
    }

    return minMonety[kwota];
}

int main() {
    int nominaly[] = {1, 3, 4};
    int n = sizeof(nominaly) / sizeof(int);
    int reszta = 6;

    int wynik = wydajReszteDynamicznie(nominaly, n, reszta);

    cout << "Minimalna liczba monet dla kwoty " << reszta << " to: " << wynik << endl;

    return 0;
}
```
