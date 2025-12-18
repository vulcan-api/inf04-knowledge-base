# Wyszukiwanie Liniowe (Linear Search)

Wyszukiwanie liniowe to najprostszy algorytm wyszukiwania. Polega na przeglądaniu elementów kolekcji jeden po drugim, aż znajdziemy szukaną wartość lub dotrzemy do końca listy.

  

---

  

## 1. Jak to działa? 

1. Algorytm startuje od pierwszego elementu tablicy (indeks 0).

  

2. Porównuje bieżący element z wartością szukaną.

  

3. Jeśli są równe – sukces! Algorytm zwraca pozycję (indeks) elementu.

  

4. Jeśli nie są równe – przechodzi do następnego elementu.

  

5. Jeśli sprawdzi wszystkie elementy i nic nie znajdzie – zwraca informację o braku (zazwyczaj `-1`).

  

---

  

## 2. Implementacja w C#

Oto klasyczny przykład, który może pojawić się w zadaniu konsolowym na egzaminie:

  

```csharp
using System;

class Program
{

// Metoda realizująca wyszukiwanie liniowe
static int WyszukajLiniowo(int[] tablica, int szukana)
{

// Przechodzimy przez całą tablicę pętlą for
for (int i = 0; i < tablica.Length; i++)

{

// Jeśli element pod indeksem i jest tym, czego szukamy

if (tablica[i] == szukana)
{

return i; // Zwracamy indeks znalezionego elementu

}
}

return -1; // Zwracamy -1, jeśli elementu nie ma w tablicy

}

//Głowna metoda w której definiujemy parametry metody WyszukajLiniowo() i wyświetlamy wynik

static void Main()
{

int[] liczby = { 10, 22, 5, 18, 9, 30 };

int szukanaWartosc = 18;

int wynik = WyszukajLiniowo(liczby, szukanaWartosc);

//sprawdzamy czy znaleziono wynik
if (wynik != -1)

Console.WriteLine($"Znaleziono element pod indeksem: {wynik}");

else

Console.WriteLine("Nie znaleziono elementu w tablicy.");

}
}

  

```

  

---

  

## 3. Wyszukiwanie liniowe z wartownikiem 

Na INF.04 często pytają o wersję z wartownikiem. Pozwala ona uniknąć sprawdzania warunku `i < tablica.Length` w każdej iteracji pętli.

  

Logika wartownika:

  

1. Na końcu tablicy (lub w specjalnie powiększonym o 1 miejscu) wstawiamy szukaną wartość.

  

2. Dzięki temu mamy pewność, że pętla zawsze coś znajdzie.

  

3. Po wyjściu z pętli sprawdzamy tylko, czy znaleziony indeks to nasze dane, czy nasz "wartownik" na samym końcu.

  
```csharp
using System;

  

class Program

{

static int WyszukajZWartownikiem(int[] tablica, int n, int szukana)

{

// 1. Zapisujemy ostatni element tablicy, żeby go nie zgubić

int ostatni = tablica[n - 1];

  

// 2. Wstawiamy wartownika na ostatnie miejsce

tablica[n - 1] = szukana;

  

int i = 0;

// 3. Pętla bez warunku (i < n) - szukamy aż znajdziemy (wartownik gwarantuje stop)

while (tablica[i] != szukana)

{

i++;

}

  

// 4. Przywracamy oryginalny ostatni element

tablica[n - 1] = ostatni;

  

// 5. Sprawdzamy czy znaleźliśmy element przed końcem,

// lub czy ostatni element był tym szukanym

if (i < n - 1 || ostatni == szukana)

{

return i; // Sukces: znaleziono pod tym indeksem

}

  

return -1; // Porażka: znaleziono tylko wartownika

}

  

static void Main()

{

// Tablica o rozmiarze 6

int[] liczby = { 10, 22, 5, 18, 9, 30 };

int n = liczby.Length;

int szukana = 18;

  

int indeks = WyszukajZWartownikiem(liczby, n, szukana);

  

if (indeks != -1)

Console.WriteLine($"Znaleziono wartownika/element pod indeksem: {indeks}");

else

Console.WriteLine("Nie ma takiej liczby.");

}

}

  
```
---

