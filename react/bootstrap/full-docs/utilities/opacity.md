> Źródło: [https://getbootstrap.com/docs/5.3/utilities/opacity](https://getbootstrap.com/docs/5.3/utilities/opacity)



Added in v5.1  [View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/utilities/opacity.mdx "View and edit this file on GitHub")

# Opacity

Control the opacity of elements.

The `opacity` property sets the opacity level for an element. The opacity level describes the transparency level, where `1` is not transparent at all, `.5` is 50% visible, and `0` is completely transparent.

Set the `opacity` of an element using `.opacity-{value}` utilities.

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
    &lt;div class=&quot;opacity-100 p-3 m-2 bg-primary text-light fw-bold rounded&quot;&gt;100%&lt;/div&gt;&lt;div class=&quot;opacity-75 p-3 m-2 bg-primary text-light fw-bold rounded&quot;&gt;75%&lt;/div&gt;&lt;div class=&quot;opacity-50 p-3 m-2 bg-primary text-light fw-bold rounded&quot;&gt;50%&lt;/div&gt;&lt;div class=&quot;opacity-25 p-3 m-2 bg-primary text-light fw-bold rounded&quot;&gt;25%&lt;/div&gt;&lt;div class=&quot;opacity-0 p-3 m-2 bg-primary text-light fw-bold rounded&quot;&gt;0%&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="opacity-100">...</div>
<div class="opacity-75">...</div>
<div class="opacity-50">...</div>
<div class="opacity-25">...</div>
<div class="opacity-0">...</div>
```

## CSS

### Sass utilities API

Opacity utilities are declared in our utilities API in `scss/_utilities.scss`. [Learn how to use the utilities API.](/docs/5.3/utilities/api#using-the-api)

[scss/\_utilities.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_utilities.scss)

```html
"opacity": (
  property: opacity,
  values: (
    0: 0,
    25: .25,
    50: .5,
    75: .75,
    100: 1,
  )
),
```

