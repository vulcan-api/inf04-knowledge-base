> Źródło: [https://getbootstrap.com/docs/5.3/content/reboot](https://getbootstrap.com/docs/5.3/content/reboot)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/content/reboot.mdx "View and edit this file on GitHub")

# Reboot

Reboot, a collection of element-specific CSS changes in a single file, kickstart Bootstrap to provide an elegant, consistent, and simple baseline to build upon.

On this page
   
**On this page**

---

* [Approach](#approach)
* [CSS variables](#css-variables)
* [Page defaults](#page-defaults)
* [Native font stack](#native-font-stack)
* [Headings](#headings)
* [Paragraphs](#paragraphs)
* [Links](#links)
* [Horizontal rules](#horizontal-rules)
* [Lists](#lists)
* [Inline code](#inline-code)
* [Code blocks](#code-blocks)
* [Variables](#variables)
* [User input](#user-input)
* [Sample output](#sample-output)
* [Tables](#tables)
* [Forms](#forms)
  + [Pointers on buttons](#pointers-on-buttons)
* [Misc elements](#misc-elements)
  + [Address](#address)
  + [Blockquote](#blockquote)
  + [Inline elements](#inline-elements)
  + [Summary](#summary)
* [HTML5 [hidden] attribute](#html5-hidden-attribute)

## Approach

Reboot builds upon Normalize, providing many HTML elements with somewhat opinionated styles using only element selectors. Additional styling is done only with classes. For example, we reboot some `<table>` styles for a simpler baseline and later provide `.table`, `.table-bordered`, and more.

Here are our guidelines and reasons for choosing what to override in Reboot:

* Update some browser default values to use `rem`s instead of `em`s for scalable component spacing.
* Avoid `margin-top`. Vertical margins can collapse, yielding unexpected results. More importantly though, a single direction of `margin` is a simpler mental model.
* For easier scaling across device sizes, block elements should use `rem`s for `margin`s.
* Keep declarations of `font`-related properties to a minimum, using `inherit` whenever possible.

## CSS variables

Added in v5.2.0

With v5.1.1, we standardized our required `@import`s across all our CSS bundles (including `bootstrap.css`, `bootstrap-reboot.css`, and `bootstrap-grid.css`) to include `_root.scss`. This adds `:root` level CSS variables to all bundles, regardless of how many of them are used in that bundle. Ultimately Bootstrap 5 will continue to see more [CSS variables](/docs/5.3/customize/css-variables) added over time, in order to provide more real-time customization without the need to always recompile Sass. Our approach is to take our source Sass variables and transform them into CSS variables. That way, even if you don’t use CSS variables, you still have all the power of Sass. **This is still in-progress and will take time to fully implement.**

For example, consider these `:root` CSS variables for common `<body>` styles:

[scss/\_root.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_root.scss)

```html
@if $font-size-root != null {
  --#{$prefix}root-font-size: #{$font-size-root};
}
--#{$prefix}body-font-family: #{inspect($font-family-base)};
@include rfs($font-size-base, --#{$prefix}body-font-size);
--#{$prefix}body-font-weight: #{$font-weight-base};
--#{$prefix}body-line-height: #{$line-height-base};
@if $body-text-align != null {
  --#{$prefix}body-text-align: #{$body-text-align};
}

--#{$prefix}body-color: #{$body-color};
--#{$prefix}body-color-rgb: #{to-rgb($body-color)};
--#{$prefix}body-bg: #{$body-bg};
--#{$prefix}body-bg-rgb: #{to-rgb($body-bg)};

--#{$prefix}emphasis-color: #{$body-emphasis-color};
--#{$prefix}emphasis-color-rgb: #{to-rgb($body-emphasis-color)};

--#{$prefix}secondary-color: #{$body-secondary-color};
--#{$prefix}secondary-color-rgb: #{to-rgb($body-secondary-color)};
--#{$prefix}secondary-bg: #{$body-secondary-bg};
--#{$prefix}secondary-bg-rgb: #{to-rgb($body-secondary-bg)};

--#{$prefix}tertiary-color: #{$body-tertiary-color};
--#{$prefix}tertiary-color-rgb: #{to-rgb($body-tertiary-color)};
--#{$prefix}tertiary-bg: #{$body-tertiary-bg};
--#{$prefix}tertiary-bg-rgb: #{to-rgb($body-tertiary-bg)};
```

In practice, those variables are then applied in Reboot like so:

[scss/\_reboot.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_reboot.scss)

```html
body {
  margin: 0; // 1
  font-family: var(--#{$prefix}body-font-family);
  @include font-size(var(--#{$prefix}body-font-size));
  font-weight: var(--#{$prefix}body-font-weight);
  line-height: var(--#{$prefix}body-line-height);
  color: var(--#{$prefix}body-color);
  text-align: var(--#{$prefix}body-text-align);
  background-color: var(--#{$prefix}body-bg); // 2
  -webkit-text-size-adjust: 100%; // 3
  -webkit-tap-highlight-color: rgba($black, 0); // 4
}
```

Which allows you to make real-time customizations however you like:

```html
<body style="--bs-body-color: #333;">
  <!-- ... -->
</body>
```

## Page defaults

The `<html>` and `<body>` elements are updated to provide better page-wide defaults. More specifically:

* The `box-sizing` is globally set on every element—including `*::before` and `*::after`, to `border-box`. This ensures that the declared width of element is never exceeded due to padding or border.
  + No base `font-size` is declared on the `<html>`, but `16px` is assumed (the browser default). `font-size: 1rem` is applied on the `<body>` for easy responsive type-scaling via media queries while respecting user preferences and ensuring a more accessible approach. This browser default can be overridden by modifying the `$font-size-root` variable.
* The `<body>` also sets a global `font-family`, `font-weight`, `line-height`, and `color`. This is inherited later by some form elements to prevent font inconsistencies.
* For safety, the `<body>` has a declared `background-color`, defaulting to `#fff`.

## Native font stack

Bootstrap utilizes a “native font stack” or “system font stack” for optimum text rendering on every device and OS. These system fonts have been designed specifically with today’s devices in mind, with improved rendering on screens, variable font support, and more. Read more about [native font stacks in this *Smashing Magazine* article](https://www.smashingmagazine.com/2015/11/using-system-ui-fonts-practical-guide/).

```html
$font-family-sans-serif:
  // Cross-platform generic font family (default user interface font)
  system-ui,
  // Safari for macOS and iOS (San Francisco)
  -apple-system,
  // Windows
  "Segoe UI",
  // Android
  Roboto,
  // older macOS and iOS
  "Helvetica Neue",
  // Linux
  "Noto Sans",
  "Liberation Sans",
  // Basic web fallback
  Arial,
  // Sans serif fallback
  sans-serif,
  // Emoji fonts
  "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol", "Noto Color Emoji" !default;
```

Note that because the font stack includes emoji fonts, many common symbol/dingbat Unicode characters will be rendered as multicolored pictographs. Their appearance will vary, depending on the style used in the browser/platform’s native emoji font, and they won’t be affected by any CSS `color` styles.

This `font-family` is applied to the `<body>` and automatically inherited globally throughout Bootstrap. To switch the global `font-family`, update `$font-family-base` and recompile Bootstrap.

## Headings

All heading elements—`<h1>`—`<h6>` have their `margin-top` removed, `margin-bottom: .5rem` set, and `line-height` tightened. While headings inherit their `color` by default, you can also override it via optional CSS variable, `--bs-heading-color`.

| Heading | Example |
| --- | --- |
| `<h1></h1>` | h1. Bootstrap heading |
| `<h2></h2>` | h2. Bootstrap heading |
| `<h3></h3>` | h3. Bootstrap heading |
| `<h4></h4>` | h4. Bootstrap heading |
| `<h5></h5>` | h5. Bootstrap heading |
| `<h6></h6>` | h6. Bootstrap heading |

## Paragraphs

All `<p>` elements have their `margin-top` removed and `margin-bottom: 1rem` set for easy spacing.

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
     &lt;p&gt;This is an example paragraph.&lt;/p&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<p>This is an example paragraph.</p>
```

## Links

Links have a default `color` and underline applied. While links change on `:hover`, they don’t change based on whether someone `:visited` the link. They also receive no special `:focus` styles.

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
     &lt;a href=&quot;#&quot;&gt;This is an example link&lt;/a&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<a href="#">This is an example link</a>
```

As of v5.3.x, link `color` is set using `rgba()` and new `-rgb` CSS variables, allowing for easy customization of link color opacity. Change the link color opacity with the `--bs-link-opacity` CSS variable:

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
     &lt;a href=&quot;#&quot; style=&quot;--bs-link-opacity: .5&quot;&gt;This is an example link&lt;/a&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<a href="#" style="--bs-link-opacity: .5">This is an example link</a>
```

Placeholder links—those without an `href`—are targeted with a more specific selector and have their `color` and `text-decoration` reset to their default values.

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
     &lt;a&gt;This is a placeholder link&lt;/a&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<a>This is a placeholder link</a>
```

## Horizontal rules

The `<hr>` element has been simplified. Similar to browser defaults, `<hr>`s are styled via `border-top`, have a default `opacity: .25`, and automatically inherit their `border-color` via `color`, including when `color` is set via the parent. They can be modified with text, border, and opacity utilities.

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
     &lt;hr/&gt;
&lt;div class=&quot;text-success&quot;&gt;
&lt;hr/&gt;
&lt;/div&gt;
&lt;hr class=&quot;border border-danger border-2 opacity-50&quot;/&gt;
&lt;hr class=&quot;border border-primary border-3 opacity-75&quot;/&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<hr>

<div class="text-success">
  <hr>
</div>

<hr class="border border-danger border-2 opacity-50">
<hr class="border border-primary border-3 opacity-75">
```

## Lists

All lists—`<ul>`, `<ol>`, and `<dl>`—have their `margin-top` removed and a `margin-bottom: 1rem`. Nested lists have no `margin-bottom`. We’ve also reset the `padding-left` on `<ul>` and `<ol>` elements.

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
    &lt;ul&gt;
&lt;li&gt;All lists have their top margin removed&lt;/li&gt;
&lt;li&gt;And their bottom margin normalized&lt;/li&gt;
&lt;li&gt;Nested lists have no bottom margin
&lt;ul&gt;
&lt;li&gt;This way they have a more even appearance&lt;/li&gt;
&lt;li&gt;Particularly when followed by more list items&lt;/li&gt;
&lt;/ul&gt;
&lt;/li&gt;
&lt;li&gt;The left padding has also been reset&lt;/li&gt;
&lt;/ul&gt;&lt;ol&gt;
&lt;li&gt;Here’s an ordered list&lt;/li&gt;
&lt;li&gt;With a few list items&lt;/li&gt;
&lt;li&gt;It has the same overall look&lt;/li&gt;
&lt;li&gt;As the previous unordered list&lt;/li&gt;
&lt;/ol&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

For simpler styling, clear hierarchy, and better spacing, description lists have updated `margin`s. `<dd>`s reset `margin-left` to `0` and add `margin-bottom: .5rem`. `<dt>`s are **bolded**.

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
    
&lt;dl&gt;
&lt;dt&gt;Description lists&lt;/dt&gt;
&lt;dd&gt;A description list is perfect for defining terms.&lt;/dd&gt;
&lt;dt&gt;Term&lt;/dt&gt;
&lt;dd&gt;Definition for the term.&lt;/dd&gt;
&lt;dd&gt;A second definition for the same term.&lt;/dd&gt;
&lt;dt&gt;Another term&lt;/dt&gt;
&lt;dd&gt;Definition for this other term.&lt;/dd&gt;
&lt;/dl&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

## Inline code

Wrap inline snippets of code with `<code>`. Be sure to escape HTML angle brackets.

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
     For example, &lt;code&gt;&amp;lt;section&amp;gt;&lt;/code&gt; should be wrapped as inline. 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
For example, <code>&lt;section&gt;</code> should be wrapped as inline.
```

## Code blocks

Use `<pre>`s for multiple lines of code. Once again, be sure to escape any angle brackets in the code for proper rendering. The `<pre>` element is reset to remove its `margin-top` and use `rem` units for its `margin-bottom`.

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
     &lt;pre&gt;&lt;code&gt;&amp;lt;p&amp;gt;Sample text here...&amp;lt;/p&amp;gt;
&amp;lt;p&amp;gt;And another line of sample text here...&amp;lt;/p&amp;gt;
&lt;/code&gt;&lt;/pre&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<pre><code>&lt;p&gt;Sample text here...&lt;/p&gt;
&lt;p&gt;And another line of sample text here...&lt;/p&gt;
</code></pre>
```

## Variables

For indicating variables use the `<var>` tag.

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
     &lt;var&gt;y&lt;/var&gt; = &lt;var&gt;m&lt;/var&gt;&lt;var&gt;x&lt;/var&gt; + &lt;var&gt;b&lt;/var&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<var>y</var> = <var>m</var><var>x</var> + <var>b</var>
```

## User input

Use the `<kbd>` to indicate input that is typically entered via keyboard.

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
     To switch directories, type &lt;kbd&gt;cd&lt;/kbd&gt; followed by the name of the directory.&lt;br/&gt;
To edit settings, press &lt;kbd&gt;&lt;kbd&gt;Ctrl&lt;/kbd&gt; + &lt;kbd&gt;,&lt;/kbd&gt;&lt;/kbd&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
To switch directories, type <kbd>cd</kbd> followed by the name of the directory.<br>
To edit settings, press <kbd><kbd>Ctrl</kbd> + <kbd>,</kbd></kbd>
```

## Sample output

For indicating sample output from a program use the `<samp>` tag.

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
     &lt;samp&gt;This text is meant to be treated as sample output from a computer program.&lt;/samp&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<samp>This text is meant to be treated as sample output from a computer program.</samp>
```

## Tables

Tables are slightly adjusted to style `<caption>`s, collapse borders, and ensure consistent `text-align` throughout. Additional changes for borders, padding, and more come with [the `.table` class](/docs/5.3/content/tables).

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
     &lt;table&gt;
&lt;caption&gt;
    This is an example table, and this is its caption to describe the contents.
  &lt;/caption&gt;
&lt;thead&gt;
&lt;tr&gt;
&lt;th&gt;Table heading&lt;/th&gt;
&lt;th&gt;Table heading&lt;/th&gt;
&lt;th&gt;Table heading&lt;/th&gt;
&lt;th&gt;Table heading&lt;/th&gt;
&lt;/tr&gt;
&lt;/thead&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;td&gt;Table cell&lt;/td&gt;
&lt;td&gt;Table cell&lt;/td&gt;
&lt;td&gt;Table cell&lt;/td&gt;
&lt;td&gt;Table cell&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;td&gt;Table cell&lt;/td&gt;
&lt;td&gt;Table cell&lt;/td&gt;
&lt;td&gt;Table cell&lt;/td&gt;
&lt;td&gt;Table cell&lt;/td&gt;
&lt;/tr&gt;
&lt;tr&gt;
&lt;td&gt;Table cell&lt;/td&gt;
&lt;td&gt;Table cell&lt;/td&gt;
&lt;td&gt;Table cell&lt;/td&gt;
&lt;td&gt;Table cell&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<table>
  <caption>
    This is an example table, and this is its caption to describe the contents.
  </caption>
  <thead>
    <tr>
      <th>Table heading</th>
      <th>Table heading</th>
      <th>Table heading</th>
      <th>Table heading</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Table cell</td>
      <td>Table cell</td>
      <td>Table cell</td>
      <td>Table cell</td>
    </tr>
    <tr>
      <td>Table cell</td>
      <td>Table cell</td>
      <td>Table cell</td>
      <td>Table cell</td>
    </tr>
    <tr>
      <td>Table cell</td>
      <td>Table cell</td>
      <td>Table cell</td>
      <td>Table cell</td>
    </tr>
  </tbody>
</table>
```

## Forms

Various form elements have been rebooted for simpler base styles. Here are some of the most notable changes:

* `<fieldset>`s have no borders, padding, or margin so they can be easily used as wrappers for individual inputs or groups of inputs.
* `<legend>`s, like fieldsets, have also been restyled to be displayed as a heading of sorts.
* `<label>`s are set to `display: inline-block` to allow `margin` to be applied.
* `<input>`s, `<select>`s, `<textarea>`s, and `<button>`s are mostly addressed by Normalize, but Reboot removes their `margin` and sets `line-height: inherit`, too.
* `<textarea>`s are modified to only be resizable vertically as horizontal resizing often “breaks” page layout.
* `<button>`s and `<input>` button elements have `cursor: pointer` when `:not(:disabled)`.

These changes, and more, are demonstrated below.

Some date inputs types are [not fully supported](https://caniuse.com/input-datetime) by the latest versions of Safari and Firefox.

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
     &lt;form&gt;
&lt;fieldset&gt;
&lt;legend&gt;Example legend&lt;/legend&gt;
&lt;p&gt;
&lt;label for=&quot;input&quot;&gt;Example input&lt;/label&gt;
&lt;input id=&quot;input&quot; placeholder=&quot;Example input&quot; type=&quot;text&quot;/&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label for=&quot;email&quot;&gt;Example email&lt;/label&gt;
&lt;input id=&quot;email&quot; placeholder=&quot;test@example.com&quot; type=&quot;email&quot;/&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label for=&quot;tel&quot;&gt;Example telephone&lt;/label&gt;
&lt;input id=&quot;tel&quot; type=&quot;tel&quot;/&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label for=&quot;url&quot;&gt;Example url&lt;/label&gt;
&lt;input id=&quot;url&quot; type=&quot;url&quot;/&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label for=&quot;number&quot;&gt;Example number&lt;/label&gt;
&lt;input id=&quot;number&quot; type=&quot;number&quot;/&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label for=&quot;search&quot;&gt;Example search&lt;/label&gt;
&lt;input id=&quot;search&quot; type=&quot;search&quot;/&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label for=&quot;range&quot;&gt;Example range&lt;/label&gt;
&lt;input id=&quot;range&quot; max=&quot;10&quot; min=&quot;0&quot; type=&quot;range&quot;/&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label for=&quot;file&quot;&gt;Example file input&lt;/label&gt;
&lt;input id=&quot;file&quot; type=&quot;file&quot;/&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label for=&quot;select&quot;&gt;Example select&lt;/label&gt;
&lt;select id=&quot;select&quot;&gt;
&lt;option value=&quot;&quot;&gt;Choose...&lt;/option&gt;
&lt;optgroup label=&quot;Option group 1&quot;&gt;
&lt;option value=&quot;&quot;&gt;Option 1&lt;/option&gt;
&lt;option value=&quot;&quot;&gt;Option 2&lt;/option&gt;
&lt;option value=&quot;&quot;&gt;Option 3&lt;/option&gt;
&lt;/optgroup&gt;
&lt;optgroup label=&quot;Option group 2&quot;&gt;
&lt;option value=&quot;&quot;&gt;Option 4&lt;/option&gt;
&lt;option value=&quot;&quot;&gt;Option 5&lt;/option&gt;
&lt;option value=&quot;&quot;&gt;Option 6&lt;/option&gt;
&lt;/optgroup&gt;
&lt;/select&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label&gt;
&lt;input type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
      Check this checkbox
    &lt;/label&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label&gt;
&lt;input checked=&quot;&quot; id=&quot;optionsRadios1&quot; name=&quot;optionsRadios&quot; type=&quot;radio&quot; value=&quot;option1&quot;/&gt;
      Option one is this and that
    &lt;/label&gt;
&lt;label&gt;
&lt;input id=&quot;optionsRadios2&quot; name=&quot;optionsRadios&quot; type=&quot;radio&quot; value=&quot;option2&quot;/&gt;
      Option two is something else that’s also super long to demonstrate the wrapping of these fancy form controls.
    &lt;/label&gt;
&lt;label&gt;
&lt;input disabled=&quot;&quot; id=&quot;optionsRadios3&quot; name=&quot;optionsRadios&quot; type=&quot;radio&quot; value=&quot;option3&quot;/&gt;
      Option three is disabled
    &lt;/label&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label for=&quot;textarea&quot;&gt;Example textarea&lt;/label&gt;
&lt;textarea id=&quot;textarea&quot; rows=&quot;3&quot;&gt;&lt;/textarea&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label for=&quot;date&quot;&gt;Example date&lt;/label&gt;
&lt;input id=&quot;date&quot; type=&quot;date&quot;/&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label for=&quot;time&quot;&gt;Example time&lt;/label&gt;
&lt;input id=&quot;time&quot; type=&quot;time&quot;/&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label for=&quot;password&quot;&gt;Example password&lt;/label&gt;
&lt;input id=&quot;password&quot; type=&quot;password&quot;/&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label for=&quot;datetime-local&quot;&gt;Example datetime-local&lt;/label&gt;
&lt;input id=&quot;datetime-local&quot; type=&quot;datetime-local&quot;/&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label for=&quot;week&quot;&gt;Example week&lt;/label&gt;
&lt;input id=&quot;week&quot; type=&quot;week&quot;/&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label for=&quot;month&quot;&gt;Example month&lt;/label&gt;
&lt;input id=&quot;month&quot; type=&quot;month&quot;/&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label for=&quot;color&quot;&gt;Example color&lt;/label&gt;
&lt;input id=&quot;color&quot; type=&quot;color&quot;/&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;label for=&quot;output&quot;&gt;Example output&lt;/label&gt;
&lt;output id=&quot;output&quot; name=&quot;result&quot;&gt;100&lt;/output&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;button type=&quot;submit&quot;&gt;Button submit&lt;/button&gt;
&lt;input type=&quot;submit&quot; value=&quot;Input submit button&quot;/&gt;
&lt;input type=&quot;reset&quot; value=&quot;Input reset button&quot;/&gt;
&lt;input type=&quot;button&quot; value=&quot;Input button&quot;/&gt;
&lt;/p&gt;
&lt;p&gt;
&lt;button disabled=&quot;&quot; type=&quot;submit&quot;&gt;Button submit&lt;/button&gt;
&lt;input disabled=&quot;&quot; type=&quot;submit&quot; value=&quot;Input submit button&quot;/&gt;
&lt;input disabled=&quot;&quot; type=&quot;reset&quot; value=&quot;Input reset button&quot;/&gt;
&lt;input disabled=&quot;&quot; type=&quot;button&quot; value=&quot;Input button&quot;/&gt;
&lt;/p&gt;
&lt;/fieldset&gt;
&lt;/form&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

### Pointers on buttons

Reboot includes an enhancement for `role="button"` to change the default cursor to `pointer`. Add this attribute to elements to help indicate elements are interactive. This role isn’t necessary for `<button>` elements, which get their own `cursor` change.

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
     &lt;span role=&quot;button&quot; tabindex=&quot;0&quot;&gt;Non-button element button&lt;/span&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<span role="button" tabindex="0">Non-button element button</span>
```

## Misc elements

### Address

The `<address>` element is updated to reset the browser default `font-style` from `italic` to `normal`. `line-height` is also now inherited, and `margin-bottom: 1rem` has been added. `<address>`s are for presenting contact information for the nearest ancestor (or an entire body of work). Preserve formatting by ending lines with `<br>`.

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
     &lt;address&gt;
&lt;strong&gt;ACME Corporation&lt;/strong&gt;&lt;br&gt;
  1123 Fictional St,&lt;br/&gt;
  San Francisco, CA 94103&lt;br/&gt;
&lt;abbr title=&quot;Phone&quot;&gt;P:&lt;/abbr&gt; (123) 456-7890
&lt;/br&gt;&lt;/address&gt;
&lt;address&gt;
&lt;strong&gt;Full Name&lt;/strong&gt;&lt;br/&gt;
&lt;a href=&quot;mailto:first.last@example.com&quot;&gt;first.last@example.com&lt;/a&gt;
&lt;/address&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

### Blockquote

The default `margin` on blockquotes is `1em 40px`, so we reset that to `0 0 1rem` for something more consistent with other elements.

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
     &lt;figure&gt;
&lt;blockquote class=&quot;blockquote&quot;&gt;
&lt;p&gt;A well-known quote, contained in a blockquote element.&lt;/p&gt;
&lt;/blockquote&gt;
&lt;figcaption&gt;
    Someone famous in &lt;cite title=&quot;Source Title&quot;&gt;Source Title&lt;/cite&gt;
&lt;/figcaption&gt;
&lt;/figure&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

### Inline elements

The `<abbr>` element receives basic styling to make it stand out amongst paragraph text.

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
     
The &lt;abbr title=&quot;HyperText Markup Language&quot;&gt;HTML&lt;/abbr&gt; abbreviation element.
 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

### Summary

The default `cursor` on summary is `text`, so we reset that to `pointer` to convey that the element can be interacted with by clicking on it.

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
    
&lt;details&gt;
&lt;summary&gt;Some details&lt;/summary&gt;
&lt;p&gt;More info about the details.&lt;/p&gt;
&lt;/details&gt;
&lt;details open=&quot;&quot;&gt;
&lt;summary&gt;Even more details&lt;/summary&gt;
&lt;p&gt;Here are even more details about the details.&lt;/p&gt;
&lt;/details&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

## HTML5 `[hidden]` attribute

HTML5 adds [a new global attribute named `[hidden]`](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/hidden), which is styled as `display: none` by default. Borrowing an idea from [PureCSS](https://purecss.io/), we improve upon this default by making `[hidden] { display: none !important; }` to help prevent its `display` from getting accidentally overridden.

```html
<input type="text" hidden>
```

Since `[hidden]` is not compatible with jQuery’s `$(...).hide()` and `$(...).show()` methods, we don’t specifically endorse `[hidden]` over other techniques for managing the `display` of elements.

To merely toggle the visibility of an element, meaning its `display` is not modified and the element can still affect the flow of the document, use [the `.invisible` class](/docs/5.3/utilities/visibility) instead.

