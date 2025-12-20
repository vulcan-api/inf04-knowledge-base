> Źródło: [https://getbootstrap.com/docs/5.3/components/scrollspy](https://getbootstrap.com/docs/5.3/components/scrollspy)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/components/scrollspy.mdx "View and edit this file on GitHub")

# Scrollspy

Automatically update Bootstrap navigation or list group components based on scroll position to indicate which link is currently active in the viewport.

On this page
   
**On this page**

---

* [How it works](#how-it-works)
* [Examples](#examples)
  + [Navbar](#navbar)
  + [Nested nav](#nested-nav)
  + [List group](#list-group)
  + [Simple anchors](#simple-anchors)
* [Non-visible elements](#non-visible-elements)
* [Usage](#usage)
  + [Via data attributes](#via-data-attributes)
  + [Via JavaScript](#via-javascript)
  + [Options](#options)
  + [Methods](#methods)
  + [Events](#events)

## How it works

Scrollspy toggles the `.active` class on anchor (`<a>`) elements when the element with the `id` referenced by the anchor’s `href` is scrolled into view. Scrollspy is best used in conjunction with a Bootstrap [nav component](/docs/5.3/components/navs-tabs) or [list group](/docs/5.3/components/list-group), but it will also work with any anchor elements in the current page. Here’s how it works.

* To start, scrollspy requires two things: a navigation, list group, or a simple set of links, plus a scrollable container. The scrollable container can be the `<body>` or a custom element with a set `height` and `overflow-y: scroll`.
* On the scrollable container, add `data-bs-spy="scroll"` and `data-bs-target="#navId"` where `navId` is the unique `id` of the associated navigation. If there is no focusable element inside the element, be sure to also include a `tabindex="0"` to ensure keyboard access.
* As you scroll the “spied” container, an `.active` class is added and removed from anchor links within the associated navigation. Links must have resolvable `id` targets, otherwise they’re ignored. For example, a `<a href="#home">home</a>` must correspond to something in the DOM like `<div id="home"></div>`
* Target elements that are not visible will be ignored. See the [Non-visible elements](#non-visible-elements) section below.

## Examples

### Navbar

Scroll the area below the navbar and watch the active class change. Open the dropdown menu and watch the dropdown items be highlighted as well.

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
     &lt;nav class=&quot;navbar bg-body-tertiary px-3 mb-3 rounded-2&quot; id=&quot;navbar-example2&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Navbar&lt;/a&gt;
&lt;ul class=&quot;nav nav-pills&quot;&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#scrollspyHeading1&quot;&gt;First&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#scrollspyHeading2&quot;&gt;Second&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item dropdown&quot;&gt;
&lt;a aria-expanded=&quot;false&quot; class=&quot;nav-link dropdown-toggle&quot; data-bs-toggle=&quot;dropdown&quot; href=&quot;#&quot; role=&quot;button&quot;&gt;Dropdown&lt;/a&gt;
&lt;ul class=&quot;dropdown-menu&quot;&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#scrollspyHeading3&quot;&gt;Third&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#scrollspyHeading4&quot;&gt;Fourth&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;hr class=&quot;dropdown-divider&quot;/&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#scrollspyHeading5&quot;&gt;Fifth&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/li&gt;
&lt;/ul&gt;
&lt;/nav&gt;
&lt;div class=&quot;scrollspy-example bg-body-tertiary p-3 rounded-2&quot; data-bs-root-margin=&quot;0px 0px -40%&quot; data-bs-smooth-scroll=&quot;true&quot; data-bs-spy=&quot;scroll&quot; data-bs-target=&quot;#navbar-example2&quot; tabindex=&quot;0&quot;&gt;
&lt;h4 id=&quot;scrollspyHeading1&quot;&gt;First heading&lt;/h4&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;h4 id=&quot;scrollspyHeading2&quot;&gt;Second heading&lt;/h4&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;h4 id=&quot;scrollspyHeading3&quot;&gt;Third heading&lt;/h4&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;h4 id=&quot;scrollspyHeading4&quot;&gt;Fourth heading&lt;/h4&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;h4 id=&quot;scrollspyHeading5&quot;&gt;Fifth heading&lt;/h4&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<nav id="navbar-example2" class="navbar bg-body-tertiary px-3 mb-3">
  <a class="navbar-brand" href="#">Navbar</a>
  <ul class="nav nav-pills">
    <li class="nav-item">
      <a class="nav-link" href="#scrollspyHeading1">First</a>
    </li>
    <li class="nav-item">
      <a class="nav-link" href="#scrollspyHeading2">Second</a>
    </li>
    <li class="nav-item dropdown">
      <a class="nav-link dropdown-toggle" data-bs-toggle="dropdown" href="#" role="button" aria-expanded="false">Dropdown</a>
      <ul class="dropdown-menu">
        <li><a class="dropdown-item" href="#scrollspyHeading3">Third</a></li>
        <li><a class="dropdown-item" href="#scrollspyHeading4">Fourth</a></li>
        <li><hr class="dropdown-divider"></li>
        <li><a class="dropdown-item" href="#scrollspyHeading5">Fifth</a></li>
      </ul>
    </li>
  </ul>
</nav>
<div data-bs-spy="scroll" data-bs-target="#navbar-example2" data-bs-root-margin="0px 0px -40%" data-bs-smooth-scroll="true" class="scrollspy-example bg-body-tertiary p-3 rounded-2" tabindex="0">
  <h4 id="scrollspyHeading1">First heading</h4>
  <p>...</p>
  <h4 id="scrollspyHeading2">Second heading</h4>
  <p>...</p>
  <h4 id="scrollspyHeading3">Third heading</h4>
  <p>...</p>
  <h4 id="scrollspyHeading4">Fourth heading</h4>
  <p>...</p>
  <h4 id="scrollspyHeading5">Fifth heading</h4>
  <p>...</p>
</div>
```

### Nested nav

Scrollspy also works with nested `.nav`s. If a nested `.nav` is `.active`, its parents will also be `.active`. Scroll the area next to the navbar and watch the active class change.

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
    
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-4&quot;&gt;
&lt;nav class=&quot;h-100 flex-column align-items-stretch pe-4 border-end&quot; id=&quot;navbar-example3&quot;&gt;
&lt;nav class=&quot;nav nav-pills flex-column&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#item-1&quot;&gt;Item 1&lt;/a&gt;
&lt;nav class=&quot;nav nav-pills flex-column&quot;&gt;
&lt;a class=&quot;nav-link ms-3 my-1&quot; href=&quot;#item-1-1&quot;&gt;Item 1-1&lt;/a&gt;
&lt;a class=&quot;nav-link ms-3 my-1&quot; href=&quot;#item-1-2&quot;&gt;Item 1-2&lt;/a&gt;
&lt;/nav&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#item-2&quot;&gt;Item 2&lt;/a&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#item-3&quot;&gt;Item 3&lt;/a&gt;
&lt;nav class=&quot;nav nav-pills flex-column&quot;&gt;
&lt;a class=&quot;nav-link ms-3 my-1&quot; href=&quot;#item-3-1&quot;&gt;Item 3-1&lt;/a&gt;
&lt;a class=&quot;nav-link ms-3 my-1&quot; href=&quot;#item-3-2&quot;&gt;Item 3-2&lt;/a&gt;
&lt;/nav&gt;
&lt;/nav&gt;
&lt;/nav&gt;
&lt;/div&gt;
&lt;div class=&quot;col-8&quot;&gt;
&lt;div class=&quot;scrollspy-example-2&quot; data-bs-smooth-scroll=&quot;true&quot; data-bs-spy=&quot;scroll&quot; data-bs-target=&quot;#navbar-example3&quot; tabindex=&quot;0&quot;&gt;
&lt;div id=&quot;item-1&quot;&gt;
&lt;h4&gt;Item 1&lt;/h4&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;p&gt;Keep in mind that the JavaScript plugin tries to pick the right element among all that may be visible. Multiple visible scrollspy targets at the same time may cause some issues.&lt;/p&gt;
&lt;/div&gt;
&lt;div id=&quot;item-1-1&quot;&gt;
&lt;h5&gt;Item 1-1&lt;/h5&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;p&gt;Keep in mind that the JavaScript plugin tries to pick the right element among all that may be visible. Multiple visible scrollspy targets at the same time may cause some issues.&lt;/p&gt;
&lt;/div&gt;
&lt;div id=&quot;item-1-2&quot;&gt;
&lt;h5&gt;Item 1-2&lt;/h5&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;p&gt;Keep in mind that the JavaScript plugin tries to pick the right element among all that may be visible. Multiple visible scrollspy targets at the same time may cause some issues.&lt;/p&gt;
&lt;/div&gt;
&lt;div id=&quot;item-2&quot;&gt;
&lt;h4&gt;Item 2&lt;/h4&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;p&gt;Keep in mind that the JavaScript plugin tries to pick the right element among all that may be visible. Multiple visible scrollspy targets at the same time may cause some issues.&lt;/p&gt;
&lt;/div&gt;
&lt;div id=&quot;item-3&quot;&gt;
&lt;h4&gt;Item 3&lt;/h4&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;p&gt;Keep in mind that the JavaScript plugin tries to pick the right element among all that may be visible. Multiple visible scrollspy targets at the same time may cause some issues.&lt;/p&gt;
&lt;/div&gt;
&lt;div id=&quot;item-3-1&quot;&gt;
&lt;h5&gt;Item 3-1&lt;/h5&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;p&gt;Keep in mind that the JavaScript plugin tries to pick the right element among all that may be visible. Multiple visible scrollspy targets at the same time may cause some issues.&lt;/p&gt;
&lt;/div&gt;
&lt;div id=&quot;item-3-2&quot;&gt;
&lt;h5&gt;Item 3-2&lt;/h5&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;p&gt;Keep in mind that the JavaScript plugin tries to pick the right element among all that may be visible. Multiple visible scrollspy targets at the same time may cause some issues.&lt;/p&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="row">
  <div class="col-4">
    <nav id="navbar-example3" class="h-100 flex-column align-items-stretch pe-4 border-end">
      <nav class="nav nav-pills flex-column">
        <a class="nav-link" href="#item-1">Item 1</a>
        <nav class="nav nav-pills flex-column">
          <a class="nav-link ms-3 my-1" href="#item-1-1">Item 1-1</a>
          <a class="nav-link ms-3 my-1" href="#item-1-2">Item 1-2</a>
        </nav>
        <a class="nav-link" href="#item-2">Item 2</a>
        <a class="nav-link" href="#item-3">Item 3</a>
        <nav class="nav nav-pills flex-column">
          <a class="nav-link ms-3 my-1" href="#item-3-1">Item 3-1</a>
          <a class="nav-link ms-3 my-1" href="#item-3-2">Item 3-2</a>
        </nav>
      </nav>
    </nav>
  </div>

  <div class="col-8">
    <div data-bs-spy="scroll" data-bs-target="#navbar-example3" data-bs-smooth-scroll="true" class="scrollspy-example-2" tabindex="0">
      <div id="item-1">
        <h4>Item 1</h4>
        <p>...</p>
      </div>
      <div id="item-1-1">
        <h5>Item 1-1</h5>
        <p>...</p>
      </div>
      <div id="item-1-2">
        <h5>Item 1-2</h5>
        <p>...</p>
      </div>
      <div id="item-2">
        <h4>Item 2</h4>
        <p>...</p>
      </div>
      <div id="item-3">
        <h4>Item 3</h4>
        <p>...</p>
      </div>
      <div id="item-3-1">
        <h5>Item 3-1</h5>
        <p>...</p>
      </div>
      <div id="item-3-2">
        <h5>Item 3-2</h5>
        <p>...</p>
      </div>
    </div>
  </div>
</div>
```

### List group

Scrollspy also works with `.list-group`s. Scroll the area next to the list group and watch the active class change.

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
    
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-4&quot;&gt;
&lt;div class=&quot;list-group&quot; id=&quot;list-example&quot;&gt;
&lt;a class=&quot;list-group-item list-group-item-action&quot; href=&quot;#list-item-1&quot;&gt;Item 1&lt;/a&gt;
&lt;a class=&quot;list-group-item list-group-item-action&quot; href=&quot;#list-item-2&quot;&gt;Item 2&lt;/a&gt;
&lt;a class=&quot;list-group-item list-group-item-action&quot; href=&quot;#list-item-3&quot;&gt;Item 3&lt;/a&gt;
&lt;a class=&quot;list-group-item list-group-item-action&quot; href=&quot;#list-item-4&quot;&gt;Item 4&lt;/a&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-8&quot;&gt;
&lt;div class=&quot;scrollspy-example&quot; data-bs-smooth-scroll=&quot;true&quot; data-bs-spy=&quot;scroll&quot; data-bs-target=&quot;#list-example&quot; tabindex=&quot;0&quot;&gt;
&lt;h4 id=&quot;list-item-1&quot;&gt;Item 1&lt;/h4&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;h4 id=&quot;list-item-2&quot;&gt;Item 2&lt;/h4&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;h4 id=&quot;list-item-3&quot;&gt;Item 3&lt;/h4&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;h4 id=&quot;list-item-4&quot;&gt;Item 4&lt;/h4&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="row">
  <div class="col-4">
    <div id="list-example" class="list-group">
      <a class="list-group-item list-group-item-action" href="#list-item-1">Item 1</a>
      <a class="list-group-item list-group-item-action" href="#list-item-2">Item 2</a>
      <a class="list-group-item list-group-item-action" href="#list-item-3">Item 3</a>
      <a class="list-group-item list-group-item-action" href="#list-item-4">Item 4</a>
    </div>
  </div>
  <div class="col-8">
    <div data-bs-spy="scroll" data-bs-target="#list-example" data-bs-smooth-scroll="true" class="scrollspy-example" tabindex="0">
      <h4 id="list-item-1">Item 1</h4>
      <p>...</p>
      <h4 id="list-item-2">Item 2</h4>
      <p>...</p>
      <h4 id="list-item-3">Item 3</h4>
      <p>...</p>
      <h4 id="list-item-4">Item 4</h4>
      <p>...</p>
    </div>
  </div>
</div>
```

### Simple anchors

Scrollspy is not limited to nav components and list groups, so it will work on any `<a>` anchor elements in the current document. Scroll the area and watch the `.active` class change.

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
    
&lt;div class=&quot;row&quot;&gt;
&lt;div class=&quot;col-4&quot;&gt;
&lt;div class=&quot;d-flex flex-column gap-2 simple-list-example-scrollspy text-center&quot; id=&quot;simple-list-example&quot;&gt;
&lt;a class=&quot;p-1 rounded&quot; href=&quot;#simple-list-item-1&quot;&gt;Item 1&lt;/a&gt;
&lt;a class=&quot;p-1 rounded&quot; href=&quot;#simple-list-item-2&quot;&gt;Item 2&lt;/a&gt;
&lt;a class=&quot;p-1 rounded&quot; href=&quot;#simple-list-item-3&quot;&gt;Item 3&lt;/a&gt;
&lt;a class=&quot;p-1 rounded&quot; href=&quot;#simple-list-item-4&quot;&gt;Item 4&lt;/a&gt;
&lt;a class=&quot;p-1 rounded&quot; href=&quot;#simple-list-item-5&quot;&gt;Item 5&lt;/a&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;col-8&quot;&gt;
&lt;div class=&quot;scrollspy-example&quot; data-bs-offset=&quot;0&quot; data-bs-smooth-scroll=&quot;true&quot; data-bs-spy=&quot;scroll&quot; data-bs-target=&quot;#simple-list-example&quot; tabindex=&quot;0&quot;&gt;
&lt;h4 id=&quot;simple-list-item-1&quot;&gt;Item 1&lt;/h4&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;h4 id=&quot;simple-list-item-2&quot;&gt;Item 2&lt;/h4&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;h4 id=&quot;simple-list-item-3&quot;&gt;Item 3&lt;/h4&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;h4 id=&quot;simple-list-item-4&quot;&gt;Item 4&lt;/h4&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;h4 id=&quot;simple-list-item-5&quot;&gt;Item 5&lt;/h4&gt;
&lt;p&gt;This is some placeholder content for the scrollspy page. Note that as you scroll down the page, the appropriate navigation link is highlighted. It’s repeated throughout the component example. We keep adding some more example copy here to emphasize the scrolling and highlighting.&lt;/p&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<div class="row">
  <div class="col-4">
    <div id="simple-list-example" class="d-flex flex-column gap-2 simple-list-example-scrollspy text-center">
      <a class="p-1 rounded" href="#simple-list-item-1">Item 1</a>
      <a class="p-1 rounded" href="#simple-list-item-2">Item 2</a>
      <a class="p-1 rounded" href="#simple-list-item-3">Item 3</a>
      <a class="p-1 rounded" href="#simple-list-item-4">Item 4</a>
      <a class="p-1 rounded" href="#simple-list-item-5">Item 5</a>
    </div>
  </div>
  <div class="col-8">
    <div data-bs-spy="scroll" data-bs-target="#simple-list-example" data-bs-offset="0" data-bs-smooth-scroll="true" class="scrollspy-example" tabindex="0">
      <h4 id="simple-list-item-1">Item 1</h4>
      <p>...</p>
      <h4 id="simple-list-item-2">Item 2</h4>
      <p>...</p>
      <h4 id="simple-list-item-3">Item 3</h4>
      <p>...</p>
      <h4 id="simple-list-item-4">Item 4</h4>
      <p>...</p>
      <h4 id="simple-list-item-5">Item 5</h4>
      <p>...</p>
    </div>
  </div>
</div>
```

## Non-visible elements

Target elements that aren’t visible will be ignored and their corresponding nav items won’t receive an `.active` class. Scrollspy instances initialized in a non-visible wrapper will ignore all target elements. Use the `refresh` method to check for observable elements once the wrapper becomes visible.

```html
document.querySelectorAll('#nav-tab>[data-bs-toggle="tab"]').forEach(el => {
  el.addEventListener('shown.bs.tab', () => {
    const target = el.getAttribute('data-bs-target')
    const scrollElem = document.querySelector(`${target} [data-bs-spy="scroll"]`)
    bootstrap.ScrollSpy.getOrCreateInstance(scrollElem).refresh()
  })
})
```

## Usage

### Via data attributes

To easily add scrollspy behavior to your topbar navigation, add `data-bs-spy="scroll"` to the element you want to spy on (most typically this would be the `<body>`). Then add the `data-bs-target` attribute with the `id` or class name of the parent element of any Bootstrap `.nav` component.

```html
<body data-bs-spy="scroll" data-bs-target="#navbar-example">
  ...
  <div id="navbar-example">
    <ul class="nav nav-tabs" role="tablist">
      ...
    </ul>
  </div>
  ...
</body>
```

### Via JavaScript

```html
const scrollSpy = new bootstrap.ScrollSpy(document.body, {
  target: '#navbar-example'
})
```

### Options

As options can be passed via data attributes or JavaScript, you can append an option name to `data-bs-`, as in `data-bs-animation="{value}"`. Make sure to change the case type of the option name from “*camelCase*” to “*kebab-case*” when passing the options via data attributes. For example, use `data-bs-custom-class="beautifier"` instead of `data-bs-customClass="beautifier"`.

As of Bootstrap 5.2.0, all components support an **experimental** reserved data attribute `data-bs-config` that can house simple component configuration as a JSON string. When an element has `data-bs-config='{"delay":0, "title":123}'` and `data-bs-title="456"` attributes, the final `title` value will be `456` and the separate data attributes will override values given on `data-bs-config`. In addition, existing data attributes are able to house JSON values like `data-bs-delay='{"show":0,"hide":150}'`.

The final configuration object is the merged result of `data-bs-config`, `data-bs-`, and `js object` where the latest given key-value overrides the others.

| Name | Type | Default | Description |
| --- | --- | --- | --- |
| `rootMargin` | string | `0px 0px -25%` | Intersection Observer [rootMargin](https://developer.mozilla.org/en-US/docs/Web/API/IntersectionObserver/rootMargin) valid units, when calculating scroll position. |
| `smoothScroll` | boolean | `false` | Enables smooth scrolling when a user clicks on a link that refers to ScrollSpy observables. |
| `target` | string, DOM element | `null` | Specifies element to apply Scrollspy plugin. |
| `threshold` | array | `[0.1, 0.5, 1]` | `IntersectionObserver` [threshold](https://developer.mozilla.org/en-US/docs/Web/API/IntersectionObserver/IntersectionObserver#threshold) valid input, when calculating scroll position. |

**Deprecated Options**

Up until v5.1.3 we were using `offset` & `method` options, which are now deprecated and replaced by `rootMargin`.
To keep backwards compatibility, we will continue to parse a given `offset` to `rootMargin`, but this feature will be removed in **v6**.

### Methods

| Method | Description |
| --- | --- |
| `dispose` | Destroys an element’s scrollspy. (Removes stored data on the DOM element) |
| `getInstance` | *Static* method to get the scrollspy instance associated with a DOM element. |
| `getOrCreateInstance` | *Static* method to get the scrollspy instance associated with a DOM element, or to create a new one in case it wasn’t initialized. |
| `refresh` | When adding or removing elements in the DOM, you’ll need to call the refresh method. |

Here’s an example using the refresh method:

```html
const dataSpyList = document.querySelectorAll('[data-bs-spy="scroll"]')
dataSpyList.forEach(dataSpyEl => {
  bootstrap.ScrollSpy.getInstance(dataSpyEl).refresh()
})
```

### Events

| Event | Description |
| --- | --- |
| `activate.bs.scrollspy` | This event fires on the scroll element whenever an anchor is activated by the scrollspy. |

```html
const firstScrollSpyEl = document.querySelector('[data-bs-spy="scroll"]')
firstScrollSpyEl.addEventListener('activate.bs.scrollspy', () => {
  // do something...
})
```

