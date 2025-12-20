Powrót -> [Start](./root.md)

Borders (Obramowania) – Bootstrap 5.3

Narzędzia obramowań w Bootstrapie umożliwiają szybkie stylowanie ramki (border) oraz zaokrągleń rogów (border-radius) elementów HTML. Są szczególnie przydatne przy stylowaniu obrazów, przycisków, kart, formularzy i innych komponentów.

Border – dodawanie i usuwanie obramowań

Bootstrap pozwala zarówno dodawać, jak i usuwać obramowania – całościowo lub tylko z wybranych stron.

Additive – dodawanie obramowań

Klasy:

.border – obramowanie ze wszystkich stron

.border-top – tylko górna krawędź

.border-0 – usuwa wszystkie obramowania

.border-top-0

.border-end-0

.border-bottom-0

.border-start-0

Przykład:

<br>
<iframe width="100%" height="200" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;style&gt;
        .demo-box { width: 100px; height: 100px; background-color: #f8f9fa; display: inline-block; margin: 10px; text-align: center; line-height: 100px; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3 text-center&quot;&gt;
    &lt;div class=&quot;demo-box border border-0&quot;&gt;None&lt;/div&gt;
    &lt;div class=&quot;demo-box border border-top-0&quot;&gt;No Top&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<span class="border border-0"></span>
<span class="border border-top-0"></span>
```

Color – kolor obramowania

Kolor obramowania można zmienić za pomocą klas .border-*, bazujących na kolorach motywu Bootstrapa:

.border-primary

.border-success

.border-danger

.border-warning

.border-info

.border-light

.border-dark

.border-black

.border-white

<br>
<iframe width="100%" height="200" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;style&gt;
        .demo-box { width: 80px; height: 80px; background-color: #f8f9fa; display: inline-block; margin: 5px; border-width: 3px !important; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;demo-box border border-primary&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box border border-secondary&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box border border-success&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box border border-danger&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box border border-warning&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box border border-info&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box border border-light&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box border border-dark&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box border border-white&quot;&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<span class="border border-primary"></span>
<span class="border border-secondary"></span>
<span class="border border-success"></span>
<span class="border border-danger"></span>
<span class="border border-warning"></span>
<span class="border border-info"></span>
<span class="border border-light"></span>
<span class="border border-dark"></span>
<span class="border border-white"></span>
```

Subtelne kolory obramowań

Klasy .border-*-subtle (np. .border-primary-subtle) są:

jaśniejsze lub ciemniejsze

dostosowane do trybu jasnego i ciemnego

zalecane zamiast standardowych .border-* (pełne wsparcie trybów kolorów będzie w Bootstrapie v6)

Zmiana koloru obramowania komponentu

Przykłady zastosowania:

zielona ramka pola formularza (.border-success)

podkreślenie nagłówka (.border-bottom)

połączenie koloru, szerokości i zaokrągleń

<input class="form-control border-success">
<div class="border-bottom border-danger"></div>

Opacity – przezroczystość obramowania

🆕 Dostępne od Bootstrap 5.2

Kolory obramowań są generowane przy użyciu zmiennych CSS, co umożliwia dynamiczną zmianę przezroczystości bez rekompilacji Sass.

Jak to działa?

Każda klasa .border-*:

używa zmiennej RGB (np. --bs-success-rgb)

posiada lokalną zmienną --bs-border-opacity (domyślnie 1)

Dzięki temu:

przezroczystość nie jest dziedziczona przez elementy zagnieżdżone

można łatwo sterować kanałem alfa

Przykład zmiany przezroczystości
<div class="border border-success" style="--bs-border-opacity: .5;"></div>

Gotowe klasy .border-opacity-*

Bootstrap udostępnia:

.border-opacity-75

.border-opacity-50

.border-opacity-25

.border-opacity-10

.border-opacity-100

Width – grubość obramowania

Można zmieniać szerokość ramki klasami:

.border-1

.border-2

.border-3

.border-4

.border-5

Przykład:

<br>
<iframe width="100%" height="200" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;style&gt;
        .demo-box { width: 80px; height: 80px; background-color: #f8f9fa; display: inline-block; margin: 10px; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;demo-box border border-1&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box border border-2&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box border border-3&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box border border-4&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box border border-5&quot;&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<span class="border border-1"></span>
<span class="border border-2"></span>
<span class="border border-3"></span>
<span class="border border-4"></span>
<span class="border border-5"></span>
```

Radius – zaokrąglenie rogów

Klasy .rounded-* umożliwiają szybkie zaokrąglanie rogów elementów.

Podstawowe klasy

.rounded – standardowe zaokrąglenie

.rounded-top

.rounded-end

.rounded-bottom

.rounded-start

Sizes – rozmiary zaokrągleń

Dostępne są skalowalne warianty:

.rounded-0 – brak zaokrąglenia

.rounded-1 do .rounded-5 – rosnące promienie

.rounded-circle – pełne koło

.rounded-pill – kształt kapsułki

Można też łączyć kierunki i rozmiary, np.:

<br>
<iframe width="100%" height="200" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;style&gt;
        .demo-box { width: 75px; height: 75px; background-color: #0d6efd; display: inline-block; margin: 5px; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;demo-box rounded&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box rounded-0&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box rounded-1&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box rounded-2&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box rounded-3&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box rounded-4&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box rounded-5&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box rounded-circle&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box rounded-pill&quot; style=&quot;width: 150px;&quot;&gt;&lt;/div&gt;
    &lt;br&gt;
    &lt;div class=&quot;demo-box rounded-top&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box rounded-end&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box rounded-bottom&quot;&gt;&lt;/div&gt;
    &lt;div class=&quot;demo-box rounded-start&quot;&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<img class="rounded">
<img class="rounded-0">
<img class="rounded-1">
<img class="rounded-2">
<img class="rounded-3">
<img class="rounded-4">
<img class="rounded-5">
<img class="rounded-circle">
<img class="rounded-pill">

<img class="rounded-top">
<img class="rounded-end">
<img class="rounded-bottom">
<img class="rounded-start">
```

Można też łączyć kierunki i rozmiary, np.:

```html
<img class="rounded-bottom-1">
<img class="rounded-end-circle">
<img class="rounded-5 rounded-top-0">
```

CSS i Sass
Zmienne CSS

Bootstrap definiuje zmienne takie jak:

--bs-border-width

--bs-border-color

--bs-border-radius

--bs-border-radius-pill

Umożliwiają one globalną kontrolę stylów.

Zmienne Sass

W plikach _variables.scss znajdziemy:

domyślną grubość obramowania (1px)

mapy szerokości ($border-widths)

wartości promieni zaokrągleń

kolory obramowań subtelnych (light i dark mode)

Mapy Sass

Mapy kolorów pozwalają Bootstrapowi generować:

.border-*-subtle

wersje dla trybu jasnego i ciemnego

Mixiny Sass

Bootstrap udostępnia mixiny do:

ogólnego zaokrąglania (border-radius)

zaokrągleń tylko wybranych rogów

warunkowego stosowania zaokrągleń ($enable-rounded)

Utilities API

Wszystkie klasy obramowań są definiowane w Utilities API (_utilities.scss), co umożliwia:

rozszerzanie istniejących klas

tworzenie własnych narzędzi

łatwą personalizację Bootstrapa
