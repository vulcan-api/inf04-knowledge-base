# WSKAŹNIKI i przekazywnaie 
## WERSJA C++
#### Objaśnienie: zmienna a ma wartość 10 i jakiś adres (&a) w pamięci np. 0x61ff08, &a = 0x61ff08. Int* p ma przypisany adres zmiennej a dlatego:
```cpp
int a = 10;  // & -> weź adres
int* p = &a; // * -> wartość spod adresu 

cout << a;   // 10
cout << p;   // adres, np. 0x61ff08
cout << *p;  // 10 (wartość spod adresu)
```

#### Przekazanie przez wskaźnik pozwala funkcji zmieniać wartość zmiennej zdefiniowanej poza nią, ponieważ operuje ona bezpośrednio na adresie tej zmiennej w pamięci.
#### Wskaźnik jest potrzebny do np. zmiany zmiennej poza funkcja tzn. masz zmienna a w c++  i chcesz zmienić jej wartość:
#### W tym przykładzie a ma jakiś adres i do tego adresu przypisuje wartosć 10 potem zmien() bierze adres x i w void ustawia jego wartość też na 10.
```cpp
void zmien(int* a) {
    *a = 10;
}
int main() {
    int x;
    zmien(&x);
    cout << x;   // WYPISZE: 10
}
// x ma wartość 5
// &x → adres zmiennej x
// a w funkcji = adres x
// *a = 10 → zmiana wartości x
```
## WERSJA C#
#### To to samo co 1 kod z cpp
```cs
class Box
{
    public int Value;
    public Box(int v) { Value = v; }
}
class Program
{
    static void Main()
    {
        Box a = new Box(10); // obiekt z wartością 10
        Box p = a;           // p wskazuje na TEN SAM obiekt (jak wskaźnik/referencja)

        Console.WriteLine(a.Value);            // 10
        Console.WriteLine(a.GetHashCode());    // "identyfikator" obiektu (nie prawdziwy adres)
        Console.WriteLine(p.Value);            // 10 (wartość z tego samego obiektu)
    }
}
```
#### To to samo co 2 kod z cpp
```cs
using System;

class Box
{
    public int Value;
}

class Program
{
    static void Zmien(Box a)
    {
        a.Value = 10;
    }

    static void Main()
    {
        Box x = new Box();   // domyślnie Value = 0
        Zmien(x);
        Console.WriteLine(x.Value); // 10
    }
}
```
## WERSJA pyton
#### To to samo co 1 kod z cpp
```py
a = 10
p = a  # p referuje do tego samego obiektu (dla intów to obiekt niemutowalny)

print(a)      # 10
print(id(a))  # "adres/ID" obiektu w pamięci (implementacyjnie)
print(p)      # 10
```
#### To to samo co 2 kod z cpp
```py
def zmien(a):
    a[0] = 10

x = [0]   # "pojemnik" na liczbę
zmien(x)
print(x[0])  # 10
```


