> Źródło: [https://getbootstrap.com/docs/5.3/utilities/colors](https://getbootstrap.com/docs/5.3/utilities/colors)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/utilities/colors.mdx "View and edit this file on GitHub")

# Colors

Convey meaning through `color` with a handful of color utility classes. Includes support for styling links with hover states, too.

On this page
   
**On this page**

---

* [Colors](#colors)
* [Opacity](#opacity)
  + [How it works](#how-it-works)
  + [Example](#example)
* [Specificity](#specificity)
* [CSS](#css)
  + [Sass variables](#sass-variables)
  + [Sass maps](#sass-maps)
  + [Sass utilities API](#sass-utilities-api)

**Accessibility tip:** Using color to add meaning only provides a visual indication, which will not be conveyed to users of assistive technologies like screen readers. Please ensure the meaning is obvious from the content itself (e.g., the visible text with a [*sufficient* color contrast](/docs/5.3/getting-started/accessibility/#color-contrast)) or is included through alternative means, such as additional text hidden with the `.visually-hidden` class.

## Colors

Colorize text with color utilities. If you want to colorize links, you can use the [`.link-*` helper classes](/docs/5.3/helpers/colored-links) which have `:hover` and `:focus` states.

Color utilities like `.text-*` that generated from our original `$theme-colors` Sass map don’t yet respond to color modes, however, any `.text-*-emphasis` utility will. This will be resolved in v6.

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
     &lt;p class=&quot;text-primary&quot;&gt;.text-primary&lt;/p&gt;
&lt;p class=&quot;text-primary-emphasis&quot;&gt;.text-primary-emphasis&lt;/p&gt;
&lt;p class=&quot;text-secondary&quot;&gt;.text-secondary&lt;/p&gt;
&lt;p class=&quot;text-secondary-emphasis&quot;&gt;.text-secondary-emphasis&lt;/p&gt;
&lt;p class=&quot;text-success&quot;&gt;.text-success&lt;/p&gt;
&lt;p class=&quot;text-success-emphasis&quot;&gt;.text-success-emphasis&lt;/p&gt;
&lt;p class=&quot;text-danger&quot;&gt;.text-danger&lt;/p&gt;
&lt;p class=&quot;text-danger-emphasis&quot;&gt;.text-danger-emphasis&lt;/p&gt;
&lt;p class=&quot;text-warning bg-dark&quot;&gt;.text-warning&lt;/p&gt;
&lt;p class=&quot;text-warning-emphasis&quot;&gt;.text-warning-emphasis&lt;/p&gt;
&lt;p class=&quot;text-info bg-dark&quot;&gt;.text-info&lt;/p&gt;
&lt;p class=&quot;text-info-emphasis&quot;&gt;.text-info-emphasis&lt;/p&gt;
&lt;p class=&quot;text-light bg-dark&quot;&gt;.text-light&lt;/p&gt;
&lt;p class=&quot;text-light-emphasis&quot;&gt;.text-light-emphasis&lt;/p&gt;
&lt;p class=&quot;text-dark bg-white&quot;&gt;.text-dark&lt;/p&gt;
&lt;p class=&quot;text-dark-emphasis&quot;&gt;.text-dark-emphasis&lt;/p&gt;
&lt;p class=&quot;text-body&quot;&gt;.text-body&lt;/p&gt;
&lt;p class=&quot;text-body-emphasis&quot;&gt;.text-body-emphasis&lt;/p&gt;
&lt;p class=&quot;text-body-secondary&quot;&gt;.text-body-secondary&lt;/p&gt;
&lt;p class=&quot;text-body-tertiary&quot;&gt;.text-body-tertiary&lt;/p&gt;
&lt;p class=&quot;text-black bg-white&quot;&gt;.text-black&lt;/p&gt;
&lt;p class=&quot;text-white bg-dark&quot;&gt;.text-white&lt;/p&gt;
&lt;p class=&quot;text-black-50 bg-white&quot;&gt;.text-black-50&lt;/p&gt;
&lt;p class=&quot;text-white-50 bg-dark&quot;&gt;.text-white-50&lt;/p&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<p class="text-primary">.text-primary</p>
<p class="text-primary-emphasis">.text-primary-emphasis</p>
<p class="text-secondary">.text-secondary</p>
<p class="text-secondary-emphasis">.text-secondary-emphasis</p>
<p class="text-success">.text-success</p>
<p class="text-success-emphasis">.text-success-emphasis</p>
<p class="text-danger">.text-danger</p>
<p class="text-danger-emphasis">.text-danger-emphasis</p>
<p class="text-warning bg-dark">.text-warning</p>
<p class="text-warning-emphasis">.text-warning-emphasis</p>
<p class="text-info bg-dark">.text-info</p>
<p class="text-info-emphasis">.text-info-emphasis</p>
<p class="text-light bg-dark">.text-light</p>
<p class="text-light-emphasis">.text-light-emphasis</p>
<p class="text-dark bg-white">.text-dark</p>
<p class="text-dark-emphasis">.text-dark-emphasis</p>

<p class="text-body">.text-body</p>
<p class="text-body-emphasis">.text-body-emphasis</p>
<p class="text-body-secondary">.text-body-secondary</p>
<p class="text-body-tertiary">.text-body-tertiary</p>

<p class="text-black bg-white">.text-black</p>
<p class="text-white bg-dark">.text-white</p>
<p class="text-black-50 bg-white">.text-black-50</p>
<p class="text-white-50 bg-dark">.text-white-50</p>
```

**Deprecation:** With the addition of `.text-opacity-*` utilities and CSS variables for text utilities, `.text-black-50` and `.text-white-50` are deprecated as of v5.1.0. They’ll be removed in v6.0.0.

**Deprecation:** With the addition of the expanded theme colors and variables, the `.text-muted` utility has been deprecated as of v5.3.0. Its default value has also been reassigned to the new `--bs-secondary-color` CSS variable to better support color modes. It will be removed in v6.0.0.

## Opacity

Added in v5.1.0

As of v5.1.0, text color utilities are generated with Sass using CSS variables. This allows for real-time color changes without compilation and dynamic alpha transparency changes.

### How it works

Consider our default `.text-primary` utility.

```html
.text-primary {
  --bs-text-opacity: 1;
  color: rgba(var(--bs-primary-rgb), var(--bs-text-opacity)) !important;
}
```

We use an RGB version of our `--bs-primary` (with the value of `13, 110, 253`) CSS variable and attached a second CSS variable, `--bs-text-opacity`, for the alpha transparency (with a default value `1` thanks to a local CSS variable). That means anytime you use `.text-primary` now, your computed `color` value is `rgba(13, 110, 253, 1)`. The local CSS variable inside each `.text-*` class avoids inheritance issues so nested instances of the utilities don’t automatically have a modified alpha transparency.

### Example

To change that opacity, override `--bs-text-opacity` via custom styles or inline styles.

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
     &lt;div class=&quot;text-primary&quot;&gt;This is default primary text&lt;/div&gt;
&lt;div class=&quot;text-primary&quot; style=&quot;--bs-text-opacity: .5;&quot;&gt;This is 50% opacity primary text&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="text-primary">This is default primary text</div>
<div class="text-primary" style="--bs-text-opacity: .5;">This is 50% opacity primary text</div>
```

Or, choose from any of the `.text-opacity` utilities:

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
     &lt;div class=&quot;text-primary&quot;&gt;This is default primary text&lt;/div&gt;
&lt;div class=&quot;text-primary text-opacity-75&quot;&gt;This is 75% opacity primary text&lt;/div&gt;
&lt;div class=&quot;text-primary text-opacity-50&quot;&gt;This is 50% opacity primary text&lt;/div&gt;
&lt;div class=&quot;text-primary text-opacity-25&quot;&gt;This is 25% opacity primary text&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="text-primary">This is default primary text</div>
<div class="text-primary text-opacity-75">This is 75% opacity primary text</div>
<div class="text-primary text-opacity-50">This is 50% opacity primary text</div>
<div class="text-primary text-opacity-25">This is 25% opacity primary text</div>
```

## Specificity

Sometimes contextual classes cannot be applied due to the specificity of another selector. In some cases, a sufficient workaround is to wrap your element’s content in a `<div>` or more semantic element with the desired class.

## CSS

In addition to the following Sass functionality, consider reading about our included [CSS custom properties](/docs/5.3/customize/css-variables) (aka CSS variables) for colors and more.

### Sass variables

Most `color` utilities are generated by our theme colors, reassigned from our generic color palette variables.

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$blue:    #0d6efd;
$indigo:  #6610f2;
$purple:  #6f42c1;
$pink:    #d63384;
$red:     #dc3545;
$orange:  #fd7e14;
$yellow:  #ffc107;
$green:   #198754;
$teal:    #20c997;
$cyan:    #0dcaf0;
```

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$primary:       $blue;
$secondary:     $gray-600;
$success:       $green;
$info:          $cyan;
$warning:       $yellow;
$danger:        $red;
$light:         $gray-100;
$dark:          $gray-900;
```

Grayscale colors are also available, but only a subset are used to generate any utilities.

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$white:    #fff;
$gray-100: #f8f9fa;
$gray-200: #e9ecef;
$gray-300: #dee2e6;
$gray-400: #ced4da;
$gray-500: #adb5bd;
$gray-600: #6c757d;
$gray-700: #495057;
$gray-800: #343a40;
$gray-900: #212529;
$black:    #000;
```

[scss/\_maps.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_maps.scss)

```html
$theme-colors-text: (
  "primary": $primary-text-emphasis,
  "secondary": $secondary-text-emphasis,
  "success": $success-text-emphasis,
  "info": $info-text-emphasis,
  "warning": $warning-text-emphasis,
  "danger": $danger-text-emphasis,
  "light": $light-text-emphasis,
  "dark": $dark-text-emphasis,
);
```

Variables for setting colors in `.text-*-emphasis` utilities in light and dark mode:

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$primary-text-emphasis:   shade-color($primary, 60%);
$secondary-text-emphasis: shade-color($secondary, 60%);
$success-text-emphasis:   shade-color($success, 60%);
$info-text-emphasis:      shade-color($info, 60%);
$warning-text-emphasis:   shade-color($warning, 60%);
$danger-text-emphasis:    shade-color($danger, 60%);
$light-text-emphasis:     $gray-700;
$dark-text-emphasis:      $gray-700;
```

[scss/\_variables-dark.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables-dark.scss)

```html
$primary-text-emphasis-dark:        tint-color($primary, 40%);
$secondary-text-emphasis-dark:      tint-color($secondary, 40%);
$success-text-emphasis-dark:        tint-color($success, 40%);
$info-text-emphasis-dark:           tint-color($info, 40%);
$warning-text-emphasis-dark:        tint-color($warning, 40%);
$danger-text-emphasis-dark:         tint-color($danger, 40%);
$light-text-emphasis-dark:          $gray-100;
$dark-text-emphasis-dark:           $gray-300;
```

### Sass maps

Theme colors are then put into a Sass map so we can loop over them to generate our utilities, component modifiers, and more.

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$theme-colors: (
  "primary":    $primary,
  "secondary":  $secondary,
  "success":    $success,
  "info":       $info,
  "warning":    $warning,
  "danger":     $danger,
  "light":      $light,
  "dark":       $dark
);
```

Grayscale colors are also available as a Sass map. **This map is not used to generate any utilities.**

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$grays: (
  "100": $gray-100,
  "200": $gray-200,
  "300": $gray-300,
  "400": $gray-400,
  "500": $gray-500,
  "600": $gray-600,
  "700": $gray-700,
  "800": $gray-800,
  "900": $gray-900
);
```

RGB colors are generated from a separate Sass map:

[scss/\_maps.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_maps.scss)

```html
$theme-colors-rgb: map-loop($theme-colors, to-rgb, "$value");
```

Color opacities build on that with their own map that’s consumed by the utilities API:

[scss/\_maps.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_maps.scss)

```html
$utilities-text: map-merge(
  $utilities-colors,
  (
    "black": to-rgb($black),
    "white": to-rgb($white),
    "body": to-rgb($body-color)
  )
);
$utilities-text-colors: map-loop($utilities-text, rgba-css-var, "$key", "text");

$utilities-text-emphasis-colors: (
  "primary-emphasis": var(--#{$prefix}primary-text-emphasis),
  "secondary-emphasis": var(--#{$prefix}secondary-text-emphasis),
  "success-emphasis": var(--#{$prefix}success-text-emphasis),
  "info-emphasis": var(--#{$prefix}info-text-emphasis),
  "warning-emphasis": var(--#{$prefix}warning-text-emphasis),
  "danger-emphasis": var(--#{$prefix}danger-text-emphasis),
  "light-emphasis": var(--#{$prefix}light-text-emphasis),
  "dark-emphasis": var(--#{$prefix}dark-text-emphasis)
);
```

Color mode adaptive text colors are also available as a Sass map:

[scss/\_maps.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_maps.scss)

```html
$theme-colors-text: (
  "primary": $primary-text-emphasis,
  "secondary": $secondary-text-emphasis,
  "success": $success-text-emphasis,
  "info": $info-text-emphasis,
  "warning": $warning-text-emphasis,
  "danger": $danger-text-emphasis,
  "light": $light-text-emphasis,
  "dark": $dark-text-emphasis,
);
```

[scss/\_maps.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_maps.scss)

```html
$theme-colors-text-dark: (
  "primary": $primary-text-emphasis-dark,
  "secondary": $secondary-text-emphasis-dark,
  "success": $success-text-emphasis-dark,
  "info": $info-text-emphasis-dark,
  "warning": $warning-text-emphasis-dark,
  "danger": $danger-text-emphasis-dark,
  "light": $light-text-emphasis-dark,
  "dark": $dark-text-emphasis-dark,
);
```

### Sass utilities API

Color utilities are declared in our utilities API in `scss/_utilities.scss`. [Learn how to use the utilities API.](/docs/5.3/utilities/api#using-the-api)

[scss/\_utilities.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_utilities.scss)

```html
"color": (
  property: color,
  class: text,
  local-vars: (
    "text-opacity": 1
  ),
  values: map-merge(
    $utilities-text-colors,
    (
      "muted": var(--#{$prefix}secondary-color), // deprecated
      "black-50": rgba($black, .5), // deprecated
      "white-50": rgba($white, .5), // deprecated
      "body-secondary": var(--#{$prefix}secondary-color),
      "body-tertiary": var(--#{$prefix}tertiary-color),
      "body-emphasis": var(--#{$prefix}emphasis-color),
      "reset": inherit,
    )
  )
),
"text-opacity": (
  css-var: true,
  class: text-opacity,
  values: (
    25: .25,
    50: .5,
    75: .75,
    100: 1
  )
),
"text-color": (
  property: color,
  class: text,
  values: $utilities-text-emphasis-colors
),
```

