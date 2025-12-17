# Frontend – Xamarin.Forms i .NET MAUI

# 📝 Spis Treści

1. [Layouty (Układy)](#1-layouty-układy)
    * [Grid (Siatka)](#grid-siatka)
    * [StackLayout](#stacklayout)
    * [AbsoluteLayout](#absolutelayout)
   


---
`
## 1. Layouty (Układy)

### Grid (Siatka)
 Grid porządkuje elementy w **wierszach** (`RowDefinitions`) i **kolumnach** (`ColumnDefinitions`). **`RowDefinition`** ma atrybut `Height`, a **`ColumnDefinition`** ma atrybut `Width`.

 **`Grid.Row` oraz `Grid.Column` indeksują się od 0 a nie od 1.**



### Kluczowe Wymiary i Atrybuty 

| Właściwość | Wartość | Działanie |
| :--- | :--- | :--- |
| **Liczba** | np. `40` | Stały rozmiar w jednostkach |
| **`Auto`** | `Auto` | Rozmiar dopasowany do zawartości komórki (np. wysokość tekstu). |
| **`*` (Star)** | `*`, `2*` | Zajmuje pozostałą dostępną przestrzeń (`2*` zajmuje **2x** więcej niż `*` i tak dalej dla `3*` itp). |
| **Pozycjonowanie** | `Grid.Row`, `Grid.Column` | Określa, gdzie element ma się znaleźć. |
| **Spanowanie** | `Grid.RowSpan`, `Grid.ColumnSpan` | Łączenie komórek (pionowo/poziomo). |

### Szczegółowo tabelka wyżej (proste przykłady)
#### 1. Definicja stałej kolumny
```xml  
<ColumnDefinition Width="40" />
``` 
Tworzy kolumnę o stałej szerokości.

#### 2. Definicja wiersza dopasowanego do treści
```xml  
<RowDefinition Height="Auto" />
``` 
Tworzy wiersz, który automatycznie dopasowuje swoją wysokość do zawartości umieszczonej w komórce.

#### 3. Proporcjonalny podział pozostałej przestrzeni
```xml  
<ColumnDefinition Width="2*" />
<ColumnDefinition Width="*" />
``` 
Tworzy dwie kolumny, które dzielą całą pozostałą szerokość w stosunku 2:1. Pierwsza kolumna jest dwa razy szersza niż druga. `Star` czyli `*` ustawia się automatycznie jeśli nie ustalimy `Width` dla `ColumnDefinition` / `Height` dla `RowDefinition`.

#### 4. Umieszczenie elementu w komórce
```xml  
<Label Text="Nazwa" Grid.Row="1" Grid.Column="0" />
``` 
Pozycjonujemy `Label` w drugim wierszu **(indeks 1)** i pierwszej kolumnie **(indeks 0)**. **Indeksy zawsze liczymy od 0!!!!!**

#### 5. Łączenie komórek
```xml  
<Button Text="Zaloguj" Grid.ColumnSpan="2" Grid.RowSpan="3" />
``` 

Element (Button) rozciąga się na dwie sąsiadujące kolumny i trzy rzędy. Używane często do centrowania nagłówków lub przycisków w stopce albo jak cos jest mega duze i musimy miec mega duzo miejsca na to.

#### 💡 Przykład Kodu XAML (Formularz)
Wszystko opisane wyżej w jednym kodzie:



```xml
 <Grid>
     <Grid.RowDefinitions>
         <RowDefinition Height="50" />
         <RowDefinition Height="50" />
         <RowDefinition Height="Auto" />
         <RowDefinition Height="Auto" />
         <RowDefinition Height="*" />
     </Grid.RowDefinitions>

     <Grid.ColumnDefinitions>
         <ColumnDefinition Width="*" />
         <ColumnDefinition Width="2*" />
     </Grid.ColumnDefinitions>

     <Label 
     Text="Formularz"
     FontSize="60"
     Grid.Row="0" 
     Grid.RowSpan="2"
     Grid.Column="0" 
     Grid.ColumnSpan="2" 
     HorizontalOptions="Center"/>

     <Label Text="Nazwa Użytkownika" Grid.Row="2" Grid.Column="0"  />
     <Entry Placeholder="Wpisz nazwę" Grid.Row="2" Grid.Column="1"  />

     <Label Text="Hasło" Grid.Row="3" Grid.Column="0" />
     <Entry IsPassword="True" Placeholder="Podaj hasło" Grid.Row="3" Grid.Column="1"  />

     <Button 
     Text="Zaloguj" 
     Grid.Row="4" 
     Grid.Column="0" 
     Grid.ColumnSpan="2" 
     VerticalOptions="Start"    
    
     />

 </Grid>

```

### StackLayout
StackLayout układa elementy jeden po drugim w jednej linii (pionowej lub poziomej). Nie trzeba ustawiac zadnych rzedow itp jak w gridze.

### Kluczowe Wymiary i Atrybuty (Dla Kontenera)

| Właściwość | Wartość | Działanie |
| :--- | :--- | :--- |
| **`Orientation`** | `Vertical`, `Horizontal` | Kierunek stosu. **Vertical (pionowo) jest domyślnie** |
| **`Spacing`** | Liczba (np. `10`) | Odstęp **pomiędzy** elementami wewnątrz stosu. |
| **`Padding`** | Liczba lub `L,T,R,B` | Margines wewnętrzny stosu (odstęp od krawędzi kontenera do treści). |

### Atrybuty dla elementów w środku StackLayout
W StackLayout każdy element w środku może mieć własne `Options`:
* **`HorizontalOptions`** / **`VerticalOptions`**:
    * `Start`, `Center`, `End` – pozycjonowanie.
    * `Fill` – rozciągnij na maxa.
    * `AndExpand` – (np. `CenterAndExpand`,`FillAndExpand`) – zajmij całą wolną przestrzeń i ustaw się na środku.

---

### Szczegółowo (Analiza właściwości)

#### 1. Kierunek (Orientation)
```xml
<StackLayout Orientation="Horizontal">
```
Elementy będą stały w jednym rzędzie obok siebie. Jak damy `Vertical` to jeden pod drugim.

#### 2. Odstępy (Spacing i Padding)
```xml
<StackLayout Spacing="20" Padding="10, 20, 10, 20">
```
Spacing="20" robi 20px przerwy między elementami. Padding ustawia marginesy wewnętrzne: 10px z boków (lewo prawo) i 20px z góry i z dołu.

#### 3. Wyrównanie (Options)
```xml
<Label Text="Hejka" VerticalOptions="CenterAndExpand" />
```
W tym wypadku mówimy Labelowi coś typu: "Weź tyle miejsca w pionie (vertical) ile zostalo wolnego i na srodku tego miejsca wstaw tekst.

#### 💡 Przykład Kodu XAML (StackLayout (jest on bez sensu tylko jako przyklad xd))

```xml
<StackLayout 
    Orientation="Horizontal" 
    Spacing="50" 
    Padding="20"
    BackgroundColor="WhiteSmoke">

    <Label Text="Góra" VerticalOptions="Start" />

    <Label Text="Środek" VerticalOptions="Center" />

    <Label Text="Dół" VerticalOptions="End" />

    <Button 
        Text="Rozciągnięty" 
        HorizontalOptions="FillAndExpand" 
        VerticalOptions="FillAndExpand" />

</StackLayout>
```
#### Wytłumaczenie kodu:
 Ustawiamy StackLayout na Horizontal czyli poziomy, wiec elementy ukladaja sie od lewej do prawej. Jako ze mamy 4 elementy (3 Labele i przycisk) to powstaja nam tak jakby 4 kolumny obok siebie (duzo miejsca jesli chodzi o wysokosc i malo szerokosci). Uzywamy VerticalOptions Start Center i End przez co pierwszy label ustawia sie na samej gorze swojej kolumny, drugi na srodku swojej, a trzeci na samym dole swojej. Przycisk w obu plaszcyznach rezerwuje cale pozostale miejsce i ustawia sie na srodku tego miejsca. 


### AbsoluteLayout
Ten Layout daje nam **całkowitą dowolność**, ale najwięcej z nim roboty. Tu ustawiamy wszystko sami.

**MOŻEMY TYM NP. NAKLADAC NA SIEBIE ELEMENTY!** (moze sie przyda akurat)

 Właściwość | Wartość | Działanie |
| :--- | :--- | :--- |
| **`LayoutBounds`** | `X`, `Y`, `Szer`,`Wys` |  **Określa pozycję i rozmiar elementu.** |
| **`LayoutFlags`** | `None`, `All`, `PositionProportional` | Ustala czy liczby sa sztywne czy sa np. procentami |

### Szczegółowo (Analiza właściwości)

#### 1. Ustawienie stałej pozycji i rozmiaru
```xml
<BoxView Color="Red" AbsoluteLayout.LayoutBounds="50, 50, 100, 100" />
```
Element zostanie narysowany dokładnie 50 jednostek od lewej (X) i 50 jednostek od góry (Y). Ma sztywny rozmiar 100x100.


#### 2. Nakładanie elementów (Kolejność warstw)

```xml
<BoxView Color="Red" AbsoluteLayout.LayoutBounds="50, 50, 100, 100" />
```
Kolejnosc w kodzie decyduje o tym co wyswietla sie wyzej. Jesli 2 elementy beda miec te same wspolrzedne, to ten element ktory jest **NIZEJ W KODZIE** (później) będzie przykrywał ten co jest wyżej. 


```xml
<AbsoluteLayout BackgroundColor="WhiteSmoke">
    
    <BoxView Color="Red" 
             AbsoluteLayout.LayoutBounds="50, 50, 100, 100" />

    <BoxView Color="Blue" 
             AbsoluteLayout.LayoutBounds="80, 80, 100, 100" />

    <Label Text="WARSTWA PRZYKRYWAJACA  " 
           TextColor="Black"
           FontAttributes="Bold"
           AbsoluteLayout.LayoutBounds="60, 100, 200, 40" />

</AbsoluteLayout>
```
