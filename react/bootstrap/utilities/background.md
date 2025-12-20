Powrót -> [Start](./root.md)

Background (Tło) – Bootstrap 5.3

Narzędzia tła w Bootstrapie umożliwiają nadawanie znaczenia elementom za pomocą koloru tła (background-color) oraz dodawanie efektów dekoracyjnych, takich jak gradienty czy przezroczystość.

Wskazówka dotycząca dostępności

Kolor nie powinien być jedynym nośnikiem informacji. Użytkownicy czytników ekranu mogą go nie odczytać, dlatego znaczenie elementu powinno wynikać także z treści (np. tekstu) lub dodatkowych opisów, a kontrast kolorów musi być wystarczający.

Kolor tła (Background color)

Bootstrap udostępnia klasy .bg-*, które pozwalają szybko ustawić kolor tła elementu, np.:

.bg-primary

.bg-success

.bg-danger

.bg-warning

.bg-info

.bg-light

.bg-dark

.bg-white

.bg-black

.bg-transparent

⚠️ Klasy tła nie ustawiają koloru tekstu, dlatego często należy użyć dodatkowo klas .text-*, np. .text-white lub .text-dark.

<br>
<iframe width="100%" height="500" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;p-3 mb-2 bg-primary text-white&quot;&gt;.bg-primary&lt;/div&gt;
    &lt;div class=&quot;p-3 mb-2 bg-secondary text-white&quot;&gt;.bg-secondary&lt;/div&gt;
    &lt;div class=&quot;p-3 mb-2 bg-success text-white&quot;&gt;.bg-success&lt;/div&gt;
    &lt;div class=&quot;p-3 mb-2 bg-danger text-white&quot;&gt;.bg-danger&lt;/div&gt;
    &lt;div class=&quot;p-3 mb-2 bg-warning text-dark&quot;&gt;.bg-warning&lt;/div&gt;
    &lt;div class=&quot;p-3 mb-2 bg-info text-dark&quot;&gt;.bg-info&lt;/div&gt;
    &lt;div class=&quot;p-3 mb-2 bg-light text-dark&quot;&gt;.bg-light&lt;/div&gt;
    &lt;div class=&quot;p-3 mb-2 bg-dark text-white&quot;&gt;.bg-dark&lt;/div&gt;
    &lt;div class=&quot;p-3 mb-2 bg-body text-body&quot;&gt;.bg-body&lt;/div&gt;
    &lt;div class=&quot;p-3 mb-2 bg-white text-dark&quot;&gt;.bg-white&lt;/div&gt;
    &lt;div class=&quot;p-3 mb-2 bg-transparent text-body&quot;&gt;.bg-transparent&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="p-3 mb-2 bg-primary text-white">.bg-primary</div>
<div class="p-3 mb-2 bg-secondary text-white">.bg-secondary</div>
<div class="p-3 mb-2 bg-success text-white">.bg-success</div>
<div class="p-3 mb-2 bg-danger text-white">.bg-danger</div>
<div class="p-3 mb-2 bg-warning text-dark">.bg-warning</div>
<div class="p-3 mb-2 bg-info text-dark">.bg-info</div>
<div class="p-3 mb-2 bg-light text-dark">.bg-light</div>
<div class="p-3 mb-2 bg-dark text-white">.bg-dark</div>
<div class="p-3 mb-2 bg-body text-body">.bg-body</div>
<div class="p-3 mb-2 bg-white text-dark">.bg-white</div>
<div class="p-3 mb-2 bg-transparent text-body">.bg-transparent</div>
```

Subtelne kolory tła

Dostępne są także warianty .bg-*-subtle, np.:

.bg-primary-subtle

.bg-success-subtle

Są to jaśniejsze (lub ciemniejsze w trybie dark mode) wersje kolorów, które reagują na tryb jasny i ciemny, w przeciwieństwie do standardowych .bg-* (do czasu Bootstrapa v6).

Gradient tła (Background gradient)

Dodanie klasy .bg-gradient powoduje nałożenie liniowego gradientu na tło elementu.

Gradient zaczyna się półprzezroczystą bielą u góry

Stopniowo zanika w dół

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
    &lt;div class=&quot;p-3 mb-2 bg-primary bg-gradient text-white&quot;&gt;.bg-primary .bg-gradient&lt;/div&gt;
    &lt;div class=&quot;p-3 mb-2 bg-secondary bg-gradient text-white&quot;&gt;.bg-secondary .bg-gradient&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="bg-primary bg-gradient"></div>
```

Jeśli tworzysz własny CSS, możesz użyć:

background-image: var(--bs-gradient);

Przezroczystość (Opacity)

Od wersji Bootstrap 5.1 kolory tła są oparte na zmiennych CSS, co pozwala dynamicznie zmieniać ich przezroczystość bez rekompilacji Sass.

Jak to działa?

Każda klasa .bg-* korzysta z:

zmiennej RGB koloru (np. --bs-success-rgb)

lokalnej zmiennej --bs-bg-opacity (domyślnie 1)

Dzięki temu można zmieniać przezroczystość bez wpływu na elementy zagnieżdżone.

Zmiana przezroczystości inline

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
    &lt;div class=&quot;bg-success p-2 text-white&quot; style=&quot;--bs-bg-opacity: .5;&quot;&gt;This is 50% opacity success background&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="bg-success" style="--bs-bg-opacity: .5;"></div>
```

Gotowe klasy przezroczystości

Bootstrap oferuje też klasy:

.bg-opacity-75

.bg-opacity-50

.bg-opacity-25

.bg-opacity-10

Przykład:

<div class="bg-success bg-opacity-50"></div>

CSS i Sass
Zmienne Sass

Kolory tła bazują na zmiennych Sass (np. $primary, $success, $danger) oraz mapach kolorów ($theme-colors).

Mapy Sass

Mapy pozwalają Bootstrapowi automatycznie generować klasy:

.bg-*

.bg-*-subtle

klasy RGB oraz warianty dla trybu jasnego i ciemnego

Mixiny

Bootstrap nie używa mixinów do generowania klas .bg-*, ale udostępnia mixiny do tworzenia własnych gradientów (poziomych, pionowych, radialnych, paskowanych itd.).

Utilities API

Klasy tła są zdefiniowane w API narzędzi (_utilities.scss), co umożliwia:

łatwe rozszerzanie

modyfikację wartości

tworzenie własnych klas narzędziowych
