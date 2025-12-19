from dataclasses import dataclass
# importujemy dataclass – u³atwia tworzenie klas (Python sam robi konstruktor)


@dataclass
class Album:
    # Klasa Album – opisuje jeden album muzyczny

    artist: str
    # nazwa artysty (tekst)

    album: str
    # nazwa albumu (tekst)

    songsNumber: int
    # liczba piosenek w albumie

    year: int
    # rok wydania albumu

    downloadNumber: int
    # liczba pobrañ albumu


def get_albums(filename: str) -> list[Album]:
    """
    nazwa funkcji:       get_albums
    opis funkcji:        funkcja odczytuje dane z pliku tekstowego
                         i tworzy obiekty klasy Album
    parametry:           filename – nazwa pliku z danymi
    zwracany typ:        lista obiektów klasy Album
    autor:               123456789112
    """

    albums: list[Album] = []
    # tworzymy pust¹ listê na albumy

    with open(filename, encoding='utf8') as f:
        # otwieramy plik do odczytu
        # encoding='utf8' – poprawna obs³uga polskich znaków

        while True:
            # pêtla dzia³a do momentu napotkania koñca pliku

            artist = f.readline().strip()
            # wczytujemy liniê z nazw¹ artysty
            # strip() usuwa znak nowej linii

            if artist == '':
                # jeœli linia jest pusta – koniec pliku
                break

            album_name = f.readline().strip()
            # wczytujemy nazwê albumu

            songs_number = int(f.readline().strip())
            # wczytujemy liczbê piosenek i zamieniamy na int

            year = int(f.readline().strip())
            # wczytujemy rok wydania

            download_number = int(f.readline().strip())
            # wczytujemy liczbê pobrañ

            f.readline()
            # pomijamy pust¹ liniê oddzielaj¹c¹ albumy
            # odpowiednik file.ignore() w C++

            album = Album(
                artist,
                album_name,
                songs_number,
                year,
                download_number
            )
            # tworzymy obiekt klasy Album

            albums.append(album)
            # dodajemy album do listy

    return albums
    # zwracamy listê wczytanych albumów


def print_albums(albums: list[Album]) -> None:
    # funkcja wypisuje albumy na ekran

    for album in albums:
        # przechodzimy po ka¿dym albumie w liœcie

        print(album.artist)
        # wypisujemy nazwê artysty

        print(album.album)
        # wypisujemy nazwê albumu

        print(album.songsNumber)
        # wypisujemy liczbê piosenek

        print(album.year)
        # wypisujemy rok wydania

        print(album.downloadNumber)
        # wypisujemy liczbê pobrañ

        print()
        # pusta linia – oddzielenie albumów


def main():
    # funkcja g³ówna programu

    albums = get_albums('Data.txt')
    # wczytujemy albumy z pliku Data.txt

    print_albums(albums)
    # wyœwietlamy wszystkie albumy


if __name__ == '__main__':
    # sprawdzenie, czy plik jest uruchamiany bezpoœrednio

    main()
    # uruchomienie programu

