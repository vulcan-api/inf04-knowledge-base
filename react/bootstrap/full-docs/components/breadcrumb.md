> Źródło: [https://getbootstrap.com/docs/5.3/components/breadcrumb](https://getbootstrap.com/docs/5.3/components/breadcrumb)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/components/breadcrumb.mdx "View and edit this file on GitHub")

# Breadcrumb

Indicate the current page’s location within a navigational hierarchy that automatically adds separators via CSS.

On this page
   
**On this page**

---

* [Example](#example)
* [Dividers](#dividers)
* [Accessibility](#accessibility)
* [CSS](#css)
  + [Variables](#variables)
  + [Sass variables](#sass-variables)

## Example

Use an ordered or unordered list with linked list items to create a minimally styled breadcrumb. Use our utilities to add additional styles as desired.

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
     &lt;nav aria-label=&quot;breadcrumb&quot;&gt;
&lt;ol class=&quot;breadcrumb&quot;&gt;
&lt;li aria-current=&quot;page&quot; class=&quot;breadcrumb-item active&quot;&gt;Home&lt;/li&gt;
&lt;/ol&gt;
&lt;/nav&gt;
&lt;nav aria-label=&quot;breadcrumb&quot;&gt;
&lt;ol class=&quot;breadcrumb&quot;&gt;
&lt;li class=&quot;breadcrumb-item&quot;&gt;&lt;a href=&quot;#&quot;&gt;Home&lt;/a&gt;&lt;/li&gt;
&lt;li aria-current=&quot;page&quot; class=&quot;breadcrumb-item active&quot;&gt;Library&lt;/li&gt;
&lt;/ol&gt;
&lt;/nav&gt;
&lt;nav aria-label=&quot;breadcrumb&quot;&gt;
&lt;ol class=&quot;breadcrumb&quot;&gt;
&lt;li class=&quot;breadcrumb-item&quot;&gt;&lt;a href=&quot;#&quot;&gt;Home&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;breadcrumb-item&quot;&gt;&lt;a href=&quot;#&quot;&gt;Library&lt;/a&gt;&lt;/li&gt;
&lt;li aria-current=&quot;page&quot; class=&quot;breadcrumb-item active&quot;&gt;Data&lt;/li&gt;
&lt;/ol&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav aria-label="breadcrumb">
  <ol class="breadcrumb">
    <li class="breadcrumb-item active" aria-current="page">Home</li>
  </ol>
</nav>

<nav aria-label="breadcrumb">
  <ol class="breadcrumb">
    <li class="breadcrumb-item"><a href="#">Home</a></li>
    <li class="breadcrumb-item active" aria-current="page">Library</li>
  </ol>
</nav>

<nav aria-label="breadcrumb">
  <ol class="breadcrumb">
    <li class="breadcrumb-item"><a href="#">Home</a></li>
    <li class="breadcrumb-item"><a href="#">Library</a></li>
    <li class="breadcrumb-item active" aria-current="page">Data</li>
  </ol>
</nav>
```

## Dividers

Dividers are automatically added in CSS through [`::before`](https://developer.mozilla.org/en-US/docs/Web/CSS/::before) and [`content`](https://developer.mozilla.org/en-US/docs/Web/CSS/content). They can be changed by modifying a local CSS custom property `--bs-breadcrumb-divider`, or through the `$breadcrumb-divider` Sass variable — and `$breadcrumb-divider-flipped` for its RTL counterpart, if needed. We default to our Sass variable, which is set as a fallback to the custom property. This way, you get a global divider that you can override without recompiling CSS at any time.

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
     &lt;nav aria-label=&quot;breadcrumb&quot; style=&quot;--bs-breadcrumb-divider: &#x27;&amp;gt;&#x27;;&quot;&gt;
&lt;ol class=&quot;breadcrumb&quot;&gt;
&lt;li class=&quot;breadcrumb-item&quot;&gt;&lt;a href=&quot;#&quot;&gt;Home&lt;/a&gt;&lt;/li&gt;
&lt;li aria-current=&quot;page&quot; class=&quot;breadcrumb-item active&quot;&gt;Library&lt;/li&gt;
&lt;/ol&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav style="--bs-breadcrumb-divider: '>';" aria-label="breadcrumb">
  <ol class="breadcrumb">
    <li class="breadcrumb-item"><a href="#">Home</a></li>
    <li class="breadcrumb-item active" aria-current="page">Library</li>
  </ol>
</nav>
```

When modifying via Sass, the [quote](https://sass-lang.com/documentation/modules/string/#quote) function is required to generate the quotes around a string. For example, using `>` as the divider, you can use this:

```html
$breadcrumb-divider: quote(">");
```

It’s also possible to use an **embedded SVG icon**. Apply it via our CSS custom property, or use the Sass variable.

**Inlined SVG requires properly escaped characters.** Some reserved characters, such as `<`, `>` and `#`, must be URL-encoded or escaped. We do this with the `$breadcrumb-divider` variable using our [`escape-svg()` Sass function](/docs/5.3/customize/sass#escape-svg). When customizing the CSS variable, you must handle this yourself. Read [Kevin Weber’s explanations on CodePen](https://codepen.io/kevinweber/pen/dXWoRw) for more info.

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
     &lt;nav aria-label=&quot;breadcrumb&quot; style=&quot;--bs-breadcrumb-divider: url(&amp;quot;data:image/svg+xml,%3Csvg xmlns=&#x27;http://www.w3.org/2000/svg&#x27; width=&#x27;8&#x27; height=&#x27;8&#x27;%3E%3Cpath d=&#x27;M2.5 0L1 1.5 3.5 4 1 6.5 2.5 8l4-4-4-4z&#x27; fill=&#x27;%236c757d&#x27;/%3E%3C/svg%3E&amp;quot;);&quot;&gt;
&lt;ol class=&quot;breadcrumb&quot;&gt;
&lt;li class=&quot;breadcrumb-item&quot;&gt;&lt;a href=&quot;#&quot;&gt;Home&lt;/a&gt;&lt;/li&gt;
&lt;li aria-current=&quot;page&quot; class=&quot;breadcrumb-item active&quot;&gt;Library&lt;/li&gt;
&lt;/ol&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav style="--bs-breadcrumb-divider: url(&#34;data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='8' height='8'%3E%3Cpath d='M2.5 0L1 1.5 3.5 4 1 6.5 2.5 8l4-4-4-4z' fill='%236c757d'/%3E%3C/svg%3E&#34;);" aria-label="breadcrumb">
  <ol class="breadcrumb">
    <li class="breadcrumb-item"><a href="#">Home</a></li>
    <li class="breadcrumb-item active" aria-current="page">Library</li>
  </ol>
</nav>
```

```html
$breadcrumb-divider: url("data:image/svg+xml,<svg xmlns='http://www.w3.org/2000/svg' width='8' height='8'><path d='M2.5 0L1 1.5 3.5 4 1 6.5 2.5 8l4-4-4-4z' fill='#{$breadcrumb-divider-color}'/></svg>");
```

You can also remove the divider setting `--bs-breadcrumb-divider: '';` (empty strings in CSS custom properties counts as a value), or setting the Sass variable to `$breadcrumb-divider: none;`.

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
     &lt;nav aria-label=&quot;breadcrumb&quot; style=&quot;--bs-breadcrumb-divider: &#x27;&#x27;;&quot;&gt;
&lt;ol class=&quot;breadcrumb&quot;&gt;
&lt;li class=&quot;breadcrumb-item&quot;&gt;&lt;a href=&quot;#&quot;&gt;Home&lt;/a&gt;&lt;/li&gt;
&lt;li aria-current=&quot;page&quot; class=&quot;breadcrumb-item active&quot;&gt;Library&lt;/li&gt;
&lt;/ol&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav style="--bs-breadcrumb-divider: '';" aria-label="breadcrumb">
  <ol class="breadcrumb">
    <li class="breadcrumb-item"><a href="#">Home</a></li>
    <li class="breadcrumb-item active" aria-current="page">Library</li>
  </ol>
</nav>
```

```html
$breadcrumb-divider: none;
```

## Accessibility

Since breadcrumbs provide a navigation, it’s a good idea to add a meaningful label such as `aria-label="breadcrumb"` to describe the type of navigation provided in the `<nav>` element, as well as applying an `aria-current="page"` to the last item of the set to indicate that it represents the current page.

For more information, see the [ARIA Authoring Practices Guide breadcrumb pattern](https://www.w3.org/WAI/ARIA/apg/patterns/breadcrumb/).

## CSS

### Variables

Added in v5.2.0

As part of Bootstrap’s evolving CSS variables approach, breadcrumbs now use local CSS variables on `.breadcrumb` for enhanced real-time customization. Values for the CSS variables are set via Sass, so Sass customization is still supported, too.

[scss/\_breadcrumb.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_breadcrumb.scss)

```html
--#{$prefix}breadcrumb-padding-x: #{$breadcrumb-padding-x};
--#{$prefix}breadcrumb-padding-y: #{$breadcrumb-padding-y};
--#{$prefix}breadcrumb-margin-bottom: #{$breadcrumb-margin-bottom};
@include rfs($breadcrumb-font-size, --#{$prefix}breadcrumb-font-size);
--#{$prefix}breadcrumb-bg: #{$breadcrumb-bg};
--#{$prefix}breadcrumb-border-radius: #{$breadcrumb-border-radius};
--#{$prefix}breadcrumb-divider-color: #{$breadcrumb-divider-color};
--#{$prefix}breadcrumb-item-padding-x: #{$breadcrumb-item-padding-x};
--#{$prefix}breadcrumb-item-active-color: #{$breadcrumb-active-color};
```

### Sass variables

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$breadcrumb-font-size:              null;
$breadcrumb-padding-y:              0;
$breadcrumb-padding-x:              0;
$breadcrumb-item-padding-x:         .5rem;
$breadcrumb-margin-bottom:          1rem;
$breadcrumb-bg:                     null;
$breadcrumb-divider-color:          var(--#{$prefix}secondary-color);
$breadcrumb-active-color:           var(--#{$prefix}secondary-color);
$breadcrumb-divider:                quote("/");
$breadcrumb-divider-flipped:        $breadcrumb-divider;
$breadcrumb-border-radius:          null;
```

