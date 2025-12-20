> Źródło: [https://getbootstrap.com/docs/5.3/utilities/flex](https://getbootstrap.com/docs/5.3/utilities/flex)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/utilities/flex.mdx "View and edit this file on GitHub")

# Flex

Quickly manage the layout, alignment, and sizing of grid columns, navigation, components, and more with a full suite of responsive flexbox utilities. For more complex implementations, custom CSS may be necessary.

On this page
   
**On this page**

---

* [Enable flex behaviors](#enable-flex-behaviors)
* [Direction](#direction)
* [Justify content](#justify-content)
* [Align items](#align-items)
* [Align self](#align-self)
* [Fill](#fill)
* [Grow and shrink](#grow-and-shrink)
* [Auto margins](#auto-margins)
  + [With align-items](#with-align-items)
* [Wrap](#wrap)
* [Order](#order)
* [Align content](#align-content)
* [Media object](#media-object)
* [CSS](#css)
  + [Sass utilities API](#sass-utilities-api)

## Enable flex behaviors

Apply `display` utilities to create a flexbox container and transform **direct children elements** into flex items. Flex containers and items are able to be modified further with additional flex properties.

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
     &lt;div class=&quot;d-flex p-2&quot;&gt;I&#x27;m a flexbox container!&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="d-flex p-2">I'm a flexbox container!</div>
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
     &lt;div class=&quot;d-inline-flex p-2&quot;&gt;I&#x27;m an inline flexbox container!&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="d-inline-flex p-2">I'm an inline flexbox container!</div>
```

Responsive variations also exist for `.d-flex` and `.d-inline-flex`.

* `.d-flex`
* `.d-inline-flex`
* `.d-sm-flex`
* `.d-sm-inline-flex`
* `.d-md-flex`
* `.d-md-inline-flex`
* `.d-lg-flex`
* `.d-lg-inline-flex`
* `.d-xl-flex`
* `.d-xl-inline-flex`
* `.d-xxl-flex`
* `.d-xxl-inline-flex`

## Direction

Set the direction of flex items in a flex container with direction utilities. In most cases you can omit the horizontal class here as the browser default is `row`. However, you may encounter situations where you needed to explicitly set this value (like responsive layouts).

Use `.flex-row` to set a horizontal direction (the browser default), or `.flex-row-reverse` to start the horizontal direction from the opposite side.

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
     &lt;div class=&quot;d-flex flex-row mb-3&quot;&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item 1&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item 2&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item 3&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;d-flex flex-row-reverse&quot;&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item 1&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item 2&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item 3&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="d-flex flex-row mb-3">
  <div class="p-2">Flex item 1</div>
  <div class="p-2">Flex item 2</div>
  <div class="p-2">Flex item 3</div>
</div>
<div class="d-flex flex-row-reverse">
  <div class="p-2">Flex item 1</div>
  <div class="p-2">Flex item 2</div>
  <div class="p-2">Flex item 3</div>
</div>
```

Use `.flex-column` to set a vertical direction, or `.flex-column-reverse` to start the vertical direction from the opposite side.

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
     &lt;div class=&quot;d-flex flex-column mb-3&quot;&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item 1&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item 2&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item 3&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;d-flex flex-column-reverse&quot;&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item 1&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item 2&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item 3&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="d-flex flex-column mb-3">
  <div class="p-2">Flex item 1</div>
  <div class="p-2">Flex item 2</div>
  <div class="p-2">Flex item 3</div>
</div>
<div class="d-flex flex-column-reverse">
  <div class="p-2">Flex item 1</div>
  <div class="p-2">Flex item 2</div>
  <div class="p-2">Flex item 3</div>
</div>
```

Responsive variations also exist for `flex-direction`.

* `.flex-row`
* `.flex-row-reverse`
* `.flex-column`
* `.flex-column-reverse`
* `.flex-sm-row`
* `.flex-sm-row-reverse`
* `.flex-sm-column`
* `.flex-sm-column-reverse`
* `.flex-md-row`
* `.flex-md-row-reverse`
* `.flex-md-column`
* `.flex-md-column-reverse`
* `.flex-lg-row`
* `.flex-lg-row-reverse`
* `.flex-lg-column`
* `.flex-lg-column-reverse`
* `.flex-xl-row`
* `.flex-xl-row-reverse`
* `.flex-xl-column`
* `.flex-xl-column-reverse`
* `.flex-xxl-row`
* `.flex-xxl-row-reverse`
* `.flex-xxl-column`
* `.flex-xxl-column-reverse`

## Justify content

Use `justify-content` utilities on flexbox containers to change the alignment of flex items on the main axis (the x-axis to start, y-axis if `flex-direction: column`). Choose from `start` (browser default), `end`, `center`, `between`, `around`, or `evenly`.

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
    &lt;div class=&quot;d-flex justify-content-start mb-3&quot;&gt;&lt;div class=&quot;p-2 bd-highlight&quot;&gt;Justify&lt;/div&gt;&lt;div class=&quot;p-2 bd-highlight&quot;&gt;Content&lt;/div&gt;&lt;div class=&quot;p-2 bd-highlight&quot;&gt;Start&lt;/div&gt;&lt;/div&gt;&lt;div class=&quot;d-flex justify-content-end mb-3&quot;&gt;&lt;div class=&quot;p-2 bd-highlight&quot;&gt;Justify&lt;/div&gt;&lt;div class=&quot;p-2 bd-highlight&quot;&gt;Content&lt;/div&gt;&lt;div class=&quot;p-2 bd-highlight&quot;&gt;End&lt;/div&gt;&lt;/div&gt;&lt;div class=&quot;d-flex justify-content-center mb-3&quot;&gt;&lt;div class=&quot;p-2 bd-highlight&quot;&gt;Justify&lt;/div&gt;&lt;div class=&quot;p-2 bd-highlight&quot;&gt;Content&lt;/div&gt;&lt;div class=&quot;p-2 bd-highlight&quot;&gt;Center&lt;/div&gt;&lt;/div&gt;&lt;div class=&quot;d-flex justify-content-between mb-3&quot;&gt;&lt;div class=&quot;p-2 bd-highlight&quot;&gt;Justify&lt;/div&gt;&lt;div class=&quot;p-2 bd-highlight&quot;&gt;Content&lt;/div&gt;&lt;div class=&quot;p-2 bd-highlight&quot;&gt;Between&lt;/div&gt;&lt;/div&gt;&lt;div class=&quot;d-flex justify-content-around mb-3&quot;&gt;&lt;div class=&quot;p-2 bd-highlight&quot;&gt;Justify&lt;/div&gt;&lt;div class=&quot;p-2 bd-highlight&quot;&gt;Content&lt;/div&gt;&lt;div class=&quot;p-2 bd-highlight&quot;&gt;Around&lt;/div&gt;&lt;/div&gt;&lt;div class=&quot;d-flex justify-content-evenly&quot;&gt;&lt;div class=&quot;p-2 bd-highlight&quot;&gt;Justify&lt;/div&gt;&lt;div class=&quot;p-2 bd-highlight&quot;&gt;Content&lt;/div&gt;&lt;div class=&quot;p-2 bd-highlight&quot;&gt;Evenly&lt;/div&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="d-flex justify-content-start">...</div>
<div class="d-flex justify-content-end">...</div>
<div class="d-flex justify-content-center">...</div>
<div class="d-flex justify-content-between">...</div>
<div class="d-flex justify-content-around">...</div>
<div class="d-flex justify-content-evenly">...</div>
```

Responsive variations also exist for `justify-content`.

* `.justify-content-start`
* `.justify-content-end`
* `.justify-content-center`
* `.justify-content-between`
* `.justify-content-around`
* `.justify-content-evenly`
* `.justify-content-sm-start`
* `.justify-content-sm-end`
* `.justify-content-sm-center`
* `.justify-content-sm-between`
* `.justify-content-sm-around`
* `.justify-content-sm-evenly`
* `.justify-content-md-start`
* `.justify-content-md-end`
* `.justify-content-md-center`
* `.justify-content-md-between`
* `.justify-content-md-around`
* `.justify-content-md-evenly`
* `.justify-content-lg-start`
* `.justify-content-lg-end`
* `.justify-content-lg-center`
* `.justify-content-lg-between`
* `.justify-content-lg-around`
* `.justify-content-lg-evenly`
* `.justify-content-xl-start`
* `.justify-content-xl-end`
* `.justify-content-xl-center`
* `.justify-content-xl-between`
* `.justify-content-xl-around`
* `.justify-content-xl-evenly`
* `.justify-content-xxl-start`
* `.justify-content-xxl-end`
* `.justify-content-xxl-center`
* `.justify-content-xxl-between`
* `.justify-content-xxl-around`
* `.justify-content-xxl-evenly`

## Align items

Use `align-items` utilities on flexbox containers to change the alignment of flex items on the cross axis (the y-axis to start, x-axis if `flex-direction: column`). Choose from `start`, `end`, `center`, `baseline`, or `stretch` (browser default).

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
    &lt;div class=&quot;d-flex align-items-start mb-3&quot; style=&quot;height: 100px&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;/div&gt;&lt;div class=&quot;d-flex align-items-end mb-3&quot; style=&quot;height: 100px&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;/div&gt;&lt;div class=&quot;d-flex align-items-center mb-3&quot; style=&quot;height: 100px&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;/div&gt;&lt;div class=&quot;d-flex align-items-baseline mb-3&quot; style=&quot;height: 100px&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;/div&gt;&lt;div class=&quot;d-flex align-items-stretch&quot; style=&quot;height: 100px&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="d-flex align-items-start">...</div>
<div class="d-flex align-items-end">...</div>
<div class="d-flex align-items-center">...</div>
<div class="d-flex align-items-baseline">...</div>
<div class="d-flex align-items-stretch">...</div>
```

Responsive variations also exist for `align-items`.

* `.align-items-start`
* `.align-items-end`
* `.align-items-center`
* `.align-items-baseline`
* `.align-items-stretch`
* `.align-items-sm-start`
* `.align-items-sm-end`
* `.align-items-sm-center`
* `.align-items-sm-baseline`
* `.align-items-sm-stretch`
* `.align-items-md-start`
* `.align-items-md-end`
* `.align-items-md-center`
* `.align-items-md-baseline`
* `.align-items-md-stretch`
* `.align-items-lg-start`
* `.align-items-lg-end`
* `.align-items-lg-center`
* `.align-items-lg-baseline`
* `.align-items-lg-stretch`
* `.align-items-xl-start`
* `.align-items-xl-end`
* `.align-items-xl-center`
* `.align-items-xl-baseline`
* `.align-items-xl-stretch`
* `.align-items-xxl-start`
* `.align-items-xxl-end`
* `.align-items-xxl-center`
* `.align-items-xxl-baseline`
* `.align-items-xxl-stretch`

## Align self

Use `align-self` utilities on flexbox items to individually change their alignment on the cross axis (the y-axis to start, x-axis if `flex-direction: column`). Choose from the same options as `align-items`: `start`, `end`, `center`, `baseline`, or `stretch` (browser default).

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
    &lt;div class=&quot;d-flex mb-3&quot; style=&quot;height: 100px&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;align-self-start p-2&quot;&gt;Aligned flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;/div&gt;&lt;div class=&quot;d-flex mb-3&quot; style=&quot;height: 100px&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;align-self-end p-2&quot;&gt;Aligned flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;/div&gt;&lt;div class=&quot;d-flex mb-3&quot; style=&quot;height: 100px&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;align-self-center p-2&quot;&gt;Aligned flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;/div&gt;&lt;div class=&quot;d-flex mb-3&quot; style=&quot;height: 100px&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;align-self-baseline p-2&quot;&gt;Aligned flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;/div&gt;&lt;div class=&quot;d-flex&quot; style=&quot;height: 100px&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;align-self-stretch p-2&quot;&gt;Aligned flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="align-self-start">Aligned flex item</div>
<div class="align-self-end">Aligned flex item</div>
<div class="align-self-center">Aligned flex item</div>
<div class="align-self-baseline">Aligned flex item</div>
<div class="align-self-stretch">Aligned flex item</div>
```

Responsive variations also exist for `align-self`.

* `.align-self-start`
* `.align-self-end`
* `.align-self-center`
* `.align-self-baseline`
* `.align-self-stretch`
* `.align-self-sm-start`
* `.align-self-sm-end`
* `.align-self-sm-center`
* `.align-self-sm-baseline`
* `.align-self-sm-stretch`
* `.align-self-md-start`
* `.align-self-md-end`
* `.align-self-md-center`
* `.align-self-md-baseline`
* `.align-self-md-stretch`
* `.align-self-lg-start`
* `.align-self-lg-end`
* `.align-self-lg-center`
* `.align-self-lg-baseline`
* `.align-self-lg-stretch`
* `.align-self-xl-start`
* `.align-self-xl-end`
* `.align-self-xl-center`
* `.align-self-xl-baseline`
* `.align-self-xl-stretch`
* `.align-self-xxl-start`
* `.align-self-xxl-end`
* `.align-self-xxl-center`
* `.align-self-xxl-baseline`
* `.align-self-xxl-stretch`

## Fill

Use the `.flex-fill` class on a series of sibling elements to force them into widths equal to their content (or equal widths if their content does not surpass their border-boxes) while taking up all available horizontal space.

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
     &lt;div class=&quot;d-flex&quot;&gt;
&lt;div class=&quot;p-2 flex-fill&quot;&gt;Flex item with a lot of content&lt;/div&gt;
&lt;div class=&quot;p-2 flex-fill&quot;&gt;Flex item&lt;/div&gt;
&lt;div class=&quot;p-2 flex-fill&quot;&gt;Flex item&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="d-flex">
  <div class="p-2 flex-fill">Flex item with a lot of content</div>
  <div class="p-2 flex-fill">Flex item</div>
  <div class="p-2 flex-fill">Flex item</div>
</div>
```

Responsive variations also exist for `flex-fill`.

* `.flex-fill`
* `.flex-sm-fill`
* `.flex-md-fill`
* `.flex-lg-fill`
* `.flex-xl-fill`
* `.flex-xxl-fill`

## Grow and shrink

Use `.flex-grow-*` utilities to toggle a flex item’s ability to grow to fill available space. In the example below, the `.flex-grow-1` elements uses all available space it can, while allowing the remaining two flex items their necessary space.

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
     &lt;div class=&quot;d-flex&quot;&gt;
&lt;div class=&quot;p-2 flex-grow-1&quot;&gt;Flex item&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Third flex item&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="d-flex">
  <div class="p-2 flex-grow-1">Flex item</div>
  <div class="p-2">Flex item</div>
  <div class="p-2">Third flex item</div>
</div>
```

Use `.flex-shrink-*` utilities to toggle a flex item’s ability to shrink if necessary. In the example below, the second flex item with `.flex-shrink-1` is forced to wrap its contents to a new line, “shrinking” to allow more space for the previous flex item with `.w-100`.

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
     &lt;div class=&quot;d-flex&quot;&gt;
&lt;div class=&quot;p-2 w-100&quot;&gt;Flex item&lt;/div&gt;
&lt;div class=&quot;p-2 flex-shrink-1&quot;&gt;Flex item&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="d-flex">
  <div class="p-2 w-100">Flex item</div>
  <div class="p-2 flex-shrink-1">Flex item</div>
</div>
```

Responsive variations also exist for `flex-grow` and `flex-shrink`.

* `.flex-{grow|shrink}-0`
* `.flex-{grow|shrink}-1`
* `.flex-sm-{grow|shrink}-0`
* `.flex-sm-{grow|shrink}-1`
* `.flex-md-{grow|shrink}-0`
* `.flex-md-{grow|shrink}-1`
* `.flex-lg-{grow|shrink}-0`
* `.flex-lg-{grow|shrink}-1`
* `.flex-xl-{grow|shrink}-0`
* `.flex-xl-{grow|shrink}-1`
* `.flex-xxl-{grow|shrink}-0`
* `.flex-xxl-{grow|shrink}-1`

## Auto margins

Flexbox can do some pretty awesome things when you mix flex alignments with auto margins. Shown below are three examples of controlling flex items via auto margins: default (no auto margin), pushing two items to the right (`.me-auto`), and pushing two items to the left (`.ms-auto`).

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
     &lt;div class=&quot;d-flex mb-3&quot;&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;d-flex mb-3&quot;&gt;
&lt;div class=&quot;me-auto p-2&quot;&gt;Flex item&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;d-flex mb-3&quot;&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;
&lt;div class=&quot;ms-auto p-2&quot;&gt;Flex item&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="d-flex mb-3">
  <div class="p-2">Flex item</div>
  <div class="p-2">Flex item</div>
  <div class="p-2">Flex item</div>
</div>

<div class="d-flex mb-3">
  <div class="me-auto p-2">Flex item</div>
  <div class="p-2">Flex item</div>
  <div class="p-2">Flex item</div>
</div>

<div class="d-flex mb-3">
  <div class="p-2">Flex item</div>
  <div class="p-2">Flex item</div>
  <div class="ms-auto p-2">Flex item</div>
</div>
```

### With align-items

Vertically move one flex item to the top or bottom of a container by mixing `align-items`, `flex-direction: column`, and `margin-top: auto` or `margin-bottom: auto`.

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
     &lt;div class=&quot;d-flex align-items-start flex-column mb-3&quot; style=&quot;height: 200px;&quot;&gt;
&lt;div class=&quot;mb-auto p-2&quot;&gt;Flex item&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;d-flex align-items-end flex-column mb-3&quot; style=&quot;height: 200px;&quot;&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;
&lt;div class=&quot;mt-auto p-2&quot;&gt;Flex item&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="d-flex align-items-start flex-column mb-3" style="height: 200px;">
  <div class="mb-auto p-2">Flex item</div>
  <div class="p-2">Flex item</div>
  <div class="p-2">Flex item</div>
</div>

<div class="d-flex align-items-end flex-column mb-3" style="height: 200px;">
  <div class="p-2">Flex item</div>
  <div class="p-2">Flex item</div>
  <div class="mt-auto p-2">Flex item</div>
</div>
```

## Wrap

Change how flex items wrap in a flex container. Choose from no wrapping at all (the browser default) with `.flex-nowrap`, wrapping with `.flex-wrap`, or reverse wrapping with `.flex-wrap-reverse`.

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
    &lt;div class=&quot;d-flex flex-nowrap&quot; style=&quot;width: 8rem;&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="d-flex flex-nowrap">
  ...
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
    &lt;div class=&quot;d-flex flex-wrap&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 1&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 2&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 3&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 4&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 5&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 6&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 7&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 8&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 9&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 10&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 11&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 12&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 13&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 14&lt;/div&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="d-flex flex-wrap">
  ...
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
    &lt;div class=&quot;d-flex flex-wrap-reverse&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 1&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 2&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 3&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 4&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 5&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 6&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 7&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 8&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 9&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 10&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 11&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 12&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 13&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item 14&lt;/div&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="d-flex flex-wrap-reverse">
  ...
</div>
```

Responsive variations also exist for `flex-wrap`.

* `.flex-nowrap`
* `.flex-wrap`
* `.flex-wrap-reverse`
* `.flex-sm-nowrap`
* `.flex-sm-wrap`
* `.flex-sm-wrap-reverse`
* `.flex-md-nowrap`
* `.flex-md-wrap`
* `.flex-md-wrap-reverse`
* `.flex-lg-nowrap`
* `.flex-lg-wrap`
* `.flex-lg-wrap-reverse`
* `.flex-xl-nowrap`
* `.flex-xl-wrap`
* `.flex-xl-wrap-reverse`
* `.flex-xxl-nowrap`
* `.flex-xxl-wrap`
* `.flex-xxl-wrap-reverse`

## Order

Change the *visual* order of specific flex items with a handful of `order` utilities. We only provide options for making an item first or last, as well as a reset to use the DOM order. As `order` takes any integer value from 0 to 5, add custom CSS for any additional values needed.

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
     &lt;div class=&quot;d-flex flex-nowrap&quot;&gt;
&lt;div class=&quot;order-3 p-2&quot;&gt;First flex item&lt;/div&gt;
&lt;div class=&quot;order-2 p-2&quot;&gt;Second flex item&lt;/div&gt;
&lt;div class=&quot;order-1 p-2&quot;&gt;Third flex item&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="d-flex flex-nowrap">
  <div class="order-3 p-2">First flex item</div>
  <div class="order-2 p-2">Second flex item</div>
  <div class="order-1 p-2">Third flex item</div>
</div>
```

Responsive variations also exist for `order`.

* `.order-0`
* `.order-1`
* `.order-2`
* `.order-3`
* `.order-4`
* `.order-5`
* `.order-sm-0`
* `.order-sm-1`
* `.order-sm-2`
* `.order-sm-3`
* `.order-sm-4`
* `.order-sm-5`
* `.order-md-0`
* `.order-md-1`
* `.order-md-2`
* `.order-md-3`
* `.order-md-4`
* `.order-md-5`
* `.order-lg-0`
* `.order-lg-1`
* `.order-lg-2`
* `.order-lg-3`
* `.order-lg-4`
* `.order-lg-5`
* `.order-xl-0`
* `.order-xl-1`
* `.order-xl-2`
* `.order-xl-3`
* `.order-xl-4`
* `.order-xl-5`
* `.order-xxl-0`
* `.order-xxl-1`
* `.order-xxl-2`
* `.order-xxl-3`
* `.order-xxl-4`
* `.order-xxl-5`

Additionally there are also responsive `.order-first` and `.order-last` classes that change the `order` of an element by applying `order: -1` and `order: 6`, respectively.

* `.order-first`
* `.order-last`
* `.order-sm-first`
* `.order-sm-last`
* `.order-md-first`
* `.order-md-last`
* `.order-lg-first`
* `.order-lg-last`
* `.order-xl-first`
* `.order-xl-last`
* `.order-xxl-first`
* `.order-xxl-last`

## Align content

Use `align-content` utilities on flexbox containers to align flex items *together* on the cross axis. Choose from `start` (browser default), `end`, `center`, `between`, `around`, or `stretch`. To demonstrate these utilities, we’ve enforced `flex-wrap: wrap` and increased the number of flex items.

**Heads up!** This property has no effect on single rows of flex items.

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
    &lt;div class=&quot;d-flex align-content-start flex-wrap mb-3&quot; style=&quot;height: 200px&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="d-flex align-content-start flex-wrap">
  ...
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
    &lt;div class=&quot;d-flex align-content-end flex-wrap mb-3&quot; style=&quot;height: 200px&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="d-flex align-content-end flex-wrap">...</div>
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
    &lt;div class=&quot;d-flex align-content-center flex-wrap mb-3&quot; style=&quot;height: 200px&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="d-flex align-content-center flex-wrap">...</div>
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
    &lt;div class=&quot;d-flex align-content-between flex-wrap mb-3&quot; style=&quot;height: 200px&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="d-flex align-content-between flex-wrap">...</div>
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
    &lt;div class=&quot;d-flex align-content-around flex-wrap mb-3&quot; style=&quot;height: 200px&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="d-flex align-content-around flex-wrap">...</div>
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
    &lt;div class=&quot;d-flex align-content-stretch flex-wrap mb-3&quot; style=&quot;height: 200px&quot;&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;div class=&quot;p-2&quot;&gt;Flex item&lt;/div&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="d-flex align-content-stretch flex-wrap">...</div>
```

Responsive variations also exist for `align-content`.

* `.align-content-start`
* `.align-content-end`
* `.align-content-center`
* `.align-content-between`
* `.align-content-around`
* `.align-content-stretch`
* `.align-content-sm-start`
* `.align-content-sm-end`
* `.align-content-sm-center`
* `.align-content-sm-between`
* `.align-content-sm-around`
* `.align-content-sm-stretch`
* `.align-content-md-start`
* `.align-content-md-end`
* `.align-content-md-center`
* `.align-content-md-between`
* `.align-content-md-around`
* `.align-content-md-stretch`
* `.align-content-lg-start`
* `.align-content-lg-end`
* `.align-content-lg-center`
* `.align-content-lg-between`
* `.align-content-lg-around`
* `.align-content-lg-stretch`
* `.align-content-xl-start`
* `.align-content-xl-end`
* `.align-content-xl-center`
* `.align-content-xl-between`
* `.align-content-xl-around`
* `.align-content-xl-stretch`
* `.align-content-xxl-start`
* `.align-content-xxl-end`
* `.align-content-xxl-center`
* `.align-content-xxl-between`
* `.align-content-xxl-around`
* `.align-content-xxl-stretch`

## Media object

Looking to replicate the [media object component](https://getbootstrap.com/docs/4.6/components/media-object/) from Bootstrap 4? Recreate it in no time with a few flex utilities that allow even more flexibility and customization than before.

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
     &lt;div class=&quot;d-flex&quot;&gt;
&lt;div class=&quot;flex-shrink-0&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Image&quot; class=&quot;bd-placeholder-img&quot; height=&quot;100&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;100&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#e5e5e5&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#999&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Image&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;flex-grow-1 ms-3&quot;&gt;
    This is some content from a media component. You can replace this with any content and adjust it as needed.
  &lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="d-flex">
  <div class="flex-shrink-0">
    <img src="..." alt="...">
  </div>
  <div class="flex-grow-1 ms-3">
    This is some content from a media component. You can replace this with any content and adjust it as needed.
  </div>
</div>
```

And say you want to vertically center the content next to the image:

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
     &lt;div class=&quot;d-flex align-items-center&quot;&gt;
&lt;div class=&quot;flex-shrink-0&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Image&quot; class=&quot;bd-placeholder-img&quot; height=&quot;100&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;100&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#e5e5e5&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#999&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Image&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;flex-grow-1 ms-3&quot;&gt;
    This is some content from a media component. You can replace this with any content and adjust it as needed.
  &lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="d-flex align-items-center">
  <div class="flex-shrink-0">
    <img src="..." alt="...">
  </div>
  <div class="flex-grow-1 ms-3">
    This is some content from a media component. You can replace this with any content and adjust it as needed.
  </div>
</div>
```

## CSS

### Sass utilities API

Flexbox utilities are declared in our utilities API in `scss/_utilities.scss`. [Learn how to use the utilities API.](/docs/5.3/utilities/api#using-the-api)

[scss/\_utilities.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_utilities.scss)

```html
"flex": (
  responsive: true,
  property: flex,
  values: (fill: 1 1 auto)
),
"flex-direction": (
  responsive: true,
  property: flex-direction,
  class: flex,
  values: row column row-reverse column-reverse
),
"flex-grow": (
  responsive: true,
  property: flex-grow,
  class: flex,
  values: (
    grow-0: 0,
    grow-1: 1,
  )
),
"flex-shrink": (
  responsive: true,
  property: flex-shrink,
  class: flex,
  values: (
    shrink-0: 0,
    shrink-1: 1,
  )
),
"flex-wrap": (
  responsive: true,
  property: flex-wrap,
  class: flex,
  values: wrap nowrap wrap-reverse
),
"justify-content": (
  responsive: true,
  property: justify-content,
  values: (
    start: flex-start,
    end: flex-end,
    center: center,
    between: space-between,
    around: space-around,
    evenly: space-evenly,
  )
),
"align-items": (
  responsive: true,
  property: align-items,
  values: (
    start: flex-start,
    end: flex-end,
    center: center,
    baseline: baseline,
    stretch: stretch,
  )
),
"align-content": (
  responsive: true,
  property: align-content,
  values: (
    start: flex-start,
    end: flex-end,
    center: center,
    between: space-between,
    around: space-around,
    stretch: stretch,
  )
),
"align-self": (
  responsive: true,
  property: align-self,
  values: (
    auto: auto,
    start: flex-start,
    end: flex-end,
    center: center,
    baseline: baseline,
    stretch: stretch,
  )
),
"order": (
  responsive: true,
  property: order,
  values: (
    first: -1,
    0: 0,
    1: 1,
    2: 2,
    3: 3,
    4: 4,
    5: 5,
    last: 6,
  ),
),
```

