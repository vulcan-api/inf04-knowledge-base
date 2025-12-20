> Źródło: [https://getbootstrap.com/docs/5.3/components/accordion](https://getbootstrap.com/docs/5.3/components/accordion)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/components/accordion.mdx "View and edit this file on GitHub")

# Accordion

Build vertically collapsing accordions in combination with our Collapse JavaScript plugin.

On this page
   
**On this page**

---

* [How it works](#how-it-works)
* [Example](#example)
  + [Flush](#flush)
  + [Always open](#always-open)
* [Accessibility](#accessibility)
* [CSS](#css)
  + [Variables](#variables)
  + [Sass variables](#sass-variables)
* [Usage](#usage)
  + [Via data attributes](#via-data-attributes)
  + [Via JavaScript](#via-javascript)
  + [Options](#options)
  + [Methods](#methods)
  + [Events](#events)

## How it works

The accordion uses [collapse](/docs/5.3/components/collapse) internally to make it collapsible.

The animation effect of this component is dependent on the `prefers-reduced-motion` media query. See the [reduced motion section of our accessibility documentation](/docs/5.3/getting-started/accessibility/#reduced-motion).

## Example

Click the accordions below to expand/collapse the accordion content.

To render an accordion that’s expanded by default:

* add the `.show` class on the `.accordion-collapse` element.
* drop the `.collapsed` class from the `.accordion-button` element and set its `aria-expanded` attribute to `true`.

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
     &lt;div class=&quot;accordion&quot; id=&quot;accordionExample&quot;&gt;
&lt;div class=&quot;accordion-item&quot;&gt;
&lt;h2 class=&quot;accordion-header&quot;&gt;
&lt;button aria-controls=&quot;collapseOne&quot; aria-expanded=&quot;true&quot; class=&quot;accordion-button&quot; data-bs-target=&quot;#collapseOne&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
        Accordion Item #1
      &lt;/button&gt;
&lt;/h2&gt;
&lt;div class=&quot;accordion-collapse collapse show&quot; data-bs-parent=&quot;#accordionExample&quot; id=&quot;collapseOne&quot;&gt;
&lt;div class=&quot;accordion-body&quot;&gt;
&lt;strong&gt;This is the first item’s accordion body.&lt;/strong&gt; It is shown by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It’s also worth noting that just about any HTML can go within the &lt;code&gt;.accordion-body&lt;/code&gt;, though the transition does limit overflow.
      &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;accordion-item&quot;&gt;
&lt;h2 class=&quot;accordion-header&quot;&gt;
&lt;button aria-controls=&quot;collapseTwo&quot; aria-expanded=&quot;false&quot; class=&quot;accordion-button collapsed&quot; data-bs-target=&quot;#collapseTwo&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
        Accordion Item #2
      &lt;/button&gt;
&lt;/h2&gt;
&lt;div class=&quot;accordion-collapse collapse&quot; data-bs-parent=&quot;#accordionExample&quot; id=&quot;collapseTwo&quot;&gt;
&lt;div class=&quot;accordion-body&quot;&gt;
&lt;strong&gt;This is the second item’s accordion body.&lt;/strong&gt; It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It’s also worth noting that just about any HTML can go within the &lt;code&gt;.accordion-body&lt;/code&gt;, though the transition does limit overflow.
      &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;accordion-item&quot;&gt;
&lt;h2 class=&quot;accordion-header&quot;&gt;
&lt;button aria-controls=&quot;collapseThree&quot; aria-expanded=&quot;false&quot; class=&quot;accordion-button collapsed&quot; data-bs-target=&quot;#collapseThree&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
        Accordion Item #3
      &lt;/button&gt;
&lt;/h2&gt;
&lt;div class=&quot;accordion-collapse collapse&quot; data-bs-parent=&quot;#accordionExample&quot; id=&quot;collapseThree&quot;&gt;
&lt;div class=&quot;accordion-body&quot;&gt;
&lt;strong&gt;This is the third item’s accordion body.&lt;/strong&gt; It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It’s also worth noting that just about any HTML can go within the &lt;code&gt;.accordion-body&lt;/code&gt;, though the transition does limit overflow.
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
<div class="accordion" id="accordionExample">
  <div class="accordion-item">
    <h2 class="accordion-header">
      <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
        Accordion Item #1
      </button>
    </h2>
    <div id="collapseOne" class="accordion-collapse collapse show" data-bs-parent="#accordionExample">
      <div class="accordion-body">
        <strong>This is the first item’s accordion body.</strong> It is shown by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It’s also worth noting that just about any HTML can go within the <code>.accordion-body</code>, though the transition does limit overflow.
      </div>
    </div>
  </div>
  <div class="accordion-item">
    <h2 class="accordion-header">
      <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
        Accordion Item #2
      </button>
    </h2>
    <div id="collapseTwo" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
      <div class="accordion-body">
        <strong>This is the second item’s accordion body.</strong> It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It’s also worth noting that just about any HTML can go within the <code>.accordion-body</code>, though the transition does limit overflow.
      </div>
    </div>
  </div>
  <div class="accordion-item">
    <h2 class="accordion-header">
      <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
        Accordion Item #3
      </button>
    </h2>
    <div id="collapseThree" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
      <div class="accordion-body">
        <strong>This is the third item’s accordion body.</strong> It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It’s also worth noting that just about any HTML can go within the <code>.accordion-body</code>, though the transition does limit overflow.
      </div>
    </div>
  </div>
</div>
```

### Flush

Add `.accordion-flush` to remove some borders and rounded corners to render accordions edge-to-edge with their parent container.

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
     &lt;div class=&quot;accordion accordion-flush&quot; id=&quot;accordionFlushExample&quot;&gt;
&lt;div class=&quot;accordion-item&quot;&gt;
&lt;h2 class=&quot;accordion-header&quot;&gt;
&lt;button aria-controls=&quot;flush-collapseOne&quot; aria-expanded=&quot;false&quot; class=&quot;accordion-button collapsed&quot; data-bs-target=&quot;#flush-collapseOne&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
        Accordion Item #1
      &lt;/button&gt;
&lt;/h2&gt;
&lt;div class=&quot;accordion-collapse collapse&quot; data-bs-parent=&quot;#accordionFlushExample&quot; id=&quot;flush-collapseOne&quot;&gt;
&lt;div class=&quot;accordion-body&quot;&gt;Placeholder content for this accordion, which is intended to demonstrate the &lt;code&gt;.accordion-flush&lt;/code&gt; class. This is the first item’s accordion body.&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;accordion-item&quot;&gt;
&lt;h2 class=&quot;accordion-header&quot;&gt;
&lt;button aria-controls=&quot;flush-collapseTwo&quot; aria-expanded=&quot;false&quot; class=&quot;accordion-button collapsed&quot; data-bs-target=&quot;#flush-collapseTwo&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
        Accordion Item #2
      &lt;/button&gt;
&lt;/h2&gt;
&lt;div class=&quot;accordion-collapse collapse&quot; data-bs-parent=&quot;#accordionFlushExample&quot; id=&quot;flush-collapseTwo&quot;&gt;
&lt;div class=&quot;accordion-body&quot;&gt;Placeholder content for this accordion, which is intended to demonstrate the &lt;code&gt;.accordion-flush&lt;/code&gt; class. This is the second item’s accordion body. Let’s imagine this being filled with some actual content.&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;accordion-item&quot;&gt;
&lt;h2 class=&quot;accordion-header&quot;&gt;
&lt;button aria-controls=&quot;flush-collapseThree&quot; aria-expanded=&quot;false&quot; class=&quot;accordion-button collapsed&quot; data-bs-target=&quot;#flush-collapseThree&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
        Accordion Item #3
      &lt;/button&gt;
&lt;/h2&gt;
&lt;div class=&quot;accordion-collapse collapse&quot; data-bs-parent=&quot;#accordionFlushExample&quot; id=&quot;flush-collapseThree&quot;&gt;
&lt;div class=&quot;accordion-body&quot;&gt;Placeholder content for this accordion, which is intended to demonstrate the &lt;code&gt;.accordion-flush&lt;/code&gt; class. This is the third item’s accordion body. Nothing more exciting happening here in terms of content, but just filling up the space to make it look, at least at first glance, a bit more representative of how this would look in a real-world application.&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="accordion accordion-flush" id="accordionFlushExample">
  <div class="accordion-item">
    <h2 class="accordion-header">
      <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseOne" aria-expanded="false" aria-controls="flush-collapseOne">
        Accordion Item #1
      </button>
    </h2>
    <div id="flush-collapseOne" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
      <div class="accordion-body">Placeholder content for this accordion, which is intended to demonstrate the <code>.accordion-flush</code> class. This is the first item’s accordion body.</div>
    </div>
  </div>
  <div class="accordion-item">
    <h2 class="accordion-header">
      <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseTwo" aria-expanded="false" aria-controls="flush-collapseTwo">
        Accordion Item #2
      </button>
    </h2>
    <div id="flush-collapseTwo" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
      <div class="accordion-body">Placeholder content for this accordion, which is intended to demonstrate the <code>.accordion-flush</code> class. This is the second item’s accordion body. Let’s imagine this being filled with some actual content.</div>
    </div>
  </div>
  <div class="accordion-item">
    <h2 class="accordion-header">
      <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseThree" aria-expanded="false" aria-controls="flush-collapseThree">
        Accordion Item #3
      </button>
    </h2>
    <div id="flush-collapseThree" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
      <div class="accordion-body">Placeholder content for this accordion, which is intended to demonstrate the <code>.accordion-flush</code> class. This is the third item’s accordion body. Nothing more exciting happening here in terms of content, but just filling up the space to make it look, at least at first glance, a bit more representative of how this would look in a real-world application.</div>
    </div>
  </div>
</div>
```

### Always open

Omit the `data-bs-parent` attribute on each `.accordion-collapse` to make accordion items stay open when another item is opened.

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
     &lt;div class=&quot;accordion&quot; id=&quot;accordionPanelsStayOpenExample&quot;&gt;
&lt;div class=&quot;accordion-item&quot;&gt;
&lt;h2 class=&quot;accordion-header&quot;&gt;
&lt;button aria-controls=&quot;panelsStayOpen-collapseOne&quot; aria-expanded=&quot;true&quot; class=&quot;accordion-button&quot; data-bs-target=&quot;#panelsStayOpen-collapseOne&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
        Accordion Item #1
      &lt;/button&gt;
&lt;/h2&gt;
&lt;div class=&quot;accordion-collapse collapse show&quot; id=&quot;panelsStayOpen-collapseOne&quot;&gt;
&lt;div class=&quot;accordion-body&quot;&gt;
&lt;strong&gt;This is the first item’s accordion body.&lt;/strong&gt; It is shown by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It’s also worth noting that just about any HTML can go within the &lt;code&gt;.accordion-body&lt;/code&gt;, though the transition does limit overflow.
      &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;accordion-item&quot;&gt;
&lt;h2 class=&quot;accordion-header&quot;&gt;
&lt;button aria-controls=&quot;panelsStayOpen-collapseTwo&quot; aria-expanded=&quot;false&quot; class=&quot;accordion-button collapsed&quot; data-bs-target=&quot;#panelsStayOpen-collapseTwo&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
        Accordion Item #2
      &lt;/button&gt;
&lt;/h2&gt;
&lt;div class=&quot;accordion-collapse collapse&quot; id=&quot;panelsStayOpen-collapseTwo&quot;&gt;
&lt;div class=&quot;accordion-body&quot;&gt;
&lt;strong&gt;This is the second item’s accordion body.&lt;/strong&gt; It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It’s also worth noting that just about any HTML can go within the &lt;code&gt;.accordion-body&lt;/code&gt;, though the transition does limit overflow.
      &lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;accordion-item&quot;&gt;
&lt;h2 class=&quot;accordion-header&quot;&gt;
&lt;button aria-controls=&quot;panelsStayOpen-collapseThree&quot; aria-expanded=&quot;false&quot; class=&quot;accordion-button collapsed&quot; data-bs-target=&quot;#panelsStayOpen-collapseThree&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
        Accordion Item #3
      &lt;/button&gt;
&lt;/h2&gt;
&lt;div class=&quot;accordion-collapse collapse&quot; id=&quot;panelsStayOpen-collapseThree&quot;&gt;
&lt;div class=&quot;accordion-body&quot;&gt;
&lt;strong&gt;This is the third item’s accordion body.&lt;/strong&gt; It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It’s also worth noting that just about any HTML can go within the &lt;code&gt;.accordion-body&lt;/code&gt;, though the transition does limit overflow.
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
<div class="accordion" id="accordionPanelsStayOpenExample">
  <div class="accordion-item">
    <h2 class="accordion-header">
      <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#panelsStayOpen-collapseOne" aria-expanded="true" aria-controls="panelsStayOpen-collapseOne">
        Accordion Item #1
      </button>
    </h2>
    <div id="panelsStayOpen-collapseOne" class="accordion-collapse collapse show">
      <div class="accordion-body">
        <strong>This is the first item’s accordion body.</strong> It is shown by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It’s also worth noting that just about any HTML can go within the <code>.accordion-body</code>, though the transition does limit overflow.
      </div>
    </div>
  </div>
  <div class="accordion-item">
    <h2 class="accordion-header">
      <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#panelsStayOpen-collapseTwo" aria-expanded="false" aria-controls="panelsStayOpen-collapseTwo">
        Accordion Item #2
      </button>
    </h2>
    <div id="panelsStayOpen-collapseTwo" class="accordion-collapse collapse">
      <div class="accordion-body">
        <strong>This is the second item’s accordion body.</strong> It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It’s also worth noting that just about any HTML can go within the <code>.accordion-body</code>, though the transition does limit overflow.
      </div>
    </div>
  </div>
  <div class="accordion-item">
    <h2 class="accordion-header">
      <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#panelsStayOpen-collapseThree" aria-expanded="false" aria-controls="panelsStayOpen-collapseThree">
        Accordion Item #3
      </button>
    </h2>
    <div id="panelsStayOpen-collapseThree" class="accordion-collapse collapse">
      <div class="accordion-body">
        <strong>This is the third item’s accordion body.</strong> It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It’s also worth noting that just about any HTML can go within the <code>.accordion-body</code>, though the transition does limit overflow.
      </div>
    </div>
  </div>
</div>
```

## Accessibility

Please read the [collapse accessibility section](/docs/5.3/components/collapse#accessibility) for more information.

## CSS

### Variables

Added in v5.2.0

As part of Bootstrap’s evolving CSS variables approach, accordions now use local CSS variables on `.accordion` for enhanced real-time customization. Values for the CSS variables are set via Sass, so Sass customization is still supported, too.

[scss/\_accordion.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_accordion.scss)

```html
--#{$prefix}accordion-color: #{$accordion-color};
--#{$prefix}accordion-bg: #{$accordion-bg};
--#{$prefix}accordion-transition: #{$accordion-transition};
--#{$prefix}accordion-border-color: #{$accordion-border-color};
--#{$prefix}accordion-border-width: #{$accordion-border-width};
--#{$prefix}accordion-border-radius: #{$accordion-border-radius};
--#{$prefix}accordion-inner-border-radius: #{$accordion-inner-border-radius};
--#{$prefix}accordion-btn-padding-x: #{$accordion-button-padding-x};
--#{$prefix}accordion-btn-padding-y: #{$accordion-button-padding-y};
--#{$prefix}accordion-btn-color: #{$accordion-button-color};
--#{$prefix}accordion-btn-bg: #{$accordion-button-bg};
--#{$prefix}accordion-btn-icon: #{escape-svg($accordion-button-icon)};
--#{$prefix}accordion-btn-icon-width: #{$accordion-icon-width};
--#{$prefix}accordion-btn-icon-transform: #{$accordion-icon-transform};
--#{$prefix}accordion-btn-icon-transition: #{$accordion-icon-transition};
--#{$prefix}accordion-btn-active-icon: #{escape-svg($accordion-button-active-icon)};
--#{$prefix}accordion-btn-focus-box-shadow: #{$accordion-button-focus-box-shadow};
--#{$prefix}accordion-body-padding-x: #{$accordion-body-padding-x};
--#{$prefix}accordion-body-padding-y: #{$accordion-body-padding-y};
--#{$prefix}accordion-active-color: #{$accordion-button-active-color};
--#{$prefix}accordion-active-bg: #{$accordion-button-active-bg};
```

### Sass variables

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$accordion-padding-y:                     1rem;
$accordion-padding-x:                     1.25rem;
$accordion-color:                         var(--#{$prefix}body-color);
$accordion-bg:                            var(--#{$prefix}body-bg);
$accordion-border-width:                  var(--#{$prefix}border-width);
$accordion-border-color:                  var(--#{$prefix}border-color);
$accordion-border-radius:                 var(--#{$prefix}border-radius);
$accordion-inner-border-radius:           subtract($accordion-border-radius, $accordion-border-width);

$accordion-body-padding-y:                $accordion-padding-y;
$accordion-body-padding-x:                $accordion-padding-x;

$accordion-button-padding-y:              $accordion-padding-y;
$accordion-button-padding-x:              $accordion-padding-x;
$accordion-button-color:                  var(--#{$prefix}body-color);
$accordion-button-bg:                     var(--#{$prefix}accordion-bg);
$accordion-transition:                    $btn-transition, border-radius .15s ease;
$accordion-button-active-bg:              var(--#{$prefix}primary-bg-subtle);
$accordion-button-active-color:           var(--#{$prefix}primary-text-emphasis);

// fusv-disable
$accordion-button-focus-border-color:     $input-focus-border-color; // Deprecated in v5.3.3
// fusv-enable
$accordion-button-focus-box-shadow:       $btn-focus-box-shadow;

$accordion-icon-width:                    1.25rem;
$accordion-icon-color:                    $body-color;
$accordion-icon-active-color:             $primary-text-emphasis;
$accordion-icon-transition:               transform .2s ease-in-out;
$accordion-icon-transform:                rotate(-180deg);

$accordion-button-icon:         url("data:image/svg+xml,<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 16 16' fill='none' stroke='#{$accordion-icon-color}' stroke-linecap='round' stroke-linejoin='round'><path d='m2 5 6 6 6-6'/></svg>");
$accordion-button-active-icon:  url("data:image/svg+xml,<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 16 16' fill='none' stroke='#{$accordion-icon-active-color}' stroke-linecap='round' stroke-linejoin='round'><path d='m2 5 6 6 6-6'/></svg>");
```

## Usage

The collapse plugin utilizes a few classes to handle the heavy lifting:

* `.collapse` hides the content
* `.collapse.show` shows the content
* `.collapsing` is added when the transition starts, and removed when it finishes

These classes can be found in `_transitions.scss`.

### Via data attributes

Just add `data-bs-toggle="collapse"` and a `data-bs-target` to the element to automatically assign control of one or more collapsible elements. The `data-bs-target` attribute accepts a CSS selector to apply the collapse to. Be sure to add the class `collapse` to the collapsible element. If you’d like it to default open, add the additional class `show`.

To add accordion group management to a collapsible area, add the data attribute `data-bs-parent="#selector"`.

### Via JavaScript

Enable manually with:

```html
const accordionCollapseElementList = document.querySelectorAll('#myAccordion .collapse')
const accordionCollapseList = [...accordionCollapseElementList].map(accordionCollapseEl => new bootstrap.Collapse(accordionCollapseEl))
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

