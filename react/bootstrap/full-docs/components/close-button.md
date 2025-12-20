> Źródło: [https://getbootstrap.com/docs/5.3/components/close-button](https://getbootstrap.com/docs/5.3/components/close-button)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/components/close-button.mdx "View and edit this file on GitHub")

# Close button

A generic close button for dismissing content like modals and alerts.

On this page
   
**On this page**

---

* [Example](#example)
* [Disabled state](#disabled-state)
* [Dark variant](#dark-variant)
* [CSS](#css)
  + [Variables](#variables)
  + [Sass variables](#sass-variables)

## Example

Provide an option to dismiss or close a component with `.btn-close`. Default styling is limited, but highly customizable. Modify the Sass variables to replace the default `background-image`. **Be sure to include text for screen readers**, as we’ve done with `aria-label`.

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
     &lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; type=&quot;button&quot;&gt;&lt;/button&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<button type="button" class="btn-close" aria-label="Close"></button>
```

## Disabled state

Disabled close buttons change their `opacity`. We’ve also applied `pointer-events: none` and `user-select: none` to preventing hover and active states from triggering.

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
     &lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; disabled=&quot;&quot; type=&quot;button&quot;&gt;&lt;/button&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<button type="button" class="btn-close" disabled aria-label="Close"></button>
```

## Dark variant

Deprecated in v5.3.0 

**Heads up!** As of v5.3.0, the `.btn-close-white` class is deprecated. Instead, use `data-bs-theme="dark"` to change the color mode of the close button.

Add `data-bs-theme="dark"` to the `.btn-close`, or to its parent element, to invert the close button. This uses the `filter` property to invert the `background-image` without overriding its value.

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
     &lt;div data-bs-theme=&quot;dark&quot;&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; disabled=&quot;&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div data-bs-theme="dark">
  <button type="button" class="btn-close" aria-label="Close"></button>
  <button type="button" class="btn-close" disabled aria-label="Close"></button>
</div>
```

## CSS

### Variables

Added in v5.3.0

As part of Bootstrap’s evolving CSS variables approach, close button now uses local CSS variables on `.btn-close` for enhanced real-time customization. Values for the CSS variables are set via Sass, so Sass customization is still supported, too.

[scss/\_close.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_close.scss)

```html
--#{$prefix}btn-close-color: #{$btn-close-color};
--#{$prefix}btn-close-bg: #{ escape-svg($btn-close-bg) };
--#{$prefix}btn-close-opacity: #{$btn-close-opacity};
--#{$prefix}btn-close-hover-opacity: #{$btn-close-hover-opacity};
--#{$prefix}btn-close-focus-shadow: #{$btn-close-focus-shadow};
--#{$prefix}btn-close-focus-opacity: #{$btn-close-focus-opacity};
--#{$prefix}btn-close-disabled-opacity: #{$btn-close-disabled-opacity};
```

### Sass variables

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$btn-close-width:            1em;
$btn-close-height:           $btn-close-width;
$btn-close-padding-x:        .25em;
$btn-close-padding-y:        $btn-close-padding-x;
$btn-close-color:            $black;
$btn-close-bg:               url("data:image/svg+xml,<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 16 16' fill='#{$btn-close-color}'><path d='M.293.293a1 1 0 0 1 1.414 0L8 6.586 14.293.293a1 1 0 1 1 1.414 1.414L9.414 8l6.293 6.293a1 1 0 0 1-1.414 1.414L8 9.414l-6.293 6.293a1 1 0 0 1-1.414-1.414L6.586 8 .293 1.707a1 1 0 0 1 0-1.414'/></svg>");
$btn-close-focus-shadow:     $focus-ring-box-shadow;
$btn-close-opacity:          .5;
$btn-close-hover-opacity:    .75;
$btn-close-focus-opacity:    1;
$btn-close-disabled-opacity: .25;
$btn-close-filter:           null;
$btn-close-white-filter:     invert(1) grayscale(100%) brightness(200%); // Deprecated in v5.3.4
```

