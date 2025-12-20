> Źródło: [https://getbootstrap.com/docs/5.3/components/toasts](https://getbootstrap.com/docs/5.3/components/toasts)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/components/toasts.mdx "View and edit this file on GitHub")

# Toasts

Push notifications to your visitors with a toast, a lightweight and easily customizable alert message.

On this page
   
**On this page**

---

* [Overview](#overview)
* [Examples](#examples)
  + [Basic](#basic)
  + [Live example](#live-example)
  + [Translucent](#translucent)
  + [Stacking](#stacking)
  + [Custom content](#custom-content)
  + [Color schemes](#color-schemes)
* [Placement](#placement)
* [Accessibility](#accessibility)
* [CSS](#css)
  + [Variables](#variables)
  + [Sass variables](#sass-variables)
* [Usage](#usage)
  + [Triggers](#triggers)
  + [Options](#options)
  + [Methods](#methods)
  + [Events](#events)

Toasts are lightweight notifications designed to mimic the push notifications that have been popularized by mobile and desktop operating systems. They’re built with flexbox, so they’re easy to align and position.

## Overview

Things to know when using the toast plugin:

* Toasts are opt-in for performance reasons, so **you must initialize them yourself**.
* Toasts will automatically hide if you do not specify `autohide: false`.

The animation effect of this component is dependent on the `prefers-reduced-motion` media query. See the [reduced motion section of our accessibility documentation](/docs/5.3/getting-started/accessibility/#reduced-motion).

## Examples

### Basic

To encourage extensible and predictable toasts, we recommend a header and body. Toast headers use `display: flex`, allowing easy alignment of content thanks to our margin and flexbox utilities.

Toasts are as flexible as you need and have very little required markup. At a minimum, we require a single element to contain your “toasted” content and strongly encourage a dismiss button.

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
     &lt;div aria-atomic=&quot;true&quot; aria-live=&quot;assertive&quot; class=&quot;toast&quot; role=&quot;alert&quot;&gt;
&lt;div class=&quot;toast-header&quot;&gt;
&lt;svg aria-hidden=&quot;true&quot; class=&quot;bd-placeholder-img rounded me-2&quot; height=&quot;20&quot; preserveaspectratio=&quot;xMidYMid slice&quot; width=&quot;20&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;rect fill=&quot;#007aff&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;/svg&gt;
&lt;strong class=&quot;me-auto&quot;&gt;Bootstrap&lt;/strong&gt;
&lt;small&gt;11 mins ago&lt;/small&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;toast&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;toast-body&quot;&gt;
    Hello, world! This is a toast message.
  &lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="toast" role="alert" aria-live="assertive" aria-atomic="true">
  <div class="toast-header">
    <img src="..." class="rounded me-2" alt="...">
    <strong class="me-auto">Bootstrap</strong>
    <small>11 mins ago</small>
    <button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button>
  </div>
  <div class="toast-body">
    Hello, world! This is a toast message.
  </div>
</div>
```

Previously, our scripts dynamically added the `.hide` class to completely hide a toast (with `display:none`, rather than just with `opacity:0`). This is now not necessary anymore. However, for backwards compatibility, our script will continue to toggle the class (even though there is no practical need for it) until the next major version.

### Live example

Click the button below to show a toast (positioned with our utilities in the lower right corner) that has been hidden by default.

**Bootstrap**11 mins ago

Hello, world! This is a toast message.

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
    
&lt;button class=&quot;btn btn-primary&quot; id=&quot;liveToastBtn&quot; type=&quot;button&quot;&gt;Show live toast&lt;/button&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<button type="button" class="btn btn-primary" id="liveToastBtn">Show live toast</button>

<div class="toast-container position-fixed bottom-0 end-0 p-3">
  <div id="liveToast" class="toast" role="alert" aria-live="assertive" aria-atomic="true">
    <div class="toast-header">
      <img src="..." class="rounded me-2" alt="...">
      <strong class="me-auto">Bootstrap</strong>
      <small>11 mins ago</small>
      <button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button>
    </div>
    <div class="toast-body">
      Hello, world! This is a toast message.
    </div>
  </div>
</div>
```

We use the following JavaScript to trigger our live toast demo:

[site/src/assets/partials/snippets.js](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/assets/partials/snippets.js)

```html
const toastTrigger = document.getElementById('liveToastBtn')
const toastLiveExample = document.getElementById('liveToast')

if (toastTrigger) {
  const toastBootstrap = bootstrap.Toast.getOrCreateInstance(toastLiveExample)
  toastTrigger.addEventListener('click', () => {
    toastBootstrap.show()
  })
}
```

### Translucent

Toasts are slightly translucent to blend in with what’s below them.

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
     &lt;div aria-atomic=&quot;true&quot; aria-live=&quot;assertive&quot; class=&quot;toast&quot; role=&quot;alert&quot;&gt;
&lt;div class=&quot;toast-header&quot;&gt;
&lt;svg aria-hidden=&quot;true&quot; class=&quot;bd-placeholder-img rounded me-2&quot; height=&quot;20&quot; preserveaspectratio=&quot;xMidYMid slice&quot; width=&quot;20&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;rect fill=&quot;#007aff&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;/svg&gt;
&lt;strong class=&quot;me-auto&quot;&gt;Bootstrap&lt;/strong&gt;
&lt;small class=&quot;text-body-secondary&quot;&gt;11 mins ago&lt;/small&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;toast&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;toast-body&quot;&gt;
    Hello, world! This is a toast message.
  &lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="toast" role="alert" aria-live="assertive" aria-atomic="true">
  <div class="toast-header">
    <img src="..." class="rounded me-2" alt="...">
    <strong class="me-auto">Bootstrap</strong>
    <small class="text-body-secondary">11 mins ago</small>
    <button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button>
  </div>
  <div class="toast-body">
    Hello, world! This is a toast message.
  </div>
</div>
```

### Stacking

You can stack toasts by wrapping them in a toast container, which will vertically add some spacing.

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
     &lt;div class=&quot;toast-container position-static&quot;&gt;
&lt;div aria-atomic=&quot;true&quot; aria-live=&quot;assertive&quot; class=&quot;toast&quot; role=&quot;alert&quot;&gt;
&lt;div class=&quot;toast-header&quot;&gt;
&lt;svg aria-hidden=&quot;true&quot; class=&quot;bd-placeholder-img rounded me-2&quot; height=&quot;20&quot; preserveaspectratio=&quot;xMidYMid slice&quot; width=&quot;20&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;rect fill=&quot;#007aff&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;/svg&gt;
&lt;strong class=&quot;me-auto&quot;&gt;Bootstrap&lt;/strong&gt;
&lt;small class=&quot;text-body-secondary&quot;&gt;just now&lt;/small&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;toast&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;toast-body&quot;&gt;
      See? Just like this.
    &lt;/div&gt;
&lt;/div&gt;
&lt;div aria-atomic=&quot;true&quot; aria-live=&quot;assertive&quot; class=&quot;toast&quot; role=&quot;alert&quot;&gt;
&lt;div class=&quot;toast-header&quot;&gt;
&lt;svg aria-hidden=&quot;true&quot; class=&quot;bd-placeholder-img rounded me-2&quot; height=&quot;20&quot; preserveaspectratio=&quot;xMidYMid slice&quot; width=&quot;20&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;rect fill=&quot;#007aff&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;/svg&gt;
&lt;strong class=&quot;me-auto&quot;&gt;Bootstrap&lt;/strong&gt;
&lt;small class=&quot;text-body-secondary&quot;&gt;2 seconds ago&lt;/small&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;toast&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;toast-body&quot;&gt;
      Heads up, toasts will stack automatically
    &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="toast-container position-static">
  <div class="toast" role="alert" aria-live="assertive" aria-atomic="true">
    <div class="toast-header">
      <img src="..." class="rounded me-2" alt="...">
      <strong class="me-auto">Bootstrap</strong>
      <small class="text-body-secondary">just now</small>
      <button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button>
    </div>
    <div class="toast-body">
      See? Just like this.
    </div>
  </div>

  <div class="toast" role="alert" aria-live="assertive" aria-atomic="true">
    <div class="toast-header">
      <img src="..." class="rounded me-2" alt="...">
      <strong class="me-auto">Bootstrap</strong>
      <small class="text-body-secondary">2 seconds ago</small>
      <button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button>
    </div>
    <div class="toast-body">
      Heads up, toasts will stack automatically
    </div>
  </div>
</div>
```

### Custom content

Customize your toasts by removing sub-components, tweaking them with [utilities](/docs/5.3/utilities/api), or by adding your own markup. Here we’ve created a simpler toast by removing the default `.toast-header`, adding a custom hide icon from [Bootstrap Icons](https://icons.getbootstrap.com/), and using some [flexbox utilities](/docs/5.3/utilities/flex) to adjust the layout.

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
     &lt;div aria-atomic=&quot;true&quot; aria-live=&quot;assertive&quot; class=&quot;toast align-items-center&quot; role=&quot;alert&quot;&gt;
&lt;div class=&quot;d-flex&quot;&gt;
&lt;div class=&quot;toast-body&quot;&gt;
      Hello, world! This is a toast message.
    &lt;/div&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close me-2 m-auto&quot; data-bs-dismiss=&quot;toast&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="toast align-items-center" role="alert" aria-live="assertive" aria-atomic="true">
  <div class="d-flex">
    <div class="toast-body">
      Hello, world! This is a toast message.
    </div>
    <button type="button" class="btn-close me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
  </div>
</div>
```

Alternatively, you can also add additional controls and components to toasts.

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
     &lt;div aria-atomic=&quot;true&quot; aria-live=&quot;assertive&quot; class=&quot;toast&quot; role=&quot;alert&quot;&gt;
&lt;div class=&quot;toast-body&quot;&gt;
    Hello, world! This is a toast message.
    &lt;div class=&quot;mt-2 pt-2 border-top&quot;&gt;
&lt;button class=&quot;btn btn-primary btn-sm&quot; type=&quot;button&quot;&gt;Take action&lt;/button&gt;
&lt;button class=&quot;btn btn-secondary btn-sm&quot; data-bs-dismiss=&quot;toast&quot; type=&quot;button&quot;&gt;Close&lt;/button&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="toast" role="alert" aria-live="assertive" aria-atomic="true">
  <div class="toast-body">
    Hello, world! This is a toast message.
    <div class="mt-2 pt-2 border-top">
      <button type="button" class="btn btn-primary btn-sm">Take action</button>
      <button type="button" class="btn btn-secondary btn-sm" data-bs-dismiss="toast">Close</button>
    </div>
  </div>
</div>
```

### Color schemes

Building on the above example, you can create different toast color schemes with our [color](/docs/5.3/utilities/colors) and [background](/docs/5.3/utilities/background) utilities. Here we’ve added `.text-bg-primary` to the `.toast`, and then added `.btn-close-white` to our close button. For a crisp edge, we remove the default border with `.border-0`.

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
     &lt;div aria-atomic=&quot;true&quot; aria-live=&quot;assertive&quot; class=&quot;toast align-items-center text-bg-primary border-0&quot; role=&quot;alert&quot;&gt;
&lt;div class=&quot;d-flex&quot;&gt;
&lt;div class=&quot;toast-body&quot;&gt;
      Hello, world! This is a toast message.
    &lt;/div&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close btn-close-white me-2 m-auto&quot; data-bs-dismiss=&quot;toast&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="toast align-items-center text-bg-primary border-0" role="alert" aria-live="assertive" aria-atomic="true">
  <div class="d-flex">
    <div class="toast-body">
      Hello, world! This is a toast message.
    </div>
    <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
  </div>
</div>
```

## Placement

Place toasts with custom CSS as you need them. The top right is often used for notifications, as is the top middle. If you’re only ever going to show one toast at a time, put the positioning styles right on the `.toast`.

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
&lt;div class=&quot;mb-3&quot;&gt;
&lt;label for=&quot;selectToastPlacement&quot;&gt;Toast placement&lt;/label&gt;
&lt;select class=&quot;form-select mt-2&quot; id=&quot;selectToastPlacement&quot;&gt;
&lt;option selected=&quot;&quot; value=&quot;&quot;&gt;Select a position...&lt;/option&gt;
&lt;option value=&quot;top-0 start-0&quot;&gt;Top left&lt;/option&gt;
&lt;option value=&quot;top-0 start-50 translate-middle-x&quot;&gt;Top center&lt;/option&gt;
&lt;option value=&quot;top-0 end-0&quot;&gt;Top right&lt;/option&gt;
&lt;option value=&quot;top-50 start-0 translate-middle-y&quot;&gt;Middle left&lt;/option&gt;
&lt;option value=&quot;top-50 start-50 translate-middle&quot;&gt;Middle center&lt;/option&gt;
&lt;option value=&quot;top-50 end-0 translate-middle-y&quot;&gt;Middle right&lt;/option&gt;
&lt;option value=&quot;bottom-0 start-0&quot;&gt;Bottom left&lt;/option&gt;
&lt;option value=&quot;bottom-0 start-50 translate-middle-x&quot;&gt;Bottom center&lt;/option&gt;
&lt;option value=&quot;bottom-0 end-0&quot;&gt;Bottom right&lt;/option&gt;
&lt;/select&gt;
&lt;/div&gt;
&lt;/form&gt;
&lt;div aria-atomic=&quot;true&quot; aria-live=&quot;polite&quot; class=&quot;bg-body-secondary position-relative bd-example-toasts rounded-3&quot;&gt;
&lt;div class=&quot;toast-container p-3&quot; id=&quot;toastPlacement&quot;&gt;
&lt;div class=&quot;toast&quot;&gt;
&lt;div class=&quot;toast-header&quot;&gt;
&lt;svg aria-hidden=&quot;true&quot; class=&quot;bd-placeholder-img rounded me-2&quot; height=&quot;20&quot; preserveaspectratio=&quot;xMidYMid slice&quot; width=&quot;20&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;rect fill=&quot;#007aff&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;/svg&gt;
&lt;strong class=&quot;me-auto&quot;&gt;Bootstrap&lt;/strong&gt;
&lt;small&gt;11 mins ago&lt;/small&gt;
&lt;/div&gt;
&lt;div class=&quot;toast-body&quot;&gt;
        Hello, world! This is a toast message.
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
<form>
  <div class="mb-3">
    <label for="selectToastPlacement">Toast placement</label>
    <select class="form-select mt-2" id="selectToastPlacement">
      <option value="" selected>Select a position...</option>
      <option value="top-0 start-0">Top left</option>
      <option value="top-0 start-50 translate-middle-x">Top center</option>
      <option value="top-0 end-0">Top right</option>
      <option value="top-50 start-0 translate-middle-y">Middle left</option>
      <option value="top-50 start-50 translate-middle">Middle center</option>
      <option value="top-50 end-0 translate-middle-y">Middle right</option>
      <option value="bottom-0 start-0">Bottom left</option>
      <option value="bottom-0 start-50 translate-middle-x">Bottom center</option>
      <option value="bottom-0 end-0">Bottom right</option>
    </select>
  </div>
</form>
<div aria-live="polite" aria-atomic="true" class="bg-body-secondary position-relative bd-example-toasts rounded-3">
  <div class="toast-container p-3" id="toastPlacement">
    <div class="toast">
      <div class="toast-header">
        <img src="..." class="rounded me-2" alt="...">
        <strong class="me-auto">Bootstrap</strong>
        <small>11 mins ago</small>
      </div>
      <div class="toast-body">
        Hello, world! This is a toast message.
      </div>
    </div>
  </div>
</div>
```

For systems that generate more notifications, consider using a wrapping element so they can easily stack.

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
     &lt;div aria-atomic=&quot;true&quot; aria-live=&quot;polite&quot; class=&quot;position-relative&quot;&gt;
&lt;!-- Position it: --&gt;
&lt;!-- - `.toast-container` for spacing between toasts --&gt;
&lt;!-- - `top-0` &amp; `end-0` to position the toasts in the upper right corner --&gt;
&lt;!-- - `.p-3` to prevent the toasts from sticking to the edge of the container  --&gt;
&lt;div class=&quot;toast-container top-0 end-0 p-3&quot;&gt;
&lt;!-- Then put toasts within --&gt;
&lt;div aria-atomic=&quot;true&quot; aria-live=&quot;assertive&quot; class=&quot;toast&quot; role=&quot;alert&quot;&gt;
&lt;div class=&quot;toast-header&quot;&gt;
&lt;svg aria-hidden=&quot;true&quot; class=&quot;bd-placeholder-img rounded me-2&quot; height=&quot;20&quot; preserveaspectratio=&quot;xMidYMid slice&quot; width=&quot;20&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;rect fill=&quot;#007aff&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;/svg&gt;
&lt;strong class=&quot;me-auto&quot;&gt;Bootstrap&lt;/strong&gt;
&lt;small class=&quot;text-body-secondary&quot;&gt;just now&lt;/small&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;toast&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;toast-body&quot;&gt;
        See? Just like this.
      &lt;/div&gt;
&lt;/div&gt;
&lt;div aria-atomic=&quot;true&quot; aria-live=&quot;assertive&quot; class=&quot;toast&quot; role=&quot;alert&quot;&gt;
&lt;div class=&quot;toast-header&quot;&gt;
&lt;svg aria-hidden=&quot;true&quot; class=&quot;bd-placeholder-img rounded me-2&quot; height=&quot;20&quot; preserveaspectratio=&quot;xMidYMid slice&quot; width=&quot;20&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;rect fill=&quot;#007aff&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;/svg&gt;
&lt;strong class=&quot;me-auto&quot;&gt;Bootstrap&lt;/strong&gt;
&lt;small class=&quot;text-body-secondary&quot;&gt;2 seconds ago&lt;/small&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;toast&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;toast-body&quot;&gt;
        Heads up, toasts will stack automatically
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
<div aria-live="polite" aria-atomic="true" class="position-relative">
  <!-- Position it: -->
  <!-- - `.toast-container` for spacing between toasts -->
  <!-- - `top-0` & `end-0` to position the toasts in the upper right corner -->
  <!-- - `.p-3` to prevent the toasts from sticking to the edge of the container  -->
  <div class="toast-container top-0 end-0 p-3">

    <!-- Then put toasts within -->
    <div class="toast" role="alert" aria-live="assertive" aria-atomic="true">
      <div class="toast-header">
        <img src="..." class="rounded me-2" alt="...">
        <strong class="me-auto">Bootstrap</strong>
        <small class="text-body-secondary">just now</small>
        <button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button>
      </div>
      <div class="toast-body">
        See? Just like this.
      </div>
    </div>

    <div class="toast" role="alert" aria-live="assertive" aria-atomic="true">
      <div class="toast-header">
        <img src="..." class="rounded me-2" alt="...">
        <strong class="me-auto">Bootstrap</strong>
        <small class="text-body-secondary">2 seconds ago</small>
        <button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button>
      </div>
      <div class="toast-body">
        Heads up, toasts will stack automatically
      </div>
    </div>
  </div>
</div>
```

You can also get fancy with flexbox utilities to align toasts horizontally and/or vertically.

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
     &lt;!-- Flexbox container for aligning the toasts --&gt;
&lt;div aria-atomic=&quot;true&quot; aria-live=&quot;polite&quot; class=&quot;d-flex justify-content-center align-items-center w-100&quot;&gt;
&lt;!-- Then put toasts within --&gt;
&lt;div aria-atomic=&quot;true&quot; aria-live=&quot;assertive&quot; class=&quot;toast&quot; role=&quot;alert&quot;&gt;
&lt;div class=&quot;toast-header&quot;&gt;
&lt;svg aria-hidden=&quot;true&quot; class=&quot;bd-placeholder-img rounded me-2&quot; height=&quot;20&quot; preserveaspectratio=&quot;xMidYMid slice&quot; width=&quot;20&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;rect fill=&quot;#007aff&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;/svg&gt;
&lt;strong class=&quot;me-auto&quot;&gt;Bootstrap&lt;/strong&gt;
&lt;small&gt;11 mins ago&lt;/small&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;toast&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;toast-body&quot;&gt;
      Hello, world! This is a toast message.
    &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<!-- Flexbox container for aligning the toasts -->
<div aria-live="polite" aria-atomic="true" class="d-flex justify-content-center align-items-center w-100">

  <!-- Then put toasts within -->
  <div class="toast" role="alert" aria-live="assertive" aria-atomic="true">
    <div class="toast-header">
      <img src="..." class="rounded me-2" alt="...">
      <strong class="me-auto">Bootstrap</strong>
      <small>11 mins ago</small>
      <button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button>
    </div>
    <div class="toast-body">
      Hello, world! This is a toast message.
    </div>
  </div>
</div>
```

## Accessibility

Toasts are intended to be small interruptions to your visitors or users, so to help those with screen readers and similar assistive technologies, you should wrap your toasts in an [`aria-live` region](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions). Changes to live regions (such as injecting/updating a toast component) are automatically announced by screen readers without needing to move the user’s focus or otherwise interrupt the user. Additionally, include `aria-atomic="true"` to ensure that the entire toast is always announced as a single (atomic) unit, rather than just announcing what was changed (which could lead to problems if you only update part of the toast’s content, or if displaying the same toast content at a later point in time). If the information needed is important for the process, e.g. for a list of errors in a form, then use the [alert component](/docs/5.3/components/alerts) instead of toast.

Note that the live region needs to be present in the markup *before* the toast is generated or updated. If you dynamically generate both at the same time and inject them into the page, they will generally not be announced by assistive technologies.

You also need to adapt the `role` and `aria-live` level depending on the content. If it’s an important message like an error, use `role="alert" aria-live="assertive"`, otherwise use `role="status" aria-live="polite"` attributes.

As the content you’re displaying changes, be sure to update the [`delay` timeout](#options) so that users have enough time to read the toast.

```html
<div class="toast" role="alert" aria-live="polite" aria-atomic="true" data-bs-delay="10000">
  <div role="alert" aria-live="assertive" aria-atomic="true">...</div>
</div>
```

When using `autohide: false`, you must add a close button to allow users to dismiss the toast.

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
     &lt;div aria-atomic=&quot;true&quot; aria-live=&quot;assertive&quot; class=&quot;toast&quot; data-bs-autohide=&quot;false&quot; role=&quot;alert&quot;&gt;
&lt;div class=&quot;toast-header&quot;&gt;
&lt;svg aria-hidden=&quot;true&quot; class=&quot;bd-placeholder-img rounded me-2&quot; height=&quot;20&quot; preserveaspectratio=&quot;xMidYMid slice&quot; width=&quot;20&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;rect fill=&quot;#007aff&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;/svg&gt;
&lt;strong class=&quot;me-auto&quot;&gt;Bootstrap&lt;/strong&gt;
&lt;small&gt;11 mins ago&lt;/small&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;toast&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;toast-body&quot;&gt;
    Hello, world! This is a toast message.
  &lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div role="alert" aria-live="assertive" aria-atomic="true" class="toast" data-bs-autohide="false">
  <div class="toast-header">
    <img src="..." class="rounded me-2" alt="...">
    <strong class="me-auto">Bootstrap</strong>
    <small>11 mins ago</small>
    <button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button>
  </div>
  <div class="toast-body">
    Hello, world! This is a toast message.
  </div>
</div>
```

While technically it’s possible to add focusable/actionable controls (such as additional buttons or links) in your toast, you should avoid doing this for autohiding toasts. Even if you give the toast a long [`delay` timeout](#options), keyboard and assistive technology users may find it difficult to reach the toast in time to take action (since toasts don’t receive focus when they are displayed). If you absolutely must have further controls, we recommend using a toast with `autohide: false`.

## CSS

### Variables

Added in v5.2.0

As part of Bootstrap’s evolving CSS variables approach, toasts now use local CSS variables on `.toast` for enhanced real-time customization. Values for the CSS variables are set via Sass, so Sass customization is still supported, too.

[scss/\_toasts.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_toasts.scss)

```html
--#{$prefix}toast-zindex: #{$zindex-toast};
--#{$prefix}toast-padding-x: #{$toast-padding-x};
--#{$prefix}toast-padding-y: #{$toast-padding-y};
--#{$prefix}toast-spacing: #{$toast-spacing};
--#{$prefix}toast-max-width: #{$toast-max-width};
@include rfs($toast-font-size, --#{$prefix}toast-font-size);
--#{$prefix}toast-color: #{$toast-color};
--#{$prefix}toast-bg: #{$toast-background-color};
--#{$prefix}toast-border-width: #{$toast-border-width};
--#{$prefix}toast-border-color: #{$toast-border-color};
--#{$prefix}toast-border-radius: #{$toast-border-radius};
--#{$prefix}toast-box-shadow: #{$toast-box-shadow};
--#{$prefix}toast-header-color: #{$toast-header-color};
--#{$prefix}toast-header-bg: #{$toast-header-background-color};
--#{$prefix}toast-header-border-color: #{$toast-header-border-color};
```

### Sass variables

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$toast-max-width:                   350px;
$toast-padding-x:                   .75rem;
$toast-padding-y:                   .5rem;
$toast-font-size:                   .875rem;
$toast-color:                       null;
$toast-background-color:            rgba(var(--#{$prefix}body-bg-rgb), .85);
$toast-border-width:                var(--#{$prefix}border-width);
$toast-border-color:                var(--#{$prefix}border-color-translucent);
$toast-border-radius:               var(--#{$prefix}border-radius);
$toast-box-shadow:                  var(--#{$prefix}box-shadow);
$toast-spacing:                     $container-padding-x;

$toast-header-color:                var(--#{$prefix}secondary-color);
$toast-header-background-color:     rgba(var(--#{$prefix}body-bg-rgb), .85);
$toast-header-border-color:         $toast-border-color;
```

## Usage

Initialize toasts via JavaScript:

```html
const toastElList = document.querySelectorAll('.toast')
const toastList = [...toastElList].map(toastEl => new bootstrap.Toast(toastEl, option))
```

### Triggers

Dismissal can be achieved with the `data-bs-dismiss` attribute on a button **within the toast** as demonstrated below:

```html
<button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button>
```

or on a button **outside the toast** using the additional `data-bs-target` as demonstrated below:

```html
<button type="button" class="btn-close" data-bs-dismiss="toast" data-bs-target="#my-toast" aria-label="Close"></button>
```

### Options

As options can be passed via data attributes or JavaScript, you can append an option name to `data-bs-`, as in `data-bs-animation="{value}"`. Make sure to change the case type of the option name from “*camelCase*” to “*kebab-case*” when passing the options via data attributes. For example, use `data-bs-custom-class="beautifier"` instead of `data-bs-customClass="beautifier"`.

As of Bootstrap 5.2.0, all components support an **experimental** reserved data attribute `data-bs-config` that can house simple component configuration as a JSON string. When an element has `data-bs-config='{"delay":0, "title":123}'` and `data-bs-title="456"` attributes, the final `title` value will be `456` and the separate data attributes will override values given on `data-bs-config`. In addition, existing data attributes are able to house JSON values like `data-bs-delay='{"show":0,"hide":150}'`.

The final configuration object is the merged result of `data-bs-config`, `data-bs-`, and `js object` where the latest given key-value overrides the others.

| Name | Type | Default | Description |
| --- | --- | --- | --- |
| `animation` | boolean | `true` | Apply a CSS fade transition to the toast. |
| `autohide` | boolean | `true` | Automatically hide the toast after the delay. |
| `delay` | number | `5000` | Delay in milliseconds before hiding the toast. |

### Methods

**All API methods are asynchronous and start a transition.** They return to the caller as soon as the transition is started, but before it ends. In addition, a method call on a transitioning component will be ignored. [Learn more in our JavaScript docs.](/docs/5.3/getting-started/javascript/#asynchronous-functions-and-transitions)

| Method | Description |
| --- | --- |
| `dispose` | Hides an element’s toast. Your toast will remain on the DOM but won’t show anymore. |
| `getInstance` | *Static* method which allows you to get the toast instance associated with a DOM element.   For example: `const myToastEl = document.getElementById('myToastEl')` `const myToast = bootstrap.Toast.getInstance(myToastEl)` Returns a Bootstrap toast instance. |
| `getOrCreateInstance` | *Static* method which allows you to get the toast instance associated with a DOM element, or create a new one, in case it wasn’t initialized.  `const myToastEl = document.getElementById('myToastEl')` `const myToast = bootstrap.Toast.getOrCreateInstance(myToastEl)` Returns a Bootstrap toast instance. |
| `hide` | Hides an element’s toast. **Returns to the caller before the toast has actually been hidden** (i.e. before the `hidden.bs.toast` event occurs). You have to manually call this method if you made `autohide` to `false`. |
| `isShown` | Returns a boolean according to toast’s visibility state. |
| `show` | Reveals an element’s toast. **Returns to the caller before the toast has actually been shown** (i.e. before the `shown.bs.toast` event occurs). You have to manually call this method, instead your toast won’t show. |

### Events

| Event | Description |
| --- | --- |
| `hide.bs.toast` | This event is fired immediately when the `hide` instance method has been called. |
| `hidden.bs.toast` | This event is fired when the toast has finished being hidden from the user. |
| `show.bs.toast` | This event fires immediately when the `show` instance method is called. |
| `shown.bs.toast` | This event is fired when the toast has been made visible to the user. |

```html
const myToastEl = document.getElementById('myToast')
myToastEl.addEventListener('hidden.bs.toast', () => {
  // do something...
})
```

