> Źródło: [https://getbootstrap.com/docs/5.3/utilities/float](https://getbootstrap.com/docs/5.3/utilities/float)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/utilities/float.mdx "View and edit this file on GitHub")

# Float

Toggle floats on any element, across any breakpoint, using our responsive float utilities.

On this page
   
**On this page**

---

* [Overview](#overview)
* [Responsive](#responsive)
* [CSS](#css)
  + [Sass utilities API](#sass-utilities-api)

## Overview

These utility classes float an element to the left or right, or disable floating, based on the current viewport size using the [CSS `float` property](https://developer.mozilla.org/en-US/docs/Web/CSS/float). `!important` is included to avoid specificity issues. These use the same viewport breakpoints as our grid system. Please be aware float utilities have no effect on flex items.

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
     &lt;div class=&quot;float-start&quot;&gt;Float start on all viewport sizes&lt;/div&gt;&lt;br/&gt;
&lt;div class=&quot;float-end&quot;&gt;Float end on all viewport sizes&lt;/div&gt;&lt;br/&gt;
&lt;div class=&quot;float-none&quot;&gt;Don’t float on all viewport sizes&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="float-start">Float start on all viewport sizes</div><br>
<div class="float-end">Float end on all viewport sizes</div><br>
<div class="float-none">Don’t float on all viewport sizes</div>
```

Use the [clearfix helper](/docs/5.3/helpers/clearfix) on a parent element to clear floats.

## Responsive

Responsive variations also exist for each `float` value.

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
     &lt;div class=&quot;float-sm-end&quot;&gt;Float end on viewports sized SM (small) or wider&lt;/div&gt;&lt;br/&gt;
&lt;div class=&quot;float-md-end&quot;&gt;Float end on viewports sized MD (medium) or wider&lt;/div&gt;&lt;br/&gt;
&lt;div class=&quot;float-lg-end&quot;&gt;Float end on viewports sized LG (large) or wider&lt;/div&gt;&lt;br/&gt;
&lt;div class=&quot;float-xl-end&quot;&gt;Float end on viewports sized XL (extra large) or wider&lt;/div&gt;&lt;br/&gt;
&lt;div class=&quot;float-xxl-end&quot;&gt;Float end on viewports sized XXL (extra extra large) or wider&lt;/div&gt;&lt;br/&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="float-sm-end">Float end on viewports sized SM (small) or wider</div><br>
<div class="float-md-end">Float end on viewports sized MD (medium) or wider</div><br>
<div class="float-lg-end">Float end on viewports sized LG (large) or wider</div><br>
<div class="float-xl-end">Float end on viewports sized XL (extra large) or wider</div><br>
<div class="float-xxl-end">Float end on viewports sized XXL (extra extra large) or wider</div><br>
```

Here are all the support classes:

* `.float-start`
* `.float-end`
* `.float-none`
* `.float-sm-start`
* `.float-sm-end`
* `.float-sm-none`
* `.float-md-start`
* `.float-md-end`
* `.float-md-none`
* `.float-lg-start`
* `.float-lg-end`
* `.float-lg-none`
* `.float-xl-start`
* `.float-xl-end`
* `.float-xl-none`
* `.float-xxl-start`
* `.float-xxl-end`
* `.float-xxl-none`

## CSS

### Sass utilities API

Float utilities are declared in our utilities API in `scss/_utilities.scss`. [Learn how to use the utilities API.](/docs/5.3/utilities/api#using-the-api)

[scss/\_utilities.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_utilities.scss)

```html
"float": (
  responsive: true,
  property: float,
  values: (
    start: left,
    end: right,
    none: none,
  )
),
```

