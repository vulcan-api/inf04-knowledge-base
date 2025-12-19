# Python – Odczyt i zapis plików

## 1. Podstawy – otwieranie plików

W Pythonie **nie trzeba importować dodatkowych bibliotek** do pracy z plikami.

Podstawowa funkcja:

```python
open(nazwa_pliku, tryb)
```

---

## 2. Tryby otwarcia plików

* `"r"` – odczyt (read) **(plik musi istnieć)**
* `"w"` – zapis (write) **(usuwa zawartość pliku lub tworzy nowy)**
* `"a"` – dopisywanie na koniec (append)
* `"r+"` – odczyt i zapis
* `"b"` – tryb binarny (np. `"rb"`, `"wb"`)

Tryby można łączyć, np. `"rb"`, `"w+"`

---

## 3. Operacje na pozycjach w pliku

*(raczej nie aż tak ważne na egzamin)*

* `seek(x)` – ustawia pozycję w pliku

```python
plik.seek(0)   # początek pliku
```

* `tell()` – zwraca aktualną pozycję

```python
print(plik.tell())
```

---

## 3a. Kodowanie znaków (encoding)

W niektórych językach programowania (np. **Python**) można określić **kodowanie znaków** podczas otwierania pliku.

Najczęściej używane kodowanie to **UTF-8**.

### Po co ustawiać `encoding="utf-8"`?

- poprawna obsługa polskich znaków (ą, ę, ł, ś, ć, ń)
- brak błędów przy odczycie/zapisie tekstu
- zgodność z plikami egzaminacyjnymi

### Przykład – odczyt pliku z kodowaniem UTF-8

```python
plik = open("dane.txt", "r", encoding="utf-8")
tekst = plik.read()
print(tekst)
plik.close()
```

### Przykład – zapis pliku z kodowaniem UTF-8

```python
plik = open("dane.txt", "w", encoding="utf-8")
plik.write("Zażółć gęślą jaźń")
plik.close()
```

**Na egzaminie INF.04 warto dopisywać** `encoding="utf-8"`, zwłaszcza gdy w pliku są polskie znaki.

---

## 4. Co możesz zrobić z plikiem?

## ODCZYT – tryb `"r"`

### Sprawdzenie czy plik istnieje

```python
try:
    plik = open("dane.txt", "r")
except FileNotFoundError:
    print("Plik nie istnieje")
```

---

### Odczyt jednej linii z pliku

#### I sposób – `readline()`

```python
plik = open("dane.txt", "r")
linia = plik.readline()
print(linia)
plik.close()
```

---

#### II sposób – `read()`

```python
plik = open("dane.txt", "r")
tekst = plik.read()
print(tekst)
plik.close()
```

---

### Odczyt całego pliku linia po linii

```python
plik = open("dane.txt", "r")

for linia in plik:
    print(linia)

plik.close()
```

---

### Co robi `readline()`?

`readline()` czyta **jedną całą linię tekstu**, razem ze spacjami i znakiem końca linii `\n`.

**W skrócie:** czyta całą linię.

---

## ZAPIS – tryb `"w"`

### Zapis danych do pliku

```python
plik = open("dane.txt", "w")
plik.write("Hello world\n")
plik.write("123\n")
plik.close()
```

Tryb `"w"` **usuwa całą zawartość pliku**

---

### Dopisywanie danych do pliku – `"a"`

```python
plik = open("dane.txt", "a")
plik.write("Nowa linia\n")
plik.close()
```

`"a"` – **dopisywanie na końcu pliku**

---

## ODCZYT + ZAPIS – tryb `"r+"`

```python
plik = open("dane.txt", "r+")

plik.write("Nowe dane\n")

plik.seek(0)
for linia in plik:
    print(linia)

plik.close()
```

---

## 5. Tryb binarny (raczej się nie przyda)

### Zapis binarny

```python
x = 123

plik = open("dane.bin", "wb")
plik.write(x.to_bytes(4, "little"))
plik.close()
```

---

### Odczyt binarny

```python
plik = open("dane.bin", "rb")
x = int.from_bytes(plik.read(4), "little")
plik.close()

print(x)
```

---

## 6. Przykład programu – odczyt do listy i wypisanie

```python
plik = open("dane.txt", "r")

tablica = []

for linia in plik:
    tablica.append(linia.strip())

plik.close()

for element in tablica:
    print(element)
```

---