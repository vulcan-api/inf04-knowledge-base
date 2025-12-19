using System.Runtime.ConstrainedExecution;


namespace mojeDzwieki
{
    class Albumy
    {
        // POLA klasy – dane jednego albumu

        private string artist;
        // nazwa artysty

        private string album;
        // tytuł albumu

        private int songsNumber;
        // liczba piosenek

        private int year;
        // rok wydania

        private int downloadNumber;
        // liczba pobrań

        // KONSTRUKTOR klasy Albumy
        // uruchamia się AUTOMATYCZNIE przy tworzeniu obiektu
        public Albumy(string artist, string album, int songsNumber, int year, int downloadNumber)
        {
            // this oznacza: „pole tego konkretnego obiektu”
            this.artist = artist;               // przypisujemy artystę
            this.album = album;                 // przypisujemy tytuł
            this.songsNumber = songsNumber;     // przypisujemy liczbę piosenek
            this.year = year;                   // przypisujemy rok
            this.downloadNumber = downloadNumber; // przypisujemy liczbę pobrań
        }

        /**********************************************
        nazwa metody: wyswietl
        opis metody: Metoda odpowiada za wyświetlenie danych danego obiektu 
        parametry: brak
        zwracany typ i opis: brak
        autor: 00000000000
        ***********************************************/
        public void wyswietl()
        {
            // Metoda wypisująca dane albumu na ekran

            Console.WriteLine(
                artist + "\n" +        // artysta
                album + "\n" +         // tytuł albumu
                songsNumber + "\n" +   // liczba piosenek
                year + "\n" +          // rok wydania
                downloadNumber + "\n"  // liczba pobrań
            );
        }
    };

    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista (dynamiczna tablica) obiektów Albumy
            List<Albumy> listaAlbumow = new List<Albumy>();

            // Wczytujemy CAŁY plik do tablicy stringów
            // każda linia pliku = jeden element tablicy
            string[] linie = File.ReadAllLines("../../../Data.txt");

            // Pętla idzie po liniach pliku co 6 linii
            // (bo jeden album zajmuje 6 linii w pliku)
            for (int i = 0; i < linie.Length; i += 6)
            {
                // Tworzymy nowy obiekt Albumy
                // i dodajemy go do listy
                listaAlbumow.Add(new Albumy(
                    linie[i],                      // artysta
                    linie[i + 1],                  // tytuł albumu
                    int.Parse(linie[i + 2]),       // liczba piosenek
                    int.Parse(linie[i + 3]),       // rok wydania
                    int.Parse(linie[i + 4])        // liczba pobrań
                ));
            }

            // Pętla foreach – przechodzi po wszystkich albumach w liście
            foreach (Albumy album in listaAlbumow)
            {
                album.wyswietl();  // wyświetlamy dane jednego albumu
            }
        }
    }
}
