> Źródło: [https://getbootstrap.com/docs/5.3/helpers/color-background](https://getbootstrap.com/docs/5.3/helpers/color-background)



Added in v5.2  [View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/helpers/color-background.mdx "View and edit this file on GitHub")

# Color and background

Set a background color with contrasting foreground color.

On this page
   
**On this page**

---

* [Overview](#overview)
* [With components](#with-components)

## Overview

Color and background helpers combine the power of our [`.text-*` utilities](/docs/5.3/utilities/colors) and [`.bg-*` utilities](/docs/5.3/utilities/background) in one class. Using our Sass `color-contrast()` function, we automatically determine a contrasting `color` for a particular `background-color`.

**Heads up!** There’s currently no support for a CSS-native `color-contrast` function, so we use our own via Sass. This means that customizing our theme colors via CSS variables may cause color contrast issues with these utilities.

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
     &lt;div class=&quot;text-bg-primary p-3&quot;&gt;Primary with contrasting color&lt;/div&gt;
&lt;div class=&quot;text-bg-secondary p-3&quot;&gt;Secondary with contrasting color&lt;/div&gt;
&lt;div class=&quot;text-bg-success p-3&quot;&gt;Success with contrasting color&lt;/div&gt;
&lt;div class=&quot;text-bg-danger p-3&quot;&gt;Danger with contrasting color&lt;/div&gt;
&lt;div class=&quot;text-bg-warning p-3&quot;&gt;Warning with contrasting color&lt;/div&gt;
&lt;div class=&quot;text-bg-info p-3&quot;&gt;Info with contrasting color&lt;/div&gt;
&lt;div class=&quot;text-bg-light p-3&quot;&gt;Light with contrasting color&lt;/div&gt;
&lt;div class=&quot;text-bg-dark p-3&quot;&gt;Dark with contrasting color&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="text-bg-primary p-3">Primary with contrasting color</div>
<div class="text-bg-secondary p-3">Secondary with contrasting color</div>
<div class="text-bg-success p-3">Success with contrasting color</div>
<div class="text-bg-danger p-3">Danger with contrasting color</div>
<div class="text-bg-warning p-3">Warning with contrasting color</div>
<div class="text-bg-info p-3">Info with contrasting color</div>
<div class="text-bg-light p-3">Light with contrasting color</div>
<div class="text-bg-dark p-3">Dark with contrasting color</div>
```

**Accessibility tip:** Using color to add meaning only provides a visual indication, which will not be conveyed to users of assistive technologies like screen readers. Please ensure the meaning is obvious from the content itself (e.g., the visible text with a [*sufficient* color contrast](/docs/5.3/getting-started/accessibility/#color-contrast)) or is included through alternative means, such as additional text hidden with the `.visually-hidden` class.

## With components

Use them in place of combined `.text-*` and `.bg-*` classes, like on [badges](/docs/5.3/components/badge#background-colors):

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
     &lt;span class=&quot;badge text-bg-primary&quot;&gt;Primary&lt;/span&gt;
&lt;span class=&quot;badge text-bg-info&quot;&gt;Info&lt;/span&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<span class="badge text-bg-primary">Primary</span>
<span class="badge text-bg-info">Info</span>
```

Or on [cards](/docs/5.3/components/card#background-and-color):

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
     &lt;div class=&quot;card text-bg-primary mb-3&quot; style=&quot;max-width: 18rem;&quot;&gt;
&lt;div class=&quot;card-header&quot;&gt;Header&lt;/div&gt;
&lt;div class=&quot;card-body&quot;&gt;
&lt;p class=&quot;card-text&quot;&gt;Some quick example text to build on the card title and make up the bulk of the card’s content.&lt;/p&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;card text-bg-info mb-3&quot; style=&quot;max-width: 18rem;&quot;&gt;
&lt;div class=&quot;card-header&quot;&gt;Header&lt;/div&gt;
&lt;div class=&quot;card-body&quot;&gt;
&lt;p class=&quot;card-text&quot;&gt;Some quick example text to build on the card title and make up the bulk of the card’s content.&lt;/p&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="card text-bg-primary mb-3" style="max-width: 18rem;">
  <div class="card-header">Header</div>
  <div class="card-body">
    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card’s content.</p>
  </div>
</div>
<div class="card text-bg-info mb-3" style="max-width: 18rem;">
  <div class="card-header">Header</div>
  <div class="card-body">
    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card’s content.</p>
  </div>
</div>
```

