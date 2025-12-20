Powrót -> [Start](./root.md)

Link (narzędzia do stylowania linków)

Narzędzia Link utilities w Bootstrapie służą do stylowania elementów <a> (odnośników). Umożliwiają m.in. zmianę koloru, przezroczystości, podkreślenia, odstępu podkreślenia od tekstu oraz zachowania linku po najechaniu kursorem.

Funkcjonalność ta została dodana w wersji Bootstrap 5.3.

Przezroczystość linku (Link opacity)

Za pomocą klas link-opacity-* możesz zmienić poziom przezroczystości koloru linku (wartość alfa w rgba()).

Dostępne poziomy:

link-opacity-10

link-opacity-25

link-opacity-50

link-opacity-75

link-opacity-100

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
    &lt;p&gt;&lt;a href=&quot;#&quot; class=&quot;link-opacity-10&quot;&gt;Link opacity 10&lt;/a&gt;&lt;/p&gt;
    &lt;p&gt;&lt;a href=&quot;#&quot; class=&quot;link-opacity-25&quot;&gt;Link opacity 25&lt;/a&gt;&lt;/p&gt;
    &lt;p&gt;&lt;a href=&quot;#&quot; class=&quot;link-opacity-50&quot;&gt;Link opacity 50&lt;/a&gt;&lt;/p&gt;
    &lt;p&gt;&lt;a href=&quot;#&quot; class=&quot;link-opacity-75&quot;&gt;Link opacity 75&lt;/a&gt;&lt;/p&gt;
    &lt;p&gt;&lt;a href=&quot;#&quot; class=&quot;link-opacity-100&quot;&gt;Link opacity 100&lt;/a&gt;&lt;/p&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<a href="#" class="link-opacity-10">Link opacity 10</a>
<a href="#" class="link-opacity-25">Link opacity 25</a>
<a href="#" class="link-opacity-50">Link opacity 50</a>
<a href="#" class="link-opacity-75">Link opacity 75</a>
<a href="#" class="link-opacity-100">Link opacity 100</a>
```

⚠️ Uwaga: Zmniejszenie przezroczystości może pogorszyć kontrast kolorów i wpłynąć negatywnie na dostępność (WCAG).

Przezroczystość po najechaniu (hover)

Dostępne są również warianty działające tylko przy najechaniu kursorem:

link-opacity-10-hover

link-opacity-25-hover

link-opacity-50-hover

link-opacity-75-hover

link-opacity-100-hover

Podkreślenia linków (Link underlines)
Kolor podkreślenia (Underline color)

Możesz ustawić kolor podkreślenia niezależnie od koloru tekstu linku, np.:

link-underline-primary

link-underline-secondary

link-underline-success

link-underline-danger

link-underline-warning

link-underline-info

link-underline-light

link-underline-dark

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
    &lt;p&gt;&lt;a href=&quot;#&quot; class=&quot;link-underline-primary&quot;&gt;Primary underline&lt;/a&gt;&lt;/p&gt;
    &lt;p&gt;&lt;a href=&quot;#&quot; class=&quot;link-underline-secondary&quot;&gt;Secondary underline&lt;/a&gt;&lt;/p&gt;
    &lt;p&gt;&lt;a href=&quot;#&quot; class=&quot;link-underline-success&quot;&gt;Success underline&lt;/a&gt;&lt;/p&gt;
    &lt;p&gt;&lt;a href=&quot;#&quot; class=&quot;link-underline-danger&quot;&gt;Danger underline&lt;/a&gt;&lt;/p&gt;
    &lt;p&gt;&lt;a href=&quot;#&quot; class=&quot;link-underline-warning&quot;&gt;Warning underline&lt;/a&gt;&lt;/p&gt;
    &lt;p&gt;&lt;a href=&quot;#&quot; class=&quot;link-underline-info&quot;&gt;Info underline&lt;/a&gt;&lt;/p&gt;
    &lt;p&gt;&lt;a href=&quot;#&quot; class=&quot;link-underline-light&quot;&gt;Light underline&lt;/a&gt;&lt;/p&gt;
    &lt;p&gt;&lt;a href=&quot;#&quot; class=&quot;link-underline-dark&quot;&gt;Dark underline&lt;/a&gt;&lt;/p&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<a href="#" class="link-underline-primary">Primary underline</a>
<a href="#" class="link-underline-secondary">Secondary underline</a>
<a href="#" class="link-underline-success">Success underline</a>
<a href="#" class="link-underline-danger">Danger underline</a>
<a href="#" class="link-underline-warning">Warning underline</a>
<a href="#" class="link-underline-info">Info underline</a>
<a href="#" class="link-underline-light">Light underline</a>
<a href="#" class="link-underline-dark">Dark underline</a>
```

Odstęp podkreślenia od tekstu (Underline offset)

Klasy link-offset-* zmieniają odległość podkreślenia od tekstu. Wartości są podawane w jednostkach em, dzięki czemu skalują się wraz z rozmiarem czcionki.

Dostępne klasy:

link-offset-1

link-offset-2

link-offset-3

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
    &lt;p&gt;&lt;a href=&quot;#&quot; class=&quot;link-offset-1&quot;&gt;Offset 1&lt;/a&gt;&lt;/p&gt;
    &lt;p&gt;&lt;a href=&quot;#&quot; class=&quot;link-offset-2&quot;&gt;Offset 2&lt;/a&gt;&lt;/p&gt;
    &lt;p&gt;&lt;a href=&quot;#&quot; class=&quot;link-offset-3&quot;&gt;Offset 3&lt;/a&gt;&lt;/p&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<a href="#" class="link-offset-1">Offset 1</a>
<a href="#" class="link-offset-2">Offset 2</a>
<a href="#" class="link-offset-3">Offset 3</a>
```

Przezroczystość podkreślenia (Underline opacity)

Aby kontrolować przezroczystość podkreślenia, należy najpierw dodać klasę:

link-underline

Następnie można ustawić poziom przezroczystości:

link-underline-opacity-0

link-underline-opacity-10

link-underline-opacity-25

link-underline-opacity-50

link-underline-opacity-75

link-underline-opacity-100

Warianty hover

Podobnie jak w przypadku przezroczystości linku, klasy link-offset-* oraz link-underline-opacity-* posiadają warianty -hover, które działają tylko po najechaniu kursorem.

Pozwala to tworzyć bardziej zaawansowane i dynamiczne style linków, np.:

brak podkreślenia domyślnie,

wyraźne podkreślenie po najechaniu.

Kolorowe linki (Colored links)

Bootstrap oferuje pomocnicze klasy kolorów linków, które można łączyć z narzędziami linków, np.:

link-primary

link-secondary

link-success

link-danger

link-warning

link-info

link-light

link-dark

link-body-emphasis

Dzięki temu można jednocześnie kontrolować:

kolor tekstu,

przezroczystość linku,

przezroczystość podkreślenia,

odstęp podkreślenia.

Wskazówka dotycząca dostępności (Accessibility)

Kolor nie powinien być jedynym nośnikiem informacji. Użytkownicy czytników ekranu lub osoby z zaburzeniami widzenia kolorów mogą nie zauważyć różnic kolorystycznych.

Zalecenia:

upewnij się, że treść linku jasno komunikuje jego znaczenie,

stosuj odpowiedni kontrast kolorów,

w razie potrzeby używaj dodatkowego tekstu (np. .visually-hidden).

CSS i Sass Utilities API

Narzędzia linków są zdefiniowane w pliku:

scss/_utilities.scss


Bootstrap wykorzystuje Sass Utilities API oraz CSS variables, co pozwala łatwo rozszerzać i dostosowywać zachowanie linków do własnych potrzeb.
