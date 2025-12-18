
# Walidacja Formularzy w Xamarin.Forms (Kompendium)

Powrót na start -> [Start](./root.md)

## 1. Wstęp

Walidacja danych w Xamarin.Forms (w podejściu egzaminacyjnym Code-Behind) polega na przechwyceniu danych z kontrolek, sprawdzeniu ich poprawności w C# i poinformowaniu użytkownika o wyniku.

---

## 2. Przygotowanie Widoku (XAML)

Dobre przygotowanie XAML to połowa sukcesu. Ustawienie odpowiedniej klawiatury ułatwia sprawdzanie danych (np. użytkownik nie wpisze liter w polu wieku, jeśli klawiatura jest numeryczna).

### Kluczowe właściwości kontrolek

| Atrybut | Wartość | Opis / Zastosowanie |
| :--- | :--- | :--- |
| `x:Name` | np. `EmailEntry` | **Konieczne**, aby widzieć kontrolkę w pliku `.cs`. |
| `Keyboard` | `Numeric` | Klawiatura tylko z cyframi (wiek, ilość, rok). |
| `Keyboard` | `Email` | Klawiatura z łatwym dostępem do `@` i `.com`. |
| `Keyboard` | `Telephone` | Klawiatura telefoniczna. |
| `IsPassword` | `True` | Zamienia znaki na kropki (hasła). |
| `Placeholder` | np. `wpisz wiek` | Tekst zastępczy (podpowiedź). |

### Gotowy szablon formularza (XAML)

```xml
<StackLayout Padding="20" Spacing="15">
    
    <Label Text="Adres E-mail:" FontSize="18"/>
    <Entry x:Name="EmailInput" Keyboard="Email" Placeholder="np. jan@wp.pl"/>

    <Label Text="Wiek:" FontSize="18"/>
    <Entry x:Name="AgeInput" Keyboard="Numeric" Placeholder="0"/>

    <Label Text="Hasło:" FontSize="18"/>
    <Entry x:Name="PassInput" IsPassword="True"/>
    
    <Label Text="Powtórz Hasło:" FontSize="18"/>
    <Entry x:Name="PassRepeatInput" IsPassword="True"/>

    <StackLayout Orientation="Horizontal">
        <CheckBox x:Name="RulesCheck"/>
        <Label Text="Akceptuję regulamin" VerticalOptions="Center"/>
    </StackLayout>

    <Button Text="Zarejestruj" Clicked="OnValidate" BackgroundColor="Teal" TextColor="White"/>
    
    <Label x:Name="ErrorLabel" TextColor="Red" FontSize="Medium" HorizontalOptions="Center"/>

</StackLayout>
```

---

## 3. Logika Walidacji (C#)

W pliku `.xaml.cs` (Code Behind) tworzymy metodę obsługującą przycisk. Poniżej zestaw najczęściej potrzebnych "klocków" walidacyjnych.

### 3.1. Sprawdzanie czy pole jest puste

Używaj `string.IsNullOrWhiteSpace()`. Chroni to przed sytuacją, gdy `Text` jest nullem lub ktoś wpisał same spacje.

```csharp
if (string.IsNullOrWhiteSpace(EmailInput.Text))
{
    ErrorLabel.Text = "Uzupełnij adres e-mail!";
    return; // return przerywa funkcję - dalszy kod się nie wykona
}
```

### 3.2. Bezpieczna walidacja liczby (`int.TryParse`)

To najważniejszy punkt na egzaminie. Bezpośrednie rzutowanie (`int.Parse`) wyrzuci błąd aplikacji, jeśli pole jest puste lub zawiera literę.

```csharp
// Tworzymy zmienną na wynik
int wiek; 

// TryParse próbuje zamienić tekst na liczbę.
// Jeśli się uda -> zwraca true i wpisuje liczbę do zmiennej 'wiek'.
// Jeśli się nie uda -> zwraca false.
if (!int.TryParse(AgeInput.Text, out wiek))
{
    ErrorLabel.Text = "Wiek musi być liczbą całkowitą!";
    return;
}

// Teraz możemy bezpiecznie używać zmiennej 'wiek'
if (wiek < 18)
{
    ErrorLabel.Text = "Musisz być pełnoletni!";
    return;
}
```

### 3.3. Walidacja Haseł

Sprawdzamy dwa warunki: długość i zgodność powtórzenia.

```csharp
string p1 = PassInput.Text;
string p2 = PassRepeatInput.Text;

// Zabezpieczenie przed nullem
if (string.IsNullOrEmpty(p1))
{
    ErrorLabel.Text = "Wpisz hasło!";
    return;
}

if (p1.Length < 5)
{
    ErrorLabel.Text = "Hasło jest za krótkie (min. 5 znaków)!";
    return;
}

if (p1 != p2)
{
    ErrorLabel.Text = "Hasła nie są identyczne!";
    return;
}
```

### 3.4. Walidacja E-maila (Prosta i Regex)

**Wersja podstawowa (często wystarcza):**
```csharp
if (!EmailInput.Text.Contains("@"))
{
    ErrorLabel.Text = "To nie jest poprawny e-mail (brak @)";
    return;
}
```

**Wersja zaawansowana (Regex):**
Wymaga: `using System.Text.RegularExpressions;`


```csharp
// Wzór: coś + @ + coś + kropka + 2-3 znaki
string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"; 

if (!Regex.IsMatch(EmailInput.Text, pattern))
{
    ErrorLabel.Text = "Błędny format e-maila!";
    return;
}
```

### 3.5. CheckBox i Switch

Te kontrolki nie mają właściwości `Text`. Sprawdzamy `IsChecked` lub `IsToggled`.

```csharp
if (RulesCheck.IsChecked == false)
{
    ErrorLabel.Text = "Musisz zaakceptować regulamin.";
    return;
}
```

---

## 4. Wyświetlanie komunikatów

### Sposób A: Label (Statyczny)
Najlepszy do prostych komunikatów w formularzu.

```csharp
// Błąd
ErrorLabel.TextColor = Color.Red;
ErrorLabel.Text = "Błąd walidacji!";

// Sukces
ErrorLabel.TextColor = Color.Green;
ErrorLabel.Text = "Dane poprawne. Zapisano.";
```

### Sposób B: DisplayAlert (Okienko)
Wyskakujące okienko, które trzeba "okejnąć".

```csharp
// Składnia: Tytuł, Treść, Przycisk
DisplayAlert("Błąd", "Hasła się różnią", "OK");
```

---

## 5. Kompletny "Gotowiec" (Metoda Scalona)

Możesz skopiować tę strukturę do każdego zadania z formularzem.

```csharp
private void OnValidate(object sender, EventArgs e)
{
    // 1. POBRANIE DANYCH (z Trim() usuwającym spacje)
    string email = EmailInput.Text?.Trim();
    string pass = PassInput.Text;
    string pass2 = PassRepeatInput.Text;
    
    // 2. CZYSZCZENIE KOMUNIKATÓW
    ErrorLabel.Text = "";
    ErrorLabel.TextColor = Color.Red;

    // 3. WALIDACJA PUSTYCH PÓL
    if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass))
    {
        ErrorLabel.Text = "Wypełnij wszystkie pola!";
        return;
    }

    // 4. WALIDACJA LOGICZNA
    if (!email.Contains("@"))
    {
        ErrorLabel.Text = "Brak znaku @ w mailu!";
        return;
    }

    if (pass != pass2)
    {
        ErrorLabel.Text = "Hasła są różne!";
        return;
    }

    // 5. WALIDACJA CHECKBOXA
    if (!RulesCheck.IsChecked)
    {
        DisplayAlert("Uwaga", "Zaakceptuj regulamin!", "OK");
        return;
    }

    // 6. SUKCES
    ErrorLabel.TextColor = Color.Green;
    ErrorLabel.Text = $"Witaj {email}, konto założone!";
    
    // Opcjonalnie: wyczyść pola
    // PassInput.Text = "";
}
```
