# Xamarin XAML Styles

- Powrót na start -> [Start](./root.md)

## Czym są style w XAML

Style w XAML służą do definiowania wyglądu kontrolek w jednym miejscu.  
Pozwalają uniknąć powielania kodu i zachować spójny interfejs aplikacji.

## ResourceDictionary – słownik zasobów

`ResourceDictionary` to miejsce, w którym przechowuje się:

* style,
* kolory,
* czcionki,
* rozmiary,
* inne zasoby wielokrotnego użytku.

Najczęściej znajduje się w:

* `App.xaml` (style globalne),
* pliku XAML strony (style lokalne)

## Definicja stylu

Styl składa się z:
- typu kontrolki (`TargetType`)
- zestawu właściwości (`Setter`)

### Przykład

```xml
<!-- Definicja stylu dla przycisków -->
<Style x:Key="PrimaryButtonStyle" TargetType="Button">

    <!-- Kolor tła przycisku -->
    <Setter Property="BackgroundColor" Value="Blue" />

    <!-- Kolor tekstu -->
    <Setter Property="TextColor" Value="White" />

    <!-- Rozmiar czcionki -->
    <Setter Property="FontSize" Value="16" />

</Style>
```

## Definiowanie stylów lokalnych (dla jednej strony)

### Przykład – Style w `ContentPage.Resources`

```xml
<ContentPage.Resources>
    <ResourceDictionary>

        <Style x:Key="HeaderLabelStyle" TargetType="Label">
            <Setter Property="FontSize" Value="Large"/>
            <Setter Property="TextColor" Value="DarkBlue"/>
            <Setter Property="FontAttributes" Value="Bold"/>
        </Style>

    </ResourceDictionary>
</ContentPage.Resources>
```

### Zastosowanie stylu (Styl obowiązuje **tylko na tej stronie**)
```xml
<Label Text="Nagłówek" Style="{StaticResource HeaderLabelStyle}"/>
```

## Style globalne (App.xaml)

Style globalne są dostępne w całej aplikacji.

### Przykład – `App.xaml`

```xml
<Application.Resources>
    <ResourceDictionary>

        <Style x:Key="PrimaryButtonStyle" TargetType="Button">
            <Setter Property="BackgroundColor" Value="DarkBlue"/>
            <Setter Property="TextColor" Value="White"/>
            <Setter Property="CornerRadius" Value="10"/>
        </Style>

    </ResourceDictionary>
</Application.Resources>
```

## Użycie stylu

Styl z kluczem `x:Key` przypisujemy do kontrolki za pomocą właściwości `Style`.

```xml
<!-- Przycisk korzystający ze zdefiniowanego stylu -->
<Button
    Text="Zapisz"                
    Style="{StaticResource PrimaryButtonStyle}" />
```


## Styl globalny (bez klucza)

Styl bez `x:Key` jest automatycznie stosowany do wszystkich kontrolek danego typu.

```xml
<!-- Styl globalny dla wszystkich Label -->
<Style TargetType="Label">

    <!-- Domyślny rozmiar tekstu -->
    <Setter Property="FontSize" Value="14" />

    <!-- Domyślny kolor tekstu -->
    <Setter Property="TextColor" Value="Black" />

</Style>
```

```xml
<!-- Ten Label automatycznie użyje stylu globalnego -->
<Label Text="Tekst przykładowy" />
```

## Dziedziczenie stylów

Style mogą dziedziczyć właściwości z innych stylów przy użyciu `BasedOn`.

```xml
<!-- Styl bazowy dla etykiet -->
<Style x:Key="BaseLabelStyle" TargetType="Label">

    <!-- Podstawowy rozmiar czcionki -->
    <Setter Property="FontSize" Value="14" />

</Style>

<!-- Styl nagłówka dziedziczący po stylu bazowym -->
<Style
    x:Key="HeaderLabelStyle"
    TargetType="Label"
    BasedOn="{StaticResource BaseLabelStyle}">

    <!-- Pogrubiona czcionka -->
    <Setter Property="FontAttributes" Value="Bold" />

</Style>
```

## Użycie stylu dziedziczonego

```xml
<!-- Label używający stylu nagłówka -->
<!-- Tekst wyświetli się w rozmiarze 14 oraz jako pogrubiony -->
<Label
    Text="Nagłówek"
    Style="{StaticResource HeaderLabelStyle}" />
```

## DynamicResource vs StaticResource

### StaticResource

* wartość ładowana raz,
* szybsza,
* nie reaguje na zmiany w czasie działania aplikacji.

```xml
TextColor="{StaticResource PrimaryColor}"
```

### DynamicResource

* reaguje na zmiany zasobów w czasie działania,
* używane np. przy **motywach jasny/ciemny**.

```xml
TextColor="{DynamicResource PrimaryColor}"
```


## Definiowanie kolorów jako zasobów

```xml
<Color x:Key="PrimaryColor">#2C3E50</Color>
<Color x:Key="AccentColor">#3498DB</Color>
```

```xml
<Label TextColor="{StaticResource PrimaryColor}"/>
```

## Style z wyzwalaczami (Triggers)

### Trigger – zmiana wyglądu po warunku
Każdy przycisk domyślnie ma tu kolor "Green", zaś Trigger bierze pod uwagę czy stan przycisku (Property="isEnabled") jest wyłączone (Value="False"), wtedy tło przycisku jest "LightGray"

```xml
<Style TargetType="Button">
    <Setter Property="BackgroundColor" Value="Green"/>

    <Style.Triggers>
        <Trigger TargetType="Button"
                 Property="IsEnabled"
                 Value="False">
            <Setter Property="BackgroundColor" Value="LightGray"/>
        </Trigger>
    </Style.Triggers>
</Style>
```
Krótko:
* Przycisk włączony (isEnabled="True") - tło jest "Green"
* Przycisk wyłaczony (isEnabled="False") - tło jest "LightGray"

## Przykładowa kompletna strona

```xml
<ContentPage.Resources>
    <ResourceDictionary>

        <Color x:Key="PrimaryColor">#2C3E50</Color>

        <Style TargetType="Label">
            <Setter Property="TextColor" Value="{StaticResource PrimaryColor}"/>
            <Setter Property="FontSize" Value="Medium"/>
        </Style>

        <Style TargetType="Button">
            <Setter Property="BackgroundColor" Value="{StaticResource PrimaryColor}"/>
            <Setter Property="TextColor" Value="White"/>
        </Style>

    </ResourceDictionary>
</ContentPage.Resources>