> Źródło: [https://getbootstrap.com/docs/5.3/customize/color](https://getbootstrap.com/docs/5.3/customize/color)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/customize/color.mdx "View and edit this file on GitHub")

# Color

Bootstrap is supported by an extensive color system that themes our styles and components. This enables more comprehensive customization and extension for any project.

On this page
   
**On this page**

---

* [Colors](#colors)
  + [Using the new colors](#using-the-new-colors)
  + [Theme colors](#theme-colors)
  + [All colors](#all-colors)
  + [Notes on Sass](#notes-on-sass)
* [Color Sass maps](#color-sass-maps)
  + [Example](#example)
* [Generating utilities](#generating-utilities)

## Colors

Added in v5.3.0

Bootstrap’s color palette has continued to expand and become more nuanced in v5.3.0. We’ve added new variables for `secondary` and `tertiary` text and background colors, plus `{color}-bg-subtle`, `{color}-border-subtle`, and `{color}-text-emphasis` for our theme colors. These new colors are available through Sass and CSS variables (but not our color maps or utility classes) with the express goal of making it easier to customize across multiple colors modes like light and dark. These new variables are globally set on `:root` and are adapted for our new dark color mode while our original theme colors remain unchanged.

Colors ending in `-rgb` provide the `red, green, blue` values for use in `rgb()` and `rgba()` color modes. For example, `rgba(var(--bs-secondary-bg-rgb), .5)`.

**Heads up!** There’s some potential confusion with our new secondary and tertiary colors, and our existing secondary theme color, as well as our light and dark theme colors. Expect this to be ironed out in v6.

| Description | Swatch | Variables |
| --- | --- | --- |
| **Body —** Default foreground (color) and background, including components. |  | `--bs-body-color` `--bs-body-color-rgb` |
|  | `--bs-body-bg` `--bs-body-bg-rgb` |
| **Secondary —** Use the `color` option for lighter text. Use the `bg` option for dividers and to indicate disabled component states. |  | `--bs-secondary-color` `--bs-secondary-color-rgb` |
|  | `--bs-secondary-bg` `--bs-secondary-bg-rgb` |
| **Tertiary —** Use the `color` option for even lighter text. Use the `bg` option to style backgrounds for hover states, accents, and wells. |  | `--bs-tertiary-color` `--bs-tertiary-color-rgb` |
|  | `--bs-tertiary-bg` `--bs-tertiary-bg-rgb` |
| **Emphasis —** For higher contrast text. Not applicable for backgrounds. |  | `--bs-emphasis-color` `--bs-emphasis-color-rgb` |
| **Border —** For component borders, dividers, and rules. Use `--bs-border-color-translucent` to blend with backgrounds with an `rgba()` value. |  | `--bs-border-color` `--bs-border-color-rgb` |
| **Primary —** Main theme color, used for hyperlinks, focus styles, and component and form active states. |  | `--bs-primary` `--bs-primary-rgb` |
|  | `--bs-primary-bg-subtle` |
|  | `--bs-primary-border-subtle` |
| Text | `--bs-primary-text-emphasis` |
| **Success —** Theme color used for positive or successful actions and information. |  | `--bs-success` `--bs-success-rgb` |
|  | `--bs-success-bg-subtle` |
|  | `--bs-success-border-subtle` |
| Text | `--bs-success-text-emphasis` |
| **Danger —** Theme color used for errors and dangerous actions. |  | `--bs-danger` `--bs-danger-rgb` |
|  | `--bs-danger-bg-subtle` |
|  | `--bs-danger-border-subtle` |
| Text | `--bs-danger-text-emphasis` |
| **Warning —** Theme color used for non-destructive warning messages. |  | `--bs-warning` `--bs-warning-rgb` |
|  | `--bs-warning-bg-subtle` |
|  | `--bs-warning-border-subtle` |
| Text | `--bs-warning-text-emphasis` |
| **Info —** Theme color used for neutral and informative content. |  | `--bs-info` `--bs-info-rgb` |
|  | `--bs-info-bg-subtle` |
|  | `--bs-info-border-subtle` |
| Text | `--bs-info-text-emphasis` |
| **Light —** Additional theme option for less contrasting colors. |  | `--bs-light` `--bs-light-rgb` |
|  | `--bs-light-bg-subtle` |
|  | `--bs-light-border-subtle` |
| Text | `--bs-light-text-emphasis` |
| **Dark —** Additional theme option for higher contrasting colors. |  | `--bs-dark` `--bs-dark-rgb` |
|  | `--bs-dark-bg-subtle` |
|  | `--bs-dark-border-subtle` |
| Text | `--bs-dark-text-emphasis` |

### Using the new colors

These new colors are accessible via CSS variables and utility classes—like `--bs-primary-bg-subtle` and `.bg-primary-subtle`—allowing you to compose your own CSS rules with the variables, or to quickly apply styles via classes. The utilities are built with the color’s associated CSS variables, and since we customize those CSS variables for dark mode, they are also adaptive to color mode by default.

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
     &lt;div class=&quot;p-3 text-primary-emphasis bg-primary-subtle border border-primary-subtle rounded-3&quot;&gt;
  Example element with utilities
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="p-3 text-primary-emphasis bg-primary-subtle border border-primary-subtle rounded-3">
  Example element with utilities
</div>
```

### Theme colors

We use a subset of all colors to create a smaller color palette for generating color schemes, also available as Sass variables and a Sass map in Bootstrap’s `scss/_variables.scss` file.

Primary

Secondary

Success

Danger

Warning

Info

Light

Dark

All these colors are available as a Sass map, `$theme-colors`.

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

Check out [our Sass maps and loops docs](/docs/5.3/customize/sass#maps-and-loops) for how to modify these colors.

### All colors

All Bootstrap colors are available as Sass variables and a Sass map in `scss/_variables.scss` file. To avoid increased file sizes, we don’t create text or background color classes for each of these variables. Instead, we choose a subset of these colors for a [theme palette](#theme-colors).

Be sure to monitor contrast ratios as you customize colors. As shown below, we’ve added three contrast ratios to each of the main colors—one for the swatch’s current colors, one for against white, and one for against black.

**$blue**#0d6efd

$blue-100

$blue-200

$blue-300

$blue-400

$blue-500

$blue-600

$blue-700

$blue-800

$blue-900

**$indigo**#6610f2

$indigo-100

$indigo-200

$indigo-300

$indigo-400

$indigo-500

$indigo-600

$indigo-700

$indigo-800

$indigo-900

**$purple**#6f42c1

$purple-100

$purple-200

$purple-300

$purple-400

$purple-500

$purple-600

$purple-700

$purple-800

$purple-900

**$pink**#d63384

$pink-100

$pink-200

$pink-300

$pink-400

$pink-500

$pink-600

$pink-700

$pink-800

$pink-900

**$red**#dc3545

$red-100

$red-200

$red-300

$red-400

$red-500

$red-600

$red-700

$red-800

$red-900

**$orange**#fd7e14

$orange-100

$orange-200

$orange-300

$orange-400

$orange-500

$orange-600

$orange-700

$orange-800

$orange-900

**$yellow**#ffc107

$yellow-100

$yellow-200

$yellow-300

$yellow-400

$yellow-500

$yellow-600

$yellow-700

$yellow-800

$yellow-900

**$green**#198754

$green-100

$green-200

$green-300

$green-400

$green-500

$green-600

$green-700

$green-800

$green-900

**$teal**#20c997

$teal-100

$teal-200

$teal-300

$teal-400

$teal-500

$teal-600

$teal-700

$teal-800

$teal-900

**$cyan**#0dcaf0

$cyan-100

$cyan-200

$cyan-300

$cyan-400

$cyan-500

$cyan-600

$cyan-700

$cyan-800

$cyan-900

**$gray-500**#adb5bd

$gray-100

$gray-200

$gray-300

$gray-400

$gray-500

$gray-600

$gray-700

$gray-800

$gray-900

**$black**
#000

**$white**
#fff

### Notes on Sass

Sass cannot programmatically generate variables, so we manually created variables for every tint and shade ourselves. We specify the midpoint value (e.g., `$blue-500`) and use custom color functions to tint (lighten) or shade (darken) our colors via Sass’s `mix()` color function.

Using `mix()` is not the same as `lighten()` and `darken()`—the former blends the specified color with white or black, while the latter only adjusts the lightness value of each color. The result is a much more complete suite of colors, as [shown in this CodePen demo](https://codepen.io/emdeoh/pen/zYOQOPB).

Our `tint-color()` and `shade-color()` functions use `mix()` alongside our `$theme-color-interval` variable, which specifies a stepped percentage value for each mixed color we produce. See the `scss/_functions.scss` and `scss/_variables.scss` files for the full source code.

## Color Sass maps

Bootstrap’s source Sass files include three maps to help you quickly and easily loop over a list of colors and their hex values.

* `$colors` lists all our available base (`500`) colors
* `$theme-colors` lists all semantically named theme colors (shown below)
* `$grays` lists all tints and shades of gray

Within `scss/_variables.scss`, you’ll find Bootstrap’s color variables and Sass map. Here’s an example of the `$colors` Sass map:

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$colors: (
  "blue":       $blue,
  "indigo":     $indigo,
  "purple":     $purple,
  "pink":       $pink,
  "red":        $red,
  "orange":     $orange,
  "yellow":     $yellow,
  "green":      $green,
  "teal":       $teal,
  "cyan":       $cyan,
  "black":      $black,
  "white":      $white,
  "gray":       $gray-600,
  "gray-dark":  $gray-800
);
```

Add, remove, or modify values within the map to update how they’re used in many other components. Unfortunately at this time, not *every* component utilizes this Sass map. Future updates will strive to improve upon this. Until then, plan on making use of the `${color}` variables and this Sass map.

### Example

Here’s how you can use these in your Sass:

```html
.alpha { color: $purple; }
.beta {
  color: $yellow-300;
  background-color: $indigo-900;
}
```

[Color](/docs/5.3/utilities/colors) and [background](/docs/5.3/utilities/background) utility classes are also available for setting `color` and `background-color` using the `500` color values.

## Generating utilities

Added in v5.1.0

Bootstrap doesn’t include `color` and `background-color` utilities for every color variable, but you can generate these yourself with our [utility API](/docs/5.3/utilities/api) and our extended Sass maps added in v5.1.0.

1. To start, make sure you’ve imported our functions, variables, mixins, and utilities.
2. Use our `map-merge-multiple()` function to quickly merge multiple Sass maps together in a new map.
3. Merge this new combined map to extend any utility with a `{color}-{level}` class name.

Here’s an example that generates text color utilities (e.g., `.text-purple-500`) using the above steps.

```html
@import "bootstrap/scss/functions";
@import "bootstrap/scss/variables";
@import "bootstrap/scss/variables-dark";
@import "bootstrap/scss/maps";
@import "bootstrap/scss/mixins";
@import "bootstrap/scss/utilities";

$all-colors: map-merge-multiple($blues, $indigos, $purples, $pinks, $reds, $oranges, $yellows, $greens, $teals, $cyans);

$utilities: map-merge(
  $utilities,
  (
    "color": map-merge(
      map-get($utilities, "color"),
      (
        values: map-merge(
          map-get(map-get($utilities, "color"), "values"),
          (
            $all-colors
          ),
        ),
      ),
    ),
  )
);

@import "bootstrap/scss/utilities/api";
```

This will generate new `.text-{color}-{level}` utilities for every color and level. You can do the same for any other utility and property as well.

