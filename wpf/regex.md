# Regexy

Wyrażenia regularne w .NET/WPF służą do sprawdzania, filtrowania i wyciągania danych z tekstu. Można ich używać np. do walidacji TextBox czy filtrowania elementów w TreeView.

## Kod

```xml
<TextBox x:Name="inputBox" TextChanged="inputBox_TextChanged"/>
<TextBlock x:Name="resultText"/>
```

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

---

# ToolBar – paski narzędziowe

Kontener przycisków lub innych elementów w górnej części okna. Można je układać w ToolBarTray, obsługiwać kliknięcia w C#.

## Kod

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

---

# Menu / ContextMenu – menu górne i podręczne

## Menu (górne)

Stały pasek poleceń u góry okna. Zawiera główne funkcje aplikacji, zawsze widoczne i dostępne zwykłym kliknięciem.

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


## ContextMenu (podręczne)

Menu wywoływane dopiero po kliknięciu PPM. Pojawia się dokładnie przy elemencie, oferując akcje związane z tym konkretnym miejscem.

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

---

# TreeView – struktury drzewiaste

Kontrolka do wyświetlania hierarchicznych danych, węzły mogą mieć dzieci, można ją uzupełniać dynamicznie lub przez XAML.

## Kod

### Statyczne TreeView

```xml
<TreeView x:Name="myTree">
  <TreeViewItem Header="Root">
    <TreeViewItem Header="Child 1"/>
    <TreeViewItem Header="Child 2"/>
  </TreeViewItem>
</TreeView>
```

### Dynamiczne dodawanie w C#
```xml
<Button Content="Add Node" Click="AddDynamic_Click"/>
```

```cs
private void AddDynamic_Click(object sender, RoutedEventArgs e)
{
    myTree.Items.Add(new TreeViewItem { Header = "New Node" });
}
```

### TreeView z ContextMenu

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
