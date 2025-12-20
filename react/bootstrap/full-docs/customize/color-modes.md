> Źródło: [https://getbootstrap.com/docs/5.3/customize/color-modes](https://getbootstrap.com/docs/5.3/customize/color-modes)



Added in v5.3  [View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/customize/color-modes.mdx "View and edit this file on GitHub")

# Color modes

Bootstrap now supports color modes, or themes, as of v5.3.0. Explore our default light color mode and the new dark mode, or create your own using our styles as your template.

On this page
   
**On this page**

---

* [Dark mode](#dark-mode)
* [Example](#example)
* [How it works](#how-it-works)
* [Usage](#usage)
  + [Enable dark mode](#enable-dark-mode)
  + [Building with Sass](#building-with-sass)
* [Custom color modes](#custom-color-modes)
* [JavaScript](#javascript)
* [Adding theme colors](#adding-theme-colors)
* [CSS](#css)
  + [Variables](#variables)
  + [Sass variables](#sass-variables)
  + [Sass mixins](#sass-mixins)

**Try it yourself!** Download the source code and working demo for using Bootstrap with Stylelint, and the color modes from the [twbs/examples repository](https://github.com/twbs/examples/tree/main/color-modes). You can also [open the example in StackBlitz](https://stackblitz.com/github/twbs/examples/tree/main/color-modes?file=index.html).

## Dark mode

**Bootstrap now supports color modes, starting with dark mode!** With v5.3.0 you can implement your own color mode toggler (see below for an example from Bootstrap’s docs) and apply the different color modes as you see fit. We support a light mode (default) and now dark mode. Color modes can be toggled globally on the `<html>` element, or on specific components and elements, thanks to the `data-bs-theme` attribute.

Alternatively, you can also switch to a media query implementation thanks to our color mode mixin—see [the usage section for details](#building-with-sass). Heads up though—this eliminates your ability to change themes on a per-component basis as shown below.

## Example

For example, to change the color mode of a dropdown menu, add `data-bs-theme="light"` or `data-bs-theme="dark"` to the parent `.dropdown`. Now, no matter the global color mode, these dropdowns will display with the specified theme value.

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
     &lt;div class=&quot;dropdown&quot; data-bs-theme=&quot;light&quot;&gt;
&lt;button aria-expanded=&quot;false&quot; class=&quot;btn btn-secondary dropdown-toggle&quot; data-bs-toggle=&quot;dropdown&quot; id=&quot;dropdownMenuButtonLight&quot; type=&quot;button&quot;&gt;
    Default dropdown
  &lt;/button&gt;
&lt;ul aria-labelledby=&quot;dropdownMenuButtonLight&quot; class=&quot;dropdown-menu&quot;&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item active&quot; href=&quot;#&quot;&gt;Action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Another action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Something else here&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;hr class=&quot;dropdown-divider&quot;/&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Separated link&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/div&gt;
&lt;div class=&quot;dropdown&quot; data-bs-theme=&quot;dark&quot;&gt;
&lt;button aria-expanded=&quot;false&quot; class=&quot;btn btn-secondary dropdown-toggle&quot; data-bs-toggle=&quot;dropdown&quot; id=&quot;dropdownMenuButtonDark&quot; type=&quot;button&quot;&gt;
    Dark dropdown
  &lt;/button&gt;
&lt;ul aria-labelledby=&quot;dropdownMenuButtonDark&quot; class=&quot;dropdown-menu&quot;&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item active&quot; href=&quot;#&quot;&gt;Action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Another action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Something else here&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;hr class=&quot;dropdown-divider&quot;/&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Separated link&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="dropdown" data-bs-theme="light">
  <button class="btn btn-secondary dropdown-toggle" type="button" id="dropdownMenuButtonLight" data-bs-toggle="dropdown" aria-expanded="false">
    Default dropdown
  </button>
  <ul class="dropdown-menu" aria-labelledby="dropdownMenuButtonLight">
    <li><a class="dropdown-item active" href="#">Action</a></li>
    <li><a class="dropdown-item" href="#">Action</a></li>
    <li><a class="dropdown-item" href="#">Another action</a></li>
    <li><a class="dropdown-item" href="#">Something else here</a></li>
    <li><hr class="dropdown-divider"></li>
    <li><a class="dropdown-item" href="#">Separated link</a></li>
  </ul>
</div>

<div class="dropdown" data-bs-theme="dark">
  <button class="btn btn-secondary dropdown-toggle" type="button" id="dropdownMenuButtonDark" data-bs-toggle="dropdown" aria-expanded="false">
    Dark dropdown
  </button>
  <ul class="dropdown-menu" aria-labelledby="dropdownMenuButtonDark">
    <li><a class="dropdown-item active" href="#">Action</a></li>
    <li><a class="dropdown-item" href="#">Action</a></li>
    <li><a class="dropdown-item" href="#">Another action</a></li>
    <li><a class="dropdown-item" href="#">Something else here</a></li>
    <li><hr class="dropdown-divider"></li>
    <li><a class="dropdown-item" href="#">Separated link</a></li>
  </ul>
</div>
```

## How it works

* As shown above, color mode styles are controlled by the `data-bs-theme` attribute. This attribute can be applied to the `<html>` element, or to any other element or Bootstrap component. If applied to the `<html>` element, it will apply to everything. If applied to a component or element, it will be scoped to that specific component or element.
* For each color mode you wish to support, you’ll need to add new overrides for the shared global CSS variables. We do this already in our `_root.scss` stylesheet for dark mode, with light mode being the default values. In writing color mode specific styles, use the mixin:

  ```html
  // Color mode variables in _root.scss
  @include color-mode(dark) {
    // CSS variable overrides here...
  }
  ```
* We use a custom `_variables-dark.scss` to power those shared global CSS variable overrides for dark mode. This file isn’t required for your own custom color modes, but it’s required for our dark mode for two reasons. First, it’s better to have a single place to reset global colors. Second, some Sass variables had to be overridden for background images embedded in our CSS for accordions, form components, and more.

## Usage

### Enable dark mode

Enable the built in dark color mode across your entire project by adding the `data-bs-theme="dark"` attribute to the `<html>` element. This will apply the dark color mode to all components and elements, other than those with a specific `data-bs-theme` attribute applied. Building on the [quick start template](/docs/5.3/getting-started/introduction#quick-start):

```html
<!doctype html>
<html lang="en" data-bs-theme="dark">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Bootstrap demo</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
  </head>
  <body>
    <h1>Hello, world!</h1>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" integrity="sha384-FKyoEForCGlyvwx9Hj09JcYn3nv7wiPVlz7YYwJrWVcXK/BmnVDxM+D2scQbITxI" crossorigin="anonymous"></script>
  </body>
</html>
```

Bootstrap does not yet ship with a built-in color mode picker, but you can use the one from our own documentation if you like. [Learn more in the JavaScript section.](#javascript)

### Building with Sass

Our new dark mode option is available to use for all users of Bootstrap, but it’s controlled via data attributes instead of media queries and does not automatically toggle your project’s color mode. You can disable our dark mode entirely via Sass by changing `$enable-dark-mode` to `false`.

We use a custom Sass mixin, `color-mode()`, to help you control *how* color modes are applied. By default, we use a `data` attribute approach, allowing you to create more user-friendly experiences where your visitors can choose to have an automatic dark mode or control their preference (like in our own docs here). This is also an easy and scalable way to add different themes and more custom color modes beyond light and dark.

In case you want to use media queries and only make color modes automatic, you can change the mixin’s default type via Sass variable. Consider the following snippet and its compiled CSS output.

```html
$color-mode-type: data;

@include color-mode(dark) {
  .element {
    color: var(--bs-primary-text-emphasis);
    background-color: var(--bs-primary-bg-subtle);
  }
}
```

Outputs to:

```html
[data-bs-theme=dark] .element {
  color: var(--bs-primary-text-emphasis);
  background-color: var(--bs-primary-bg-subtle);
}
```

And when setting to `media-query`:

```html
$color-mode-type: media-query;

@include color-mode(dark) {
  .element {
    color: var(--bs-primary-text-emphasis);
    background-color: var(--bs-primary-bg-subtle);
  }
}
```

Outputs to:

```html
@media (prefers-color-scheme: dark) {
  .element {
    color: var(--bs-primary-text-emphasis);
    background-color: var(--bs-primary-bg-subtle);
  }
}
```

## Custom color modes

While the primary use case for color modes is light and dark mode, custom color modes are also possible. Create your own `data-bs-theme` selector with a custom value as the name of your color mode, then modify our Sass and CSS variables as needed. We opted to create a separate `_variables-dark.scss` stylesheet to house Bootstrap’s dark mode specific Sass variables, but that’s not required for you.

For example, you can create a “blue theme” with the selector `data-bs-theme="blue"`. In your custom Sass or CSS file, add the new selector and override any global or component CSS variables as needed. If you’re using Sass, you can also use Sass’s functions within your CSS variable overrides.

[site/src/scss/\_content.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/scss/_content.scss)

```html
[data-bs-theme="blue"] {
  --bs-body-color: var(--bs-white);
  --bs-body-color-rgb: #{to-rgb($white)};
  --bs-body-bg: var(--bs-blue);
  --bs-body-bg-rgb: #{to-rgb($blue)};
  --bs-tertiary-bg: #{$blue-600};

  .dropdown-menu {
    --bs-dropdown-bg: #{mix($blue-500, $blue-600)};
    --bs-dropdown-link-active-bg: #{$blue-700};
  }

  .btn-secondary {
    --bs-btn-bg: #{mix($gray-600, $blue-400, .5)};
    --bs-btn-border-color: #{rgba($white, .25)};
    --bs-btn-hover-bg: #{darken(mix($gray-600, $blue-400, .5), 5%)};
    --bs-btn-hover-border-color: #{rgba($white, .25)};
    --bs-btn-active-bg: #{darken(mix($gray-600, $blue-400, .5), 10%)};
    --bs-btn-active-border-color: #{rgba($white, .5)};
    --bs-btn-focus-border-color: #{rgba($white, .5)};
    --bs-btn-focus-box-shadow: 0 0 0 .25rem rgba(255, 255, 255, .2);
  }
}
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
     &lt;div class=&quot;bd-example text-body bg-body&quot; data-bs-theme=&quot;blue&quot;&gt;
&lt;div class=&quot;h4&quot;&gt;Example blue theme&lt;/div&gt;
&lt;p&gt;Some paragraph text to show how the blue theme might look with written copy.&lt;/p&gt;
&lt;hr class=&quot;my-4&quot;&gt;
&lt;div class=&quot;dropdown&quot;&gt;
&lt;button aria-expanded=&quot;false&quot; class=&quot;btn btn-secondary dropdown-toggle&quot; data-bs-toggle=&quot;dropdown&quot; id=&quot;dropdownMenuButtonCustom&quot; type=&quot;button&quot;&gt;
    Dropdown button
  &lt;/button&gt;
&lt;ul aria-labelledby=&quot;dropdownMenuButtonCustom&quot; class=&quot;dropdown-menu&quot;&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item active&quot; href=&quot;#&quot;&gt;Action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Another action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Something else here&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;hr class=&quot;dropdown-divider&quot;/&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Separated link&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/div&gt;
&lt;/hr&gt;&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div data-bs-theme="blue">
  ...
</div>
```

## JavaScript

To allow visitors or users to toggle color modes, you’ll need to create a toggle element to control the `data-bs-theme` attribute on the root element, `<html>`. We’ve built a toggler in our documentation that initially defers to a user’s current system color mode, but provides an option to override that and pick a specific color mode.

Here’s a look at the JavaScript that powers it. Feel free to inspect our own documentation navbar to see how it’s implemented using HTML and CSS from our own components. It is suggested to include the JavaScript at the top of your page to reduce potential screen flickering during reloading of your site. Note that if you decide to use media queries for your color modes, your JavaScript may need to be modified or removed if you prefer an implicit control.

```html
/*!
 * Color mode toggler for Bootstrap's docs (https://getbootstrap.com/)
 * Copyright 2011-2025 The Bootstrap Authors
 * Licensed under the Creative Commons Attribution 3.0 Unported License.
 */

(() => {
  'use strict'

  const getStoredTheme = () => localStorage.getItem('theme')
  const setStoredTheme = theme => localStorage.setItem('theme', theme)

  const getPreferredTheme = () => {
    const storedTheme = getStoredTheme()
    if (storedTheme) {
      return storedTheme
    }

    return window.matchMedia('(prefers-color-scheme: dark)').matches ? 'dark' : 'light'
  }

  const setTheme = theme => {
    if (theme === 'auto') {
      document.documentElement.setAttribute('data-bs-theme', (window.matchMedia('(prefers-color-scheme: dark)').matches ? 'dark' : 'light'))
    } else {
      document.documentElement.setAttribute('data-bs-theme', theme)
    }
  }

  setTheme(getPreferredTheme())

  const showActiveTheme = (theme, focus = false) => {
    const themeSwitcher = document.querySelector('#bd-theme')

    if (!themeSwitcher) {
      return
    }

    const themeSwitcherText = document.querySelector('#bd-theme-text')
    const activeThemeIcon = document.querySelector('.theme-icon-active use')
    const btnToActive = document.querySelector(`[data-bs-theme-value="${theme}"]`)
    const svgOfActiveBtn = btnToActive.querySelector('svg use').getAttribute('href')

    document.querySelectorAll('[data-bs-theme-value]').forEach(element => {
      element.classList.remove('active')
      element.setAttribute('aria-pressed', 'false')
    })

    btnToActive.classList.add('active')
    btnToActive.setAttribute('aria-pressed', 'true')
    activeThemeIcon.setAttribute('href', svgOfActiveBtn)
    const themeSwitcherLabel = `${themeSwitcherText.textContent} (${btnToActive.dataset.bsThemeValue})`
    themeSwitcher.setAttribute('aria-label', themeSwitcherLabel)

    if (focus) {
      themeSwitcher.focus()
    }
  }

  window.matchMedia('(prefers-color-scheme: dark)').addEventListener('change', () => {
    const storedTheme = getStoredTheme()
    if (storedTheme !== 'light' && storedTheme !== 'dark') {
      setTheme(getPreferredTheme())
    }
  })

  window.addEventListener('DOMContentLoaded', () => {
    showActiveTheme(getPreferredTheme())

    document.querySelectorAll('[data-bs-theme-value]')
      .forEach(toggle => {
        toggle.addEventListener('click', () => {
          const theme = toggle.getAttribute('data-bs-theme-value')
          setStoredTheme(theme)
          setTheme(theme)
          showActiveTheme(theme, true)
        })
      })
  })
})()
```

## Adding theme colors

Adding a new color in `$theme-colors` is not enough for some of our components like [alerts](/docs/5.3/components/alerts) and [list groups](/docs/5.3/components/list-group). New colors must also be defined in `$theme-colors-text`, `$theme-colors-bg-subtle`, and `$theme-colors-border-subtle` for light theme; but also in `$theme-colors-text-dark`, `$theme-colors-bg-subtle-dark`, and `$theme-colors-border-subtle-dark` for dark theme.

This is a manual process because Sass cannot generate its own Sass variables from an existing variable or map. In future versions of Bootstrap, we'll revisit this setup to reduce the duplication.

```html
// Required
@import "functions";
@import "variables";
@import "variables-dark";

// Add a custom color to $theme-colors
$custom-colors: (
  "custom-color": #712cf9
);
$theme-colors: map-merge($theme-colors, $custom-colors);

@import "maps";
@import "mixins";
@import "utilities";

// Add a custom color to new theme maps

// Light mode
$custom-colors-text: ("custom-color": #712cf9);
$custom-colors-bg-subtle: ("custom-color": #e1d2fe);
$custom-colors-border-subtle: ("custom-color": #bfa1fc);

$theme-colors-text: map-merge($theme-colors-text, $custom-colors-text);
$theme-colors-bg-subtle: map-merge($theme-colors-bg-subtle, $custom-colors-bg-subtle);
$theme-colors-border-subtle: map-merge($theme-colors-border-subtle, $custom-colors-border-subtle);

// Dark mode
$custom-colors-text-dark: ("custom-color": #e1d2f2);
$custom-colors-bg-subtle-dark: ("custom-color": #8951fa);
$custom-colors-border-subtle-dark: ("custom-color": #e1d2f2);

$theme-colors-text-dark: map-merge($theme-colors-text-dark, $custom-colors-text-dark);
$theme-colors-bg-subtle-dark: map-merge($theme-colors-bg-subtle-dark, $custom-colors-bg-subtle-dark);
$theme-colors-border-subtle-dark: map-merge($theme-colors-border-subtle-dark, $custom-colors-border-subtle-dark);

// Remainder of Bootstrap imports
@import "root";
@import "reboot";
// etc
```

## CSS

### Variables

Dozens of root level CSS variables are repeated as overrides for dark mode. These are scoped to the color mode selector, which defaults to `data-bs-theme` but [can be configured](#building-with-sass) to use a `prefers-color-scheme` media query. Use these variables as a guideline for generating your own new color modes.

[scss/\_root.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_root.scss)

```html
--#{$prefix}body-color: #{$body-color-dark};
--#{$prefix}body-color-rgb: #{to-rgb($body-color-dark)};
--#{$prefix}body-bg: #{$body-bg-dark};
--#{$prefix}body-bg-rgb: #{to-rgb($body-bg-dark)};

--#{$prefix}emphasis-color: #{$body-emphasis-color-dark};
--#{$prefix}emphasis-color-rgb: #{to-rgb($body-emphasis-color-dark)};

--#{$prefix}secondary-color: #{$body-secondary-color-dark};
--#{$prefix}secondary-color-rgb: #{to-rgb($body-secondary-color-dark)};
--#{$prefix}secondary-bg: #{$body-secondary-bg-dark};
--#{$prefix}secondary-bg-rgb: #{to-rgb($body-secondary-bg-dark)};

--#{$prefix}tertiary-color: #{$body-tertiary-color-dark};
--#{$prefix}tertiary-color-rgb: #{to-rgb($body-tertiary-color-dark)};
--#{$prefix}tertiary-bg: #{$body-tertiary-bg-dark};
--#{$prefix}tertiary-bg-rgb: #{to-rgb($body-tertiary-bg-dark)};

@each $color, $value in $theme-colors-text-dark {
  --#{$prefix}#{$color}-text-emphasis: #{$value};
}

@each $color, $value in $theme-colors-bg-subtle-dark {
  --#{$prefix}#{$color}-bg-subtle: #{$value};
}

@each $color, $value in $theme-colors-border-subtle-dark {
  --#{$prefix}#{$color}-border-subtle: #{$value};
}

--#{$prefix}heading-color: #{$headings-color-dark};

--#{$prefix}link-color: #{$link-color-dark};
--#{$prefix}link-hover-color: #{$link-hover-color-dark};
--#{$prefix}link-color-rgb: #{to-rgb($link-color-dark)};
--#{$prefix}link-hover-color-rgb: #{to-rgb($link-hover-color-dark)};

--#{$prefix}code-color: #{$code-color-dark};
--#{$prefix}highlight-color: #{$mark-color-dark};
--#{$prefix}highlight-bg: #{$mark-bg-dark};

--#{$prefix}border-color: #{$border-color-dark};
--#{$prefix}border-color-translucent: #{$border-color-translucent-dark};

--#{$prefix}form-valid-color: #{$form-valid-color-dark};
--#{$prefix}form-valid-border-color: #{$form-valid-border-color-dark};
--#{$prefix}form-invalid-color: #{$form-invalid-color-dark};
--#{$prefix}form-invalid-border-color: #{$form-invalid-border-color-dark};
```

### Sass variables

CSS variables for our dark color mode are partially generated from dark mode specific Sass variables in `_variables-dark.scss`. This also includes some custom overrides for changing the colors of embedded SVGs used throughout our components.

[scss/\_variables-dark.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables-dark.scss)

```html
// scss-docs-start theme-text-dark-variables
$primary-text-emphasis-dark:        tint-color($primary, 40%);
$secondary-text-emphasis-dark:      tint-color($secondary, 40%);
$success-text-emphasis-dark:        tint-color($success, 40%);
$info-text-emphasis-dark:           tint-color($info, 40%);
$warning-text-emphasis-dark:        tint-color($warning, 40%);
$danger-text-emphasis-dark:         tint-color($danger, 40%);
$light-text-emphasis-dark:          $gray-100;
$dark-text-emphasis-dark:           $gray-300;
// scss-docs-end theme-text-dark-variables

// scss-docs-start theme-bg-subtle-dark-variables
$primary-bg-subtle-dark:            shade-color($primary, 80%);
$secondary-bg-subtle-dark:          shade-color($secondary, 80%);
$success-bg-subtle-dark:            shade-color($success, 80%);
$info-bg-subtle-dark:               shade-color($info, 80%);
$warning-bg-subtle-dark:            shade-color($warning, 80%);
$danger-bg-subtle-dark:             shade-color($danger, 80%);
$light-bg-subtle-dark:              $gray-800;
$dark-bg-subtle-dark:               mix($gray-800, $black);
// scss-docs-end theme-bg-subtle-dark-variables

// scss-docs-start theme-border-subtle-dark-variables
$primary-border-subtle-dark:        shade-color($primary, 40%);
$secondary-border-subtle-dark:      shade-color($secondary, 40%);
$success-border-subtle-dark:        shade-color($success, 40%);
$info-border-subtle-dark:           shade-color($info, 40%);
$warning-border-subtle-dark:        shade-color($warning, 40%);
$danger-border-subtle-dark:         shade-color($danger, 40%);
$light-border-subtle-dark:          $gray-700;
$dark-border-subtle-dark:           $gray-800;
// scss-docs-end theme-border-subtle-dark-variables

$body-color-dark:                   $gray-300;
$body-bg-dark:                      $gray-900;
$body-secondary-color-dark:         rgba($body-color-dark, .75);
$body-secondary-bg-dark:            $gray-800;
$body-tertiary-color-dark:          rgba($body-color-dark, .5);
$body-tertiary-bg-dark:             mix($gray-800, $gray-900, 50%);
$body-emphasis-color-dark:          $white;
$border-color-dark:                 $gray-700;
$border-color-translucent-dark:     rgba($white, .15);
$headings-color-dark:               inherit;
$link-color-dark:                   tint-color($primary, 40%);
$link-hover-color-dark:             shift-color($link-color-dark, -$link-shade-percentage);
$code-color-dark:                   tint-color($code-color, 40%);
$mark-color-dark:                   $body-color-dark;
$mark-bg-dark:                      $yellow-800;

//
// Forms
//

$form-select-indicator-color-dark:  $body-color-dark;
$form-select-indicator-dark:        url("data:image/svg+xml,<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 16 16'><path fill='none' stroke='#{$form-select-indicator-color-dark}' stroke-linecap='round' stroke-linejoin='round' stroke-width='2' d='m2 5 6 6 6-6'/></svg>");

$form-switch-color-dark:            rgba($white, .25);
$form-switch-bg-image-dark:         url("data:image/svg+xml,<svg xmlns='http://www.w3.org/2000/svg' viewBox='-4 -4 8 8'><circle r='3' fill='#{$form-switch-color-dark}'/></svg>");

// scss-docs-start form-validation-colors-dark
$form-valid-color-dark:             $green-300;
$form-valid-border-color-dark:      $green-300;
$form-invalid-color-dark:           $red-300;
$form-invalid-border-color-dark:    $red-300;
// scss-docs-end form-validation-colors-dark

//
// Accordion
//

$accordion-icon-color-dark:         $primary-text-emphasis-dark;
$accordion-icon-active-color-dark:  $primary-text-emphasis-dark;

$accordion-button-icon-dark:         url("data:image/svg+xml,<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 16 16' fill='#{$accordion-icon-color-dark}'><path fill-rule='evenodd' d='M1.646 4.646a.5.5 0 0 1 .708 0L8 10.293l5.646-5.647a.5.5 0 0 1 .708.708l-6 6a.5.5 0 0 1-.708 0l-6-6a.5.5 0 0 1 0-.708'/></svg>");
$accordion-button-active-icon-dark:  url("data:image/svg+xml,<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 16 16' fill='#{$accordion-icon-active-color-dark}'><path fill-rule='evenodd' d='M1.646 4.646a.5.5 0 0 1 .708 0L8 10.293l5.646-5.647a.5.5 0 0 1 .708.708l-6 6a.5.5 0 0 1-.708 0l-6-6a.5.5 0 0 1 0-.708'/></svg>");
```

### Sass mixins

Styles for dark mode, and any custom color modes you create, can be scoped appropriately to the `data-bs-theme` attribute selector or media query with the customizable `color-mode()` mixin. See the [Sass usage section](#building-with-sass) for more details.

[scss/mixins/\_color-mode.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/mixins/_color-mode.scss)

```html
@mixin color-mode($mode: light, $root: false) {
  @if $color-mode-type == "media-query" {
    @if $root == true {
      @media (prefers-color-scheme: $mode) {
        :root {
          @content;
        }
      }
    } @else {
      @media (prefers-color-scheme: $mode) {
        @content;
      }
    }
  } @else {
    [data-bs-theme="#{$mode}"] {
      @content;
    }
  }
}
```

