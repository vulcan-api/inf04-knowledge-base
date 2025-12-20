> Źródło: [https://getbootstrap.com/docs/5.3/forms/floating-labels](https://getbootstrap.com/docs/5.3/forms/floating-labels)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/forms/floating-labels.mdx "View and edit this file on GitHub")

# Floating labels

Create beautifully simple form labels that float over your input fields.

On this page
   
**On this page**

---

* [Example](#example)
* [Textareas](#textareas)
* [Selects](#selects)
* [Disabled](#disabled)
* [Readonly plaintext](#readonly-plaintext)
* [Input groups](#input-groups)
* [Layout](#layout)
* [CSS](#css)
  + [Sass variables](#sass-variables)

## Example

Wrap a pair of `<input class="form-control">` and `<label>` elements in `.form-floating` to enable floating labels with Bootstrap’s textual form fields.

A non-empty `placeholder` attribute is required on each `<input>` as our CSS-only floating label implementation relies on the `:placeholder-shown` pseudo-element to detect when the input is empty. The placeholder text itself is not visible; only the `<label>` is shown to users.

Also note that the `<input>` must come first so we can utilize a sibling selector (i.e., `~`).

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
     &lt;div class=&quot;form-floating mb-3&quot;&gt;
&lt;input class=&quot;form-control&quot; id=&quot;floatingInput&quot; placeholder=&quot;name@example.com&quot; type=&quot;email&quot;/&gt;
&lt;label for=&quot;floatingInput&quot;&gt;Email address&lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-floating&quot;&gt;
&lt;input class=&quot;form-control&quot; id=&quot;floatingPassword&quot; placeholder=&quot;Password&quot; type=&quot;password&quot;/&gt;
&lt;label for=&quot;floatingPassword&quot;&gt;Password&lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="form-floating mb-3">
  <input type="email" class="form-control" id="floatingInput" placeholder="name@example.com">
  <label for="floatingInput">Email address</label>
</div>
<div class="form-floating">
  <input type="password" class="form-control" id="floatingPassword" placeholder="Password">
  <label for="floatingPassword">Password</label>
</div>
```

When there’s a `value` already defined, `<label>`s will automatically adjust to their floated position.

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
     &lt;form class=&quot;form-floating&quot;&gt;
&lt;input class=&quot;form-control&quot; id=&quot;floatingInputValue&quot; placeholder=&quot;name@example.com&quot; type=&quot;email&quot; value=&quot;test@example.com&quot;/&gt;
&lt;label for=&quot;floatingInputValue&quot;&gt;Input with value&lt;/label&gt;
&lt;/form&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<form class="form-floating">
  <input type="email" class="form-control" id="floatingInputValue" placeholder="name@example.com" value="test@example.com">
  <label for="floatingInputValue">Input with value</label>
</form>
```

Form validation styles also work as expected.

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
     &lt;form class=&quot;form-floating&quot;&gt;
&lt;input class=&quot;form-control is-invalid&quot; id=&quot;floatingInputInvalid&quot; placeholder=&quot;name@example.com&quot; type=&quot;email&quot; value=&quot;test@example.com&quot;/&gt;
&lt;label for=&quot;floatingInputInvalid&quot;&gt;Invalid input&lt;/label&gt;
&lt;/form&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<form class="form-floating">
  <input type="email" class="form-control is-invalid" id="floatingInputInvalid" placeholder="name@example.com" value="test@example.com">
  <label for="floatingInputInvalid">Invalid input</label>
</form>
```

## Textareas

By default, `<textarea>`s with `.form-control` will be the same height as `<input>`s.

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
     &lt;div class=&quot;form-floating&quot;&gt;
&lt;textarea class=&quot;form-control&quot; id=&quot;floatingTextarea&quot; placeholder=&quot;Leave a comment here&quot;&gt;&lt;/textarea&gt;
&lt;label for=&quot;floatingTextarea&quot;&gt;Comments&lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="form-floating">
  <textarea class="form-control" placeholder="Leave a comment here" id="floatingTextarea"></textarea>
  <label for="floatingTextarea">Comments</label>
</div>
```

To set a custom height on your `<textarea>`, do not use the `rows` attribute. Instead, set an explicit `height` (either inline or via custom CSS).

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
     &lt;div class=&quot;form-floating&quot;&gt;
&lt;textarea class=&quot;form-control&quot; id=&quot;floatingTextarea2&quot; placeholder=&quot;Leave a comment here&quot; style=&quot;height: 100px&quot;&gt;&lt;/textarea&gt;
&lt;label for=&quot;floatingTextarea2&quot;&gt;Comments&lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="form-floating">
  <textarea class="form-control" placeholder="Leave a comment here" id="floatingTextarea2" style="height: 100px"></textarea>
  <label for="floatingTextarea2">Comments</label>
</div>
```

## Selects

Other than `.form-control`, floating labels are only available on `.form-select`s. They work in the same way, but unlike `<input>`s, they’ll always show the `<label>` in its floated state. **Selects with `size` and `multiple` are not supported.**

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
     &lt;div class=&quot;form-floating&quot;&gt;
&lt;select aria-label=&quot;Floating label select example&quot; class=&quot;form-select&quot; id=&quot;floatingSelect&quot;&gt;
&lt;option selected=&quot;&quot;&gt;Open this select menu&lt;/option&gt;
&lt;option value=&quot;1&quot;&gt;One&lt;/option&gt;
&lt;option value=&quot;2&quot;&gt;Two&lt;/option&gt;
&lt;option value=&quot;3&quot;&gt;Three&lt;/option&gt;
&lt;/select&gt;
&lt;label for=&quot;floatingSelect&quot;&gt;Works with selects&lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="form-floating">
  <select class="form-select" id="floatingSelect" aria-label="Floating label select example">
    <option selected>Open this select menu</option>
    <option value="1">One</option>
    <option value="2">Two</option>
    <option value="3">Three</option>
  </select>
  <label for="floatingSelect">Works with selects</label>
</div>
```

## Disabled

Add the `disabled` boolean attribute on an input, a textarea or a select to give it a grayed out appearance, remove pointer events, and prevent focusing.

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
     &lt;div class=&quot;form-floating mb-3&quot;&gt;
&lt;input class=&quot;form-control&quot; disabled=&quot;&quot; id=&quot;floatingInputDisabled&quot; placeholder=&quot;name@example.com&quot; type=&quot;email&quot;/&gt;
&lt;label for=&quot;floatingInputDisabled&quot;&gt;Email address&lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-floating mb-3&quot;&gt;
&lt;textarea class=&quot;form-control&quot; disabled=&quot;&quot; id=&quot;floatingTextareaDisabled&quot; placeholder=&quot;Leave a comment here&quot;&gt;&lt;/textarea&gt;
&lt;label for=&quot;floatingTextareaDisabled&quot;&gt;Comments&lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-floating mb-3&quot;&gt;
&lt;textarea class=&quot;form-control&quot; disabled=&quot;&quot; id=&quot;floatingTextarea2Disabled&quot; placeholder=&quot;Leave a comment here&quot; style=&quot;height: 100px&quot;&gt;Disabled textarea with some text inside&lt;/textarea&gt;
&lt;label for=&quot;floatingTextarea2Disabled&quot;&gt;Comments&lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-floating&quot;&gt;
&lt;select aria-label=&quot;Floating label disabled select example&quot; class=&quot;form-select&quot; disabled=&quot;&quot; id=&quot;floatingSelectDisabled&quot;&gt;
&lt;option selected=&quot;&quot;&gt;Open this select menu&lt;/option&gt;
&lt;option value=&quot;1&quot;&gt;One&lt;/option&gt;
&lt;option value=&quot;2&quot;&gt;Two&lt;/option&gt;
&lt;option value=&quot;3&quot;&gt;Three&lt;/option&gt;
&lt;/select&gt;
&lt;label for=&quot;floatingSelectDisabled&quot;&gt;Works with selects&lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="form-floating mb-3">
  <input type="email" class="form-control" id="floatingInputDisabled" placeholder="name@example.com" disabled>
  <label for="floatingInputDisabled">Email address</label>
</div>
<div class="form-floating mb-3">
  <textarea class="form-control" placeholder="Leave a comment here" id="floatingTextareaDisabled" disabled></textarea>
  <label for="floatingTextareaDisabled">Comments</label>
</div>
<div class="form-floating mb-3">
  <textarea class="form-control" placeholder="Leave a comment here" id="floatingTextarea2Disabled" style="height: 100px" disabled>Disabled textarea with some text inside</textarea>
  <label for="floatingTextarea2Disabled">Comments</label>
</div>
<div class="form-floating">
  <select class="form-select" id="floatingSelectDisabled" aria-label="Floating label disabled select example" disabled>
    <option selected>Open this select menu</option>
    <option value="1">One</option>
    <option value="2">Two</option>
    <option value="3">Three</option>
  </select>
  <label for="floatingSelectDisabled">Works with selects</label>
</div>
```

## Readonly plaintext

Floating labels also support `.form-control-plaintext`, which can be helpful for toggling from an editable `<input>` to a plaintext value without affecting the page layout.

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
     &lt;div class=&quot;form-floating mb-3&quot;&gt;
&lt;input class=&quot;form-control-plaintext&quot; id=&quot;floatingEmptyPlaintextInput&quot; placeholder=&quot;name@example.com&quot; readonly=&quot;&quot; type=&quot;email&quot;/&gt;
&lt;label for=&quot;floatingEmptyPlaintextInput&quot;&gt;Empty input&lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-floating mb-3&quot;&gt;
&lt;input class=&quot;form-control-plaintext&quot; id=&quot;floatingPlaintextInput&quot; placeholder=&quot;name@example.com&quot; readonly=&quot;&quot; type=&quot;email&quot; value=&quot;name@example.com&quot;/&gt;
&lt;label for=&quot;floatingPlaintextInput&quot;&gt;Input with value&lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="form-floating mb-3">
  <input type="email" readonly class="form-control-plaintext" id="floatingEmptyPlaintextInput" placeholder="name@example.com">
  <label for="floatingEmptyPlaintextInput">Empty input</label>
</div>
<div class="form-floating mb-3">
  <input type="email" readonly class="form-control-plaintext" id="floatingPlaintextInput" placeholder="name@example.com" value="name@example.com">
  <label for="floatingPlaintextInput">Input with value</label>
</div>
```

## Input groups

Floating labels also support `.input-group`.

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
     &lt;div class=&quot;input-group mb-3&quot;&gt;
&lt;span class=&quot;input-group-text&quot;&gt;@&lt;/span&gt;
&lt;div class=&quot;form-floating&quot;&gt;
&lt;input class=&quot;form-control&quot; id=&quot;floatingInputGroup1&quot; placeholder=&quot;Username&quot; type=&quot;text&quot;/&gt;
&lt;label for=&quot;floatingInputGroup1&quot;&gt;Username&lt;/label&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="input-group mb-3">
  <span class="input-group-text">@</span>
  <div class="form-floating">
    <input type="text" class="form-control" id="floatingInputGroup1" placeholder="Username">
    <label for="floatingInputGroup1">Username</label>
  </div>
</div>
```

When using `.input-group` and `.form-floating` along with form validation, the `-feedback` should be placed outside of the `.form-floating`, but inside of the `.input-group`. This means that the feedback will need to be shown using javascript.

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
     &lt;div class=&quot;input-group has-validation&quot;&gt;
&lt;span class=&quot;input-group-text&quot;&gt;@&lt;/span&gt;
&lt;div class=&quot;form-floating is-invalid&quot;&gt;
&lt;input class=&quot;form-control is-invalid&quot; id=&quot;floatingInputGroup2&quot; placeholder=&quot;Username&quot; required=&quot;&quot; type=&quot;text&quot;/&gt;
&lt;label for=&quot;floatingInputGroup2&quot;&gt;Username&lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;invalid-feedback&quot;&gt;
    Please choose a username.
  &lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="input-group has-validation">
  <span class="input-group-text">@</span>
  <div class="form-floating is-invalid">
    <input type="text" class="form-control is-invalid" id="floatingInputGroup2" placeholder="Username" required>
    <label for="floatingInputGroup2">Username</label>
  </div>
  <div class="invalid-feedback">
    Please choose a username.
  </div>
</div>
```

## Layout

When working with the Bootstrap grid system, be sure to place form elements within column classes.

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
     &lt;div class=&quot;row g-2&quot;&gt;
&lt;div class=&quot;col-md&quot;&gt;
&lt;div class=&quot;form-floating&quot;&gt;
&lt;input class=&quot;form-control&quot; id=&quot;floatingInputGrid&quot; placeholder=&quot;name@example.com&quot; type=&quot;email&quot; value=&quot;mdo@example.com&quot;/&gt;
&lt;label for=&quot;floatingInputGrid&quot;&gt;Email address&lt;/label&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md&quot;&gt;
&lt;div class=&quot;form-floating&quot;&gt;
&lt;select class=&quot;form-select&quot; id=&quot;floatingSelectGrid&quot;&gt;
&lt;option selected=&quot;&quot;&gt;Open this select menu&lt;/option&gt;
&lt;option value=&quot;1&quot;&gt;One&lt;/option&gt;
&lt;option value=&quot;2&quot;&gt;Two&lt;/option&gt;
&lt;option value=&quot;3&quot;&gt;Three&lt;/option&gt;
&lt;/select&gt;
&lt;label for=&quot;floatingSelectGrid&quot;&gt;Works with selects&lt;/label&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="row g-2">
  <div class="col-md">
    <div class="form-floating">
      <input type="email" class="form-control" id="floatingInputGrid" placeholder="name@example.com" value="mdo@example.com">
      <label for="floatingInputGrid">Email address</label>
    </div>
  </div>
  <div class="col-md">
    <div class="form-floating">
      <select class="form-select" id="floatingSelectGrid">
        <option selected>Open this select menu</option>
        <option value="1">One</option>
        <option value="2">Two</option>
        <option value="3">Three</option>
      </select>
      <label for="floatingSelectGrid">Works with selects</label>
    </div>
  </div>
</div>
```

## CSS

### Sass variables

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$form-floating-height:                  add(3.5rem, $input-height-border);
$form-floating-line-height:             1.25;
$form-floating-padding-x:               $input-padding-x;
$form-floating-padding-y:               1rem;
$form-floating-input-padding-t:         1.625rem;
$form-floating-input-padding-b:         .625rem;
$form-floating-label-height:            1.5em;
$form-floating-label-opacity:           .65;
$form-floating-label-transform:         scale(.85) translateY(-.5rem) translateX(.15rem);
$form-floating-label-disabled-color:    $gray-600;
$form-floating-transition:              opacity .1s ease-in-out, transform .1s ease-in-out;
```

