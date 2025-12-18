# C# – klasy abstrakcyjne

## 1. Co to jest klasa?

Klasa to wzór (szablon), na podstawie którego tworzy się obiekty.

Klasa opisuje:

* jakie dane ma obiekt (pola)
* jakie czynności może wykonać (metody)

Prosty przykład klasy i jak się ją wywołuje:

klasa:

```csharp
class Samochod {
    public void Jedz() {
        Console.WriteLine("Samochód jedzie");
    }
}
```

wywołanie klasy:

```csharp
class Program {
    static void Main() {
        // utworzenie obiektu klasy
        Samochod s = new Samochod();

        // wywołanie metody
        s.Jedz();
    }
}
```

## 2. Co to jest klasa abstrakcyjna?

Klasa abstrakcyjna to taka klasa:

* nie można utworzyć z niej obiektu
* służy jako baza (wzór) dla innych klas

W skrócie: Klasa abstrakcyjna mówi co obiekt ma robić, ale nie zawsze JAK.

Po co się używa klas abstrakcyjnych?

* gdy chcemy wymusić implementację metod w klasach pochodnych
* mieć jeden wspólny wzór dla różnych klas
* móc obsługiwać różne obiekty w ten sam sposób

Skąd mam wiedzieć kiedy klasa jest abstrakcyjna?

Klasa jest abstrakcyjna, jeśli zawiera co najmniej jedną metodę abstrakcyjną.

przykład metody abstrakcyjnej:

```csharp
public abstract void Nazwa();
```

przykład prostej klasy abstrakcyjnej:

```csharp
abstract class Figura {
    public abstract float Pole();
}
```

Nie możesz zrobić:

```csharp
class Program {
    static void Main() {
        Figura f; // błąd – nie można utworzyć obiektu klasy abstrakcyjnej
    }
}
```

Ponieważ z klasy abstrakcyjnej nie możesz utworzyć obiektu, jednak pamiętaj, że możesz po niej dziedziczyć!

## 3. Dziedziczenie po klasie abstrakcyjnej oraz polimorfizm – przykład

```csharp
using System;

abstract class Figura {
    public abstract float Pole();
}

class Prostokat : Figura {
    private float szerokosc, wysokosc;

    public Prostokat(float s, float w) {
        szerokosc = s;
        wysokosc = w;
    }

    public override float Pole() {
        return szerokosc * wysokosc;
    }
}

class Kolo : Figura {
    private float promien;

    public Kolo(float r) {
        promien = r;
    }

    public override float Pole() {
        return 3.14f * promien * promien;
    }
}

class Program {
    static void Main() {
        Prostokat p = new Prostokat(4, 5);
        Kolo k = new Kolo(3);

        Console.WriteLine("Pole prostokata: " + p.Pole());
        Console.WriteLine("Pole kola: " + k.Pole());
    }
}
```

Powyższy program liczy pole koła i prostokąta poprzez dziedziczenie po klasie abstrakcyjnej. Figura jest klasą abstrakcyjną – czyli szablonem. Mówi tylko, że figura musi policzyć swoje pole.

Słowo kluczowe `override` służy do nadpisania metody abstrakcyjnej z klasy bazowej. Kompilator sprawdza, czy metoda została poprawnie zaimplementowana.

Program używa tej samej metody `Pole()` do obliczenia zarówno pola koła, jak i prostokąta. Jest to przykład polimorfizmu.

## 3.1 Polimorfizm z użyciem referencji do klasy abstrakcyjnej

```csharp
class Program {
    static void Main() {
        Figura f1 = new Prostokat(4, 5);
        Figura f2 = new Kolo(3);

        Console.WriteLine("Pole prostokata: " + f1.Pole());
        Console.WriteLine("Pole kola: " + f2.Pole());
    }
}
```

Figura oznacza referencję do obiektu klasy bazowej. Nie możesz utworzyć obiektu klasy abstrakcyjnej, ale możesz przechowywać w niej obiekty klas pochodnych.

W skrócie POLIMORFIZM – jedna nazwa metody, różne działanie.

## 4. Przykład zadania używającego klasy abstrakcyjnej – Samochody

```csharp
using System;

abstract class Samochod {
    public string Marka;
    public int Predkosc;
    public int Rocznik;
    public string Kolor;

    public Samochod(string m, int r, string k, int p = 0) {
        Marka = m;
        Rocznik = r;
        Kolor = k;
        Predkosc = p;
    }

    public void Info() {
        Console.WriteLine($"Marka: {Marka}  Predkosc: {Predkosc} km/h  Rocznik: {Rocznik}  Kolor: {Kolor}");
    }

    public abstract void Jedz();
    public abstract void Hamuj();
}

class SamochodSpalinowy : Samochod {
    public SamochodSpalinowy(string m, int r, string k, int p = 0)
        : base(m, r, k, p) {}

    public override void Jedz() {
        Console.WriteLine("Silnik spalinowy");
    }

    public override void Hamuj() {
        Console.WriteLine("Hamowanie silnikiem spalinowym");
        Predkosc -= 10;
        if (Predkosc < 0) Predkosc = 0;
    }
}

class SamochodElektryczny : Samochod {
    public SamochodElektryczny(string m, int r, string k, int p = 0)
        : base(m, r, k, p) {}

    public override void Jedz() {
        Console.WriteLine("Samochod elektryczny");
    }

    public override void Hamuj() {
        Console.WriteLine("Rekuperacja – odzyskiwanie energii przy hamowaniu");
        Predkosc -= 15;
        if (Predkosc < 0) Predkosc = 0;
    }
}

class SamochodHybrydowy : Samochod {
    public SamochodHybrydowy(string m, int r, string k, int p = 0)
        : base(m, r, k, p) {}

    public override void Jedz() {
        Console.WriteLine("Silnik elektryczny wspomaga spalinowy");
    }

    public override void Hamuj() {
        Console.WriteLine("Hamowanie hybrydowe – czesc energii odzyskiwana");
        Predkosc -= 12;
        if (Predkosc < 0) Predkosc = 0;
    }
}

class Program {
    static void Main() {
        Samochod s1 = new SamochodSpalinowy("Audi", 2020, "Czarny", 50);
        Samochod s2 = new SamochodElektryczny("Tesla", 2022, "Czerwony", 30);
        Samochod s3 = new SamochodHybrydowy("Toyota", 2021, "Bialy", 40);

        s1.Jedz();
        s1.Info();
        s1.Hamuj();
        s1.Info();

        Console.WriteLine();

        s2.Jedz();
        s2.Info();
        s2.Hamuj();
        s2.Info();

        Console.WriteLine();

        s3.Jedz();
        s3.Info();
        s3.Hamuj();
        s3.Info();
    }
}
```

Samochod to klasa abstrakcyjna – jest tylko wzorem.
Każdy samochód ma markę, prędkość, rocznik i kolor oraz musi umieć jechać i hamować (Jedz(), Hamuj()).

SamochodSpalinowy, SamochodElektryczny i SamochodHybrydowy to różne typy samochodów, które dziedziczą po klasie Samochod.

Każdy typ samochodu:

* jedzie inaczej
* hamuje inaczej
* inaczej zmniejsza prędkość

Funkcja Info() pokazuje aktualne dane samochodu.
