> Źródło: [https://getbootstrap.com/docs/5.3/components/offcanvas](https://getbootstrap.com/docs/5.3/components/offcanvas)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/components/offcanvas.mdx "View and edit this file on GitHub")

# Offcanvas

Build hidden sidebars into your project for navigation, shopping carts, and more with a few classes and our JavaScript plugin.

On this page
   
**On this page**

---

* [How it works](#how-it-works)
* [Examples](#examples)
  + [Offcanvas components](#offcanvas-components)
  + [Live demo](#live-demo)
  + [Body scrolling](#body-scrolling)
  + [Body scrolling and backdrop](#body-scrolling-and-backdrop)
  + [Static backdrop](#static-backdrop)
* [Dark offcanvas](#dark-offcanvas)
* [Responsive](#responsive)
* [Placement](#placement)
* [Accessibility](#accessibility)
* [CSS](#css)
  + [Variables](#variables)
  + [Sass variables](#sass-variables)
* [Usage](#usage)
  + [Via data attributes](#via-data-attributes)
    - [Toggle](#toggle)
    - [Dismiss](#dismiss)
  + [Via JavaScript](#via-javascript)
  + [Options](#options)
  + [Methods](#methods)
  + [Events](#events)

## How it works

Offcanvas is a sidebar component that can be toggled via JavaScript to appear from the left, right, top, or bottom edge of the viewport. Buttons or anchors are used as triggers that are attached to specific elements you toggle, and `data` attributes are used to invoke our JavaScript.

* Offcanvas shares some of the same JavaScript code as modals. Conceptually, they are quite similar, but they are separate plugins.
* Similarly, some [source Sass](#sass-variables) variables for offcanvas’s styles and dimensions are inherited from the modal’s variables.
* When shown, offcanvas includes a default backdrop that can be clicked to hide the offcanvas.
* Similar to modals, only one offcanvas can be shown at a time.

**Heads up!** Given how CSS handles animations, you cannot use `margin` or `translate` on an `.offcanvas` element. Instead, use the class as an independent wrapping element.

The animation effect of this component is dependent on the `prefers-reduced-motion` media query. See the [reduced motion section of our accessibility documentation](/docs/5.3/getting-started/accessibility/#reduced-motion).

## Examples

### Offcanvas components

Below is an offcanvas example that is shown by default (via `.show` on `.offcanvas`). Offcanvas includes support for a header with a close button and an optional body class for some initial `padding`. We suggest that you include offcanvas headers with dismiss actions whenever possible, or provide an explicit dismiss action.

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
     &lt;div aria-labelledby=&quot;offcanvasLabel&quot; class=&quot;offcanvas offcanvas-start show&quot; id=&quot;offcanvas&quot; tabindex=&quot;-1&quot;&gt;
&lt;div class=&quot;offcanvas-header&quot;&gt;
&lt;h5 class=&quot;offcanvas-title&quot; id=&quot;offcanvasLabel&quot;&gt;Offcanvas&lt;/h5&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;offcanvas&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;offcanvas-body&quot;&gt;
    Content for the offcanvas goes here. You can place just about any Bootstrap component or custom elements here.
  &lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="offcanvas offcanvas-start show" tabindex="-1" id="offcanvas" aria-labelledby="offcanvasLabel">
  <div class="offcanvas-header">
    <h5 class="offcanvas-title" id="offcanvasLabel">Offcanvas</h5>
    <button type="button" class="btn-close" data-bs-dismiss="offcanvas" aria-label="Close"></button>
  </div>
  <div class="offcanvas-body">
    Content for the offcanvas goes here. You can place just about any Bootstrap component or custom elements here.
  </div>
</div>
```

### Live demo

Use the buttons below to show and hide an offcanvas element via JavaScript that toggles the `.show` class on an element with the `.offcanvas` class.

* `.offcanvas` hides content (default)
* `.offcanvas.show` shows content

You can use a link with the `href` attribute, or a button with the `data-bs-target` attribute. In both cases, the `data-bs-toggle="offcanvas"` is required.

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
     &lt;a aria-controls=&quot;offcanvasExample&quot; class=&quot;btn btn-primary&quot; data-bs-toggle=&quot;offcanvas&quot; href=&quot;#offcanvasExample&quot; role=&quot;button&quot;&gt;
  Link with href
&lt;/a&gt;
&lt;button aria-controls=&quot;offcanvasExample&quot; class=&quot;btn btn-primary&quot; data-bs-target=&quot;#offcanvasExample&quot; data-bs-toggle=&quot;offcanvas&quot; type=&quot;button&quot;&gt;
  Button with data-bs-target
&lt;/button&gt;
&lt;div aria-labelledby=&quot;offcanvasExampleLabel&quot; class=&quot;offcanvas offcanvas-start&quot; id=&quot;offcanvasExample&quot; tabindex=&quot;-1&quot;&gt;
&lt;div class=&quot;offcanvas-header&quot;&gt;
&lt;h5 class=&quot;offcanvas-title&quot; id=&quot;offcanvasExampleLabel&quot;&gt;Offcanvas&lt;/h5&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;offcanvas&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;offcanvas-body&quot;&gt;
&lt;div&gt;
      Some text as placeholder. In real life you can have the elements you have chosen. Like, text, images, lists, etc.
    &lt;/div&gt;
&lt;div class=&quot;dropdown mt-3&quot;&gt;
&lt;button class=&quot;btn btn-secondary dropdown-toggle&quot; data-bs-toggle=&quot;dropdown&quot; type=&quot;button&quot;&gt;
        Dropdown button
      &lt;/button&gt;
&lt;ul class=&quot;dropdown-menu&quot;&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Another action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Something else here&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<a class="btn btn-primary" data-bs-toggle="offcanvas" href="#offcanvasExample" role="button" aria-controls="offcanvasExample">
  Link with href
</a>
<button class="btn btn-primary" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasExample" aria-controls="offcanvasExample">
  Button with data-bs-target
</button>

<div class="offcanvas offcanvas-start" tabindex="-1" id="offcanvasExample" aria-labelledby="offcanvasExampleLabel">
  <div class="offcanvas-header">
    <h5 class="offcanvas-title" id="offcanvasExampleLabel">Offcanvas</h5>
    <button type="button" class="btn-close" data-bs-dismiss="offcanvas" aria-label="Close"></button>
  </div>
  <div class="offcanvas-body">
    <div>
      Some text as placeholder. In real life you can have the elements you have chosen. Like, text, images, lists, etc.
    </div>
    <div class="dropdown mt-3">
      <button class="btn btn-secondary dropdown-toggle" type="button" data-bs-toggle="dropdown">
        Dropdown button
      </button>
      <ul class="dropdown-menu">
        <li><a class="dropdown-item" href="#">Action</a></li>
        <li><a class="dropdown-item" href="#">Another action</a></li>
        <li><a class="dropdown-item" href="#">Something else here</a></li>
      </ul>
    </div>
  </div>
</div>
```

### Body scrolling

Scrolling the `<body>` element is disabled when an offcanvas and its backdrop are visible. Use the `data-bs-scroll` attribute to enable `<body>` scrolling.

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
     &lt;button aria-controls=&quot;offcanvasScrolling&quot; class=&quot;btn btn-primary&quot; data-bs-target=&quot;#offcanvasScrolling&quot; data-bs-toggle=&quot;offcanvas&quot; type=&quot;button&quot;&gt;Enable body scrolling&lt;/button&gt;
&lt;div aria-labelledby=&quot;offcanvasScrollingLabel&quot; class=&quot;offcanvas offcanvas-start&quot; data-bs-backdrop=&quot;false&quot; data-bs-scroll=&quot;true&quot; id=&quot;offcanvasScrolling&quot; tabindex=&quot;-1&quot;&gt;
&lt;div class=&quot;offcanvas-header&quot;&gt;
&lt;h5 class=&quot;offcanvas-title&quot; id=&quot;offcanvasScrollingLabel&quot;&gt;Offcanvas with body scrolling&lt;/h5&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;offcanvas&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;offcanvas-body&quot;&gt;
&lt;p&gt;Try scrolling the rest of the page to see this option in action.&lt;/p&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<button class="btn btn-primary" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasScrolling" aria-controls="offcanvasScrolling">Enable body scrolling</button>

<div class="offcanvas offcanvas-start" data-bs-scroll="true" data-bs-backdrop="false" tabindex="-1" id="offcanvasScrolling" aria-labelledby="offcanvasScrollingLabel">
  <div class="offcanvas-header">
    <h5 class="offcanvas-title" id="offcanvasScrollingLabel">Offcanvas with body scrolling</h5>
    <button type="button" class="btn-close" data-bs-dismiss="offcanvas" aria-label="Close"></button>
  </div>
  <div class="offcanvas-body">
    <p>Try scrolling the rest of the page to see this option in action.</p>
  </div>
</div>
```

### Body scrolling and backdrop

You can also enable `<body>` scrolling with a visible backdrop.

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
     &lt;button aria-controls=&quot;offcanvasWithBothOptions&quot; class=&quot;btn btn-primary&quot; data-bs-target=&quot;#offcanvasWithBothOptions&quot; data-bs-toggle=&quot;offcanvas&quot; type=&quot;button&quot;&gt;Enable both scrolling &amp;amp; backdrop&lt;/button&gt;
&lt;div aria-labelledby=&quot;offcanvasWithBothOptionsLabel&quot; class=&quot;offcanvas offcanvas-start&quot; data-bs-scroll=&quot;true&quot; id=&quot;offcanvasWithBothOptions&quot; tabindex=&quot;-1&quot;&gt;
&lt;div class=&quot;offcanvas-header&quot;&gt;
&lt;h5 class=&quot;offcanvas-title&quot; id=&quot;offcanvasWithBothOptionsLabel&quot;&gt;Backdrop with scrolling&lt;/h5&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;offcanvas&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;offcanvas-body&quot;&gt;
&lt;p&gt;Try scrolling the rest of the page to see this option in action.&lt;/p&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<button class="btn btn-primary" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasWithBothOptions" aria-controls="offcanvasWithBothOptions">Enable both scrolling & backdrop</button>

<div class="offcanvas offcanvas-start" data-bs-scroll="true" tabindex="-1" id="offcanvasWithBothOptions" aria-labelledby="offcanvasWithBothOptionsLabel">
  <div class="offcanvas-header">
    <h5 class="offcanvas-title" id="offcanvasWithBothOptionsLabel">Backdrop with scrolling</h5>
    <button type="button" class="btn-close" data-bs-dismiss="offcanvas" aria-label="Close"></button>
  </div>
  <div class="offcanvas-body">
    <p>Try scrolling the rest of the page to see this option in action.</p>
  </div>
</div>
```

### Static backdrop

When backdrop is set to static, the offcanvas will not close when clicking outside of it.

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
     &lt;button aria-controls=&quot;staticBackdrop&quot; class=&quot;btn btn-primary&quot; data-bs-target=&quot;#staticBackdrop&quot; data-bs-toggle=&quot;offcanvas&quot; type=&quot;button&quot;&gt;
  Toggle static offcanvas
&lt;/button&gt;
&lt;div aria-labelledby=&quot;staticBackdropLabel&quot; class=&quot;offcanvas offcanvas-start&quot; data-bs-backdrop=&quot;static&quot; id=&quot;staticBackdrop&quot; tabindex=&quot;-1&quot;&gt;
&lt;div class=&quot;offcanvas-header&quot;&gt;
&lt;h5 class=&quot;offcanvas-title&quot; id=&quot;staticBackdropLabel&quot;&gt;Offcanvas&lt;/h5&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;offcanvas&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;offcanvas-body&quot;&gt;
&lt;div&gt;
      I will not close if you click outside of me.
    &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<button class="btn btn-primary" type="button" data-bs-toggle="offcanvas" data-bs-target="#staticBackdrop" aria-controls="staticBackdrop">
  Toggle static offcanvas
</button>

<div class="offcanvas offcanvas-start" data-bs-backdrop="static" tabindex="-1" id="staticBackdrop" aria-labelledby="staticBackdropLabel">
  <div class="offcanvas-header">
    <h5 class="offcanvas-title" id="staticBackdropLabel">Offcanvas</h5>
    <button type="button" class="btn-close" data-bs-dismiss="offcanvas" aria-label="Close"></button>
  </div>
  <div class="offcanvas-body">
    <div>
      I will not close if you click outside of me.
    </div>
  </div>
</div>
```

## Dark offcanvas

Deprecated in v5.3.0 
Added in v5.2.0

Change the appearance of offcanvases with utilities to better match them to different contexts like dark navbars. Here we add `.text-bg-dark` to the `.offcanvas` and `.btn-close-white` to `.btn-close` for proper styling with a dark offcanvas. If you have dropdowns within, consider also adding `.dropdown-menu-dark` to `.dropdown-menu`.

**Heads up!** Dark variants for components were deprecated in v5.3.0 with the introduction of color modes. Instead of manually adding classes mentioned above, set `data-bs-theme="dark"` on the root element, a parent wrapper, or the component itself.

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
     &lt;div aria-labelledby=&quot;offcanvasDarkLabel&quot; class=&quot;offcanvas offcanvas-start show text-bg-dark&quot; id=&quot;offcanvasDark&quot; tabindex=&quot;-1&quot;&gt;
&lt;div class=&quot;offcanvas-header&quot;&gt;
&lt;h5 class=&quot;offcanvas-title&quot; id=&quot;offcanvasDarkLabel&quot;&gt;Offcanvas&lt;/h5&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close btn-close-white&quot; data-bs-dismiss=&quot;offcanvasDark&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;offcanvas-body&quot;&gt;
&lt;p&gt;Place offcanvas content here.&lt;/p&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="offcanvas offcanvas-start show text-bg-dark" tabindex="-1" id="offcanvasDark" aria-labelledby="offcanvasDarkLabel">
  <div class="offcanvas-header">
    <h5 class="offcanvas-title" id="offcanvasDarkLabel">Offcanvas</h5>
    <button type="button" class="btn-close btn-close-white" data-bs-dismiss="offcanvasDark" aria-label="Close"></button>
  </div>
  <div class="offcanvas-body">
    <p>Place offcanvas content here.</p>
  </div>
</div>
```

## Responsive

Added in v5.2.0

Responsive offcanvas classes hide content outside the viewport from a specified breakpoint and down. Above that breakpoint, the contents within will behave as usual. For example, `.offcanvas-lg` hides content in an offcanvas below the `lg` breakpoint, but shows the content above the `lg` breakpoint. Responsive offcanvas classes are available for each breakpoint.

* `.offcanvas`
* `.offcanvas-sm`
* `.offcanvas-md`
* `.offcanvas-lg`
* `.offcanvas-xl`
* `.offcanvas-xxl`

To make a responsive offcanvas, replace the `.offcanvas` base class with a responsive variant and ensure your close button has an explicit `data-bs-target`.

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
     &lt;button aria-controls=&quot;offcanvasResponsive&quot; class=&quot;btn btn-primary d-lg-none&quot; data-bs-target=&quot;#offcanvasResponsive&quot; data-bs-toggle=&quot;offcanvas&quot; type=&quot;button&quot;&gt;Toggle offcanvas&lt;/button&gt;
&lt;div class=&quot;alert alert-info d-none d-lg-block&quot;&gt;Resize your browser to show the responsive offcanvas toggle.&lt;/div&gt;
&lt;div aria-labelledby=&quot;offcanvasResponsiveLabel&quot; class=&quot;offcanvas-lg offcanvas-end&quot; id=&quot;offcanvasResponsive&quot; tabindex=&quot;-1&quot;&gt;
&lt;div class=&quot;offcanvas-header&quot;&gt;
&lt;h5 class=&quot;offcanvas-title&quot; id=&quot;offcanvasResponsiveLabel&quot;&gt;Responsive offcanvas&lt;/h5&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;offcanvas&quot; data-bs-target=&quot;#offcanvasResponsive&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;offcanvas-body&quot;&gt;
&lt;p class=&quot;mb-0&quot;&gt;This is content within an &lt;code&gt;.offcanvas-lg&lt;/code&gt;.&lt;/p&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<button class="btn btn-primary d-lg-none" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasResponsive" aria-controls="offcanvasResponsive">Toggle offcanvas</button>

<div class="alert alert-info d-none d-lg-block">Resize your browser to show the responsive offcanvas toggle.</div>

<div class="offcanvas-lg offcanvas-end" tabindex="-1" id="offcanvasResponsive" aria-labelledby="offcanvasResponsiveLabel">
  <div class="offcanvas-header">
    <h5 class="offcanvas-title" id="offcanvasResponsiveLabel">Responsive offcanvas</h5>
    <button type="button" class="btn-close" data-bs-dismiss="offcanvas" data-bs-target="#offcanvasResponsive" aria-label="Close"></button>
  </div>
  <div class="offcanvas-body">
    <p class="mb-0">This is content within an <code>.offcanvas-lg</code>.</p>
  </div>
</div>
```

## Placement

There’s no default placement for offcanvas components, so you must add one of the modifier classes below.

* `.offcanvas-start` places offcanvas on the left of the viewport (shown above)
* `.offcanvas-end` places offcanvas on the right of the viewport
* `.offcanvas-top` places offcanvas on the top of the viewport
* `.offcanvas-bottom` places offcanvas on the bottom of the viewport

Try the top, right, and bottom examples out below.

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
     &lt;button aria-controls=&quot;offcanvasTop&quot; class=&quot;btn btn-primary&quot; data-bs-target=&quot;#offcanvasTop&quot; data-bs-toggle=&quot;offcanvas&quot; type=&quot;button&quot;&gt;Toggle top offcanvas&lt;/button&gt;
&lt;div aria-labelledby=&quot;offcanvasTopLabel&quot; class=&quot;offcanvas offcanvas-top&quot; id=&quot;offcanvasTop&quot; tabindex=&quot;-1&quot;&gt;
&lt;div class=&quot;offcanvas-header&quot;&gt;
&lt;h5 class=&quot;offcanvas-title&quot; id=&quot;offcanvasTopLabel&quot;&gt;Offcanvas top&lt;/h5&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;offcanvas&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;offcanvas-body&quot;&gt;
    ...
  &lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<button class="btn btn-primary" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasTop" aria-controls="offcanvasTop">Toggle top offcanvas</button>

<div class="offcanvas offcanvas-top" tabindex="-1" id="offcanvasTop" aria-labelledby="offcanvasTopLabel">
  <div class="offcanvas-header">
    <h5 class="offcanvas-title" id="offcanvasTopLabel">Offcanvas top</h5>
    <button type="button" class="btn-close" data-bs-dismiss="offcanvas" aria-label="Close"></button>
  </div>
  <div class="offcanvas-body">
    ...
  </div>
</div>
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
     &lt;button aria-controls=&quot;offcanvasRight&quot; class=&quot;btn btn-primary&quot; data-bs-target=&quot;#offcanvasRight&quot; data-bs-toggle=&quot;offcanvas&quot; type=&quot;button&quot;&gt;Toggle right offcanvas&lt;/button&gt;
&lt;div aria-labelledby=&quot;offcanvasRightLabel&quot; class=&quot;offcanvas offcanvas-end&quot; id=&quot;offcanvasRight&quot; tabindex=&quot;-1&quot;&gt;
&lt;div class=&quot;offcanvas-header&quot;&gt;
&lt;h5 class=&quot;offcanvas-title&quot; id=&quot;offcanvasRightLabel&quot;&gt;Offcanvas right&lt;/h5&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;offcanvas&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;offcanvas-body&quot;&gt;
    ...
  &lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<button class="btn btn-primary" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasRight" aria-controls="offcanvasRight">Toggle right offcanvas</button>

<div class="offcanvas offcanvas-end" tabindex="-1" id="offcanvasRight" aria-labelledby="offcanvasRightLabel">
  <div class="offcanvas-header">
    <h5 class="offcanvas-title" id="offcanvasRightLabel">Offcanvas right</h5>
    <button type="button" class="btn-close" data-bs-dismiss="offcanvas" aria-label="Close"></button>
  </div>
  <div class="offcanvas-body">
    ...
  </div>
</div>
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
     &lt;button aria-controls=&quot;offcanvasBottom&quot; class=&quot;btn btn-primary&quot; data-bs-target=&quot;#offcanvasBottom&quot; data-bs-toggle=&quot;offcanvas&quot; type=&quot;button&quot;&gt;Toggle bottom offcanvas&lt;/button&gt;
&lt;div aria-labelledby=&quot;offcanvasBottomLabel&quot; class=&quot;offcanvas offcanvas-bottom&quot; id=&quot;offcanvasBottom&quot; tabindex=&quot;-1&quot;&gt;
&lt;div class=&quot;offcanvas-header&quot;&gt;
&lt;h5 class=&quot;offcanvas-title&quot; id=&quot;offcanvasBottomLabel&quot;&gt;Offcanvas bottom&lt;/h5&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;offcanvas&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;offcanvas-body small&quot;&gt;
    ...
  &lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<button class="btn btn-primary" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasBottom" aria-controls="offcanvasBottom">Toggle bottom offcanvas</button>

<div class="offcanvas offcanvas-bottom" tabindex="-1" id="offcanvasBottom" aria-labelledby="offcanvasBottomLabel">
  <div class="offcanvas-header">
    <h5 class="offcanvas-title" id="offcanvasBottomLabel">Offcanvas bottom</h5>
    <button type="button" class="btn-close" data-bs-dismiss="offcanvas" aria-label="Close"></button>
  </div>
  <div class="offcanvas-body small">
    ...
  </div>
</div>
```

## Accessibility

Since the offcanvas panel is conceptually a modal dialog, be sure to add `aria-labelledby="..."`—referencing the offcanvas title—to `.offcanvas`. Note that you don’t need to add `role="dialog"` since we already add it via JavaScript.

## CSS

### Variables

Added in v5.2.0

As part of Bootstrap’s evolving CSS variables approach, offcanvas now uses local CSS variables on `.offcanvas` for enhanced real-time customization. Values for the CSS variables are set via Sass, so Sass customization is still supported, too.

[scss/\_offcanvas.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_offcanvas.scss)

```html
--#{$prefix}offcanvas-zindex: #{$zindex-offcanvas};
--#{$prefix}offcanvas-width: #{$offcanvas-horizontal-width};
--#{$prefix}offcanvas-height: #{$offcanvas-vertical-height};
--#{$prefix}offcanvas-padding-x: #{$offcanvas-padding-x};
--#{$prefix}offcanvas-padding-y: #{$offcanvas-padding-y};
--#{$prefix}offcanvas-color: #{$offcanvas-color};
--#{$prefix}offcanvas-bg: #{$offcanvas-bg-color};
--#{$prefix}offcanvas-border-width: #{$offcanvas-border-width};
--#{$prefix}offcanvas-border-color: #{$offcanvas-border-color};
--#{$prefix}offcanvas-box-shadow: #{$offcanvas-box-shadow};
--#{$prefix}offcanvas-transition: #{transform $offcanvas-transition-duration ease-in-out};
--#{$prefix}offcanvas-title-line-height: #{$offcanvas-title-line-height};
```

### Sass variables

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$offcanvas-padding-y:               $modal-inner-padding;
$offcanvas-padding-x:               $modal-inner-padding;
$offcanvas-horizontal-width:        400px;
$offcanvas-vertical-height:         30vh;
$offcanvas-transition-duration:     .3s;
$offcanvas-border-color:            $modal-content-border-color;
$offcanvas-border-width:            $modal-content-border-width;
$offcanvas-title-line-height:       $modal-title-line-height;
$offcanvas-bg-color:                var(--#{$prefix}body-bg);
$offcanvas-color:                   var(--#{$prefix}body-color);
$offcanvas-box-shadow:              $modal-content-box-shadow-xs;
$offcanvas-backdrop-bg:             $modal-backdrop-bg;
$offcanvas-backdrop-opacity:        $modal-backdrop-opacity;
```

## Usage

The offcanvas plugin utilizes a few classes and attributes to handle the heavy lifting:

* `.offcanvas` hides the content
* `.offcanvas.show` shows the content
* `.offcanvas-start` hides the offcanvas on the left
* `.offcanvas-end` hides the offcanvas on the right
* `.offcanvas-top` hides the offcanvas on the top
* `.offcanvas-bottom` hides the offcanvas on the bottom

Add a dismiss button with the `data-bs-dismiss="offcanvas"` attribute, which triggers the JavaScript functionality. Be sure to use the `<button>` element with it for proper behavior across all devices.

### Via data attributes

#### Toggle

Add `data-bs-toggle="offcanvas"` and a `data-bs-target` or `href` to the element to automatically assign control of one offcanvas element. The `data-bs-target` attribute accepts a CSS selector to apply the offcanvas to. Be sure to add the class `offcanvas` to the offcanvas element. If you’d like it to default open, add the additional class `show`.

#### Dismiss

Dismissal can be achieved with the `data-bs-dismiss` attribute on a button **within the offcanvas** as demonstrated below:

```html
<button type="button" class="btn-close" data-bs-dismiss="offcanvas" aria-label="Close"></button>
```

or on a button **outside the offcanvas** using the additional `data-bs-target` as demonstrated below:

```html
<button type="button" class="btn-close" data-bs-dismiss="offcanvas" data-bs-target="#my-offcanvas" aria-label="Close"></button>
```

While both ways to dismiss an offcanvas are supported, keep in mind that dismissing from outside an offcanvas does not match the [ARIA Authoring Practices Guide dialog (modal) pattern](https://www.w3.org/WAI/ARIA/apg/patterns/dialogmodal/). Do this at your own risk.

### Via JavaScript

Enable manually with:

```html
const offcanvasElementList = document.querySelectorAll('.offcanvas')
const offcanvasList = [...offcanvasElementList].map(offcanvasEl => new bootstrap.Offcanvas(offcanvasEl))
```

### Options

As options can be passed via data attributes or JavaScript, you can append an option name to `data-bs-`, as in `data-bs-animation="{value}"`. Make sure to change the case type of the option name from “*camelCase*” to “*kebab-case*” when passing the options via data attributes. For example, use `data-bs-custom-class="beautifier"` instead of `data-bs-customClass="beautifier"`.

As of Bootstrap 5.2.0, all components support an **experimental** reserved data attribute `data-bs-config` that can house simple component configuration as a JSON string. When an element has `data-bs-config='{"delay":0, "title":123}'` and `data-bs-title="456"` attributes, the final `title` value will be `456` and the separate data attributes will override values given on `data-bs-config`. In addition, existing data attributes are able to house JSON values like `data-bs-delay='{"show":0,"hide":150}'`.

The final configuration object is the merged result of `data-bs-config`, `data-bs-`, and `js object` where the latest given key-value overrides the others.

| Name | Type | Default | Description |
| --- | --- | --- | --- |
| `backdrop` | boolean or the string `static` | `true` | Apply a backdrop on body while offcanvas is open. Alternatively, specify `static` for a backdrop which doesn’t close the offcanvas when clicked. |
| `keyboard` | boolean | `true` | Closes the offcanvas when escape key is pressed. |
| `scroll` | boolean | `false` | Allow body scrolling while offcanvas is open. |

### Methods

**All API methods are asynchronous and start a transition.** They return to the caller as soon as the transition is started, but before it ends. In addition, a method call on a transitioning component will be ignored. [Learn more in our JavaScript docs.](/docs/5.3/getting-started/javascript/#asynchronous-functions-and-transitions)

Activates your content as an offcanvas element. Accepts an optional options `object`.

You can create an offcanvas instance with the constructor, for example:

```html
const bsOffcanvas = new bootstrap.Offcanvas('#myOffcanvas')
```

| Method | Description |
| --- | --- |
| `dispose` | Destroys an element’s offcanvas. |
| `getInstance` | *Static* method which allows you to get the offcanvas instance associated with a DOM element. |
| `getOrCreateInstance` | *Static* method which allows you to get the offcanvas instance associated with a DOM element, or create a new one in case it wasn’t initialized. |
| `hide` | Hides an offcanvas element. **Returns to the caller before the offcanvas element has actually been hidden** (i.e. before the `hidden.bs.offcanvas` event occurs). |
| `show` | Shows an offcanvas element. **Returns to the caller before the offcanvas element has actually been shown** (i.e. before the `shown.bs.offcanvas` event occurs). |
| `toggle` | Toggles an offcanvas element to shown or hidden. **Returns to the caller before the offcanvas element has actually been shown or hidden** (i.e. before the `shown.bs.offcanvas` or `hidden.bs.offcanvas` event occurs). |

### Events

Bootstrap’s offcanvas class exposes a few events for hooking into offcanvas functionality.

| Event type | Description |
| --- | --- |
| `hide.bs.offcanvas` | This event is fired immediately when the `hide` method has been called. |
| `hidden.bs.offcanvas` | This event is fired when an offcanvas element has been hidden from the user (will wait for CSS transitions to complete). |
| `hidePrevented.bs.offcanvas` | This event is fired when the offcanvas is shown, its backdrop is `static` and a click outside of the offcanvas is performed. The event is also fired when the escape key is pressed and the `keyboard` option is set to `false`. |
| `show.bs.offcanvas` | This event fires immediately when the `show` instance method is called. |
| `shown.bs.offcanvas` | This event is fired when an offcanvas element has been made visible to the user (will wait for CSS transitions to complete). |

```html
const myOffcanvas = document.getElementById('myOffcanvas')
myOffcanvas.addEventListener('hidden.bs.offcanvas', event => {
  // do something...
})
```

