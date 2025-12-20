Powrót -> [Start](./root.md)



# Columns

Dowiedz się, jak modyfikować kolumny za pomocą kilku opcji wyrównywania, zmiany kolejności oraz przesuwania (offsetów), dzięki systemowi siatki opartemu na flexboxie. Dodatkowo zobacz, jak używać klas kolumn do zarządzania szerokościami elementów spoza siatki.

Na tej stronie
   
**Na tej stronie**

---


* [Alignment](#alignment)
  + [Vertical alignment](#vertical-alignment)
  + [Horizontal alignment](#horizontal-alignment)
  + [Column wrapping](#column-wrapping)
  + [Column breaks](#column-breaks)
* [Reordering](#reordering)
  + [Order classes](#order-classes)
  + [Offsetting columns](#offsetting-columns)
    - [Offset classes](#offset-classes)
    - [Margin utilities](#margin-utilities)
* [Standalone column classes](#standalone-column-classes)





## Alignment

Użyj narzędzi wyrównywania flexboxa, aby wyrównać kolumny w pionie i poziomie.

### Vertical alignment

Zmień wyrównanie pionowe za pomocą responsywnych klas`align-items-*` 

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
&lt;div class=&quot;row align-items-start&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;
      One of three columns
    &lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
      One of three columns
    &lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
      One of three columns
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
  <div class="row align-items-start">
    <div class="col">
      One of three columns
    </div>
    <div class="col">
      One of three columns
    </div>
    <div class="col">
      One of three columns
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
     &lt;div class=&quot;container text-center&quot;&gt;
&lt;div class=&quot;row align-items-center&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;
      One of three columns
    &lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
      One of three columns
    &lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
      One of three columns
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
  <div class="row align-items-center">
    <div class="col">
      One of three columns
    </div>
    <div class="col">
      One of three columns
    </div>
    <div class="col">
      One of three columns
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
     &lt;div class=&quot;container text-center&quot;&gt;
&lt;div class=&quot;row align-items-end&quot;&gt;
&lt;div class=&quot;col border&quot;&gt;
      One of three columns
    &lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
      One of three columns
    &lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
      One of three columns
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
  <div class="row align-items-end">
    <div class="col">
      One of three columns
    </div>
    <div class="col">
      One of three columns
    </div>
    <div class="col">
      One of three columns
    </div>
  </div>
</div>
```

Możesz też zmienić wyrównanie pojedynczych kolumn za pomocą klas `.align-self-*`.

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
&lt;div class=&quot;col align-self-start border&quot;&gt;
      One of three columns
    &lt;/div&gt;
&lt;div class=&quot;col align-self-center border&quot;&gt;
      One of three columns
    &lt;/div&gt;
&lt;div class=&quot;col align-self-end border&quot;&gt;
      One of three columns
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
    <div class="col align-self-start">
      One of three columns
    </div>
    <div class="col align-self-center">
      One of three columns
    </div>
    <div class="col align-self-end">
      One of three columns
    </div>
  </div>
</div>
```

### Horizontal alignment

Zmień wyrównanie poziome za pomocą responsywnych klas`justify-content-*`.

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
&lt;div class=&quot;row justify-content-start&quot;&gt;
&lt;div class=&quot;col-4 border&quot;&gt;
      One of two columns
    &lt;/div&gt;
&lt;div class=&quot;col-4 border&quot;&gt;
      One of two columns
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;row justify-content-center&quot;&gt;
&lt;div class=&quot;col-4 border&quot;&gt;
      One of two columns
    &lt;/div&gt;
&lt;div class=&quot;col-4 border&quot;&gt;
      One of two columns
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;row justify-content-end&quot;&gt;
&lt;div class=&quot;col-4 border&quot;&gt;
      One of two columns
    &lt;/div&gt;
&lt;div class=&quot;col-4 border&quot;&gt;
      One of two columns
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;row justify-content-around&quot;&gt;
&lt;div class=&quot;col-4 border&quot;&gt;
      One of two columns
    &lt;/div&gt;
&lt;div class=&quot;col-4 border&quot;&gt;
      One of two columns
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;row justify-content-between&quot;&gt;
&lt;div class=&quot;col-4 border&quot;&gt;
      One of two columns
    &lt;/div&gt;
&lt;div class=&quot;col-4 border&quot;&gt;
      One of two columns
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;row justify-content-evenly&quot;&gt;
&lt;div class=&quot;col-4 border&quot;&gt;
      One of two columns
    &lt;/div&gt;
&lt;div class=&quot;col-4 border&quot;&gt;
      One of two columns
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
  <div class="row justify-content-start">
    <div class="col-4">
      One of two columns
    </div>
    <div class="col-4">
      One of two columns
    </div>
  </div>
  <div class="row justify-content-center">
    <div class="col-4">
      One of two columns
    </div>
    <div class="col-4">
      One of two columns
    </div>
  </div>
  <div class="row justify-content-end">
    <div class="col-4">
      One of two columns
    </div>
    <div class="col-4">
      One of two columns
    </div>
  </div>
  <div class="row justify-content-around">
    <div class="col-4">
      One of two columns
    </div>
    <div class="col-4">
      One of two columns
    </div>
  </div>
  <div class="row justify-content-between">
    <div class="col-4">
      One of two columns
    </div>
    <div class="col-4">
      One of two columns
    </div>
  </div>
  <div class="row justify-content-evenly">
    <div class="col-4">
      One of two columns
    </div>
    <div class="col-4">
      One of two columns
    </div>
  </div>
</div>
```

### Column wrapping

Jeśli w jednym wierszu znajdzie się więcej niż 12 kolumn, każda kolejna grupa zostanie automatycznie przeniesiona do nowej linii jako jeden blok.

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
     &lt;div class=&quot;container&quot;&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-9 border&quot;&gt;.col-9&lt;/div&gt;
&lt;div class=&quot;col-4 border&quot;&gt;.col-4&lt;br/&gt;Since 9 + 4 = 13 &amp;gt; 12, this 4-column-wide div gets wrapped onto a new line as one contiguous unit.&lt;/div&gt;
&lt;div class=&quot;col-6 border&quot;&gt;.col-6&lt;br/&gt;Subsequent columns continue along the new line.&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container">
  <div class="row">
    <div class="col-9">.col-9</div>
    <div class="col-4">.col-4<br>Since 9 + 4 = 13 &gt; 12, this 4-column-wide div gets wrapped onto a new line as one contiguous unit.</div>
    <div class="col-6">.col-6<br>Subsequent columns continue along the new line.</div>
  </div>
</div>
```

### Column breaks

Aby wymusić przejście kolumn do nowej linii w flexboxie, użyj elementu z`width: 100%` Zwykle osiąga się to poprzez użycie wielu elementów `.row`jednak nie każda metoda implementacji na to pozwala lub to uwzględnia.

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
&lt;div class=&quot;col-6 col-sm-3 border&quot;&gt;.col-6 .col-sm-3&lt;/div&gt;
&lt;div class=&quot;col-6 col-sm-3 border&quot;&gt;.col-6 .col-sm-3&lt;/div&gt;
&lt;!-- Force next columns to break to new line --&gt;
&lt;div class=&quot;w-100&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;col-6 col-sm-3 border&quot;&gt;.col-6 .col-sm-3&lt;/div&gt;
&lt;div class=&quot;col-6 col-sm-3 border&quot;&gt;.col-6 .col-sm-3&lt;/div&gt;
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
    <div class="col-6 col-sm-3">.col-6 .col-sm-3</div>
    <div class="col-6 col-sm-3">.col-6 .col-sm-3</div>

    <!-- Force next columns to break to new line -->
    <div class="w-100"></div>

    <div class="col-6 col-sm-3">.col-6 .col-sm-3</div>
    <div class="col-6 col-sm-3">.col-6 .col-sm-3</div>
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
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-6 col-sm-4 border&quot;&gt;.col-6 .col-sm-4&lt;/div&gt;
&lt;div class=&quot;col-6 col-sm-4 border&quot;&gt;.col-6 .col-sm-4&lt;/div&gt;
&lt;!-- Force next columns to break to new line at md breakpoint and up --&gt;
&lt;div class=&quot;w-100 d-none d-md-block&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;col-6 col-sm-4 border&quot;&gt;.col-6 .col-sm-4&lt;/div&gt;
&lt;div class=&quot;col-6 col-sm-4 border&quot;&gt;.col-6 .col-sm-4&lt;/div&gt;
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
    <div class="col-6 col-sm-4">.col-6 .col-sm-4</div>
    <div class="col-6 col-sm-4">.col-6 .col-sm-4</div>

    <!-- Force next columns to break to new line at md breakpoint and up -->
    <div class="w-100 d-none d-md-block"></div>

    <div class="col-6 col-sm-4">.col-6 .col-sm-4</div>
    <div class="col-6 col-sm-4">.col-6 .col-sm-4</div>
  </div>
</div>
```

## Reordering

### Order classes

Klasy `.order-*` pozwalają kontrolować wizualną kolejność elementów. Są responsywne i obsługują wartości od `1` do `5`.

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
      First in DOM, no order applied
    &lt;/div&gt;
&lt;div class=&quot;col order-5 border&quot;&gt;
      Second in DOM, with a larger order
    &lt;/div&gt;
&lt;div class=&quot;col order-1 border&quot;&gt;
      Third in DOM, with an order of 1
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
      First in DOM, no order applied
    </div>
    <div class="col order-5">
      Second in DOM, with a larger order
    </div>
    <div class="col order-1">
      Third in DOM, with an order of 1
    </div>
  </div>
</div>
```

Dostępne są także klasy `.order-first` i `.order-last` które zmieniają `order` na `order: -1` i `order: 6`. Dzięki temu nasza kolumna ustawia się jako pierwsza lub ostatnia

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
&lt;div class=&quot;col order-last border&quot;&gt;
      First in DOM, ordered last
    &lt;/div&gt;
&lt;div class=&quot;col border&quot;&gt;
      Second in DOM, unordered
    &lt;/div&gt;
&lt;div class=&quot;col order-first border&quot;&gt;
      Third in DOM, ordered first
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
    <div class="col order-last">
      First in DOM, ordered last
    </div>
    <div class="col">
      Second in DOM, unordered
    </div>
    <div class="col order-first">
      Third in DOM, ordered first
    </div>
  </div>
</div>
```



```html
$utilities: map-merge(
  $utilities,
  (
    "order": map-merge(
      map-get($utilities, "order"),
      (
        values: map-merge(
          map-get(map-get($utilities, "order"), "values"),
          (
            6: 6, // Add a new `.order-{breakpoint}-6` utility
            last: 7 // Change the `.order-{breakpoint}-last` utility to use the next number
          )
        ),
      ),
    ),
  )
);
```

### Offsetting columns

Możesz przesuwać kolumny w siatce na dwa sposoby: za pomocą responsywnych klas siatki `.offset-` raz przy użyciu `margin utilities`. Klasy siatki mają szerokości dopasowane dokładnie do kolumn, natomiast marginesy są bardziej przydatne w szybkich układach, gdzie szerokość przesunięcia jest zmienna.

#### Offset classes

Przesuwaj kolumny w prawo, używając klas `.offset-md-*`. Klasy te zwiększają lewy margines kolumny o `*` kolumn. Na przykład, `.offset-md-4` przesuwa element `.col-md-4` o cztery kolumny w prawo.

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
&lt;div class=&quot;col-md-4 border&quot;&gt;.col-md-4&lt;/div&gt;
&lt;div class=&quot;col-md-4 offset-md-4 border&quot;&gt;.col-md-4 .offset-md-4&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-md-3 offset-md-3 border&quot;&gt;.col-md-3 .offset-md-3&lt;/div&gt;
&lt;div class=&quot;col-md-3 offset-md-3 border&quot;&gt;.col-md-3 .offset-md-3&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-md-6 offset-md-3 border&quot;&gt;.col-md-6 .offset-md-3&lt;/div&gt;
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
    <div class="col-md-4 border">.col-md-4</div>
    <div class="col-md-4 offset-md-4 border">.col-md-4 .offset-md-4</div>
  </div>
  <div class="row">
    <div class="col-md-3 offset-md-3 border">.col-md-3 .offset-md-3</div>
    <div class="col-md-3 offset-md-3 border">.col-md-3 .offset-md-3</div>
  </div>
  <div class="row">
    <div class="col-md-6 offset-md-3 border">.col-md-6 .offset-md-3</div>
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
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-sm-5 col-md-6 border&quot;&gt;.col-sm-5 .col-md-6&lt;/div&gt;
&lt;div class=&quot;col-sm-5 offset-sm-2 col-md-6 offset-md-0 border&quot;&gt;.col-sm-5 .offset-sm-2 .col-md-6 .offset-md-0&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-sm-6 col-md-5 col-lg-6 border&quot;&gt;.col-sm-6 .col-md-5 .col-lg-6&lt;/div&gt;
&lt;div class=&quot;col-sm-6 col-md-5 offset-md-2 col-lg-6 offset-lg-0 border&quot;&gt;.col-sm-6 .col-md-5 .offset-md-2 .col-lg-6 .offset-lg-0&lt;/div&gt;
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
    <div class="col-sm-5 col-md-6">.col-sm-5 .col-md-6</div>
    <div class="col-sm-5 offset-sm-2 col-md-6 offset-md-0">.col-sm-5 .offset-sm-2 .col-md-6 .offset-md-0</div>
  </div>
  <div class="row">
    <div class="col-sm-6 col-md-5 col-lg-6">.col-sm-6 .col-md-5 .col-lg-6</div>
    <div class="col-sm-6 col-md-5 offset-md-2 col-lg-6 offset-lg-0">.col-sm-6 .col-md-5 .offset-md-2 .col-lg-6 .offset-lg-0</div>
  </div>
</div>
```

#### Margin utilities

Dzięki flexboxowi możesz używać klas marginesów, takich jak `.me-auto` aby dynamicznie rozsuwać kolumny.

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
&lt;div class=&quot;col-md-4 border&quot;&gt;.col-md-4&lt;/div&gt;
&lt;div class=&quot;col-md-4 ms-auto border&quot;&gt;.col-md-4 .ms-auto&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-md-3 ms-md-auto border&quot;&gt;.col-md-3 .ms-md-auto&lt;/div&gt;
&lt;div class=&quot;col-md-3 ms-md-auto border&quot;&gt;.col-md-3 .ms-md-auto&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-auto me-auto border&quot;&gt;.col-auto .me-auto&lt;/div&gt;
&lt;div class=&quot;col-auto border&quot;&gt;.col-auto&lt;/div&gt;
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
    <div class="col-md-4">.col-md-4</div>
    <div class="col-md-4 ms-auto">.col-md-4 .ms-auto</div>
  </div>
  <div class="row">
    <div class="col-md-3 ms-md-auto">.col-md-3 .ms-md-auto</div>
    <div class="col-md-3 ms-md-auto">.col-md-3 .ms-md-auto</div>
  </div>
  <div class="row">
    <div class="col-auto me-auto">.col-auto .me-auto</div>
    <div class="col-auto">.col-auto</div>
  </div>
</div>
```

## Standalone column classes

Klasy `.col-*` mogą być używane również poza `.row` aby nadać elementowi określoną szerokość. W takim przypadku paddingi kolumn nie są stosowane.

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
     &lt;div class=&quot;col-3 p-3 mb-2 border&quot;&gt;
  .col-3: width of 25%
&lt;/div&gt;
&lt;div class=&quot;col-sm-9 p-3 border&quot;&gt;
  .col-sm-9: width of 75% above sm breakpoint
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="col-3 p-3 mb-2">
  .col-3: width of 25%
</div>

<div class="col-sm-9 p-3">
  .col-sm-9: width of 75% above sm breakpoint
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
     &lt;div class=&quot;clearfix&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Responsive floated image&quot; class=&quot;bd-placeholder-img col-md-6 float-md-end mb-3 ms-md-3&quot; height=&quot;210&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;100%&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#868e96&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#dee2e6&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Responsive floated image&lt;/text&gt;&lt;/svg&gt;
&lt;p&gt;
    A paragraph of placeholder text. We’re using it here to show the use of the clearfix class. We’re adding quite a few meaningless phrases here to demonstrate how the columns interact here with the floated image.
  &lt;/p&gt;
&lt;p&gt;
    As you can see the paragraphs gracefully wrap around the floated image. Now imagine how this would look with some actual content in here, rather than just this boring placeholder text that goes on and on, but actually conveys no tangible information at. It simply takes up space and should not really be read.
  &lt;/p&gt;
&lt;p&gt;
    And yet, here you are, still persevering in reading this placeholder text, hoping for some more insights, or some hidden easter egg of content. A joke, perhaps. Unfortunately, there’s none of that here.
  &lt;/p&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="clearfix">
  <img src="..." class="col-md-6 float-md-end mb-3 ms-md-3" alt="...">

  <p>
    A paragraph of placeholder text. We’re using it here to show the use of the clearfix class. We’re adding quite a few meaningless phrases here to demonstrate how the columns interact here with the floated image.
  </p>

  <p>
    As you can see the paragraphs gracefully wrap around the floated image. Now imagine how this would look with some actual content in here, rather than just this boring placeholder text that goes on and on, but actually conveys no tangible information at. It simply takes up space and should not really be read.
  </p>

  <p>
    And yet, here you are, still persevering in reading this placeholder text, hoping for some more insights, or some hidden easter egg of content. A joke, perhaps. Unfortunately, there’s none of that here.
  </p>
</div>
```


