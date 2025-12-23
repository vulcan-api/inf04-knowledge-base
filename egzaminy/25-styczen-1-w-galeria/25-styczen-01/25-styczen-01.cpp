#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

class Tablica {
private:
    int* tablica;            // Wskaźnik na dynamicznie utworzoną tablicę int
    int liczbaElementow;     // Faktyczna liczba elementów tablicy (limit dla operacji)

public:

    /***********************************************
    nazwa metody:        Tablica
    opis metody:         Konstruktor klasy. Tworzy tablicę dynamiczną o podanym rozmiarze i wypełnia ją liczbami pseudolosowymi z zakresu 1..1000.
    parametry:           rozmiar - liczba elementów tablicy (rozmiar tablicy).
    zwracany typ i opis: brak
    autor:               <numer_zdajacego>
    ***********************************************/
    Tablica(int rozmiar) {
        liczbaElementow = rozmiar;
        tablica = new int[liczbaElementow];   // Alokacja pamięci na tablicę

        srand(time(NULL));                    // Ustawienie ziarna losowania (raz na start)
        for (int i = 0; i < liczbaElementow; i++) {
            tablica[i] = rand() % 1000 + 1;   // Losowanie liczby z zakresu 1-1000
        }
    }

    /***********************************************
    nazwa metody:        ~Tablica
    opis metody:         Destruktor klasy. Zwalnia pamięć przydzieloną dynamicznie dla tablicy.
    parametry:           brak
    zwracany typ i opis: brak
    autor:               <numer_zdajacego>
    ***********************************************/
    ~Tablica() {
        delete[] tablica;                     // Usunięcie tablicy dynamicznej
    }

    /***********************************************
    nazwa metody:        wyswietlTablice
    opis metody:         Wyświetla wszystkie elementy tablicy w formacie "indeks: wartość".
    parametry:           brak
    zwracany typ i opis: void - metoda nie zwraca wartości.
    autor:               <numer_zdajacego>
    ***********************************************/
    void wyswietlTablice() {
        for (int i = 0; i < liczbaElementow; i++) {
            cout << i << ": " << tablica[i] << endl;
        }
    }

    /***********************************************
    nazwa metody:        wyszukaj
    opis metody:         Wyszukuje pierwsze wystąpienie podanej wartości w tablicy.
    parametry:           wartosc - szukana wartość w tablicy.
    zwracany typ i opis: int - indeks pierwszego znalezionego elementu lub -1, gdy nie znaleziono.
    autor:               <numer_zdajacego>
    ***********************************************/
    int wyszukaj(int wartosc) {
        for (int i = 0; i < liczbaElementow; i++) {
            if (tablica[i] == wartosc) {
                return i;                      // Zwracamy indeks pierwszego trafienia
            }
        }
        return -1;                             // Brak wartości w tablicy
    }

    /***********************************************
    nazwa metody:        wyswietlNieparzyste
    opis metody:         Wyświetla wszystkie liczby nieparzyste znajdujące się w tablicy oraz zlicza ich ilość.
    parametry:           brak
    zwracany typ i opis: int - liczba elementów nieparzystych w tablicy.
    autor:               <numer_zdajacego>
    ***********************************************/
    int wyswietlNieparzyste() {
        int licznik = 0;
        cout << "Liczby nieparzyste w tablicy: ";
        for (int i = 0; i < liczbaElementow; i++) {
            if (tablica[i] % 2 != 0) {        // Warunek: liczba nieparzysta
                cout << tablica[i] << " ";
                licznik++;
            }
        }
        cout << endl;
        return licznik;
    }

    /***********************************************
    nazwa metody:        srednia
    opis metody:         Oblicza średnią arytmetyczną wszystkich elementów tablicy.
    parametry:           brak
    zwracany typ i opis: double - średnia arytmetyczna wartości z tablicy.
    autor:               <numer_zdajacego>
    ***********************************************/
    double srednia() {
        int suma = 0;
        for (int i = 0; i < liczbaElementow; i++) {
            suma += tablica[i];               // Sumowanie elementów tablicy
        }
        return (double)suma / liczbaElementow; // Rzutowanie, aby uzyskać wynik zmiennoprzecinkowy
    }
};

int main() {
    cout << "PROGRAM OPERACJE NA TABLICY\n";

    // Tworzenie obiektu z rozmiarem większym niż 20 (zgodnie z poleceniem)
    Tablica t(25);

    cout << "\n1. Zawartosc tablicy:\n";
    t.wyswietlTablice();

    cout << "\n2. Wyszukiwanie wartosci\n";
    cout << "Podaj wartosc do wyszukania: ";
    int wartosc;
    cin >> wartosc;

    // Jeśli znaleziono, wypisz indeks; jeśli nie, nic nie wypisuj (wymóg zadania)
    int indeks = t.wyszukaj(wartosc);
    if (indeks != -1) {
        cout << "Znaleziono wartosc na indeksie: " << indeks << endl;
    }

    cout << "\n3. Liczby nieparzyste:\n";
    int ile = t.wyswietlNieparzyste();
    cout << "Ilosc liczb nieparzystych: " << ile << endl;

    cout << "\n4. Srednia arytmetyczna:\n";
    cout << "Srednia wartosci w tablicy: " << t.srednia() << endl;

    return 0;
}