> Źródło: [https://getbootstrap.com/docs/5.3/utilities/z-index](https://getbootstrap.com/docs/5.3/utilities/z-index)



Added in v5.3  [View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/utilities/z-index.mdx "View and edit this file on GitHub")

# Z-index

Use our low-level `z-index` utilities to quickly change the stack level of an element or component.

On this page
   
**On this page**

---

* [Example](#example)
* [Overlays](#overlays)
* [Component approach](#component-approach)
* [CSS](#css)
  + [Sass maps](#sass-maps)
  + [Sass utilities API](#sass-utilities-api)

## Example

Use `z-index` utilities to stack elements on top of one another. Requires a `position` value other than `static`, which can be set with custom styles or using our [position utilities](/docs/5.3/utilities/position/).

We call these “low-level” `z-index` utilities because of their default values of `-1` through `3`, which we use for the layout of overlapping components. High-level `z-index` values are used for overlay components like modals and tooltips.

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
     &lt;div class=&quot;z-3 position-absolute p-5 rounded-3&quot;&gt;&lt;span&gt;z-3&lt;/span&gt;&lt;/div&gt;
&lt;div class=&quot;z-2 position-absolute p-5 rounded-3&quot;&gt;&lt;span&gt;z-2&lt;/span&gt;&lt;/div&gt;
&lt;div class=&quot;z-1 position-absolute p-5 rounded-3&quot;&gt;&lt;span&gt;z-1&lt;/span&gt;&lt;/div&gt;
&lt;div class=&quot;z-0 position-absolute p-5 rounded-3&quot;&gt;&lt;span&gt;z-0&lt;/span&gt;&lt;/div&gt;
&lt;div class=&quot;z-n1 position-absolute p-5 rounded-3&quot;&gt;&lt;span&gt;z-n1&lt;/span&gt;&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="z-3 position-absolute p-5 rounded-3"><span>z-3</span></div>
<div class="z-2 position-absolute p-5 rounded-3"><span>z-2</span></div>
<div class="z-1 position-absolute p-5 rounded-3"><span>z-1</span></div>
<div class="z-0 position-absolute p-5 rounded-3"><span>z-0</span></div>
<div class="z-n1 position-absolute p-5 rounded-3"><span>z-n1</span></div>
```

## Overlays

Bootstrap overlay components—dropdown, modal, offcanvas, popover, toast, and tooltip—all have their own `z-index` values to ensure a usable experience with competing “layers” of an interface.

Read about them in the [`z-index` layout page](/docs/5.3/layout/z-index).

## Component approach

On some components, we use our low-level `z-index` values to manage repeating elements that overlap one another (like buttons in a button group or items in a list group).

Learn about our [`z-index` approach](/docs/5.3/extend/approach#z-index-scales).

## CSS

### Sass maps

Customize this Sass map to change the available values and generated utilities.

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$zindex-levels: (
  n1: -1,
  0: 0,
  1: 1,
  2: 2,
  3: 3
);
```

### Sass utilities API

Position utilities are declared in our utilities API in `scss/_utilities.scss`. [Learn how to use the utilities API.](/docs/5.3/utilities/api#using-the-api)

[scss/\_utilities.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_utilities.scss)

```html
"z-index": (
  property: z-index,
  class: z,
  values: $zindex-levels,
)
```

