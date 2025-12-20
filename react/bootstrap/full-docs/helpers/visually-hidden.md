> Źródło: [https://getbootstrap.com/docs/5.3/helpers/visually-hidden](https://getbootstrap.com/docs/5.3/helpers/visually-hidden)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/helpers/visually-hidden.mdx "View and edit this file on GitHub")

# Visually hidden

Use these helpers to visually hide elements but keep them accessible to assistive technologies.

Visually hide an element while still allowing it to be exposed to assistive technologies (such as screen readers) with `.visually-hidden`. Use `.visually-hidden-focusable` to visually hide an element by default, but to display it when it’s focused (e.g. by a keyboard-only user). `.visually-hidden-focusable` can also be applied to a container–thanks to `:focus-within`, the container will be displayed when any child element of the container receives focus.

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
     &lt;h2 class=&quot;visually-hidden&quot;&gt;Title for screen readers&lt;/h2&gt;
&lt;a class=&quot;visually-hidden-focusable&quot; href=&quot;#content&quot;&gt;Skip to main content&lt;/a&gt;
&lt;div class=&quot;visually-hidden-focusable&quot;&gt;A container with a &lt;a href=&quot;#&quot;&gt;focusable element&lt;/a&gt;.&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<h2 class="visually-hidden">Title for screen readers</h2>
<a class="visually-hidden-focusable" href="#content">Skip to main content</a>
<div class="visually-hidden-focusable">A container with a <a href="#">focusable element</a>.</div>
```

Both `visually-hidden` and `visually-hidden-focusable` can also be used as mixins.

```html
// Usage as a mixin

.visually-hidden-title {
  @include visually-hidden;
}

.skip-navigation {
  @include visually-hidden-focusable;
}
```

