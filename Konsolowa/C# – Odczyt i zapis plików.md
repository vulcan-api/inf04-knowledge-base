# C# – Odczyt i zapis plików

## 1. Przestrzenie nazw potrzebne do odczytu i zapisu plików

```csharp
using System;      // wejście/wyjście
using System.IO;   // obsługa plików
```

---

## 2. Tryby otwarcia plików

### FileMode

* `FileMode.Open` – otwarcie istniejącego pliku
* `FileMode.Create` – utworzenie nowego pliku (nadpisuje jeśli istnieje)
* `FileMode.Append` – dopisywanie na koniec pliku
* `FileMode.Truncate` – usuwa zawartość pliku
* `FileMode.OpenOrCreate` – otwiera lub tworzy plik

### FileAccess

* `FileAccess.Read` – odczyt
* `FileAccess.Write` – zapis
* `FileAccess.ReadWrite` – odczyt i zapis

---

## 3. Operacje na pozycjach w pliku

*(raczej nie aż tak ważne)*

* `Seek()` – ustawia pozycję w pliku
  np. `stream.Seek(0, SeekOrigin.Begin);` – od początku pliku

* `Position` – zwraca lub ustawia aktualną pozycję
  np. `Console.WriteLine(stream.Position);`

---

## 4. Co możesz zrobić z plikiem?

### `StreamReader` – tylko odczyt

#### Sprawdzenie czy plik istnieje

```csharp
class Program {
    static void Main() {
        if (!File.Exists("dane.txt")) {
            Console.WriteLine("Plik nie istnieje");
        }
    }
}
```

---

#### Odczyt jednej linii z pliku

```csharp
class Program {
    static void Main() {
        StreamReader plik = new StreamReader("dane.txt");
        string linia = plik.ReadLine();
        Console.WriteLine(linia);
        plik.Close();
    }
}
```

---

#### Odczyt całego pliku

```csharp
class Program {
    static void Main() {
        StreamReader plik = new StreamReader("dane.txt");
        string linia;

        while ((linia = plik.ReadLine()) != null) {
            Console.WriteLine(linia);
        }

        plik.Close();
    }
}
```

### Co robi `ReadLine()`?

`ReadLine()` czyta **CAŁĄ linię tekstu z pliku** i zapisuje ją do zmiennej.
Czyta spacje i kończy czytanie na znaku nowej linii.

---

### `StreamWriter` – tylko zapis

#### Zapis danych do pliku

```csharp
class Program {
    static void Main() {
        StreamWriter plik = new StreamWriter("dane.txt");
        plik.WriteLine("Hello world");
        plik.WriteLine(123);
        plik.Close();
    }
}
```

---

#### Dopisywanie danych do pliku

```csharp
class Program {
    static void Main() {
        StreamWriter plik = new StreamWriter("dane.txt", true);
        plik.WriteLine("Nowa linia");
        plik.Close();
    }
}
```

`true` – dopisuje dane na końcu pliku

---

### `FileStream` – odczyt i zapis jednocześnie

#### Prosty przykład

```csharp
class Program {
    static void Main() {
        FileStream plik = new FileStream("dane.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        StreamWriter writer = new StreamWriter(plik);
        StreamReader reader = new StreamReader(plik);

        writer.WriteLine("Nowe dane");
        writer.Flush(); //gwarantuje to że dane na pewno trafiły do celu

        plik.Seek(0, SeekOrigin.Begin);
        string txt;
        while ((txt = reader.ReadLine()) != null) {
            Console.WriteLine(txt);
        }

        plik.Close();
    }
}
```

---

## 5. Szybki odczyt całego pliku

### `File.ReadAllLines()`

Czyta **CAŁY plik naraz** i zwraca tablicę stringów

```csharp
class Program {
    static void Main() {
        string[] linie = File.ReadAllLines("dane.txt");

        foreach (string linia in linie) {
            Console.WriteLine(linia);
        }
    }
}
```

---

### `File.ReadAllText()`

Czyta **CAŁY plik jako jeden string**

```csharp
class Program {
    static void Main() {
        string tekst = File.ReadAllText("dane.txt");
        Console.WriteLine(tekst);
    }
}
```

---

## 6. Tryb binarny (raczej się nie przyda)

### Zapis binarny

```csharp
class Program {
    static void Main() {
        int x = 123;
        BinaryWriter plik = new BinaryWriter(File.Open("dane.bin", FileMode.Create));
        plik.Write(x);
        plik.Close();
    }
}
```

### Odczyt binarny

```csharp
class Program {
    static void Main() {
        BinaryReader plik = new BinaryReader(File.Open("dane.bin", FileMode.Open));
        int x = plik.ReadInt32();
        plik.Close();

        Console.WriteLine(x);
    }
}
```

---

## 7. Przykład programu – odczyt do tablicy i wypisanie

```csharp
using System;
using System.IO;

class Program {
    static void Main() {
        StreamReader plik = new StreamReader("dane.txt");

        string[] tablica = new string[100];
        int i = 0;

        while ((tablica[i] = plik.ReadLine()) != null) {
            i++;
        }

        plik.Close();

        for (int j = 0; j < i; j++) {
            Console.WriteLine(tablica[j]);
        }
    }
}
```
