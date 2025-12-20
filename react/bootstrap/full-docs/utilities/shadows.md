> Źródło: [https://getbootstrap.com/docs/5.3/utilities/shadows](https://getbootstrap.com/docs/5.3/utilities/shadows)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/utilities/shadows.mdx "View and edit this file on GitHub")

# Shadows

Add or remove shadows to elements with box-shadow utilities.

On this page
   
**On this page**

---

* [Examples](#examples)
* [CSS](#css)
  + [Sass variables](#sass-variables)
  + [Sass utilities API](#sass-utilities-api)

## Examples

While shadows on components are disabled by default in Bootstrap and can be enabled via `$enable-shadows`, you can also quickly add or remove a shadow with our `box-shadow` utility classes. Includes support for `.shadow-none` and three default sizes (which have associated variables to match).

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
     &lt;div class=&quot;shadow-none p-3 mb-5 bg-body-tertiary rounded&quot;&gt;No shadow&lt;/div&gt;
&lt;div class=&quot;shadow-sm p-3 mb-5 bg-body-tertiary rounded&quot;&gt;Small shadow&lt;/div&gt;
&lt;div class=&quot;shadow p-3 mb-5 bg-body-tertiary rounded&quot;&gt;Regular shadow&lt;/div&gt;
&lt;div class=&quot;shadow-lg p-3 mb-5 bg-body-tertiary rounded&quot;&gt;Larger shadow&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="shadow-none p-3 mb-5 bg-body-tertiary rounded">No shadow</div>
<div class="shadow-sm p-3 mb-5 bg-body-tertiary rounded">Small shadow</div>
<div class="shadow p-3 mb-5 bg-body-tertiary rounded">Regular shadow</div>
<div class="shadow-lg p-3 mb-5 bg-body-tertiary rounded">Larger shadow</div>
```

## CSS

### Sass variables

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$box-shadow:                  0 .5rem 1rem rgba($black, .15);
$box-shadow-sm:               0 .125rem .25rem rgba($black, .075);
$box-shadow-lg:               0 1rem 3rem rgba($black, .175);
$box-shadow-inset:            inset 0 1px 2px rgba($black, .075);
```

### Sass utilities API

Shadow utilities are declared in our utilities API in `scss/_utilities.scss`. [Learn how to use the utilities API.](/docs/5.3/utilities/api#using-the-api)

[scss/\_utilities.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_utilities.scss)

```html
"shadow": (
  property: box-shadow,
  class: shadow,
  values: (
    null: var(--#{$prefix}box-shadow),
    sm: var(--#{$prefix}box-shadow-sm),
    lg: var(--#{$prefix}box-shadow-lg),
    none: none,
  )
),
```

