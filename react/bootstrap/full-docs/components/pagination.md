> Źródło: [https://getbootstrap.com/docs/5.3/components/pagination](https://getbootstrap.com/docs/5.3/components/pagination)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/components/pagination.mdx "View and edit this file on GitHub")

# Pagination

Documentation and examples for showing pagination to indicate a series of related content exists across multiple pages.

On this page
   
**On this page**

---

* [Overview](#overview)
* [Working with icons](#working-with-icons)
* [Active](#active)
* [Disabled](#disabled)
* [Sizing](#sizing)
* [Alignment](#alignment)
* [CSS](#css)
  + [Variables](#variables)
  + [Sass variables](#sass-variables)
  + [Sass mixins](#sass-mixins)

## Overview

We use a large block of connected links for our pagination, making links hard to miss and easily scalable—all while providing large hit areas. Pagination is built with list HTML elements so screen readers can announce the number of available links. Use a wrapping `<nav>` element to identify it as a navigation section to screen readers and other assistive technologies.

In addition, as pages likely have more than one such navigation section, it’s advisable to provide a descriptive `aria-label` for the `<nav>` to reflect its purpose. For example, if the pagination component is used to navigate between a set of search results, an appropriate label could be `aria-label="Search results pages"`.

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
     &lt;nav aria-label=&quot;Page navigation example&quot;&gt;
&lt;ul class=&quot;pagination&quot;&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;Previous&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;1&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;2&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;3&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;Next&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav aria-label="Page navigation example">
  <ul class="pagination">
    <li class="page-item"><a class="page-link" href="#">Previous</a></li>
    <li class="page-item"><a class="page-link" href="#">1</a></li>
    <li class="page-item"><a class="page-link" href="#">2</a></li>
    <li class="page-item"><a class="page-link" href="#">3</a></li>
    <li class="page-item"><a class="page-link" href="#">Next</a></li>
  </ul>
</nav>
```

## Working with icons

Looking to use an icon or symbol in place of text for some pagination links? Be sure to provide proper screen reader support with `aria` attributes.

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
     &lt;nav aria-label=&quot;Page navigation example&quot;&gt;
&lt;ul class=&quot;pagination&quot;&gt;
&lt;li class=&quot;page-item&quot;&gt;
&lt;a aria-label=&quot;Previous&quot; class=&quot;page-link&quot; href=&quot;#&quot;&gt;
&lt;span aria-hidden=&quot;true&quot;&gt;«&lt;/span&gt;
&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;1&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;2&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;3&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;
&lt;a aria-label=&quot;Next&quot; class=&quot;page-link&quot; href=&quot;#&quot;&gt;
&lt;span aria-hidden=&quot;true&quot;&gt;»&lt;/span&gt;
&lt;/a&gt;
&lt;/li&gt;
&lt;/ul&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav aria-label="Page navigation example">
  <ul class="pagination">
    <li class="page-item">
      <a class="page-link" href="#" aria-label="Previous">
        <span aria-hidden="true">&laquo;</span>
      </a>
    </li>
    <li class="page-item"><a class="page-link" href="#">1</a></li>
    <li class="page-item"><a class="page-link" href="#">2</a></li>
    <li class="page-item"><a class="page-link" href="#">3</a></li>
    <li class="page-item">
      <a class="page-link" href="#" aria-label="Next">
        <span aria-hidden="true">&raquo;</span>
      </a>
    </li>
  </ul>
</nav>
```

## Active

Add `.active` to indicate a `.page-item` is the one currently being viewed. If using an `<a>` on the current page, `aria-current="page"` should be added for assistive technologies.

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
     &lt;nav aria-label=&quot;...&quot;&gt;
&lt;ul class=&quot;pagination&quot;&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;Previous&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;1&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item active&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;page-link&quot; href=&quot;#&quot;&gt;2&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;3&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;Next&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav aria-label="...">
  <ul class="pagination">
    <li class="page-item"><a href="#" class="page-link">Previous</a></li>
    <li class="page-item"><a class="page-link" href="#">1</a></li>
    <li class="page-item active">
      <a class="page-link" href="#" aria-current="page">2</a>
    </li>
    <li class="page-item"><a class="page-link" href="#">3</a></li>
    <li class="page-item"><a class="page-link" href="#">Next</a></li>
  </ul>
</nav>
```

If using a non-interactive element, like a `<span>` for the current page, you may omit the `aria-current` attribute.

```html
<li class="page-item active">
  <span class="page-link">2</span>
</li>
```

## Disabled

Add `.disabled` to a `.page-item` to make it appear un-clickable. While `.disabled` uses `pointer-events: none` to disable the link‘s interactivity, that CSS property is not yet standardized and doesn’t account for keyboard navigation. As such, you should always add `tabindex="-1"` on disabled links and use custom JavaScript to fully disable their functionality.

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
     &lt;nav aria-label=&quot;...&quot;&gt;
&lt;ul class=&quot;pagination&quot;&gt;
&lt;li class=&quot;page-item disabled&quot;&gt;
&lt;a class=&quot;page-link&quot;&gt;Previous&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;1&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item active&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;page-link&quot; href=&quot;#&quot;&gt;2&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;3&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;
&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;Next&lt;/a&gt;
&lt;/li&gt;
&lt;/ul&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav aria-label="...">
  <ul class="pagination">
    <li class="page-item disabled">
      <a class="page-link">Previous</a>
    </li>
    <li class="page-item"><a class="page-link" href="#">1</a></li>
    <li class="page-item active">
      <a class="page-link" href="#" aria-current="page">2</a>
    </li>
    <li class="page-item"><a class="page-link" href="#">3</a></li>
    <li class="page-item">
      <a class="page-link" href="#">Next</a>
    </li>
  </ul>
</nav>
```

And just like active page items, you can swap out the disabled `<a>` for a `<span>` to remove click functionality and prevent keyboard focus while retaining intended styles.

```html
<li class="page-item disabled">
  <span class="page-link">Previous</span>
</li>
```

## Sizing

Fancy larger or smaller pagination? Add `.pagination-lg` or `.pagination-sm` for additional sizes.

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
     &lt;nav aria-label=&quot;...&quot;&gt;
&lt;ul class=&quot;pagination pagination-lg&quot;&gt;
&lt;li class=&quot;page-item active&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;page-link&quot;&gt;1&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;2&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;3&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav aria-label="...">
  <ul class="pagination pagination-lg">
    <li class="page-item active" >
      <a class="page-link" aria-current="page">1</a>
    </li>
    <li class="page-item"><a class="page-link" href="#">2</a></li>
    <li class="page-item"><a class="page-link" href="#">3</a></li>
  </ul>
</nav>
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
     &lt;nav aria-label=&quot;...&quot;&gt;
&lt;ul class=&quot;pagination pagination-sm&quot;&gt;
&lt;li class=&quot;page-item active&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;page-link&quot;&gt;1&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;2&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;3&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav aria-label="...">
  <ul class="pagination pagination-sm">
    <li class="page-item active">
      <a class="page-link" aria-current="page">1</a>
    </li>
    <li class="page-item"><a class="page-link" href="#">2</a></li>
    <li class="page-item"><a class="page-link" href="#">3</a></li>
  </ul>
</nav>
```

## Alignment

Change the alignment of pagination components with [flexbox utilities](/docs/5.3/utilities/flex). For example, with `.justify-content-center`:

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
     &lt;nav aria-label=&quot;Page navigation example&quot;&gt;
&lt;ul class=&quot;pagination justify-content-center&quot;&gt;
&lt;li class=&quot;page-item disabled&quot;&gt;
&lt;a class=&quot;page-link&quot;&gt;Previous&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;1&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;2&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;3&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;
&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;Next&lt;/a&gt;
&lt;/li&gt;
&lt;/ul&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav aria-label="Page navigation example">
  <ul class="pagination justify-content-center">
    <li class="page-item disabled">
      <a class="page-link">Previous</a>
    </li>
    <li class="page-item"><a class="page-link" href="#">1</a></li>
    <li class="page-item"><a class="page-link" href="#">2</a></li>
    <li class="page-item"><a class="page-link" href="#">3</a></li>
    <li class="page-item">
      <a class="page-link" href="#">Next</a>
    </li>
  </ul>
</nav>
```

Or with `.justify-content-end`:

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
     &lt;nav aria-label=&quot;Page navigation example&quot;&gt;
&lt;ul class=&quot;pagination justify-content-end&quot;&gt;
&lt;li class=&quot;page-item disabled&quot;&gt;
&lt;a class=&quot;page-link&quot;&gt;Previous&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;1&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;2&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;3&lt;/a&gt;&lt;/li&gt;
&lt;li class=&quot;page-item&quot;&gt;
&lt;a class=&quot;page-link&quot; href=&quot;#&quot;&gt;Next&lt;/a&gt;
&lt;/li&gt;
&lt;/ul&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav aria-label="Page navigation example">
  <ul class="pagination justify-content-end">
    <li class="page-item disabled">
      <a class="page-link">Previous</a>
    </li>
    <li class="page-item"><a class="page-link" href="#">1</a></li>
    <li class="page-item"><a class="page-link" href="#">2</a></li>
    <li class="page-item"><a class="page-link" href="#">3</a></li>
    <li class="page-item">
      <a class="page-link" href="#">Next</a>
    </li>
  </ul>
</nav>
```

## CSS

### Variables

Added in v5.2.0

As part of Bootstrap’s evolving CSS variables approach, pagination now uses local CSS variables on `.pagination` for enhanced real-time customization. Values for the CSS variables are set via Sass, so Sass customization is still supported, too.

[scss/\_pagination.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_pagination.scss)

```html
--#{$prefix}pagination-padding-x: #{$pagination-padding-x};
--#{$prefix}pagination-padding-y: #{$pagination-padding-y};
@include rfs($pagination-font-size, --#{$prefix}pagination-font-size);
--#{$prefix}pagination-color: #{$pagination-color};
--#{$prefix}pagination-bg: #{$pagination-bg};
--#{$prefix}pagination-border-width: #{$pagination-border-width};
--#{$prefix}pagination-border-color: #{$pagination-border-color};
--#{$prefix}pagination-border-radius: #{$pagination-border-radius};
--#{$prefix}pagination-hover-color: #{$pagination-hover-color};
--#{$prefix}pagination-hover-bg: #{$pagination-hover-bg};
--#{$prefix}pagination-hover-border-color: #{$pagination-hover-border-color};
--#{$prefix}pagination-focus-color: #{$pagination-focus-color};
--#{$prefix}pagination-focus-bg: #{$pagination-focus-bg};
--#{$prefix}pagination-focus-box-shadow: #{$pagination-focus-box-shadow};
--#{$prefix}pagination-active-color: #{$pagination-active-color};
--#{$prefix}pagination-active-bg: #{$pagination-active-bg};
--#{$prefix}pagination-active-border-color: #{$pagination-active-border-color};
--#{$prefix}pagination-disabled-color: #{$pagination-disabled-color};
--#{$prefix}pagination-disabled-bg: #{$pagination-disabled-bg};
--#{$prefix}pagination-disabled-border-color: #{$pagination-disabled-border-color};
```

### Sass variables

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$pagination-padding-y:              .375rem;
$pagination-padding-x:              .75rem;
$pagination-padding-y-sm:           .25rem;
$pagination-padding-x-sm:           .5rem;
$pagination-padding-y-lg:           .75rem;
$pagination-padding-x-lg:           1.5rem;

$pagination-font-size:              $font-size-base;

$pagination-color:                  var(--#{$prefix}link-color);
$pagination-bg:                     var(--#{$prefix}body-bg);
$pagination-border-radius:          var(--#{$prefix}border-radius);
$pagination-border-width:           var(--#{$prefix}border-width);
$pagination-margin-start:           calc(-1 * #{$pagination-border-width}); // stylelint-disable-line function-disallowed-list
$pagination-border-color:           var(--#{$prefix}border-color);

$pagination-focus-color:            var(--#{$prefix}link-hover-color);
$pagination-focus-bg:               var(--#{$prefix}secondary-bg);
$pagination-focus-box-shadow:       $focus-ring-box-shadow;
$pagination-focus-outline:          0;

$pagination-hover-color:            var(--#{$prefix}link-hover-color);
$pagination-hover-bg:               var(--#{$prefix}tertiary-bg);
$pagination-hover-border-color:     var(--#{$prefix}border-color); // Todo in v6: remove this?

$pagination-active-color:           $component-active-color;
$pagination-active-bg:              $component-active-bg;
$pagination-active-border-color:    $component-active-bg;

$pagination-disabled-color:         var(--#{$prefix}secondary-color);
$pagination-disabled-bg:            var(--#{$prefix}secondary-bg);
$pagination-disabled-border-color:  var(--#{$prefix}border-color);

$pagination-transition:              color .15s ease-in-out, background-color .15s ease-in-out, border-color .15s ease-in-out, box-shadow .15s ease-in-out;

$pagination-border-radius-sm:       var(--#{$prefix}border-radius-sm);
$pagination-border-radius-lg:       var(--#{$prefix}border-radius-lg);
```

### Sass mixins

[scss/mixins/\_pagination.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/mixins/_pagination.scss)

```html
@mixin pagination-size($padding-y, $padding-x, $font-size, $border-radius) {
  --#{$prefix}pagination-padding-x: #{$padding-x};
  --#{$prefix}pagination-padding-y: #{$padding-y};
  @include rfs($font-size, --#{$prefix}pagination-font-size);
  --#{$prefix}pagination-border-radius: #{$border-radius};
}
```

