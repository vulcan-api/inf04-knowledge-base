> Źródło: [https://getbootstrap.com/docs/5.3/forms/range](https://getbootstrap.com/docs/5.3/forms/range)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/forms/range.mdx "View and edit this file on GitHub")

# Range

Use our custom range inputs for consistent cross-browser styling and built-in customization.

On this page
   
**On this page**

---

* [Overview](#overview)
* [Disabled](#disabled)
* [Min and max](#min-and-max)
* [Steps](#steps)
* [Output value](#output-value)
* [CSS](#css)
  + [Sass variables](#sass-variables)

## Overview

Create custom `<input type="range">` controls with `.form-range`. The track (the background) and thumb (the value) are both styled to appear the same across browsers. As only Firefox supports “filling” their track from the left or right of the thumb as a means to visually indicate progress, we do not currently support it.

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
     &lt;label class=&quot;form-label&quot; for=&quot;range1&quot;&gt;Example range&lt;/label&gt;
&lt;input class=&quot;form-range&quot; id=&quot;range1&quot; type=&quot;range&quot;/&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<label for="range1" class="form-label">Example range</label>
<input type="range" class="form-range" id="range1">
```

## Disabled

Add the `disabled` boolean attribute on an input to give it a grayed out appearance, remove pointer events, and prevent focusing.

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
     &lt;label class=&quot;form-label&quot; for=&quot;disabledRange&quot;&gt;Disabled range&lt;/label&gt;
&lt;input class=&quot;form-range&quot; disabled=&quot;&quot; id=&quot;disabledRange&quot; type=&quot;range&quot;/&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<label for="disabledRange" class="form-label">Disabled range</label>
<input type="range" class="form-range" id="disabledRange" disabled>
```

## Min and max

Range inputs have implicit values for `min` and `max`—`0` and `100`, respectively. You may specify new values for those using the `min` and `max` attributes.

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
     &lt;label class=&quot;form-label&quot; for=&quot;range2&quot;&gt;Example range&lt;/label&gt;
&lt;input class=&quot;form-range&quot; id=&quot;range2&quot; max=&quot;5&quot; min=&quot;0&quot; type=&quot;range&quot;/&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<label for="range2" class="form-label">Example range</label>
<input type="range" class="form-range" min="0" max="5" id="range2">
```

## Steps

By default, range inputs “snap” to integer values. To change this, you can specify a `step` value. In the example below, we double the number of steps by using `step="0.5"`.

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
     &lt;label class=&quot;form-label&quot; for=&quot;range3&quot;&gt;Example range&lt;/label&gt;
&lt;input class=&quot;form-range&quot; id=&quot;range3&quot; max=&quot;5&quot; min=&quot;0&quot; step=&quot;0.5&quot; type=&quot;range&quot;/&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<label for="range3" class="form-label">Example range</label>
<input type="range" class="form-range" min="0" max="5" step="0.5" id="range3">
```

## Output value

The value of the range input can be shown using the `output` element and a bit of JavaScript.

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
     &lt;label class=&quot;form-label&quot; for=&quot;range4&quot;&gt;Example range&lt;/label&gt;
&lt;input class=&quot;form-range&quot; id=&quot;range4&quot; max=&quot;100&quot; min=&quot;0&quot; type=&quot;range&quot; value=&quot;50&quot;/&gt;
&lt;output aria-hidden=&quot;true&quot; for=&quot;range4&quot; id=&quot;rangeValue&quot;&gt;&lt;/output&gt;
&lt;script&gt;
  // This is an example script, please modify as needed
  const rangeInput = document.getElementById(&#x27;range4&#x27;);
  const rangeOutput = document.getElementById(&#x27;rangeValue&#x27;);

  // Set initial value
  rangeOutput.textContent = rangeInput.value;

  rangeInput.addEventListener(&#x27;input&#x27;, function() {
    rangeOutput.textContent = this.value;
  });
&lt;/script&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<label for="range4" class="form-label">Example range</label>
<input type="range" class="form-range" min="0" max="100" value="50" id="range4">
<output for="range4" id="rangeValue" aria-hidden="true"></output>

<script>
  // This is an example script, please modify as needed
  const rangeInput = document.getElementById('range4');
  const rangeOutput = document.getElementById('rangeValue');

  // Set initial value
  rangeOutput.textContent = rangeInput.value;

  rangeInput.addEventListener('input', function() {
    rangeOutput.textContent = this.value;
  });
</script>
```

## CSS

### Sass variables

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$form-range-track-width:          100%;
$form-range-track-height:         .5rem;
$form-range-track-cursor:         pointer;
$form-range-track-bg:             var(--#{$prefix}secondary-bg);
$form-range-track-border-radius:  1rem;
$form-range-track-box-shadow:     var(--#{$prefix}box-shadow-inset);

$form-range-thumb-width:                   1rem;
$form-range-thumb-height:                  $form-range-thumb-width;
$form-range-thumb-bg:                      $component-active-bg;
$form-range-thumb-border:                  0;
$form-range-thumb-border-radius:           1rem;
$form-range-thumb-box-shadow:              0 .1rem .25rem rgba($black, .1);
$form-range-thumb-focus-box-shadow:        0 0 0 1px $body-bg, $input-focus-box-shadow;
$form-range-thumb-focus-box-shadow-width:  $input-focus-width; // For focus box shadow issue in Edge
$form-range-thumb-active-bg:               tint-color($component-active-bg, 70%);
$form-range-thumb-disabled-bg:             var(--#{$prefix}secondary-color);
$form-range-thumb-transition:              background-color .15s ease-in-out, border-color .15s ease-in-out, box-shadow .15s ease-in-out;
```

