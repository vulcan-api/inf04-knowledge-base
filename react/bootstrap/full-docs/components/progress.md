> Źródło: [https://getbootstrap.com/docs/5.3/components/progress](https://getbootstrap.com/docs/5.3/components/progress)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/components/progress.mdx "View and edit this file on GitHub")

# Progress

Documentation and examples for using Bootstrap custom progress bars featuring support for stacked bars, animated backgrounds, and text labels.

On this page
   
**On this page**

---

* [How it works](#how-it-works)
* [Bar sizing](#bar-sizing)
  + [Width](#width)
  + [Height](#height)
* [Labels](#labels)
  + [Long labels](#long-labels)
* [Backgrounds](#backgrounds)
* [Multiple bars](#multiple-bars)
* [Striped](#striped)
* [Animated stripes](#animated-stripes)
* [CSS](#css)
  + [Variables](#variables)
  + [Sass variables](#sass-variables)
  + [Keyframes](#keyframes)

**New markup in v5.3.0 —** We’ve deprecated the previous HTML structure for progress bars and replaced it with a more accessible one. The previous structure will continue to work until v6. [See what’s changed in our migration guide.](/docs/5.3/migration#improved-markup-for-progress-bars)

## How it works

Progress components are built with two HTML elements, some CSS to set the width, and a few attributes. We don’t use [the HTML5 `<progress>` element](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/progress), ensuring you can stack progress bars, animate them, and place text labels over them.

* We use the `.progress` as a wrapper to indicate the max value of the progress bar.
* The `.progress` wrapper also requires a `role="progressbar"` and `aria` attributes to make it accessible, including an accessible name (using `aria-label`, `aria-labelledby`, or similar).
* We use the inner `.progress-bar` purely for the visual bar and label.
* The `.progress-bar` requires an inline style, utility class, or custom CSS to set its width.
* We provide a special `.progress-stacked` class to create multiple/stacked progress bars.

Put that all together, and you have the following examples.

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
     &lt;div aria-label=&quot;Basic example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;0&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar&quot; style=&quot;width: 0%&quot;&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Basic example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;25&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar&quot; style=&quot;width: 25%&quot;&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Basic example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;50&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar&quot; style=&quot;width: 50%&quot;&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Basic example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;75&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar&quot; style=&quot;width: 75%&quot;&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Basic example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;100&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar&quot; style=&quot;width: 100%&quot;&gt;&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="progress" role="progressbar" aria-label="Basic example" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar" style="width: 0%"></div>
</div>
<div class="progress" role="progressbar" aria-label="Basic example" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar" style="width: 25%"></div>
</div>
<div class="progress" role="progressbar" aria-label="Basic example" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar" style="width: 50%"></div>
</div>
<div class="progress" role="progressbar" aria-label="Basic example" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar" style="width: 75%"></div>
</div>
<div class="progress" role="progressbar" aria-label="Basic example" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar" style="width: 100%"></div>
</div>
```

## Bar sizing

### Width

Bootstrap provides a handful of [utilities for setting width](/docs/5.3/utilities/sizing). Depending on your needs, these may help with quickly configuring the width of the `.progress-bar`.

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
     &lt;div aria-label=&quot;Basic example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;75&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar w-75&quot;&gt;&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="progress" role="progressbar" aria-label="Basic example" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar w-75"></div>
</div>
```

### Height

You only set a `height` value on the `.progress` container, so if you change that value, the inner `.progress-bar` will automatically resize accordingly.

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
     &lt;div aria-label=&quot;Example 1px high&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;25&quot; class=&quot;progress&quot; role=&quot;progressbar&quot; style=&quot;height: 1px&quot;&gt;
&lt;div class=&quot;progress-bar&quot; style=&quot;width: 25%&quot;&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Example 20px high&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;25&quot; class=&quot;progress&quot; role=&quot;progressbar&quot; style=&quot;height: 20px&quot;&gt;
&lt;div class=&quot;progress-bar&quot; style=&quot;width: 25%&quot;&gt;&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="progress" role="progressbar" aria-label="Example 1px high" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100" style="height: 1px">
  <div class="progress-bar" style="width: 25%"></div>
</div>
<div class="progress" role="progressbar" aria-label="Example 20px high" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100" style="height: 20px">
  <div class="progress-bar" style="width: 25%"></div>
</div>
```

## Labels

Add labels to your progress bars by placing text within the `.progress-bar`.

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
     &lt;div aria-label=&quot;Example with label&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;25&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar&quot; style=&quot;width: 25%&quot;&gt;25%&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="progress" role="progressbar" aria-label="Example with label" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar" style="width: 25%">25%</div>
</div>
```

### Long labels

Note that by default, the content inside the `.progress-bar` is controlled with `overflow: hidden`, so it doesn’t bleed out of the bar. If your progress bar is shorter than its label, the content will be capped and may become unreadable. To change this behavior, you can use `.overflow-visible` from the [overflow utilities](/docs/5.3/utilities/overflow).

Labels longer than the progress bar within may not be fully accessible using this method because it relies on the text color having the correct contrast ratio with both the `.progress` and `.progress-bar` background colors. Use caution when implementing this example.

If the text can overlap the progress bar, we often recommend displaying the label outside of the progress bar for better accessibility.

## Backgrounds

Use background utility classes to change the appearance of individual progress bars.

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
     &lt;div aria-label=&quot;Success example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;25&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar bg-success&quot; style=&quot;width: 25%&quot;&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Info example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;50&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar bg-info&quot; style=&quot;width: 50%&quot;&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Warning example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;75&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar bg-warning&quot; style=&quot;width: 75%&quot;&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Danger example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;100&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar bg-danger&quot; style=&quot;width: 100%&quot;&gt;&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="progress" role="progressbar" aria-label="Success example" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar bg-success" style="width: 25%"></div>
</div>
<div class="progress" role="progressbar" aria-label="Info example" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar bg-info" style="width: 50%"></div>
</div>
<div class="progress" role="progressbar" aria-label="Warning example" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar bg-warning" style="width: 75%"></div>
</div>
<div class="progress" role="progressbar" aria-label="Danger example" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar bg-danger" style="width: 100%"></div>
</div>
```

**Accessibility tip:** Using color to add meaning only provides a visual indication, which will not be conveyed to users of assistive technologies like screen readers. Please ensure the meaning is obvious from the content itself (e.g., the visible text with a [*sufficient* color contrast](/docs/5.3/getting-started/accessibility/#color-contrast)) or is included through alternative means, such as additional text hidden with the `.visually-hidden` class.

If you’re adding labels to progress bars with a custom background color, make sure to also set an appropriate [text color](/docs/5.3/utilities/colors#colors), so the labels remain readable and have sufficient contrast. We recommend using the [color and background](/docs/5.3/helpers/color-background) helper classes.

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
     &lt;div aria-label=&quot;Success example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;25&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar text-bg-success&quot; style=&quot;width: 25%&quot;&gt;25%&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Info example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;50&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar text-bg-info&quot; style=&quot;width: 50%&quot;&gt;50%&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Warning example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;75&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar text-bg-warning&quot; style=&quot;width: 75%&quot;&gt;75%&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Danger example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;100&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar text-bg-danger&quot; style=&quot;width: 100%&quot;&gt;100%&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="progress" role="progressbar" aria-label="Success example" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar text-bg-success" style="width: 25%">25%</div>
</div>
<div class="progress" role="progressbar" aria-label="Info example" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar text-bg-info" style="width: 50%">50%</div>
</div>
<div class="progress" role="progressbar" aria-label="Warning example" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar text-bg-warning" style="width: 75%">75%</div>
</div>
<div class="progress" role="progressbar" aria-label="Danger example" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar text-bg-danger" style="width: 100%">100%</div>
</div>
```

## Multiple bars

You can include multiple progress components inside a container with `.progress-stacked` to create a single stacked progress bar. Note that in this case, the styling to set the visual width of the progress bar *must* be applied to the `.progress` elements, rather than the `.progress-bar`s.

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
     &lt;div class=&quot;progress-stacked&quot;&gt;
&lt;div aria-label=&quot;Segment one&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;15&quot; class=&quot;progress&quot; role=&quot;progressbar&quot; style=&quot;width: 15%&quot;&gt;
&lt;div class=&quot;progress-bar&quot;&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Segment two&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;30&quot; class=&quot;progress&quot; role=&quot;progressbar&quot; style=&quot;width: 30%&quot;&gt;
&lt;div class=&quot;progress-bar bg-success&quot;&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Segment three&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;20&quot; class=&quot;progress&quot; role=&quot;progressbar&quot; style=&quot;width: 20%&quot;&gt;
&lt;div class=&quot;progress-bar bg-info&quot;&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="progress-stacked">
  <div class="progress" role="progressbar" aria-label="Segment one" aria-valuenow="15" aria-valuemin="0" aria-valuemax="100" style="width: 15%">
    <div class="progress-bar"></div>
  </div>
  <div class="progress" role="progressbar" aria-label="Segment two" aria-valuenow="30" aria-valuemin="0" aria-valuemax="100" style="width: 30%">
    <div class="progress-bar bg-success"></div>
  </div>
  <div class="progress" role="progressbar" aria-label="Segment three" aria-valuenow="20" aria-valuemin="0" aria-valuemax="100" style="width: 20%">
    <div class="progress-bar bg-info"></div>
  </div>
</div>
```

## Striped

Add `.progress-bar-striped` to any `.progress-bar` to apply a stripe via CSS gradient over the progress bar’s background color.

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
     &lt;div aria-label=&quot;Default striped example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;10&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar progress-bar-striped&quot; style=&quot;width: 10%&quot;&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Success striped example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;25&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar progress-bar-striped bg-success&quot; style=&quot;width: 25%&quot;&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Info striped example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;50&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar progress-bar-striped bg-info&quot; style=&quot;width: 50%&quot;&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Warning striped example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;75&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar progress-bar-striped bg-warning&quot; style=&quot;width: 75%&quot;&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div aria-label=&quot;Danger striped example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;100&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar progress-bar-striped bg-danger&quot; style=&quot;width: 100%&quot;&gt;&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="progress" role="progressbar" aria-label="Default striped example" aria-valuenow="10" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar progress-bar-striped" style="width: 10%"></div>
</div>
<div class="progress" role="progressbar" aria-label="Success striped example" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar progress-bar-striped bg-success" style="width: 25%"></div>
</div>
<div class="progress" role="progressbar" aria-label="Info striped example" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar progress-bar-striped bg-info" style="width: 50%"></div>
</div>
<div class="progress" role="progressbar" aria-label="Warning striped example" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar progress-bar-striped bg-warning" style="width: 75%"></div>
</div>
<div class="progress" role="progressbar" aria-label="Danger striped example" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar progress-bar-striped bg-danger" style="width: 100%"></div>
</div>
```

## Animated stripes

The striped gradient can also be animated. Add `.progress-bar-animated` to `.progress-bar` to animate the stripes right to left via CSS3 animations.

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
     &lt;div aria-label=&quot;Animated striped example&quot; aria-valuemax=&quot;100&quot; aria-valuemin=&quot;0&quot; aria-valuenow=&quot;75&quot; class=&quot;progress&quot; role=&quot;progressbar&quot;&gt;
&lt;div class=&quot;progress-bar progress-bar-striped progress-bar-animated&quot; style=&quot;width: 75%&quot;&gt;&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="progress" role="progressbar" aria-label="Animated striped example" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar progress-bar-striped progress-bar-animated" style="width: 75%"></div>
</div>
```

## CSS

### Variables

Added in v5.2.0

As part of Bootstrap’s evolving CSS variables approach, progress bars now use local CSS variables on `.progress` for enhanced real-time customization. Values for the CSS variables are set via Sass, so Sass customization is still supported, too.

[scss/\_progress.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_progress.scss)

```html
--#{$prefix}progress-height: #{$progress-height};
@include rfs($progress-font-size, --#{$prefix}progress-font-size);
--#{$prefix}progress-bg: #{$progress-bg};
--#{$prefix}progress-border-radius: #{$progress-border-radius};
--#{$prefix}progress-box-shadow: #{$progress-box-shadow};
--#{$prefix}progress-bar-color: #{$progress-bar-color};
--#{$prefix}progress-bar-bg: #{$progress-bar-bg};
--#{$prefix}progress-bar-transition: #{$progress-bar-transition};
```

### Sass variables

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$progress-height:                   1rem;
$progress-font-size:                $font-size-base * .75;
$progress-bg:                       var(--#{$prefix}secondary-bg);
$progress-border-radius:            var(--#{$prefix}border-radius);
$progress-box-shadow:               var(--#{$prefix}box-shadow-inset);
$progress-bar-color:                $white;
$progress-bar-bg:                   $primary;
$progress-bar-animation-timing:     1s linear infinite;
$progress-bar-transition:           width .6s ease;
```

### Keyframes

Used for creating the CSS animations for `.progress-bar-animated`. Included in `scss/_progress-bar.scss`.

[scss/\_progress.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_progress.scss)

```html
@if $enable-transitions {
  @keyframes progress-bar-stripes {
    0% { background-position-x: var(--#{$prefix}progress-height); }
  }
}
```

