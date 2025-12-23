# Przeliczanie Systemów Liczbowych

Powrót na start -> [Start](./root.md)

Na egzaminie INF.04 może pojawić się potrzeba przeliczenia liczby między dowolnymi systemami (np. z binarnego na szesnastkowy)

### 1. Dziesiętny na Binarny 

Ten algorytm opiera się na cyklicznym dzieleniu liczby przez podstawę systemu i zbieraniu reszt.

C#

```csharp
using System;

class Program
{
    static string DziesietnyNaDowolny(int liczba, int podstawa)
    {
        // Obsługa przypadku, gdy liczba wejściowa to 0
        if (liczba == 0) return "0";
        
        string wynik = "";
        
        // Dopóki liczba jest większa od zera, wykonujemy dzielenie
        while (liczba > 0)
        {
            // Operator % zwraca resztę z dzielenia (to jest nasza cyfra w nowym systemie)
            int reszta = liczba % podstawa;
            
            // Doklejamy cyfrę na POCZĄTEK ciągu (reszty obliczane są od końca liczby)
            wynik = reszta.ToString() + wynik; 
            
            // Wykonujemy dzielenie całkowite, aby przejść do kolejnej pozycji
            liczba = liczba / podstawa;        
        }
        return wynik;
    }

    static void Main()
    {
        // Przykład: 13 / 2 = 6 r 1; 6 / 2 = 3 r 0; 3 / 2 = 1 r 1; 1 / 2 = 0 r 1 -> Wynik 1101
        Console.WriteLine("13 dziesiętnie na binarny: " + DziesietnyNaDowolny(13, 2)); 
    }
}

```

----------

### 2. Binarny na Dziesiętny

Każda cyfra binarna ma swoją wagę (kolejne potęgi liczby 2). Sumujemy te wagi tam, gdzie występuje '1'.

C#

```csharp
using System;

class Program
{
    static int BinarnyNaDziesietny(string binarny)
    {
        int wynik = 0;
        int waga = 1; // Reprezentuje 2 do potęgi 0 (czyli 1)

        // Przeszukujemy ciąg tekstowy od ostatniego znaku (prawa strona) do pierwszego
        for (int i = binarny.Length - 1; i >= 0; i--)
        {
            // Jeśli na danej pozycji jest '1', dodajemy aktualną wagę do wyniku
            if (binarny[i] == '1')
            {
                wynik += waga;
            }
            
            // Z każdym krokiem w lewo waga rośnie dwukrotnie (1, 2, 4, 8, 16...)
            waga *= 2; 
        }
        return wynik;
    }

    static void Main()
    {
        // Przykład: 1101 -> (1 * 1) + (0 * 2) + (1 * 4) + (1 * 8) = 13
        Console.WriteLine("1101 binarnie na dziesiętny: " + BinarnyNaDziesietny("1101"));
    }
}

```

----------

### 3. Dziesiętny na Szesnastkowy 
Podobny do binarnego, ale reszty powyżej 9 zamieniamy na litery A-F.

C#

```csharp
using System;

class Program
{
    static string DziesietnyNaHex(int liczba)
    {
        if (liczba == 0) return "0";
        
        // Tablica znaków używanych w systemie szesnastkowym
        string hexZnaki = "0123456789ABCDEF";
        string wynik = "";

        while (liczba > 0)
        {
            // Wyciągamy resztę z dzielenia przez 16 (zakres 0-15)
            int reszta = liczba % 16;
            
            // Używamy reszty jako indeksu, aby pobrać odpowiedni znak (np. 10 -> 'A')
            wynik = hexZnaki[reszta] + wynik;
            
            // Przechodzimy do kolejnej części liczby
            liczba /= 16;
        }
        return wynik;
    }

    static void Main()
    {
        // Przykład: 255 / 16 = 15 r 15 (F); 15 / 16 = 0 r 15 (F) -> Wynik FF
        Console.WriteLine("255 dziesiętnie na HEX: " + DziesietnyNaHex(255));
    }
}

```

----------

### 4. Szesnastkowy na Dziesiętny

Algorytm musi rozpoznać, czy znak jest cyfrą, czy literą (A-F), i przypisać mu wartość 10-15.

C#

```csharp
using System;

class Program
{
    static int HexNaDziesietny(string hex)
    {
        // Zamieniamy na wielkie litery, aby uniknąć problemów z 'a' zamiast 'A'
        hex = hex.ToUpper();
        int wynik = 0;
        int waga = 1; // 16 do potęgi 0

        for (int i = hex.Length - 1; i >= 0; i--)
        {
            char znak = hex[i];
            int wartosc = 0;

            // Sprawdzamy czy znak to cyfra 0-9
            if (znak >= '0' && znak <= '9')
                wartosc = znak - '0'; // Szybka zamiana char na int
            // Sprawdzamy czy znak to litera A-F
            else if (znak >= 'A' && znak <= 'F')
                wartosc = znak - 'A' + 10; // 'A' staje się 10, 'B' staje się 11 itd.

            // Mnożymy wartość znaku przez jego wagę (pozycję)
            wynik += wartosc * waga;
            
            // Waga rośnie szesnastokrotnie w każdym kroku (1, 16, 256...)
            waga *= 16;
        }
        return wynik;
    }

    static void Main()
    {
        // Przykład: 1A -> (10 * 1) + (1 * 16) = 26
        Console.WriteLine("1A w HEX na dziesiętny: " + HexNaDziesietny("1A"));
    }
}

```

----------

### 5. Binarny na Szesnastkowy

Najskuteczniejsza metoda egzaminacyjna to metoda "pomostowa": zamień binarny na dziesiętny, a potem dziesiętny na szesnastkowy.

C#

```csharp
using System;

class Program
{
    // Korzystamy z napisanych wcześniej funkcji jako narzędzi
    static string BinarnyNaHex(string binarny)
    {
        // KROK 1: Zamiana Binarny -> Dziesiętny
        int liczbaDziesietna = 0;
        int wagaBin = 1;
        for (int i = binarny.Length - 1; i >= 0; i--)
        {
            if (binarny[i] == '1') liczbaDziesietna += wagaBin;
            wagaBin *= 2;
        }

        // KROK 2: Zamiana Dziesiętny -> Szesnastkowy
        if (liczbaDziesietna == 0) return "0";
        string hexZnaki = "0123456789ABCDEF";
        string wynikHex = "";

        while (liczbaDziesietna > 0)
        {
            int reszta = liczbaDziesietna % 16;
            wynikHex = hexZnaki[reszta] + wynikHex;
            liczbaDziesietna /= 16;
        }

        return wynikHex;
    }

    static void Main()
    {
        // Przykład: 11111111 -> 255 dziesiętnie -> FF w HEX
        Console.WriteLine("11111111 binarnie na HEX: " + BinarnyNaHex("11111111"));
    }
}
```
---
### 2. Wbudowane metody do konwersji między systemami

-   **Dziesiętny ➔ Inny (jako string):**
    
    C#
    
    ```csharp
    string bin = Convert.ToString(255, 2);  // "11111111"
    string hex = Convert.ToString(255, 16); // "ff"
    
    ```
    
-   **Inny (string) ➔ Dziesiętny:**
    
    C#
    
    ```csharp
    int decFromBin = Convert.ToInt32("1101", 2);  // 13
    int decFromHex = Convert.ToInt32("FF", 16);   // 255
    
    ```
    

----------

**Wskazówka:** Pamiętaj o obsłudze wielkości liter (`ToUpper()`) przy systemie szesnastkowym, aby algorytm był odporny na błędy użytkownika.


## 6. Implementacja w C++

W C++ do pracy z tekstami używamy typu `string`. Ważną różnicą jest sposób budowania napisu – zamiast doklejać znaki na początek (co jest mało wydajne), często dodajemy je na koniec, a potem odwracamy cały ciąg funkcją `reverse`.

### 1. Dziesiętny na Binarny / Dowolny

C++

```cpp
#include <iostream>
#include <string>
#include <algorithm> // Dla funkcji reverse

using namespace std;

string dziesietnyNaDowolny(int liczba, int podstawa) {
    if (liczba == 0) return "0";
    
    string wynik = "";
    
    while (liczba > 0) {
        // Obliczamy resztę i zamieniamy ją na znak char
        int reszta = liczba % podstawa;
        wynik += to_string(reszta); // Dodajemy na koniec
        
        liczba /= podstawa;
    }
    
    // Ponieważ dodawaliśmy na koniec, musimy odwrócić wynik
    reverse(wynik.begin(), wynik.end());
    return wynik;
}

int main() {
    cout << "13 dziesietnie na binarny: " << dziesietnyNaDowolny(13, 2) << endl;
    return 0;
}

```

----------

### 2. Binarny na Dziesiętny

C++

```cpp
#include <iostream>
#include <string>

using namespace std;

int binarnyNaDziesietny(string binarny) {
    int wynik = 0;
    int waga = 1; // 2^0

    // Przechodzimy od końca napisu (prawa strona)
    for (int i = binarny.length() - 1; i >= 0; i--) {
        if (binarny[i] == '1') {
            wynik += waga;
        }
        waga *= 2; // Zwiększamy wagę dwukrotnie
    }
    return wynik;
}

int main() {
    cout << "1101 binarnie na dziesietny: " << binarnyNaDziesietny("1101") << endl;
    return 0;
}

```

----------

### 3. Dziesiętny na Szesnastkowy

C++

```cpp
#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

string dziesietnyNaHex(int liczba) {
    if (liczba == 0) return "0";
    
    string hexZnaki = "0123456789ABCDEF";
    string wynik = "";

    while (liczba > 0) {
        int reszta = liczba % 16;
        // Pobieramy znak z tablicy indeksów
        wynik += hexZnaki[reszta];
        liczba /= 16;
    }

    reverse(wynik.begin(), wynik.end());
    return wynik;
}

int main() {
    cout << "255 dziesietnie na HEX: " << dziesietnyNaHex(255) << endl;
    return 0;
}

```

----------

### 4. Szesnastkowy na Dziesiętny

C++

```cpp
#include <iostream>
#include <string>
#include <cctype> // Dla funkcji toupper

using namespace std;

int hexNaDziesietny(string hex) {
    int wynik = 0;
    int waga = 1;

    for (int i = hex.length() - 1; i >= 0; i--) {
        char znak = toupper(hex[i]); // Standaryzacja na wielkie litery
        int wartosc = 0;

        if (znak >= '0' && znak <= '9') {
            wartosc = znak - '0'; // Konwersja char '0'-'9' na int
        } else if (znak >= 'A' && znak <= 'F') {
            wartosc = znak - 'A' + 10; // 'A' = 10, 'B' = 11...
        }

        wynik += wartosc * waga;
        waga *= 16;
    }
    return wynik;
}

int main() {
    cout << "1A w HEX na dziesietny: " << hexNaDziesietny("1A") << endl;
    return 0;
}

```

----------

### 5. Wbudowane metody w C++ (Formatowanie)

W C++ możemy łatwo wypisać liczbę w systemie ósemkowym lub szesnastkowym bezpośrednio do strumienia `cout`:

C++

```cpp
#include <iostream>
#include <iomanip> // Dla manipulatorów

using namespace std;

int main() {
    int liczba = 255;

    // Wypisanie szesnastkowe
    cout << hex << liczba << endl; // ff

    // Wypisanie ósemkowe
    cout << oct << liczba << endl; // 377
    
    // Powrót do dziesiętnego
    cout << dec << liczba << endl; // 255

    return 0;
}

```

----------

### Wskazówki egzaminacyjne dla C++:

-   **Operacja `znak - '0'`:** To najszybszy sposób na zamianę cyfry zapisanej jako tekst na liczbę. Działa, ponieważ kody ASCII cyfr są ułożone po kolei.
    
-   **Nagłówek `<algorithm>`:** Pamiętaj o nim, jeśli chcesz użyć `reverse()`. Na egzaminie INF.04 często zapomina się o tej bibliotece.
    
-   **Typ `long long`:** Jeśli przeliczasz bardzo duże liczby (np. długie ciągi binarne), użyj `long long` zamiast `int`, aby uniknąć przepełnienia zakresu.