Powrót -> [Start](./root.md)


# Gutters

Gutters to odstępy (padding) między kolumnami, używane do responsywnego rozmieszczania i wyrównywania treści w systemie siatki Bootstrap.

Na tej stronie
   
**Na tej stronie**

---

* [How they work](#how-they-work)
* [Horizontal gutters](#horizontal-gutters)
* [Vertical gutters](#vertical-gutters)
* [Horizontal & vertical gutters](#horizontal--vertical-gutters)
* [Row columns gutters](#row-columns-gutters)
* [No gutters](#no-gutters)


## How they work

* **Gutters to przerwy między zawartością kolumn, tworzone przez poziomy `padding`.** Ustawiamy `padding-right` i`padding-left` w każdej kolumnie i używamy ujemnego `margin` na początku i końcu wiersza, aby wyrównać zawartość.
* **Gutters mają początkową szerokość `1.5rem` (`24px`).** Pozwala to dopasować siatkę do skali 
* **Gutters można dostosować responsywnie..** Używaj klas dla konkretnych punktów przerwania, aby zmieniać marginesy poziome, pionowe i wszystkie naraz.

## Horizontal gutters

Klasy `.gx-*` pozwalają kontrolować szerokość marginesów poziomych. Rodzic `.container` lub `.container-fluid` może wymagać dostosowania, jeśli używane są większe marginesy, aby uniknąć niepożądanego overflow, używając odpowiedniej klasy padding.

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
     &lt;div class=&quot;container px-4 text-center&quot;&gt;
&lt;div class=&quot;row gx-5 border border-success&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Custom column padding&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Custom column padding&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container px-4 text-center">
  <div class="row gx-5">
    <div class="col">
      <div class="p-3">Custom column padding</div>
    </div>
    <div class="col">
      <div class="p-3">Custom column padding</div>
    </div>
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
     &lt;div class=&quot;container overflow-hidden text-center&quot;&gt;
&lt;div class=&quot;row gx-5 border border-success&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Custom column padding&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Custom column padding&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container overflow-hidden text-center">
  <div class="row gx-5">
    <div class="col">
      <div class="p-3">Custom column padding</div>
    </div>
    <div class="col">
      <div class="p-3">Custom column padding</div>
    </div>
  </div>
</div>
```

## Vertical gutters

Klasy`.gy-*` pozwalają kontrolować marginesy pionowe w wierszu, gdy kolumny zawijają się do nowych linii. Podobnie jak w marginesach poziomych, pionowe gutters mogą powodować overflow na dole `.row` W takim przypadku dodaj `wrapper` wokół `.row` z klasą `.overflow-hidden`:

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
     &lt;div class=&quot;container overflow-hidden text-center&quot;&gt;
&lt;div class=&quot;row gy-5 border border-success&quot;&gt;
&lt;div class=&quot;col-6 border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Custom column padding&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-6 border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Custom column padding&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-6 border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Custom column padding&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-6 border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Custom column padding&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container overflow-hidden text-center">
  <div class="row gy-5 border border-success">
    <div class="col-6">
      <div class="p-3">Custom column padding</div>
    </div>
    <div class="col-6">
      <div class="p-3">Custom column padding</div>
    </div>
    <div class="col-6">
      <div class="p-3">Custom column padding</div>
    </div>
    <div class="col-6">
      <div class="p-3">Custom column padding</div>
    </div>
  </div>
</div>
```

## Horizontal & vertical gutters

Klasy `.g-*` pozwalają kontrolować zarówno marginesy poziome, jak i pionowe w siatce. W poniższym przykładzie użyto mniejszych marginesów, więc nie ma potrzeby stosowania wrappera `.overflow-hidden`.

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
&lt;div class=&quot;row g-2 border border-success&quot;&gt;
&lt;div class=&quot;col-6 border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Custom column padding&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-6 border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Custom column padding&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-6&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Custom column padding&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-6&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Custom column padding&lt;/div&gt;
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
  <div class="row g-2">
    <div class="col-6">
      <div class="p-3">Custom column padding</div>
    </div>
    <div class="col-6">
      <div class="p-3">Custom column padding</div>
    </div>
    <div class="col-6">
      <div class="p-3">Custom column padding</div>
    </div>
    <div class="col-6">
      <div class="p-3">Custom column padding</div>
    </div>
  </div>
</div>
```

## Row columns gutters

Klasy gutter można również dodać do `row columns` Poniżej przykład użycia responsywnych kolumn wiersza i responsywnych klas gutter:
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
&lt;div class=&quot;row row-cols-2 row-cols-lg-5 g-2 g-lg-3 border border-success&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;
&lt;div class=&quot;p-3 border  border-danger&quot;&gt;Row column&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Row column&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Row column&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Row column&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Row column&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Row column&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Row column&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Row column&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Row column&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
&lt;div class=&quot;p-3 border border-danger&quot;&gt;Row column&lt;/div&gt;
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
  <div class="row row-cols-2 row-cols-lg-5 g-2 g-lg-3 ">
    <div class="col">
      <div class="p-3">Row column</div>
    </div>
    <div class="col">
      <div class="p-3">Row column</div>
    </div>
    <div class="col">
      <div class="p-3">Row column</div>
    </div>
    <div class="col">
      <div class="p-3">Row column</div>
    </div>
    <div class="col">
      <div class="p-3">Row column</div>
    </div>
    <div class="col">
      <div class="p-3">Row column</div>
    </div>
    <div class="col">
      <div class="p-3">Row column</div>
    </div>
    <div class="col">
      <div class="p-3">Row column</div>
    </div>
    <div class="col">
      <div class="p-3">Row column</div>
    </div>
    <div class="col">
      <div class="p-3">Row column</div>
    </div>
  </div>
</div>
```

## No gutters

Gutters między kolumnami w naszych predefiniowanych klasach siatki można usunąć za pomocą `.g-0`. Usuwa to ujemne `margin`s z `.row` i poziomy`padding` ze wszystkich bezpośrednich dzieci kolumn.

**Potrzebujesz projektu „edge-to-edge”?** Usuń rodzica `.container` lub `.container-fluid` i dodaj `.mx-0` do `.row` aby zapobiec overflow.



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
    &lt;/style&gt;V
&lt;/head&gt;
&lt;body&gt;
     &lt;div class=&quot;row g-0 text-center &quot;&gt;
&lt;div class=&quot;col-sm-6 col-md-8 border&quot;&gt;.col-sm-6 .col-md-8&lt;/div&gt;
&lt;div class=&quot;col-6 col-md-4 border&quot;&gt;.col-6 .col-md-4&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="row g-0 text-center">
  <div class="col-sm-6 col-md-8">.col-sm-6 .col-md-8</div>
  <div class="col-6 col-md-4">.col-6 .col-md-4</div>
</div>
```




