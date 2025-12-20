> Źródło: [https://getbootstrap.com/docs/5.3/content/tables](https://getbootstrap.com/docs/5.3/content/tables)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/content/tables.mdx "View and edit this file on GitHub")

# Tables

Documentation and examples for opt-in styling of tables (given their prevalent use in JavaScript plugins) with Bootstrap.

On this page
   
**On this page**

---

* [Overview](#overview)
* [Variants](#variants)
* [Accented tables](#accented-tables)
  + [Striped rows](#striped-rows)
  + [Striped columns](#striped-columns)
  + [Hoverable rows](#hoverable-rows)
  + [Active tables](#active-tables)
* [How do the variants and accented tables work?](#how-do-the-variants-and-accented-tables-work)
* [Table borders](#table-borders)
  + [Bordered tables](#bordered-tables)
  + [Tables without borders](#tables-without-borders)
* [Small tables](#small-tables)
* [Table group dividers](#table-group-dividers)
* [Vertical alignment](#vertical-alignment)
* [Nesting](#nesting)
* [How nesting works](#how-nesting-works)
* [Anatomy](#anatomy)
  + [Table head](#table-head)
  + [Table foot](#table-foot)
  + [Captions](#captions)
* [Responsive tables](#responsive-tables)
  + [Always responsive](#always-responsive)
  + [Breakpoint specific](#breakpoint-specific)
* [CSS](#css)
  + [Sass variables](#sass-variables)
  + [Sass loops](#sass-loops)
  + [Customizing](#customizing)

## Overview

Due to the widespread use of `<table>` elements across third-party widgets like calendars and date pickers, Bootstrap’s tables are **opt-in**. Add the base class `.table` to any `<table>`, then extend with our optional modifier classes or custom styles. All table styles are not inherited in Bootstrap, meaning any nested tables can be styled independent from the parent.

Using the most basic table markup, here’s how `.table`-based tables look in Bootstrap.

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

## Variants

Use contextual classes to color tables, table rows or individual cells.

**Heads up!** Because of the more complicated CSS used to generate our table variants, they most likely won’t see color mode adaptive styling until v6.

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

**Accessibility tip:** Using color to add meaning only provides a visual indication, which will not be conveyed to users of assistive technologies like screen readers. Please ensure the meaning is obvious from the content itself (e.g., the visible text with a [*sufficient* color contrast](/docs/5.3/getting-started/accessibility/#color-contrast)) or is included through alternative means, such as additional text hidden with the `.visually-hidden` class.

## Accented tables

### Striped rows

Use `.table-striped` to add zebra-striping to any table row within the `<tbody>`.

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

### Striped columns

Use `.table-striped-columns` to add zebra-striping to any table column.

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

These classes can also be added to table variants:

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

### Hoverable rows

Add `.table-hover` to enable a hover state on table rows within a `<tbody>`.

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

These hoverable rows can also be combined with the striped rows variant:

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

### Active tables

Highlight a table row or cell by adding a `.table-active` class.

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

## How do the variants and accented tables work?

For the accented tables ([striped rows](#striped-rows), [striped columns](#striped-columns), [hoverable rows](#hoverable-rows), and [active tables](#active-tables)), we used some techniques to make these effects work for all our [table variants](#variants):

* We start by setting the background of a table cell with the `--bs-table-bg` custom property. All table variants then set that custom property to colorize the table cells. This way, we don’t get into trouble if semi-transparent colors are used as table backgrounds.
* Then we add an inset box shadow on the table cells with `box-shadow: inset 0 0 0 9999px var(--bs-table-bg-state, var(--bs-table-bg-type, var(--bs-table-accent-bg)));` to layer on top of any specified `background-color`. It uses custom cascade to override the `box-shadow`, regardless the CSS specificity. Because we use a huge spread and no blur, the color will be monotone. Since `--bs-table-accent-bg` is set to `transparent` by default, we don’t have a default box shadow.
* When either `.table-striped`, `.table-striped-columns`, `.table-hover` or `.table-active` classes are added, either `--bs-table-bg-type` or `--bs-table-bg-state` (by default set to `initial`) are set to a semitransparent color (`--bs-table-striped-bg`, `--bs-table-active-bg` or `--bs-table-hover-bg`) to colorize the background and override default `--bs-table-accent-bg`.
* For each table variant, we generate a `--bs-table-accent-bg` color with the highest contrast depending on that color. For example, the accent color for `.table-primary` is darker while `.table-dark` has a lighter accent color.
* Text and border colors are generated the same way, and their colors are inherited by default.

Behind the scenes it looks like this:

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

## Table borders

### Bordered tables

Add `.table-bordered` for borders on all sides of the table and cells.

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

[Border color utilities](/docs/5.3/utilities/borders#border-color) can be added to change colors:

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

### Tables without borders

Add `.table-borderless` for a table without borders.

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

## Small tables

Add `.table-sm` to make any `.table` more compact by cutting all cell `padding` in half.

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

## Table group dividers

Add a thicker border, darker between table groups—`<thead>`, `<tbody>`, and `<tfoot>`—with `.table-group-divider`. Customize the color by changing the `border-top-color` (which we don’t currently provide a utility class for at this time).

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

## Vertical alignment

Table cells of `<thead>` are always vertical aligned to the bottom. Table cells in `<tbody>` inherit their alignment from `<table>` and are aligned to the top by default. Use the [vertical align](/docs/5.3/utilities/vertical-align) classes to re-align where needed.

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

## Nesting

Border styles, active styles, and table variants are not inherited by nested tables.

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

## How nesting works

To prevent *any* styles from leaking to nested tables, we use the child combinator (`>`) selector in our CSS. Since we need to target all the `td`s and `th`s in the `thead`, `tbody`, and `tfoot`, our selector would look pretty long without it. As such, we use the rather odd looking `.table > :not(caption) > * > *` selector to target all `td`s and `th`s of the `.table`, but none of any potential nested tables.

Note that if you add `<tr>`s as direct children of a table, those `<tr>` will be wrapped in a `<tbody>` by default, thus making our selectors work as intended.

## Anatomy

### Table head

Similar to tables and dark tables, use the modifier classes `.table-light` or `.table-dark` to make `<thead>`s appear light or dark gray.

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

### Table foot

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

### Captions

A `<caption>` functions like a heading for a table. It helps users with screen readers to find a table and understand what it’s about and decide if they want to read it.

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

You can also put the `<caption>` on the top of the table with `.caption-top`.

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

## Responsive tables

Responsive tables allow tables to be scrolled horizontally with ease. Make any table responsive across all viewports by wrapping a `.table` with `.table-responsive`. Or, pick a maximum breakpoint with which to have a responsive table up to by using `.table-responsive{-sm|-md|-lg|-xl|-xxl}`.

##### Vertical clipping/truncation

Responsive tables make use of `overflow-y: hidden`, which clips off any content that goes beyond the bottom or top edges of the table. In particular, this can clip off dropdown menus and other third-party widgets.

### Always responsive

Across every breakpoint, use `.table-responsive` for horizontally scrolling tables.

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

### Breakpoint specific

Use `.table-responsive{-sm|-md|-lg|-xl|-xxl}` as needed to create responsive tables up to a particular breakpoint. From that breakpoint and up, the table will behave normally and not scroll horizontally.

**These tables may appear broken until their responsive styles apply at specific viewport widths.**

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

### Sass variables

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

### Sass loops

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

### Customizing

* The factor variables (`$table-striped-bg-factor`, `$table-active-bg-factor` & `$table-hover-bg-factor`) are used to determine the contrast in table variants.
* Apart from the light & dark table variants, theme colors are lightened by the `$table-bg-scale` variable.

