# C++ - klasy abstrakcyjne

## 1. Co to jest klasa?

Klasa to wzór (szablon), na podstawie którego tworzy się obiekty.

Klasa opisuje:

* jakie dane ma obiekt (pola)
* jakie czynności może wykonać (metody)

Prosty przykład klasy i jak się ją wywołuje:

klasa:

```cpp
class Samochod {
public:
    void jedz() {
        cout << "Samochód jedzie" << endl;
    }
};
```

wywołanie klasy:

```cpp
int main() {
    // utworzenie obiektu klasy
    Samochod s;

    // wywołanie metody
    s.jedz();

    return 0;
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

Klasa jest abstrakcyjna, jeśli zawiera co najmniej jedną funkcję czysto wirtualną.

prykład funkcji czysto wirtualnej:

```cpp
virtual void nazwa() = 0;
```

przykład prstej klasy abstrakcyjnej:

```cpp
class Figura {
public:
virtual float pole() = 0; // funkcja abstrakcyjna
};
```

Nie możesz zrobić:

```cpp
int main() {
    Figura f;
}
```

Ponieważ z klasy abstrakcyjnej nie możesz utworzyć obiektu, jednak pamiętaj, że możesz po niej dziedziczyć!

## 3. Dziedziczenie po klasie abstrakcyjnej oraz polimorfizm przykład:

```cpp
#include <iostream>
using namespace std;

//Klasa abstrakcyjna figura
class Figura {
public:
    virtual float pole() = 0; // funkcja czysto wirtualna
};

//Klasa pochodna Prostokat
class Prostokat : public Figura {
private:
    float szerokosc, wysokosc;

public:
    Prostokat(float s, float w) {
        szerokosc = s;
        wysokosc = w;
    }

    float pole() override {
        return szerokosc * wysokosc;
    }
};

//Klasa pochodna Kolo
class Kolo : public Figura {
private:
    float promien;

public:
    Kolo(float r) {
        promien = r;
    }

    float pole() override {
        return 3.14 * promien * promien;
    }
};

int main() {
    
    Prostokat p(4, 5);
    Kolo k(3);

    cout << "Pole prostokata: " << p.pole() << endl;
    cout << "Pole kola: " << k.pole() << endl;

    return 0;
}
```

Powyższy program liczy pole koła i prostokąta poprzez dziedziczenie po klasie abstrakcyjnej. Figura jest klasą abstrakcyjną - czyli szablonem. Mówi tylko, że figura musi policzyć swoje pole (pole() - funkcją licząca pole).
Funkcja override nadpisuje metodę w klasie bazowej. Override używa się po to aby nadpisac metode oraz aby zapobiec błędom np. jak popełnisz literówke to wyskoczy ci bład w kompilatorze. W tym przykladzie nadpisuje metode polę.
Program używa tej samej funkcji pole() do obliczenia zarówno pola koła jak i prostokątu. Jest to przykład polimorfizmu.

Powyższy program można wywołać w inny sposób - za pomocą wskaźniku do klasy abstrakcyjnej. Będzie to książkowy przykład jak działa POLIMORFIZM - możemy mieć wskaźniki do różnych klas pochodnych (Prostokat, Kolo) i wywoływać metodę pole() w ten sam sposób.
przykład:

```cpp
int main() {
    
    Figura* f1 = new Prostokat(4, 5); //dynamiczna alokacja pamięci
    Figura* f2 = new Kolo(3); //dynamiczna alokacja pamięci

    cout << "Pole prostokata: " << f1->pole() << endl;
    cout << "Pole kola: " << f2->pole() << endl;

    delete f1; //zwolnienie pamięci
    delete f2; //zwolnienie pamięci

    return 0;
}
```

Figura* oznacza wskaźnik do obiektu klasy Figura. Nie możesz utworzyć obiektu do klasy abstrakcyjnej, ale za to możesz mieć wskaźnik do klasy pochodnej. W skrócie POLIMORFIZM - jedna nazwa metody – różne działanie

## 4. Przykład zadania który używa klasy abstrakcyjne:

```cpp
#include <iostream>
#include <string>
using namespace std;

class Samochod {
public:
    string Marka;
    int Predkosc;
    int Rocznik;
    string Kolor;

    Samochod(string m, int r, string k, int p = 0) {
        Marka = m;
        Rocznik = r;
        Kolor = k;
        Predkosc = p; 
    }

    void Info() {
        cout << "Marka: " << Marka << "  Predkosc: " << Predkosc << " km/h  Rocznik: " << Rocznik << "  Kolor: " << Kolor << "\n";
    }

    virtual void Jedz() = 0;
    virtual void Hamuj() = 0;
};

class SamochodSpalinowy : public Samochod {
public:
    SamochodSpalinowy(string m, int r, string k, int p = 0) : Samochod(m, r, k, p) {}

    void Jedz() override {
        cout << "Silnik spalinowy \n";
    }

    void Hamuj() override {
        cout << "Hamowanie silnikiem spalinowym\n";
        Predkosc -= 10;
        if (Predkosc < 0) Predkosc = 0;
    }
};

class SamochodElektryczny : public Samochod {
public:
    SamochodElektryczny(string m, int r, string k, int p = 0) 
        : Samochod(m, r, k, p) {}

    void Jedz() override {
        cout << "Samochod elektryczny \n";
    }

    void Hamuj() override {
        cout << "Rekuperacja - odzyskiwanie energii przy hamowaniu\n";
        Predkosc -= 15;
        if (Predkosc < 0) Predkosc = 0;
    }
};

class SamochodHybrydowy : public Samochod {
public:
    SamochodHybrydowy(string m, int r, string k, int p = 0) 
        : Samochod(m, r, k, p) {}

    void Jedz() override {
        cout << "Silnik elektryczny wspomaga spalinowy\n";
    }

    void Hamuj() override {
        cout << "Hamowanie hybrydowe - czesc energii odzyskiwana\n";
        Predkosc -= 12;
        if (Predkosc < 0) Predkosc = 0;
    }
};

int main() {
    SamochodSpalinowy s1("Audi", 2020, "Czarny", 50);
    SamochodElektryczny s2("Tesla", 2022, "Czerwony", 30);
    SamochodHybrydowy s3("Toyota", 2021, "Bialy", 40);

    s1.Jedz();
    s1.Info();
    s1.Hamuj();
    s1.Info();

    cout << "\n";

    s2.Jedz();
    s2.Info();
    s2.Hamuj();
    s2.Info();

    cout << "\n";

    s3.Jedz();
    s3.Info();
    s3.Hamuj();
    s3.Info();

    return 0;
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
