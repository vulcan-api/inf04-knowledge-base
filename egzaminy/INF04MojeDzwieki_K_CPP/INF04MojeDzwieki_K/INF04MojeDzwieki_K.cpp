#include <iostream>     
#include <fstream>      
#include <string>       
using namespace std;


// Tworzymy klasę Album – czyli opis jak ma wyglądać jeden album
class Album {
public:
    string artist;
    // zmienna tekstowa – przechowuje nazwę artysty

    string title;
    // zmienna tekstowa – przechowuje tytuł albumu

    int songsNumber = 0;
    // liczba piosenek w albumie (na start 0)

    int year = 0;
    // rok wydania albumu (na start 0)

    long long downloadNumber = 0;
    // liczba pobrań – long long bo liczba może być bardzo duża

    void wyswietl() {
        // funkcja, która wypisuje dane albumu na ekran

        cout << artist << endl;
        // wypisz artystę

        cout << title << endl;
        // wypisz tytuł

        cout << songsNumber << endl;
        // wypisz liczbę piosenek

        cout << year << endl;
        // wypisz rok wydania

        cout << downloadNumber << endl;
        // wypisz liczbę pobrań

        cout << endl;
        // pusta linia, żeby oddzielić albumy
    }
};

// Funkcja wczytująca albumy z pliku
int getAlbums(Album albums[], int maxSize) {
    // Album albums[] – tablica albumów, którą dostajemy z maina
    // maxSize – maksymalna liczba albumów (np. 100)

    ifstream file("Data.txt");
    // otwieramy plik Data.txt do czytania

    if (!file) {
        // sprawdzamy czy plik się poprawnie otworzył

        cout << "Blad otwarcia pliku!" << endl;
        // jeśli nie, wypisujemy błąd

        return 0;
        // i kończymy funkcję – 0 albumów
    }

    int count = 0;
    // licznik – ile albumów już wczytaliśmy

    while (count < maxSize) {
        // pętla działa dopóki nie przekroczymy rozmiaru tablicy

        if (!getline(file, albums[count].artist))
            // próbujemy wczytać linię z artystą

            break;
        // jeśli się nie uda (koniec pliku) – wychodzimy z pętli

        if (albums[count].artist == "")
            // jeśli linia jest pusta

            continue;
        // pomijamy ją i idziemy do następnego obrotu pętli

        getline(file, albums[count].title);
        // wczytujemy tytuł albumu

        file >> albums[count].songsNumber;
        // wczytujemy liczbę piosenek

        file >> albums[count].year;
        // wczytujemy rok wydania

        file >> albums[count].downloadNumber;
        // wczytujemy liczbę pobrań

        file.ignore();
        // ignorujemy znak nowej linii po liczbach

        count++;
        // zwiększamy licznik – wczytaliśmy jeden album
    }

    file.close();
    // zamykamy plik

    return count;
    // zwracamy ile albumów udało się wczytać
}

int main() {
    Album albums[100];
    // tworzymy tablicę na 100 albumów
    // jakby po prostu np. albums[0] przechowuje artist, title itd.

    int count = getAlbums(albums, 100);
    // wywołujemy funkcję, która wczyta albumy z pliku
    // i zapisze je do tablicy albums

    for (int i = 0; i < count; i++) {
        // pętla przechodząca po wszystkich wczytanych albumach

        albums[i].wyswietl();
        // wyświetlamy każdy album
    }

    return 0;
}




