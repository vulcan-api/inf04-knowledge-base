> Źródło: [https://getbootstrap.com/docs/5.3/utilities/position](https://getbootstrap.com/docs/5.3/utilities/position)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/utilities/position.mdx "View and edit this file on GitHub")

# Position

Use these shorthand utilities for quickly configuring the position of an element.

On this page
   
**On this page**

---

* [Position values](#position-values)
* [Arrange elements](#arrange-elements)
* [Center elements](#center-elements)
* [Examples](#examples)
* [CSS](#css)
  + [Sass maps](#sass-maps)
  + [Sass utilities API](#sass-utilities-api)

## Position values

Quick positioning classes are available, though they are not responsive.

```html
<div class="position-static">...</div>
<div class="position-relative">...</div>
<div class="position-absolute">...</div>
<div class="position-fixed">...</div>
<div class="position-sticky">...</div>
```

## Arrange elements

Arrange elements easily with the edge positioning utilities. The format is `{property}-{position}`.

Where *property* is one of:

* `top` - for the vertical `top` position
* `start` - for the horizontal `left` position (in LTR)
* `bottom` - for the vertical `bottom` position
* `end` - for the horizontal `right` position (in LTR)

Where *position* is one of:

* `0` - for `0` edge position
* `50` - for `50%` edge position
* `100` - for `100%` edge position

(You can add more position values by adding entries to the `$position-values` Sass map variable.)

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
     &lt;div class=&quot;position-relative&quot;&gt;
&lt;div class=&quot;position-absolute top-0 start-0&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute top-0 end-0&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute top-50 start-50&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute bottom-50 end-50&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute bottom-0 start-0&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute bottom-0 end-0&quot;&gt;&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="position-relative">
  <div class="position-absolute top-0 start-0"></div>
  <div class="position-absolute top-0 end-0"></div>
  <div class="position-absolute top-50 start-50"></div>
  <div class="position-absolute bottom-50 end-50"></div>
  <div class="position-absolute bottom-0 start-0"></div>
  <div class="position-absolute bottom-0 end-0"></div>
</div>
```

## Center elements

In addition, you can also center the elements with the transform utility class `.translate-middle`.

This class applies the transformations `translateX(-50%)` and `translateY(-50%)` to the element which, in combination with the edge positioning utilities, allows you to absolute center an element.

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
     &lt;div class=&quot;position-relative&quot;&gt;
&lt;div class=&quot;position-absolute top-0 start-0 translate-middle&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute top-0 start-50 translate-middle&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute top-0 start-100 translate-middle&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute top-50 start-0 translate-middle&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute top-50 start-50 translate-middle&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute top-50 start-100 translate-middle&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute top-100 start-0 translate-middle&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute top-100 start-50 translate-middle&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute top-100 start-100 translate-middle&quot;&gt;&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="position-relative">
  <div class="position-absolute top-0 start-0 translate-middle"></div>
  <div class="position-absolute top-0 start-50 translate-middle"></div>
  <div class="position-absolute top-0 start-100 translate-middle"></div>
  <div class="position-absolute top-50 start-0 translate-middle"></div>
  <div class="position-absolute top-50 start-50 translate-middle"></div>
  <div class="position-absolute top-50 start-100 translate-middle"></div>
  <div class="position-absolute top-100 start-0 translate-middle"></div>
  <div class="position-absolute top-100 start-50 translate-middle"></div>
  <div class="position-absolute top-100 start-100 translate-middle"></div>
</div>
```

By adding `.translate-middle-x` or `.translate-middle-y` classes, elements can be positioned only in horizontal or vertical direction.

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
     &lt;div class=&quot;position-relative&quot;&gt;
&lt;div class=&quot;position-absolute top-0 start-0&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute top-0 start-50 translate-middle-x&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute top-0 end-0&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute top-50 start-0 translate-middle-y&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute top-50 start-50 translate-middle&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute top-50 end-0 translate-middle-y&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute bottom-0 start-0&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute bottom-0 start-50 translate-middle-x&quot;&gt;&lt;/div&gt;
&lt;div class=&quot;position-absolute bottom-0 end-0&quot;&gt;&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="position-relative">
  <div class="position-absolute top-0 start-0"></div>
  <div class="position-absolute top-0 start-50 translate-middle-x"></div>
  <div class="position-absolute top-0 end-0"></div>
  <div class="position-absolute top-50 start-0 translate-middle-y"></div>
  <div class="position-absolute top-50 start-50 translate-middle"></div>
  <div class="position-absolute top-50 end-0 translate-middle-y"></div>
  <div class="position-absolute bottom-0 start-0"></div>
  <div class="position-absolute bottom-0 start-50 translate-middle-x"></div>
  <div class="position-absolute bottom-0 end-0"></div>
</div>
```

## Examples

Here are some real life examples of these classes:

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
     &lt;button class=&quot;btn btn-primary position-relative&quot; type=&quot;button&quot;&gt;
  Mails &lt;span class=&quot;position-absolute top-0 start-100 translate-middle badge rounded-pill text-bg-secondary&quot;&gt;+99 &lt;span class=&quot;visually-hidden&quot;&gt;unread messages&lt;/span&gt;&lt;/span&gt;
&lt;/button&gt;
&lt;div class=&quot;position-relative py-2 px-4 text-bg-secondary border border-secondary rounded-pill&quot;&gt;
  Marker &lt;svg aria-hidden=&quot;true&quot; class=&quot;position-absolute top-100 start-50 translate-middle mt-1&quot; fill=&quot;var(--bs-secondary)&quot; height=&quot;1em&quot; viewbox=&quot;0 0 16 16&quot; width=&quot;1em&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;path d=&quot;M7.247 11.14L2.451 5.658C1.885 5.013 2.345 4 3.204 4h9.592a1 1 0 0 1 .753 1.659l-4.796 5.48a1 1 0 0 1-1.506 0z&quot;&gt;&lt;/path&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;button class=&quot;btn btn-primary position-relative&quot; type=&quot;button&quot;&gt;
  Alerts &lt;span class=&quot;position-absolute top-0 start-100 translate-middle badge border border-light rounded-circle bg-danger p-2&quot;&gt;&lt;span class=&quot;visually-hidden&quot;&gt;unread messages&lt;/span&gt;&lt;/span&gt;
&lt;/button&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<button type="button" class="btn btn-primary position-relative">
  Mails <span class="position-absolute top-0 start-100 translate-middle badge rounded-pill text-bg-secondary">+99 <span class="visually-hidden">unread messages</span></span>
</button>

<div class="position-relative py-2 px-4 text-bg-secondary border border-secondary rounded-pill">
  Marker <svg width="1em" height="1em" viewBox="0 0 16 16" class="position-absolute top-100 start-50 translate-middle mt-1" fill="var(--bs-secondary)" xmlns="http://www.w3.org/2000/svg" aria-hidden="true"><path d="M7.247 11.14L2.451 5.658C1.885 5.013 2.345 4 3.204 4h9.592a1 1 0 0 1 .753 1.659l-4.796 5.48a1 1 0 0 1-1.506 0z"/></svg>
</div>

<button type="button" class="btn btn-primary position-relative">
  Alerts <span class="position-absolute top-0 start-100 translate-middle badge border border-light rounded-circle bg-danger p-2"><span class="visually-hidden">unread messages</span></span>
</button>
```

You can use these classes with existing components to create new ones. Remember that you can extend its functionality by adding entries to the `$position-values` variable.

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
     &lt;div class=&quot;position-relative m-4&quot;&gt;
&lt;div aria-label=&quot;Progress&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;50&quot; class=&quot;progress&quot; role=&quot;progressbar&quot; style=&quot;height: 1px;&quot;&gt;
&lt;div class=&quot;progress-bar&quot; style=&quot;width: 50%&quot;&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;button class=&quot;position-absolute top-0 start-0 translate-middle btn btn-sm btn-primary rounded-pill&quot; style=&quot;width: 2rem; height:2rem;&quot; type=&quot;button&quot;&gt;1&lt;/button&gt;
&lt;button class=&quot;position-absolute top-0 start-50 translate-middle btn btn-sm btn-primary rounded-pill&quot; style=&quot;width: 2rem; height:2rem;&quot; type=&quot;button&quot;&gt;2&lt;/button&gt;
&lt;button class=&quot;position-absolute top-0 start-100 translate-middle btn btn-sm btn-secondary rounded-pill&quot; style=&quot;width: 2rem; height:2rem;&quot; type=&quot;button&quot;&gt;3&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="position-relative m-4">
  <div class="progress" role="progressbar" aria-label="Progress" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100" style="height: 1px;">
    <div class="progress-bar" style="width: 50%"></div>
  </div>
  <button type="button" class="position-absolute top-0 start-0 translate-middle btn btn-sm btn-primary rounded-pill" style="width: 2rem; height:2rem;">1</button>
  <button type="button" class="position-absolute top-0 start-50 translate-middle btn btn-sm btn-primary rounded-pill" style="width: 2rem; height:2rem;">2</button>
  <button type="button" class="position-absolute top-0 start-100 translate-middle btn btn-sm btn-secondary rounded-pill" style="width: 2rem; height:2rem;">3</button>
</div>
```

## CSS

### Sass maps

Default position utility values are declared in a Sass map, then used to generate our utilities.

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$position-values: (
  0: 0,
  50: 50%,
  100: 100%
);
```

### Sass utilities API

Position utilities are declared in our utilities API in `scss/_utilities.scss`. [Learn how to use the utilities API.](/docs/5.3/utilities/api#using-the-api)

[scss/\_utilities.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_utilities.scss)

```html
"position": (
  property: position,
  values: static relative absolute fixed sticky
),
"top": (
  property: top,
  values: $position-values
),
"bottom": (
  property: bottom,
  values: $position-values
),
"start": (
  property: left,
  class: start,
  values: $position-values
),
"end": (
  property: right,
  class: end,
  values: $position-values
),
"translate-middle": (
  property: transform,
  class: translate-middle,
  values: (
    null: translate(-50%, -50%),
    x: translateX(-50%),
    y: translateY(-50%),
  )
),
```

