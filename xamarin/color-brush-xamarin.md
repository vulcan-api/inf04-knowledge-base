# Xarmarin Color Brush

Powrót na start -> [Start](../root)

## 1. Wprowadzenie

W Xamarin.Forms do stylowania elementów UI można używać zarówno typu `Color`, jak i `Brush`.

* `Color` – reprezentuje pojedynczy kolor (RGB/ARGB)
* `Brush` – bardziej ogólne pojęcie, które może reprezentować:

  * `SolidColorBrush`
  * `LinearGradientBrush`
  * `RadialGradientBrush`

W praktyce bardzo często zachodzi potrzeba:

* zamiany `Color` na `Brush`
* odczytania `Color` z `Brush` (jeśli jest to możliwe)

Ten dokument opisuje oba kierunki konwersji wraz z przykładami.

---

## 2. Konwersja `Color` → `Brush`

### 2.1. Najprostszy przypadek – `SolidColorBrush`

Każdy obiekt `Color` można bezpośrednio opakować w `SolidColorBrush`.

```csharp
Color color = Color.Red;
Brush brush = new SolidColorBrush(color);
```

Alternatywnie (krótsza składnia):

```csharp
Brush brush = Brush.FromColor(Color.Red);
```

### 2.2. Przykład użycia w kontrolce

```csharp
BoxView box = new BoxView
{
    Background = new SolidColorBrush(Color.Blue)
};
```

Lub:

```csharp
BoxView box = new BoxView
{
    Background = Brush.FromColor(Color.Blue)
};
```

---

## 3. Konwersja `Brush` → `Color`

### 3.1. Dlaczego to nie zawsze jest możliwe?

`Brush` jest typem bazowym. Może reprezentować gradient lub inny typ wypełnienia, który **nie ma jednego koloru**.

Dlatego:

* konwersja jest możliwa **tylko dla `SolidColorBrush`**
* dla gradientów należy obsłużyć przypadek braku jednoznacznego koloru

---

### 3.2. Bezpieczna konwersja z użyciem `is`

```csharp
Brush brush = new SolidColorBrush(Color.Green);

if (brush is SolidColorBrush solidBrush)
{
    Color color = solidBrush.Color;
}
```

---

### 3.3. Konwersja z użyciem `as`

```csharp
Brush brush = new SolidColorBrush(Color.Yellow);

SolidColorBrush solidBrush = brush as SolidColorBrush;
if (solidBrush != null)
{
    Color color = solidBrush.Color;
}
```

---

## 4. Przykład uniwersalnej metody pomocniczej

### 4.1. `Color` → `Brush`

```csharp
public static Brush ColorToBrush(Color color)
{
    return new SolidColorBrush(color);
}
```

### 4.2. `Brush` → `Color?`

```csharp
public static Color? BrushToColor(Brush brush)
{
    if (brush is SolidColorBrush solidBrush)
        return solidBrush.Color;

    return null; // np. gradient
}
```

Użycie typu `Color?` (nullable) pozwala bezpiecznie obsłużyć przypadki, gdzie konwersja nie jest możliwa.

---

## 5. Praca z gradientami

Przykład gradientu:

```csharp
Brush gradient = new LinearGradientBrush
{
    StartPoint = new Point(0, 0),
    EndPoint = new Point(1, 0),
    GradientStops = new GradientStopCollection
    {
        new GradientStop(Color.Red, 0.0f),
        new GradientStop(Color.Blue, 1.0f)
    }
};
```

Tego typu `Brush` **nie może** zostać poprawnie skonwertowany na pojedynczy `Color`.

Jeśli potrzebujesz koloru zastępczego (np. pierwszy kolor gradientu):

```csharp
if (brush is LinearGradientBrush linear && linear.GradientStops.Count > 0)
{
    Color fallbackColor = linear.GradientStops[0].Color;
}
```
