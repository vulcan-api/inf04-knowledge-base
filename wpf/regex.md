# Regexy

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

---

# ToolBar – paski narzędziowe

ToolBar to kontener na przyciski lub inne elementy, zwykle w górnej części okna. Służy do szybkiego dostępu do akcji, np „Open”, „Save”.

## Kod

ToolBarTray - pojemnik na ToolBary (np obok siebie, jeden pod drugim).
DockPanel.Dock="Top" ustawia cały pasek na górze okna.
ToolBar - pojedynczy pasek przycisków lub kontrolek (np Button, ComboBox, TextBox).
Atrybut Click="Open_Click" mówi: „Open clicked”.

```xml
<ToolBarTray DockPanel.Dock="Top">
  <ToolBar>
    <Button Click="Open_Click">Open</Button>
    <Button Click="Save_Click">Save</Button>
  </ToolBar>
</ToolBarTray>
```

```cs
private void Open_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Open clicked");
private void Save_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Save clicked");
```

Użytkownik klika przycisk na pasku ToolBar.
Wydarzenie Click (Open_Click) wywołuje przypisaną metodę w C# i pokazuje "Open clicked"
Można dodawać dowolne kontrolki do ToolBar i przypisywać im własne akcje.

---

# Menu / ContextMenu – menu górne i podręczne

W WPF mamy dwa główne rodzaje menu:
- Menu (górne) – pasek poleceń u góry okna, zawsze widoczny.
- ContextMenu (podręczne) – menu wywoływane prawym przyciskiem myszy, pojawia się przy konkretnym elemencie.

## Menu (górne)

Używa się kontrolki Menu i MenuItem.
Menu to kontener dla wszystkich pozycji menu.
MenuItem to pojedyncza pozycja lub podmenu.
Atrybut Header ustawia tekst widoczny w menu.
_ w Header (_File) tworzy skrót klawiszowy Alt+F.
Atrybut Click="Open_Click" mówi: „Open clicked”.

```xml
<Menu DockPanel.Dock="Top">
  <MenuItem Header="_File">
    <MenuItem Header="Open" Click="Open_Click"/>
    <MenuItem Header="Exit" Click="Exit_Click"/>
  </MenuItem>
</Menu>
```

```cs
private void Open_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Open clicked");
private void Exit_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Exit clicked");
```

Użytkownik klika w „File”.
Pojawia się podmenu z „Open” i „Exit”.
Kliknięcie wywołuje metodę w C#.

## ContextMenu (podręczne)

Wywoływane tylko po kliknięciu prawym przyciskiem myszy.
Pojawia się dokładnie przy elemencie, do którego jest przypisane.
Tworzy się poprzez Element.ContextMenu i ContextMenu wewnątrz niego.
MenuItem działa tak samo jak w górnym menu – Click wywołuje metodę w C#.

```xml
<Button Content="Right Click Me">
  <Button.ContextMenu>
    <ContextMenu>
      <MenuItem Header="Option 1" Click="Option1_Click"/>
      <MenuItem Header="Option 2" Click="Option2_Click"/>
    </ContextMenu>
  </Button.ContextMenu>
</Button>
```

```cs
private void Option1_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Option 1 clicked");
private void Option2_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Option 2 clicked");
```

Użytkownik kliknął prawym przyciskiem na przycisk.
Pojawia się menu z opcjami „Option 1” i „Option 2”.
Kliknięcie wywołuje metodę w C#.

---

# TreeView – struktury drzewiaste

TreeView to kontrolka służąca do wyświetlania danych w hierarchii, czyli „drzewa”.
Każdy węzeł (TreeViewItem) może mieć dzieci, dzięki czemu można tworzyć zagnieżdżone struktury.

## Kod

### Statyczne TreeView

Tworzymy je bezpośrednio w XAML.
Węzły (TreeViewItem) są zdefiniowane od razu, np. root + dzieci.

```xml
<TreeView x:Name="myTree">
  <TreeViewItem Header="Root">
    <TreeViewItem Header="Child 1"/>
    <TreeViewItem Header="Child 2"/>
  </TreeViewItem>
</TreeView>
```

„Root” to węzeł główny.
„Child 1” i „Child 2” są dziećmi.
Użytkownik może rozwijać i zwijać węzły klikając strzałkę obok.

### Dynamiczne dodawanie w C#

Możemy dodawać węzły w C# w czasie działania programu.
Typowy scenariusz: przycisk „Add Node” dodaje nowy element.

```xml
<Button Content="Add Node" Click="AddDynamic_Click"/>
```

```cs
private void AddDynamic_Click(object sender, RoutedEventArgs e)
{
    myTree.Items.Add(new TreeViewItem { Header = "New Node" });
}
```

Użytkownik klika przycisk.
Metoda w C# tworzy nowy TreeViewItem.
Element jest dodawany do głównej kolekcji węzłów (myTree.Items).

### TreeView z ContextMenu

Możemy przypisać menu podręczne do całego TreeView.
Menu pojawia się po kliknięciu prawym przyciskiem myszy.
Można np. dodać lub usunąć węzeł.

```xml
// opcje pojawiają się po kliknięciu PPM
<TreeView x:Name="treeWithMenu">
  <TreeView.ContextMenu>
    <ContextMenu>
      <MenuItem Header="Add Node" Click="AddNode_Click"/>
      <MenuItem Header="Remove Node" Click="RemoveNode_Click"/>
    </ContextMenu>
  </TreeView.ContextMenu>
</TreeView>
```

```cs
private void AddNode_Click(object sender, RoutedEventArgs e)
{
    treeWithMenu.Items.Add(new TreeViewItem { Header = "Dynamic Node" });
}

private void RemoveNode_Click(object sender, RoutedEventArgs e)
{
    if (treeWithMenu.Items.Count > 0)
        treeWithMenu.Items.RemoveAt(treeWithMenu.Items.Count - 1);
}
```

Użytkownik kliknął PPM na TreeView.
Pojawia się menu z opcjami „Add Node” i „Remove Node”.
Kliknięcie wywołuje metodę w C#: dodaje lub usuwa węzeł.
