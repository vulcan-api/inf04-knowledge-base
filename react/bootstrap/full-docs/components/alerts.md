> Źródło: [https://getbootstrap.com/docs/5.3/components/alerts](https://getbootstrap.com/docs/5.3/components/alerts)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/components/alerts.mdx "View and edit this file on GitHub")

# Alerts

Provide contextual feedback messages for typical user actions with the handful of available and flexible alert messages.

On this page
   
**On this page**

---

* [Examples](#examples)
  + [Live example](#live-example)
  + [Link color](#link-color)
  + [Additional content](#additional-content)
  + [Icons](#icons)
  + [Dismissing](#dismissing)
* [CSS](#css)
  + [Variables](#variables)
  + [Sass variables](#sass-variables)
  + [Sass mixins](#sass-mixins)
  + [Sass loops](#sass-loops)
* [JavaScript behavior](#javascript-behavior)
  + [Initialize](#initialize)
  + [Triggers](#triggers)
  + [Methods](#methods)
  + [Events](#events)

## Examples

Alerts are available for any length of text, as well as an optional close button. For proper styling, use one of the eight **required** contextual classes (e.g., `.alert-success`). For inline dismissal, use the [alerts JavaScript plugin](#dismissing).

**Heads up!** As of v5.3.0, the `alert-variant()` Sass mixin is deprecated. Alert variants now have their CSS variables overridden in [a Sass loop](#sass-loops).

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
     &lt;div class=&quot;alert alert-primary&quot; role=&quot;alert&quot;&gt;
  A simple primary alert—check it out!
&lt;/div&gt;
&lt;div class=&quot;alert alert-secondary&quot; role=&quot;alert&quot;&gt;
  A simple secondary alert—check it out!
&lt;/div&gt;
&lt;div class=&quot;alert alert-success&quot; role=&quot;alert&quot;&gt;
  A simple success alert—check it out!
&lt;/div&gt;
&lt;div class=&quot;alert alert-danger&quot; role=&quot;alert&quot;&gt;
  A simple danger alert—check it out!
&lt;/div&gt;
&lt;div class=&quot;alert alert-warning&quot; role=&quot;alert&quot;&gt;
  A simple warning alert—check it out!
&lt;/div&gt;
&lt;div class=&quot;alert alert-info&quot; role=&quot;alert&quot;&gt;
  A simple info alert—check it out!
&lt;/div&gt;
&lt;div class=&quot;alert alert-light&quot; role=&quot;alert&quot;&gt;
  A simple light alert—check it out!
&lt;/div&gt;
&lt;div class=&quot;alert alert-dark&quot; role=&quot;alert&quot;&gt;
  A simple dark alert—check it out!
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="alert alert-primary" role="alert">
  A simple primary alert—check it out!
</div>
<div class="alert alert-secondary" role="alert">
  A simple secondary alert—check it out!
</div>
<div class="alert alert-success" role="alert">
  A simple success alert—check it out!
</div>
<div class="alert alert-danger" role="alert">
  A simple danger alert—check it out!
</div>
<div class="alert alert-warning" role="alert">
  A simple warning alert—check it out!
</div>
<div class="alert alert-info" role="alert">
  A simple info alert—check it out!
</div>
<div class="alert alert-light" role="alert">
  A simple light alert—check it out!
</div>
<div class="alert alert-dark" role="alert">
  A simple dark alert—check it out!
</div>
```

**Accessibility tip:** Using color to add meaning only provides a visual indication, which will not be conveyed to users of assistive technologies like screen readers. Please ensure the meaning is obvious from the content itself (e.g., the visible text with a [*sufficient* color contrast](/docs/5.3/getting-started/accessibility/#color-contrast)) or is included through alternative means, such as additional text hidden with the `.visually-hidden` class.

### Live example

Click the button below to show an alert (hidden with inline styles to start), then dismiss (and destroy) it with the built-in close button.

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
     &lt;div id=&quot;liveAlertPlaceholder&quot;&gt;&lt;/div&gt;
&lt;button class=&quot;btn btn-primary&quot; id=&quot;liveAlertBtn&quot; type=&quot;button&quot;&gt;Show live alert&lt;/button&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div id="liveAlertPlaceholder"></div>
<button type="button" class="btn btn-primary" id="liveAlertBtn">Show live alert</button>
```

We use the following JavaScript to trigger our live alert demo:

[site/src/assets/partials/snippets.js](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/assets/partials/snippets.js)

```html
const alertPlaceholder = document.getElementById('liveAlertPlaceholder')
const appendAlert = (message, type) => {
  const wrapper = document.createElement('div')
  wrapper.innerHTML = [
    `<div class="alert alert-${type} alert-dismissible" role="alert">`,
    `   <div>${message}</div>`,
    '   <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>',
    '</div>'
  ].join('')

  alertPlaceholder.append(wrapper)
}

const alertTrigger = document.getElementById('liveAlertBtn')
if (alertTrigger) {
  alertTrigger.addEventListener('click', () => {
    appendAlert('Nice, you triggered this alert message!', 'success')
  })
}
```

### Link color

Use the `.alert-link` utility class to quickly provide matching colored links within any alert.

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
     &lt;div class=&quot;alert alert-primary&quot; role=&quot;alert&quot;&gt;
  A simple primary alert with &lt;a class=&quot;alert-link&quot; href=&quot;#&quot;&gt;an example link&lt;/a&gt;. Give it a click if you like.
&lt;/div&gt;
&lt;div class=&quot;alert alert-secondary&quot; role=&quot;alert&quot;&gt;
  A simple secondary alert with &lt;a class=&quot;alert-link&quot; href=&quot;#&quot;&gt;an example link&lt;/a&gt;. Give it a click if you like.
&lt;/div&gt;
&lt;div class=&quot;alert alert-success&quot; role=&quot;alert&quot;&gt;
  A simple success alert with &lt;a class=&quot;alert-link&quot; href=&quot;#&quot;&gt;an example link&lt;/a&gt;. Give it a click if you like.
&lt;/div&gt;
&lt;div class=&quot;alert alert-danger&quot; role=&quot;alert&quot;&gt;
  A simple danger alert with &lt;a class=&quot;alert-link&quot; href=&quot;#&quot;&gt;an example link&lt;/a&gt;. Give it a click if you like.
&lt;/div&gt;
&lt;div class=&quot;alert alert-warning&quot; role=&quot;alert&quot;&gt;
  A simple warning alert with &lt;a class=&quot;alert-link&quot; href=&quot;#&quot;&gt;an example link&lt;/a&gt;. Give it a click if you like.
&lt;/div&gt;
&lt;div class=&quot;alert alert-info&quot; role=&quot;alert&quot;&gt;
  A simple info alert with &lt;a class=&quot;alert-link&quot; href=&quot;#&quot;&gt;an example link&lt;/a&gt;. Give it a click if you like.
&lt;/div&gt;
&lt;div class=&quot;alert alert-light&quot; role=&quot;alert&quot;&gt;
  A simple light alert with &lt;a class=&quot;alert-link&quot; href=&quot;#&quot;&gt;an example link&lt;/a&gt;. Give it a click if you like.
&lt;/div&gt;
&lt;div class=&quot;alert alert-dark&quot; role=&quot;alert&quot;&gt;
  A simple dark alert with &lt;a class=&quot;alert-link&quot; href=&quot;#&quot;&gt;an example link&lt;/a&gt;. Give it a click if you like.
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="alert alert-primary" role="alert">
  A simple primary alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
</div>
<div class="alert alert-secondary" role="alert">
  A simple secondary alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
</div>
<div class="alert alert-success" role="alert">
  A simple success alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
</div>
<div class="alert alert-danger" role="alert">
  A simple danger alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
</div>
<div class="alert alert-warning" role="alert">
  A simple warning alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
</div>
<div class="alert alert-info" role="alert">
  A simple info alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
</div>
<div class="alert alert-light" role="alert">
  A simple light alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
</div>
<div class="alert alert-dark" role="alert">
  A simple dark alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
</div>
```

### Additional content

Alerts can also contain additional HTML elements like headings, paragraphs and dividers.

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
     &lt;div class=&quot;alert alert-success&quot; role=&quot;alert&quot;&gt;
&lt;h4 class=&quot;alert-heading&quot;&gt;Well done!&lt;/h4&gt;
&lt;p&gt;Aww yeah, you successfully read this important alert message. This example text is going to run a bit longer so that you can see how spacing within an alert works with this kind of content.&lt;/p&gt;
&lt;hr/&gt;
&lt;p class=&quot;mb-0&quot;&gt;Whenever you need to, be sure to use margin utilities to keep things nice and tidy.&lt;/p&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="alert alert-success" role="alert">
  <h4 class="alert-heading">Well done!</h4>
  <p>Aww yeah, you successfully read this important alert message. This example text is going to run a bit longer so that you can see how spacing within an alert works with this kind of content.</p>
  <hr>
  <p class="mb-0">Whenever you need to, be sure to use margin utilities to keep things nice and tidy.</p>
</div>
```

### Icons

Similarly, you can use [flexbox utilities](/docs/5.3/utilities/flex) and [Bootstrap Icons](https://icons.getbootstrap.com/) to create alerts with icons. Depending on your icons and content, you may want to add more utilities or custom styles.

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
     &lt;div class=&quot;alert alert-primary d-flex align-items-center&quot; role=&quot;alert&quot;&gt;
&lt;svg aria-label=&quot;Warning:&quot; class=&quot;bi flex-shrink-0 me-2&quot; role=&quot;img&quot; viewbox=&quot;0 0 16 16&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;
&lt;path d=&quot;M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z&quot;&gt;&lt;/path&gt;
&lt;/svg&gt;
&lt;div&gt;
    An example alert with an icon
  &lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="alert alert-primary d-flex align-items-center" role="alert">
  <svg xmlns="http://www.w3.org/2000/svg" class="bi flex-shrink-0 me-2" viewBox="0 0 16 16" role="img" aria-label="Warning:">
    <path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/>
  </svg>
  <div>
    An example alert with an icon
  </div>
</div>
```

Need more than one icon for your alerts? Consider using more Bootstrap Icons and making a local SVG sprite like so to easily reference the same icons repeatedly.

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
     &lt;svg class=&quot;d-none&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;
&lt;symbol id=&quot;check-circle-fill&quot; viewbox=&quot;0 0 16 16&quot;&gt;
&lt;path d=&quot;M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z&quot;&gt;&lt;/path&gt;
&lt;/symbol&gt;
&lt;symbol id=&quot;info-fill&quot; viewbox=&quot;0 0 16 16&quot;&gt;
&lt;path d=&quot;M8 16A8 8 0 1 0 8 0a8 8 0 0 0 0 16zm.93-9.412-1 4.705c-.07.34.029.533.304.533.194 0 .487-.07.686-.246l-.088.416c-.287.346-.92.598-1.465.598-.703 0-1.002-.422-.808-1.319l.738-3.468c.064-.293.006-.399-.287-.47l-.451-.081.082-.381 2.29-.287zM8 5.5a1 1 0 1 1 0-2 1 1 0 0 1 0 2z&quot;&gt;&lt;/path&gt;
&lt;/symbol&gt;
&lt;symbol id=&quot;exclamation-triangle-fill&quot; viewbox=&quot;0 0 16 16&quot;&gt;
&lt;path d=&quot;M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z&quot;&gt;&lt;/path&gt;
&lt;/symbol&gt;
&lt;/svg&gt;
&lt;div class=&quot;alert alert-primary d-flex align-items-center&quot; role=&quot;alert&quot;&gt;
&lt;svg aria-label=&quot;Info:&quot; class=&quot;bi flex-shrink-0 me-2&quot; role=&quot;img&quot;&gt;&lt;use xlink:href=&quot;#info-fill&quot;&gt;&lt;/use&gt;&lt;/svg&gt;
&lt;div&gt;
    An example alert with an icon
  &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;alert alert-success d-flex align-items-center&quot; role=&quot;alert&quot;&gt;
&lt;svg aria-label=&quot;Success:&quot; class=&quot;bi flex-shrink-0 me-2&quot; role=&quot;img&quot;&gt;&lt;use xlink:href=&quot;#check-circle-fill&quot;&gt;&lt;/use&gt;&lt;/svg&gt;
&lt;div&gt;
    An example success alert with an icon
  &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;alert alert-warning d-flex align-items-center&quot; role=&quot;alert&quot;&gt;
&lt;svg aria-label=&quot;Warning:&quot; class=&quot;bi flex-shrink-0 me-2&quot; role=&quot;img&quot;&gt;&lt;use xlink:href=&quot;#exclamation-triangle-fill&quot;&gt;&lt;/use&gt;&lt;/svg&gt;
&lt;div&gt;
    An example warning alert with an icon
  &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;alert alert-danger d-flex align-items-center&quot; role=&quot;alert&quot;&gt;
&lt;svg aria-label=&quot;Danger:&quot; class=&quot;bi flex-shrink-0 me-2&quot; role=&quot;img&quot;&gt;&lt;use xlink:href=&quot;#exclamation-triangle-fill&quot;&gt;&lt;/use&gt;&lt;/svg&gt;
&lt;div&gt;
    An example danger alert with an icon
  &lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<svg xmlns="http://www.w3.org/2000/svg" class="d-none">
  <symbol id="check-circle-fill" viewBox="0 0 16 16">
    <path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z"/>
  </symbol>
  <symbol id="info-fill" viewBox="0 0 16 16">
    <path d="M8 16A8 8 0 1 0 8 0a8 8 0 0 0 0 16zm.93-9.412-1 4.705c-.07.34.029.533.304.533.194 0 .487-.07.686-.246l-.088.416c-.287.346-.92.598-1.465.598-.703 0-1.002-.422-.808-1.319l.738-3.468c.064-.293.006-.399-.287-.47l-.451-.081.082-.381 2.29-.287zM8 5.5a1 1 0 1 1 0-2 1 1 0 0 1 0 2z"/>
  </symbol>
  <symbol id="exclamation-triangle-fill" viewBox="0 0 16 16">
    <path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/>
  </symbol>
</svg>

<div class="alert alert-primary d-flex align-items-center" role="alert">
  <svg class="bi flex-shrink-0 me-2" role="img" aria-label="Info:"><use xlink:href="#info-fill"/></svg>
  <div>
    An example alert with an icon
  </div>
</div>
<div class="alert alert-success d-flex align-items-center" role="alert">
  <svg class="bi flex-shrink-0 me-2" role="img" aria-label="Success:"><use xlink:href="#check-circle-fill"/></svg>
  <div>
    An example success alert with an icon
  </div>
</div>
<div class="alert alert-warning d-flex align-items-center" role="alert">
  <svg class="bi flex-shrink-0 me-2" role="img" aria-label="Warning:"><use xlink:href="#exclamation-triangle-fill"/></svg>
  <div>
    An example warning alert with an icon
  </div>
</div>
<div class="alert alert-danger d-flex align-items-center" role="alert">
  <svg class="bi flex-shrink-0 me-2" role="img" aria-label="Danger:"><use xlink:href="#exclamation-triangle-fill"/></svg>
  <div>
    An example danger alert with an icon
  </div>
</div>
```

### Dismissing

Using the alert JavaScript plugin, it’s possible to dismiss any alert inline. Here’s how:

* Be sure you’ve loaded the alert plugin, or the compiled Bootstrap JavaScript.
* Add a [close button](/docs/5.3/components/close-button) and the `.alert-dismissible` class, which adds extra padding to the right of the alert and positions the close button.
* On the close button, add the `data-bs-dismiss="alert"` attribute, which triggers the JavaScript functionality. Be sure to use the `<button>` element with it for proper behavior across all devices.
* To animate alerts when dismissing them, be sure to add the `.fade` and `.show` classes.

You can see this in action with a live demo:

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
     &lt;div class=&quot;alert alert-warning alert-dismissible fade show&quot; role=&quot;alert&quot;&gt;
&lt;strong&gt;Holy guacamole!&lt;/strong&gt; You should check in on some of those fields below.
  &lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;alert&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="alert alert-warning alert-dismissible fade show" role="alert">
  <strong>Holy guacamole!</strong> You should check in on some of those fields below.
  <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
</div>
```

When an alert is dismissed, the element is completely removed from the page structure. If a keyboard user dismisses the alert using the close button, their focus will suddenly be lost and, depending on the browser, reset to the start of the page/document. For this reason, we recommend including additional JavaScript that listens for the `closed.bs.alert` event and programmatically sets `focus()` to the most appropriate location in the page. If you’re planning to move focus to a non-interactive element that normally does not receive focus, make sure to add `tabindex="-1"` to the element.

## CSS

### Variables

Added in v5.2.0

As part of Bootstrap’s evolving CSS variables approach, alerts now use local CSS variables on `.alert` for enhanced real-time customization. Values for the CSS variables are set via Sass, so Sass customization is still supported, too.

[scss/\_alert.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_alert.scss)

```html
--#{$prefix}alert-bg: transparent;
--#{$prefix}alert-padding-x: #{$alert-padding-x};
--#{$prefix}alert-padding-y: #{$alert-padding-y};
--#{$prefix}alert-margin-bottom: #{$alert-margin-bottom};
--#{$prefix}alert-color: inherit;
--#{$prefix}alert-border-color: transparent;
--#{$prefix}alert-border: #{$alert-border-width} solid var(--#{$prefix}alert-border-color);
--#{$prefix}alert-border-radius: #{$alert-border-radius};
--#{$prefix}alert-link-color: inherit;
```

### Sass variables

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$alert-padding-y:               $spacer;
$alert-padding-x:               $spacer;
$alert-margin-bottom:           1rem;
$alert-border-radius:           var(--#{$prefix}border-radius);
$alert-link-font-weight:        $font-weight-bold;
$alert-border-width:            var(--#{$prefix}border-width);
$alert-dismissible-padding-r:   $alert-padding-x * 3; // 3x covers width of x plus default padding on either side
```

### Sass mixins

Deprecated in v5.3.0 

[scss/mixins/\_alert.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/mixins/_alert.scss)

```html
@mixin alert-variant($background, $border, $color) {
  --#{$prefix}alert-color: #{$color};
  --#{$prefix}alert-bg: #{$background};
  --#{$prefix}alert-border-color: #{$border};
  --#{$prefix}alert-link-color: #{shade-color($color, 20%)};

  @if $enable-gradients {
    background-image: var(--#{$prefix}gradient);
  }

  .alert-link {
    color: var(--#{$prefix}alert-link-color);
  }
}
```

### Sass loops

Loop that generates the modifier classes with an overriding of CSS variables.

[scss/\_alert.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_alert.scss)

```html
// Generate contextual modifier classes for colorizing the alert
@each $state in map-keys($theme-colors) {
  .alert-#{$state} {
    --#{$prefix}alert-color: var(--#{$prefix}#{$state}-text-emphasis);
    --#{$prefix}alert-bg: var(--#{$prefix}#{$state}-bg-subtle);
    --#{$prefix}alert-border-color: var(--#{$prefix}#{$state}-border-subtle);
    --#{$prefix}alert-link-color: var(--#{$prefix}#{$state}-text-emphasis);
  }
}
```

## JavaScript behavior

### Initialize

Initialize elements as alerts

```html
const alertList = document.querySelectorAll('.alert')
const alerts = [...alertList].map(element => new bootstrap.Alert(element))
```

For the sole purpose of dismissing an alert, it isn’t necessary to initialize the component manually via the JS API. By making use of `data-bs-dismiss="alert"`, the component will be initialized automatically and properly dismissed.

See the [triggers](#triggers) section for more details.

### Triggers

Dismissal can be achieved with the `data-bs-dismiss` attribute on a button **within the alert** as demonstrated below:

```html
<button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
```

or on a button **outside the alert** using the additional `data-bs-target` as demonstrated below:

```html
<button type="button" class="btn-close" data-bs-dismiss="alert" data-bs-target="#my-alert" aria-label="Close"></button>
```

**Note that closing an alert will remove it from the DOM.**

### Methods

You can create an alert instance with the alert constructor, for example:

```html
const bsAlert = new bootstrap.Alert('#myAlert')
```

This makes an alert listen for click events on descendant elements which have the `data-bs-dismiss="alert"` attribute. (Not necessary when using the data-api’s auto-initialization.)

| Method | Description |
| --- | --- |
| `close` | Closes an alert by removing it from the DOM. If the `.fade` and `.show` classes are present on the element, the alert will fade out before it is removed. |
| `dispose` | Destroys an element’s alert. (Removes stored data on the DOM element) |
| `getInstance` | Static method which allows you to get the alert instance associated to a DOM element. For example: `bootstrap.Alert.getInstance(alert)`. |
| `getOrCreateInstance` | Static method which returns an alert instance associated to a DOM element or create a new one in case it wasn’t initialized. You can use it like this: `bootstrap.Alert.getOrCreateInstance(element)`. |

Basic usage:

```html
const alert = bootstrap.Alert.getOrCreateInstance('#myAlert')
alert.close()
```

### Events

Bootstrap’s alert plugin exposes a few events for hooking into alert functionality.

| Event | Description |
| --- | --- |
| `close.bs.alert` | Fires immediately when the `close` instance method is called. |
| `closed.bs.alert` | Fired when the alert has been closed and CSS transitions have completed. |

```html
const myAlert = document.getElementById('myAlert')
myAlert.addEventListener('closed.bs.alert', event => {
  // do something, for instance, explicitly move focus to the most appropriate element,
  // so it doesn’t get lost/reset to the start of the page
  // document.getElementById('...').focus()
})
```

