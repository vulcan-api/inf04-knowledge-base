Powrót -> [Start](./root.md)

Spacing (odstępy)

Bootstrap oferuje szeroki zestaw klas narzędziowych do ustawiania marginesów (margin), wypełnień (padding) oraz odstępów między elementami (gap), które można stosować w sposób responsywny. Pozwala to łatwo zmieniać wygląd elementów bez konieczności pisania własnego CSS.

Marginesy i wypełnienia

Można przypisywać wartości marginesów lub paddingu do całego elementu lub jego konkretnych stron, korzystając z klas skrótowych. Obejmuje to:

pojedyncze strony: top, bottom, start (lewy/prawy), end (prawy/lewy)

poziome i pionowe: x (lewo-prawo), y (góra-dół)

wszystkie strony naraz

Klasy są oparte na domyślnej mapie Sass $spacers, od 0.25rem do 3rem.

Notacja klas

Format klas:

{property}{side}-{size} – dla najmniejszych breakpointów (xs)

{property}{side}-{breakpoint}-{size} – dla większych breakpointów (sm, md, lg, xl, xxl)

Gdzie:

<iframe width="100%" height="100" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;mx-auto p-2 bg-info text-dark&quot; style=&quot;width: 200px;&quot;&gt;
      Element wycentrowany
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="mx-auto p-2" style="width: 200px;">
  Element wycentrowany
</div>
```

Marginesy ujemne

Bootstrap pozwala także na stosowanie ujemnych marginesów, które są wyłączone domyślnie, ale można je włączyć w Sass poprzez $enable-negative-margins: true.
Przykład:

.mt-n1 { margin-top: -0.25rem !important; }

Gap (odstępy między elementami)

W przypadku układu grid lub flex, zamiast stosować marginesy dla każdego elementu, można użyć gap utilities, które działają na rodzicu i są responsywne. Obejmują one wszystkie breakpointy i sześć rozmiarów (0–5).

row-gap i column-gap

row-gap – ustawia odstęp pionowy między elementami

column-gap – ustawia odstęp poziomy między elementami

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
    &lt;div class=&quot;d-grid gap-3&quot; style=&quot;grid-template-columns: 1fr 1fr;&quot;&gt;
      &lt;div class=&quot;p-2 bg-light border&quot;&gt;Element 1&lt;/div&gt;
      &lt;div class=&quot;p-2 bg-light border&quot;&gt;Element 2&lt;/div&gt;
      &lt;div class=&quot;p-2 bg-light border&quot;&gt;Element 3&lt;/div&gt;
      &lt;div class=&quot;p-2 bg-light border&quot;&gt;Element 4&lt;/div&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div style="grid-template-columns: 1fr 1fr;" class="d-grid gap-3">
  <div class="p-2 bg-light border">Element 1</div>
  <div class="p-2 bg-light border">Element 2</div>
  <div class="p-2 bg-light border">Element 3</div>
  <div class="p-2 bg-light border">Element 4</div>
</div>
```

CSS i API Sass

Spacery są definiowane w Sass w mapie $spacers:

$spacer: 1rem;
$spacers: (
  0: 0,
  1: $spacer * .25,
  2: $spacer * .5,
  3: $spacer,
  4: $spacer * 1.5,
  5: $spacer * 3
);


Klasom odpowiadają definicje w scss/_utilities.scss dla:

marginesów (margin, mx, my, mt, mb, ms, me)

paddingu (padding, px, py, pt, pb, ps, pe)

gapów (gap, row-gap, column-gap)

marginesów ujemnych (negative-margin, negative-margin-x, negative-margin-y itd.)

Podsumowanie

Dzięki Spacing utilities można w prosty i elastyczny sposób:

ustawiać marginesy i paddingi w sposób responsywny,

stosować ujemne marginesy,

ustalać odstępy między elementami w grid i flex,

wycentrować elementy poziomo bez dodatkowego CSS.
