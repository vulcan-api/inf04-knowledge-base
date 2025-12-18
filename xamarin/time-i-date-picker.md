# Xamarin - Time & Data Picker
- Powrót na start -> [Start](./root.md)

### Czym są "Pickery"
Pickery są to nic innego jak elementy formularza, które pozwalają na wybranie daty lub czasu z poziomu interfejsu użytkownika. Po stronie XAML będziemy tworzyć proste kontrolki, zaś z poziomu kodu C# możemy łatwo odczytać wybrane przez użytkownika dane.

## Date Picker (Wybór daty)
Date Picker to nic innego jak wybieranie daty z kalendarza - spotykasz się z nim m.in. gdy ustawiasz przypomnienie na jakiś dzień.

### Poniżej znajduje się kod `XAML`, wyświetlający przykładowy Data Picker:
```xml
<Label Text="Wybierz datę:" FontSize="Medium"/>
<DatePicker x:Name="datePicker"/>
```

### Tutaj jest kod `C#` który pobiera datę.
```csharp
DateTime selectedDate = datePicker.Date;
```

**Ważne informacje:**

* `DatePicker.Date` zwraca obiekt typu `DateTime`
* zawiera **tylko datę**, a godzina jest ustawiona domyślnie na `00:00:00`

## Time Picker (Wybór czasu)
Time Picker służy do wybierania godziny i minuty - spotykasz się z nim m.in. gdy ustawiasz budzik w telefonie.

### Poniżej znajduje się kod `XAML`, wyświetlający przykładowy Time Picker
```xml
<Label Text="Wybierz czas:" FontSize="Medium"/>
<TimePicker x:Name="timePicker"/>
```
### Tutaj jest kod `C#` który pobiera czas
```csharp
TimeSpan selectedTime = timePicker.Time;
```

**Ważne informacje:**

* `TimePicker.Time` zwraca **TimeSpan**, a nie `DateTime`
* przechowuje tylko godziny, minuty i sekundy
* nie zawiera informacji o dacie

## Łączenie daty i czasu w jeden obiekt DateTime

Ponieważ:

* `DatePicker` zwraca `DateTime` (bez czasu),
* `TimePicker` zwraca `TimeSpan` (bez daty),

najczęściej łączy się je w jeden obiekt:

```csharp
DateTime combined = selectedDate.Date + selectedTime;
```

W ten sposób otrzymujemy pełną datę i godzinę, np.:
**20.01.2026 9:30:00**

## Walidacja daty i czasu

Walidacja jest bardzo ważnym elementem aplikacji – pozwala upewnić się, że użytkownik wybrał poprawne dane.

### Ograniczenie zakresu dat

```csharp
datePicker.MinimumDate = DateTime.Today;
datePicker.MaximumDate = DateTime.Today.AddYears(1);
```

#### Przykład zastosowania

* nie można wybrać daty z przeszłości,
* rezerwacja maksymalnie na rok do przodu.

### Sprawdzanie czy data i czas nie są z przeszłości

```csharp
DateTime selected = datePicker.Date + timePicker.Time;

if (selected < DateTime.Now)
{
    resultLabel.Text = "Wybrana data i czas są niepoprawne.";
}
```

## Formatowanie daty i czasu

Domyślny format daty zależy od ustawień systemowych urządzenia, jednak bardzo często zachodzi potrzeba własnego formatowania.

### Format w DatePicker

```csharp
datePicker.Format = "dd.MM.yyyy";
```

### Formatowanie w C#

```csharp
//`combined` to plik DateTime z datą oraz czasem
string formatted = combined.ToString("dd.MM.yyyy HH:mm");
```

### Przykładowe formaty

| Format     | Przykład   |
| ---------- | ---------- |
| dd.MM.yyyy | 20.01.2026 |
| HH:mm      | 9:30       |
| yyyy-MM-dd | 2026-01-20 |

## Obsługa zdarzeń

Aplikacja może reagować na zmianę daty lub czasu bez użycia przycisku.

### Reakcja na zmianę daty

`DateSelected` - dedykowane zdarzenie zmiany daty
```csharp
datePicker.DateSelected += (sender, e) =>
{
    DateTime newDate = e.NewDate;
};
```

### Reakcja na zmianę czasu

TimePicker **nie ma dedykowanego zdarzenia** zmiany czasu
```csharp
timePicker.PropertyChanged += (sender, e) =>
{
    if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
    {
        TimeSpan newTime = timePicker.Time;
    }
};
```

## Lokalizacja i kultura

`DatePicker` automatycznie dostosowuje się do ustawień językowych systemu operacyjnego użytkownika.

Możliwe jest także ręczne ustawienie kultury:

```csharp
using System.Globalization;
using System.Threading;

Thread.CurrentThread.CurrentCulture = new CultureInfo("pl-PL");
Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");
```

## Typowe problemy i uwagi

* `DatePicker.Date` **nie zawiera godziny**
* `TimePicker.Time` to `TimeSpan`, a nie `DateTime`
* brak obsługi sekund w `TimePicker`
* różnice stref czasowych przy zapisie danych do bazy lub API

## Przykładowy kod XAML i C# – przykładowa, pełna implementacja

### XAML

```xml
<StackLayout Padding="20" Spacing="20">

    <Label Text="Wybierz datę:" FontSize="Medium"/>
    <DatePicker x:Name="datePicker"/>

    <Label Text="Wybierz czas:" FontSize="Medium"/>
    <TimePicker x:Name="timePicker"/>

    <Button Text="Pokaż wybrane wartości"
            Clicked="OnShowClicked"/>

    <Label x:Name="resultLabel"
           FontSize="Large"
           TextColor="DarkBlue"/>

</StackLayout>
```

### C#

```csharp
private void OnShowClicked(object sender, EventArgs e)
{
    DateTime selectedDate = datePicker.Date;
    TimeSpan selectedTime = timePicker.Time;

    DateTime combined = selectedDate.Date + selectedTime;

    if (combined < DateTime.Now)
    {
        resultLabel.Text = "Wybrana data i czas są niepoprawne.";
        return;
    }

    resultLabel.Text =
        $"Data: {selectedDate:dd.MM.yyyy}\n" +
        $"Czas: {selectedTime}\n" +
        $"Połączone: {combined:dd.MM.yyyy HH:mm}";
}
```
