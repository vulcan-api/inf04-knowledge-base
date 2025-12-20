> Źródło: [https://getbootstrap.com/docs/5.3/forms/validation](https://getbootstrap.com/docs/5.3/forms/validation)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/forms/validation.mdx "View and edit this file on GitHub")

# Validation

Provide valuable, actionable feedback to your users with HTML5 form validation, via browser default behaviors or custom styles and JavaScript.

On this page
   
**On this page**

---

* [How it works](#how-it-works)
* [Custom styles](#custom-styles)
* [Browser defaults](#browser-defaults)
* [Server-side](#server-side)
* [Supported elements](#supported-elements)
* [Tooltips](#tooltips)
* [CSS](#css)
  + [Variables](#variables)
  + [Sass variables](#sass-variables)
  + [Sass mixins](#sass-mixins)
  + [Sass maps](#sass-maps)
  + [Sass loops](#sass-loops)
  + [Customizing](#customizing)

We are aware that currently the client-side custom validation styles and tooltips are not accessible, since they are not exposed to assistive technologies. While we work on a solution, we’d recommend either using the server-side option or the default browser validation method.

## How it works

Here’s how form validation works with Bootstrap:

* HTML form validation is applied via CSS’s two pseudo-classes, `:invalid` and `:valid`. It applies to `<input>`, `<select>`, and `<textarea>` elements.
* Bootstrap scopes the `:invalid` and `:valid` styles to parent `.was-validated` class, usually applied to the `<form>`. Otherwise, any required field without a value shows up as invalid on page load. This way, you may choose when to activate them (typically after form submission is attempted).
* To reset the appearance of the form (for instance, in the case of dynamic form submissions using Ajax), remove the `.was-validated` class from the `<form>` again after submission.
* As a fallback, `.is-invalid` and `.is-valid` classes may be used instead of the pseudo-classes for [server-side validation](#server-side). They do not require a `.was-validated` parent class.
* Due to constraints in how CSS works, we cannot (at present) apply styles to a `<label>` that comes before a form control in the DOM without the help of custom JavaScript.
* All modern browsers support the [constraint validation API](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#the-constraint-validation-api), a series of JavaScript methods for validating form controls.
* Feedback messages may utilize the [browser defaults](#browser-defaults) (different for each browser, and unstylable via CSS) or our custom feedback styles with additional HTML and CSS.
* You may provide custom validity messages with `setCustomValidity` in JavaScript.

With that in mind, consider the following demos for our custom form validation styles, optional server-side classes, and browser defaults.

## Custom styles

For custom Bootstrap form validation messages, you’ll need to add the `novalidate` boolean attribute to your `<form>`. This disables the browser default feedback tooltips, but still provides access to the form validation APIs in JavaScript. Try to submit the form below; our JavaScript will intercept the submit button and relay feedback to you. When attempting to submit, you’ll see the `:invalid` and `:valid` styles applied to your form controls.

Custom feedback styles apply custom colors, borders, focus styles, and background icons to better communicate feedback. Background icons for `<select>`s are only available with `.form-select`, and not `.form-control`.

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
     &lt;form class=&quot;row g-3 needs-validation&quot; novalidate=&quot;&quot;&gt;
&lt;div class=&quot;col-md-4&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationCustom01&quot;&gt;First name&lt;/label&gt;
&lt;input class=&quot;form-control&quot; id=&quot;validationCustom01&quot; required=&quot;&quot; type=&quot;text&quot; value=&quot;Mark&quot;/&gt;
&lt;div class=&quot;valid-feedback&quot;&gt;
      Looks good!
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-4&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationCustom02&quot;&gt;Last name&lt;/label&gt;
&lt;input class=&quot;form-control&quot; id=&quot;validationCustom02&quot; required=&quot;&quot; type=&quot;text&quot; value=&quot;Otto&quot;/&gt;
&lt;div class=&quot;valid-feedback&quot;&gt;
      Looks good!
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-4&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationCustomUsername&quot;&gt;Username&lt;/label&gt;
&lt;div class=&quot;input-group has-validation&quot;&gt;
&lt;span class=&quot;input-group-text&quot; id=&quot;inputGroupPrepend&quot;&gt;@&lt;/span&gt;
&lt;input aria-describedby=&quot;inputGroupPrepend&quot; class=&quot;form-control&quot; id=&quot;validationCustomUsername&quot; required=&quot;&quot; type=&quot;text&quot;/&gt;
&lt;div class=&quot;invalid-feedback&quot;&gt;
        Please choose a username.
      &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-6&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationCustom03&quot;&gt;City&lt;/label&gt;
&lt;input class=&quot;form-control&quot; id=&quot;validationCustom03&quot; required=&quot;&quot; type=&quot;text&quot;/&gt;
&lt;div class=&quot;invalid-feedback&quot;&gt;
      Please provide a valid city.
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-3&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationCustom04&quot;&gt;State&lt;/label&gt;
&lt;select class=&quot;form-select&quot; id=&quot;validationCustom04&quot; required=&quot;&quot;&gt;
&lt;option disabled=&quot;&quot; selected=&quot;&quot; value=&quot;&quot;&gt;Choose...&lt;/option&gt;
&lt;option&gt;...&lt;/option&gt;
&lt;/select&gt;
&lt;div class=&quot;invalid-feedback&quot;&gt;
      Please select a valid state.
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-3&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationCustom05&quot;&gt;Zip&lt;/label&gt;
&lt;input class=&quot;form-control&quot; id=&quot;validationCustom05&quot; required=&quot;&quot; type=&quot;text&quot;/&gt;
&lt;div class=&quot;invalid-feedback&quot;&gt;
      Please provide a valid zip.
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-12&quot;&gt;
&lt;div class=&quot;form-check&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;invalidCheck&quot; required=&quot;&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;invalidCheck&quot;&gt;
        Agree to terms and conditions
      &lt;/label&gt;
&lt;div class=&quot;invalid-feedback&quot;&gt;
        You must agree before submitting.
      &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-12&quot;&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;submit&quot;&gt;Submit form&lt;/button&gt;
&lt;/div&gt;
&lt;/form&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<form class="row g-3 needs-validation" novalidate>
  <div class="col-md-4">
    <label for="validationCustom01" class="form-label">First name</label>
    <input type="text" class="form-control" id="validationCustom01" value="Mark" required>
    <div class="valid-feedback">
      Looks good!
    </div>
  </div>
  <div class="col-md-4">
    <label for="validationCustom02" class="form-label">Last name</label>
    <input type="text" class="form-control" id="validationCustom02" value="Otto" required>
    <div class="valid-feedback">
      Looks good!
    </div>
  </div>
  <div class="col-md-4">
    <label for="validationCustomUsername" class="form-label">Username</label>
    <div class="input-group has-validation">
      <span class="input-group-text" id="inputGroupPrepend">@</span>
      <input type="text" class="form-control" id="validationCustomUsername" aria-describedby="inputGroupPrepend" required>
      <div class="invalid-feedback">
        Please choose a username.
      </div>
    </div>
  </div>
  <div class="col-md-6">
    <label for="validationCustom03" class="form-label">City</label>
    <input type="text" class="form-control" id="validationCustom03" required>
    <div class="invalid-feedback">
      Please provide a valid city.
    </div>
  </div>
  <div class="col-md-3">
    <label for="validationCustom04" class="form-label">State</label>
    <select class="form-select" id="validationCustom04" required>
      <option selected disabled value="">Choose...</option>
      <option>...</option>
    </select>
    <div class="invalid-feedback">
      Please select a valid state.
    </div>
  </div>
  <div class="col-md-3">
    <label for="validationCustom05" class="form-label">Zip</label>
    <input type="text" class="form-control" id="validationCustom05" required>
    <div class="invalid-feedback">
      Please provide a valid zip.
    </div>
  </div>
  <div class="col-12">
    <div class="form-check">
      <input class="form-check-input" type="checkbox" value="" id="invalidCheck" required>
      <label class="form-check-label" for="invalidCheck">
        Agree to terms and conditions
      </label>
      <div class="invalid-feedback">
        You must agree before submitting.
      </div>
    </div>
  </div>
  <div class="col-12">
    <button class="btn btn-primary" type="submit">Submit form</button>
  </div>
</form>
```

```html
// Example starter JavaScript for disabling form submissions if there are invalid fields
(() => {
  'use strict'

  // Fetch all the forms we want to apply custom Bootstrap validation styles to
  const forms = document.querySelectorAll('.needs-validation')

  // Loop over them and prevent submission
  Array.from(forms).forEach(form => {
    form.addEventListener('submit', event => {
      if (!form.checkValidity()) {
        event.preventDefault()
        event.stopPropagation()
      }

      form.classList.add('was-validated')
    }, false)
  })
})()
```

## Browser defaults

Not interested in custom validation feedback messages or writing JavaScript to change form behaviors? All good, you can use the browser defaults. Try submitting the form below. Depending on your browser and OS, you’ll see a slightly different style of feedback.

While these feedback styles cannot be styled with CSS, you can still customize the feedback text through JavaScript.

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
     &lt;form class=&quot;row g-3&quot;&gt;
&lt;div class=&quot;col-md-4&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationDefault01&quot;&gt;First name&lt;/label&gt;
&lt;input class=&quot;form-control&quot; id=&quot;validationDefault01&quot; required=&quot;&quot; type=&quot;text&quot; value=&quot;Mark&quot;/&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-4&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationDefault02&quot;&gt;Last name&lt;/label&gt;
&lt;input class=&quot;form-control&quot; id=&quot;validationDefault02&quot; required=&quot;&quot; type=&quot;text&quot; value=&quot;Otto&quot;/&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-4&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationDefaultUsername&quot;&gt;Username&lt;/label&gt;
&lt;div class=&quot;input-group&quot;&gt;
&lt;span class=&quot;input-group-text&quot; id=&quot;inputGroupPrepend2&quot;&gt;@&lt;/span&gt;
&lt;input aria-describedby=&quot;inputGroupPrepend2&quot; class=&quot;form-control&quot; id=&quot;validationDefaultUsername&quot; required=&quot;&quot; type=&quot;text&quot;/&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-6&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationDefault03&quot;&gt;City&lt;/label&gt;
&lt;input class=&quot;form-control&quot; id=&quot;validationDefault03&quot; required=&quot;&quot; type=&quot;text&quot;/&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-3&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationDefault04&quot;&gt;State&lt;/label&gt;
&lt;select class=&quot;form-select&quot; id=&quot;validationDefault04&quot; required=&quot;&quot;&gt;
&lt;option disabled=&quot;&quot; selected=&quot;&quot; value=&quot;&quot;&gt;Choose...&lt;/option&gt;
&lt;option&gt;...&lt;/option&gt;
&lt;/select&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-3&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationDefault05&quot;&gt;Zip&lt;/label&gt;
&lt;input class=&quot;form-control&quot; id=&quot;validationDefault05&quot; required=&quot;&quot; type=&quot;text&quot;/&gt;
&lt;/div&gt;
&lt;div class=&quot;col-12&quot;&gt;
&lt;div class=&quot;form-check&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;invalidCheck2&quot; required=&quot;&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;invalidCheck2&quot;&gt;
        Agree to terms and conditions
      &lt;/label&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-12&quot;&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;submit&quot;&gt;Submit form&lt;/button&gt;
&lt;/div&gt;
&lt;/form&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<form class="row g-3">
  <div class="col-md-4">
    <label for="validationDefault01" class="form-label">First name</label>
    <input type="text" class="form-control" id="validationDefault01" value="Mark" required>
  </div>
  <div class="col-md-4">
    <label for="validationDefault02" class="form-label">Last name</label>
    <input type="text" class="form-control" id="validationDefault02" value="Otto" required>
  </div>
  <div class="col-md-4">
    <label for="validationDefaultUsername" class="form-label">Username</label>
    <div class="input-group">
      <span class="input-group-text" id="inputGroupPrepend2">@</span>
      <input type="text" class="form-control" id="validationDefaultUsername" aria-describedby="inputGroupPrepend2" required>
    </div>
  </div>
  <div class="col-md-6">
    <label for="validationDefault03" class="form-label">City</label>
    <input type="text" class="form-control" id="validationDefault03" required>
  </div>
  <div class="col-md-3">
    <label for="validationDefault04" class="form-label">State</label>
    <select class="form-select" id="validationDefault04" required>
      <option selected disabled value="">Choose...</option>
      <option>...</option>
    </select>
  </div>
  <div class="col-md-3">
    <label for="validationDefault05" class="form-label">Zip</label>
    <input type="text" class="form-control" id="validationDefault05" required>
  </div>
  <div class="col-12">
    <div class="form-check">
      <input class="form-check-input" type="checkbox" value="" id="invalidCheck2" required>
      <label class="form-check-label" for="invalidCheck2">
        Agree to terms and conditions
      </label>
    </div>
  </div>
  <div class="col-12">
    <button class="btn btn-primary" type="submit">Submit form</button>
  </div>
</form>
```

## Server-side

We recommend using client-side validation, but in case you require server-side validation, you can indicate invalid and valid form fields with `.is-invalid` and `.is-valid`. Note that `.invalid-feedback` is also supported with these classes.

For invalid fields, ensure that the invalid feedback/error message is associated with the relevant form field using `aria-describedby` (noting that this attribute allows more than one `id` to be referenced, in case the field already points to additional form text).

To fix [issues with border radius](https://github.com/twbs/bootstrap/issues/25110), input groups require an additional `.has-validation` class.

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
     &lt;form class=&quot;row g-3&quot;&gt;
&lt;div class=&quot;col-md-4&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationServer01&quot;&gt;First name&lt;/label&gt;
&lt;input class=&quot;form-control is-valid&quot; id=&quot;validationServer01&quot; required=&quot;&quot; type=&quot;text&quot; value=&quot;Mark&quot;/&gt;
&lt;div class=&quot;valid-feedback&quot;&gt;
      Looks good!
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-4&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationServer02&quot;&gt;Last name&lt;/label&gt;
&lt;input class=&quot;form-control is-valid&quot; id=&quot;validationServer02&quot; required=&quot;&quot; type=&quot;text&quot; value=&quot;Otto&quot;/&gt;
&lt;div class=&quot;valid-feedback&quot;&gt;
      Looks good!
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-4&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationServerUsername&quot;&gt;Username&lt;/label&gt;
&lt;div class=&quot;input-group has-validation&quot;&gt;
&lt;span class=&quot;input-group-text&quot; id=&quot;inputGroupPrepend3&quot;&gt;@&lt;/span&gt;
&lt;input aria-describedby=&quot;inputGroupPrepend3 validationServerUsernameFeedback&quot; class=&quot;form-control is-invalid&quot; id=&quot;validationServerUsername&quot; required=&quot;&quot; type=&quot;text&quot;/&gt;
&lt;div class=&quot;invalid-feedback&quot; id=&quot;validationServerUsernameFeedback&quot;&gt;
        Please choose a username.
      &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-6&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationServer03&quot;&gt;City&lt;/label&gt;
&lt;input aria-describedby=&quot;validationServer03Feedback&quot; class=&quot;form-control is-invalid&quot; id=&quot;validationServer03&quot; required=&quot;&quot; type=&quot;text&quot;/&gt;
&lt;div class=&quot;invalid-feedback&quot; id=&quot;validationServer03Feedback&quot;&gt;
      Please provide a valid city.
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-3&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationServer04&quot;&gt;State&lt;/label&gt;
&lt;select aria-describedby=&quot;validationServer04Feedback&quot; class=&quot;form-select is-invalid&quot; id=&quot;validationServer04&quot; required=&quot;&quot;&gt;
&lt;option disabled=&quot;&quot; selected=&quot;&quot; value=&quot;&quot;&gt;Choose...&lt;/option&gt;
&lt;option&gt;...&lt;/option&gt;
&lt;/select&gt;
&lt;div class=&quot;invalid-feedback&quot; id=&quot;validationServer04Feedback&quot;&gt;
      Please select a valid state.
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-3&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationServer05&quot;&gt;Zip&lt;/label&gt;
&lt;input aria-describedby=&quot;validationServer05Feedback&quot; class=&quot;form-control is-invalid&quot; id=&quot;validationServer05&quot; required=&quot;&quot; type=&quot;text&quot;/&gt;
&lt;div class=&quot;invalid-feedback&quot; id=&quot;validationServer05Feedback&quot;&gt;
      Please provide a valid zip.
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-12&quot;&gt;
&lt;div class=&quot;form-check&quot;&gt;
&lt;input aria-describedby=&quot;invalidCheck3Feedback&quot; class=&quot;form-check-input is-invalid&quot; id=&quot;invalidCheck3&quot; required=&quot;&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;invalidCheck3&quot;&gt;
        Agree to terms and conditions
      &lt;/label&gt;
&lt;div class=&quot;invalid-feedback&quot; id=&quot;invalidCheck3Feedback&quot;&gt;
        You must agree before submitting.
      &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-12&quot;&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;submit&quot;&gt;Submit form&lt;/button&gt;
&lt;/div&gt;
&lt;/form&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<form class="row g-3">
  <div class="col-md-4">
    <label for="validationServer01" class="form-label">First name</label>
    <input type="text" class="form-control is-valid" id="validationServer01" value="Mark" required>
    <div class="valid-feedback">
      Looks good!
    </div>
  </div>
  <div class="col-md-4">
    <label for="validationServer02" class="form-label">Last name</label>
    <input type="text" class="form-control is-valid" id="validationServer02" value="Otto" required>
    <div class="valid-feedback">
      Looks good!
    </div>
  </div>
  <div class="col-md-4">
    <label for="validationServerUsername" class="form-label">Username</label>
    <div class="input-group has-validation">
      <span class="input-group-text" id="inputGroupPrepend3">@</span>
      <input type="text" class="form-control is-invalid" id="validationServerUsername" aria-describedby="inputGroupPrepend3 validationServerUsernameFeedback" required>
      <div id="validationServerUsernameFeedback" class="invalid-feedback">
        Please choose a username.
      </div>
    </div>
  </div>
  <div class="col-md-6">
    <label for="validationServer03" class="form-label">City</label>
    <input type="text" class="form-control is-invalid" id="validationServer03" aria-describedby="validationServer03Feedback" required>
    <div id="validationServer03Feedback" class="invalid-feedback">
      Please provide a valid city.
    </div>
  </div>
  <div class="col-md-3">
    <label for="validationServer04" class="form-label">State</label>
    <select class="form-select is-invalid" id="validationServer04" aria-describedby="validationServer04Feedback" required>
      <option selected disabled value="">Choose...</option>
      <option>...</option>
    </select>
    <div id="validationServer04Feedback" class="invalid-feedback">
      Please select a valid state.
    </div>
  </div>
  <div class="col-md-3">
    <label for="validationServer05" class="form-label">Zip</label>
    <input type="text" class="form-control is-invalid" id="validationServer05" aria-describedby="validationServer05Feedback" required>
    <div id="validationServer05Feedback" class="invalid-feedback">
      Please provide a valid zip.
    </div>
  </div>
  <div class="col-12">
    <div class="form-check">
      <input class="form-check-input is-invalid" type="checkbox" value="" id="invalidCheck3" aria-describedby="invalidCheck3Feedback" required>
      <label class="form-check-label" for="invalidCheck3">
        Agree to terms and conditions
      </label>
      <div id="invalidCheck3Feedback" class="invalid-feedback">
        You must agree before submitting.
      </div>
    </div>
  </div>
  <div class="col-12">
    <button class="btn btn-primary" type="submit">Submit form</button>
  </div>
</form>
```

## Supported elements

Validation styles are available for the following form controls and components:

* `<input>`s and `<textarea>`s with `.form-control` (including up to one `.form-control` in input groups)
* `<select>`s with `.form-select`
* `.form-check`s

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
     &lt;form class=&quot;was-validated&quot;&gt;
&lt;div class=&quot;mb-3&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationTextarea&quot;&gt;Textarea&lt;/label&gt;
&lt;textarea class=&quot;form-control&quot; id=&quot;validationTextarea&quot; placeholder=&quot;Required example textarea&quot; required=&quot;&quot;&gt;&lt;/textarea&gt;
&lt;div class=&quot;invalid-feedback&quot;&gt;
      Please enter a message in the textarea.
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check mb-3&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;validationFormCheck1&quot; required=&quot;&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;validationFormCheck1&quot;&gt;Check this checkbox&lt;/label&gt;
&lt;div class=&quot;invalid-feedback&quot;&gt;Example invalid feedback text&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;validationFormCheck2&quot; name=&quot;radio-stacked&quot; required=&quot;&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;validationFormCheck2&quot;&gt;Toggle this radio&lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check mb-3&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;validationFormCheck3&quot; name=&quot;radio-stacked&quot; required=&quot;&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;validationFormCheck3&quot;&gt;Or toggle this other radio&lt;/label&gt;
&lt;div class=&quot;invalid-feedback&quot;&gt;More example invalid feedback text&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;mb-3&quot;&gt;
&lt;select aria-label=&quot;select example&quot; class=&quot;form-select&quot; required=&quot;&quot;&gt;
&lt;option value=&quot;&quot;&gt;Open this select menu&lt;/option&gt;
&lt;option value=&quot;1&quot;&gt;One&lt;/option&gt;
&lt;option value=&quot;2&quot;&gt;Two&lt;/option&gt;
&lt;option value=&quot;3&quot;&gt;Three&lt;/option&gt;
&lt;/select&gt;
&lt;div class=&quot;invalid-feedback&quot;&gt;Example invalid select feedback&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;mb-3&quot;&gt;
&lt;input aria-label=&quot;file example&quot; class=&quot;form-control&quot; required=&quot;&quot; type=&quot;file&quot;/&gt;
&lt;div class=&quot;invalid-feedback&quot;&gt;Example invalid form file feedback&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;mb-3&quot;&gt;
&lt;button class=&quot;btn btn-primary&quot; disabled=&quot;&quot; type=&quot;submit&quot;&gt;Submit form&lt;/button&gt;
&lt;/div&gt;
&lt;/form&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<form class="was-validated">
  <div class="mb-3">
    <label for="validationTextarea" class="form-label">Textarea</label>
    <textarea class="form-control" id="validationTextarea" placeholder="Required example textarea" required></textarea>
    <div class="invalid-feedback">
      Please enter a message in the textarea.
    </div>
  </div>

  <div class="form-check mb-3">
    <input type="checkbox" class="form-check-input" id="validationFormCheck1" required>
    <label class="form-check-label" for="validationFormCheck1">Check this checkbox</label>
    <div class="invalid-feedback">Example invalid feedback text</div>
  </div>

  <div class="form-check">
    <input type="radio" class="form-check-input" id="validationFormCheck2" name="radio-stacked" required>
    <label class="form-check-label" for="validationFormCheck2">Toggle this radio</label>
  </div>
  <div class="form-check mb-3">
    <input type="radio" class="form-check-input" id="validationFormCheck3" name="radio-stacked" required>
    <label class="form-check-label" for="validationFormCheck3">Or toggle this other radio</label>
    <div class="invalid-feedback">More example invalid feedback text</div>
  </div>

  <div class="mb-3">
    <select class="form-select" required aria-label="select example">
      <option value="">Open this select menu</option>
      <option value="1">One</option>
      <option value="2">Two</option>
      <option value="3">Three</option>
    </select>
    <div class="invalid-feedback">Example invalid select feedback</div>
  </div>

  <div class="mb-3">
    <input type="file" class="form-control" aria-label="file example" required>
    <div class="invalid-feedback">Example invalid form file feedback</div>
  </div>

  <div class="mb-3">
    <button class="btn btn-primary" type="submit" disabled>Submit form</button>
  </div>
</form>
```

## Tooltips

If your form layout allows it, you can swap the `.{valid|invalid}-feedback` classes for `.{valid|invalid}-tooltip` classes to display validation feedback in a styled tooltip. Be sure to have a parent with `position: relative` on it for tooltip positioning. In the example below, our column classes have this already, but your project may require an alternative setup.

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
     &lt;form class=&quot;row g-3 needs-validation&quot; novalidate=&quot;&quot;&gt;
&lt;div class=&quot;col-md-4 position-relative&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationTooltip01&quot;&gt;First name&lt;/label&gt;
&lt;input class=&quot;form-control&quot; id=&quot;validationTooltip01&quot; required=&quot;&quot; type=&quot;text&quot; value=&quot;Mark&quot;/&gt;
&lt;div class=&quot;valid-tooltip&quot;&gt;
      Looks good!
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-4 position-relative&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationTooltip02&quot;&gt;Last name&lt;/label&gt;
&lt;input class=&quot;form-control&quot; id=&quot;validationTooltip02&quot; required=&quot;&quot; type=&quot;text&quot; value=&quot;Otto&quot;/&gt;
&lt;div class=&quot;valid-tooltip&quot;&gt;
      Looks good!
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-4 position-relative&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationTooltipUsername&quot;&gt;Username&lt;/label&gt;
&lt;div class=&quot;input-group has-validation&quot;&gt;
&lt;span class=&quot;input-group-text&quot; id=&quot;validationTooltipUsernamePrepend&quot;&gt;@&lt;/span&gt;
&lt;input aria-describedby=&quot;validationTooltipUsernamePrepend&quot; class=&quot;form-control&quot; id=&quot;validationTooltipUsername&quot; required=&quot;&quot; type=&quot;text&quot;/&gt;
&lt;div class=&quot;invalid-tooltip&quot;&gt;
        Please choose a unique and valid username.
      &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-6 position-relative&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationTooltip03&quot;&gt;City&lt;/label&gt;
&lt;input class=&quot;form-control&quot; id=&quot;validationTooltip03&quot; required=&quot;&quot; type=&quot;text&quot;/&gt;
&lt;div class=&quot;invalid-tooltip&quot;&gt;
      Please provide a valid city.
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-3 position-relative&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationTooltip04&quot;&gt;State&lt;/label&gt;
&lt;select class=&quot;form-select&quot; id=&quot;validationTooltip04&quot; required=&quot;&quot;&gt;
&lt;option disabled=&quot;&quot; selected=&quot;&quot; value=&quot;&quot;&gt;Choose...&lt;/option&gt;
&lt;option&gt;...&lt;/option&gt;
&lt;/select&gt;
&lt;div class=&quot;invalid-tooltip&quot;&gt;
      Please select a valid state.
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-3 position-relative&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;validationTooltip05&quot;&gt;Zip&lt;/label&gt;
&lt;input class=&quot;form-control&quot; id=&quot;validationTooltip05&quot; required=&quot;&quot; type=&quot;text&quot;/&gt;
&lt;div class=&quot;invalid-tooltip&quot;&gt;
      Please provide a valid zip.
    &lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-12&quot;&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;submit&quot;&gt;Submit form&lt;/button&gt;
&lt;/div&gt;
&lt;/form&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<form class="row g-3 needs-validation" novalidate>
  <div class="col-md-4 position-relative">
    <label for="validationTooltip01" class="form-label">First name</label>
    <input type="text" class="form-control" id="validationTooltip01" value="Mark" required>
    <div class="valid-tooltip">
      Looks good!
    </div>
  </div>
  <div class="col-md-4 position-relative">
    <label for="validationTooltip02" class="form-label">Last name</label>
    <input type="text" class="form-control" id="validationTooltip02" value="Otto" required>
    <div class="valid-tooltip">
      Looks good!
    </div>
  </div>
  <div class="col-md-4 position-relative">
    <label for="validationTooltipUsername" class="form-label">Username</label>
    <div class="input-group has-validation">
      <span class="input-group-text" id="validationTooltipUsernamePrepend">@</span>
      <input type="text" class="form-control" id="validationTooltipUsername" aria-describedby="validationTooltipUsernamePrepend" required>
      <div class="invalid-tooltip">
        Please choose a unique and valid username.
      </div>
    </div>
  </div>
  <div class="col-md-6 position-relative">
    <label for="validationTooltip03" class="form-label">City</label>
    <input type="text" class="form-control" id="validationTooltip03" required>
    <div class="invalid-tooltip">
      Please provide a valid city.
    </div>
  </div>
  <div class="col-md-3 position-relative">
    <label for="validationTooltip04" class="form-label">State</label>
    <select class="form-select" id="validationTooltip04" required>
      <option selected disabled value="">Choose...</option>
      <option>...</option>
    </select>
    <div class="invalid-tooltip">
      Please select a valid state.
    </div>
  </div>
  <div class="col-md-3 position-relative">
    <label for="validationTooltip05" class="form-label">Zip</label>
    <input type="text" class="form-control" id="validationTooltip05" required>
    <div class="invalid-tooltip">
      Please provide a valid zip.
    </div>
  </div>
  <div class="col-12">
    <button class="btn btn-primary" type="submit">Submit form</button>
  </div>
</form>
```

## CSS

### Variables

Added in v5.3.0

As part of Bootstrap’s evolving CSS variables approach, forms now use local CSS variables for validation for enhanced real-time customization. Values for the CSS variables are set via Sass, so Sass customization is still supported, too.

[scss/\_root.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_root.scss)

```html
--#{$prefix}form-valid-color: #{$form-valid-color};
--#{$prefix}form-valid-border-color: #{$form-valid-border-color};
--#{$prefix}form-invalid-color: #{$form-invalid-color};
--#{$prefix}form-invalid-border-color: #{$form-invalid-border-color};
```

These variables are also color mode adaptive, meaning they change color while in dark mode.

### Sass variables

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$form-feedback-margin-top:          $form-text-margin-top;
$form-feedback-font-size:           $form-text-font-size;
$form-feedback-font-style:          $form-text-font-style;
$form-feedback-valid-color:         $success;
$form-feedback-invalid-color:       $danger;

$form-feedback-icon-valid-color:    $form-feedback-valid-color;
$form-feedback-icon-valid:          url("data:image/svg+xml,<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 8 8'><path fill='#{$form-feedback-icon-valid-color}' d='M2.3 6.73.6 4.53c-.4-1.04.46-1.4 1.1-.8l1.1 1.4 3.4-3.8c.6-.63 1.6-.27 1.2.7l-4 4.6c-.43.5-.8.4-1.1.1'/></svg>");
$form-feedback-icon-invalid-color:  $form-feedback-invalid-color;
$form-feedback-icon-invalid:        url("data:image/svg+xml,<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 12 12' width='12' height='12' fill='none' stroke='#{$form-feedback-icon-invalid-color}'><circle cx='6' cy='6' r='4.5'/><path stroke-linejoin='round' d='M5.8 3.6h.4L6 6.5z'/><circle cx='6' cy='8.2' r='.6' fill='#{$form-feedback-icon-invalid-color}' stroke='none'/></svg>");
```

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$form-valid-color:                  $form-feedback-valid-color;
$form-valid-border-color:           $form-feedback-valid-color;
$form-invalid-color:                $form-feedback-invalid-color;
$form-invalid-border-color:         $form-feedback-invalid-color;
```

[scss/\_variables-dark.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables-dark.scss)

```html
$form-valid-color-dark:             $green-300;
$form-valid-border-color-dark:      $green-300;
$form-invalid-color-dark:           $red-300;
$form-invalid-border-color-dark:    $red-300;
```

### Sass mixins

Two mixins are combined, through our [loop](#sass-loops), to generate our form validation feedback styles.

[scss/mixins/\_forms.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/mixins/_forms.scss)

```html
@mixin form-validation-state-selector($state) {
  @if ($state == "valid" or $state == "invalid") {
    .was-validated #{if(&, "&", "")}:#{$state},
    #{if(&, "&", "")}.is-#{$state} {
      @content;
    }
  } @else {
    #{if(&, "&", "")}.is-#{$state} {
      @content;
    }
  }
}

@mixin form-validation-state(
  $state,
  $color,
  $icon,
  $tooltip-color: color-contrast($color),
  $tooltip-bg-color: rgba($color, $form-feedback-tooltip-opacity),
  $focus-box-shadow: 0 0 $input-btn-focus-blur $input-focus-width rgba($color, $input-btn-focus-color-opacity),
  $border-color: $color
) {
  .#{$state}-feedback {
    display: none;
    width: 100%;
    margin-top: $form-feedback-margin-top;
    @include font-size($form-feedback-font-size);
    font-style: $form-feedback-font-style;
    color: $color;
  }

  .#{$state}-tooltip {
    position: absolute;
    top: 100%;
    z-index: 5;
    display: none;
    max-width: 100%; // Contain to parent when possible
    padding: $form-feedback-tooltip-padding-y $form-feedback-tooltip-padding-x;
    margin-top: .1rem;
    @include font-size($form-feedback-tooltip-font-size);
    line-height: $form-feedback-tooltip-line-height;
    color: $tooltip-color;
    background-color: $tooltip-bg-color;
    @include border-radius($form-feedback-tooltip-border-radius);
  }

  @include form-validation-state-selector($state) {
    ~ .#{$state}-feedback,
    ~ .#{$state}-tooltip {
      display: block;
    }
  }

  .form-control {
    @include form-validation-state-selector($state) {
      border-color: $border-color;

      @if $enable-validation-icons {
        padding-right: $input-height-inner;
        background-image: escape-svg($icon);
        background-repeat: no-repeat;
        background-position: right $input-height-inner-quarter center;
        background-size: $input-height-inner-half $input-height-inner-half;
      }

      &:focus {
        border-color: $border-color;
        @if $enable-shadows {
          @include box-shadow($input-box-shadow, $focus-box-shadow);
        } @else {
          // Avoid using mixin so we can pass custom focus shadow properly
          box-shadow: $focus-box-shadow;
        }
      }
    }
  }

  // stylelint-disable-next-line selector-no-qualifying-type
  textarea.form-control {
    @include form-validation-state-selector($state) {
      @if $enable-validation-icons {
        padding-right: $input-height-inner;
        background-position: top $input-height-inner-quarter right $input-height-inner-quarter;
      }
    }
  }

  .form-select {
    @include form-validation-state-selector($state) {
      border-color: $border-color;

      @if $enable-validation-icons {
        &:not([multiple]):not([size]),
        &:not([multiple])[size="1"] {
          --#{$prefix}form-select-bg-icon: #{escape-svg($icon)};
          padding-right: $form-select-feedback-icon-padding-end;
          background-position: $form-select-bg-position, $form-select-feedback-icon-position;
          background-size: $form-select-bg-size, $form-select-feedback-icon-size;
        }
      }

      &:focus {
        border-color: $border-color;
        @if $enable-shadows {
          @include box-shadow($form-select-box-shadow, $focus-box-shadow);
        } @else {
          // Avoid using mixin so we can pass custom focus shadow properly
          box-shadow: $focus-box-shadow;
        }
      }
    }
  }

  .form-control-color {
    @include form-validation-state-selector($state) {
      @if $enable-validation-icons {
        width: add($form-color-width, $input-height-inner);
      }
    }
  }

  .form-check-input {
    @include form-validation-state-selector($state) {
      border-color: $border-color;

      &:checked {
        background-color: $color;
      }

      &:focus {
        box-shadow: $focus-box-shadow;
      }

      ~ .form-check-label {
        color: $color;
      }
    }
  }
  .form-check-inline .form-check-input {
    ~ .#{$state}-feedback {
      margin-left: .5em;
    }
  }

  .input-group {
    > .form-control:not(:focus),
    > .form-select:not(:focus),
    > .form-floating:not(:focus-within) {
      @include form-validation-state-selector($state) {
        @if $state == "valid" {
          z-index: 3;
        } @else if $state == "invalid" {
          z-index: 4;
        }
      }
    }
  }
}
```

### Sass maps

This is the validation Sass map from `_variables.scss`. Override or extend this to generate different or additional states.

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$form-validation-states: (
  "valid": (
    "color": var(--#{$prefix}form-valid-color),
    "icon": $form-feedback-icon-valid,
    "tooltip-color": #fff,
    "tooltip-bg-color": var(--#{$prefix}success),
    "focus-box-shadow": 0 0 $input-btn-focus-blur $input-focus-width rgba(var(--#{$prefix}success-rgb), $input-btn-focus-color-opacity),
    "border-color": var(--#{$prefix}form-valid-border-color),
  ),
  "invalid": (
    "color": var(--#{$prefix}form-invalid-color),
    "icon": $form-feedback-icon-invalid,
    "tooltip-color": #fff,
    "tooltip-bg-color": var(--#{$prefix}danger),
    "focus-box-shadow": 0 0 $input-btn-focus-blur $input-focus-width rgba(var(--#{$prefix}danger-rgb), $input-btn-focus-color-opacity),
    "border-color": var(--#{$prefix}form-invalid-border-color),
  )
);
```

Maps of `$form-validation-states` can contain three optional parameters to override tooltips and focus styles.

### Sass loops

Used to iterate over `$form-validation-states` map values to generate our validation styles. Any modifications to the above Sass map will be reflected in your compiled CSS via this loop.

[scss/forms/\_validation.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/forms/_validation.scss)

```html
@each $state, $data in $form-validation-states {
  @include form-validation-state($state, $data...);
}
```

### Customizing

Validation states can be customized via Sass with the `$form-validation-states` map. Located in our `_variables.scss` file, this Sass map is how we generate the default `valid`/`invalid` validation states. Included is a nested map for customizing each state’s color, icon, tooltip color, and focus shadow. While no other states are supported by browsers, those using custom styles can easily add more complex form feedback.

