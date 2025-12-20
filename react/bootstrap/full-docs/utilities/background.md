> Źródło: [https://getbootstrap.com/docs/5.3/utilities/background](https://getbootstrap.com/docs/5.3/utilities/background)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/utilities/background.mdx "View and edit this file on GitHub")

# Background

Convey meaning through `background-color` and add decoration with gradients.

On this page
   
**On this page**

---

* [Background color](#background-color)
* [Background gradient](#background-gradient)
* [Opacity](#opacity)
  + [How it works](#how-it-works)
  + [Example](#example)
* [CSS](#css)
  + [Sass variables](#sass-variables)
  + [Sass maps](#sass-maps)
  + [Sass mixins](#sass-mixins)
  + [Sass utilities API](#sass-utilities-api)

**Accessibility tip:** Using color to add meaning only provides a visual indication, which will not be conveyed to users of assistive technologies like screen readers. Please ensure the meaning is obvious from the content itself (e.g., the visible text with a [*sufficient* color contrast](/docs/5.3/getting-started/accessibility/#color-contrast)) or is included through alternative means, such as additional text hidden with the `.visually-hidden` class.

## Background color

Similar to the contextual text color classes, set the background of an element to any contextual class. Background utilities **do not set `color`**, so in some cases you’ll want to use `.text-*` [color utilities](/docs/5.3/utilities/colors).

Background utilities like `.bg-*` that generated from our original `$theme-colors` Sass map don’t yet respond to color modes, however, any `.bg-*-subtle` utility will. This will be resolved in v6.

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
     &lt;div class=&quot;p-3 mb-2 bg-primary text-white&quot;&gt;.bg-primary&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-primary-subtle text-primary-emphasis&quot;&gt;.bg-primary-subtle&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-secondary text-white&quot;&gt;.bg-secondary&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-secondary-subtle text-secondary-emphasis&quot;&gt;.bg-secondary-subtle&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-success text-white&quot;&gt;.bg-success&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-success-subtle text-success-emphasis&quot;&gt;.bg-success-subtle&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-danger text-white&quot;&gt;.bg-danger&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-danger-subtle text-danger-emphasis&quot;&gt;.bg-danger-subtle&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-warning text-dark&quot;&gt;.bg-warning&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-warning-subtle text-warning-emphasis&quot;&gt;.bg-warning-subtle&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-info text-dark&quot;&gt;.bg-info&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-info-subtle text-info-emphasis&quot;&gt;.bg-info-subtle&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-light text-dark&quot;&gt;.bg-light&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-light-subtle text-light-emphasis&quot;&gt;.bg-light-subtle&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-dark text-white&quot;&gt;.bg-dark&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-dark-subtle text-dark-emphasis&quot;&gt;.bg-dark-subtle&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-body-secondary&quot;&gt;.bg-body-secondary&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-body-tertiary&quot;&gt;.bg-body-tertiary&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-body text-body&quot;&gt;.bg-body&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-black text-white&quot;&gt;.bg-black&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-white text-dark&quot;&gt;.bg-white&lt;/div&gt;
&lt;div class=&quot;p-3 mb-2 bg-transparent text-body&quot;&gt;.bg-transparent&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="p-3 mb-2 bg-primary text-white">.bg-primary</div>
<div class="p-3 mb-2 bg-primary-subtle text-primary-emphasis">.bg-primary-subtle</div>
<div class="p-3 mb-2 bg-secondary text-white">.bg-secondary</div>
<div class="p-3 mb-2 bg-secondary-subtle text-secondary-emphasis">.bg-secondary-subtle</div>
<div class="p-3 mb-2 bg-success text-white">.bg-success</div>
<div class="p-3 mb-2 bg-success-subtle text-success-emphasis">.bg-success-subtle</div>
<div class="p-3 mb-2 bg-danger text-white">.bg-danger</div>
<div class="p-3 mb-2 bg-danger-subtle text-danger-emphasis">.bg-danger-subtle</div>
<div class="p-3 mb-2 bg-warning text-dark">.bg-warning</div>
<div class="p-3 mb-2 bg-warning-subtle text-warning-emphasis">.bg-warning-subtle</div>
<div class="p-3 mb-2 bg-info text-dark">.bg-info</div>
<div class="p-3 mb-2 bg-info-subtle text-info-emphasis">.bg-info-subtle</div>
<div class="p-3 mb-2 bg-light text-dark">.bg-light</div>
<div class="p-3 mb-2 bg-light-subtle text-light-emphasis">.bg-light-subtle</div>
<div class="p-3 mb-2 bg-dark text-white">.bg-dark</div>
<div class="p-3 mb-2 bg-dark-subtle text-dark-emphasis">.bg-dark-subtle</div>
<div class="p-3 mb-2 bg-body-secondary">.bg-body-secondary</div>
<div class="p-3 mb-2 bg-body-tertiary">.bg-body-tertiary</div>
<div class="p-3 mb-2 bg-body text-body">.bg-body</div>
<div class="p-3 mb-2 bg-black text-white">.bg-black</div>
<div class="p-3 mb-2 bg-white text-dark">.bg-white</div>
<div class="p-3 mb-2 bg-transparent text-body">.bg-transparent</div>
```

## Background gradient

By adding a `.bg-gradient` class, a linear gradient is added as background image to the backgrounds. This gradient starts with a semi-transparent white which fades out to the bottom.

Do you need a gradient in your custom CSS? Just add `background-image: var(--bs-gradient);`.

.bg-primary.bg-gradient

.bg-secondary.bg-gradient

.bg-success.bg-gradient

.bg-danger.bg-gradient

.bg-warning.bg-gradient

.bg-info.bg-gradient

.bg-light.bg-gradient

.bg-dark.bg-gradient

.bg-black.bg-gradient

## Opacity

Added in v5.1.0

As of v5.1.0, `background-color` utilities are generated with Sass using CSS variables. This allows for real-time color changes without compilation and dynamic alpha transparency changes.

### How it works

Consider our default `.bg-success` utility.

```html
.bg-success {
  --bs-bg-opacity: 1;
  background-color: rgba(var(--bs-success-rgb), var(--bs-bg-opacity)) !important;
}
```

We use an RGB version of our `--bs-success` (with the value of `25, 135, 84`) CSS variable and attached a second CSS variable, `--bs-bg-opacity`, for the alpha transparency (with a default value `1` thanks to a local CSS variable). That means anytime you use `.bg-success` now, your computed `color` value is `rgba(25, 135, 84, 1)`. The local CSS variable inside each `.bg-*` class avoids inheritance issues so nested instances of the utilities don’t automatically have a modified alpha transparency.

### Example

To change that opacity, override `--bs-bg-opacity` via custom styles or inline styles.

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
     &lt;div class=&quot;bg-success p-2 text-white&quot;&gt;This is default success background&lt;/div&gt;
&lt;div class=&quot;bg-success p-2&quot; style=&quot;--bs-bg-opacity: .5;&quot;&gt;This is 50% opacity success background&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="bg-success p-2 text-white">This is default success background</div>
<div class="bg-success p-2" style="--bs-bg-opacity: .5;">This is 50% opacity success background</div>
```

Or, choose from any of the `.bg-opacity` utilities:

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
     &lt;div class=&quot;bg-success p-2 text-white&quot;&gt;This is default success background&lt;/div&gt;
&lt;div class=&quot;bg-success p-2 text-white bg-opacity-75&quot;&gt;This is 75% opacity success background&lt;/div&gt;
&lt;div class=&quot;bg-success p-2 text-dark bg-opacity-50&quot;&gt;This is 50% opacity success background&lt;/div&gt;
&lt;div class=&quot;bg-success p-2 text-dark bg-opacity-25&quot;&gt;This is 25% opacity success background&lt;/div&gt;
&lt;div class=&quot;bg-success p-2 text-dark bg-opacity-10&quot;&gt;This is 10% opacity success background&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="bg-success p-2 text-white">This is default success background</div>
<div class="bg-success p-2 text-white bg-opacity-75">This is 75% opacity success background</div>
<div class="bg-success p-2 text-dark bg-opacity-50">This is 50% opacity success background</div>
<div class="bg-success p-2 text-dark bg-opacity-25">This is 25% opacity success background</div>
<div class="bg-success p-2 text-dark bg-opacity-10">This is 10% opacity success background</div>
```

## CSS

In addition to the following Sass functionality, consider reading about our included [CSS custom properties](/docs/5.3/customize/css-variables) (aka CSS variables) for colors and more.

### Sass variables

Most `background-color` utilities are generated by our theme colors, reassigned from our generic color palette variables.

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

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$gradient: linear-gradient(180deg, rgba($white, .15), rgba($white, 0));
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

Variables for setting `background-color` in `.bg-*-subtle` utilities in light and dark mode:

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$primary-bg-subtle:       tint-color($primary, 80%);
$secondary-bg-subtle:     tint-color($secondary, 80%);
$success-bg-subtle:       tint-color($success, 80%);
$info-bg-subtle:          tint-color($info, 80%);
$warning-bg-subtle:       tint-color($warning, 80%);
$danger-bg-subtle:        tint-color($danger, 80%);
$light-bg-subtle:         mix($gray-100, $white);
$dark-bg-subtle:          $gray-400;
```

[scss/\_variables-dark.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables-dark.scss)

```html
$primary-bg-subtle-dark:            shade-color($primary, 80%);
$secondary-bg-subtle-dark:          shade-color($secondary, 80%);
$success-bg-subtle-dark:            shade-color($success, 80%);
$info-bg-subtle-dark:               shade-color($info, 80%);
$warning-bg-subtle-dark:            shade-color($warning, 80%);
$danger-bg-subtle-dark:             shade-color($danger, 80%);
$light-bg-subtle-dark:              $gray-800;
$dark-bg-subtle-dark:               mix($gray-800, $black);
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

Background color opacities build on that with their own map that’s consumed by the utilities API:

[scss/\_maps.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_maps.scss)

```html
$utilities-bg: map-merge(
  $utilities-colors,
  (
    "black": to-rgb($black),
    "white": to-rgb($white),
    "body": to-rgb($body-bg)
  )
);
$utilities-bg-colors: map-loop($utilities-bg, rgba-css-var, "$key", "bg");

$utilities-bg-subtle: (
  "primary-subtle": var(--#{$prefix}primary-bg-subtle),
  "secondary-subtle": var(--#{$prefix}secondary-bg-subtle),
  "success-subtle": var(--#{$prefix}success-bg-subtle),
  "info-subtle": var(--#{$prefix}info-bg-subtle),
  "warning-subtle": var(--#{$prefix}warning-bg-subtle),
  "danger-subtle": var(--#{$prefix}danger-bg-subtle),
  "light-subtle": var(--#{$prefix}light-bg-subtle),
  "dark-subtle": var(--#{$prefix}dark-bg-subtle)
);
```

Color mode background colors are also available as a Sass map:

[scss/\_maps.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_maps.scss)

```html
$theme-colors-bg-subtle: (
  "primary": $primary-bg-subtle,
  "secondary": $secondary-bg-subtle,
  "success": $success-bg-subtle,
  "info": $info-bg-subtle,
  "warning": $warning-bg-subtle,
  "danger": $danger-bg-subtle,
  "light": $light-bg-subtle,
  "dark": $dark-bg-subtle,
);
```

[scss/\_maps.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_maps.scss)

```html
$theme-colors-bg-subtle-dark: (
  "primary": $primary-bg-subtle-dark,
  "secondary": $secondary-bg-subtle-dark,
  "success": $success-bg-subtle-dark,
  "info": $info-bg-subtle-dark,
  "warning": $warning-bg-subtle-dark,
  "danger": $danger-bg-subtle-dark,
  "light": $light-bg-subtle-dark,
  "dark": $dark-bg-subtle-dark,
);
```

### Sass mixins

**No mixins are used to generate our background utilities**, but we do have some additional mixins for other situations where you’d like to create your own gradients.

[scss/mixins/\_gradients.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/mixins/_gradients.scss)

```html
@mixin gradient-bg($color: null) {
  background-color: $color;

  @if $enable-gradients {
    background-image: var(--#{$prefix}gradient);
  }
}
```

[scss/mixins/\_gradients.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/mixins/_gradients.scss)

```html
// Horizontal gradient, from left to right
//
// Creates two color stops, start and end, by specifying a color and position for each color stop.
@mixin gradient-x($start-color: $gray-700, $end-color: $gray-800, $start-percent: 0%, $end-percent: 100%) {
  background-image: linear-gradient(to right, $start-color $start-percent, $end-color $end-percent);
}

// Vertical gradient, from top to bottom
//
// Creates two color stops, start and end, by specifying a color and position for each color stop.
@mixin gradient-y($start-color: $gray-700, $end-color: $gray-800, $start-percent: null, $end-percent: null) {
  background-image: linear-gradient(to bottom, $start-color $start-percent, $end-color $end-percent);
}

@mixin gradient-directional($start-color: $gray-700, $end-color: $gray-800, $deg: 45deg) {
  background-image: linear-gradient($deg, $start-color, $end-color);
}

@mixin gradient-x-three-colors($start-color: $blue, $mid-color: $purple, $color-stop: 50%, $end-color: $red) {
  background-image: linear-gradient(to right, $start-color, $mid-color $color-stop, $end-color);
}

@mixin gradient-y-three-colors($start-color: $blue, $mid-color: $purple, $color-stop: 50%, $end-color: $red) {
  background-image: linear-gradient($start-color, $mid-color $color-stop, $end-color);
}

@mixin gradient-radial($inner-color: $gray-700, $outer-color: $gray-800) {
  background-image: radial-gradient(circle, $inner-color, $outer-color);
}

@mixin gradient-striped($color: rgba($white, .15), $angle: 45deg) {
  background-image: linear-gradient($angle, $color 25%, transparent 25%, transparent 50%, $color 50%, $color 75%, transparent 75%, transparent);
}
```

### Sass utilities API

Background utilities are declared in our utilities API in `scss/_utilities.scss`. [Learn how to use the utilities API.](/docs/5.3/utilities/api#using-the-api)

[scss/\_utilities.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_utilities.scss)

```html
"background-color": (
  property: background-color,
  class: bg,
  local-vars: (
    "bg-opacity": 1
  ),
  values: map-merge(
    $utilities-bg-colors,
    (
      "transparent": transparent,
      "body-secondary": rgba(var(--#{$prefix}secondary-bg-rgb), var(--#{$prefix}bg-opacity)),
      "body-tertiary": rgba(var(--#{$prefix}tertiary-bg-rgb), var(--#{$prefix}bg-opacity)),
    )
  )
),
"bg-opacity": (
  css-var: true,
  class: bg-opacity,
  values: (
    10: .1,
    25: .25,
    50: .5,
    75: .75,
    100: 1
  )
),
"subtle-background-color": (
  property: background-color,
  class: bg,
  values: $utilities-bg-subtle
),
```

