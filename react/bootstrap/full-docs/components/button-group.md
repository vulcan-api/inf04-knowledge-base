> Źródło: [https://getbootstrap.com/docs/5.3/components/button-group](https://getbootstrap.com/docs/5.3/components/button-group)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/components/button-group.mdx "View and edit this file on GitHub")

# Button group

Group a series of buttons together on a single line or stack them in a vertical column.

On this page
   
**On this page**

---

* [Basic example](#basic-example)
* [Mixed styles](#mixed-styles)
* [Outlined styles](#outlined-styles)
* [Checkbox and radio button groups](#checkbox-and-radio-button-groups)
* [Button toolbar](#button-toolbar)
* [Sizing](#sizing)
* [Nesting](#nesting)
* [Vertical variation](#vertical-variation)

## Basic example

Wrap a series of buttons with `.btn` in `.btn-group`.

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
     &lt;div aria-label=&quot;Basic example&quot; class=&quot;btn-group&quot; role=&quot;group&quot;&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;Left&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;Middle&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;Right&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="btn-group" role="group" aria-label="Basic example">
  <button type="button" class="btn btn-primary">Left</button>
  <button type="button" class="btn btn-primary">Middle</button>
  <button type="button" class="btn btn-primary">Right</button>
</div>
```

Button groups require an appropriate `role` attribute and explicit label to ensure assistive technologies like screen readers identify buttons as grouped and announce them. Use `role="group"` for button groups or `role="toolbar"` for button toolbars. Then use `aria-label` or `aria-labelledby` to label them.

These classes can also be added to groups of links, as an alternative to the [`.nav` navigation components](/docs/5.3/components/navs-tabs).

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
     &lt;div class=&quot;btn-group&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;btn btn-primary active&quot; href=&quot;#&quot;&gt;Active link&lt;/a&gt;
&lt;a class=&quot;btn btn-primary&quot; href=&quot;#&quot;&gt;Link&lt;/a&gt;
&lt;a class=&quot;btn btn-primary&quot; href=&quot;#&quot;&gt;Link&lt;/a&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="btn-group">
  <a href="#" class="btn btn-primary active" aria-current="page">Active link</a>
  <a href="#" class="btn btn-primary">Link</a>
  <a href="#" class="btn btn-primary">Link</a>
</div>
```

## Mixed styles

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
     &lt;div aria-label=&quot;Basic mixed styles example&quot; class=&quot;btn-group&quot; role=&quot;group&quot;&gt;
&lt;button class=&quot;btn btn-danger&quot; type=&quot;button&quot;&gt;Left&lt;/button&gt;
&lt;button class=&quot;btn btn-warning&quot; type=&quot;button&quot;&gt;Middle&lt;/button&gt;
&lt;button class=&quot;btn btn-success&quot; type=&quot;button&quot;&gt;Right&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="btn-group" role="group" aria-label="Basic mixed styles example">
  <button type="button" class="btn btn-danger">Left</button>
  <button type="button" class="btn btn-warning">Middle</button>
  <button type="button" class="btn btn-success">Right</button>
</div>
```

## Outlined styles

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
     &lt;div aria-label=&quot;Basic outlined example&quot; class=&quot;btn-group&quot; role=&quot;group&quot;&gt;
&lt;button class=&quot;btn btn-outline-primary&quot; type=&quot;button&quot;&gt;Left&lt;/button&gt;
&lt;button class=&quot;btn btn-outline-primary&quot; type=&quot;button&quot;&gt;Middle&lt;/button&gt;
&lt;button class=&quot;btn btn-outline-primary&quot; type=&quot;button&quot;&gt;Right&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="btn-group" role="group" aria-label="Basic outlined example">
  <button type="button" class="btn btn-outline-primary">Left</button>
  <button type="button" class="btn btn-outline-primary">Middle</button>
  <button type="button" class="btn btn-outline-primary">Right</button>
</div>
```

## Checkbox and radio button groups

Combine button-like checkbox and radio [toggle buttons](/docs/5.3/forms/checks-radios) into a seamless looking button group.

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
     &lt;div aria-label=&quot;Basic checkbox toggle button group&quot; class=&quot;btn-group&quot; role=&quot;group&quot;&gt;
&lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; id=&quot;btncheck1&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;btn btn-outline-primary&quot; for=&quot;btncheck1&quot;&gt;Checkbox 1&lt;/label&gt;
&lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; id=&quot;btncheck2&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;btn btn-outline-primary&quot; for=&quot;btncheck2&quot;&gt;Checkbox 2&lt;/label&gt;
&lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; id=&quot;btncheck3&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;btn btn-outline-primary&quot; for=&quot;btncheck3&quot;&gt;Checkbox 3&lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="btn-group" role="group" aria-label="Basic checkbox toggle button group">
  <input type="checkbox" class="btn-check" id="btncheck1" autocomplete="off">
  <label class="btn btn-outline-primary" for="btncheck1">Checkbox 1</label>

  <input type="checkbox" class="btn-check" id="btncheck2" autocomplete="off">
  <label class="btn btn-outline-primary" for="btncheck2">Checkbox 2</label>

  <input type="checkbox" class="btn-check" id="btncheck3" autocomplete="off">
  <label class="btn btn-outline-primary" for="btncheck3">Checkbox 3</label>
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
     &lt;div aria-label=&quot;Basic radio toggle button group&quot; class=&quot;btn-group&quot; role=&quot;group&quot;&gt;
&lt;input autocomplete=&quot;off&quot; checked=&quot;&quot; class=&quot;btn-check&quot; id=&quot;btnradio1&quot; name=&quot;btnradio&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;btn btn-outline-primary&quot; for=&quot;btnradio1&quot;&gt;Radio 1&lt;/label&gt;
&lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; id=&quot;btnradio2&quot; name=&quot;btnradio&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;btn btn-outline-primary&quot; for=&quot;btnradio2&quot;&gt;Radio 2&lt;/label&gt;
&lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; id=&quot;btnradio3&quot; name=&quot;btnradio&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;btn btn-outline-primary&quot; for=&quot;btnradio3&quot;&gt;Radio 3&lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="btn-group" role="group" aria-label="Basic radio toggle button group">
  <input type="radio" class="btn-check" name="btnradio" id="btnradio1" autocomplete="off" checked>
  <label class="btn btn-outline-primary" for="btnradio1">Radio 1</label>

  <input type="radio" class="btn-check" name="btnradio" id="btnradio2" autocomplete="off">
  <label class="btn btn-outline-primary" for="btnradio2">Radio 2</label>

  <input type="radio" class="btn-check" name="btnradio" id="btnradio3" autocomplete="off">
  <label class="btn btn-outline-primary" for="btnradio3">Radio 3</label>
</div>
```

## Button toolbar

Combine sets of button groups into button toolbars for more complex components. Use utility classes as needed to space out groups, buttons, and more.

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
     &lt;div aria-label=&quot;Toolbar with button groups&quot; class=&quot;btn-toolbar&quot; role=&quot;toolbar&quot;&gt;
&lt;div aria-label=&quot;First group&quot; class=&quot;btn-group me-2&quot; role=&quot;group&quot;&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;1&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;2&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;3&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;4&lt;/button&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Second group&quot; class=&quot;btn-group me-2&quot; role=&quot;group&quot;&gt;
&lt;button class=&quot;btn btn-secondary&quot; type=&quot;button&quot;&gt;5&lt;/button&gt;
&lt;button class=&quot;btn btn-secondary&quot; type=&quot;button&quot;&gt;6&lt;/button&gt;
&lt;button class=&quot;btn btn-secondary&quot; type=&quot;button&quot;&gt;7&lt;/button&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Third group&quot; class=&quot;btn-group&quot; role=&quot;group&quot;&gt;
&lt;button class=&quot;btn btn-info&quot; type=&quot;button&quot;&gt;8&lt;/button&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="btn-toolbar" role="toolbar" aria-label="Toolbar with button groups">
  <div class="btn-group me-2" role="group" aria-label="First group">
    <button type="button" class="btn btn-primary">1</button>
    <button type="button" class="btn btn-primary">2</button>
    <button type="button" class="btn btn-primary">3</button>
    <button type="button" class="btn btn-primary">4</button>
  </div>
  <div class="btn-group me-2" role="group" aria-label="Second group">
    <button type="button" class="btn btn-secondary">5</button>
    <button type="button" class="btn btn-secondary">6</button>
    <button type="button" class="btn btn-secondary">7</button>
  </div>
  <div class="btn-group" role="group" aria-label="Third group">
    <button type="button" class="btn btn-info">8</button>
  </div>
</div>
```

Feel free to mix input groups with button groups in your toolbars. Similar to the example above, you’ll likely need some utilities though to space things properly.

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
     &lt;div aria-label=&quot;Toolbar with button groups&quot; class=&quot;btn-toolbar mb-3&quot; role=&quot;toolbar&quot;&gt;
&lt;div aria-label=&quot;First group&quot; class=&quot;btn-group me-2&quot; role=&quot;group&quot;&gt;
&lt;button class=&quot;btn btn-outline-secondary&quot; type=&quot;button&quot;&gt;1&lt;/button&gt;
&lt;button class=&quot;btn btn-outline-secondary&quot; type=&quot;button&quot;&gt;2&lt;/button&gt;
&lt;button class=&quot;btn btn-outline-secondary&quot; type=&quot;button&quot;&gt;3&lt;/button&gt;
&lt;button class=&quot;btn btn-outline-secondary&quot; type=&quot;button&quot;&gt;4&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;input-group&quot;&gt;
&lt;div class=&quot;input-group-text&quot; id=&quot;btnGroupAddon&quot;&gt;@&lt;/div&gt;
&lt;input aria-describedby=&quot;btnGroupAddon&quot; aria-label=&quot;Input group example&quot; class=&quot;form-control&quot; placeholder=&quot;Input group example&quot; type=&quot;text&quot;/&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Toolbar with button groups&quot; class=&quot;btn-toolbar justify-content-between&quot; role=&quot;toolbar&quot;&gt;
&lt;div aria-label=&quot;First group&quot; class=&quot;btn-group&quot; role=&quot;group&quot;&gt;
&lt;button class=&quot;btn btn-outline-secondary&quot; type=&quot;button&quot;&gt;1&lt;/button&gt;
&lt;button class=&quot;btn btn-outline-secondary&quot; type=&quot;button&quot;&gt;2&lt;/button&gt;
&lt;button class=&quot;btn btn-outline-secondary&quot; type=&quot;button&quot;&gt;3&lt;/button&gt;
&lt;button class=&quot;btn btn-outline-secondary&quot; type=&quot;button&quot;&gt;4&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;input-group&quot;&gt;
&lt;div class=&quot;input-group-text&quot; id=&quot;btnGroupAddon2&quot;&gt;@&lt;/div&gt;
&lt;input aria-describedby=&quot;btnGroupAddon2&quot; aria-label=&quot;Input group example&quot; class=&quot;form-control&quot; placeholder=&quot;Input group example&quot; type=&quot;text&quot;/&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="btn-toolbar mb-3" role="toolbar" aria-label="Toolbar with button groups">
  <div class="btn-group me-2" role="group" aria-label="First group">
    <button type="button" class="btn btn-outline-secondary">1</button>
    <button type="button" class="btn btn-outline-secondary">2</button>
    <button type="button" class="btn btn-outline-secondary">3</button>
    <button type="button" class="btn btn-outline-secondary">4</button>
  </div>
  <div class="input-group">
    <div class="input-group-text" id="btnGroupAddon">@</div>
    <input type="text" class="form-control" placeholder="Input group example" aria-label="Input group example" aria-describedby="btnGroupAddon">
  </div>
</div>

<div class="btn-toolbar justify-content-between" role="toolbar" aria-label="Toolbar with button groups">
  <div class="btn-group" role="group" aria-label="First group">
    <button type="button" class="btn btn-outline-secondary">1</button>
    <button type="button" class="btn btn-outline-secondary">2</button>
    <button type="button" class="btn btn-outline-secondary">3</button>
    <button type="button" class="btn btn-outline-secondary">4</button>
  </div>
  <div class="input-group">
    <div class="input-group-text" id="btnGroupAddon2">@</div>
    <input type="text" class="form-control" placeholder="Input group example" aria-label="Input group example" aria-describedby="btnGroupAddon2">
  </div>
</div>
```

## Sizing

Instead of applying button sizing classes to every button in a group, just add `.btn-group-*` to each `.btn-group`, including each one when nesting multiple groups.

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
     &lt;div aria-label=&quot;Large button group&quot; class=&quot;btn-group btn-group-lg&quot; role=&quot;group&quot;&gt;
&lt;button class=&quot;btn btn-outline-primary&quot; type=&quot;button&quot;&gt;Left&lt;/button&gt;
&lt;button class=&quot;btn btn-outline-primary&quot; type=&quot;button&quot;&gt;Middle&lt;/button&gt;
&lt;button class=&quot;btn btn-outline-primary&quot; type=&quot;button&quot;&gt;Right&lt;/button&gt;
&lt;/div&gt;
&lt;br/&gt;
&lt;div aria-label=&quot;Default button group&quot; class=&quot;btn-group&quot; role=&quot;group&quot;&gt;
&lt;button class=&quot;btn btn-outline-primary&quot; type=&quot;button&quot;&gt;Left&lt;/button&gt;
&lt;button class=&quot;btn btn-outline-primary&quot; type=&quot;button&quot;&gt;Middle&lt;/button&gt;
&lt;button class=&quot;btn btn-outline-primary&quot; type=&quot;button&quot;&gt;Right&lt;/button&gt;
&lt;/div&gt;
&lt;br/&gt;
&lt;div aria-label=&quot;Small button group&quot; class=&quot;btn-group btn-group-sm&quot; role=&quot;group&quot;&gt;
&lt;button class=&quot;btn btn-outline-primary&quot; type=&quot;button&quot;&gt;Left&lt;/button&gt;
&lt;button class=&quot;btn btn-outline-primary&quot; type=&quot;button&quot;&gt;Middle&lt;/button&gt;
&lt;button class=&quot;btn btn-outline-primary&quot; type=&quot;button&quot;&gt;Right&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="btn-group btn-group-lg" role="group" aria-label="Large button group">
  <button type="button" class="btn btn-outline-primary">Left</button>
  <button type="button" class="btn btn-outline-primary">Middle</button>
  <button type="button" class="btn btn-outline-primary">Right</button>
</div>
<br>
<div class="btn-group" role="group" aria-label="Default button group">
  <button type="button" class="btn btn-outline-primary">Left</button>
  <button type="button" class="btn btn-outline-primary">Middle</button>
  <button type="button" class="btn btn-outline-primary">Right</button>
</div>
<br>
<div class="btn-group btn-group-sm" role="group" aria-label="Small button group">
  <button type="button" class="btn btn-outline-primary">Left</button>
  <button type="button" class="btn btn-outline-primary">Middle</button>
  <button type="button" class="btn btn-outline-primary">Right</button>
</div>
```

## Nesting

Place a `.btn-group` within another `.btn-group` when you want dropdown menus mixed with a series of buttons.

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
     &lt;div aria-label=&quot;Button group with nested dropdown&quot; class=&quot;btn-group&quot; role=&quot;group&quot;&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;1&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;2&lt;/button&gt;
&lt;div class=&quot;btn-group&quot; role=&quot;group&quot;&gt;
&lt;button aria-expanded=&quot;false&quot; class=&quot;btn btn-primary dropdown-toggle&quot; data-bs-toggle=&quot;dropdown&quot; type=&quot;button&quot;&gt;
      Dropdown
    &lt;/button&gt;
&lt;ul class=&quot;dropdown-menu&quot;&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Dropdown link&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Dropdown link&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="btn-group" role="group" aria-label="Button group with nested dropdown">
  <button type="button" class="btn btn-primary">1</button>
  <button type="button" class="btn btn-primary">2</button>

  <div class="btn-group" role="group">
    <button type="button" class="btn btn-primary dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false">
      Dropdown
    </button>
    <ul class="dropdown-menu">
      <li><a class="dropdown-item" href="#">Dropdown link</a></li>
      <li><a class="dropdown-item" href="#">Dropdown link</a></li>
    </ul>
  </div>
</div>
```

## Vertical variation

Make a set of buttons appear vertically stacked rather than horizontally. **Split button dropdowns are not supported here.**

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
     &lt;div aria-label=&quot;Vertical button group&quot; class=&quot;btn-group-vertical&quot; role=&quot;group&quot;&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;Button&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;Button&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;Button&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;Button&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="btn-group-vertical" role="group" aria-label="Vertical button group">
  <button type="button" class="btn btn-primary">Button</button>
  <button type="button" class="btn btn-primary">Button</button>
  <button type="button" class="btn btn-primary">Button</button>
  <button type="button" class="btn btn-primary">Button</button>
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
     &lt;div aria-label=&quot;Vertical button group&quot; class=&quot;btn-group-vertical&quot; role=&quot;group&quot;&gt;
&lt;div class=&quot;btn-group&quot; role=&quot;group&quot;&gt;
&lt;button aria-expanded=&quot;false&quot; class=&quot;btn btn-primary dropdown-toggle&quot; data-bs-toggle=&quot;dropdown&quot; type=&quot;button&quot;&gt;
      Dropdown
    &lt;/button&gt;
&lt;ul class=&quot;dropdown-menu&quot;&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Dropdown link&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Dropdown link&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/div&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;Button&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;Button&lt;/button&gt;
&lt;div class=&quot;btn-group dropstart&quot; role=&quot;group&quot;&gt;
&lt;button aria-expanded=&quot;false&quot; class=&quot;btn btn-primary dropdown-toggle&quot; data-bs-toggle=&quot;dropdown&quot; type=&quot;button&quot;&gt;
      Dropdown
    &lt;/button&gt;
&lt;ul class=&quot;dropdown-menu&quot;&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Dropdown link&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Dropdown link&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/div&gt;
&lt;div class=&quot;btn-group dropend&quot; role=&quot;group&quot;&gt;
&lt;button aria-expanded=&quot;false&quot; class=&quot;btn btn-primary dropdown-toggle&quot; data-bs-toggle=&quot;dropdown&quot; type=&quot;button&quot;&gt;
      Dropdown
    &lt;/button&gt;
&lt;ul class=&quot;dropdown-menu&quot;&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Dropdown link&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Dropdown link&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/div&gt;
&lt;div class=&quot;btn-group dropup&quot; role=&quot;group&quot;&gt;
&lt;button aria-expanded=&quot;false&quot; class=&quot;btn btn-primary dropdown-toggle&quot; data-bs-toggle=&quot;dropdown&quot; type=&quot;button&quot;&gt;
      Dropdown
    &lt;/button&gt;
&lt;ul class=&quot;dropdown-menu&quot;&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Dropdown link&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Dropdown link&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="btn-group-vertical" role="group" aria-label="Vertical button group">
  <div class="btn-group" role="group">
    <button type="button" class="btn btn-primary dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false">
      Dropdown
    </button>
    <ul class="dropdown-menu">
      <li><a class="dropdown-item" href="#">Dropdown link</a></li>
      <li><a class="dropdown-item" href="#">Dropdown link</a></li>
    </ul>
  </div>
  <button type="button" class="btn btn-primary">Button</button>
  <button type="button" class="btn btn-primary">Button</button>
  <div class="btn-group dropstart" role="group">
    <button type="button" class="btn btn-primary dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false">
      Dropdown
    </button>
    <ul class="dropdown-menu">
      <li><a class="dropdown-item" href="#">Dropdown link</a></li>
      <li><a class="dropdown-item" href="#">Dropdown link</a></li>
    </ul>
  </div>
  <div class="btn-group dropend" role="group">
    <button type="button" class="btn btn-primary dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false">
      Dropdown
    </button>
    <ul class="dropdown-menu">
      <li><a class="dropdown-item" href="#">Dropdown link</a></li>
      <li><a class="dropdown-item" href="#">Dropdown link</a></li>
    </ul>
  </div>
  <div class="btn-group dropup" role="group">
    <button type="button" class="btn btn-primary dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false">
      Dropdown
    </button>
    <ul class="dropdown-menu">
      <li><a class="dropdown-item" href="#">Dropdown link</a></li>
      <li><a class="dropdown-item" href="#">Dropdown link</a></li>
    </ul>
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
     &lt;div aria-label=&quot;Vertical radio toggle button group&quot; class=&quot;btn-group-vertical&quot; role=&quot;group&quot;&gt;
&lt;input autocomplete=&quot;off&quot; checked=&quot;&quot; class=&quot;btn-check&quot; id=&quot;vbtn-radio1&quot; name=&quot;vbtn-radio&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;btn btn-outline-danger&quot; for=&quot;vbtn-radio1&quot;&gt;Radio 1&lt;/label&gt;
&lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; id=&quot;vbtn-radio2&quot; name=&quot;vbtn-radio&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;btn btn-outline-danger&quot; for=&quot;vbtn-radio2&quot;&gt;Radio 2&lt;/label&gt;
&lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; id=&quot;vbtn-radio3&quot; name=&quot;vbtn-radio&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;btn btn-outline-danger&quot; for=&quot;vbtn-radio3&quot;&gt;Radio 3&lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="btn-group-vertical" role="group" aria-label="Vertical radio toggle button group">
  <input type="radio" class="btn-check" name="vbtn-radio" id="vbtn-radio1" autocomplete="off" checked>
  <label class="btn btn-outline-danger" for="vbtn-radio1">Radio 1</label>
  <input type="radio" class="btn-check" name="vbtn-radio" id="vbtn-radio2" autocomplete="off">
  <label class="btn btn-outline-danger" for="vbtn-radio2">Radio 2</label>
  <input type="radio" class="btn-check" name="vbtn-radio" id="vbtn-radio3" autocomplete="off">
  <label class="btn btn-outline-danger" for="vbtn-radio3">Radio 3</label>
</div>
```

