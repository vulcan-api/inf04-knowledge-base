Powrót -> [Start](./root.md)

> Źródło: [https://getbootstrap.com/docs/5.3/content/tables](https://getbootstrap.com/docs/5.3/content/tables)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/content/tables.mdx "View and edit this file on GitHub")

# Tabele (Tables)

Dokumentacja oraz przykłady dotyczące **opcjonalnego stylowania tabel** (ze względu na ich powszechne użycie w wtyczkach JavaScript) w Bootstrap.

## Na tej stronie

---

* [Warianty](#warianty)
* [Tabele akcentowane](#tabele-akcentowane)
  + [Paski w wierszach](#paski-w-wierszach)
  + [Paski w kolumnach](#paski-w-kolumnach)
  + [Wiersze z efektem hover](#wiersze-z-efektem-hover)
  + [Aktywne tabele](#aktywne-tabele)
* [Jak działają warianty i tabele akcentowane?](#jak-działają-warianty-i-tabele-akcentowane)
* [Obramowania tabel](#obramowania-tabel)
  + [Tabele z obramowaniem](#tabele-z-obramowaniem)
  + [Tabele bez obramowania](#tabele-bez-obramowania)
* [Małe tabele](#małe-tabele)
* [Podziały grup tabel](#podziały-grup-tabel)
* [Wyrównanie pionowe](#wyrównanie-pionowe)
* [Zagnieżdżanie](#zagnieżdżanie)
* [Jak działa zagnieżdżanie](#jak-działa-zagnieżdżanie)
* [Anatomia](#anatomia)
  + [Nagłówek tabeli](#nagłówek-tabeli)
  + [Stopka tabeli](#stopka-tabeli)
  + [Podpisy](#podpisy)
* [Tabele responsywne](#tabele-responsywne)
  + [Zawsze responsywne](#zawsze-responsywne)
  + [Specyficzne dla breakpointu](#specyficzne-dla-breakpointu)
* [CSS](#css)
  + [Zmienne Sass](#zmienne-sass)
  + [Pętle Sass](#pętle-sass)
  + [Dostosowywanie](#dostosowywanie)
  + [Customizing](#customizing)

## Overview

Ze względu na szerokie wykorzystanie elementów `<table>` w zewnętrznych komponentach, takich jak kalendarze czy selektory dat, tabele w Bootstrap są **opcjonalne (opt-in)**. Aby je aktywować, dodaj podstawową klasę `.table` do dowolnego elementu `<table>`, a następnie rozszerz ją o opcjonalne klasy modyfikujące lub własne style.

Style tabel w Bootstrap **nie są dziedziczone**, co oznacza, że każda zagnieżdżona tabela może być stylowana niezależnie od tabeli nadrzędnej.

Poniżej pokazano, jak wygląda tabela oparta wyłącznie na klasie `.table`.

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
     &lt;table class=&quot;table&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table">
  <thead>
    <tr>
      <th scope="col">#</th>
      <th scope="col">First</th>
      <th scope="col">Last</th>
      <th scope="col">Handle</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope="row">1</th>
      <td>Mark</td>
      <td>Otto</td>
      <td>@mdo</td>
    </tr>
    <tr>
      <th scope="row">2</th>
      <td>Jacob</td>
      <td>Thornton</td>
      <td>@fat</td>
    </tr>
    <tr>
      <th scope="row">3</th>
      <td>John</td>
      <td>Doe</td>
      <td>@social</td>
    </tr>
  </tbody>
</table>
```

## Warianty

Użyj klas kontekstowych, aby kolorować całe tabele, pojedyncze wiersze lub konkretne komórki.

**Uwaga:** Ze względu na bardziej złożony CSS używany do generowania wariantów tabel, najprawdopodobniej nie będą one obsługiwać adaptacyjnego trybu kolorów aż do wersji Bootstrap v6.

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
    &lt;table class=&quot;table&quot;&gt;&lt;thead&gt;&lt;tr&gt;&lt;th scope=&quot;col&quot;&gt;Class&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt;&lt;tbody&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;Default&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr class=&quot;table-primary&quot;&gt;&lt;th scope=&quot;row&quot;&gt;Primary&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr class=&quot;table-secondary&quot;&gt;&lt;th scope=&quot;row&quot;&gt;Secondary&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr class=&quot;table-success&quot;&gt;&lt;th scope=&quot;row&quot;&gt;Success&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr class=&quot;table-danger&quot;&gt;&lt;th scope=&quot;row&quot;&gt;Danger&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr class=&quot;table-warning&quot;&gt;&lt;th scope=&quot;row&quot;&gt;Warning&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr class=&quot;table-info&quot;&gt;&lt;th scope=&quot;row&quot;&gt;Info&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr class=&quot;table-light&quot;&gt;&lt;th scope=&quot;row&quot;&gt;Light&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr class=&quot;table-dark&quot;&gt;&lt;th scope=&quot;row&quot;&gt;Dark&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;/tbody&gt;&lt;/table&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<!-- On tables -->
<table class="table-primary">...</table>
<table class="table-secondary">...</table>
<table class="table-success">...</table>
<table class="table-danger">...</table>
<table class="table-warning">...</table>
<table class="table-info">...</table>
<table class="table-light">...</table>
<table class="table-dark">...</table>

<!-- On rows -->
<tr class="table-primary">...</tr>
<tr class="table-secondary">...</tr>
<tr class="table-success">...</tr>
<tr class="table-danger">...</tr>
<tr class="table-warning">...</tr>
<tr class="table-info">...</tr>
<tr class="table-light">...</tr>
<tr class="table-dark">...</tr>

<!-- On cells (`td` or `th`) -->
<tr>
  <td class="table-primary">...</td>
  <td class="table-secondary">...</td>
  <td class="table-success">...</td>
  <td class="table-danger">...</td>
  <td class="table-warning">...</td>
  <td class="table-info">...</td>
  <td class="table-light">...</td>
  <td class="table-dark">...</td>
</tr>
```

**Wskazówka dotycząca dostępności:**
Samo użycie koloru do przekazywania znaczenia dostarcza jedynie informacji wizualnej, która nie będzie dostępna dla użytkowników technologii asystujących (np. czytników ekranu). Upewnij się, że znaczenie wynika również z treści (np. widocznego tekstu o odpowiednim kontraście) lub jest przekazane w inny sposób, np. poprzez dodatkowy tekst ukryty klasą `.visually-hidden`.

## Tabele akcentowane

### Paski w wierszach

Dodaj `.table-striped`, aby zastosować efekt „zebry” do wierszy w obrębie `<tbody>`.

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
     &lt;table class=&quot;table table-striped&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table table-striped">
  ...
</table>
```

### Paski w kolumnach

Użyj `.table-striped-columns`, aby dodać pasy do kolumn tabeli.

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
     &lt;table class=&quot;table table-striped-columns&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table table-striped-columns">
  ...
</table>
```

Klasy te można również łączyć z wariantami tabel:

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
     &lt;table class=&quot;table table-dark table-striped&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table table-dark table-striped">
  ...
</table>
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
     &lt;table class=&quot;table table-dark table-striped-columns&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table table-dark table-striped-columns">
  ...
</table>
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
     &lt;table class=&quot;table table-success table-striped&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table table-success table-striped">
  ...
</table>
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
     &lt;table class=&quot;table table-success table-striped-columns&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table table-success table-striped-columns">
  ...
</table>
```

### Wiersze z efektem hover

Dodaj `.table-hover`, aby włączyć efekt najechania kursorem na wiersze w `<tbody>`.

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
     &lt;table class=&quot;table table-hover&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table table-hover">
  ...
</table>
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
     &lt;table class=&quot;table table-dark table-hover&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table table-dark table-hover">
  ...
</table>
```

Efekt hover można łączyć z pasami:

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
     &lt;table class=&quot;table table-striped table-hover&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table table-striped table-hover">
  ...
</table>
```

### Aktywne tabele

Aby wyróżnić wiersz lub pojedynczą komórkę, użyj klasy `.table-active`.

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
    
&lt;table class=&quot;table&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr class=&quot;table-active&quot;&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td class=&quot;table-active&quot;&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table">
  <thead>
    ...
  </thead>
  <tbody>
    <tr class="table-active">
      ...
    </tr>
    <tr>
      ...
    </tr>
    <tr>
      <th scope="row">3</th>
      <td>John</td>
      <td>Doe</td>
      <td class="table-active">@social</td>
    </tr>
  </tbody>
</table>
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
    
&lt;table class=&quot;table table-dark&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr class=&quot;table-active&quot;&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td class=&quot;table-active&quot;&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table table-dark">
  <thead>
    ...
  </thead>
  <tbody>
    <tr class="table-active">
      ...
    </tr>
    <tr>
      ...
    </tr>
    <tr>
      <th scope="row">3</th>
      <td>John</td>
      <td>Doe</td>
      <td class="table-active">@social</td>
    </tr>
  </tbody>
</table>
```

## Jak działają warianty i tabele akcentowane?

Dla tabel akcentowanych (paski w wierszach, paski w kolumnach, hover, aktywne wiersze) Bootstrap stosuje kilka technik:

* Tło komórki tabeli jest ustawiane za pomocą zmiennej CSS `--bs-table-bg`.
* Następnie dodawany jest wewnętrzny `box-shadow`, który nakłada kolor akcentu ponad ewentualne `background-color`.
* Klasy `.table-striped`, `.table-hover` i `.table-active` ustawiają półprzezroczyste kolory stanów.
* Dla każdego wariantu tabeli generowany jest kolor akcentu o najwyższym kontraście.
* Kolory tekstu i obramowań są generowane w ten sam sposób i dziedziczone domyślnie.

```scss
@mixin table-variant($state, $background) {
  .table-#{$state} {
    ...
  }
}
```

[scss/mixins/\_table-variants.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/mixins/_table-variants.scss)

```html
@mixin table-variant($state, $background) {
  .table-#{$state} {
    $color: color-contrast(opaque($body-bg, $background));
    $hover-bg: mix($color, $background, percentage($table-hover-bg-factor));
    $striped-bg: mix($color, $background, percentage($table-striped-bg-factor));
    $active-bg: mix($color, $background, percentage($table-active-bg-factor));
    $table-border-color: mix($color, $background, percentage($table-border-factor));

    --#{$prefix}table-color: #{$color};
    --#{$prefix}table-bg: #{$background};
    --#{$prefix}table-border-color: #{$table-border-color};
    --#{$prefix}table-striped-bg: #{$striped-bg};
    --#{$prefix}table-striped-color: #{color-contrast($striped-bg)};
    --#{$prefix}table-active-bg: #{$active-bg};
    --#{$prefix}table-active-color: #{color-contrast($active-bg)};
    --#{$prefix}table-hover-bg: #{$hover-bg};
    --#{$prefix}table-hover-color: #{color-contrast($hover-bg)};

    color: var(--#{$prefix}table-color);
    border-color: var(--#{$prefix}table-border-color);
  }
}
```

## Obramowania tabel

### Tabele z obramowaniem

Dodaj `.table-bordered`, aby wyświetlić obramowanie po wszystkich stronach tabeli i jej komórek.

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
     &lt;table class=&quot;table table-bordered&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table table-bordered">
  ...
</table>
```


Możesz zmieniać kolor obramowania za pomocą narzędzi do obramowań:

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
     &lt;table class=&quot;table table-bordered border-primary&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table table-bordered border-primary">
  ...
</table>
```

### Tabele bez obramowania

Dodaj `.table-borderless`, aby wyświetlić tabelę bez obramowań.

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
     &lt;table class=&quot;table table-borderless&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table table-borderless">
  ...
</table>
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
     &lt;table class=&quot;table table-dark table-borderless&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table table-dark table-borderless">
  ...
</table>
```

## Małe tabele

Dodaj `.table-sm`, aby każda `.table` była bardziej kompaktowa poprzez zmniejszenie `padding` w komórkach o połowę.
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
     &lt;table class=&quot;table table-sm&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table table-sm">
  ...
</table>
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
     &lt;table class=&quot;table table-dark table-sm&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table table-dark table-sm">
  ...
</table>
```

## Podziały grup tabel

Dodaj grubszy, ciemniejszy border między grupami tabel—`<thead>`, `<tbody>` i `<tfoot>`—używając `.table-group-divider`. Kolor można dostosować zmieniając `border-top-color` (aktualnie nie ma dla tego klasy utility).

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
     &lt;table class=&quot;table&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody class=&quot;table-group-divider&quot;&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<table class="table">
  <thead>
    <tr>
      <th scope="col">#</th>
      <th scope="col">First</th>
      <th scope="col">Last</th>
      <th scope="col">Handle</th>
    </tr>
  </thead>
  <tbody class="table-group-divider">
    <tr>
      <th scope="row">1</th>
      <td>Mark</td>
      <td>Otto</td>
      <td>@mdo</td>
    </tr>
    <tr>
      <th scope="row">2</th>
      <td>Jacob</td>
      <td>Thornton</td>
      <td>@fat</td>
    </tr>
    <tr>
      <th scope="row">3</th>
      <td>John</td>
      <td>Doe</td>
      <td>@social</td>
    </tr>
  </tbody>
</table>
```

## Wyrównanie pionowe

Komórki `<thead>` są zawsze wyrównane pionowo do dołu. Komórki w `<tbody>` dziedziczą wyrównanie z `<table>` i są domyślnie wyrównane do góry. Użyj klas [vertical align](/docs/5.3/utilities/vertical-align), aby zmienić wyrównanie w razie potrzeby.

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
    
&lt;div class=&quot;table-responsive&quot;&gt;
&lt;table class=&quot;table align-middle&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th class=&quot;w-25&quot; scope=&quot;col&quot;&gt;Heading 1&lt;/th&gt;
&lt;th class=&quot;w-25&quot; scope=&quot;col&quot;&gt;Heading 2&lt;/th&gt;
&lt;th class=&quot;w-25&quot; scope=&quot;col&quot;&gt;Heading 3&lt;/th&gt;
&lt;th class=&quot;w-25&quot; scope=&quot;col&quot;&gt;Heading 4&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;td&gt;This cell inherits &lt;code&gt;vertical-align: middle;&lt;/code&gt; from the table&lt;/td&gt;
&lt;td&gt;This cell inherits &lt;code&gt;vertical-align: middle;&lt;/code&gt; from the table&lt;/td&gt;
&lt;td&gt;This cell inherits &lt;code&gt;vertical-align: middle;&lt;/code&gt; from the table&lt;/td&gt;
&lt;td&gt;This here is some placeholder text, intended to take up quite a bit of vertical space, to demonstrate how the vertical alignment works in the preceding cells.&lt;/td&gt;
&lt;/tr&gt;
&lt;tr class=&quot;align-bottom&quot;&gt;
&lt;td&gt;This cell inherits &lt;code&gt;vertical-align: bottom;&lt;/code&gt; from the table row&lt;/td&gt;
&lt;td&gt;This cell inherits &lt;code&gt;vertical-align: bottom;&lt;/code&gt; from the table row&lt;/td&gt;
&lt;td&gt;This cell inherits &lt;code&gt;vertical-align: bottom;&lt;/code&gt; from the table row&lt;/td&gt;
&lt;td&gt;This here is some placeholder text, intended to take up quite a bit of vertical space, to demonstrate how the vertical alignment works in the preceding cells.&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;td&gt;This cell inherits &lt;code&gt;vertical-align: middle;&lt;/code&gt; from the table&lt;/td&gt;
&lt;td&gt;This cell inherits &lt;code&gt;vertical-align: middle;&lt;/code&gt; from the table&lt;/td&gt;
&lt;td class=&quot;align-top&quot;&gt;This cell is aligned to the top.&lt;/td&gt;
&lt;td&gt;This here is some placeholder text, intended to take up quite a bit of vertical space, to demonstrate how the vertical alignment works in the preceding cells.&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt;
&lt;/div&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="table-responsive">
  <table class="table align-middle">
    <thead>
      <tr>
        ...
      </tr>
    </thead>
    <tbody>
      <tr>
        ...
      </tr>
      <tr class="align-bottom">
        ...
      </tr>
      <tr>
        <td>...</td>
        <td>...</td>
        <td class="align-top">This cell is aligned to the top.</td>
        <td>...</td>
      </tr>
    </tbody>
  </table>
</div>
```

## Zagnieżdżanie

Style borderów, aktywne style i warianty tabel nie są dziedziczone przez tabele zagnieżdżone.


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
    
&lt;table class=&quot;table table-striped table-bordered&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;td colspan=&quot;4&quot;&gt;
&lt;table class=&quot;table mb-0&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;Header&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Header&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Header&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;A&lt;/th&gt;
&lt;td&gt;First&lt;/td&gt;
&lt;td&gt;Last&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;B&lt;/th&gt;
&lt;td&gt;First&lt;/td&gt;
&lt;td&gt;Last&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;C&lt;/th&gt;
&lt;td&gt;First&lt;/td&gt;
&lt;td&gt;Last&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt;
&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table table-striped table-bordered">
  <thead>
    ...
  </thead>
  <tbody>
    ...
    <tr>
      <td colspan="4">
        <table class="table mb-0">
          ...
        </table>
      </td>
    </tr>
    ...
  </tbody>
</table>
```

## Jak działa zagnieżdżanie

Aby zapobiec *przeciekaniu* stylów do tabel zagnieżdżonych, używamy selektora child combinator (`>`) w CSS. Selekcja wygląda jak `.table > :not(caption) > * > *`, aby dotknąć wszystkich `td` i `th` w `.table`, ale nie w zagnieżdżonych tabelach.

## Budowa

### Nagłówek tabeli

Użyj modyfikatorów `.table-light` lub `.table-dark`, aby nagłówki wyglądały na jasne lub ciemne.

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
    
&lt;table class=&quot;table&quot;&gt;
&lt;thead class=&quot;table-light&quot;&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table">
  <thead class="table-light">
    ...
  </thead>
  <tbody>
    ...
  </tbody>
</table>
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
    
&lt;table class=&quot;table&quot;&gt;
&lt;thead class=&quot;table-dark&quot;&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table">
  <thead class="table-dark">
    ...
  </thead>
  <tbody>
    ...
  </tbody>
</table>
```

### Stopka tabeli

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
    
&lt;table class=&quot;table&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;tfoot&gt;
&lt;tr&gt;
&lt;td&gt;Footer&lt;/td&gt;
&lt;td&gt;Footer&lt;/td&gt;
&lt;td&gt;Footer&lt;/td&gt;
&lt;td&gt;Footer&lt;/td&gt;
&lt;/tr&gt;
&lt;/tfoot&gt;
&lt;/table&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table">
  <thead>
    ...
  </thead>
  <tbody>
    ...
  </tbody>
  <tfoot>
    ...
  </tfoot>
</table>
```

### Podpisy

`<caption>` działa jak nagłówek tabeli. Pomaga użytkownikom korzystającym z czytników ekranów zrozumieć tabelę.

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
    &lt;table class=&quot;table&quot;&gt;&lt;caption&gt;List of users&lt;/caption&gt; &lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;&lt;/table&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<table class="table table-sm">
  <caption>List of users</caption>
  <thead>
    ...
  </thead>
  <tbody>
    ...
  </tbody>
</table>
```

Podpis można też umieścić u góry tabeli z `.caption-top`.

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
     &lt;table class=&quot;table caption-top&quot;&gt;
&lt;caption&gt;List of users&lt;/caption&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;First&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Last&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Handle&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Mark&lt;/td&gt;
&lt;td&gt;Otto&lt;/td&gt;
&lt;td&gt;@mdo&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Jacob&lt;/td&gt;
&lt;td&gt;Thornton&lt;/td&gt;
&lt;td&gt;@fat&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;John&lt;/td&gt;
&lt;td&gt;Doe&lt;/td&gt;
&lt;td&gt;@social&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<table class="table caption-top">
  <caption>List of users</caption>
  <thead>
    <tr>
      <th scope="col">#</th>
      <th scope="col">First</th>
      <th scope="col">Last</th>
      <th scope="col">Handle</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope="row">1</th>
      <td>Mark</td>
      <td>Otto</td>
      <td>@mdo</td>
    </tr>
    <tr>
      <th scope="row">2</th>
      <td>Jacob</td>
      <td>Thornton</td>
      <td>@fat</td>
    </tr>
    <tr>
      <th scope="row">3</th>
      <td>John</td>
      <td>Doe</td>
      <td>@social</td>
    </tr>
  </tbody>
</table>
```

## Tabele responsywne

Tabele responsywne pozwalają na przewijanie poziome. Użyj `.table-responsive` albo z wyborem punktu przerwania `.table-responsive{-sm|-md|-lg|-xl|-xxl}`.

##### Przycinanie/obcinanie w pionie

Tabele responsywne korzystają z `overflow-y: hidden`, co powoduje przycinanie zawartości wychodzącej poza górne lub dolne krawędzie tabeli. W szczególności może to obcinać menu rozwijane i inne widżety firm trzecich.

## Zawsze responsywne

We wszystkich breakpointach używaj `.table-responsive` dla tabel przewijanych poziomo.

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
    
&lt;div class=&quot;table-responsive&quot;&gt;
&lt;table class=&quot;table&quot;&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;
&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;td&gt;Cell&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt;
&lt;/div&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="table-responsive">
  <table class="table">
    ...
  </table>
</div>
```

## Specyficzne dla breakpointu

Używaj `.table-responsive{-sm|-md|-lg|-xl|-xxl}` w zależności od potrzeb, aby stworzyć responsywne tabele do określonego breakpointu. Od tego breakpointu wzwyż tabela zachowuje się normalnie i nie przewija się poziomo.

**Tabele mogą wyglądać źle dopóki style responsywne nie zostaną zastosowane przy określonej szerokości widoku.**

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
    &lt;div class=&quot;table-responsive&quot;&gt;&lt;table class=&quot;table&quot;&gt;&lt;thead&gt;&lt;tr&gt;&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt;&lt;tbody&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;/tbody&gt;&lt;/table&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>
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
    &lt;div class=&quot;table-responsive-sm&quot;&gt;&lt;table class=&quot;table&quot;&gt;&lt;thead&gt;&lt;tr&gt;&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt;&lt;tbody&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;/tbody&gt;&lt;/table&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>
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
    &lt;div class=&quot;table-responsive-md&quot;&gt;&lt;table class=&quot;table&quot;&gt;&lt;thead&gt;&lt;tr&gt;&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt;&lt;tbody&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;/tbody&gt;&lt;/table&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>
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
    &lt;div class=&quot;table-responsive-lg&quot;&gt;&lt;table class=&quot;table&quot;&gt;&lt;thead&gt;&lt;tr&gt;&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt;&lt;tbody&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;/tbody&gt;&lt;/table&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>
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
    &lt;div class=&quot;table-responsive-xl&quot;&gt;&lt;table class=&quot;table&quot;&gt;&lt;thead&gt;&lt;tr&gt;&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt;&lt;tbody&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;/tbody&gt;&lt;/table&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>
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
    &lt;div class=&quot;table-responsive-xxl&quot;&gt;&lt;table class=&quot;table&quot;&gt;&lt;thead&gt;&lt;tr&gt;&lt;th scope=&quot;col&quot;&gt;#&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;th scope=&quot;col&quot;&gt;Heading&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt;&lt;tbody&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;1&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;2&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;th scope=&quot;row&quot;&gt;3&lt;/th&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;td&gt;Cell&lt;/td&gt;&lt;/tr&gt;&lt;/tbody&gt;&lt;/table&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="table-responsive">
  <table class="table">
    ...
  </table>
</div>

<div class="table-responsive-sm">
  <table class="table">
    ...
  </table>
</div>

<div class="table-responsive-md">
  <table class="table">
    ...
  </table>
</div>

<div class="table-responsive-lg">
  <table class="table">
    ...
  </table>
</div>

<div class="table-responsive-xl">
  <table class="table">
    ...
  </table>
</div>

<div class="table-responsive-xxl">
  <table class="table">
    ...
  </table>
</div>
```

## CSS

### Zmienne Sass

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$table-cell-padding-y:        .5rem;
$table-cell-padding-x:        .5rem;
$table-cell-padding-y-sm:     .25rem;
$table-cell-padding-x-sm:     .25rem;

$table-cell-vertical-align:   top;

$table-color:                 var(--#{$prefix}emphasis-color);
$table-bg:                    var(--#{$prefix}body-bg);
$table-accent-bg:             transparent;

$table-th-font-weight:        null;

$table-striped-color:         $table-color;
$table-striped-bg-factor:     .05;
$table-striped-bg:            rgba(var(--#{$prefix}emphasis-color-rgb), $table-striped-bg-factor);

$table-active-color:          $table-color;
$table-active-bg-factor:      .1;
$table-active-bg:             rgba(var(--#{$prefix}emphasis-color-rgb), $table-active-bg-factor);

$table-hover-color:           $table-color;
$table-hover-bg-factor:       .075;
$table-hover-bg:              rgba(var(--#{$prefix}emphasis-color-rgb), $table-hover-bg-factor);

$table-border-factor:         .2;
$table-border-width:          var(--#{$prefix}border-width);
$table-border-color:          var(--#{$prefix}border-color);

$table-striped-order:         odd;
$table-striped-columns-order: even;

$table-group-separator-color: currentcolor;

$table-caption-color:         var(--#{$prefix}secondary-color);

$table-bg-scale:              -80%;
```

### Pętle Sass

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$table-variants: (
  "primary":    shift-color($primary, $table-bg-scale),
  "secondary":  shift-color($secondary, $table-bg-scale),
  "success":    shift-color($success, $table-bg-scale),
  "info":       shift-color($info, $table-bg-scale),
  "warning":    shift-color($warning, $table-bg-scale),
  "danger":     shift-color($danger, $table-bg-scale),
  "light":      $light,
  "dark":       $dark,
);
```

### Dostosowywanie

* Zmienne typu factor (`$table-striped-bg-factor`, `$table-active-bg-factor`, `$table-hover-bg-factor`) określają kontrast w wariantach tabel.
* Poza wariantami light i dark, kolory motywu są rozjaśniane przy użyciu zmiennej `$table-bg-scale`.


