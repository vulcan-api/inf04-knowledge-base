# Struktury danych – C++ i C#

## C++: Obsługa struktur danych

```cpp
#include <vector>
#include <queue>
#include <stack>

using namespace std;

// TABLICA: Stały rozmiar, szybki dostęp
int tab[5] = {1, 2, 3};

// LISTA (Vector): Dynamiczny rozmiar, dodawanie na końcu
vector<int> v;
v.push_back(10); // Dodanie elementu

// KOLEJKA (FIFO): First-In First-Out
queue<int> q;
q.push(1); // Dodanie (enqueue w c#)
q.pop();   // Usunięcie najstarszego (dequeue w c#)

// STOS (LIFO): Last-In First-Out
stack<int> s;
s.push(1); // Dodanie (push)
s.pop();   // Usunięcie najnowszego (pop)
```

---

## C#: Obsługa struktur danych

```csharp
using System.Collections.Generic;

// TABLICA: Stały rozmiar, szybki dostęp
int[] tab = new int[5] {1, 2, 3, 0, 0};

// LISTA: Dynamiczna kolekcja elementów
List<int> list = new List<int>();
list.Add(10); // Dodanie elementu

// KOLEJKA (FIFO): First-In First-Out
Queue<int> q = new Queue<int>();
q.Enqueue(1); // Dodanie ( wkolejwowywanie )
q.Dequeue();  // Pobranie i usunięcie ( wykolejkowywanie )

// STOS (LIFO): Last-In First-Out
Stack<int> s = new Stack<int>();
s.Push(1);  // Dodanie
s.Pop();    // Pobranie i usunięcie
```

---

## C++: Tablice wielowymiarowe i wskaźniki

```cpp
// 1. ZWYKŁA (STATYCZNA) TABLICA 2D
int tab2D[2][3] = {{1,2,3}, {4,5,6}};
tab2D[0][0] = 7; // Dodawanie/modyfikacja elementu

// 2. WSKAŹNIK NA TABLICĘ STATYCZNĄ
int (*ptr)[3] = tab2D; // Wskaźnik na wiersz 3-elementowy

// 3. DYNAMICZNA TABLICA 1D (Wskaźnik)
int* d1D = new int[5];
d1D[0] = 10;
delete[] d1D; // Pamiętaj o zwolnieniu pamieci!

// 4. DYNAMICZNA TABLICA 2D (Wskaźnik do wskaźnika)
int** d2D = new int*[2]; // Tablica wskaźników na wiersze
d2D[0] = new int[3];    // Alokacja konkretnego wiersza
d2D[0][1] = 5;          // Dodawanie elementu
```

---

## C#: Tablice wielowymiarowe

```csharp
// 1. TABLICA PROSTOKĄTNA (Wielowymiarowa)
int[,] tab2D = new int[2, 3];
tab2D[0, 0] = 7; // Dodawanie/modyfikacja elementu

// 2. TABLICA POSZARPANA (Jagged Array)
int[][] jagged = new int[2][];
jagged[0] = new int[3]; // Inicjalizacja pod-tablicy
jagged[0][0] = 5;       // Dodawanie elementu

// 3. WSKAŹNIKI (wymagają unsafe – rzadkie na egzaminie)
// unsafe { int* p = &tab1D[0]; }
```

---

## C++: Liczby losowe i wypełnianie

```cpp
#include <iostream>
#include <cstdlib>
#include <ctime>
#include <vector>

// Inicjalizacja ziarna czasu (RAZ na początku programu)
srand(time(NULL));

// 1. Tablica 1D
int tab[10];
for(int i = 0; i < 10; i++) {
    tab[i] = rand() % 100 + 1; // 1–100
}

// 2. Tablica 2D
int tab2D[3][3];
for(int i = 0; i < 3; i++) {
    for(int j = 0; j < 3; j++) {
        tab2D[i][j] = rand() % 10; // 0–9
    }
}

// 3. Wektor
std::vector<int> v;
for(int i = 0; i < 5; i++) {
    v.push_back(rand() % 50);
}
```

---

## C#: Liczby losowe i wypełnianie

```csharp
using System;
using System.Collections.Generic;

// Inicjalizacja obiektu Random (RAZ)
Random rand = new Random();

// 1. Tablica 1D
int[] tab = new int[10];
for(int i = 0; i < tab.Length; i++) {
    tab[i] = rand.Next(1, 101); // 1–100
}

// 2. Tablica 2D
int[,] tab2D = new int[3, 3];
for(int i = 0; i < tab2D.GetLength(0); i++) {
    for(int j = 0; j < tab2D.GetLength(1); j++) {
        tab2D[i, j] = rand.Next(0, 10);
    }
}

// 3. Lista
List<int> list = new List<int>();
for(int i = 0; i < 5; i++) {
    list.Add(rand.Next(50)); // 0–49
}
```

