> Źródło: [https://getbootstrap.com/docs/5.3/utilities/spacing](https://getbootstrap.com/docs/5.3/utilities/spacing)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/utilities/spacing.mdx "View and edit this file on GitHub")

# Spacing

Bootstrap includes a wide range of shorthand responsive margin, padding, and gap utility classes to modify an element’s appearance.

On this page
   
**On this page**

---

* [Margin and padding](#margin-and-padding)
  + [Notation](#notation)
  + [Examples](#examples)
  + [Horizontal centering](#horizontal-centering)
* [Negative margin](#negative-margin)
* [Gap](#gap)
  + [row-gap](#row-gap)
  + [column-gap](#column-gap)
* [CSS](#css)
  + [Sass maps](#sass-maps)
  + [Sass utilities API](#sass-utilities-api)

## Margin and padding

Assign responsive-friendly `margin` or `padding` values to an element or a subset of its sides with shorthand classes. Includes support for individual properties, all properties, and vertical and horizontal properties. Classes are built from a default Sass map ranging from `.25rem` to `3rem`.

**Using the CSS Grid layout module?** Consider using [the gap utility](#gap) instead.

### Notation

Spacing utilities that apply to all breakpoints, from `xs` to `xxl`, have no breakpoint abbreviation in them. This is because those classes are applied from `min-width: 0` and up, and thus are not bound by a media query. The remaining breakpoints, however, do include a breakpoint abbreviation.

The classes are named using the format `{property}{sides}-{size}` for `xs` and `{property}{sides}-{breakpoint}-{size}` for `sm`, `md`, `lg`, `xl`, and `xxl`.

Where *property* is one of:

* `m` - for classes that set `margin`
* `p` - for classes that set `padding`

Where *sides* is one of:

* `t` - for classes that set `margin-top` or `padding-top`
* `b` - for classes that set `margin-bottom` or `padding-bottom`
* `s` - (start) for classes that set `margin-left` or `padding-left` in LTR, `margin-right` or `padding-right` in RTL
* `e` - (end) for classes that set `margin-right` or `padding-right` in LTR, `margin-left` or `padding-left` in RTL
* `x` - for classes that set both `*-left` and `*-right`
* `y` - for classes that set both `*-top` and `*-bottom`
* blank - for classes that set a `margin` or `padding` on all 4 sides of the element

Where *size* is one of:

* `0` - for classes that eliminate the `margin` or `padding` by setting it to `0`
* `1` - (by default) for classes that set the `margin` or `padding` to `$spacer * .25`
* `2` - (by default) for classes that set the `margin` or `padding` to `$spacer * .5`
* `3` - (by default) for classes that set the `margin` or `padding` to `$spacer`
* `4` - (by default) for classes that set the `margin` or `padding` to `$spacer * 1.5`
* `5` - (by default) for classes that set the `margin` or `padding` to `$spacer * 3`
* `auto` - for classes that set the `margin` to auto

(You can add more sizes by adding entries to the `$spacers` Sass map variable.)

### Examples

Here are some representative examples of these classes:

```html
.mt-0 {
  margin-top: 0 !important;
}

.ms-1 {
  margin-left: ($spacer * .25) !important;
}

.px-2 {
  padding-left: ($spacer * .5) !important;
  padding-right: ($spacer * .5) !important;
}

.p-3 {
  padding: $spacer !important;
}
```

### Horizontal centering

Additionally, Bootstrap also includes an `.mx-auto` class for horizontally centering fixed-width block level content—that is, content that has `display: block` and a `width` set—by setting the horizontal margins to `auto`.

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
     &lt;div class=&quot;mx-auto p-2&quot; style=&quot;width: 200px; background-color: rgba(var(--bd-violet-rgb),.15); border: rgba(var(--bd-violet-rgb),.3) solid 1px;&quot;&gt;
  Centered element
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="mx-auto p-2" style="width: 200px;">
  Centered element
</div>
```

## Negative margin

In CSS, `margin` properties can utilize negative values (`padding` cannot). These negative margins are **disabled by default**, but can be enabled in Sass by setting `$enable-negative-margins: true`.

The syntax is nearly the same as the default, positive margin utilities, but with the addition of `n` before the requested size. Here’s an example class that’s the opposite of `.mt-1`:

```html
.mt-n1 {
  margin-top: -0.25rem !important;
}
```

## Gap

When using `display: grid` or `display: flex`, you can make use of `gap` utilities on the parent element. This can save on having to add margin utilities to individual children of a grid or flex container. Gap utilities are responsive by default, and are generated via our utilities API, based on the `$spacers` Sass map.

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
     &lt;div class=&quot;d-grid gap-3&quot; style=&quot;grid-template-columns: 1fr 1fr;&quot;&gt;
&lt;div class=&quot;p-2&quot;&gt;Grid item 1&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Grid item 2&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Grid item 3&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Grid item 4&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div style="grid-template-columns: 1fr 1fr;" class="d-grid gap-3">
  <div class="p-2">Grid item 1</div>
  <div class="p-2">Grid item 2</div>
  <div class="p-2">Grid item 3</div>
  <div class="p-2">Grid item 4</div>
</div>
```

Support includes responsive options for all of Bootstrap’s grid breakpoints, as well as six sizes from the `$spacers` map (`0`–`5`). There is no `.gap-auto` utility class as it’s effectively the same as `.gap-0`.

### row-gap

`row-gap` sets the vertical space between children items in the specified container.

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
     &lt;div class=&quot;d-grid gap-0 row-gap-3&quot; style=&quot;grid-template-columns: 1fr 1fr;&quot;&gt;
&lt;div class=&quot;p-2&quot;&gt;Grid item 1&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Grid item 2&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Grid item 3&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Grid item 4&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div style="grid-template-columns: 1fr 1fr;" class="d-grid gap-0 row-gap-3">
  <div class="p-2">Grid item 1</div>
  <div class="p-2">Grid item 2</div>
  <div class="p-2">Grid item 3</div>
  <div class="p-2">Grid item 4</div>
</div>
```

### column-gap

`column-gap` sets the horizontal space between children items in the specified container.

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
     &lt;div class=&quot;d-grid gap-0 column-gap-3&quot; style=&quot;grid-template-columns: 1fr 1fr;&quot;&gt;
&lt;div class=&quot;p-2&quot;&gt;Grid item 1&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Grid item 2&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Grid item 3&lt;/div&gt;
&lt;div class=&quot;p-2&quot;&gt;Grid item 4&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div style="grid-template-columns: 1fr 1fr;" class="d-grid gap-0 column-gap-3">
  <div class="p-2">Grid item 1</div>
  <div class="p-2">Grid item 2</div>
  <div class="p-2">Grid item 3</div>
  <div class="p-2">Grid item 4</div>
</div>
```

## CSS

### Sass maps

Spacing utilities are declared via Sass map and then generated with our utilities API.

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$spacer: 1rem;
$spacers: (
  0: 0,
  1: $spacer * .25,
  2: $spacer * .5,
  3: $spacer,
  4: $spacer * 1.5,
  5: $spacer * 3,
);
```

### Sass utilities API

Spacing utilities are declared in our utilities API in `scss/_utilities.scss`. [Learn how to use the utilities API.](/docs/5.3/utilities/api#using-the-api)

[scss/\_utilities.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_utilities.scss)

```html
"margin": (
  responsive: true,
  property: margin,
  class: m,
  values: map-merge($spacers, (auto: auto))
),
"margin-x": (
  responsive: true,
  property: margin-right margin-left,
  class: mx,
  values: map-merge($spacers, (auto: auto))
),
"margin-y": (
  responsive: true,
  property: margin-top margin-bottom,
  class: my,
  values: map-merge($spacers, (auto: auto))
),
"margin-top": (
  responsive: true,
  property: margin-top,
  class: mt,
  values: map-merge($spacers, (auto: auto))
),
"margin-end": (
  responsive: true,
  property: margin-right,
  class: me,
  values: map-merge($spacers, (auto: auto))
),
"margin-bottom": (
  responsive: true,
  property: margin-bottom,
  class: mb,
  values: map-merge($spacers, (auto: auto))
),
"margin-start": (
  responsive: true,
  property: margin-left,
  class: ms,
  values: map-merge($spacers, (auto: auto))
),
// Negative margin utilities
"negative-margin": (
  responsive: true,
  property: margin,
  class: m,
  values: $negative-spacers
),
"negative-margin-x": (
  responsive: true,
  property: margin-right margin-left,
  class: mx,
  values: $negative-spacers
),
"negative-margin-y": (
  responsive: true,
  property: margin-top margin-bottom,
  class: my,
  values: $negative-spacers
),
"negative-margin-top": (
  responsive: true,
  property: margin-top,
  class: mt,
  values: $negative-spacers
),
"negative-margin-end": (
  responsive: true,
  property: margin-right,
  class: me,
  values: $negative-spacers
),
"negative-margin-bottom": (
  responsive: true,
  property: margin-bottom,
  class: mb,
  values: $negative-spacers
),
"negative-margin-start": (
  responsive: true,
  property: margin-left,
  class: ms,
  values: $negative-spacers
),
// Padding utilities
"padding": (
  responsive: true,
  property: padding,
  class: p,
  values: $spacers
),
"padding-x": (
  responsive: true,
  property: padding-right padding-left,
  class: px,
  values: $spacers
),
"padding-y": (
  responsive: true,
  property: padding-top padding-bottom,
  class: py,
  values: $spacers
),
"padding-top": (
  responsive: true,
  property: padding-top,
  class: pt,
  values: $spacers
),
"padding-end": (
  responsive: true,
  property: padding-right,
  class: pe,
  values: $spacers
),
"padding-bottom": (
  responsive: true,
  property: padding-bottom,
  class: pb,
  values: $spacers
),
"padding-start": (
  responsive: true,
  property: padding-left,
  class: ps,
  values: $spacers
),
// Gap utility
"gap": (
  responsive: true,
  property: gap,
  class: gap,
  values: $spacers
),
"row-gap": (
  responsive: true,
  property: row-gap,
  class: row-gap,
  values: $spacers
),
"column-gap": (
  responsive: true,
  property: column-gap,
  class: column-gap,
  values: $spacers
),
```

