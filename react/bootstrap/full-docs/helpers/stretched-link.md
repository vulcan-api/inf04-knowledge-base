> Źródło: [https://getbootstrap.com/docs/5.3/helpers/stretched-link](https://getbootstrap.com/docs/5.3/helpers/stretched-link)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/helpers/stretched-link.mdx "View and edit this file on GitHub")

# Stretched link

Make any HTML element or Bootstrap component clickable by “stretching” a nested link via CSS.

Add `.stretched-link` to a link to make its [containing block](https://developer.mozilla.org/en-US/docs/Web/CSS/Containing_block) clickable via a `::after` pseudo element. In most cases, this means that an element with `position: relative;` that contains a link with the `.stretched-link` class is clickable. Please note given [how CSS `position` works](https://www.w3.org/TR/CSS21/visuren.html#propdef-position), `.stretched-link` cannot be mixed with most table elements.

Cards have `position: relative` by default in Bootstrap, so in this case you can safely add the `.stretched-link` class to a link in the card without any other HTML changes.

Multiple links and tap targets are not recommended with stretched links. However, some `position` and `z-index` styles can help should this be required.

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
     &lt;div class=&quot;card&quot; style=&quot;width: 18rem;&quot;&gt;
&lt;svg aria-label=&quot;Card image cap&quot; class=&quot;bd-placeholder-img card-img-top&quot; height=&quot;180&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;100%&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Card image cap&lt;/title&gt;&lt;rect fill=&quot;#868e96&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;/svg&gt;
&lt;div class=&quot;card-body&quot;&gt;
&lt;h5 class=&quot;card-title&quot;&gt;Card with stretched link&lt;/h5&gt;
&lt;p class=&quot;card-text&quot;&gt;Some quick example text to build on the card title and make up the bulk of the card’s content.&lt;/p&gt;
&lt;a class=&quot;btn btn-primary stretched-link&quot; href=&quot;#&quot;&gt;Go somewhere&lt;/a&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="card" style="width: 18rem;">
  <img src="..." class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title">Card with stretched link</h5>
    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card’s content.</p>
    <a href="#" class="btn btn-primary stretched-link">Go somewhere</a>
  </div>
</div>
```

Most custom components do not have `position: relative` by default, so we need to add the `.position-relative` here to prevent the link from stretching outside the parent element.

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
     &lt;div class=&quot;d-flex position-relative&quot;&gt;
&lt;svg aria-label=&quot;Generic placeholder image22222&quot; class=&quot;bd-placeholder-img flex-shrink-0 me-3&quot; height=&quot;144&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;144&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Generic placeholder image22222&lt;/title&gt;&lt;rect fill=&quot;#868e96&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;/svg&gt;
&lt;div&gt;
&lt;h5 class=&quot;mt-0&quot;&gt;Custom component with stretched link&lt;/h5&gt;
&lt;p&gt;This is some placeholder content for the custom component. It is intended to mimic what some real-world content would look like, and we’re using it here to give the component a bit of body and size.&lt;/p&gt;
&lt;a class=&quot;stretched-link&quot; href=&quot;#&quot;&gt;Go somewhere&lt;/a&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="d-flex position-relative">
  <img src="..." class="flex-shrink-0 me-3" alt="...">
  <div>
    <h5 class="mt-0">Custom component with stretched link</h5>
    <p>This is some placeholder content for the custom component. It is intended to mimic what some real-world content would look like, and we’re using it here to give the component a bit of body and size.</p>
    <a href="#" class="stretched-link">Go somewhere</a>
  </div>
</div>
```

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
     &lt;div class=&quot;row g-0 bg-body-secondary position-relative&quot;&gt;
&lt;div class=&quot;col-md-6 mb-md-0 p-md-4&quot;&gt;
&lt;svg aria-label=&quot;Generic placeholder image&quot; class=&quot;bd-placeholder-img w-100&quot; height=&quot;200&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;100%&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Generic placeholder image&lt;/title&gt;&lt;rect fill=&quot;#868e96&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;col-md-6 p-4 ps-md-0&quot;&gt;
&lt;h5 class=&quot;mt-0&quot;&gt;Columns with stretched link&lt;/h5&gt;
&lt;p&gt;Another instance of placeholder content for this other custom component. It is intended to mimic what some real-world content would look like, and we’re using it here to give the component a bit of body and size.&lt;/p&gt;
&lt;a class=&quot;stretched-link&quot; href=&quot;#&quot;&gt;Go somewhere&lt;/a&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="row g-0 bg-body-secondary position-relative">
  <div class="col-md-6 mb-md-0 p-md-4">
    <img src="..." class="w-100" alt="...">
  </div>
  <div class="col-md-6 p-4 ps-md-0">
    <h5 class="mt-0">Columns with stretched link</h5>
    <p>Another instance of placeholder content for this other custom component. It is intended to mimic what some real-world content would look like, and we’re using it here to give the component a bit of body and size.</p>
    <a href="#" class="stretched-link">Go somewhere</a>
  </div>
</div>
```

## Identifying the containing block

If the stretched link doesn’t seem to work, the [containing block](https://developer.mozilla.org/en-US/docs/Web/CSS/Containing_block#Identifying_the_containing_block) will probably be the cause. The following CSS properties will make an element the containing block:

* A `position` value other than `static`
* A `transform` or `perspective` value other than `none`
* A `will-change` value of `transform` or `perspective`
* A `filter` value other than `none` or a `will-change` value of `filter` (only works on Firefox)

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
     &lt;div class=&quot;card&quot; style=&quot;width: 18rem;&quot;&gt;
&lt;svg aria-label=&quot;Card image cap&quot; class=&quot;bd-placeholder-img card-img-top&quot; height=&quot;180&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;100%&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Card image cap&lt;/title&gt;&lt;rect fill=&quot;#868e96&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;/svg&gt;
&lt;div class=&quot;card-body&quot;&gt;
&lt;h5 class=&quot;card-title&quot;&gt;Card with stretched links&lt;/h5&gt;
&lt;p class=&quot;card-text&quot;&gt;Some quick example text to build on the card title and make up the bulk of the card’s content.&lt;/p&gt;
&lt;p class=&quot;card-text&quot;&gt;
&lt;a class=&quot;stretched-link text-danger&quot; href=&quot;#&quot; style=&quot;position: relative;&quot;&gt;Stretched link will not work here, because &lt;code&gt;position: relative&lt;/code&gt; is added to the link&lt;/a&gt;
&lt;/p&gt;
&lt;p class=&quot;card-text bg-body-tertiary&quot; style=&quot;transform: rotate(0);&quot;&gt;
      This &lt;a class=&quot;text-warning stretched-link&quot; href=&quot;#&quot;&gt;stretched link&lt;/a&gt; will only be spread over the &lt;code&gt;p&lt;/code&gt;-tag, because a transform is applied to it.
    &lt;/p&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="card" style="width: 18rem;">
  <img src="..." class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title">Card with stretched links</h5>
    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card’s content.</p>
    <p class="card-text">
      <a href="#" class="stretched-link text-danger" style="position: relative;">Stretched link will not work here, because <code>position: relative</code> is added to the link</a>
    </p>
    <p class="card-text bg-body-tertiary" style="transform: rotate(0);">
      This <a href="#" class="text-warning stretched-link">stretched link</a> will only be spread over the <code>p</code>-tag, because a transform is applied to it.
    </p>
  </div>
</div>
```

