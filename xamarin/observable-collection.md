## ObservableCollection
- Powrót na start -> [Start](./root.md)

# 1. Definicja

`ObservableCollection<T>` to kolekcja, która automatycznie informuje interfejs użytkownika  
o zmianach (dodaniu, usunięciu lub wyczyszczeniu listy).

Dzięki niej **nie trzeba ręcznie odświeżać kontrolek** takich jak `ListView` czy `CollectionView`.

---

### Wymagana przestrzeń nazw:

```csharp
using System.Collections.ObjectModel;
```

## 2. Implementacja w Xamarin
W Xamarinie najczęściej stosuje się bindowanie do klasy strony.

  MainPage.xaml.cs
```csharp
public partial class MainPage : ContentPage
{
    // Deklaracja kolekcji
    public ObservableCollection<string> Owoce { get; set; }

    // Główna metoda w c#
    public MainPage()
    {
        InitializeComponent();

        // Tworzenie kolekcji, w nawiasach piszemy co chcemy, żeby znajdowało się w kolekcji
        Owoce = new ObservableCollection<string> { "Jabłko", "Banan" };

        // KLUCZOWE!!! Ustawienie kontekstu powiązania na tę klasę, bez tego nie zadziała bindowanie w XAML
        BindingContext = this;
    }

    // Metoda naciśnięcia na przycisk
    private void OnAddClicked(object sender, EventArgs e)
    {
        // Interfejs odświeży się automatycznie po dodaniu elementu
        Owoce.Add("Pomarańcza");
    }
}
```
  MainPage.xaml
```xml

<StackLayout>

    <!-- Przycisk do dodawania elementów -->
    <Button Text="Dodaj"
            Clicked="OnAddClicked" />

    <!--
        ListView służy do wyświetlania kolekcji,
        a ItemsSource="{Binding Owoce}" oznacza,
        że widok pobiera elementy z kolekcji Owoce
        zdefiniowanej w kodzie C#
    -->
    <ListView ItemsSource="{Binding Owoce}" />

</StackLayout>

```
## 3. Implementacja w .NET MAUI
W MAUI struktura jest bardzo podobna,
ale zamiast ListView zaleca się używanie CollectionView.

MainPage.xaml.cs
``` csharp

public partial class MainPage : ContentPage
{
    // Deklaracja kolekcji
    public ObservableCollection<string> Owoce { get; set; }

    // Główna metoda
    public MainPage()
    {
        InitializeComponent();

        // Tworzenie kolekcji
        Owoce = new ObservableCollection<string> { "Jabłko", "Banan" };

        // KLUCZOWE!!!
        // Bez ustawienia BindingContext bindowanie nie zadziała
        BindingContext = this;
    }

    // Metoda naciśnięcia na przycisk
    private void OnAddClicked(object sender, EventArgs e)
    {
        // UI odświeży się automatycznie po dodaniu elementu
        Owoce.Add("Nowy Owoc MAUI");
    }
}
```
MainPage.xaml
```xml

<VerticalStackLayout Padding="20">

    <!-- Przycisk do dodawania elementów -->
    <Button Text="Dodaj w MAUI"
            Clicked="OnAddClicked" />

    <!--
        CollectionView służy do wyświetlania kolekcji,
        działa podobnie jak ListView,
        ale jest zalecany w MAUI
    -->
    <CollectionView ItemsSource="{Binding Owoce}">

        <!-- To w EmptyView jest wyświetlane,
             gdy kolekcja jest pusta -->
        <CollectionView.EmptyView>
            <Label Text="Brak danych!!!"
                   HorizontalOptions="Center" />
        </CollectionView.EmptyView>

    </CollectionView>

</VerticalStackLayout>

```
## 4. Dodawanie elementów z Entry
Ten przykład pokazuje dokładnie to samo co wyżej,
ale zamiast wpisywać dane na sztywno,
pobieramy je z pola Entry.

### 4.1 Xamarin – Entry + ObservableCollection
  MainPage.xaml.cs
```csharp

public partial class MainPage : ContentPage
{
    // Deklaracja kolekcji
    public ObservableCollection<string> Owoce { get; set; }

    // Główna metoda w c#
    public MainPage()
    {
        InitializeComponent();

        // Tworzymy pustą kolekcję
        Owoce = new ObservableCollection<string>();

        // KLUCZOWE!!!
        // Bez tego XAML nie widzi kolekcji
        BindingContext = this;
    }

    // Metoda naciśnięcia na przycisk
    private void OnAddClicked(object sender, EventArgs e)
    {
        // Sprawdzamy czy użytkownik coś wpisał
        if (!string.IsNullOrWhiteSpace(EntryOwoc.Text))
        {
            // Dodajemy tekst z Entry do kolekcji
            Owoce.Add(EntryOwoc.Text);

            // Czyścimy Entry po dodaniu elementu
            EntryOwoc.Text = "";
        }
    }
}
```
MainPage.xaml
```xml
<StackLayout Padding="20">

    <!-- Entry, w którym użytkownik wpisuje dane -->
    <Entry x:Name="EntryOwoc"
           Placeholder="Wpisz nazwę owocu" />

    <!-- Przycisk dodający wpisany tekst do kolekcji -->
    <Button Text="Dodaj"
            Clicked="OnAddClicked" />

    <!-- ListView wyświetla dane z ObservableCollection -->
    <ListView ItemsSource="{Binding Owoce}" />

</StackLayout>
```
### 4.2 .NET MAUI – Entry + ObservableCollection
  MainPage.xaml.cs
```csharp
Skopiuj kod
public partial class MainPage : ContentPage
{
    // Deklaracja kolekcji
    public ObservableCollection<string> Owoce { get; set; }

    // Główna metoda
    public MainPage()
    {
        InitializeComponent();

        // Tworzymy pustą kolekcję
        Owoce = new ObservableCollection<string>();

        // KLUCZOWE!!!
        BindingContext = this;
    }

    // Metoda naciśnięcia przycisku
    private void OnAddClicked(object sender, EventArgs e)
    {
        // Sprawdzamy czy użytkownik coś wpisał
        if (!string.IsNullOrWhiteSpace(EntryOwoc.Text))
        {
            // Dodajemy tekst z Entry do kolekcji
            Owoce.Add(EntryOwoc.Text);

            // Czyścimy Entry po dodaniu
            EntryOwoc.Text = "";
        }
    }
}
```
  MainPage.xaml
```xml

<VerticalStackLayout Padding="20">

    <!-- Entry do wpisywania danych -->
    <Entry x:Name="EntryOwoc"
           Placeholder="Wpisz nazwę owocu" />

    <!-- Przycisk dodający element -->
    <Button Text="Dodaj"
            Clicked="OnAddClicked" />

    <!-- CollectionView wyświetla kolekcję -->
    <CollectionView ItemsSource="{Binding Owoce}" />

</VerticalStackLayout>
```
## 5. Metody zarządzania kolekcją
(takie same dla Xamarin i MAUI)

``` csharp

Owoce.Add("Truskawka");        // dodanie elementu
Owoce.Insert(0, "Pierwszy");  // wstawienie na początek
Owoce.Remove("Banan");        // usunięcie konkretnego elementu
Owoce.RemoveAt(0);            // usunięcie po indeksie
Owoce.Clear();                // wyczyszczenie kolekcji
Owoce.Move(0, 2);             // przesunięcie elementu (staryIndex, nowyIndex)
```
## 6. Ważne informacje

ObservableCollection vs List

List<T> → NIE odświeża UI

ObservableCollection<T> → odświeża UI automatycznie

UWAGA! BindingContext:

```csharp

BindingContext = this;
```
musi być ustawiony, inaczej {Binding Owoce} nie zadziała.