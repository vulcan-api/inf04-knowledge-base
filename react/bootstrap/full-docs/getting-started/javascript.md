> Źródło: [https://getbootstrap.com/docs/5.3/getting-started/javascript](https://getbootstrap.com/docs/5.3/getting-started/javascript)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/getting-started/javascript.mdx "View and edit this file on GitHub")

# JavaScript

Bring Bootstrap to life with our optional JavaScript plugins. Learn about each plugin, our data and programmatic API options, and more.

On this page
   
**On this page**

---

* [Individual or compiled](#individual-or-compiled)
* [Usage with JavaScript frameworks](#usage-with-javascript-frameworks)
* [Using Bootstrap as a module](#using-bootstrap-as-a-module)
* [Dependencies](#dependencies)
* [Data attributes](#data-attributes)
* [Selectors](#selectors)
* [Events](#events)
* [Programmatic API](#programmatic-api)
  + [CSS selectors in constructors](#css-selectors-in-constructors)
  + [Asynchronous functions and transitions](#asynchronous-functions-and-transitions)
    - [dispose method](#dispose-method)
  + [Default settings](#default-settings)
* [Methods and properties](#methods-and-properties)
* [Sanitizer](#sanitizer)
* [Optionally using jQuery](#optionally-using-jquery)
  + [No conflict](#no-conflict)
  + [jQuery events](#jquery-events)
* [Disabled JavaScript](#disabled-javascript)

## Individual or compiled

Plugins can be included individually (using Bootstrap’s individual `js/dist/*.js`), or all at once using `bootstrap.js` or the minified `bootstrap.min.js` (don’t include both).

If you use a bundler (Webpack, Parcel, Vite…), you can use `/js/dist/*.js` files which are UMD ready.

## Usage with JavaScript frameworks

While the Bootstrap CSS can be used with any framework, **the Bootstrap JavaScript is not fully compatible with JavaScript frameworks like React, Vue, and Angular** which assume full knowledge of the DOM. Both Bootstrap and the framework may attempt to mutate the same DOM element, resulting in bugs like dropdowns that are stuck in the “open” position.

A better alternative for those using this type of frameworks is to use a framework-specific package **instead of** the Bootstrap JavaScript. Here are some of the most popular options:

* React: [React Bootstrap](https://react-bootstrap.github.io/)

  **Try it yourself!** Download the source code and working demo for using Bootstrap with React, Next.js, and React Bootstrap from the [twbs/examples repository](https://github.com/twbs/examples/tree/main/react-nextjs). You can also [open the example in StackBlitz](https://stackblitz.com/github/twbs/examples/tree/main/react-nextjs?file=src%2Fpages%2Findex.tsx).
* Vue: [BootstrapVue](https://bootstrap-vue.org/) (Bootstrap 4)
* Vue 3: [BootstrapVueNext](https://bootstrap-vue-next.github.io/bootstrap-vue-next/) (Bootstrap 5, currently in alpha)
* Angular: [ng-bootstrap](https://ng-bootstrap.github.io/) or [ngx-bootstrap](https://valor-software.com/ngx-bootstrap)

## Using Bootstrap as a module

**Try it yourself!** Download the source code and working demo for using Bootstrap as an ES module from the [twbs/examples repository](https://github.com/twbs/examples/tree/main/sass-js-esm). You can also [open the example in StackBlitz](https://stackblitz.com/github/twbs/examples/tree/main/sass-js-esm?file=index.html).

We provide a version of Bootstrap built as `ESM` (`bootstrap.esm.js` and `bootstrap.esm.min.js`) which allows you to use Bootstrap as a module in the browser, if your [targeted browsers support it](https://caniuse.com/es6-module).

```html
<script type="module">
  import { Toast } from 'bootstrap.esm.min.js'

  Array.from(document.querySelectorAll('.toast'))
    .forEach(toastNode => new Toast(toastNode))
</script>
```

Compared to JS bundlers, using ESM in the browser requires you to use the full path and filename instead of the module name. [Read more about JS modules in the browser.](https://v8.dev/features/modules#specifiers) That’s why we use `'bootstrap.esm.min.js'` instead of `'bootstrap'` above. However, this is further complicated by our Popper dependency, which imports Popper into our JavaScript like so:

```html
import * as Popper from "@popperjs/core"
```

If you try this as-is, you’ll see an error in the console like the following:

```html
Uncaught TypeError: Failed to resolve module specifier "@popperjs/core". Relative references must start with either "/", "./", or "../".
```

To fix this, you can use an `importmap` to resolve the arbitrary module names to complete paths. If your [targeted browsers](https://caniuse.com/?search=importmap) do not support `importmap`, you’ll need to use the [es-module-shims](https://github.com/guybedford/es-module-shims) project. Here’s how it works for Bootstrap and Popper:

```html
<!doctype html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
    <title>Hello, modularity!</title>
  </head>
  <body>
    <h1>Hello, modularity!</h1>
    <button id="popoverButton" type="button" class="btn btn-primary btn-lg" data-bs-toggle="popover" title="ESM in Browser" data-bs-content="Bang!">Custom popover</button>

    <script async src="https://cdn.jsdelivr.net/npm/es-module-shims@1/dist/es-module-shims.min.js" crossorigin="anonymous"></script>
    <script type="importmap">
    {
      "imports": {
        "@popperjs/core": "https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/esm/popper.min.js",
        "bootstrap": "https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.esm.min.js"
      }
    }
    </script>
    <script type="module">
      import * as bootstrap from 'bootstrap'

      new bootstrap.Popover(document.getElementById('popoverButton'))
    </script>
  </body>
</html>
```

## Dependencies

Some plugins and CSS components depend on other plugins. If you include plugins individually, make sure to check for these dependencies in the docs.

Our dropdowns, popovers, and tooltips also depend on [Popper](https://popper.js.org/docs/v2/).

## Data attributes

Nearly all Bootstrap plugins can be enabled and configured through HTML alone with data attributes (our preferred way of using JavaScript functionality). Be sure to **only use one set of data attributes on a single element** (e.g., you cannot trigger a tooltip and modal from the same button.)

As options can be passed via data attributes or JavaScript, you can append an option name to `data-bs-`, as in `data-bs-animation="{value}"`. Make sure to change the case type of the option name from “*camelCase*” to “*kebab-case*” when passing the options via data attributes. For example, use `data-bs-custom-class="beautifier"` instead of `data-bs-customClass="beautifier"`.

As of Bootstrap 5.2.0, all components support an **experimental** reserved data attribute `data-bs-config` that can house simple component configuration as a JSON string. When an element has `data-bs-config='{"delay":0, "title":123}'` and `data-bs-title="456"` attributes, the final `title` value will be `456` and the separate data attributes will override values given on `data-bs-config`. In addition, existing data attributes are able to house JSON values like `data-bs-delay='{"show":0,"hide":150}'`.

The final configuration object is the merged result of `data-bs-config`, `data-bs-`, and `js object` where the latest given key-value overrides the others.

## Selectors

We use the native `querySelector` and `querySelectorAll` methods to query DOM elements for performance reasons, so you must use [valid selectors](https://www.w3.org/TR/CSS21/syndata.html#value-def-identifier). If you use special selectors like `collapse:Example`, be sure to escape them.

## Events

Bootstrap provides custom events for most plugins’ unique actions. Generally, these come in an infinitive and past participle form - where the infinitive (ex. `show`) is triggered at the start of an event, and its past participle form (ex. `shown`) is triggered on the completion of an action.

All infinitive events provide [`preventDefault()`](https://developer.mozilla.org/en-US/docs/Web/API/Event/preventDefault) functionality. This provides the ability to stop the execution of an action before it starts. Returning false from an event handler will also automatically call `preventDefault()`.

```html
const myModal = document.querySelector('#myModal')

myModal.addEventListener('show.bs.modal', event => {
  return event.preventDefault() // stops modal from being shown
})
```

## Programmatic API

All constructors accept an optional options object or nothing (which initiates a plugin with its default behavior):

```html
const myModalEl = document.querySelector('#myModal')
const modal = new bootstrap.Modal(myModalEl) // initialized with defaults

const configObject = { keyboard: false }
const modal1 = new bootstrap.Modal(myModalEl, configObject) // initialized with no keyboard
```

If you’d like to get a particular plugin instance, each plugin exposes a `getInstance` method. For example, to retrieve an instance directly from an element:

```html
bootstrap.Popover.getInstance(myPopoverEl)
```

This method will return `null` if an instance is not initiated over the requested element.

Alternatively, `getOrCreateInstance` can be used to get the instance associated with a DOM element, or create a new one in case it wasn’t initialized.

```html
bootstrap.Popover.getOrCreateInstance(myPopoverEl, configObject)
```

In case an instance wasn’t initialized, it may accept and use an optional configuration object as second argument.

### CSS selectors in constructors

In addition to the `getInstance` and `getOrCreateInstance` methods, all plugin constructors can accept a DOM element or a valid [CSS selector](#selectors) as the first argument. Plugin elements are found with the `querySelector` method since our plugins only support a single element.

```html
const modal = new bootstrap.Modal('#myModal')
const dropdown = new bootstrap.Dropdown('[data-bs-toggle="dropdown"]')
const offcanvas = bootstrap.Offcanvas.getInstance('#myOffcanvas')
const alert = bootstrap.Alert.getOrCreateInstance('#myAlert')
```

### Asynchronous functions and transitions

All programmatic API methods are **asynchronous** and return to the caller once the transition is started, but **before it ends**. In order to execute an action once the transition is complete, you can listen to the corresponding event.

```html
const myCollapseEl = document.querySelector('#myCollapse')

myCollapseEl.addEventListener('shown.bs.collapse', event => {
  // Action to execute once the collapsible area is expanded
})
```

In addition, a method call on a **transitioning component will be ignored**.

```html
const myCarouselEl = document.querySelector('#myCarousel')
const carousel = bootstrap.Carousel.getInstance(myCarouselEl) // Retrieve a Carousel instance

myCarouselEl.addEventListener('slid.bs.carousel', event => {
  carousel.to('2') // Will slide to the slide 2 as soon as the transition to slide 1 is finished
})

carousel.to('1') // Will start sliding to the slide 1 and returns to the caller
carousel.to('2') // !! Will be ignored, as the transition to the slide 1 is not finished !!
```

#### `dispose` method

While it may seem correct to use the `dispose` method immediately after `hide()`, it will lead to incorrect results. Here’s an example of the problem use:

```html
const myModal = document.querySelector('#myModal')
myModal.hide() // it is asynchronous

myModal.addEventListener('shown.bs.hidden', event => {
  myModal.dispose()
})
```

### Default settings

You can change the default settings for a plugin by modifying the plugin’s `Constructor.Default` object:

```html
// changes default for the modal plugin’s `keyboard` option to false
bootstrap.Modal.Default.keyboard = false
```

## Methods and properties

Every Bootstrap plugin exposes the following methods and static properties.

| Method | Description |
| --- | --- |
| `dispose` | Destroys an element’s modal. (Removes stored data on the DOM element) |
| `getInstance` | *Static* method which allows you to get the modal instance associated with a DOM element. |
| `getOrCreateInstance` | *Static* method which allows you to get the modal instance associated with a DOM element, or create a new one in case it wasn’t initialized. |

| Static property | Description |
| --- | --- |
| `NAME` | Returns the plugin name. (Example: `bootstrap.Tooltip.NAME`) |
| `VERSION` | The version of each of Bootstrap’s plugins can be accessed via the `VERSION` property of the plugin’s constructor (Example: `bootstrap.Tooltip.VERSION`) |

## Sanitizer

Our tooltip and popover components are able to render arbitrary HTML to the page if configured to do so.
To prevent cross-site scripting (XSS) attacks, these components use our built-in content sanitizer to sanitize any options which accept HTML before they are rendered to the page. Content sanitization is enabled by default.

The tags and attributes allowed by default are as follows. Any tags or attributes not explicitly allowed will be removed during sanitization:

[js/src/util/sanitizer.js](https://github.com/twbs/bootstrap/blob/v5.3.8/js/src/util/sanitizer.js)

```html
const ARIA_ATTRIBUTE_PATTERN = /^aria-[\w-]*$/i

export const DefaultAllowlist = {
  // Global attributes allowed on any supplied element below.
  '*': ['class', 'dir', 'id', 'lang', 'role', ARIA_ATTRIBUTE_PATTERN],
  a: ['target', 'href', 'title', 'rel'],
  area: [],
  b: [],
  br: [],
  col: [],
  code: [],
  dd: [],
  div: [],
  dl: [],
  dt: [],
  em: [],
  hr: [],
  h1: [],
  h2: [],
  h3: [],
  h4: [],
  h5: [],
  h6: [],
  i: [],
  img: ['src', 'srcset', 'alt', 'title', 'width', 'height'],
  li: [],
  ol: [],
  p: [],
  pre: [],
  s: [],
  small: [],
  span: [],
  sub: [],
  sup: [],
  strong: [],
  u: [],
  ul: []
}
```

**Exercise caution when using these advanced options.** Refer to [OWASP’s Cross Site Scripting Prevention Cheat Sheet](https://cheatsheetseries.owasp.org/cheatsheets/Cross_Site_Scripting_Prevention_Cheat_Sheet.html) for more information. Vulnerabilities caused solely by disabling or modifying content sanitization are not considered within scope for Bootstrap’s security model.

You can add new values to this default `allowList`:

```html
const myDefaultAllowList = bootstrap.Tooltip.Default.allowList

// To allow table elements
myDefaultAllowList.table = []

// To allow td elements and data-bs-option attributes on td elements
myDefaultAllowList.td = ['data-bs-option']

// You can push your custom regex to validate your attributes.
// Be careful about your regular expressions being too lax
const myCustomRegex = /^data-my-app-[\w-]+/
myDefaultAllowList['*'].push(myCustomRegex)
```

You can also replace our sanitizer with a dedicated library, for example [DOMPurify](https://www.npmjs.com/package/dompurify):

```html
const yourTooltipEl = document.querySelector('#yourTooltip')
const tooltip = new bootstrap.Tooltip(yourTooltipEl, {
  sanitizeFn(content) {
    return DOMPurify.sanitize(content)
  }
})
```

## Optionally using jQuery

**You don’t need jQuery in Bootstrap 5**, but it’s still possible to use our components with jQuery. If Bootstrap detects `jQuery` in the `window` object, it'll add all of our components in jQuery’s plugin system. This allows you to do the following:

```html
// to enable tooltips with the default configuration
$('[data-bs-toggle="tooltip"]').tooltip()

// to initialize tooltips with given configuration
$('[data-bs-toggle="tooltip"]').tooltip({
  boundary: 'clippingParents',
  customClass: 'myClass'
})

// to trigger the `show` method
$('#myTooltip').tooltip('show')
```

The same goes for our other components.

### No conflict

Sometimes it is necessary to use Bootstrap plugins with other UI frameworks. In these circumstances, namespace collisions can occasionally occur. If this happens, you may call `.noConflict` on the plugin you wish to revert the value of.

```html
const bootstrapButton = $.fn.button.noConflict() // return $.fn.button to previously assigned value
$.fn.bootstrapBtn = bootstrapButton // give $().bootstrapBtn the Bootstrap functionality
```

Bootstrap does not officially support third-party JavaScript libraries like Prototype or jQuery UI. Despite `.noConflict` and namespaced events, there may be compatibility problems that you need to fix on your own.

### jQuery events

Bootstrap will detect jQuery if `jQuery` is present in the `window` object and there is no `data-bs-no-jquery` attribute set on `<body>`. If jQuery is found, Bootstrap will emit events thanks to jQuery’s event system. So if you want to listen to Bootstrap’s events, you’ll have to use the jQuery methods (`.on`, `.one`) instead of `addEventListener`.

```html
$('#myTab a').on('shown.bs.tab', () => {
  // do something...
})
```

## Disabled JavaScript

Bootstrap’s plugins have no special fallback when JavaScript is disabled. If you care about the user experience in this case, use [`<noscript>`](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/noscript) to explain the situation (and how to re-enable JavaScript) to your users, and/or add your own custom fallbacks.

