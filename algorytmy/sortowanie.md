# ALGORYTMY SORTOWANIA



## JAK KORZYSTAĆ

1. **Żeby sortowanie działało musimy mieć tablice**
2. W kodach sortowania używana jest nazwa `rozmiar`.

     `rozmiar` NIE jest gotową zmienną  – jest to **umowna nazwa liczby elementów tablicy**

    Musisz:
    - wpisać w pętlach własną liczbę (w zależności jaki jest rozmiar twojej tablicy) , np. `5`, `10`
    - LUB podmienić `rozmiar` na zmienną, która określa rozmiar twojej tablicy

    Przykłady:
    - masz tablicę 5-elementową → wpisujesz `5`
    - masz tablicę `tab[20]` → wpisujesz `20`
    - masz tablicę `tab[liczba]` → wpisujesz `liczba`

2.  W C++ i C# kod sortowania wklejasz w `main()`

    wyjątek: **Quick Sort – funkcja NAD `main()`**
3. Chcesz sortować:
   - **rosnąco**  użyj `>`
   - **malejąco**  użyj `<`

---

## PRZYKŁADOWA TABLICA

### C++
```cpp
int tablica[] = {5, 2, 9, 1, 7};
````
W C++ gdy tablica jest dynamiczna, czyli użytkownik podaje jej rozmiar musimy zrobić: 
```cpp
int rozmiar;
cout << "Podaj rozmiar tablicy: ";
cin >> rozmiar;

int* tablica = new int[rozmiar];
```

### C#

```csharp
int[] tablica = {5, 2, 9, 1, 7};
```

### Python

```python
tablica = [5, 2, 9, 1, 7]
```

---

# ---------------------------------------------------

# 1. SORTOWANIE BĄBELKOWE



 **Co robi:** porównuje sąsiednie elementy i zamienia je miejscami
 
 **Gdzie wkleić:** do `main()`

## C++

```cpp
for (int i = 0; i < rozmiar - 1; i++) { // rozmiar = ilość elementów tablicy
    for (int j = 0; j < rozmiar - 1; j++) {
        if (tablica[j] < tablica[j + 1]) { // '<' malejąco, '>' rosnąco
            int pom = tablica[j];
            tablica[j] = tablica[j + 1];
            tablica[j + 1] = pom;
        }
    }
}

// Wypisanie tablicy
for (int i = 0; i < rozmiar; i++) {
    cout << tablica[i] << " ";
}
```

## C#

```csharp

for (int i = 0; i < rozmiar - 1; i++) { // rozmiar = ilość elementów tablicy
    for (int j = 0; j < rozmiar - 1; j++) {
        if (tablica[j] < tablica[j + 1]) { // '<' malejąco, '>' rosnąco
            int pom = tablica[j];
            tablica[j] = tablica[j + 1];
            tablica[j + 1] = pom;
        }
    }
}

// Wypisanie tablicy
for (int i = 0; i < rozmiar; i++) {
    Console.Write(tablica[i] + " ");
}
```

## Python

```python
for i in range(rozmiar - 1): # rozmiar = ilość elementów tablicy
    for j in range(rozmiar - 1):
        if tablica[j] < tablica[j + 1]:  # '<' malejąco, '>' rosnąco
            tablica[j], tablica[j + 1] = tablica[j + 1], tablica[j]
# Wypisanie tablicy
print(tablica)
```

---

# ===============================

# 2. SORTOWANIE ZACHŁANNE (PRZEZ WYBIERANIE)

# ===============================

 **Co robi:** szuka największego elementu i daje go na początek

 **Gdzie wkleić:** do `main()`

## C++

```cpp
for (int i = 0; i < rozmiar - 1; i++) { // rozmiar = ilość elementów tablicy
    int index = i;
    for (int j = i + 1; j < rozmiar; j++) {
        if (tablica[j] > tablica[index]) { // '<' rosnąco, '>' malejąco
            index = j;
        }
    }
    int pom = tablica[i];
    tablica[i] = tablica[index];
    tablica[index] = pom;
}

// Wypisanie tablicy
for (int i = 0; i < rozmiar; i++) {
    cout << tablica[i] << " ";
}
```

## C#

```csharp
for (int i = 0; i < rozmiar - 1; i++) { // rozmiar = ilość elementów tablicy
    int index = i;
    for (int j = i + 1; j < rozmiar; j++) {
        if (tablica[j] > tablica[index]) { // '<' rosnąco, '>' malejąco
            index = j;
        }
    }
    int pom = tablica[i];
    tablica[i] = tablica[index];
    tablica[index] = pom;
}
// Wypisanie tablicy
for (int i = 0; i < rozmiar; i++) {
    Console.Write(tablica[i] + " ");
}
```

## Python

```python
for i in range(rozmiar - 1): # rozmiar = ilość elementów tablicy
    index = i
    for j in range(i + 1, rozmiar):
        if tablica[j] > tablica[index]: # '<' rosnąco, '>' malejąco
            index = j
    tablica[i], tablica[index] = tablica[index], tablica[i]
# Wypisanie tablicy
print(tablica)
```

---

# ===============================

# 3. SORTOWANIE PRZEZ WSTAWIANIE

# ===============================

 **Co robi:** bierze element i wstawia go w dobre miejsce

 **Gdzie wkleić:** do `main()`

## C++

```cpp
for (int i = 1; i < rozmiar; i++) { // rozmiar = ilość elementów
    int klucz = tablica[i];
    int j = i - 1;

    while (j >= 0 && tablica[j] > klucz) { // '<' malejąco, '>' rosnąco
        tablica[j + 1] = tablica[j];
        j--;
    }
    tablica[j + 1] = klucz;
}

// Wypisanie tablicy
for (int i = 0; i < rozmiar; i++) {
    cout << tablica[i] << " ";
}
```

## C#

```csharp
for (int i = 1; i < rozmiar; i++) { // rozmiar = ilość elementów
    int klucz = tablica[i];
    int j = i - 1;

    while (j >= 0 && tablica[j] > klucz) { // '<' malejąco, '>' rosnąco
        tablica[j + 1] = tablica[j];
        j--;
    }
    tablica[j + 1] = klucz;
}
// Wypisanie tablicy
for (int i = 0; i < rozmiar; i++) {
    Console.Write(tablica[i] + " ");
}
```

## Python

```python
for i in range(1, rozmiar): # rozmiar = ilość elementów
    klucz = tablica[i]
    j = i - 1
    while j >= 0 and tablica[j] > klucz: # '<' malejąco, '>' rosnąco
        tablica[j + 1] = tablica[j]
        j -= 1
    tablica[j + 1] = klucz
# Wypisanie tablicy
print(tablica)
```

---

# ===============================

# 4. SORTOWANIE SZYBKIE (QUICK SORT – DZIEL I ZWYCIĘŻAJ)

# ===============================

🔹 **Gdzie wkleić:** funkcję **NAD main()**, wywołanie w `main()`

## C++

```cpp
void szybkieSortowanie(int tablica[], int lewy, int prawy) {
    int i = lewy;
    int j = prawy;
    int pivot = tablica[(lewy + prawy) / 2];

    while (i <= j) {
        while (tablica[i] < pivot) i++; // '<' rosnąco, '>' malejąco
        while (tablica[j] > pivot) j--; // znak '<' albo '>' odwrotnie niż wyżej

        if (i <= j) {
            int pom = tablica[i];
            tablica[i] = tablica[j];
            tablica[j] = pom;
            i++;
            j--;
        }
    }

    if (lewy < j) szybkieSortowanie(tablica, lewy, j);
    if (i < prawy) szybkieSortowanie(tablica, i, prawy);
}

// WYWOŁANIE W MAIN:
int main()
{
    int tablica[] = {5, 2, 9, 1, 7};
    szybkieSortowanie(tablica, 0, rozmiar - 1); // rozmiar = ilość elementów
    // Wypisanie tablicy
    for (int i = 0; i < rozmiar; i++) {
        cout << tablica[i] << " ";
    }
}
```

## C#

```csharp
static void SzybkieSortowanie(int[] tablica, int lewy, int prawy)
    {
        int i = lewy;
        int j = prawy;
        int pivot = tablica[(lewy + prawy) / 2];

        while (i <= j)
        {
            while (tablica[i] > pivot) i++;   // '<' rosnąco, '>' malejąco
            while (tablica[j] < pivot) j--;   // znak '<' albo '>' odwrotnie niż wyżej

            if (i <= j)
            {
                int pom = tablica[i];
                tablica[i] = tablica[j];
                tablica[j] = pom;
                i++;
                j--;
            }
        }

        if (lewy < j) SzybkieSortowanie(tablica, lewy, j);
        if (i < prawy) SzybkieSortowanie(tablica, i, prawy);
    }

// WYWOŁANIE W MAIN:
  static void Main()
    {
        int[] tablica = { 5, 2, 9, 1, 7 };

        SzybkieSortowanie(tablica, 0, rozmiar - 1); // rozmiar = ilość elementów

        // Wypisanie tablicy
        for (int i = 0; i < rozmiar; i++)
        {
            Console.Write(tablica[i] + " ");
        }
    }
```

## Python

```python
tablica = [5, 2, 9, 1, 7]

def szybkie_sortowanie(tablica, lewy, prawy):
    i = lewy
    j = prawy
    pivot = tablica[(lewy + prawy) // 2]

    while i <= j:
        while tablica[i] < pivot:   # '<' rosnąco, '>' malejąco
            i += 1
        while tablica[j] > pivot: # znak '<' albo '>' odwrotnie niż wyżej
            j -= 1

        if i <= j:
            tablica[i], tablica[j] = tablica[j], tablica[i]
            i += 1
            j -= 1

    if lewy < j:
        szybkie_sortowanie(tablica, lewy, j)
    if i < prawy:
        szybkie_sortowanie(tablica, i, prawy)


# Wywołanie
szybkie_sortowanie(tablica, 0, rozmiar - 1) # rozmiar = ilość elementów

# Wypisanie tablicy
print(tablica)


```

