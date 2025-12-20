> Źródło: [https://getbootstrap.com/docs/5.3/utilities/overflow](https://getbootstrap.com/docs/5.3/utilities/overflow)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/utilities/overflow.mdx "View and edit this file on GitHub")

# Overflow

Use these shorthand utilities for quickly configuring how content overflows an element.

On this page
   
**On this page**

---

* [Overflow](#overflow)
  + [overflow-x](#overflow-x)
  + [overflow-y](#overflow-y)
* [CSS](#css)
  + [Sass utilities API](#sass-utilities-api)

## Overflow

Adjust the `overflow` property on the fly with four default values and classes. These classes are not responsive by default.

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
    &lt;div class=&quot;overflow-auto p-3 mb-3 mb-md-0 me-md-3 bg-body-tertiary&quot; style=&quot;max-width: 260px; max-height: 100px;&quot;&gt;&lt;p&gt;This is an example of using &lt;code&gt;.overflow-auto&lt;/code&gt; on an element with set width and height dimensions. By design, this content will vertically scroll.&lt;/p&gt;&lt;/div&gt;&lt;div class=&quot;overflow-hidden p-3 mb-3 mb-md-0 me-md-3 bg-body-tertiary&quot; style=&quot;max-width: 260px; max-height: 100px;&quot;&gt;&lt;p&gt;This is an example of using &lt;code&gt;.overflow-hidden&lt;/code&gt; on an element with set width and height dimensions.&lt;/p&gt;&lt;/div&gt;&lt;div class=&quot;overflow-visible p-3 mb-3 mb-md-0 me-md-3 bg-body-tertiary&quot; style=&quot;max-width: 260px; max-height: 100px;&quot;&gt;&lt;p&gt;This is an example of using &lt;code&gt;.overflow-visible&lt;/code&gt; on an element with set width and height dimensions.&lt;/p&gt;&lt;/div&gt;&lt;div class=&quot;overflow-scroll p-3 bg-body-tertiary&quot; style=&quot;max-width: 260px; max-height: 100px;&quot;&gt;&lt;p&gt;This is an example of using &lt;code&gt;.overflow-scroll&lt;/code&gt; on an element with set width and height dimensions.&lt;/p&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="overflow-auto">...</div>
<div class="overflow-hidden">...</div>
<div class="overflow-visible">...</div>
<div class="overflow-scroll">...</div>
```

### `overflow-x`

Adjust the `overflow-x` property to affect the overflow of content horizontally.

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
    &lt;div class=&quot;overflow-x-auto p-3 mb-3 mb-md-0 me-md-3 bg-body-tertiary w-100&quot; style=&quot;max-width: 200px; max-height: 100px; white-space: nowrap;&quot;&gt;&lt;div&gt;&lt;code&gt;.overflow-x-auto&lt;/code&gt; example on an element&lt;/div&gt;&lt;div&gt; with set width and height dimensions.&lt;/div&gt;&lt;/div&gt;&lt;div class=&quot;overflow-x-hidden p-3 mb-3 mb-md-0 me-md-3 bg-body-tertiary w-100&quot; style=&quot;max-width: 200px; max-height: 100px;white-space: nowrap;&quot;&gt;&lt;div&gt;&lt;code&gt;.overflow-x-hidden&lt;/code&gt; example&lt;/div&gt;&lt;div&gt;on an element with set width and height dimensions.&lt;/div&gt;&lt;/div&gt;&lt;div class=&quot;overflow-x-visible p-3 mb-3 mb-md-0 me-md-3 bg-body-tertiary w-100&quot; style=&quot;max-width: 200px; max-height: 100px;white-space: nowrap;&quot;&gt;&lt;div&gt;&lt;code&gt;.overflow-x-visible&lt;/code&gt; example &lt;/div&gt;&lt;div&gt;on an element with set width and height dimensions.&lt;/div&gt;&lt;/div&gt;&lt;div class=&quot;overflow-x-scroll p-3 bg-body-tertiary w-100&quot; style=&quot;max-width: 200px; max-height: 100px;white-space: nowrap;&quot;&gt;&lt;div&gt;&lt;code&gt;.overflow-x-scroll&lt;/code&gt; example on an element&lt;/div&gt;&lt;div&gt; with set width and height dimensions.&lt;/div&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="overflow-x-auto">...</div>
<div class="overflow-x-hidden">...</div>
<div class="overflow-x-visible">...</div>
<div class="overflow-x-scroll">...</div>
```

### `overflow-y`

Adjust the `overflow-y` property to affect the overflow of content vertically.

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
    &lt;div class=&quot;overflow-y-auto p-3 mb-3 mb-md-0 me-md-3 bg-body-tertiary w-100&quot; style=&quot;max-width: 200px; max-height: 100px;&quot;&gt;&lt;p&gt;&lt;code&gt;.overflow-y-auto&lt;/code&gt; example on an element with set width and height dimensions.&lt;/p&gt;&lt;/div&gt;&lt;div class=&quot;overflow-y-hidden p-3 mb-3 mb-md-0 me-md-3 bg-body-tertiary w-100&quot; style=&quot;max-width: 200px; max-height: 100px;&quot;&gt;&lt;p&gt;&lt;code&gt;.overflow-y-hidden&lt;/code&gt; example on an element with set width and height dimensions.&lt;/p&gt;&lt;/div&gt;&lt;div class=&quot;overflow-y-visible p-3 mb-3 mb-md-0 me-md-3 bg-body-tertiary w-100&quot; style=&quot;max-width: 200px; max-height: 100px;&quot;&gt;&lt;p&gt;&lt;code&gt;.overflow-y-visible&lt;/code&gt; example on an element with set width and height dimensions.&lt;/p&gt;&lt;/div&gt;&lt;div class=&quot;overflow-y-scroll p-3 bg-body-tertiary w-100&quot; style=&quot;max-width: 200px; max-height: 100px;&quot;&gt;&lt;p&gt;&lt;code&gt;.overflow-y-scroll&lt;/code&gt; example on an element with set width and height dimensions.&lt;/p&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="overflow-y-auto">...</div>
<div class="overflow-y-hidden">...</div>
<div class="overflow-y-visible">...</div>
<div class="overflow-y-scroll">...</div>
```

Using Sass variables, you may customize the overflow utilities by changing the `$overflows` variable in `_variables.scss`.

## CSS

### Sass utilities API

Overflow utilities are declared in our utilities API in `scss/_utilities.scss`. [Learn how to use the utilities API.](/docs/5.3/utilities/api#using-the-api)

[scss/\_utilities.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_utilities.scss)

```html
"overflow": (
  property: overflow,
  values: auto hidden visible scroll,
),
"overflow-x": (
  property: overflow-x,
  values: auto hidden visible scroll,
),
"overflow-y": (
  property: overflow-y,
  values: auto hidden visible scroll,
),
```

