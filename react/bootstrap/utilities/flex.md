Powrót -> [Start](./root.md)

Flex – Bootstrap 5.3

Narzędzia Flex w Bootstrapie umożliwiają szybkie zarządzanie układem, wyrównaniem i rozmiarem elementów przy użyciu mechanizmu Flexbox. Można ich używać m.in. do budowy siatek, nawigacji, komponentów i układów responsywnych.
W bardziej złożonych przypadkach może być konieczne użycie własnego CSS.

Włączanie Flexboxa (Enable flex behaviors)

Aby element stał się kontenerem flexbox, należy użyć klas display:


.d-sm-inline-flex, .d-md-inline-flex itd.

Kierunek elementów (Direction)

Określa kierunek ułożenia elementów flex w kontenerze.

Poziomo (domyślnie):

.flex-row – od lewej do prawej

.flex-row-reverse – od prawej do lewej

Pionowo:

.flex-column – z góry na dół

.flex-column-reverse – z dołu do góry

Dostępne są również warianty responsywne, np. .flex-md-column.

Wyrównanie w osi głównej (Justify content)

Klasy justify-content-* sterują rozmieszczeniem elementów wzdłuż osi głównej
(poziomej przy flex-row, pionowej przy flex-column).

Dostępne wartości:

start – początek (domyślne)

end – koniec

center – środek

between – równe odstępy między elementami

around – odstępy wokół elementów

evenly – równe odstępy między i wokół elementów

Przykład:

<br>
<iframe width="100%" height="250" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;d-flex justify-content-start mb-3 bg-light&quot;&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item 1&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item 2&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item 3&lt;/div&gt;
    &lt;/div&gt;
    &lt;div class=&quot;d-flex justify-content-end mb-3 bg-light&quot;&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item 1&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item 2&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item 3&lt;/div&gt;
    &lt;/div&gt;
    &lt;div class=&quot;d-flex justify-content-center mb-3 bg-light&quot;&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item 1&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item 2&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item 3&lt;/div&gt;
    &lt;/div&gt;
    &lt;div class=&quot;d-flex justify-content-between mb-3 bg-light&quot;&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item 1&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item 2&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item 3&lt;/div&gt;
    &lt;/div&gt;
    &lt;div class=&quot;d-flex justify-content-around mb-3 bg-light&quot;&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item 1&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item 2&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item 3&lt;/div&gt;
    &lt;/div&gt;
    &lt;div class=&quot;d-flex justify-content-evenly bg-light&quot;&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item 1&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item 2&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item 3&lt;/div&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="d-flex justify-content-start">...</div>
<div class="d-flex justify-content-end">...</div>
<div class="d-flex justify-content-center">...</div>
<div class="d-flex justify-content-between">...</div>
<div class="d-flex justify-content-around">...</div>
<div class="d-flex justify-content-evenly">...</div>
```


Każda z tych klas ma wersje responsywne, np. .justify-content-lg-center.

Wyrównanie w osi poprzecznej (Align items)

Klasy align-items-* określają wyrównanie elementów w osi poprzecznej
(pionowej przy flex-row).

Dostępne wartości:

start

end

center

baseline

stretch (domyślne)

Przykład:

<br>
<iframe width="100%" height="200" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;d-flex align-items-start mb-3 bg-light&quot; style=&quot;height: 50px&quot;&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
    &lt;/div&gt;
    &lt;div class=&quot;d-flex align-items-end mb-3 bg-light&quot; style=&quot;height: 50px&quot;&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
    &lt;/div&gt;
    &lt;div class=&quot;d-flex align-items-center mb-3 bg-light&quot; style=&quot;height: 50px&quot;&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
    &lt;/div&gt;
    &lt;div class=&quot;d-flex align-items-baseline mb-3 bg-light&quot; style=&quot;height: 50px&quot;&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
    &lt;/div&gt;
    &lt;div class=&quot;d-flex align-items-stretch bg-light&quot; style=&quot;height: 50px&quot;&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="d-flex align-items-start">...</div>
<div class="d-flex align-items-end">...</div>
<div class="d-flex align-items-center">...</div>
<div class="d-flex align-items-baseline">...</div>
<div class="d-flex align-items-stretch">...</div>
```


Również tutaj dostępne są warianty responsywne.

Indywidualne wyrównanie elementu (Align self)

align-self-* pozwala nadpisać wyrównanie pojedynczego elementu, niezależnie od align-items.

Dostępne wartości:

start

end

center

baseline

stretch

Przykład:

<br>
<iframe width="100%" height="200" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;d-flex mb-3 bg-light&quot; style=&quot;height: 100px&quot;&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-warning align-self-start&quot;&gt;Start&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-warning align-self-center&quot;&gt;Center&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-warning align-self-end&quot;&gt;End&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-warning align-self-stretch&quot;&gt;Stretch&lt;/div&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="align-self-start">Start</div>
<div class="align-self-center">Center</div>
<div class="align-self-end">End</div>
<div class="align-self-stretch">Stretch</div>
```

Wypełnianie dostępnej przestrzeni (Fill)

Klasa .flex-fill sprawia, że element:

zajmuje maksymalną dostępną szerokość

dzieli przestrzeń równo z innymi .flex-fill

Przykład:

<br>
<iframe width="100%" height="100" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;d-flex bg-light&quot;&gt;
        &lt;div class=&quot;p-2 flex-fill bg-info border&quot;&gt;Flex fill&lt;/div&gt;
        &lt;div class=&quot;p-2 flex-fill bg-info border&quot;&gt;Flex fill&lt;/div&gt;
        &lt;div class=&quot;p-2 flex-fill bg-info border&quot;&gt;Flex fill&lt;/div&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="d-flex">
  <div class="p-2 flex-fill">Flex fill</div>
  <div class="p-2 flex-fill">Flex fill</div>
  <div class="p-2 flex-fill">Flex fill</div>
</div>
```


Dostępne są też wersje responsywne (.flex-md-fill itd.).

Rozszerzanie i kurczenie (Grow and shrink)
Rozszerzanie (flex-grow-*)

.flex-grow-1 – element może się rozszerzać

.flex-grow-0 – element nie rozszerza się

Kurczenie (flex-shrink-*)

.flex-shrink-1 – element może się kurczyć

.flex-shrink-0 – element nie kurczy się

Przykład:

<br>
<iframe width="100%" height="150" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;d-flex bg-light mb-3&quot;&gt;
        &lt;div class=&quot;p-2 flex-grow-1 bg-info border&quot;&gt;Flex grow 1&lt;/div&gt;
        &lt;div class=&quot;p-2 bg-info border&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 bg-info border&quot;&gt;Item&lt;/div&gt;
    &lt;/div&gt;
    &lt;div class=&quot;d-flex bg-light&quot;&gt;
        &lt;div class=&quot;p-2 w-100 bg-info border&quot;&gt;W-100&lt;/div&gt;
        &lt;div class=&quot;p-2 flex-shrink-1 bg-warning border&quot;&gt;Shrink 1&lt;/div&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="d-flex">
  <div class="p-2 flex-grow-1">Flex grow 1</div>
  <div class="p-2">Item</div>
  <div class="p-2">Item</div>
</div>
```


Dostępne są wersje responsywne.

Automatyczne marginesy (Auto margins)

Flexbox w połączeniu z auto marginami pozwala przesuwać elementy:

.me-auto – wypycha elementy w prawo

.ms-auto – wypycha elementy w lewo

.mt-auto, .mb-auto – przesuwanie w pionie (przy flex-column)

Przykład:

<br>
<iframe width="100%" height="150" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;d-flex bg-light mb-3&quot;&gt;
        &lt;div class=&quot;p-2 me-auto bg-info border&quot;&gt;Flex item&lt;/div&gt;
        &lt;div class=&quot;p-2 bg-info border&quot;&gt;Flex item&lt;/div&gt;
        &lt;div class=&quot;p-2 bg-info border&quot;&gt;Flex item&lt;/div&gt;
    &lt;/div&gt;
    &lt;div class=&quot;d-flex bg-light&quot;&gt;
        &lt;div class=&quot;p-2 bg-info border&quot;&gt;Flex item&lt;/div&gt;
        &lt;div class=&quot;p-2 bg-info border&quot;&gt;Flex item&lt;/div&gt;
        &lt;div class=&quot;p-2 ms-auto bg-info border&quot;&gt;Flex item&lt;/div&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="d-flex">
  <div class="me-auto">Flex item</div>
  <div>Flex item</div>
  <div>Flex item</div>
</div>

<div class="d-flex">
  <div>Flex item</div>
  <div>Flex item</div>
  <div class="ms-auto">Flex item</div>
</div>
```

Zawijanie elementów (Wrap)

Kontroluje, czy elementy flex mogą przechodzić do nowej linii:

.flex-nowrap – brak zawijania (domyślne)

.flex-wrap – zawijanie

.flex-wrap-reverse – zawijanie w odwrotnej kolejności

Przykład:

<br>
<iframe width="100%" height="200" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;d-flex flex-wrap bg-light&quot; style=&quot;width: 200px;&quot;&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Flex item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Flex item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Flex item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Flex item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Flex item&lt;/div&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="d-flex flex-wrap">
  ...
</div>
```

Kolejność wizualna (Order)

Klasy order-* zmieniają kolejność wyświetlania elementów, bez zmiany HTML.

.order-0 do .order-5

.order-first

.order-last

Przykład:

<br>
<iframe width="100%" height="100" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;d-flex bg-light&quot;&gt;
        &lt;div class=&quot;p-2 order-3 border bg-info&quot;&gt;First flex item (Order 3)&lt;/div&gt;
        &lt;div class=&quot;p-2 order-2 border bg-info&quot;&gt;Second flex item (Order 2)&lt;/div&gt;
        &lt;div class=&quot;p-2 order-1 border bg-info&quot;&gt;Third flex item (Order 1)&lt;/div&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="d-flex">
  <div class="order-3">First flex item</div>
  <div class="order-2">Second flex item</div>
  <div class="order-1">Third flex item</div>
</div>
```


Dostępne są również warianty responsywne.

Wyrównanie wielu linii (Align content)

align-content-* wyrównuje całe grupy wierszy w kontenerze (działa tylko przy flex-wrap).

Dostępne wartości:

start

end

center

between

around

stretch

⚠️ Nie działa, jeśli elementy są w jednej linii.

Przykład:

<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;d-flex align-content-start flex-wrap bg-light mb-3&quot; style=&quot;height: 200px&quot;&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
    &lt;/div&gt;
    &lt;div class=&quot;d-flex align-content-center flex-wrap bg-light&quot; style=&quot;height: 200px&quot;&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
        &lt;div class=&quot;p-2 border bg-info&quot;&gt;Item&lt;/div&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="d-flex align-content-start flex-wrap">...</div>
<div class="d-flex align-content-end flex-wrap">...</div>
<div class="d-flex align-content-center flex-wrap">...</div>
<div class="d-flex align-content-between flex-wrap">...</div>
<div class="d-flex align-content-around flex-wrap">...</div>
<div class="d-flex align-content-stretch flex-wrap">...</div>
```

Podsumowanie (w skrócie)

Flex w Bootstrapie pozwala:

szybko budować układy bez pisania CSS

łatwo tworzyć layouty responsywne

precyzyjnie kontrolować wyrównanie i kolejność elementów
