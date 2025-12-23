# Lambda (funkcja anonimowa)

Powrót na start -> [Start](./root.md)

Funkcja anonimowa (lambda albo w JSie funkcja strzałkowa) to skrócona postać funkcji bez nazwy, przypisana do zmiennej
Funkcja klasyczna jest definiowana osobno, a funkcja strzałkowa bezpośrednio w miejscu użycia

## Zwykła funkcja

**C++**
```cpp
int dodaj(int a, int b)
{
    return a + b;
}
```

**C#**
```cs
static int Dodaj(int a, int b)
{
    return a + b;
}
```

## Lambda

**C++**
```cpp
auto dodaj = [](int a, int b) {
    return a + b;
};
```

**C#**
```cs
Func<int, int, int> dodaj = (int a, int b) =>
{
    return a + b;
};
```

## Obliczanie NWD bez lambdy

**C++**
```cpp
#include <iostream>
using namespace std;

// Funkcja obliczająca NWD
int NWD(int a, int b)
{
    while (a != b)
    {
        if (a > b)
            a = a - b;
        else
            b = b - a;
    }
    return a;
}

int main()
{
    int a, b;

    cout << "Podaj dwie liczby: ";
    cin >> a >> b;

    cout << "NWD = " << NWD(a, b) << endl;

    return 0;
}
```

**C#**
```cs
class Program {
    static void Main()
    {
        Func<int, int, int> dodaj = (int a, int b) =>
        {
            return a + b;
        };

        int a, b;

        Console.Write("Podaj dwie liczby: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("NWD = " + NWD(a, b));

    }

    static int NWD(int a, int b)
    {
        while (a != b)
        {
            if (a > b)
                a = a - b;
            else
                b = b - a;
        }
        return a;
    }
}
```

## Obliczanie NWD z lambdą

**C++**
```cpp
#include <iostream>
using namespace std;

int main()
{
    // Funkcja strzałkowa obliczająca NWD
    auto NWD = [](int a, int b)
    {
        while (a != b)
        {
            if (a > b)
                a = a - b;
            else
                b = b - a;
        }
        return a;
    };

    int a, b;

    cout << "Podaj dwie liczby: ";
    cin >> a >> b;

    cout << "NWD = " << NWD(a, b) << endl;

    return 0;
}
```

**C#**
```cs
class Program {
    static void Main() {
        Func<int, int, int> NWD_lambda = (int x, int y) =>
        {
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            return x;
        };

        Console.WriteLine("NWD (funkcja strzalkowa) = " + NWD_lambda(a, b));
    }
}
```