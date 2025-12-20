> Źródło: [https://getbootstrap.com/docs/5.3/helpers/clearfix](https://getbootstrap.com/docs/5.3/helpers/clearfix)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/helpers/clearfix.mdx "View and edit this file on GitHub")

# Clearfix

Quickly and easily clear floated content within a container by adding a clearfix utility.

Easily clear `float`s by adding `.clearfix` **to the parent element**. Can also be used as a mixin.

Use in HTML:

```html
<div class="clearfix">...</div>
```

The mixin source code:

[scss/mixins/\_clearfix.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/mixins/_clearfix.scss)

```html
@mixin clearfix() {
  &::after {
    display: block;
    clear: both;
    content: "";
  }
}
```

Use the mixin in SCSS:

```html
.element {
  @include clearfix;
}
```

The following example shows how the clearfix can be used. Without the clearfix the wrapping div would not span around the buttons which would cause a broken layout.

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
     &lt;div class=&quot;bg-info clearfix&quot;&gt;
&lt;button class=&quot;btn btn-secondary float-start&quot; type=&quot;button&quot;&gt;Example Button floated left&lt;/button&gt;
&lt;button class=&quot;btn btn-secondary float-end&quot; type=&quot;button&quot;&gt;Example Button floated right&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="bg-info clearfix">
  <button type="button" class="btn btn-secondary float-start">Example Button floated left</button>
  <button type="button" class="btn btn-secondary float-end">Example Button floated right</button>
</div>
```

