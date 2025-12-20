> Źródło: [https://getbootstrap.com/docs/5.3/components/collapse](https://getbootstrap.com/docs/5.3/components/collapse)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/components/collapse.mdx "View and edit this file on GitHub")

# Collapse

Toggle the visibility of content across your project with a few classes and our JavaScript plugins.

On this page
   
**On this page**

---

* [How it works](#how-it-works)
* [Example](#example)
* [Horizontal](#horizontal)
* [Multiple toggles and targets](#multiple-toggles-and-targets)
* [Accessibility](#accessibility)
* [CSS](#css)
  + [Sass variables](#sass-variables)
  + [Classes](#classes)
* [Usage](#usage)
  + [Via data attributes](#via-data-attributes)
  + [Via JavaScript](#via-javascript)
  + [Options](#options)
  + [Methods](#methods)
  + [Events](#events)

## How it works

The collapse JavaScript plugin is used to show and hide content. Buttons or anchors are used as triggers that are mapped to specific elements you toggle. Collapsing an element will animate the `height` from its current value to `0`. Given how CSS handles animations, you cannot use `padding` on a `.collapse` element. Instead, use the class as an independent wrapping element.

The animation effect of this component is dependent on the `prefers-reduced-motion` media query. See the [reduced motion section of our accessibility documentation](/docs/5.3/getting-started/accessibility/#reduced-motion).

## Example

Click the buttons below to show and hide another element via class changes:

* `.collapse` hides content
* `.collapsing` is applied during transitions
* `.collapse.show` shows content

Generally, we recommend using a `<button>` with the `data-bs-target` attribute. While not recommended from a semantic point of view, you can also use an `<a>` link with the `href` attribute (and a `role="button"`). In both cases, the `data-bs-toggle="collapse"` is required.

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
     &lt;p class=&quot;d-inline-flex gap-1&quot;&gt;
&lt;a aria-controls=&quot;collapseExample&quot; aria-expanded=&quot;false&quot; class=&quot;btn btn-primary&quot; data-bs-toggle=&quot;collapse&quot; href=&quot;#collapseExample&quot; role=&quot;button&quot;&gt;
    Link with href
  &lt;/a&gt;
&lt;button aria-controls=&quot;collapseExample&quot; aria-expanded=&quot;false&quot; class=&quot;btn btn-primary&quot; data-bs-target=&quot;#collapseExample&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
    Button with data-bs-target
  &lt;/button&gt;
&lt;/p&gt;
&lt;div class=&quot;collapse&quot; id=&quot;collapseExample&quot;&gt;
&lt;div class=&quot;card card-body&quot;&gt;
    Some placeholder content for the collapse component. This panel is hidden by default but revealed when the user activates the relevant trigger.
  &lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<p class="d-inline-flex gap-1">
  <a class="btn btn-primary" data-bs-toggle="collapse" href="#collapseExample" role="button" aria-expanded="false" aria-controls="collapseExample">
    Link with href
  </a>
  <button class="btn btn-primary" type="button" data-bs-toggle="collapse" data-bs-target="#collapseExample" aria-expanded="false" aria-controls="collapseExample">
    Button with data-bs-target
  </button>
</p>
<div class="collapse" id="collapseExample">
  <div class="card card-body">
    Some placeholder content for the collapse component. This panel is hidden by default but revealed when the user activates the relevant trigger.
  </div>
</div>
```

## Horizontal

The collapse plugin supports horizontal collapsing. Add the `.collapse-horizontal` modifier class to transition the `width` instead of `height` and set a `width` on the immediate child element. Feel free to write your own custom Sass, use inline styles, or use our [width utilities](/docs/5.3/utilities/sizing).

Please note that while the example below has a `min-height` set to avoid excessive repaints in our docs, this is not explicitly required. **Only the `width` on the child element is required.**

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
     &lt;p&gt;
&lt;button aria-controls=&quot;collapseWidthExample&quot; aria-expanded=&quot;false&quot; class=&quot;btn btn-primary&quot; data-bs-target=&quot;#collapseWidthExample&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
    Toggle width collapse
  &lt;/button&gt;
&lt;/p&gt;
&lt;div style=&quot;min-height: 120px;&quot;&gt;
&lt;div class=&quot;collapse collapse-horizontal&quot; id=&quot;collapseWidthExample&quot;&gt;
&lt;div class=&quot;card card-body&quot; style=&quot;width: 300px;&quot;&gt;
      This is some placeholder content for a horizontal collapse. It’s hidden by default and shown when triggered.
    &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<p>
  <button class="btn btn-primary" type="button" data-bs-toggle="collapse" data-bs-target="#collapseWidthExample" aria-expanded="false" aria-controls="collapseWidthExample">
    Toggle width collapse
  </button>
</p>
<div style="min-height: 120px;">
  <div class="collapse collapse-horizontal" id="collapseWidthExample">
    <div class="card card-body" style="width: 300px;">
      This is some placeholder content for a horizontal collapse. It’s hidden by default and shown when triggered.
    </div>
  </div>
</div>
```

## Multiple toggles and targets

A `<button>` or `<a>` element can show and hide multiple elements by referencing them with a selector in its `data-bs-target` or `href` attribute.
Conversely, multiple `<button>` or `<a>` elements can show and hide the same element if they each reference it with their `data-bs-target` or `href` attribute.

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
     &lt;p class=&quot;d-inline-flex gap-1&quot;&gt;
&lt;a aria-controls=&quot;multiCollapseExample1&quot; aria-expanded=&quot;false&quot; class=&quot;btn btn-primary&quot; data-bs-toggle=&quot;collapse&quot; href=&quot;#multiCollapseExample1&quot; role=&quot;button&quot;&gt;Toggle first element&lt;/a&gt;
&lt;button aria-controls=&quot;multiCollapseExample2&quot; aria-expanded=&quot;false&quot; class=&quot;btn btn-primary&quot; data-bs-target=&quot;#multiCollapseExample2&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;Toggle second element&lt;/button&gt;
&lt;button aria-controls=&quot;multiCollapseExample1 multiCollapseExample2&quot; aria-expanded=&quot;false&quot; class=&quot;btn btn-primary&quot; data-bs-target=&quot;.multi-collapse&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;Toggle both elements&lt;/button&gt;
&lt;/p&gt;
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col&quot;&gt;
&lt;div class=&quot;collapse multi-collapse&quot; id=&quot;multiCollapseExample1&quot;&gt;
&lt;div class=&quot;card card-body&quot;&gt;
        Some placeholder content for the first collapse component of this multi-collapse example. This panel is hidden by default but revealed when the user activates the relevant trigger.
      &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col&quot;&gt;
&lt;div class=&quot;collapse multi-collapse&quot; id=&quot;multiCollapseExample2&quot;&gt;
&lt;div class=&quot;card card-body&quot;&gt;
        Some placeholder content for the second collapse component of this multi-collapse example. This panel is hidden by default but revealed when the user activates the relevant trigger.
      &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<p class="d-inline-flex gap-1">
  <a class="btn btn-primary" data-bs-toggle="collapse" href="#multiCollapseExample1" role="button" aria-expanded="false" aria-controls="multiCollapseExample1">Toggle first element</a>
  <button class="btn btn-primary" type="button" data-bs-toggle="collapse" data-bs-target="#multiCollapseExample2" aria-expanded="false" aria-controls="multiCollapseExample2">Toggle second element</button>
  <button class="btn btn-primary" type="button" data-bs-toggle="collapse" data-bs-target=".multi-collapse" aria-expanded="false" aria-controls="multiCollapseExample1 multiCollapseExample2">Toggle both elements</button>
</p>
<div class="row">
  <div class="col">
    <div class="collapse multi-collapse" id="multiCollapseExample1">
      <div class="card card-body">
        Some placeholder content for the first collapse component of this multi-collapse example. This panel is hidden by default but revealed when the user activates the relevant trigger.
      </div>
    </div>
  </div>
  <div class="col">
    <div class="collapse multi-collapse" id="multiCollapseExample2">
      <div class="card card-body">
        Some placeholder content for the second collapse component of this multi-collapse example. This panel is hidden by default but revealed when the user activates the relevant trigger.
      </div>
    </div>
  </div>
</div>
```

## Accessibility

Be sure to add `aria-expanded` to the control element. This attribute explicitly conveys the current state of the collapsible element tied to the control to screen readers and similar assistive technologies. If the collapsible element is closed by default, the attribute on the control element should have a value of `aria-expanded="false"`. If you’ve set the collapsible element to be open by default using the `show` class, set `aria-expanded="true"` on the control instead. The plugin will automatically toggle this attribute on the control based on whether or not the collapsible element has been opened or closed (via JavaScript, or because the user triggered another control element also tied to the same collapsible element). If the control element’s HTML element is not a button (e.g., an `<a>` or `<div>`), the attribute `role="button"` should be added to the element.

If your control element is targeting a single collapsible element – i.e. the `data-bs-target` attribute is pointing to an `id` selector – you should add the `aria-controls` attribute to the control element, containing the `id` of the collapsible element. Modern screen readers and similar assistive technologies make use of this attribute to provide users with additional shortcuts to navigate directly to the collapsible element itself.

Note that Bootstrap’s current implementation does not cover the various *optional* keyboard interactions described in the [ARIA Authoring Practices Guide accordion pattern](https://www.w3.org/WAI/ARIA/apg/patterns/accordion/) - you will need to include these yourself with custom JavaScript.

## CSS

### Sass variables

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$transition-collapse:         height .35s ease;
$transition-collapse-width:   width .35s ease;
```

### Classes

Collapse transition classes can be found in `scss/_transitions.scss` as these are shared across multiple components (collapse and accordion).

[scss/\_transitions.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_transitions.scss)

```html
.collapse {
  &:not(.show) {
    display: none;
  }
}

.collapsing {
  height: 0;
  overflow: hidden;
  @include transition($transition-collapse);

  &.collapse-horizontal {
    width: 0;
    height: auto;
    @include transition($transition-collapse-width);
  }
}
```

## Usage

The collapse plugin utilizes a few classes to handle the heavy lifting:

* `.collapse` hides the content
* `.collapse.show` shows the content
* `.collapsing` is added when the transition starts, and removed when it finishes

These classes can be found in `_transitions.scss`.

### Via data attributes

Just add `data-bs-toggle="collapse"` and a `data-bs-target` to the element to automatically assign control of one or more collapsible elements. The `data-bs-target` attribute accepts a CSS selector to apply the collapse to. Be sure to add the class `collapse` to the collapsible element. If you’d like it to default open, add the additional class `show`.

To add accordion-like group management to a collapsible area, add the data attribute `data-bs-parent="#selector"`. Refer to the [accordion page](/docs/5.3/components/accordion) for more information.

### Via JavaScript

Enable manually with:

```html
const collapseElementList = document.querySelectorAll('.collapse')
const collapseList = [...collapseElementList].map(collapseEl => new bootstrap.Collapse(collapseEl))
```

### Options

As options can be passed via data attributes or JavaScript, you can append an option name to `data-bs-`, as in `data-bs-animation="{value}"`. Make sure to change the case type of the option name from “*camelCase*” to “*kebab-case*” when passing the options via data attributes. For example, use `data-bs-custom-class="beautifier"` instead of `data-bs-customClass="beautifier"`.

As of Bootstrap 5.2.0, all components support an **experimental** reserved data attribute `data-bs-config` that can house simple component configuration as a JSON string. When an element has `data-bs-config='{"delay":0, "title":123}'` and `data-bs-title="456"` attributes, the final `title` value will be `456` and the separate data attributes will override values given on `data-bs-config`. In addition, existing data attributes are able to house JSON values like `data-bs-delay='{"show":0,"hide":150}'`.

The final configuration object is the merged result of `data-bs-config`, `data-bs-`, and `js object` where the latest given key-value overrides the others.

| Name | Type | Default | Description |
| --- | --- | --- | --- |
| `parent` | selector, DOM element | `null` | If parent is provided, then all collapsible elements under the specified parent will be closed when this collapsible item is shown. (similar to traditional accordion behavior - this is dependent on the `card` class). The attribute has to be set on the target collapsible area. |
| `toggle` | boolean | `true` | Toggles the collapsible element on invocation. |

### Methods

**All API methods are asynchronous and start a transition.** They return to the caller as soon as the transition is started, but before it ends. In addition, a method call on a transitioning component will be ignored. [Learn more in our JavaScript docs.](/docs/5.3/getting-started/javascript/#asynchronous-functions-and-transitions)

Activates your content as a collapsible element. Accepts an optional options `object`.

You can create a collapse instance with the constructor, for example:

```html
const bsCollapse = new bootstrap.Collapse('#myCollapse', {
  toggle: false
})
```

| Method | Description |
| --- | --- |
| `dispose` | Destroys an element’s collapse. (Removes stored data on the DOM element) |
| `getInstance` | Static method which allows you to get the collapse instance associated to a DOM element, you can use it like this: `bootstrap.Collapse.getInstance(element)`. |
| `getOrCreateInstance` | Static method which returns a collapse instance associated to a DOM element or create a new one in case it wasn’t initialized. You can use it like this: `bootstrap.Collapse.getOrCreateInstance(element)`. |
| `hide` | Hides a collapsible element. **Returns to the caller before the collapsible element has actually been hidden** (e.g., before the `hidden.bs.collapse` event occurs). |
| `show` | Shows a collapsible element. **Returns to the caller before the collapsible element has actually been shown** (e.g., before the `shown.bs.collapse` event occurs). |
| `toggle` | Toggles a collapsible element to shown or hidden. **Returns to the caller before the collapsible element has actually been shown or hidden** (i.e. before the `shown.bs.collapse` or `hidden.bs.collapse` event occurs). |

### Events

Bootstrap’s collapse class exposes a few events for hooking into collapse functionality.

| Event type | Description |
| --- | --- |
| `hide.bs.collapse` | This event is fired immediately when the `hide` method has been called. |
| `hidden.bs.collapse` | This event is fired when a collapse element has been hidden from the user (will wait for CSS transitions to complete). |
| `show.bs.collapse` | This event fires immediately when the `show` instance method is called. |
| `shown.bs.collapse` | This event is fired when a collapse element has been made visible to the user (will wait for CSS transitions to complete). |

```html
const myCollapsible = document.getElementById('myCollapsible')
myCollapsible.addEventListener('hidden.bs.collapse', event => {
  // do something...
})
```

