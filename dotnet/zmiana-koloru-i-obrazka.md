# Dynamiczna zmiana obrazka lub koloru w C# 

Powrót na start -> [Start](./root.md)
 
## Zamiana koloru w Xamarin.Forms i MAUI
 
> Dynamiczna zmiana koloru w Xamarin.Forms jest bardzo prostym zadaniem    
> Jest tak, ponieważ kontrolki kolor definiują za pomocą `Color`, a nie `Brush` 
 
Kolor w C# jest przechowywany jako obiekt klasy `Color`, na której można wywołać kilka metod 

```cs
Color.FromRgb(byte R, byte G, byte B) // Tworzy kolor z wartości R, G, B (Red, Green, Blue). Muszą być typu byte
Color.FromHex(string hex) // Tworzy kolor z np. stringu "#FFFF00" 
Color.FromHsla(float H, float S, float L, float A) // Tworzy kolor z HSL (Odcień, Nasycenie, Jasność, Przezroczystość) 
```
 
Można też zastosować klasę `ColorConverter` i jej metody, by przejść z jednego kodowania koloru na inny. 
 
`Color c = (Color)ColorConverter.ConvertFromString("#00FF00")`
 
Można korzystać z predefiniowanych kolorów, na przykład:
 
`boxView.Color = Color.Yellow` 
 
Zmieni kolor kontrolki na żółty, choć warto pamiętać że czasem należy zdefiniować `BackgroundColor` albo `Fill` 
 
Dodatkowo 
 
> MAUI również pozwala na zmianę koloru w ten sposób, ze względu na kompatybilność wsteczną z Xamarin.Forms
 
Posiada też kilka ciekawą metodę nieobecną w Xamarinie
 
+ `kolor.GetComplementary()` - Zwraca kolor dopełniający (przeciwny do obecnej) np. czerwień - cyjan, zieleń - magenta, żółty - niebieski
 
+ `kolor.With_____` - Tworzy kolor z nową składową np. `kolor.WithAlpha(0.75)` doda alfę do istniejącego koloru `kolor`, czyli będzie bardziej przezroczysty
 
## Zamiana koloru w WPF 
 
> Sprawa drastycznie komplikuje się w WPFie, ponieważ jego kontrolki są typu `Brush`  
> Zatem nasze kolory należy definiować za pomocą `Color` i konwertować na `Brush` 
 
### Brush 
*Dlaczego Brush jest stosowany zamiast Color?*
 
`Brush` jest bardziej abstrakcyjnym konceptem niż `Color`, ponieważ może być nie tylko kolorem (`SolidColorBrush`), lecz także gradientem (`LinearColorBrush`), zdjęciem (`ImageBrush`) lub nawet rysunkiem (`DrawingBrush`). `Color` jest bardziej ograniczony 
 
#### Przykładowy kod
 
````cs 
byte red = Convert.ToByte(sliderR.Value);
byte green = Convert.ToByte(sliderG.Value);     // Pobieramy kolory RGB ze Sliderów
byte blue = Convert.ToByte(sliderB.Value);
Color color = Color.FromRgb(red, green, blue);  // Tworzymy kolor z składowych red, green, blue
SolidColorBrush brush = new SolidColorBrush(color); // Konwersja Color -> Brush
rect.Fill = brush;
outputText.Background = brush;      // Zamiana koloru kontrolki w C# 
outputText.Content = $"{red}, {green}, {blue}";
````
 
> `BrushConverter` pozwala na bezpośrednią konwersję String -> Brush 
 
````cs 
BrushConverter converter = new BrushConverter();
Brush backColor = (Brush)converter.ConvertFromString("#FFFF00");
boxView.Background = backColor; 
```` 
 
## Dynamiczna podmiana obrazka
 
> Dodawanie zdjęć dla aplikacji mobilnych odbywa się znacznie inaczej niż w przypadku WPFa
> Jest tak ze względu na to, że źródłem zdjęć w WPFie jest `BitmapImage` a aplikacjach mobilnych - `ImageSource` 
 
#### Jak wstawić zdjęcie w Visual Studio
 
1. W Eksploratorze rozwiązań (`Ctrl + ;`) przejdź do folderu `[nazwa projektu].Android/Resources/drawable` 
2. `Dodaj istniejący element` (`Shift + Alt + A`) -> Dodaj Twoje zdjęcie
3. Przejdź do `Właściwości` zdjęcia (`Alt + Enter`) i ustaw `Akcje kompilacji` na `AndroidResource` 
4. Dodaj swoje zdjęcie w kodzie XAML 
 
### Dynamiczna podmiana obrazka - Xamarin.Forms i MAUI 
 
Przykładowy kod 
 
````cs 
img.Source = ImageSource.FromFile("dupa.jpg"); // Pobranie z pliku 
img.Source = ImageSource.FromUri("https://nihrecord.nih.gov/sites/nihrecord/files/styles/float_medium/public/2019/November-1/lobotomy%20icepickjpg?itok=rJmRqsx9"); // Z linku 
 
````
 
> W MAUI powinno działać ze względu na kompatybilność wsteczną, jeśli nie działa - Należy zrobić to tak jak w WPFie
 
 
### Dynamiczna podmiana obrazka - WPF 
 
Zdjęcia są przechowywane w projekcie WPF jako instancje klasy `BitmapImage`, do których nalęży podać ścieżkę jako `Uri` 
 
*Co to jest BitmapImage i dlaczego się go stosuje?*
 
`BitmapImage` jest klasą obsługującą wszelkiego rodzaju pliki rastrowe - Czyli w formacie .png, .jpg, .gif czy .bmp  
`BitmapImage` jest spokrewniony z `ImageSource`, Xamarin i MAUI ułatwiają nam pracę i za kulisami tak naprawdę 
wywołują `BitmapImage` gdy posługujemy się `ImageSource` 
 
Słysząc `BitmapImage` należy rozumieć ogólnie zdjęcia złożone z pikseli. Klasa ta pozwala na wiele funkcjonalności i jest dosyć elastyczna 
 
*Czym jest Uri?*   
`Uri (Uniform Resource Indicator)` jest adresem (identyfikatorem) jakiegoś zasobu (np. zdjęcia) po nazwie lub lokalizacji (lub obu) 
Znanym podtypem Uri jest `URL`, czyli po prostu link 
 
Przykłady zastosowania Uri 
 
````cs 
Uri uriLink = new Uri("https://kocham.krzysztofa/stope.jpg"); // Link do zdjęcia na stronie
Uri uriLocal = new Uri("files/rel.png", UriKind.Relative); // Absolutną byłoby C:\... 
 
// Ścieżki można łączyć
Uri baseUri = new Uri("https://stopka.pl/api/"); 
Uri relativeUri = new Uri("public/glaca.jpg", UriKind.Relative);
Uri combinedUri = new Uri(baseUri, relativeUri);
 
//Odnośnik do pliku
Uri fileUri = new Uri(@"/docs/document.pdf")
 
// Jeśli kod by nie działał warto rozpatrzeć zmianę  "/" na "\", zwłaszcza jeśli stosujemy ścieżki do plików w Windowsie
 
```` 
 
Mając tą wiedzę możemy dowiedzieć się jak dodać zdjęcie w WPFie:   
 
````cs 
imgFace.Source = new BitmapImage(new Uri("1-zdjecie.png", UriKind.Relative)); 
imgPrint.Source = new BitmapImage(new Uri("1-odcisk.jpg", UriKind.Relative)); 
 
````