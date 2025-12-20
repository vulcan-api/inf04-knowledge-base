> Źródło: [https://getbootstrap.com/docs/5.3/components/popovers](https://getbootstrap.com/docs/5.3/components/popovers)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/components/popovers.mdx "View and edit this file on GitHub")

# Popovers

Documentation and examples for adding Bootstrap popovers, like those found in iOS, to any element on your site.

On this page
   
**On this page**

---

* [Overview](#overview)
* [Examples](#examples)
  + [Enable popovers](#enable-popovers)
  + [Live demo](#live-demo)
  + [Four directions](#four-directions)
  + [Custom container](#custom-container)
  + [Custom popovers](#custom-popovers)
  + [Dismiss on next click](#dismiss-on-next-click)
  + [Disabled elements](#disabled-elements)
* [CSS](#css)
  + [Variables](#variables)
  + [Sass variables](#sass-variables)
* [Usage](#usage)
  + [Options](#options)
    - [Data attributes for individual popovers](#data-attributes-for-individual-popovers)
    - [Using function with popperConfig](#using-function-with-popperconfig)
  + [Methods](#methods)
  + [Events](#events)

## Overview

Things to know when using the popover plugin:

* Popovers rely on the third party library [Popper](https://popper.js.org/docs/v2/) for positioning. You must include [popper.min.js](https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js) before `bootstrap.js`, or use one `bootstrap.bundle.min.js` which contains Popper.
* Popovers require the [popover plugin](/docs/5.3/components/popovers) as a dependency.
* Popovers are opt-in for performance reasons, so **you must initialize them yourself**.
* Zero-length `title` and `content` values will never show a popover.
* Specify `container: 'body'` to avoid rendering problems in more complex components (like our input groups, button groups, etc).
* Triggering popovers on hidden elements will not work.
* Popovers for `.disabled` or `disabled` elements must be triggered on a wrapper element.
* When triggered from anchors that wrap across multiple lines, popovers will be centered between the anchors’ overall width. Use `.text-nowrap` on your `<a>`s to avoid this behavior.
* Popovers must be hidden before their corresponding elements have been removed from the DOM.
* Popovers can be triggered thanks to an element inside a shadow DOM.

By default, this component uses the built-in content sanitizer, which strips out any HTML elements that are not explicitly allowed. See the [sanitizer section in our JavaScript documentation](/docs/5.3/getting-started/javascript/#sanitizer) for more details.

The animation effect of this component is dependent on the `prefers-reduced-motion` media query. See the [reduced motion section of our accessibility documentation](/docs/5.3/getting-started/accessibility/#reduced-motion).

Keep reading to see how popovers work with some examples.

## Examples

### Enable popovers

As mentioned above, you must initialize popovers before they can be used. One way to initialize all popovers on a page would be to select them by their `data-bs-toggle` attribute, like so:

```html
const popoverTriggerList = document.querySelectorAll('[data-bs-toggle="popover"]')
const popoverList = [...popoverTriggerList].map(popoverTriggerEl => new bootstrap.Popover(popoverTriggerEl))
```

### Live demo

We use JavaScript similar to the snippet above to render the following live popover. Titles are set via `data-bs-title` and body content is set via `data-bs-content`.

Feel free to use either `title` or `data-bs-title` in your HTML. When `title` is used, Popper will replace it automatically with `data-bs-title` when the element is rendered.

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
     &lt;button class=&quot;btn btn-lg btn-danger&quot; data-bs-content=&quot;And here’s some amazing content. It’s very engaging. Right?&quot; data-bs-title=&quot;Popover title&quot; data-bs-toggle=&quot;popover&quot; type=&quot;button&quot;&gt;Click to toggle popover&lt;/button&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<button type="button" class="btn btn-lg btn-danger" data-bs-toggle="popover" data-bs-title="Popover title" data-bs-content="And here’s some amazing content. It’s very engaging. Right?">Click to toggle popover</button>
```

### Four directions

Four options are available: top, right, bottom, and left. Directions are mirrored when using Bootstrap in RTL. Set `data-bs-placement` to change the direction.

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
     &lt;button class=&quot;btn btn-secondary&quot; data-bs-container=&quot;body&quot; data-bs-content=&quot;Top popover&quot; data-bs-placement=&quot;top&quot; data-bs-toggle=&quot;popover&quot; type=&quot;button&quot;&gt;
  Popover on top
&lt;/button&gt;
&lt;button class=&quot;btn btn-secondary&quot; data-bs-container=&quot;body&quot; data-bs-content=&quot;Right popover&quot; data-bs-placement=&quot;right&quot; data-bs-toggle=&quot;popover&quot; type=&quot;button&quot;&gt;
  Popover on right
&lt;/button&gt;
&lt;button class=&quot;btn btn-secondary&quot; data-bs-container=&quot;body&quot; data-bs-content=&quot;Bottom popover&quot; data-bs-placement=&quot;bottom&quot; data-bs-toggle=&quot;popover&quot; type=&quot;button&quot;&gt;
  Popover on bottom
&lt;/button&gt;
&lt;button class=&quot;btn btn-secondary&quot; data-bs-container=&quot;body&quot; data-bs-content=&quot;Left popover&quot; data-bs-placement=&quot;left&quot; data-bs-toggle=&quot;popover&quot; type=&quot;button&quot;&gt;
  Popover on left
&lt;/button&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<button type="button" class="btn btn-secondary" data-bs-container="body" data-bs-toggle="popover" data-bs-placement="top" data-bs-content="Top popover">
  Popover on top
</button>
<button type="button" class="btn btn-secondary" data-bs-container="body" data-bs-toggle="popover" data-bs-placement="right" data-bs-content="Right popover">
  Popover on right
</button>
<button type="button" class="btn btn-secondary" data-bs-container="body" data-bs-toggle="popover" data-bs-placement="bottom" data-bs-content="Bottom popover">
  Popover on bottom
</button>
<button type="button" class="btn btn-secondary" data-bs-container="body" data-bs-toggle="popover" data-bs-placement="left" data-bs-content="Left popover">
  Popover on left
</button>
```

### Custom `container`

When you have some styles on a parent element that interfere with a popover, you’ll want to specify a custom `container` so that the popover’s HTML appears within that element instead. This is common in responsive tables, input groups, and the like.

```html
const popover = new bootstrap.Popover('.example-popover', {
  container: 'body'
})
```

Another situation where you’ll want to set an explicit custom `container` are popovers inside a [modal dialog](/docs/5.3/components/modal), to make sure that the popover itself is appended to the modal. This is particularly important for popovers that contain interactive elements – modal dialogs will trap focus, so unless the popover is a child element of the modal, users won’t be able to focus or activate these interactive elements.

```html
const popover = new bootstrap.Popover('.example-popover', {
  container: '.modal-body'
})
```

### Custom popovers

Added in v5.2.0

You can customize the appearance of popovers using [CSS variables](#variables). We set a custom class with `data-bs-custom-class="custom-popover"` to scope our custom appearance and use it to override some of the local CSS variables.

[site/src/scss/\_component-examples.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/scss/_component-examples.scss)

```html
.custom-popover {
  --bs-popover-max-width: 200px;
  --bs-popover-border-color: var(--bd-violet-bg);
  --bs-popover-header-bg: var(--bd-violet-bg);
  --bs-popover-header-color: var(--bs-white);
  --bs-popover-body-padding-x: 1rem;
  --bs-popover-body-padding-y: .5rem;
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
     &lt;button class=&quot;btn btn-secondary&quot; data-bs-content=&quot;This popover is themed via CSS variables.&quot; data-bs-custom-class=&quot;custom-popover&quot; data-bs-placement=&quot;right&quot; data-bs-title=&quot;Custom popover&quot; data-bs-toggle=&quot;popover&quot; type=&quot;button&quot;&gt;
  Custom popover
&lt;/button&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<button type="button" class="btn btn-secondary"
        data-bs-toggle="popover" data-bs-placement="right"
        data-bs-custom-class="custom-popover"
        data-bs-title="Custom popover"
        data-bs-content="This popover is themed via CSS variables.">
  Custom popover
</button>
```

### Dismiss on next click

Use the `focus` trigger to dismiss popovers on the user’s next click of an element other than the toggle element.

**Dismissing on next click requires specific HTML for proper cross-browser and cross-platform behavior.** You can only use `<a>` elements, not `<button>`s, and you must include a [`tabindex`](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/tabindex).

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
     &lt;a class=&quot;btn btn-lg btn-danger&quot; data-bs-content=&quot;And here’s some amazing content. It’s very engaging. Right?&quot; data-bs-title=&quot;Dismissible popover&quot; data-bs-toggle=&quot;popover&quot; data-bs-trigger=&quot;focus&quot; role=&quot;button&quot; tabindex=&quot;0&quot;&gt;Dismissible popover&lt;/a&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<a tabindex="0" class="btn btn-lg btn-danger" role="button" data-bs-toggle="popover" data-bs-trigger="focus" data-bs-title="Dismissible popover" data-bs-content="And here’s some amazing content. It’s very engaging. Right?">Dismissible popover</a>
```

```html
const popover = new bootstrap.Popover('.popover-dismiss', {
  trigger: 'focus'
})
```

### Disabled elements

Elements with the `disabled` attribute aren’t interactive, meaning users cannot hover or click them to trigger a popover (or tooltip). As a workaround, you’ll want to trigger the popover from a wrapper `<div>` or `<span>`, ideally made keyboard-focusable using `tabindex="0"`.

For disabled popover triggers, you may also prefer `data-bs-trigger="hover focus"` so that the popover appears as immediate visual feedback to your users as they may not expect to *click* on a disabled element.

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
     &lt;span class=&quot;d-inline-block&quot; data-bs-content=&quot;Disabled popover&quot; data-bs-toggle=&quot;popover&quot; data-bs-trigger=&quot;hover focus&quot; tabindex=&quot;0&quot;&gt;
&lt;button class=&quot;btn btn-primary&quot; disabled=&quot;&quot; type=&quot;button&quot;&gt;Disabled button&lt;/button&gt;
&lt;/span&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<span class="d-inline-block" tabindex="0" data-bs-toggle="popover" data-bs-trigger="hover focus" data-bs-content="Disabled popover">
  <button class="btn btn-primary" type="button" disabled>Disabled button</button>
</span>
```

## CSS

### Variables

Added in v5.2.0

As part of Bootstrap’s evolving CSS variables approach, popovers now use local CSS variables on `.popover` for enhanced real-time customization. Values for the CSS variables are set via Sass, so Sass customization is still supported, too.

[scss/\_popover.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_popover.scss)

```html
--#{$prefix}popover-zindex: #{$zindex-popover};
--#{$prefix}popover-max-width: #{$popover-max-width};
@include rfs($popover-font-size, --#{$prefix}popover-font-size);
--#{$prefix}popover-bg: #{$popover-bg};
--#{$prefix}popover-border-width: #{$popover-border-width};
--#{$prefix}popover-border-color: #{$popover-border-color};
--#{$prefix}popover-border-radius: #{$popover-border-radius};
--#{$prefix}popover-inner-border-radius: #{$popover-inner-border-radius};
--#{$prefix}popover-box-shadow: #{$popover-box-shadow};
--#{$prefix}popover-header-padding-x: #{$popover-header-padding-x};
--#{$prefix}popover-header-padding-y: #{$popover-header-padding-y};
@include rfs($popover-header-font-size, --#{$prefix}popover-header-font-size);
--#{$prefix}popover-header-color: #{$popover-header-color};
--#{$prefix}popover-header-bg: #{$popover-header-bg};
--#{$prefix}popover-body-padding-x: #{$popover-body-padding-x};
--#{$prefix}popover-body-padding-y: #{$popover-body-padding-y};
--#{$prefix}popover-body-color: #{$popover-body-color};
--#{$prefix}popover-arrow-width: #{$popover-arrow-width};
--#{$prefix}popover-arrow-height: #{$popover-arrow-height};
--#{$prefix}popover-arrow-border: var(--#{$prefix}popover-border-color);
```

### Sass variables

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$popover-font-size:                 $font-size-sm;
$popover-bg:                        var(--#{$prefix}body-bg);
$popover-max-width:                 276px;
$popover-border-width:              var(--#{$prefix}border-width);
$popover-border-color:              var(--#{$prefix}border-color-translucent);
$popover-border-radius:             var(--#{$prefix}border-radius-lg);
$popover-inner-border-radius:       calc(#{$popover-border-radius} - #{$popover-border-width}); // stylelint-disable-line function-disallowed-list
$popover-box-shadow:                var(--#{$prefix}box-shadow);

$popover-header-font-size:          $font-size-base;
$popover-header-bg:                 var(--#{$prefix}secondary-bg);
$popover-header-color:              $headings-color;
$popover-header-padding-y:          .5rem;
$popover-header-padding-x:          $spacer;

$popover-body-color:                var(--#{$prefix}body-color);
$popover-body-padding-y:            $spacer;
$popover-body-padding-x:            $spacer;

$popover-arrow-width:               1rem;
$popover-arrow-height:              .5rem;
```

## Usage

Enable popovers via JavaScript:

```html
const exampleEl = document.getElementById('example')
const popover = new bootstrap.Popover(exampleEl, options)
```

**Keep popovers accessible to keyboard and assistive technology users** by only adding them to HTML elements that are traditionally keyboard-focusable and interactive (such as links or form controls). While other HTML elements can be made focusable by adding `tabindex="0"`, this can create annoying and confusing tab stops on non-interactive elements for keyboard users, and most assistive technologies currently do not announce popovers in this situation. Additionally, do not rely solely on `hover` as the trigger for your popovers as this will make them impossible to trigger for keyboard users.

Avoid adding an excessive amount of content in popovers with the `html` option. Once popovers are displayed, their content is tied to the trigger element with the `aria-describedby` attribute, causing all of the popover’s content to be announced to assistive technology users as one long, uninterrupted stream.

Popovers do not manage keyboard focus order, and their placement can be random in the DOM, so be careful when adding interactive elements (like forms or links), as it may lead to an illogical focus order or make the popover content itself completely unreachable for keyboard users. In cases where you must use these elements, consider using a modal dialog instead.

### Options

As options can be passed via data attributes or JavaScript, you can append an option name to `data-bs-`, as in `data-bs-animation="{value}"`. Make sure to change the case type of the option name from “*camelCase*” to “*kebab-case*” when passing the options via data attributes. For example, use `data-bs-custom-class="beautifier"` instead of `data-bs-customClass="beautifier"`.

As of Bootstrap 5.2.0, all components support an **experimental** reserved data attribute `data-bs-config` that can house simple component configuration as a JSON string. When an element has `data-bs-config='{"delay":0, "title":123}'` and `data-bs-title="456"` attributes, the final `title` value will be `456` and the separate data attributes will override values given on `data-bs-config`. In addition, existing data attributes are able to house JSON values like `data-bs-delay='{"show":0,"hide":150}'`.

The final configuration object is the merged result of `data-bs-config`, `data-bs-`, and `js object` where the latest given key-value overrides the others.

Note that for security reasons the `sanitize`, `sanitizeFn`, and `allowList` options cannot be supplied using data attributes.

| Name | Type | Default | Description |
| --- | --- | --- | --- |
| `allowList` | object | [Default value](/docs/5.3/getting-started/javascript#sanitizer) | An object containing allowed tags and attributes. Those not explicitly allowed will be removed by [the content sanitizer](/docs/5.3/getting-started/javascript#sanitizer). **Exercise caution when adding to this list.** Refer to [OWASP’s Cross Site Scripting Prevention Cheat Sheet](https://cheatsheetseries.owasp.org/cheatsheets/Cross_Site_Scripting_Prevention_Cheat_Sheet.html) for more information. |
| `animation` | boolean | `true` | Apply a CSS fade transition to the popover. |
| `boundary` | string, element | `'clippingParents'` | Overflow constraint boundary of the popover (applies only to Popper’s preventOverflow modifier). By default, it’s `'clippingParents'` and can accept an HTMLElement reference (via JavaScript only). For more information refer to Popper’s [detectOverflow docs](https://popper.js.org/docs/v2/utils/detect-overflow/#boundary). |
| `container` | string, element, false | `false` | Appends the popover to a specific element. Example: `container: 'body'`. This option is particularly useful in that it allows you to position the popover in the flow of the document near the triggering element - which will prevent the popover from floating away from the triggering element during a window resize. |
| `content` | string, element, function | `''` | The popover’s text content. If a function is given, it will be called with its `this` reference set to the element that the popover is attached to. |
| `customClass` | string, function | `''` | Add classes to the popover when it is shown. Note that these classes will be added in addition to any classes specified in the template. To add multiple classes, separate them with spaces: `'class-1 class-2'`. You can also pass a function that should return a single string containing additional class names. |
| `delay` | number, object | `0` | Delay showing and hiding the popover (ms)—doesn’t apply to manual trigger type. If a number is supplied, delay is applied to both hide/show. Object structure is: `delay: { "show": 500, "hide": 100 }`. |
| `fallbackPlacements` | string, array | `['top', 'right', 'bottom', 'left']` | Define fallback placements by providing a list of placements in array (in order of preference). For more information refer to Popper’s [behavior docs](https://popper.js.org/docs/v2/modifiers/flip/#fallbackplacements). |
| `html` | boolean | `false` | Allow HTML in the popover. If true, HTML tags in the popover’s `title` will be rendered in the popover. If false, `innerText` property will be used to insert content into the DOM. Prefer text when dealing with user-generated input to [prevent XSS attacks](https://cheatsheetseries.owasp.org/cheatsheets/Cross_Site_Scripting_Prevention_Cheat_Sheet.html). |
| `offset` | number, string, function | `[0, 8]` | Offset of the popover relative to its target. You can pass a string in data attributes with comma separated values like: `data-bs-offset="10,20"`. When a function is used to determine the offset, it is called with an object containing the popper placement, the reference, and popper rects as its first argument. The triggering element DOM node is passed as the second argument. The function must return an array with two numbers: [skidding](https://popper.js.org/docs/v2/modifiers/offset/#skidding-1), [distance](https://popper.js.org/docs/v2/modifiers/offset/#distance-1). For more information refer to Popper’s [offset docs](https://popper.js.org/docs/v2/modifiers/offset/#options). |
| `placement` | string, function | `'right'` | How to position the popover: auto, top, bottom, left, right. When `auto` is specified, it will dynamically reorient the popover. When a function is used to determine the placement, it is called with the popover DOM node as its first argument and the triggering element DOM node as its second. The `this` context is set to the popover instance. |
| `popperConfig` | null, object, function | `null` | To change Bootstrap’s default Popper config, see [Popper’s configuration](https://popper.js.org/docs/v2/constructors/#options). When a function is used to create the Popper configuration, it’s called with an object that contains the Bootstrap’s default Popper configuration. It helps you use and merge the default with your own configuration. The function must return a configuration object for Popper. |
| `sanitize` | boolean | `true` | Enable [content sanitization](/docs/5.3/getting-started/javascript#sanitizer). If true, the `template`, `content` and `title` options will be sanitized. **Exercise caution when disabling content sanitization.** Refer to [OWASP’s Cross Site Scripting Prevention Cheat Sheet](https://cheatsheetseries.owasp.org/cheatsheets/Cross_Site_Scripting_Prevention_Cheat_Sheet.html) for more information. Vulnerabilities caused solely by disabling content sanitization are not considered within scope for Bootstrap’s security model. |
| `sanitizeFn` | null, function | `null` | Provide an alternative [content sanitization](/docs/5.3/getting-started/javascript#sanitizer) function. This can be useful if you prefer to use a dedicated library to perform sanitization. |
| `selector` | string, false | `false` | If a selector is provided, popover objects will be delegated to the specified targets. In practice, this is used to also apply popovers to dynamically added DOM elements (`jQuery.on` support). See [this issue](https://github.com/twbs/bootstrap/issues/4215) and [an informative example](https://codepen.io/Johann-S/pen/djJYPb). **Note**: `title` attribute must not be used as a selector. |
| `template` | string | `'<div class="popover" role="tooltip"><div class="popover-arrow"></div><h3 class="popover-header"></h3><div class="popover-body"></div></div>'` | Base HTML to use when creating the popover. The popover’s `title` will be injected into the `.popover-header`. The popover’s `content` will be injected into the `.popover-body`. `.popover-arrow` will become the popover’s arrow. The outermost wrapper element should have the `.popover` class and `role="tooltip"`. |
| `title` | string, element, function | `''` | The popover title. If a function is given, it will be called with its `this` reference set to the element that the popover is attached to. |
| `trigger` | string | `'click'` | How popover is triggered: click, hover, focus, manual. You may pass multiple triggers; separate them with a space. `'manual'` indicates that the popover will be triggered programmatically via the `.popover('show')`, `.popover('hide')` and `.popover('toggle')` methods; this value cannot be combined with any other trigger. `'hover'` on its own will result in popovers that cannot be triggered via the keyboard, and should only be used if alternative methods for conveying the same information for keyboard users is present. |

#### Data attributes for individual popovers

Options for individual popovers can alternatively be specified through the use of data attributes, as explained above.

#### Using function with `popperConfig`

```html
const popover = new bootstrap.Popover(element, {
  popperConfig(defaultBsPopperConfig) {
    // const newPopperConfig = {...}
    // use defaultBsPopperConfig if needed...
    // return newPopperConfig
  }
})
```

### Methods

**All API methods are asynchronous and start a transition.** They return to the caller as soon as the transition is started, but before it ends. In addition, a method call on a transitioning component will be ignored. [Learn more in our JavaScript docs.](/docs/5.3/getting-started/javascript/#asynchronous-functions-and-transitions)

| Method | Description |
| --- | --- |
| `disable` | Removes the ability for an element’s popover to be shown. The popover will only be able to be shown if it is re-enabled. |
| `dispose` | Hides and destroys an element’s popover (Removes stored data on the DOM element). Popovers that use delegation (which are created using [the `selector` option](#options)) cannot be individually destroyed on descendant trigger elements. |
| `enable` | Gives an element’s popover the ability to be shown. **Popovers are enabled by default.** |
| `getInstance` | *Static* method which allows you to get the popover instance associated with a DOM element. |
| `getOrCreateInstance` | *Static* method which allows you to get the popover instance associated with a DOM element, or create a new one in case it wasn’t initialized. |
| `hide` | Hides an element’s popover. **Returns to the caller before the popover has actually been hidden** (i.e. before the `hidden.bs.popover` event occurs). This is considered a “manual” triggering of the popover. |
| `setContent` | Gives a way to change the popover’s content after its initialization. |
| `show` | Reveals an element’s popover. **Returns to the caller before the popover has actually been shown** (i.e. before the `shown.bs.popover` event occurs). This is considered a “manual” triggering of the popover. Popovers whose title and content are both zero-length are never displayed. |
| `toggle` | Toggles an element’s popover. **Returns to the caller before the popover has actually been shown or hidden** (i.e. before the `shown.bs.popover` or `hidden.bs.popover` event occurs). This is considered a “manual” triggering of the popover. |
| `toggleEnabled` | Toggles the ability for an element’s popover to be shown or hidden. |
| `update` | Updates the position of an element’s popover. |

```html
// getOrCreateInstance example
const popover = bootstrap.Popover.getOrCreateInstance('#example') // Returns a Bootstrap popover instance

// setContent example
popover.setContent({
  '.popover-header': 'another title',
  '.popover-body': 'another content'
})
```

The `setContent` method accepts an `object` argument, where each property-key is a valid `string` selector within the popover template, and each related property-value can be `string` | `element` | `function` | `null`

### Events

| Event | Description |
| --- | --- |
| `hide.bs.popover` | This event is fired immediately when the `hide` instance method has been called. |
| `hidden.bs.popover` | This event is fired when the popover has finished being hidden from the user (will wait for CSS transitions to complete). |
| `inserted.bs.popover` | This event is fired after the `show.bs.popover` event when the popover template has been added to the DOM. |
| `show.bs.popover` | This event fires immediately when the `show` instance method is called. |
| `shown.bs.popover` | This event is fired when the popover has been made visible to the user (will wait for CSS transitions to complete). |

```html
const myPopoverTrigger = document.getElementById('myPopover')
myPopoverTrigger.addEventListener('hidden.bs.popover', () => {
  // do something...
})
```

