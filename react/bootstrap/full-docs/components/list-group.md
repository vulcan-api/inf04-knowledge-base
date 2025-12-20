> Źródło: [https://getbootstrap.com/docs/5.3/components/list-group](https://getbootstrap.com/docs/5.3/components/list-group)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/components/list-group.mdx "View and edit this file on GitHub")

# List group

List groups are a flexible and powerful component for displaying a series of content. Modify and extend them to support just about any content within.

On this page
   
**On this page**

---

* [Basic example](#basic-example)
* [Active items](#active-items)
* [Links and buttons](#links-and-buttons)
* [Flush](#flush)
* [Numbered](#numbered)
* [Horizontal](#horizontal)
* [Variants](#variants)
  + [For links and buttons](#for-links-and-buttons)
* [With badges](#with-badges)
* [Custom content](#custom-content)
* [Checkboxes and radios](#checkboxes-and-radios)
* [CSS](#css)
  + [Variables](#variables)
  + [Sass variables](#sass-variables)
  + [Sass mixins](#sass-mixins)
  + [Sass loops](#sass-loops)
* [JavaScript behavior](#javascript-behavior)
  + [Using data attributes](#using-data-attributes)
  + [Via JavaScript](#via-javascript)
  + [Fade effect](#fade-effect)
  + [Methods](#methods)
  + [Events](#events)

## Basic example

The most basic list group is an unordered list with list items and the proper classes. Build upon it with the options that follow, or with your own CSS as needed.

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
     &lt;ul class=&quot;list-group&quot;&gt;
&lt;li class=&quot;list-group-item&quot;&gt;An item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A second item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A third item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A fourth item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;And a fifth one&lt;/li&gt;
&lt;/ul&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<ul class="list-group">
  <li class="list-group-item">An item</li>
  <li class="list-group-item">A second item</li>
  <li class="list-group-item">A third item</li>
  <li class="list-group-item">A fourth item</li>
  <li class="list-group-item">And a fifth one</li>
</ul>
```

## Active items

Add `.active` to a `.list-group-item` to indicate the current active selection.

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
     &lt;ul class=&quot;list-group&quot;&gt;
&lt;li aria-current=&quot;true&quot; class=&quot;list-group-item active&quot;&gt;An active item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A second item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A third item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A fourth item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;And a fifth one&lt;/li&gt;
&lt;/ul&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<ul class="list-group">
  <li class="list-group-item active" aria-current="true">An active item</li>
  <li class="list-group-item">A second item</li>
  <li class="list-group-item">A third item</li>
  <li class="list-group-item">A fourth item</li>
  <li class="list-group-item">And a fifth one</li>
</ul>
```

## Links and buttons

Use `<a>`s or `<button>`s to create *actionable* list group items with hover, disabled, and active states by adding `.list-group-item-action`. We separate these pseudo-classes to ensure list groups made of non-interactive elements (like `<li>`s or `<div>`s) don’t provide a click or tap affordance.

Make `.list-group-item-action` instances *appear* disabled by adding `.disabled`, and `aria-disabled="true"` to inform assistive technologies that the element is disabled. You may require additional JavaScript to fully disable links and buttons.

Be sure to **not use the standard `.btn` classes here**.

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
     &lt;div class=&quot;list-group&quot;&gt;
&lt;a aria-current=&quot;true&quot; class=&quot;list-group-item list-group-item-action active&quot; href=&quot;#&quot;&gt;
    The current link item
  &lt;/a&gt;
&lt;a class=&quot;list-group-item list-group-item-action&quot; href=&quot;#&quot;&gt;A second link item&lt;/a&gt;
&lt;a class=&quot;list-group-item list-group-item-action&quot; href=&quot;#&quot;&gt;A third link item&lt;/a&gt;
&lt;a class=&quot;list-group-item list-group-item-action&quot; href=&quot;#&quot;&gt;A fourth link item&lt;/a&gt;
&lt;a aria-disabled=&quot;true&quot; class=&quot;list-group-item list-group-item-action disabled&quot; href=&quot;#&quot;&gt;A disabled link item&lt;/a&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="list-group">
  <a href="#" class="list-group-item list-group-item-action active" aria-current="true">
    The current link item
  </a>
  <a href="#" class="list-group-item list-group-item-action">A second link item</a>
  <a href="#" class="list-group-item list-group-item-action">A third link item</a>
  <a href="#" class="list-group-item list-group-item-action">A fourth link item</a>
  <a href="#" class="list-group-item list-group-item-action disabled" aria-disabled="true">A disabled link item</a>
</div>
```

With `<button>`s, you can also make use of the `disabled` attribute instead of the `.disabled` class. Sadly, `<a>`s don’t support the disabled attribute.

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
     &lt;div class=&quot;list-group&quot;&gt;
&lt;button aria-current=&quot;true&quot; class=&quot;list-group-item list-group-item-action active&quot; type=&quot;button&quot;&gt;
    The current button
  &lt;/button&gt;
&lt;button class=&quot;list-group-item list-group-item-action&quot; type=&quot;button&quot;&gt;A second button item&lt;/button&gt;
&lt;button class=&quot;list-group-item list-group-item-action&quot; type=&quot;button&quot;&gt;A third button item&lt;/button&gt;
&lt;button class=&quot;list-group-item list-group-item-action&quot; type=&quot;button&quot;&gt;A fourth button item&lt;/button&gt;
&lt;button class=&quot;list-group-item list-group-item-action&quot; disabled=&quot;&quot; type=&quot;button&quot;&gt;A disabled button item&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="list-group">
  <button type="button" class="list-group-item list-group-item-action active" aria-current="true">
    The current button
  </button>
  <button type="button" class="list-group-item list-group-item-action">A second button item</button>
  <button type="button" class="list-group-item list-group-item-action">A third button item</button>
  <button type="button" class="list-group-item list-group-item-action">A fourth button item</button>
  <button type="button" class="list-group-item list-group-item-action" disabled>A disabled button item</button>
</div>
```

## Flush

Add `.list-group-flush` to remove some borders and rounded corners to render list group items edge-to-edge in a parent container (e.g., cards).

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
     &lt;ul class=&quot;list-group list-group-flush&quot;&gt;
&lt;li class=&quot;list-group-item&quot;&gt;An item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A second item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A third item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A fourth item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;And a fifth one&lt;/li&gt;
&lt;/ul&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<ul class="list-group list-group-flush">
  <li class="list-group-item">An item</li>
  <li class="list-group-item">A second item</li>
  <li class="list-group-item">A third item</li>
  <li class="list-group-item">A fourth item</li>
  <li class="list-group-item">And a fifth one</li>
</ul>
```

## Numbered

Add the `.list-group-numbered` modifier class (and optionally use an `<ol>` element) to opt into numbered list group items. Numbers are generated via CSS (as opposed to a `<ol>`s default browser styling) for better placement inside list group items and to allow for better customization.

Numbers are generated by `counter-reset` on the `<ol>`, and then styled and placed with a `::before` pseudo-element on the `<li>` with `counter-increment` and `content`.

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
     &lt;ol class=&quot;list-group list-group-numbered&quot;&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A list item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A list item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A list item&lt;/li&gt;
&lt;/ol&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<ol class="list-group list-group-numbered">
  <li class="list-group-item">A list item</li>
  <li class="list-group-item">A list item</li>
  <li class="list-group-item">A list item</li>
</ol>
```

These work great with custom content as well.

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
     &lt;ol class=&quot;list-group list-group-numbered&quot;&gt;
&lt;li class=&quot;list-group-item d-flex justify-content-between align-items-start&quot;&gt;
&lt;div class=&quot;ms-2 me-auto&quot;&gt;
&lt;div class=&quot;fw-bold&quot;&gt;Subheading&lt;/div&gt;
      Content for list item
    &lt;/div&gt;
&lt;span class=&quot;badge text-bg-primary rounded-pill&quot;&gt;14&lt;/span&gt;
&lt;/li&gt;
&lt;li class=&quot;list-group-item d-flex justify-content-between align-items-start&quot;&gt;
&lt;div class=&quot;ms-2 me-auto&quot;&gt;
&lt;div class=&quot;fw-bold&quot;&gt;Subheading&lt;/div&gt;
      Content for list item
    &lt;/div&gt;
&lt;span class=&quot;badge text-bg-primary rounded-pill&quot;&gt;14&lt;/span&gt;
&lt;/li&gt;
&lt;li class=&quot;list-group-item d-flex justify-content-between align-items-start&quot;&gt;
&lt;div class=&quot;ms-2 me-auto&quot;&gt;
&lt;div class=&quot;fw-bold&quot;&gt;Subheading&lt;/div&gt;
      Content for list item
    &lt;/div&gt;
&lt;span class=&quot;badge text-bg-primary rounded-pill&quot;&gt;14&lt;/span&gt;
&lt;/li&gt;
&lt;/ol&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<ol class="list-group list-group-numbered">
  <li class="list-group-item d-flex justify-content-between align-items-start">
    <div class="ms-2 me-auto">
      <div class="fw-bold">Subheading</div>
      Content for list item
    </div>
    <span class="badge text-bg-primary rounded-pill">14</span>
  </li>
  <li class="list-group-item d-flex justify-content-between align-items-start">
    <div class="ms-2 me-auto">
      <div class="fw-bold">Subheading</div>
      Content for list item
    </div>
    <span class="badge text-bg-primary rounded-pill">14</span>
  </li>
  <li class="list-group-item d-flex justify-content-between align-items-start">
    <div class="ms-2 me-auto">
      <div class="fw-bold">Subheading</div>
      Content for list item
    </div>
    <span class="badge text-bg-primary rounded-pill">14</span>
  </li>
</ol>
```

## Horizontal

Add `.list-group-horizontal` to change the layout of list group items from vertical to horizontal across all breakpoints. Alternatively, choose a responsive variant `.list-group-horizontal-{sm|md|lg|xl|xxl}` to make a list group horizontal starting at that breakpoint’s `min-width`. Currently **horizontal list groups cannot be combined with flush list groups.**

**ProTip:** Want equal-width list group items when horizontal? Add `.flex-fill` to each list group item.

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
     &lt;ul class=&quot;list-group list-group-horizontal&quot;&gt;
&lt;li class=&quot;list-group-item&quot;&gt;An item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A second item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A third item&lt;/li&gt;
&lt;/ul&gt;
&lt;ul class=&quot;list-group list-group-horizontal-sm&quot;&gt;
&lt;li class=&quot;list-group-item&quot;&gt;An item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A second item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A third item&lt;/li&gt;
&lt;/ul&gt;
&lt;ul class=&quot;list-group list-group-horizontal-md&quot;&gt;
&lt;li class=&quot;list-group-item&quot;&gt;An item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A second item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A third item&lt;/li&gt;
&lt;/ul&gt;
&lt;ul class=&quot;list-group list-group-horizontal-lg&quot;&gt;
&lt;li class=&quot;list-group-item&quot;&gt;An item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A second item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A third item&lt;/li&gt;
&lt;/ul&gt;
&lt;ul class=&quot;list-group list-group-horizontal-xl&quot;&gt;
&lt;li class=&quot;list-group-item&quot;&gt;An item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A second item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A third item&lt;/li&gt;
&lt;/ul&gt;
&lt;ul class=&quot;list-group list-group-horizontal-xxl&quot;&gt;
&lt;li class=&quot;list-group-item&quot;&gt;An item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A second item&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A third item&lt;/li&gt;
&lt;/ul&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<ul class="list-group list-group-horizontal">
  <li class="list-group-item">An item</li>
  <li class="list-group-item">A second item</li>
  <li class="list-group-item">A third item</li>
</ul>
<ul class="list-group list-group-horizontal-sm">
  <li class="list-group-item">An item</li>
  <li class="list-group-item">A second item</li>
  <li class="list-group-item">A third item</li>
</ul>
<ul class="list-group list-group-horizontal-md">
  <li class="list-group-item">An item</li>
  <li class="list-group-item">A second item</li>
  <li class="list-group-item">A third item</li>
</ul>
<ul class="list-group list-group-horizontal-lg">
  <li class="list-group-item">An item</li>
  <li class="list-group-item">A second item</li>
  <li class="list-group-item">A third item</li>
</ul>
<ul class="list-group list-group-horizontal-xl">
  <li class="list-group-item">An item</li>
  <li class="list-group-item">A second item</li>
  <li class="list-group-item">A third item</li>
</ul>
<ul class="list-group list-group-horizontal-xxl">
  <li class="list-group-item">An item</li>
  <li class="list-group-item">A second item</li>
  <li class="list-group-item">A third item</li>
</ul>
```

## Variants

**Heads up!** As of v5.3.0, the `list-group-item-variant()` Sass mixin is deprecated. List group item variants now have their CSS variables overridden in [a Sass loop](#sass-loops).

Use contextual classes to style list items with a stateful background and color.

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
     &lt;ul class=&quot;list-group&quot;&gt;
&lt;li class=&quot;list-group-item&quot;&gt;A simple default list group item&lt;/li&gt;
&lt;li class=&quot;list-group-item list-group-item-primary&quot;&gt;A simple primary list group item&lt;/li&gt;
&lt;li class=&quot;list-group-item list-group-item-secondary&quot;&gt;A simple secondary list group item&lt;/li&gt;
&lt;li class=&quot;list-group-item list-group-item-success&quot;&gt;A simple success list group item&lt;/li&gt;
&lt;li class=&quot;list-group-item list-group-item-danger&quot;&gt;A simple danger list group item&lt;/li&gt;
&lt;li class=&quot;list-group-item list-group-item-warning&quot;&gt;A simple warning list group item&lt;/li&gt;
&lt;li class=&quot;list-group-item list-group-item-info&quot;&gt;A simple info list group item&lt;/li&gt;
&lt;li class=&quot;list-group-item list-group-item-light&quot;&gt;A simple light list group item&lt;/li&gt;
&lt;li class=&quot;list-group-item list-group-item-dark&quot;&gt;A simple dark list group item&lt;/li&gt;
&lt;/ul&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<ul class="list-group">
  <li class="list-group-item">A simple default list group item</li>
  
  <li class="list-group-item list-group-item-primary">A simple primary list group item</li>
  <li class="list-group-item list-group-item-secondary">A simple secondary list group item</li>
  <li class="list-group-item list-group-item-success">A simple success list group item</li>
  <li class="list-group-item list-group-item-danger">A simple danger list group item</li>
  <li class="list-group-item list-group-item-warning">A simple warning list group item</li>
  <li class="list-group-item list-group-item-info">A simple info list group item</li>
  <li class="list-group-item list-group-item-light">A simple light list group item</li>
  <li class="list-group-item list-group-item-dark">A simple dark list group item</li>
</ul>
```

### For links and buttons

Contextual classes also work with `.list-group-item-action` for `<a>` and `<button>` elements. Note the addition of the hover styles here not present in the previous example. Also supported is the `.active` state; apply it to indicate an active selection on a contextual list group item.

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
     &lt;div class=&quot;list-group&quot;&gt;
&lt;a class=&quot;list-group-item list-group-item-action&quot; href=&quot;#&quot;&gt;A simple default list group item&lt;/a&gt;
&lt;a class=&quot;list-group-item list-group-item-action list-group-item-primary&quot; href=&quot;#&quot;&gt;A simple primary list group item&lt;/a&gt;
&lt;a class=&quot;list-group-item list-group-item-action list-group-item-secondary&quot; href=&quot;#&quot;&gt;A simple secondary list group item&lt;/a&gt;
&lt;a class=&quot;list-group-item list-group-item-action list-group-item-success&quot; href=&quot;#&quot;&gt;A simple success list group item&lt;/a&gt;
&lt;a class=&quot;list-group-item list-group-item-action list-group-item-danger&quot; href=&quot;#&quot;&gt;A simple danger list group item&lt;/a&gt;
&lt;a class=&quot;list-group-item list-group-item-action list-group-item-warning&quot; href=&quot;#&quot;&gt;A simple warning list group item&lt;/a&gt;
&lt;a class=&quot;list-group-item list-group-item-action list-group-item-info&quot; href=&quot;#&quot;&gt;A simple info list group item&lt;/a&gt;
&lt;a class=&quot;list-group-item list-group-item-action list-group-item-light&quot; href=&quot;#&quot;&gt;A simple light list group item&lt;/a&gt;
&lt;a class=&quot;list-group-item list-group-item-action list-group-item-dark&quot; href=&quot;#&quot;&gt;A simple dark list group item&lt;/a&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="list-group">
  <a href="#" class="list-group-item list-group-item-action">A simple default list group item</a>
  
  <a href="#" class="list-group-item list-group-item-action list-group-item-primary">A simple primary list group item</a>
  <a href="#" class="list-group-item list-group-item-action list-group-item-secondary">A simple secondary list group item</a>
  <a href="#" class="list-group-item list-group-item-action list-group-item-success">A simple success list group item</a>
  <a href="#" class="list-group-item list-group-item-action list-group-item-danger">A simple danger list group item</a>
  <a href="#" class="list-group-item list-group-item-action list-group-item-warning">A simple warning list group item</a>
  <a href="#" class="list-group-item list-group-item-action list-group-item-info">A simple info list group item</a>
  <a href="#" class="list-group-item list-group-item-action list-group-item-light">A simple light list group item</a>
  <a href="#" class="list-group-item list-group-item-action list-group-item-dark">A simple dark list group item</a>
</div>
```

**Accessibility tip:** Using color to add meaning only provides a visual indication, which will not be conveyed to users of assistive technologies like screen readers. Please ensure the meaning is obvious from the content itself (e.g., the visible text with a [*sufficient* color contrast](/docs/5.3/getting-started/accessibility/#color-contrast)) or is included through alternative means, such as additional text hidden with the `.visually-hidden` class.

## With badges

Add badges to any list group item to show unread counts, activity, and more with the help of some [utilities](/docs/5.3/utilities/flex).

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
     &lt;ul class=&quot;list-group&quot;&gt;
&lt;li class=&quot;list-group-item d-flex justify-content-between align-items-center&quot;&gt;
    A list item
    &lt;span class=&quot;badge text-bg-primary rounded-pill&quot;&gt;14&lt;/span&gt;
&lt;/li&gt;
&lt;li class=&quot;list-group-item d-flex justify-content-between align-items-center&quot;&gt;
    A second list item
    &lt;span class=&quot;badge text-bg-primary rounded-pill&quot;&gt;2&lt;/span&gt;
&lt;/li&gt;
&lt;li class=&quot;list-group-item d-flex justify-content-between align-items-center&quot;&gt;
    A third list item
    &lt;span class=&quot;badge text-bg-primary rounded-pill&quot;&gt;1&lt;/span&gt;
&lt;/li&gt;
&lt;/ul&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<ul class="list-group">
  <li class="list-group-item d-flex justify-content-between align-items-center">
    A list item
    <span class="badge text-bg-primary rounded-pill">14</span>
  </li>
  <li class="list-group-item d-flex justify-content-between align-items-center">
    A second list item
    <span class="badge text-bg-primary rounded-pill">2</span>
  </li>
  <li class="list-group-item d-flex justify-content-between align-items-center">
    A third list item
    <span class="badge text-bg-primary rounded-pill">1</span>
  </li>
</ul>
```

## Custom content

Add nearly any HTML within, even for linked list groups like the one below, with the help of [flexbox utilities](/docs/5.3/utilities/flex).

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
     &lt;div class=&quot;list-group&quot;&gt;
&lt;a aria-current=&quot;true&quot; class=&quot;list-group-item list-group-item-action active&quot; href=&quot;#&quot;&gt;
&lt;div class=&quot;d-flex w-100 justify-content-between&quot;&gt;
&lt;h5 class=&quot;mb-1&quot;&gt;List group item heading&lt;/h5&gt;
&lt;small&gt;3 days ago&lt;/small&gt;
&lt;/div&gt;
&lt;p class=&quot;mb-1&quot;&gt;Some placeholder content in a paragraph.&lt;/p&gt;
&lt;small&gt;And some small print.&lt;/small&gt;
&lt;/a&gt;
&lt;a class=&quot;list-group-item list-group-item-action&quot; href=&quot;#&quot;&gt;
&lt;div class=&quot;d-flex w-100 justify-content-between&quot;&gt;
&lt;h5 class=&quot;mb-1&quot;&gt;List group item heading&lt;/h5&gt;
&lt;small class=&quot;text-body-secondary&quot;&gt;3 days ago&lt;/small&gt;
&lt;/div&gt;
&lt;p class=&quot;mb-1&quot;&gt;Some placeholder content in a paragraph.&lt;/p&gt;
&lt;small class=&quot;text-body-secondary&quot;&gt;And some muted small print.&lt;/small&gt;
&lt;/a&gt;
&lt;a class=&quot;list-group-item list-group-item-action&quot; href=&quot;#&quot;&gt;
&lt;div class=&quot;d-flex w-100 justify-content-between&quot;&gt;
&lt;h5 class=&quot;mb-1&quot;&gt;List group item heading&lt;/h5&gt;
&lt;small class=&quot;text-body-secondary&quot;&gt;3 days ago&lt;/small&gt;
&lt;/div&gt;
&lt;p class=&quot;mb-1&quot;&gt;Some placeholder content in a paragraph.&lt;/p&gt;
&lt;small class=&quot;text-body-secondary&quot;&gt;And some muted small print.&lt;/small&gt;
&lt;/a&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="list-group">
  <a href="#" class="list-group-item list-group-item-action active" aria-current="true">
    <div class="d-flex w-100 justify-content-between">
      <h5 class="mb-1">List group item heading</h5>
      <small>3 days ago</small>
    </div>
    <p class="mb-1">Some placeholder content in a paragraph.</p>
    <small>And some small print.</small>
  </a>
  <a href="#" class="list-group-item list-group-item-action">
    <div class="d-flex w-100 justify-content-between">
      <h5 class="mb-1">List group item heading</h5>
      <small class="text-body-secondary">3 days ago</small>
    </div>
    <p class="mb-1">Some placeholder content in a paragraph.</p>
    <small class="text-body-secondary">And some muted small print.</small>
  </a>
  <a href="#" class="list-group-item list-group-item-action">
    <div class="d-flex w-100 justify-content-between">
      <h5 class="mb-1">List group item heading</h5>
      <small class="text-body-secondary">3 days ago</small>
    </div>
    <p class="mb-1">Some placeholder content in a paragraph.</p>
    <small class="text-body-secondary">And some muted small print.</small>
  </a>
</div>
```

## Checkboxes and radios

Place Bootstrap’s checkboxes and radios within list group items and customize as needed. You can use them without `<label>`s, but please remember to include an `aria-label` attribute and value for accessibility.

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
     &lt;ul class=&quot;list-group&quot;&gt;
&lt;li class=&quot;list-group-item&quot;&gt;
&lt;input class=&quot;form-check-input me-1&quot; id=&quot;firstCheckbox&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;firstCheckbox&quot;&gt;First checkbox&lt;/label&gt;
&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;
&lt;input class=&quot;form-check-input me-1&quot; id=&quot;secondCheckbox&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;secondCheckbox&quot;&gt;Second checkbox&lt;/label&gt;
&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;
&lt;input class=&quot;form-check-input me-1&quot; id=&quot;thirdCheckbox&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;thirdCheckbox&quot;&gt;Third checkbox&lt;/label&gt;
&lt;/li&gt;
&lt;/ul&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<ul class="list-group">
  <li class="list-group-item">
    <input class="form-check-input me-1" type="checkbox" value="" id="firstCheckbox">
    <label class="form-check-label" for="firstCheckbox">First checkbox</label>
  </li>
  <li class="list-group-item">
    <input class="form-check-input me-1" type="checkbox" value="" id="secondCheckbox">
    <label class="form-check-label" for="secondCheckbox">Second checkbox</label>
  </li>
  <li class="list-group-item">
    <input class="form-check-input me-1" type="checkbox" value="" id="thirdCheckbox">
    <label class="form-check-label" for="thirdCheckbox">Third checkbox</label>
  </li>
</ul>
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
     &lt;ul class=&quot;list-group&quot;&gt;
&lt;li class=&quot;list-group-item&quot;&gt;
&lt;input checked=&quot;&quot; class=&quot;form-check-input me-1&quot; id=&quot;firstRadio&quot; name=&quot;listGroupRadio&quot; type=&quot;radio&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;firstRadio&quot;&gt;First radio&lt;/label&gt;
&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;
&lt;input class=&quot;form-check-input me-1&quot; id=&quot;secondRadio&quot; name=&quot;listGroupRadio&quot; type=&quot;radio&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;secondRadio&quot;&gt;Second radio&lt;/label&gt;
&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;
&lt;input class=&quot;form-check-input me-1&quot; id=&quot;thirdRadio&quot; name=&quot;listGroupRadio&quot; type=&quot;radio&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;thirdRadio&quot;&gt;Third radio&lt;/label&gt;
&lt;/li&gt;
&lt;/ul&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<ul class="list-group">
  <li class="list-group-item">
    <input class="form-check-input me-1" type="radio" name="listGroupRadio" value="" id="firstRadio" checked>
    <label class="form-check-label" for="firstRadio">First radio</label>
  </li>
  <li class="list-group-item">
    <input class="form-check-input me-1" type="radio" name="listGroupRadio" value="" id="secondRadio">
    <label class="form-check-label" for="secondRadio">Second radio</label>
  </li>
  <li class="list-group-item">
    <input class="form-check-input me-1" type="radio" name="listGroupRadio" value="" id="thirdRadio">
    <label class="form-check-label" for="thirdRadio">Third radio</label>
  </li>
</ul>
```

You can use `.stretched-link` on `<label>`s to make the whole list group item clickable.

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
     &lt;ul class=&quot;list-group&quot;&gt;
&lt;li class=&quot;list-group-item&quot;&gt;
&lt;input class=&quot;form-check-input me-1&quot; id=&quot;firstCheckboxStretched&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label stretched-link&quot; for=&quot;firstCheckboxStretched&quot;&gt;First checkbox&lt;/label&gt;
&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;
&lt;input class=&quot;form-check-input me-1&quot; id=&quot;secondCheckboxStretched&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label stretched-link&quot; for=&quot;secondCheckboxStretched&quot;&gt;Second checkbox&lt;/label&gt;
&lt;/li&gt;
&lt;li class=&quot;list-group-item&quot;&gt;
&lt;input class=&quot;form-check-input me-1&quot; id=&quot;thirdCheckboxStretched&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label stretched-link&quot; for=&quot;thirdCheckboxStretched&quot;&gt;Third checkbox&lt;/label&gt;
&lt;/li&gt;
&lt;/ul&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<ul class="list-group">
  <li class="list-group-item">
    <input class="form-check-input me-1" type="checkbox" value="" id="firstCheckboxStretched">
    <label class="form-check-label stretched-link" for="firstCheckboxStretched">First checkbox</label>
  </li>
  <li class="list-group-item">
    <input class="form-check-input me-1" type="checkbox" value="" id="secondCheckboxStretched">
    <label class="form-check-label stretched-link" for="secondCheckboxStretched">Second checkbox</label>
  </li>
  <li class="list-group-item">
    <input class="form-check-input me-1" type="checkbox" value="" id="thirdCheckboxStretched">
    <label class="form-check-label stretched-link" for="thirdCheckboxStretched">Third checkbox</label>
  </li>
</ul>
```

## CSS

### Variables

Added in v5.2.0

As part of Bootstrap’s evolving CSS variables approach, list groups now use local CSS variables on `.list-group` for enhanced real-time customization. Values for the CSS variables are set via Sass, so Sass customization is still supported, too.

[scss/\_list-group.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_list-group.scss)

```html
--#{$prefix}list-group-color: #{$list-group-color};
--#{$prefix}list-group-bg: #{$list-group-bg};
--#{$prefix}list-group-border-color: #{$list-group-border-color};
--#{$prefix}list-group-border-width: #{$list-group-border-width};
--#{$prefix}list-group-border-radius: #{$list-group-border-radius};
--#{$prefix}list-group-item-padding-x: #{$list-group-item-padding-x};
--#{$prefix}list-group-item-padding-y: #{$list-group-item-padding-y};
--#{$prefix}list-group-action-color: #{$list-group-action-color};
--#{$prefix}list-group-action-hover-color: #{$list-group-action-hover-color};
--#{$prefix}list-group-action-hover-bg: #{$list-group-hover-bg};
--#{$prefix}list-group-action-active-color: #{$list-group-action-active-color};
--#{$prefix}list-group-action-active-bg: #{$list-group-action-active-bg};
--#{$prefix}list-group-disabled-color: #{$list-group-disabled-color};
--#{$prefix}list-group-disabled-bg: #{$list-group-disabled-bg};
--#{$prefix}list-group-active-color: #{$list-group-active-color};
--#{$prefix}list-group-active-bg: #{$list-group-active-bg};
--#{$prefix}list-group-active-border-color: #{$list-group-active-border-color};
```

### Sass variables

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$list-group-color:                  var(--#{$prefix}body-color);
$list-group-bg:                     var(--#{$prefix}body-bg);
$list-group-border-color:           var(--#{$prefix}border-color);
$list-group-border-width:           var(--#{$prefix}border-width);
$list-group-border-radius:          var(--#{$prefix}border-radius);

$list-group-item-padding-y:         $spacer * .5;
$list-group-item-padding-x:         $spacer;
// fusv-disable
$list-group-item-bg-scale:          -80%; // Deprecated in v5.3.0
$list-group-item-color-scale:       40%; // Deprecated in v5.3.0
// fusv-enable

$list-group-hover-bg:               var(--#{$prefix}tertiary-bg);
$list-group-active-color:           $component-active-color;
$list-group-active-bg:              $component-active-bg;
$list-group-active-border-color:    $list-group-active-bg;

$list-group-disabled-color:         var(--#{$prefix}secondary-color);
$list-group-disabled-bg:            $list-group-bg;

$list-group-action-color:           var(--#{$prefix}secondary-color);
$list-group-action-hover-color:     var(--#{$prefix}emphasis-color);

$list-group-action-active-color:    var(--#{$prefix}body-color);
$list-group-action-active-bg:       var(--#{$prefix}secondary-bg);
```

### Sass mixins

Deprecated in v5.3.0 

[scss/mixins/\_list-group.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/mixins/_list-group.scss)

```html
@mixin list-group-item-variant($state, $background, $color) {
  .list-group-item-#{$state} {
    color: $color;
    background-color: $background;

    &.list-group-item-action {
      &:hover,
      &:focus {
        color: $color;
        background-color: shade-color($background, 10%);
      }

      &.active {
        color: $white;
        background-color: $color;
        border-color: $color;
      }
    }
  }
}
```

### Sass loops

Loop that generates the modifier classes with an overriding of CSS variables.

[scss/\_list-group.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_list-group.scss)

```html
// List group contextual variants
//
// Add modifier classes to change text and background color on individual items.
// Organizationally, this must come after the `:hover` states.

@each $state in map-keys($theme-colors) {
  .list-group-item-#{$state} {
    --#{$prefix}list-group-color: var(--#{$prefix}#{$state}-text-emphasis);
    --#{$prefix}list-group-bg: var(--#{$prefix}#{$state}-bg-subtle);
    --#{$prefix}list-group-border-color: var(--#{$prefix}#{$state}-border-subtle);
    --#{$prefix}list-group-action-hover-color: var(--#{$prefix}emphasis-color);
    --#{$prefix}list-group-action-hover-bg: var(--#{$prefix}#{$state}-border-subtle);
    --#{$prefix}list-group-action-active-color: var(--#{$prefix}emphasis-color);
    --#{$prefix}list-group-action-active-bg: var(--#{$prefix}#{$state}-border-subtle);
    --#{$prefix}list-group-active-color: var(--#{$prefix}#{$state}-bg-subtle);
    --#{$prefix}list-group-active-bg: var(--#{$prefix}#{$state}-text-emphasis);
    --#{$prefix}list-group-active-border-color: var(--#{$prefix}#{$state}-text-emphasis);
  }
}
```

## JavaScript behavior

Use the tab JavaScript plugin—include it individually or through the compiled `bootstrap.js` file—to extend our list group to create tabbable panes of local content.

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
    &lt;div class=&quot;row&quot;&gt;&lt;div class=&quot;col-4&quot;&gt;&lt;div class=&quot;list-group&quot; id=&quot;list-tab&quot; role=&quot;tablist&quot;&gt;&lt;a aria-controls=&quot;list-home&quot; class=&quot;list-group-item list-group-item-action active&quot; data-bs-toggle=&quot;tab&quot; href=&quot;#list-home&quot; id=&quot;list-home-list&quot; role=&quot;tab&quot;&gt;Home&lt;/a&gt;&lt;a aria-controls=&quot;list-profile&quot; class=&quot;list-group-item list-group-item-action&quot; data-bs-toggle=&quot;tab&quot; href=&quot;#list-profile&quot; id=&quot;list-profile-list&quot; role=&quot;tab&quot;&gt;Profile&lt;/a&gt;&lt;a aria-controls=&quot;list-messages&quot; class=&quot;list-group-item list-group-item-action&quot; data-bs-toggle=&quot;tab&quot; href=&quot;#list-messages&quot; id=&quot;list-messages-list&quot; role=&quot;tab&quot;&gt;Messages&lt;/a&gt;&lt;a aria-controls=&quot;list-settings&quot; class=&quot;list-group-item list-group-item-action&quot; data-bs-toggle=&quot;tab&quot; href=&quot;#list-settings&quot; id=&quot;list-settings-list&quot; role=&quot;tab&quot;&gt;Settings&lt;/a&gt;&lt;/div&gt;&lt;/div&gt;&lt;div class=&quot;col-8&quot;&gt;&lt;div class=&quot;tab-content&quot; id=&quot;nav-tabContent&quot;&gt;&lt;div aria-labelledby=&quot;list-home-list&quot; class=&quot;tab-pane fade show active&quot; id=&quot;list-home&quot; role=&quot;tabpanel&quot;&gt;&lt;p&gt;Some placeholder content in a paragraph relating to &quot;Home&quot;. And some more content, used here just to pad out and fill this tab panel. In production, you would obviously have more real content here. And not just text. It could be anything, really. Text, images, forms.&lt;/p&gt;&lt;/div&gt;&lt;div aria-labelledby=&quot;list-profile-list&quot; class=&quot;tab-pane fade&quot; id=&quot;list-profile&quot; role=&quot;tabpanel&quot;&gt;&lt;p&gt;Some placeholder content in a paragraph relating to &quot;Profile&quot;. And some more content, used here just to pad out and fill this tab panel. In production, you would obviously have more real content here. And not just text. It could be anything, really. Text, images, forms.&lt;/p&gt;&lt;/div&gt;&lt;div aria-labelledby=&quot;list-messages-list&quot; class=&quot;tab-pane fade&quot; id=&quot;list-messages&quot; role=&quot;tabpanel&quot;&gt;&lt;p&gt;Some placeholder content in a paragraph relating to &quot;Messages&quot;. And some more content, used here just to pad out and fill this tab panel. In production, you would obviously have more real content here. And not just text. It could be anything, really. Text, images, forms.&lt;/p&gt;&lt;/div&gt;&lt;div aria-labelledby=&quot;list-settings-list&quot; class=&quot;tab-pane fade&quot; id=&quot;list-settings&quot; role=&quot;tabpanel&quot;&gt;&lt;p&gt;Some placeholder content in a paragraph relating to &quot;Settings&quot;. And some more content, used here just to pad out and fill this tab panel. In production, you would obviously have more real content here. And not just text. It could be anything, really. Text, images, forms.&lt;/p&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="row">
  <div class="col-4">
    <div class="list-group" id="list-tab" role="tablist">
      <a class="list-group-item list-group-item-action active" id="list-home-list" data-bs-toggle="list" href="#list-home" role="tab" aria-controls="list-home">Home</a>
      <a class="list-group-item list-group-item-action" id="list-profile-list" data-bs-toggle="list" href="#list-profile" role="tab" aria-controls="list-profile">Profile</a>
      <a class="list-group-item list-group-item-action" id="list-messages-list" data-bs-toggle="list" href="#list-messages" role="tab" aria-controls="list-messages">Messages</a>
      <a class="list-group-item list-group-item-action" id="list-settings-list" data-bs-toggle="list" href="#list-settings" role="tab" aria-controls="list-settings">Settings</a>
    </div>
  </div>
  <div class="col-8">
    <div class="tab-content" id="nav-tabContent">
      <div class="tab-pane fade show active" id="list-home" role="tabpanel" aria-labelledby="list-home-list">...</div>
      <div class="tab-pane fade" id="list-profile" role="tabpanel" aria-labelledby="list-profile-list">...</div>
      <div class="tab-pane fade" id="list-messages" role="tabpanel" aria-labelledby="list-messages-list">...</div>
      <div class="tab-pane fade" id="list-settings" role="tabpanel" aria-labelledby="list-settings-list">...</div>
    </div>
  </div>
</div>
```

### Using data attributes

You can activate a list group navigation without writing any JavaScript by simply specifying `data-bs-toggle="list"` or on an element. Use these data attributes on `.list-group-item`.

```html
<div role="tabpanel">
  <!-- List group -->
  <div class="list-group" id="myList" role="tablist">
    <a class="list-group-item list-group-item-action active" data-bs-toggle="list" href="#home" role="tab">Home</a>
    <a class="list-group-item list-group-item-action" data-bs-toggle="list" href="#profile" role="tab">Profile</a>
    <a class="list-group-item list-group-item-action" data-bs-toggle="list" href="#messages" role="tab">Messages</a>
    <a class="list-group-item list-group-item-action" data-bs-toggle="list" href="#settings" role="tab">Settings</a>
  </div>

  <!-- Tab panes -->
  <div class="tab-content">
    <div class="tab-pane active" id="home" role="tabpanel">...</div>
    <div class="tab-pane" id="profile" role="tabpanel">...</div>
    <div class="tab-pane" id="messages" role="tabpanel">...</div>
    <div class="tab-pane" id="settings" role="tabpanel">...</div>
  </div>
</div>
```

### Via JavaScript

Enable tabbable list item via JavaScript (each list item needs to be activated individually):

```html
const triggerTabList = document.querySelectorAll('#myTab a')
triggerTabList.forEach(triggerEl => {
  const tabTrigger = new bootstrap.Tab(triggerEl)

  triggerEl.addEventListener('click', event => {
    event.preventDefault()
    tabTrigger.show()
  })
})
```

You can activate individual list item in several ways:

```html
const triggerEl = document.querySelector('#myTab a[href="#profile"]')
bootstrap.Tab.getInstance(triggerEl).show() // Select tab by name

const triggerFirstTabEl = document.querySelector('#myTab li:first-child a')
bootstrap.Tab.getInstance(triggerFirstTabEl).show() // Select first tab
```

### Fade effect

To make tabs panel fade in, add `.fade` to each `.tab-pane`. The first tab pane must also have `.show` to make the initial content visible.

```html
<div class="tab-content">
  <div class="tab-pane fade show active" id="home" role="tabpanel">...</div>
  <div class="tab-pane fade" id="profile" role="tabpanel">...</div>
  <div class="tab-pane fade" id="messages" role="tabpanel">...</div>
  <div class="tab-pane fade" id="settings" role="tabpanel">...</div>
</div>
```

### Methods

**All API methods are asynchronous and start a transition.** They return to the caller as soon as the transition is started, but before it ends. In addition, a method call on a transitioning component will be ignored. [Learn more in our JavaScript docs.](/docs/5.3/getting-started/javascript/#asynchronous-functions-and-transitions)

Activates your content as a tab element.

You can create a tab instance with the constructor, for example:

```html
const bsTab = new bootstrap.Tab('#myTab')
```

| Method | Description |
| --- | --- |
| `dispose` | Destroys an element’s tab. |
| `getInstance` | Static method which allows you to get the tab instance associated with a DOM element, you can use it like this: `bootstrap.Tab.getInstance(element)`. |
| `getOrCreateInstance` | Static method which returns a tab instance associated to a DOM element or create a new one in case it wasn’t initialized. You can use it like this: `bootstrap.Tab.getOrCreateInstance(element)`. |
| `show` | Selects the given tab and shows its associated pane. Any other tab that was previously selected becomes unselected and its associated pane is hidden. **Returns to the caller before the tab pane has actually been shown** (i.e. before the `shown.bs.tab` event occurs). |

### Events

When showing a new tab, the events fire in the following order:

1. `hide.bs.tab` (on the current active tab)
2. `show.bs.tab` (on the to-be-shown tab)
3. `hidden.bs.tab` (on the previous active tab, the same one as for the `hide.bs.tab` event)
4. `shown.bs.tab` (on the newly-active just-shown tab, the same one as for the `show.bs.tab` event)

If no tab was already active, then the `hide.bs.tab` and `hidden.bs.tab` events will not be fired.

| Event type | Description |
| --- | --- |
| `hide.bs.tab` | This event fires when a new tab is to be shown (and thus the previous active tab is to be hidden). Use `event.target` and `event.relatedTarget` to target the current active tab and the new soon-to-be-active tab, respectively. |
| `hidden.bs.tab` | This event fires after a new tab is shown (and thus the previous active tab is hidden). Use `event.target` and `event.relatedTarget` to target the previous active tab and the new active tab, respectively. |
| `show.bs.tab` | This event fires on tab show, but before the new tab has been shown. Use `event.target` and `event.relatedTarget` to target the active tab and the previous active tab (if available) respectively. |
| `shown.bs.tab` | This event fires on tab show after a tab has been shown. Use `event.target` and `event.relatedTarget` to target the active tab and the previous active tab (if available) respectively. |

```html
const tabElms = document.querySelectorAll('a[data-bs-toggle="list"]')
tabElms.forEach(tabElm => {
  tabElm.addEventListener('shown.bs.tab', event => {
    event.target // newly activated tab
    event.relatedTarget // previous active tab
  })
})
```

