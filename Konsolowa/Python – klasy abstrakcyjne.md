# Python – klasy abstrakcyjne

## 1. Co to jest klasa?

Klasa to wzór (szablon), na podstawie którego tworzy się obiekty.

Klasa opisuje:

* jakie dane ma obiekt (atrybuty)
* jakie czynności może wykonać (metody)

Prosty przykład klasy i jak się ją wywołuje:

klasa:

```python
class Samochod:
    def jedz(self):
        print("Samochód jedzie")
```

wywołanie klasy:

```python
# utworzenie obiektu klasy
s = Samochod()

# wywołanie metody
s.jedz()
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

Klasa jest abstrakcyjna, jeśli dziedziczy po `ABC` i zawiera co najmniej jedną metodę oznaczoną `@abstractmethod`.

przykład prostej klasy abstrakcyjnej:

```python
from abc import ABC, abstractmethod

class Figura(ABC):
    @abstractmethod
    def pole(self):
        pass
```

Nie możesz zrobić:

```python
f = Figura()  # błąd – nie można utworzyć obiektu klasy abstrakcyjnej
```

Ponieważ z klasy abstrakcyjnej nie możesz utworzyć obiektu, jednak pamiętaj, że możesz po niej dziedziczyć!

## 3. Dziedziczenie po klasie abstrakcyjnej oraz polimorfizm – przykład

```python
from abc import ABC, abstractmethod

class Figura(ABC):
    @abstractmethod
    def pole(self):
        pass

class Prostokat(Figura):
    def __init__(self, szerokosc, wysokosc):
        self.szerokosc = szerokosc
        self.wysokosc = wysokosc

    def pole(self):
        return self.szerokosc * self.wysokosc

class Kolo(Figura):
    def __init__(self, promien):
        self.promien = promien

    def pole(self):
        return 3.14 * self.promien * self.promien

p = Prostokat(4, 5)
k = Kolo(3)

print("Pole prostokata:", p.pole())
print("Pole kola:", k.pole())
```

Powyższy program liczy pole koła i prostokąta poprzez dziedziczenie po klasie abstrakcyjnej. Figura jest klasą abstrakcyjną – czyli szablonem. Mówi tylko, że figura musi policzyć swoje pole.

Program używa tej samej metody `pole()` do obliczenia zarówno pola koła, jak i prostokąta. Jest to przykład polimorfizmu.

## 3.1 Polimorfizm – jeden sposób wywołania, różne obiekty

```python
figury = [Prostokat(4, 5), Kolo(3)]

for f in figury:
    print(f.pole())
```

Nie możesz utworzyć obiektu klasy abstrakcyjnej, ale możesz przechowywać obiekty klas pochodnych w jednej kolekcji.

W skrócie POLIMORFIZM – jedna nazwa metody, różne działanie.

## 4. Przykład zadania używającego klasy abstrakcyjnej – Samochody

```python
from abc import ABC, abstractmethod

class Samochod(ABC):
    def __init__(self, marka, rocznik, kolor, predkosc=0):
        self.Marka = marka
        self.Rocznik = rocznik
        self.Kolor = kolor
        self.Predkosc = predkosc

    def info(self):
        print(f"Marka: {self.Marka}  Predkosc: {self.Predkosc} km/h  Rocznik: {self.Rocznik}  Kolor: {self.Kolor}")

    @abstractmethod
    def jedz(self):
        pass

    @abstractmethod
    def hamuj(self):
        pass

class SamochodSpalinowy(Samochod):
    def jedz(self):
        print("Silnik spalinowy")

    def hamuj(self):
        print("Hamowanie silnikiem spalinowym")
        self.Predkosc -= 10
        if self.Predkosc < 0:
            self.Predkosc = 0

class SamochodElektryczny(Samochod):
    def jedz(self):
        print("Samochod elektryczny")

    def hamuj(self):
        print("Rekuperacja - odzyskiwanie energii przy hamowaniu")
        self.Predkosc -= 15
        if self.Predkosc < 0:
            self.Predkosc = 0

class SamochodHybrydowy(Samochod):
    def jedz(self):
        print("Silnik elektryczny wspomaga spalinowy")

    def hamuj(self):
        print("Hamowanie hybrydowe - czesc energii odzyskiwana")
        self.Predkosc -= 12
        if self.Predkosc < 0:
            self.Predkosc = 0

s1 = SamochodSpalinowy("Audi", 2020, "Czarny", 50)
s2 = SamochodElektryczny("Tesla", 2022, "Czerwony", 30)
s3 = SamochodHybrydowy("Toyota", 2021, "Bialy", 40)

for s in (s1, s2, s3):
    s.jedz()
    s.info()
    s.hamuj()
    s.info()
    print()
```

Samochod to klasa abstrakcyjna – jest tylko wzorem.
Każdy samochód ma markę, prędkość, rocznik i kolor oraz musi umieć jechać i hamować (jedz(), hamuj()).

SamochodSpalinowy, SamochodElektryczny i SamochodHybrydowy to różne typy samochodów, które dziedziczą po klasie Samochod.

Każdy typ samochodu:

* jedzie inaczej
* hamuje inaczej
* inaczej zmniejsza prędkość

Funkcja info() pokazuje aktualne dane samochodu.
