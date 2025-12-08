# Kontrolki

## TextBox
Służy do wprowadzania i edycji niesformatowanego tekstu przez użytkownika. Podstawowa kontrolka formularzy.

### Przykład kodu
```xml
<TextBox
  Name="tbMultiLine"
  TextWrapping="Wrap"
  AcceptsReturn="True"
  VerticalScrollBarVisibility="Visible"
>
    Przykładowy tekst, który użytkownik może edytować
</TextBox>
```

### Właściwości
- `Name` - chyba wiadomo
- `TextWrapping="Wrap"` - zawija linie tekstu, jak się nie mieści zawija do nowego wiersza i automatycznie rozszerza TextBoxa, żeby uwzględnić miejsce dla nowego wiersza
- `AcceptsReturn="True"` - powoduje, że po wciśnięciu RETURN (enter) zostanie wstawiony nowy wiersz, automatycznie rozszerza
- `VerticalScrollBarVisibility="Visible"` - dodaje pasek przewijania do TextBox, jeśli TextBox rozszerza się poza rozmiar ramy lub okna, który go otacza

---

## TextBlock
Służy do wyświetlania tekstu na ekranie. Jest lżejszy od TextBoxa (zużywa mniej zasobów), ale użytkownik nie może edytować jego zawartości.

### Przykład kodu
```xml
<TextBlock
  Text="Przykładowy tekst"
  TextWrapping="Wrap"
  TextTrimming="CharacterEllipsis"
  Foreground="Blue"
  FontSize="14"
/>
```

### Właściwości
- `Text` - Treść wyświetlana w kontrolce.
- `TextWrapping="Wrap"` - Zawija tekst do nowej linii, jeśli nie mieści się w szerokości kontrolki.
- `TextTrimming="CharacterEllipsis"` - Jeśli tekst się nie mieści, ucina go i dodaje trzy kropki (...) na końcu.
- `Foreground="Blue"` - Kolor czcionki.
- `FontSize="14"` - Rozmiar czcionki w pikselach (device independent pixels).

---

## Button
Przycisk po prostu c:

### Przykład kodu
```xml
<Button
  Content="Zatwierdź"
  Click="Button_Click"
  IsDefault="True"
  IsEnabled="False"
/>
```

### Właściwości
- `Content` - Zawartość przycisku (może to być tekst, ale też np. obrazek lub inna kontrolka).
- `Click="Button_Click"` - Nazwa metody w kodzie C# (event handler), która wykona się po kliknięciu.
- `IsDefault="True"` - Sprawia, że wciśnięcie klawisza ENTER na klawiaturze automatycznie klika ten przycisk (np. w formularzach logowania).
- `IsEnabled="False"` - Wyłącza przycisk (jest wyszarzony i nie można go kliknąć).

### Obsługa zdarzenia w C#
Potem w .xaml.cs (metoda)
```csharp
private void Button_Click(object sender, RoutedEventArgs e)
{
    //co ma robic ta funkcja
}
```

---

## CheckBox
Pozwala użytkownikowi wybrać opcję typu "Tak/Nie" (True/False). Można zaznaczyć wiele CheckBoxów niezależnie od siebie.

### Przykład kodu
```xml
<CheckBox
  Content="Zgadzam się na warunki"
  IsChecked="True"
/>
```

### Właściwości
- `Content` - Tekst wyświetlany obok kwadracika.
- `IsChecked="True"` - Określa stan zaznaczenia (True = zaznaczony, False = odznaczony).

---

## RadioButton
Służy do wyboru **tylko jednej** opcji z grupy. Zaznaczenie jednego elementu automatycznie odznacza pozostałe w tej samej grupie.

### Przykład kodu
```xml
<StackPanel>
  <RadioButton GroupName="Plec" Content="Kobieta" />
  <RadioButton GroupName="Plec" Content="Mężczyzna" IsChecked="True" />
</StackPanel>
```

### Właściwości
- `GroupName="Plec"` - Kluczowa właściwość. Wszystkie RadioButtony o tej samej nazwie grupy działają razem (tylko jeden może być wybrany).
- `IsChecked="True"` - Domyślnie zaznacza tę opcję przy uruchomieniu programu.
- `Content` - Tekst opcji.

---

## ComboBox
Rozwijana lista wyboru. Pozwala użytkownikowi wybrać jedną wartość z listy, oszczędzając miejsce na ekranie (widać tylko wybrany element, reszta po rozwinięciu).

### Przykład kodu
```xml
<ComboBox
  IsEditable="True"
  SelectedIndex="0"
  Text="Wybierz opcję"
>
  <ComboBoxItem Content="Opcja 1" />
  <ComboBoxItem Content="Opcja 2" />
</ComboBox>
```

### Właściwości
- `IsEditable="True"` - Pozwala użytkownikowi wpisać własną wartość, której nie ma na liście (działa trochę jak TextBox połączony z listą).
- `SelectedIndex="0"` - Ustawia domyślnie wybrany element (0 to pierwszy element listy).
- `ComboBoxItem` - Pojedynczy element wewnątrz listy rozwijanej.

---

## ListBox
Wyświetla listę elementów w pionie. W przeciwieństwie do ComboBoxa, lista jest cały czas widoczna.

### Przykład kodu
```xml
<ListBox
  SelectionMode="Multiple"
  Height="100"
>
  <ListBoxItem Content="Element A" />
  <ListBoxItem Content="Element B" />
</ListBox>
```

### Właściwości
- `SelectionMode="Multiple"` - Pozwala użytkownikowi zaznaczyć więcej niż jeden element (np. trzymając Ctrl). Domyślnie jest "Single" (do zaznaczenia tylko jeden element).
- `Height="100"` - Ustala sztywną wysokość listy (jeśli elementów jest więcej, pojawi się pasek przewijania).

---

## ListView
Bardziej zaawansowana lista, zoptymalizowana do wyświetlania danych w kolumnach (widok szczegółowy / GridView).

### Przykład kodu
```xml
<ListView ItemsSource="{Binding Users}">
  <ListView.View>
    <GridView>
      <GridViewColumn Header="Imię" DisplayMemberBinding="{Binding Name}" />
      <GridViewColumn Header="Wiek" DisplayMemberBinding="{Binding Age}" Width="50"/>
    </GridView>
  </ListView.View>
</ListView>
```

### Właściwości
- `ItemsSource="{Binding Users}"` - Źródło danych (lista obiektów w kodzie C#, którą wyświetlamy).
- `GridView` - Tryb widoku, który pozwala na definiowanie kolumn.
- `GridViewColumn Header="..."` - Definiuje nagłówek kolumny.
- `DisplayMemberBinding` - Wskazuje, którą właściwość obiektu (np. Name) wyświetlić w tej kolumnie.

---

## DataGrid
Potężna tabela do wyświetlania i edycji dużych zbiorów danych. Przypomina Excela.

### Przykład kodu
```xml
<DataGrid
  ItemsSource="{Binding UsersList}"
  AutoGenerateColumns="False"
  CanUserAddRows="False"
  AlternatingRowBackground="LightGray"
>
  <DataGrid.Columns>
    <DataGridTextColumn Header="Imię" Binding="{Binding Name}" Width="*" />
    <DataGridTextColumn Header="Wiek" Binding="{Binding Age}" Width="50" />
    <DataGridCheckBoxColumn Header="Admin" Binding="{Binding IsAdmin}" />
  </DataGrid.Columns>
</DataGrid>
```

### Właściwości
- `ItemsSource="{Binding UsersList}"` - Źródło danych (lista obiektów C#).
- `AutoGenerateColumns="False"` - Kluczowe! "False" oznacza, że sami decydujemy jakie kolumny wyświetlić (jak w kodzie wyżej). "True" wrzuciłoby wszystko jak leci.
- `CanUserAddRows="False"` - Usuwa pusty wiersz na dole tabeli (użytkownik nie może dodawać nowych rekordów wpisując w puste pole).
- `AlternatingRowBackground="LightGray"` - Co drugi wiersz ma szare tło (tzw. zebra), poprawia czytelność.
- `DataGridTextColumn / CheckBoxColumn` - Typy kolumn. "Header" to nagłówek, "Binding" to dane z obiektu.
- `Width="*"` - Kolumna rozciąga się, zajmując całe pozostałe wolne miejsce.

---

## DockPanel
Kontener układu, który "przykleja" (dokuje) elementy potomne do krawędzi: Góry, Dołu, Lewej lub Prawej.

### Przykład kodu
```xml
<DockPanel LastChildFill="True">
  <Button DockPanel.Dock="Top" Content="Menu" />
  <Button DockPanel.Dock="Bottom" Content="Stopka" />
  <TextBox Text="Środek" />
</DockPanel>
```

### Właściwości
- `LastChildFill="True"` - Ostatni element w kodzie (tutaj TextBox) automatycznie rozciągnie się na całą pozostałą wolną przestrzeń pośrodku, ewentualnie można ustawić false.
- `DockPanel.Dock="Top"` - Właściwość doczepiana (Attached Property), mówi rodzicowi, do której krawędzi przykleić ten konkretny element.

---

## WrapPanel
Kontener, który układa elementy jeden obok drugiego (domyślnie poziomo). Gdy brakuje miejsca w linii, przenosi element do nowego wiersza.

### Przykład kodu
```xml
<WrapPanel Orientation="Horizontal" ItemWidth="100">
  <Button Content="1" />
  <Button Content="2" />
  <Button Content="3" />
</WrapPanel>
```

### Właściwości
- `Orientation="Horizontal"` - Elementy układają się od lewej do prawej (domyślne). "Vertical" układałoby w kolumnach z góry na dół.
- `ItemWidth="100"` - Wymusza stałą szerokość dla wszystkich elementów wewnątrz panelu (opcjonalne).
