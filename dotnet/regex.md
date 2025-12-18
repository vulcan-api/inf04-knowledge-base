# Regexy

Powrót na start -> [Start](./root.md)

Regexy służą do sprawdzania, czy tekst pasuje do określonego wzoru (np. tylko cyfry, email, litery itp).

## Kod

Mamy TextBox. Ktoś w niego coś pisze. My sprawdzamy, czy to są wyłącznie cyfry za każdym razem jak się tekst zmieni.

```xml
<TextBox x:Name="inputBox" TextChanged="inputBox_TextChanged"/>
<TextBlock x:Name="resultText"/>
```

W logice C# wpisujemy wzór dla tekstu i za pomocą if i w środku funkcję Regex.IsMatch tekst wpisujemy jako pierwszy argument a wzór jako drugi i tak sprawdzamy czy nasz tekst pasuje do wzoru.

| Wzór / Symbol | Znaczenie                                   |
| ------------- | ------------------------------------------- |
| `^`           | początek tekstu                             |
| `$`           | koniec tekstu                               |
| `.`           | dowolny znak oprócz nowej linii             |
| `[]`          | zestaw znaków, np. `[abc]`                  |
| `[^]`         | negacja zestawu, np. `[^0-9]`               |
| `()`          | grupowanie wzorów lub wyciąganie fragmentów |
| `(?:)`        | grupa bez zapisywania dopasowania           |
| `(?<name>)`   | nazwana grupa                               |
| `\|`          | alternatywa („lub”)                         |
| `\`           | ucieczka metaznaków                         |
| `\d`          | cyfra 0–9                                   |
| `\D`          | nie-cyfra                                   |
| `\w`          | słowo (litery/cyfry/_)                      |
| `\W`          | nie-`\w`                                    |
| `\s`          | biały znak (spacja, tab, enter)             |
| `\S`          | nie-`\s`                                    |
| `*`           | 0 lub więcej wystąpień                      |
| `+`           | 1 lub więcej wystąpień                      |
| `?`           | 0 lub 1 wystąpienie                         |
| `{n}`         | dokładnie n wystąpień                       |
| `{n,}`        | n lub więcej wystąpień                      |
| `{n,m}`       | od n do m wystąpień                         |

Przykłady regexów:

| Wzór                                               | Co dopasowuje      | Przykłady                              |
| -------------------------------------------------- | ------------------ | -------------------------------------- |
| `^\d+$`                                            | tylko cyfry        | `12345` ✅, `12a3` ❌                 |
| `^[A-Za-z]+$`                                      | tylko litery       | `Hello` ✅, `Hello123` ❌             |
| `^\w+$`                                            | litery, cyfry, `_` | `user_1` ✅, `user-name` ❌           |
| `^\S+$`                                            | bez spacji         | `NoSpace` ✅, `Has Space` ❌          |
| `^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$` | email              | `test@example.com` ✅, `test@.com` ❌ |

```cs
private void inputBox_TextChanged(object sender, TextChangedEventArgs e)
{
    string pattern = @"^\d+$"; // tylko cyfry
    if (Regex.IsMatch(inputBox.Text, pattern))
        resultText.Text = "Poprawne!";
    else
        resultText.Text = "Niepoprawne!";
}
```

Użytkownik wpisuje tekst w TextBox.
Zdarzenie TextChanged wywołuje metodę w C#.
W metodzie definiujemy wzór (pattern) i używamy Regex.IsMatch, aby sprawdzić, czy tekst pasuje do wzoru.
Jeśli tekst pasuje, pokazujemy „Poprawne!”, w przeciwnym razie „Niepoprawne!”.
Regex pozwala tworzyć elastyczne reguły dopasowania: cyfry, litery, spacje, email itp.
