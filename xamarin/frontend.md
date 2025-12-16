# Frontend – Xamarin.Forms i .NET MAUI

# 📝 Spis Treści

1. [Layouty (Układy)](#1-layouty-układy)
    * [Grid (Siatka)](#grid-siatka)
   


---

# 1. Layouty (Układy)

### Grid (Siatka)
 Grid porządkuje elementy w **wierszach** (`RowDefinitions`) i **kolumnach** (`ColumnDefinitions`). **`RowDefinition`** ma atrybut `Height`, a **`ColumnDefinition`** ma atrybut `Width`.

 `Grid.Row` oraz `Grid.Column` indeksują się od 0 a nie od 1.



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