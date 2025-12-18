# Wyszukiwanie Binarne (Binary Search)

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
    