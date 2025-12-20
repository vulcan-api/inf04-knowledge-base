> Źródło: [https://getbootstrap.com/docs/5.3/components/modal](https://getbootstrap.com/docs/5.3/components/modal)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/components/modal.mdx "View and edit this file on GitHub")

# Modal

Use Bootstrap’s JavaScript modal plugin to add dialogs to your site for lightboxes, user notifications, or completely custom content.

On this page
   
**On this page**

---

* [How it works](#how-it-works)
* [Examples](#examples)
  + [Modal components](#modal-components)
  + [Live demo](#live-demo)
  + [Static backdrop](#static-backdrop)
  + [Scrolling long content](#scrolling-long-content)
  + [Vertically centered](#vertically-centered)
  + [Tooltips and popovers](#tooltips-and-popovers)
  + [Using the grid](#using-the-grid)
  + [Varying modal content](#varying-modal-content)
  + [Toggle between modals](#toggle-between-modals)
  + [Change animation](#change-animation)
  + [Remove animation](#remove-animation)
  + [Dynamic heights](#dynamic-heights)
  + [Accessibility](#accessibility)
  + [Embedding YouTube videos](#embedding-youtube-videos)
* [Optional sizes](#optional-sizes)
* [Fullscreen Modal](#fullscreen-modal)
* [CSS](#css)
  + [Variables](#variables)
  + [Sass variables](#sass-variables)
  + [Sass loops](#sass-loops)
* [Usage](#usage)
  + [Via data attributes](#via-data-attributes)
    - [Toggle](#toggle)
    - [Dismiss](#dismiss)
  + [Via JavaScript](#via-javascript)
  + [Options](#options)
  + [Methods](#methods)
    - [Passing options](#passing-options)
  + [Events](#events)

## How it works

Before getting started with Bootstrap’s modal component, be sure to read the following as our menu options have recently changed.

* Modals are built with HTML, CSS, and JavaScript. They’re positioned over everything else in the document and remove scroll from the `<body>` so that modal content scrolls instead.
* Clicking on the modal “backdrop” will automatically close the modal.
* Bootstrap only supports one modal window at a time. Nested modals aren’t supported as we believe them to be poor user experiences.
* Modals use `position: fixed`, which can sometimes be a bit particular about its rendering. Whenever possible, place your modal HTML in a top-level position to avoid potential interference from other elements. You’ll likely run into issues when nesting a `.modal` within another fixed element.
* Once again, due to `position: fixed`, there are some caveats with using modals on mobile devices. [See our browser support docs](/docs/5.3/getting-started/browsers-devices#modals-and-dropdowns-on-mobile) for details.
* Due to how HTML5 defines its semantics, [the `autofocus` HTML attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#attr-autofocus) has no effect in Bootstrap modals. To achieve the same effect, use some custom JavaScript:

```html
const myModal = document.getElementById('myModal')
const myInput = document.getElementById('myInput')

myModal.addEventListener('shown.bs.modal', () => {
  myInput.focus()
})
```

The animation effect of this component is dependent on the `prefers-reduced-motion` media query. See the [reduced motion section of our accessibility documentation](/docs/5.3/getting-started/accessibility/#reduced-motion).

Keep reading for demos and usage guidelines.

## Examples

### Modal components

Below is a *static* modal example (meaning its `position` and `display` have been overridden). Included are the modal header, modal body (required for `padding`), and modal footer (optional). We ask that you include modal headers with dismiss actions whenever possible, or provide another explicit dismiss action.

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
    &lt;div class=&quot;modal position-static d-block&quot; tabindex=&quot;-1&quot;&gt;&lt;div class=&quot;modal-dialog&quot;&gt;&lt;div class=&quot;modal-content&quot;&gt;&lt;div class=&quot;modal-header&quot;&gt;&lt;h5 class=&quot;modal-title&quot;&gt;Modal title&lt;/h5&gt;&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;modal&quot; type=&quot;button&quot;&gt;&lt;/button&gt;&lt;/div&gt;&lt;div class=&quot;modal-body&quot;&gt;&lt;p&gt;Modal body text goes here.&lt;/p&gt;&lt;/div&gt;&lt;div class=&quot;modal-footer&quot;&gt;&lt;button class=&quot;btn btn-secondary&quot; data-bs-dismiss=&quot;modal&quot; type=&quot;button&quot;&gt;Close&lt;/button&gt;&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;Save changes&lt;/button&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="modal" tabindex="-1">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title">Modal title</h5>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        <p>Modal body text goes here.</p>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Save changes</button>
      </div>
    </div>
  </div>
</div>
```

In the above static example, we use `<h5>`, to avoid issues with the heading hierarchy in the documentation page. Structurally, however, a modal dialog represents its own separate document/context, so the `.modal-title` should ideally be an `<h1>`. If necessary, you can use the [font size utilities](/docs/5.3/utilities/text#font-size) to control the heading’s appearance. All the following live examples use this approach.

### Live demo

Toggle a working modal demo by clicking the button below. It will slide down and fade in from the top of the page.

# Modal title

Woo-hoo, you’re reading this text in a modal!

CloseSave changes

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
    
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModalLive&quot; data-bs-toggle=&quot;modal&quot; type=&quot;button&quot;&gt;Launch demo modal&lt;/button&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<!-- Button trigger modal -->
<button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
  Launch demo modal
</button>

<!-- Modal -->
<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h1 class="modal-title fs-5" id="exampleModalLabel">Modal title</h1>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        ...
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Save changes</button>
      </div>
    </div>
  </div>
</div>
```

### Static backdrop

When backdrop is set to static, the modal will not close when clicking outside of it. Click the button below to try it.

# Modal title

I will not close if you click outside of me. Don’t even try to press escape key.

CloseUnderstood

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
    
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#staticBackdropLive&quot; data-bs-toggle=&quot;modal&quot; type=&quot;button&quot;&gt;Launch static backdrop modal&lt;/button&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<!-- Button trigger modal -->
<button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#staticBackdrop">
  Launch static backdrop modal
</button>

<!-- Modal -->
<div class="modal fade" id="staticBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h1 class="modal-title fs-5" id="staticBackdropLabel">Modal title</h1>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        ...
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Understood</button>
      </div>
    </div>
  </div>
</div>
```

### Scrolling long content

When modals become too long for the user’s viewport or device, they scroll independent of the page itself. Try the demo below to see what we mean.

# Modal title

This is some placeholder content to show the scrolling behavior for modals. Instead of repeating the text in the modal, we use an inline style to set a minimum height, thereby extending the length of the overall modal and demonstrating the overflow scrolling. When content becomes longer than the height of the viewport, scrolling will move the modal as needed.

CloseSave changes

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
    
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModalLong&quot; data-bs-toggle=&quot;modal&quot; type=&quot;button&quot;&gt;Launch demo modal&lt;/button&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

You can also create a scrollable modal that allows scrolling the modal body by adding `.modal-dialog-scrollable` to `.modal-dialog`.

# Modal title

This is some placeholder content to show the scrolling behavior for modals. We use repeated line breaks to demonstrate how content can exceed minimum inner height, thereby showing inner scrolling. When content becomes longer than the predefined max-height of modal, content will be cropped and scrollable within the modal.

  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  

This content should appear at the bottom after you scroll.

CloseSave changes

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
    
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModalScrollable&quot; data-bs-toggle=&quot;modal&quot; type=&quot;button&quot;&gt;Launch demo modal&lt;/button&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<!-- Scrollable modal -->
<div class="modal-dialog modal-dialog-scrollable">
  ...
</div>
```

### Vertically centered

Add `.modal-dialog-centered` to `.modal-dialog` to vertically center the modal.

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
     &lt;div aria-hidden=&quot;true&quot; aria-labelledby=&quot;exampleModalCenterTitle&quot; class=&quot;modal fade&quot; id=&quot;exampleModalCenter&quot; tabindex=&quot;-1&quot;&gt;
&lt;div class=&quot;modal-dialog modal-dialog-centered&quot;&gt;
&lt;div class=&quot;modal-content&quot;&gt;
&lt;div class=&quot;modal-header&quot;&gt;
&lt;h1 class=&quot;modal-title fs-5&quot; id=&quot;exampleModalCenterTitle&quot;&gt;Modal title&lt;/h1&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;modal&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;modal-body&quot;&gt;
&lt;p&gt;This is a vertically centered modal.&lt;/p&gt;
&lt;/div&gt;
&lt;div class=&quot;modal-footer&quot;&gt;
&lt;button class=&quot;btn btn-secondary&quot; data-bs-dismiss=&quot;modal&quot; type=&quot;button&quot;&gt;Close&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;Save changes&lt;/button&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-hidden=&quot;true&quot; aria-labelledby=&quot;exampleModalCenteredScrollableTitle&quot; class=&quot;modal fade&quot; id=&quot;exampleModalCenteredScrollable&quot; tabindex=&quot;-1&quot;&gt;
&lt;div class=&quot;modal-dialog modal-dialog-centered modal-dialog-scrollable&quot;&gt;
&lt;div class=&quot;modal-content&quot;&gt;
&lt;div class=&quot;modal-header&quot;&gt;
&lt;h1 class=&quot;modal-title fs-5&quot; id=&quot;exampleModalCenteredScrollableTitle&quot;&gt;Modal title&lt;/h1&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;modal&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;modal-body&quot;&gt;
&lt;p&gt;This is some placeholder content to show a vertically centered modal. We’ve added some extra copy here to show how vertically centering the modal works when combined with scrollable modals. We also use some repeated line breaks to quickly extend the height of the content, thereby triggering the scrolling. When content becomes longer than the predefined max-height of modal, content will be cropped and scrollable within the modal.&lt;/p&gt;
&lt;br/&gt;&lt;br/&gt;&lt;br/&gt;&lt;br/&gt;&lt;br/&gt;&lt;br/&gt;&lt;br/&gt;&lt;br/&gt;&lt;br/&gt;&lt;br/&gt;
&lt;p&gt;Just like that.&lt;/p&gt;
&lt;/div&gt;
&lt;div class=&quot;modal-footer&quot;&gt;
&lt;button class=&quot;btn btn-secondary&quot; data-bs-dismiss=&quot;modal&quot; type=&quot;button&quot;&gt;Close&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;Save changes&lt;/button&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModalCenter&quot; data-bs-toggle=&quot;modal&quot; type=&quot;button&quot;&gt;Vertically centered modal&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModalCenteredScrollable&quot; data-bs-toggle=&quot;modal&quot; type=&quot;button&quot;&gt;Vertically centered scrollable modal&lt;/button&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<!-- Vertically centered modal -->
<div class="modal-dialog modal-dialog-centered">
  ...
</div>

<!-- Vertically centered scrollable modal -->
<div class="modal-dialog modal-dialog-centered modal-dialog-scrollable">
  ...
</div>
```

### Tooltips and popovers

[Tooltips](/docs/5.3/components/tooltips) and [popovers](/docs/5.3/components/popovers) can be placed within modals as needed. When modals are closed, any tooltips and popovers within are also automatically dismissed.

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
     &lt;div aria-hidden=&quot;true&quot; aria-labelledby=&quot;exampleModalPopoversLabel&quot; class=&quot;modal fade&quot; id=&quot;exampleModalPopovers&quot; tabindex=&quot;-1&quot;&gt;
&lt;div class=&quot;modal-dialog&quot;&gt;
&lt;div class=&quot;modal-content&quot;&gt;
&lt;div class=&quot;modal-header&quot;&gt;
&lt;h1 class=&quot;modal-title fs-5&quot; id=&quot;exampleModalPopoversLabel&quot;&gt;Modal title&lt;/h1&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;modal&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;modal-body&quot;&gt;
&lt;h2 class=&quot;fs-5&quot;&gt;Popover in a modal&lt;/h2&gt;
&lt;p&gt;This &lt;button class=&quot;btn btn-secondary&quot; data-bs-container=&quot;#exampleModalPopovers&quot; data-bs-content=&quot;Popover body content is set in this attribute.&quot; data-bs-toggle=&quot;popover&quot; title=&quot;Popover title&quot;&gt;button&lt;/button&gt; triggers a popover on click.&lt;/p&gt;
&lt;hr/&gt;
&lt;h2 class=&quot;fs-5&quot;&gt;Tooltips in a modal&lt;/h2&gt;
&lt;p&gt;&lt;a data-bs-container=&quot;#exampleModalPopovers&quot; data-bs-toggle=&quot;tooltip&quot; href=&quot;#&quot; title=&quot;Tooltip&quot;&gt;This link&lt;/a&gt; and &lt;a data-bs-container=&quot;#exampleModalPopovers&quot; data-bs-toggle=&quot;tooltip&quot; href=&quot;#&quot; title=&quot;Tooltip&quot;&gt;that link&lt;/a&gt; have tooltips on hover.&lt;/p&gt;
&lt;/div&gt;
&lt;div class=&quot;modal-footer&quot;&gt;
&lt;button class=&quot;btn btn-secondary&quot; data-bs-dismiss=&quot;modal&quot; type=&quot;button&quot;&gt;Close&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;Save changes&lt;/button&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModalPopovers&quot; data-bs-toggle=&quot;modal&quot; type=&quot;button&quot;&gt;Launch demo modal&lt;/button&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="modal-body">
  <h2 class="fs-5">Popover in a modal</h2>
  <p>This <button class="btn btn-secondary" data-bs-toggle="popover" title="Popover title" data-bs-content="Popover body content is set in this attribute.">button</button> triggers a popover on click.</p>
  <hr>
  <h2 class="fs-5">Tooltips in a modal</h2>
  <p><a href="#" data-bs-toggle="tooltip" title="Tooltip">This link</a> and <a href="#" data-bs-toggle="tooltip" title="Tooltip">that link</a> have tooltips on hover.</p>
</div>
```

### Using the grid

Utilize the Bootstrap grid system within a modal by nesting `.container-fluid` within the `.modal-body`. Then, use the normal grid system classes as you would anywhere else.

# Grids in modals

.col-md-4

.col-md-4 .ms-auto

.col-md-3 .ms-auto

.col-md-2 .ms-auto

.col-md-6 .ms-auto

Level 1: .col-sm-9

Level 2: .col-8 .col-sm-6

Level 2: .col-4 .col-sm-6

CloseSave changes

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
    
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#gridSystemModal&quot; data-bs-toggle=&quot;modal&quot; type=&quot;button&quot;&gt;Launch demo modal&lt;/button&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="modal-body">
  <div class="container-fluid">
    <div class="row">
      <div class="col-md-4">.col-md-4</div>
      <div class="col-md-4 ms-auto">.col-md-4 .ms-auto</div>
    </div>
    <div class="row">
      <div class="col-md-3 ms-auto">.col-md-3 .ms-auto</div>
      <div class="col-md-2 ms-auto">.col-md-2 .ms-auto</div>
    </div>
    <div class="row">
      <div class="col-md-6 ms-auto">.col-md-6 .ms-auto</div>
    </div>
    <div class="row">
      <div class="col-sm-9">
        Level 1: .col-sm-9
        <div class="row">
          <div class="col-8 col-sm-6">
            Level 2: .col-8 .col-sm-6
          </div>
          <div class="col-4 col-sm-6">
            Level 2: .col-4 .col-sm-6
          </div>
        </div>
      </div>
    </div>
  </div>
</div>
```

### Varying modal content

Have a bunch of buttons that all trigger the same modal with slightly different contents? Use `event.relatedTarget` and [HTML `data-bs-*` attributes](https://developer.mozilla.org/en-US/docs/Learn/HTML/Howto/Use_data_attributes) to vary the contents of the modal depending on which button was clicked.

Below is a live demo followed by example HTML and JavaScript. For more information, [read the modal events docs](#events) for details on `relatedTarget`.

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
     &lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModal&quot; data-bs-toggle=&quot;modal&quot; data-bs-whatever=&quot;@mdo&quot; type=&quot;button&quot;&gt;Open modal for @mdo&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModal&quot; data-bs-toggle=&quot;modal&quot; data-bs-whatever=&quot;@fat&quot; type=&quot;button&quot;&gt;Open modal for @fat&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModal&quot; data-bs-toggle=&quot;modal&quot; data-bs-whatever=&quot;@getbootstrap&quot; type=&quot;button&quot;&gt;Open modal for @getbootstrap&lt;/button&gt;
&lt;div aria-hidden=&quot;true&quot; aria-labelledby=&quot;exampleModalLabel&quot; class=&quot;modal fade&quot; id=&quot;exampleModal&quot; tabindex=&quot;-1&quot;&gt;
&lt;div class=&quot;modal-dialog&quot;&gt;
&lt;div class=&quot;modal-content&quot;&gt;
&lt;div class=&quot;modal-header&quot;&gt;
&lt;h1 class=&quot;modal-title fs-5&quot; id=&quot;exampleModalLabel&quot;&gt;New message&lt;/h1&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;modal&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;modal-body&quot;&gt;
&lt;form&gt;
&lt;div class=&quot;mb-3&quot;&gt;
&lt;label class=&quot;col-form-label&quot; for=&quot;recipient-name&quot;&gt;Recipient:&lt;/label&gt;
&lt;input class=&quot;form-control&quot; id=&quot;recipient-name&quot; type=&quot;text&quot;/&gt;
&lt;/div&gt;
&lt;div class=&quot;mb-3&quot;&gt;
&lt;label class=&quot;col-form-label&quot; for=&quot;message-text&quot;&gt;Message:&lt;/label&gt;
&lt;textarea class=&quot;form-control&quot; id=&quot;message-text&quot;&gt;&lt;/textarea&gt;
&lt;/div&gt;
&lt;/form&gt;
&lt;/div&gt;
&lt;div class=&quot;modal-footer&quot;&gt;
&lt;button class=&quot;btn btn-secondary&quot; data-bs-dismiss=&quot;modal&quot; type=&quot;button&quot;&gt;Close&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;button&quot;&gt;Send message&lt;/button&gt;
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
<button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal" data-bs-whatever="@mdo">Open modal for @mdo</button>
<button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal" data-bs-whatever="@fat">Open modal for @fat</button>
<button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal" data-bs-whatever="@getbootstrap">Open modal for @getbootstrap</button>

<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h1 class="modal-title fs-5" id="exampleModalLabel">New message</h1>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        <form>
          <div class="mb-3">
            <label for="recipient-name" class="col-form-label">Recipient:</label>
            <input type="text" class="form-control" id="recipient-name">
          </div>
          <div class="mb-3">
            <label for="message-text" class="col-form-label">Message:</label>
            <textarea class="form-control" id="message-text"></textarea>
          </div>
        </form>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Send message</button>
      </div>
    </div>
  </div>
</div>
```

[site/src/assets/partials/snippets.js](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/assets/partials/snippets.js)

```html
const exampleModal = document.getElementById('exampleModal')
if (exampleModal) {
  exampleModal.addEventListener('show.bs.modal', event => {
    // Button that triggered the modal
    const button = event.relatedTarget
    // Extract info from data-bs-* attributes
    const recipient = button.getAttribute('data-bs-whatever')
    // If necessary, you could initiate an Ajax request here
    // and then do the updating in a callback.

    // Update the modal's content.
    const modalTitle = exampleModal.querySelector('.modal-title')
    const modalBodyInput = exampleModal.querySelector('.modal-body input')

    modalTitle.textContent = `New message to ${recipient}`
    modalBodyInput.value = recipient
  })
}
```

### Toggle between modals

Toggle between multiple modals with some clever placement of the `data-bs-target` and `data-bs-toggle` attributes. For example, you could toggle a password reset modal from within an already open sign in modal. **Please note multiple modals cannot be open at the same time**—this method simply toggles between two separate modals.

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
     &lt;div aria-hidden=&quot;true&quot; aria-labelledby=&quot;exampleModalToggleLabel&quot; class=&quot;modal fade&quot; id=&quot;exampleModalToggle&quot; tabindex=&quot;-1&quot;&gt;
&lt;div class=&quot;modal-dialog modal-dialog-centered&quot;&gt;
&lt;div class=&quot;modal-content&quot;&gt;
&lt;div class=&quot;modal-header&quot;&gt;
&lt;h1 class=&quot;modal-title fs-5&quot; id=&quot;exampleModalToggleLabel&quot;&gt;Modal 1&lt;/h1&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;modal&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;modal-body&quot;&gt;
        Show a second modal and hide this one with the button below.
      &lt;/div&gt;
&lt;div class=&quot;modal-footer&quot;&gt;
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModalToggle2&quot; data-bs-toggle=&quot;modal&quot;&gt;Open second modal&lt;/button&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-hidden=&quot;true&quot; aria-labelledby=&quot;exampleModalToggleLabel2&quot; class=&quot;modal fade&quot; id=&quot;exampleModalToggle2&quot; tabindex=&quot;-1&quot;&gt;
&lt;div class=&quot;modal-dialog modal-dialog-centered&quot;&gt;
&lt;div class=&quot;modal-content&quot;&gt;
&lt;div class=&quot;modal-header&quot;&gt;
&lt;h1 class=&quot;modal-title fs-5&quot; id=&quot;exampleModalToggleLabel2&quot;&gt;Modal 2&lt;/h1&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;modal&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;modal-body&quot;&gt;
        Hide this modal and show the first with the button below.
      &lt;/div&gt;
&lt;div class=&quot;modal-footer&quot;&gt;
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModalToggle&quot; data-bs-toggle=&quot;modal&quot;&gt;Back to first&lt;/button&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModalToggle&quot; data-bs-toggle=&quot;modal&quot;&gt;Open first modal&lt;/button&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="modal fade" id="exampleModalToggle" aria-hidden="true" aria-labelledby="exampleModalToggleLabel" tabindex="-1">
  <div class="modal-dialog modal-dialog-centered">
    <div class="modal-content">
      <div class="modal-header">
        <h1 class="modal-title fs-5" id="exampleModalToggleLabel">Modal 1</h1>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        Show a second modal and hide this one with the button below.
      </div>
      <div class="modal-footer">
        <button class="btn btn-primary" data-bs-target="#exampleModalToggle2" data-bs-toggle="modal">Open second modal</button>
      </div>
    </div>
  </div>
</div>
<div class="modal fade" id="exampleModalToggle2" aria-hidden="true" aria-labelledby="exampleModalToggleLabel2" tabindex="-1">
  <div class="modal-dialog modal-dialog-centered">
    <div class="modal-content">
      <div class="modal-header">
        <h1 class="modal-title fs-5" id="exampleModalToggleLabel2">Modal 2</h1>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        Hide this modal and show the first with the button below.
      </div>
      <div class="modal-footer">
        <button class="btn btn-primary" data-bs-target="#exampleModalToggle" data-bs-toggle="modal">Back to first</button>
      </div>
    </div>
  </div>
</div>
<button class="btn btn-primary" data-bs-target="#exampleModalToggle" data-bs-toggle="modal">Open first modal</button>
```

### Change animation

The `$modal-fade-transform` variable determines the transform state of `.modal-dialog` before the modal fade-in animation, the `$modal-show-transform` variable determines the transform of `.modal-dialog` at the end of the modal fade-in animation.

If you want for example a zoom-in animation, you can set `$modal-fade-transform: scale(.8)`.

### Remove animation

For modals that simply appear rather than fade in to view, remove the `.fade` class from your modal markup.

```html
<div class="modal" tabindex="-1" aria-labelledby="..." aria-hidden="true">
  ...
</div>
```

### Dynamic heights

If the height of a modal changes while it is open, you should call `myModal.handleUpdate()` to readjust the modal’s position in case a scrollbar appears.

### Accessibility

Be sure to add `aria-labelledby="..."`, referencing the modal title, to `.modal`. Additionally, you may give a description of your modal dialog with `aria-describedby` on `.modal`. Note that you don’t need to add `role="dialog"` since we already add it via JavaScript.

### Embedding YouTube videos

Embedding YouTube videos in modals requires additional JavaScript not in Bootstrap to automatically stop playback and more. [See this helpful Stack Overflow post](https://stackoverflow.com/questions/18622508/bootstrap-3-and-youtube-in-modal) for more information.

## Optional sizes

Modals have three optional sizes, available via modifier classes to be placed on a `.modal-dialog`. These sizes kick in at certain breakpoints to avoid horizontal scrollbars on narrower viewports.

| Size | Class | Modal max-width |
| --- | --- | --- |
| Small | `.modal-sm` | `300px` |
| Default | None | `500px` |
| Large | `.modal-lg` | `800px` |
| Extra large | `.modal-xl` | `1140px` |

Our default modal without modifier class constitutes the “medium” size modal.

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
     &lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModalXl&quot; data-bs-toggle=&quot;modal&quot; type=&quot;button&quot;&gt;Extra large modal&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModalLg&quot; data-bs-toggle=&quot;modal&quot; type=&quot;button&quot;&gt;Large modal&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModalSm&quot; data-bs-toggle=&quot;modal&quot; type=&quot;button&quot;&gt;Small modal&lt;/button&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="modal-dialog modal-xl">...</div>
<div class="modal-dialog modal-lg">...</div>
<div class="modal-dialog modal-sm">...</div>
```

# Extra large modal

...

# Large modal

...

# Small modal

...

## Fullscreen Modal

Another override is the option to pop up a modal that covers the user viewport, available via modifier classes that are placed on a `.modal-dialog`.

| Class | Availability |
| --- | --- |
| `.modal-fullscreen` | Always |
| `.modal-fullscreen-sm-down` | `576px` |
| `.modal-fullscreen-md-down` | `768px` |
| `.modal-fullscreen-lg-down` | `992px` |
| `.modal-fullscreen-xl-down` | `1200px` |
| `.modal-fullscreen-xxl-down` | `1400px` |

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
     &lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModalFullscreen&quot; data-bs-toggle=&quot;modal&quot; type=&quot;button&quot;&gt;Full screen&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModalFullscreenSm&quot; data-bs-toggle=&quot;modal&quot; type=&quot;button&quot;&gt;Full screen below sm&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModalFullscreenMd&quot; data-bs-toggle=&quot;modal&quot; type=&quot;button&quot;&gt;Full screen below md&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModalFullscreenLg&quot; data-bs-toggle=&quot;modal&quot; type=&quot;button&quot;&gt;Full screen below lg&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModalFullscreenXl&quot; data-bs-toggle=&quot;modal&quot; type=&quot;button&quot;&gt;Full screen below xl&lt;/button&gt;
&lt;button class=&quot;btn btn-primary&quot; data-bs-target=&quot;#exampleModalFullscreenXxl&quot; data-bs-toggle=&quot;modal&quot; type=&quot;button&quot;&gt;Full screen below xxl&lt;/button&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<!-- Full screen modal -->
<div class="modal-dialog modal-fullscreen-sm-down">
  ...
</div>
```

# Full screen modal

...

Close

# Full screen below sm

...

Close

# Full screen below md

...

Close

# Full screen below lg

...

Close

# Full screen below xl

...

Close

# Full screen below xxl

...

Close

## CSS

### Variables

Added in v5.2.0

As part of Bootstrap’s evolving CSS variables approach, modals now use local CSS variables on `.modal` and `.modal-backdrop` for enhanced real-time customization. Values for the CSS variables are set via Sass, so Sass customization is still supported, too.

[scss/\_modal.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_modal.scss)

```html
--#{$prefix}modal-zindex: #{$zindex-modal};
--#{$prefix}modal-width: #{$modal-md};
--#{$prefix}modal-padding: #{$modal-inner-padding};
--#{$prefix}modal-margin: #{$modal-dialog-margin};
--#{$prefix}modal-color: #{$modal-content-color};
--#{$prefix}modal-bg: #{$modal-content-bg};
--#{$prefix}modal-border-color: #{$modal-content-border-color};
--#{$prefix}modal-border-width: #{$modal-content-border-width};
--#{$prefix}modal-border-radius: #{$modal-content-border-radius};
--#{$prefix}modal-box-shadow: #{$modal-content-box-shadow-xs};
--#{$prefix}modal-inner-border-radius: #{$modal-content-inner-border-radius};
--#{$prefix}modal-header-padding-x: #{$modal-header-padding-x};
--#{$prefix}modal-header-padding-y: #{$modal-header-padding-y};
--#{$prefix}modal-header-padding: #{$modal-header-padding}; // Todo in v6: Split this padding into x and y
--#{$prefix}modal-header-border-color: #{$modal-header-border-color};
--#{$prefix}modal-header-border-width: #{$modal-header-border-width};
--#{$prefix}modal-title-line-height: #{$modal-title-line-height};
--#{$prefix}modal-footer-gap: #{$modal-footer-margin-between};
--#{$prefix}modal-footer-bg: #{$modal-footer-bg};
--#{$prefix}modal-footer-border-color: #{$modal-footer-border-color};
--#{$prefix}modal-footer-border-width: #{$modal-footer-border-width};
```

[scss/\_modal.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_modal.scss)

```html
--#{$prefix}backdrop-zindex: #{$zindex-modal-backdrop};
--#{$prefix}backdrop-bg: #{$modal-backdrop-bg};
--#{$prefix}backdrop-opacity: #{$modal-backdrop-opacity};
```

### Sass variables

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$modal-inner-padding:               $spacer;

$modal-footer-margin-between:       .5rem;

$modal-dialog-margin:               .5rem;
$modal-dialog-margin-y-sm-up:       1.75rem;

$modal-title-line-height:           $line-height-base;

$modal-content-color:               var(--#{$prefix}body-color);
$modal-content-bg:                  var(--#{$prefix}body-bg);
$modal-content-border-color:        var(--#{$prefix}border-color-translucent);
$modal-content-border-width:        var(--#{$prefix}border-width);
$modal-content-border-radius:       var(--#{$prefix}border-radius-lg);
$modal-content-inner-border-radius: subtract($modal-content-border-radius, $modal-content-border-width);
$modal-content-box-shadow-xs:       var(--#{$prefix}box-shadow-sm);
$modal-content-box-shadow-sm-up:    var(--#{$prefix}box-shadow);

$modal-backdrop-bg:                 $black;
$modal-backdrop-opacity:            .5;

$modal-header-border-color:         var(--#{$prefix}border-color);
$modal-header-border-width:         $modal-content-border-width;
$modal-header-padding-y:            $modal-inner-padding;
$modal-header-padding-x:            $modal-inner-padding;
$modal-header-padding:              $modal-header-padding-y $modal-header-padding-x; // Keep this for backwards compatibility

$modal-footer-bg:                   null;
$modal-footer-border-color:         $modal-header-border-color;
$modal-footer-border-width:         $modal-header-border-width;

$modal-sm:                          300px;
$modal-md:                          500px;
$modal-lg:                          800px;
$modal-xl:                          1140px;

$modal-fade-transform:              translate(0, -50px);
$modal-show-transform:              none;
$modal-transition:                  transform .3s ease-out;
$modal-scale-transform:             scale(1.02);
```

### Sass loops

[Responsive fullscreen modals](#fullscreen-modal) are generated via the `$breakpoints` map and a loop in `scss/_modal.scss`.

[scss/\_modal.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_modal.scss)

```html
@each $breakpoint in map-keys($grid-breakpoints) {
  $infix: breakpoint-infix($breakpoint, $grid-breakpoints);
  $postfix: if($infix != "", $infix + "-down", "");

  @include media-breakpoint-down($breakpoint) {
    .modal-fullscreen#{$postfix} {
      width: 100vw;
      max-width: none;
      height: 100%;
      margin: 0;

      .modal-content {
        height: 100%;
        border: 0;
        @include border-radius(0);
      }

      .modal-header,
      .modal-footer {
        @include border-radius(0);
      }

      .modal-body {
        overflow-y: auto;
      }
    }
  }
}
```

## Usage

The modal plugin toggles your hidden content on demand, via data attributes or JavaScript. It also overrides default scrolling behavior and generates a `.modal-backdrop` to provide a click area for dismissing shown modals when clicking outside the modal.

### Via data attributes

#### Toggle

Activate a modal without writing JavaScript. Set `data-bs-toggle="modal"` on a controller element, like a button, along with a `data-bs-target="#foo"` or `href="#foo"` to target a specific modal to toggle.

```html
<button type="button" data-bs-toggle="modal" data-bs-target="#myModal">Launch modal</button>
```

#### Dismiss

Dismissal can be achieved with the `data-bs-dismiss` attribute on a button **within the modal** as demonstrated below:

```html
<button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
```

or on a button **outside the modal** using the additional `data-bs-target` as demonstrated below:

```html
<button type="button" class="btn-close" data-bs-dismiss="modal" data-bs-target="#my-modal" aria-label="Close"></button>
```

While both ways to dismiss a modal are supported, keep in mind that dismissing from outside a modal does not match the [ARIA Authoring Practices Guide dialog (modal) pattern](https://www.w3.org/WAI/ARIA/apg/patterns/dialogmodal/). Do this at your own risk.

### Via JavaScript

Create a modal with a single line of JavaScript:

```html
const myModal = new bootstrap.Modal(document.getElementById('myModal'), options)
// or
const myModalAlternative = new bootstrap.Modal('#myModal', options)
```

### Options

As options can be passed via data attributes or JavaScript, you can append an option name to `data-bs-`, as in `data-bs-animation="{value}"`. Make sure to change the case type of the option name from “*camelCase*” to “*kebab-case*” when passing the options via data attributes. For example, use `data-bs-custom-class="beautifier"` instead of `data-bs-customClass="beautifier"`.

As of Bootstrap 5.2.0, all components support an **experimental** reserved data attribute `data-bs-config` that can house simple component configuration as a JSON string. When an element has `data-bs-config='{"delay":0, "title":123}'` and `data-bs-title="456"` attributes, the final `title` value will be `456` and the separate data attributes will override values given on `data-bs-config`. In addition, existing data attributes are able to house JSON values like `data-bs-delay='{"show":0,"hide":150}'`.

The final configuration object is the merged result of `data-bs-config`, `data-bs-`, and `js object` where the latest given key-value overrides the others.

| Name | Type | Default | Description |
| --- | --- | --- | --- |
| `backdrop` | boolean, `’static'` | `true` | Includes a modal-backdrop element. Alternatively, specify `static` for a backdrop which doesn’t close the modal when clicked. |
| `focus` | boolean | `true` | Puts the focus on the modal when initialized. |
| `keyboard` | boolean | `true` | Closes the modal when escape key is pressed. |

### Methods

**All API methods are asynchronous and start a transition.** They return to the caller as soon as the transition is started, but before it ends. In addition, a method call on a transitioning component will be ignored. [Learn more in our JavaScript docs.](/docs/5.3/getting-started/javascript/#asynchronous-functions-and-transitions)

#### Passing options

Activates your content as a modal. Accepts an optional options `object`.

```html
const myModal = new bootstrap.Modal('#myModal', {
  keyboard: false
})
```

| Method | Description |
| --- | --- |
| `dispose` | Destroys an element’s modal. (Removes stored data on the DOM element) |
| `getInstance` | *Static* method which allows you to get the modal instance associated with a DOM element. |
| `getOrCreateInstance` | *Static* method which allows you to get the modal instance associated with a DOM element, or create a new one in case it wasn’t initialized. |
| `handleUpdate` | Manually readjust the modal’s position if the height of a modal changes while it is open (i.e. in case a scrollbar appears). |
| `hide` | Manually hides a modal. **Returns to the caller before the modal has actually been hidden** (i.e. before the `hidden.bs.modal` event occurs). |
| `show` | Manually opens a modal. **Returns to the caller before the modal has actually been shown** (i.e. before the `shown.bs.modal` event occurs). Also, you can pass a DOM element as an argument that can be received in the modal events (as the `relatedTarget` property). (i.e. `const modalToggle = document.getElementById('toggleMyModal'); myModal.show(modalToggle)`. |
| `toggle` | Manually toggles a modal. **Returns to the caller before the modal has actually been shown or hidden** (i.e. before the `shown.bs.modal` or `hidden.bs.modal` event occurs). |

### Events

Bootstrap’s modal class exposes a few events for hooking into modal functionality. All modal events are fired at the modal itself (i.e. at the `<div class="modal">`).

| Event | Description |
| --- | --- |
| `hide.bs.modal` | This event is fired immediately when the `hide` instance method has been called. Can be prevented by calling `event.preventDefault()`. See [JavaScript events documentation](/docs/5.3/getting-started/javascript#events) for more details on event prevention. |
| `hidden.bs.modal` | This event is fired when the modal has finished being hidden from the user (will wait for CSS transitions to complete). |
| `hidePrevented.bs.modal` | This event is fired when the modal is shown, its backdrop is `static` and a click outside of the modal is performed. The event is also fired when the escape key is pressed and the `keyboard` option is set to `false`. |
| `show.bs.modal` | This event fires immediately when the `show` instance method is called. If caused by a click, the clicked element is available as the `relatedTarget` property of the event. |
| `shown.bs.modal` | This event is fired when the modal has been made visible to the user (will wait for CSS transitions to complete). If caused by a click, the clicked element is available as the `relatedTarget` property of the event. |

```html
const myModalEl = document.getElementById('myModal')
myModalEl.addEventListener('hidden.bs.modal', event => {
  // do something...
})
```

