# Wyszukiwanie Binarne (Binary Search)

Powrót na start -> [Start](./root.md)

Wyszukiwanie binarne działa na zasadzie "dziel i zwyciężaj". Zamiast sprawdzać każdy element po kolei, za każdym razem odrzucamy połowę tablicy, w której na pewno nie ma szukanego elementu.

----------

## 1. Jak to działa? (Logika)

1.  Sprawdź środkowy element tablicy.
    
2.  Jeśli środkowy element to szukana wartość – **koniec**.
    
3.  Jeśli szukana wartość jest **mniejsza** od środkowego – szukaj dalej tylko w lewej połowie.
    
4.  Jeśli szukana wartość jest **większa** od środkowego – szukaj dalej tylko w prawej połowie.
    
5.  Powtarzaj kroki, aż znajdziesz element lub obszar poszukiwań stanie się pusty.
    

----------

## 2. Implementacja w C# (Iteracyjna)


C#

```csharp
using System;

class Program
{
    // Metoda zwraca indeks elementu lub -1 jeśli nie znaleziono
    static int BinarySearch(int[] tablica, int szukana)
    {
        int lewy = 0;
        int prawy = tablica.Length - 1;

        while (lewy <= prawy)
        {
            // Wyznaczamy środek (bezpieczny sposób na uniknięcie overflow)
            int srodek = lewy + (prawy - lewy) / 2;

            // 1. Sprawdzamy czy środek to nasz szukany element
            if (tablica[srodek] == szukana)
                return srodek;

            // 2. Jeśli szukana jest większa, odrzucamy lewą połowę
            if (tablica[srodek] < szukana)
                lewy = srodek + 1;
            
            // 3. Jeśli szukana jest mniejsza, odrzucamy prawą połowę
            else
                prawy = srodek - 1;
        }

        return -1; // Elementu nie ma w tablicy
    }

    static void Main()
    {
        // TABLICA MUSI BYĆ POSORTOWANA!
        int[] liczby = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
        int szukana = 23;

        int wynik = BinarySearch(liczby, szukana);

        if (wynik != -1)
            Console.WriteLine($"Element znaleziony pod indeksem: {wynik}");
        else
            Console.WriteLine("Nie znaleziono elementu.");
    }
}

```

----------




----------

## 4. Wskazówki egzaminacyjne (INF.04)

-   Jeśli w zadaniu masz podaną bardzo długą tablicę i polecenie "znajdź element najszybciej jak się da", zawsze wybieraj wyszukiwanie binarne.
    
-   Pamiętaj o warunku pętli `while (lewy <= prawy)`. Jeśli zapomnisz o `=`, algorytm może nie znaleźć elementu, który jest na samym brzegu.
    
-   Uważaj na obliczanie środka. Standardowe `(lewy + prawy) / 2` jest poprawne, ale w bardzo dużych tablicach może przekroczyć zakres typu `int` (dlatego  pisze się `lewy + (prawy - lewy) / 2`).

-   **Wymóg:**  Dane wejściowe muszą być **posortowane**. Jeśli nie są – najpierw trzeba użyć algorytmu sortowania.

## 5. Implementacja w C++ (Iteracyjna)

W **C++** musimy samodzielnie obliczyć rozmiar tablicy przed przekazaniem jej do funkcji, ponieważ wewnątrz funkcji tablica jest traktowana jedynie jako wskaźnik na pierwszy element.

C++

```cpp
#include <iostream>
using namespace std;

/**
 * Funkcja realizująca wyszukiwanie binarne.
 * tablica[] - musi być uprzednio posortowana!
 * n - liczba elementów w tablicy
 * szukana - wartość, której szukamy
 */
int wyszukajBinarnie(int tablica[], int n, int szukana) {
    int lewy = 0;          // Indeks początku (pierwszy element)
    int prawy = n - 1;     // Indeks końca (ostatni element)

    while (lewy <= prawy) {
        // Obliczanie środka - ten zapis chroni przed błędem overflow dla ogromnych tablic
        int srodek = lewy + (prawy - lewy) / 2;

        // 1. Sukces: szukana wartość jest na środku
        if (tablica[srodek] == szukana) {
            return srodek; 
        }

        // 2. Jeśli szukana jest większa: ignorujemy lewą stronę i środek
        if (tablica[srodek] < szukana) {
            lewy = srodek + 1;
        } 
        // 3. Jeśli szukana jest mniejsza: ignorujemy prawą stronę i środek
        else {
            prawy = srodek - 1;
        }
    }

    // Jeśli pętla się zakończy: elementu nie ma w tablicy
    return -1;
}

int main() {
    // TABLICA MUSI BYĆ POSORTOWANA!
    int liczby[] = {2, 5, 8, 12, 16, 23, 38, 56, 72, 91};
    
    // sizeof(liczby) -> rozmiar tablicy w bajtach
    // sizeof(liczby[0]) -> rozmiar pojedynczej komórki int
    // Wynik dzielenia to liczba elementów (n)
    int n = sizeof(liczby) / sizeof(liczby[0]); 
    int szukana = 23;

    // Przekazujemy tablicę, jej rozmiar oraz szukaną wartość
    int wynik = wyszukajBinarnie(liczby, n, szukana);

    // Wyświetlenie wyniku (cout to odpowiednik Console.WriteLine)
    if (wynik != -1) {
        cout << "Element znaleziony pod indeksem: " << wynik << endl;
    } else {
        cout << "Nie znaleziono elementu." << endl;
    }

    return 0;
}
```