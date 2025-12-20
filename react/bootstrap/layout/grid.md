Powrót -> [Start](./root.md)



# Grid system

Użyj potężnego, opartego na zasadzie mobile first systemu siatki flexbox, aby budować layouty o dowolnym kształcie i rozmiarze. System opiera się na 12 kolumnach, 6 domyślnych breakpointach, zmiennych i mixinach Sass oraz dziesiątkach gotowych klas.

Na tej stronie
   
**Na tej stronie**

---

* [Example](#example)
* [How it works](#how-it-works)
* [Grid options](#grid-options)
* [Auto-layout columns](#auto-layout-columns)
  + [Equal-width](#equal-width)
  + [Setting one column width](#setting-one-column-width)
  + [Variable width content](#variable-width-content)
* [Responsive classes](#responsive-classes)
  + [All breakpoints](#all-breakpoints)
  + [Stacked to horizontal](#stacked-to-horizontal)
  + [Mix and match](#mix-and-match)
  + [Row columns](#row-columns)
* [Nesting](#nesting)
* [CSS](#css)
  + [Sass variables](#sass-variables)
  + [Sass mixins](#sass-mixins)
  + [Example usage](#example-usage)
* [Customizing the grid](#customizing-the-grid)
  + [Columns and gutters](#columns-and-gutters)
  + [Grid tiers](#grid-tiers)

## Example

System siatki Bootstrapa wykorzystuje kontenery, wiersze i kolumny do rozmieszczania i wyrównywania treści. Jest zbudowany na `flexbox` i w pełni responsywny. Poniższy przykład tworzy trzy kolumny o równej szerokości na wszystkich urządzeniach. Kolumny są wyśrodkowane dzięki kontenerowi .container.



<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
    &lt;style&gt;
        body { padding: 1rem; background-color: #fff; }
        .dropdown-menu { position: absolute !important; }
        .bd-example { margin: 0; border: none; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body&gt;
     &lt;div class=&quot;container text-center&quot;&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;
      Column
    &lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
      Column
    &lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
      Column
    &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container text-center">
  <div class="row">
    <div class="col">
      Column
    </div>
    <div class="col">
      Column
    </div>
    <div class="col">
      Column
    </div>
  </div>
</div>
```



## How it works

Oto jak system siatki funkcjonuje krok po kroku:

* **Siatka obsługuje 6 responsywnych `breakpoint`ów** Są one oparte na`min-width`  (np., `.col-sm-4` działa na `sm`, `md`, `lg`, `xl`, i `xxl`).To oznacza, że możesz kontrolować wielkość i zachowanie każdego z breakpoints.
* **Kontenery centrują i dodają boczne odstępy** Użyj`.container` (stała szerokość), `.container-fluid` dla `width: 100%` lub kontenera responsywnego (np, `.container-md`) 
* **Wiersze (.row) są opakowaniem dla kolumn..** Kolumny mają poziomy padding (gutter), a wiersze mają ujemne marginesy, aby treść była równo wyrównana. 
* **Kolumny są bardzo elastyczne.** Każdy wiersz ma 12 kolumn, które możesz dowolnie łączyć (np. col-4 zajmuje 4/12 szerokości).
* **Odstępy (gutters) są responsywne i konfigurowalne**  Możesz je zmieniać klasami poziom -> `.gx-*` pion -> `.gy-*`, lub dwa na raz -> `.g-*`. lub usunąć przez za pomocą ->`.g-0` 




## Grid options

Bootstrap dzieli siatkę na sześć poziomów:

* Extra small (xs)
* Small (sm)
* Medium (md)
* Large (lg)
* Extra large (xl)
* Extra extra large (xxl)



|  | xs <576px | sm ≥576px | md ≥768px | lg ≥992px | xl ≥1200px | xxl ≥1400px |
| --- | --- | --- | --- | --- | --- | --- |
| Container `max-width` | None (auto) | 540px | 720px | 960px | 1140px | 1320px |
| Class prefix | `.col-` | `.col-sm-` | `.col-md-` | `.col-lg-` | `.col-xl-` | `.col-xxl-` |
| # of columns | 12 | | | | | |
| Gutter width | 1.5rem (.75rem on left and right) | | | | | |
| Custom gutters | [Yes](/docs/5.3/layout/gutters) | | | | | |
| Nestable | [Yes](#nesting) | | | | | |
| Column ordering | [Yes](/docs/5.3/layout/columns#reordering) | | | | | |

## Auto-layout columns

Używaj klas kolumn specyficznych dla punktu przerwania, aby łatwo ustawiać rozmiar kolumn bez użycia jawnej klasy z numerem `.col-sm-6`.

### Equal-width

Używając samej klasy `.col` to `xxl`. wszystkie kolumny w wierszu będą miały taką samą szerokość, niezależnie od liczby kolumn.

<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
    &lt;style&gt;
        body { padding: 1rem; background-color: #fff; }
        .dropdown-menu { position: absolute !important; }
        .bd-example { margin: 0; border: none; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body&gt;
     &lt;div class=&quot;container text-center&quot;&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;
      1 of 2
    &lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
      2 of 2
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;
      1 of 3
    &lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
      2 of 3
    &lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
      3 of 3
    &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container text-center">
  <div class="row">
    <div class="col">
      1 of 2
    </div>
    <div class="col">
      2 of 2
    </div>
  </div>
  <div class="row">
    <div class="col">
      1 of 3
    </div>
    <div class="col">
      2 of 3
    </div>
    <div class="col">
      3 of 3
    </div>
  </div>
</div>
```

### Setting one column width

Możesz ustawić szerokość jednej kolumny, a pozostałe automatycznie się dopasują.

<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
    &lt;style&gt;
        body { padding: 1rem; background-color: #fff; }
        .dropdown-menu { position: absolute !important; }
        .bd-example { margin: 0; border: none; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body&gt;
     &lt;div class=&quot;container text-center&quot;&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;
      1 of 3
    &lt;/div&gt;
&lt;div class=&quot;col-6 border&quot;&gt;
      2 of 3 (wider)
    &lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
      3 of 3
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;
      1 of 3
    &lt;/div&gt;
&lt;div class=&quot;col-5 border&quot;&gt;
      2 of 3 (wider)
    &lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
      3 of 3
    &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container text-center">
  <div class="row">
    <div class="col">
      1 of 3
    </div>
    <div class="col-6">
      2 of 3 (wider)
    </div>
    <div class="col">
      3 of 3
    </div>
  </div>
  <div class="row">
    <div class="col">
      1 of 3
    </div>
    <div class="col-5">
      2 of 3 (wider)
    </div>
    <div class="col">
      3 of 3
    </div>
  </div>
</div>
```

### Variable width content

Użyj `col-{breakpoint}-auto` aby szerokość kolumny była dopasowana do treści.

<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
    &lt;style&gt;
        body { padding: 1rem; background-color: #fff; }
        .dropdown-menu { position: absolute !important; }
        .bd-example { margin: 0; border: none; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body&gt;
     &lt;div class=&quot;container text-center&quot;&gt;
&lt;div class=&quot;row justify-content-md-center&quot;&gt;
&lt;div class=&quot;col col-lg-2 border&quot;&gt;
      1 of 3
    &lt;/div&gt;
&lt;div class=&quot;col-md-auto border&quot;&gt;
      Variable width content
    &lt;/div&gt;
&lt;div class=&quot;col col-lg-2 border&quot;&gt;
      3 of 3
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;
      1 of 3
    &lt;/div&gt;
&lt;div class=&quot;col-md-auto border&quot;&gt;
      Variable width content
    &lt;/div&gt;
&lt;div class=&quot;col col-lg-2 border&quot;&gt;
      3 of 3
    &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container text-center">
  <div class="row justify-content-md-center">
    <div class="col col-lg-2">
      1 of 3
    </div>
    <div class="col-md-auto">
      Variable width content
    </div>
    <div class="col col-lg-2">
      3 of 3
    </div>
  </div>
  <div class="row">
    <div class="col">
      1 of 3
    </div>
    <div class="col-md-auto">
      Variable width content
    </div>
    <div class="col col-lg-2">
      3 of 3
    </div>
  </div>
</div>
```

## Responsive classes

Siatka Bootstrapa zawiera sześć poziomów wstępnie zdefiniowanych klas do tworzenia złożonych, responsywnych układów. Dostosuj rozmiar swoich kolumn na urządzeniach bardzo małych, małych, średnich, dużych lub bardzo dużych w dowolny sposób.

### All breakpoints

Jeśli layout ma wyglądać tak samo na wszystkich urządzeniach, użyj `.col` and `.col-*` Dopisz numerową klase, kiedy potrzebujesz poszczególnego rozmiaru np. `col-6`.  
<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
    &lt;style&gt;
        body { padding: 1rem; background-color: #fff; }
        .dropdown-menu { position: absolute !important; }
        .bd-example { margin: 0; border: none; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body&gt;
     &lt;div class=&quot;container text-center&quot;&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;col&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;col&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;col&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;col&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-8 border&quot;&gt;col-8&lt;/div&gt;
&lt;div class=&quot;col-4 border&quot;&gt;col-4&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container text-center">
  <div class="row">
    <div class="col">col</div>
    <div class="col">col</div>
    <div class="col">col</div>
    <div class="col">col</div>
  </div>
  <div class="row">
    <div class="col-8">col-8</div>
    <div class="col-4">col-4</div>
  </div>
</div>
```

### Stacked to horizontal

Układ może być pionowy na małych ekranach i poziomy na większych:

<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
    &lt;style&gt;
        body { padding: 1rem; background-color: #fff; }
        .dropdown-menu { position: absolute !important; }
        .bd-example { margin: 0; border: none; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body&gt;
     &lt;div class=&quot;container text-center&quot;&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-sm-8 border&quot;&gt;col-sm-8&lt;/div&gt;
&lt;div class=&quot;col-sm-4 border&quot;&gt;col-sm-4&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-sm border&quot;&gt;col-sm&lt;/div&gt;
&lt;div class=&quot;col-sm border&quot;&gt;col-sm&lt;/div&gt;
&lt;div class=&quot;col-sm border&quot;&gt;col-sm&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container text-center">
  <div class="row">
    <div class="col-sm-8">col-sm-8</div>
    <div class="col-sm-4">col-sm-4</div>
  </div>
  <div class="row">
    <div class="col-sm">col-sm</div>
    <div class="col-sm">col-sm</div>
    <div class="col-sm">col-sm</div>
  </div>
</div>
```

### Mix and match

Możesz łączyć klasy z różnych breakpointów, aby uzyskać bardziej złożony layout.

<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
    &lt;style&gt;
        body { padding: 1rem; background-color: #fff; }
        .dropdown-menu { position: absolute !important; }
        .bd-example { margin: 0; border: none; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body&gt;
     &lt;div class=&quot;container text-center&quot;&gt;
&lt;!-- Stack the columns on mobile by making one full-width and the other half-width --&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-md-8 border&quot;&gt;.col-md-8&lt;/div&gt;
&lt;div class=&quot;col-6 col-md-4 border&quot;&gt;.col-6 .col-md-4&lt;/div&gt;
&lt;/div&gt;
&lt;!-- Columns start at 50% wide on mobile and bump up to 33.3% wide on desktop --&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-6 col-md-4 border&quot;&gt;.col-6 .col-md-4&lt;/div&gt;
&lt;div class=&quot;col-6 col-md-4 border&quot;&gt;.col-6 .col-md-4&lt;/div&gt;
&lt;div class=&quot;col-6 col-md-4 border&quot;&gt;.col-6 .col-md-4&lt;/div&gt;
&lt;/div&gt;
&lt;!-- Columns are always 50% wide, on mobile and desktop --&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-6 border&quot;&gt;.col-6&lt;/div&gt;
&lt;div class=&quot;col-6 border&quot;&gt;.col-6&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container text-center">
  <!-- Stack the columns on mobile by making one full-width and the other half-width -->
  <div class="row">
    <div class="col-md-8">.col-md-8</div>
    <div class="col-6 col-md-4">.col-6 .col-md-4</div>
  </div>

  <!-- Columns start at 50% wide on mobile and bump up to 33.3% wide on desktop -->
  <div class="row">
    <div class="col-6 col-md-4">.col-6 .col-md-4</div>
    <div class="col-6 col-md-4">.col-6 .col-md-4</div>
    <div class="col-6 col-md-4">.col-6 .col-md-4</div>
  </div>

  <!-- Columns are always 50% wide, on mobile and desktop -->
  <div class="row">
    <div class="col-6">.col-6</div>
    <div class="col-6">.col-6</div>
  </div>
</div>
```

### Row columns

Klasy `.row-cols-*` pozwalają szybko ustawić liczbę kolumn w wierszu. Podczas gdy normalne klasy `.col-*` stosuje się do pojedynczych kolumn (np. .col-md-4), klasy kolumn w wierszu (np., `.col-md-4`), ustawiane są na rodzicu `.row` jako skrót. Dzięki `.row-cols-auto` możesz nadać kolumnom ich naturalną szerokość.



<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
    &lt;style&gt;
        body { padding: 1rem; background-color: #fff; }
        .dropdown-menu { position: absolute !important; }
        .bd-example { margin: 0; border: none; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body&gt;
     &lt;div class=&quot;container text-center&quot;&gt;
&lt;div class=&quot;row row-cols-2&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container text-center">
  <div class="row row-cols-2">
    <div class="col">Column</div>
    <div class="col">Column</div>
    <div class="col">Column</div>
    <div class="col">Column</div>
  </div>
</div>
```

<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
    &lt;style&gt;
        body { padding: 1rem; background-color: #fff; }
        .dropdown-menu { position: absolute !important; }
        .bd-example { margin: 0; border: none; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body&gt;
     &lt;div class=&quot;container text-center&quot;&gt;
&lt;div class=&quot;row row-cols-3&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container text-center">
  <div class="row row-cols-3">
    <div class="col">Column</div>
    <div class="col">Column</div>
    <div class="col">Column</div>
    <div class="col">Column</div>
  </div>
</div>
```

<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
    &lt;style&gt;
        body { padding: 1rem; background-color: #fff; }
        .dropdown-menu { position: absolute !important; }
        .bd-example { margin: 0; border: none; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body&gt;
     &lt;div class=&quot;container text-center&quot;&gt;
&lt;div class=&quot;row row-cols-auto&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container text-center">
  <div class="row row-cols-auto">
    <div class="col">Column</div>
    <div class="col">Column</div>
    <div class="col">Column</div>
    <div class="col">Column</div>
  </div>
</div>
```

<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
    &lt;style&gt;
        body { padding: 1rem; background-color: #fff; }
        .dropdown-menu { position: absolute !important; }
        .bd-example { margin: 0; border: none; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body&gt;
     &lt;div class=&quot;container text-center&quot;&gt;
&lt;div class=&quot;row row-cols-4&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container text-center">
  <div class="row row-cols-4">
    <div class="col">Column</div>
    <div class="col">Column</div>
    <div class="col">Column</div>
    <div class="col">Column</div>
  </div>
</div>
```

<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
    &lt;style&gt;
        body { padding: 1rem; background-color: #fff; }
        .dropdown-menu { position: absolute !important; }
        .bd-example { margin: 0; border: none; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body&gt;
     &lt;div class=&quot;container text-center&quot;&gt;
&lt;div class=&quot;row row-cols-4&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;div class=&quot;col-6 border&quot;&gt;Column&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container text-center">
  <div class="row row-cols-4">
    <div class="col">Column</div>
    <div class="col">Column</div>
    <div class="col-6">Column</div>
    <div class="col">Column</div>
  </div>
</div>
```

<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
    &lt;style&gt;
        body { padding: 1rem; background-color: #fff; }
        .dropdown-menu { position: absolute !important; }
        .bd-example { margin: 0; border: none; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body&gt;
     &lt;div class=&quot;container text-center&quot;&gt;
&lt;div class=&quot;row row-cols-1 row-cols-sm-2 row-cols-md-4&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;Column&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container text-center">
  <div class="row row-cols-1 row-cols-sm-2 row-cols-md-4">
    <div class="col">Column</div>
    <div class="col">Column</div>
    <div class="col">Column</div>
    <div class="col">Column</div>
  </div>
</div>
```



```html
.element {
  // Three columns to start
  @include row-cols(3);

  // Five columns from medium breakpoint up
  @include media-breakpoint-up(md) {
    @include row-cols(5);
  }
}
```

## Nesting

Kolumny mogą zawierać kolejne wiersze i kolumny, co pozwala budować złożone struktury layoutu.

<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
    &lt;style&gt;
        body { padding: 1rem; background-color: #fff; }
        .dropdown-menu { position: absolute !important; }
        .bd-example { margin: 0; border: none; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body&gt;
     &lt;div class=&quot;container text-center&quot;&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-sm-3 border&quot;&gt;
      Level 1: .col-sm-3
    &lt;/div&gt;
&lt;div class=&quot;col-sm-9 border&quot;&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-8 col-sm-6 border&quot;&gt;
          Level 2: .col-8 .col-sm-6
        &lt;/div&gt;
&lt;div class=&quot;col-4 col-sm-6 border&quot;&gt;
          Level 2: .col-4 .col-sm-6
        &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container text-center">
  <div class="row">
    <div class="col-sm-3">
      Level 1: .col-sm-3
    </div>
    <div class="col-sm-9">
      <div class="row">
        <div class="col-8 col-sm-6">
          Level 2: .col-8 .col-sm-6
        </div>
        <div class="col-4 col-sm-6">
          Level 2: .col-4 .col-sm-6
        </div>
      </div>
    </div>
  </div>
</div>
```


