# C++ – Odczyt i zapis plików

## 1. Biblioteki i przestrzeń nazw potrzebne do odczytu i zapisu plików

```cpp
#include <iostream> // wejście/wyjście
#include <fstream>  // obsługa plików
#include <string>   // string
```

---

## 2. Tryby otwarcia plików

* `ios::in` – odczyt
* `ios::out` – zapis
* `ios::app` – dopisywanie na koniec
* `ios::trunc` – usuwa zawartość pliku
* `ios::binary` – tryb binarny

---

## 3. Operacje na pozycjach w pliku

*(raczej nie aż tak ważne)*

* `seekg()` – ustawia miejsce, z którego program będzie czytał plik
  np. `plik.seekg(0);` – czytaj od początku pliku

* `seekp()` – ustawia pozycję zapisu
  np. `plik.seekp(0);` – pisz od początku pliku

* `tellg()` – zwraca pozycję odczytu
  np. `cout << plik.tellg();`

* `tellp()` – zwraca pozycję zapisu
  np. `cout << plik.tellp();`

---

## 4. Co możesz zrobić z plikiem?

### `ifstream` – tylko odczyt

#### Sprawdzenie czy plik istnieje

```cpp
int main() {
    ifstream plik("dane.txt");
    if (!plik) {
        cout << "Plik nie istnieje";
    }
}
```

#### Odczyt jednej linii z pliku

#### I sposób:
```cpp
int main() {
    ifstream plik("dane.txt");
    string linia;
    getline(plik, linia);
    cout << linia;
    plik.close();
}
```

#### 2 sposób:
```cpp
int main() {
    ifstream plik("dane.txt");
    string tekst;
    plik >> tekst;
    cout << tekst;
    plik.close();
}
```

#### Odczyt całego pliku

```cpp
int main() {
    ifstream plik("dane.txt");
    string linia;

    while (getline(plik, linia)) {
        cout << linia << endl;
    }

    plik.close();
}
```

### Co robi `getline`?

`getline` czyta **CAŁĄ linię tekstu z pliku** i zapisuje ją do zmiennej.
Czyta spacje (w przeciwieństwie do `>>`).

**W skrócie:** `getline` czyta wszystko do końca linii, razem ze spacjami.

---

### `ofstream` – tylko zapis

#### Zapis danych do pliku

```cpp
int main() {
    ofstream plik("dane.txt");
    plik << "Hello world" << endl;
    plik << 123 << endl;
    plik.close();
}
```

#### Dopisywanie danych do pliku

```cpp
int main() {
    ofstream plik("dane.txt", ios::app);
    plik << "Nowa linia" << endl;
    plik.close();
}
```

`ios::app` – dopisuje dane na końcu pliku

---

### `fstream` – odczyt i zapis jednocześnie

#### Prosty przykład

```cpp
int main() {
    fstream plik("dane.txt", ios::in | ios::out);

    plik << "Nowe dane" << endl;

    plik.seekg(0);
    string txt;
    while (getline(plik, txt)) {
        cout << txt << endl;
    }

    plik.close();
    return 0;
}
```

#### Odczyt + zapis + dopisywanie

```cpp
int main() {
    fstream plik("dane.txt", ios::in | ios::out | ios::app);

    plik << "Nowe dane" << endl;

    plik.seekg(0);
    string txt;
    while (getline(plik, txt)) {
        cout << txt << endl;
    }

    plik.close();
    return 0;
}
```

---

## 5. Tryb binarny (raczej się nie przyda)

### Zapis binarny

```cpp
int main() {
    int x = 123;

    ofstream plik("dane.bin", ios::binary);
    plik.write((char*)&x, sizeof(x));
    plik.close();

    return 0;
}
```

### Odczyt binarny

```cpp
int main() {
    int x;

    ifstream plik("dane.bin", ios::binary);
    plik.read((char*)&x, sizeof(x));
    plik.close();

    cout << x;
    return 0;
}
```


---

## 6. Przykład programu – odczyt do tablicy i wypisanie


```cpp
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main() {
    ifstream plik("dane.txt");

    string tablica[100];
    int i = 0;

    while (getline(plik, tablica[i])) {
        i++;
    }

    plik.close();

    for (int j = 0; j < i; j++) {
        cout << tablica[j] << endl;
    }

    return 0;
}
```
