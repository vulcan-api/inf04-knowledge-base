> Źródło: [https://getbootstrap.com/docs/5.3/components/navbar](https://getbootstrap.com/docs/5.3/components/navbar)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/components/navbar.mdx "View and edit this file on GitHub")

# Navbar

Documentation and examples for Bootstrap’s powerful, responsive navigation header, the navbar. Includes support for branding, navigation, and more, including support for our collapse plugin.

On this page
   
**On this page**

---

* [How it works](#how-it-works)
* [Supported content](#supported-content)
  + [Brand](#brand)
    - [Text](#text)
    - [Image](#image)
    - [Image and text](#image-and-text)
  + [Nav](#nav)
  + [Forms](#forms)
  + [Text](#text-1)
* [Color schemes](#color-schemes)
* [Containers](#containers)
* [Placement](#placement)
* [Scrolling](#scrolling)
* [Responsive behaviors](#responsive-behaviors)
  + [Toggler](#toggler)
  + [External content](#external-content)
  + [Offcanvas](#offcanvas)
* [CSS](#css)
  + [Variables](#variables)
  + [Sass variables](#sass-variables)
  + [Sass loops](#sass-loops)

## How it works

Here’s what you need to know before getting started with the navbar:

* Navbars require a wrapping `.navbar` with `.navbar-expand{-sm|-md|-lg|-xl|-xxl}` for responsive collapsing and [color scheme](#color-schemes) classes.
* Navbars and their contents are fluid by default. Change the [container](#containers) to limit their horizontal width in different ways.
* Use our [spacing](/docs/5.3/utilities/spacing) and [flex](/docs/5.3/utilities/flex) utility classes for controlling spacing and alignment within navbars.
* Navbars are responsive by default, but you can easily modify them to change that. Responsive behavior depends on our Collapse JavaScript plugin.
* Ensure accessibility by using a `<nav>` element or, if using a more generic element such as a `<div>`, add a `role="navigation"` to every navbar to explicitly identify it as a landmark region for users of assistive technologies.
* Indicate the current item by using `aria-current="page"` for the current page or `aria-current="true"` for the current item in a set.
* **New in v5.2.0:** Navbars can be themed with CSS variables that are scoped to the `.navbar` base class. `.navbar-light` has been deprecated and `.navbar-dark` has been rewritten to override CSS variables instead of adding additional styles.

The animation effect of this component is dependent on the `prefers-reduced-motion` media query. See the [reduced motion section of our accessibility documentation](/docs/5.3/getting-started/accessibility/#reduced-motion).

## Supported content

Navbars come with built-in support for a handful of sub-components. Choose from the following as needed:

* `.navbar-brand` for your company, product, or project name.
* `.navbar-nav` for a full-height and lightweight navigation (including support for dropdowns).
* `.navbar-toggler` for use with our collapse plugin and other [navigation toggling](#responsive-behaviors) behaviors.
* Flex and spacing utilities for any form controls and actions.
* `.navbar-text` for adding vertically centered strings of text.
* `.collapse.navbar-collapse` for grouping and hiding navbar contents by a parent breakpoint.
* Add an optional `.navbar-nav-scroll` to set a `max-height` and [scroll expanded navbar content](#scrolling).

Here’s an example of all the sub-components included in a responsive light-themed navbar that automatically collapses at the `lg` (large) breakpoint.

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
     &lt;nav class=&quot;navbar navbar-expand-lg bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Navbar&lt;/a&gt;
&lt;button aria-controls=&quot;navbarSupportedContent&quot; aria-expanded=&quot;false&quot; aria-label=&quot;Toggle navigation&quot; class=&quot;navbar-toggler&quot; data-bs-target=&quot;#navbarSupportedContent&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
&lt;span class=&quot;navbar-toggler-icon&quot;&gt;&lt;/span&gt;
&lt;/button&gt;
&lt;div class=&quot;collapse navbar-collapse&quot; id=&quot;navbarSupportedContent&quot;&gt;
&lt;ul class=&quot;navbar-nav me-auto mb-2 mb-lg-0&quot;&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;nav-link active&quot; href=&quot;#&quot;&gt;Home&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Link&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item dropdown&quot;&gt;
&lt;a aria-expanded=&quot;false&quot; class=&quot;nav-link dropdown-toggle&quot; data-bs-toggle=&quot;dropdown&quot; href=&quot;#&quot; role=&quot;button&quot;&gt;
            Dropdown
          &lt;/a&gt;
&lt;ul class=&quot;dropdown-menu&quot;&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Another action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;hr class=&quot;dropdown-divider&quot;/&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Something else here&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-disabled=&quot;true&quot; class=&quot;nav-link disabled&quot;&gt;Disabled&lt;/a&gt;
&lt;/li&gt;
&lt;/ul&gt;
&lt;form class=&quot;d-flex&quot; role=&quot;search&quot;&gt;
&lt;input aria-label=&quot;Search&quot; class=&quot;form-control me-2&quot; placeholder=&quot;Search&quot; type=&quot;search&quot;/&gt;
&lt;button class=&quot;btn btn-outline-success&quot; type=&quot;submit&quot;&gt;Search&lt;/button&gt;
&lt;/form&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Navbar</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">Home</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Link</a>
        </li>
        <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Dropdown
          </a>
          <ul class="dropdown-menu">
            <li><a class="dropdown-item" href="#">Action</a></li>
            <li><a class="dropdown-item" href="#">Another action</a></li>
            <li><hr class="dropdown-divider"></li>
            <li><a class="dropdown-item" href="#">Something else here</a></li>
          </ul>
        </li>
        <li class="nav-item">
          <a class="nav-link disabled" aria-disabled="true">Disabled</a>
        </li>
      </ul>
      <form class="d-flex" role="search">
        <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search"/>
        <button class="btn btn-outline-success" type="submit">Search</button>
      </form>
    </div>
  </div>
</nav>
```

This example uses [background](/docs/5.3/utilities/background) (`bg-body-tertiary`) and [spacing](/docs/5.3/utilities/spacing) (`me-auto`, `mb-2`, `mb-lg-0`, `me-2`) utility classes.

### Brand

The `.navbar-brand` can be applied to most elements, but an anchor works best, as some elements might require utility classes or custom styles.

#### Text

Add your text within an element with the `.navbar-brand` class.

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
     &lt;!-- As a link --&gt;
&lt;nav class=&quot;navbar bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Navbar&lt;/a&gt;
&lt;/div&gt;
&lt;/nav&gt;
&lt;!-- As a heading --&gt;
&lt;nav class=&quot;navbar bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;span class=&quot;navbar-brand mb-0 h1&quot;&gt;Navbar&lt;/span&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<!-- As a link -->
<nav class="navbar bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Navbar</a>
  </div>
</nav>

<!-- As a heading -->
<nav class="navbar bg-body-tertiary">
  <div class="container-fluid">
    <span class="navbar-brand mb-0 h1">Navbar</span>
  </div>
</nav>
```

#### Image

You can replace the text within the `.navbar-brand` with an `<img>`.

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
     &lt;nav class=&quot;navbar bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;
&lt;img alt=&quot;Bootstrap&quot; height=&quot;24&quot; src=&quot;/docs/5.3/assets/brand/bootstrap-logo.svg&quot; width=&quot;30&quot;/&gt;
&lt;/a&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar bg-body-tertiary">
  <div class="container">
    <a class="navbar-brand" href="#">
      <img src="/docs/5.3/assets/brand/bootstrap-logo.svg" alt="Bootstrap" width="30" height="24">
    </a>
  </div>
</nav>
```

#### Image and text

You can also make use of some additional utilities to add an image and text at the same time. Note the addition of `.d-inline-block` and `.align-text-top` on the `<img>`.

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
     &lt;nav class=&quot;navbar bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;
&lt;img alt=&quot;Logo&quot; class=&quot;d-inline-block align-text-top&quot; height=&quot;24&quot; src=&quot;/docs/5.3/assets/brand/bootstrap-logo.svg&quot; width=&quot;30&quot;/&gt;
      Bootstrap
    &lt;/a&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">
      <img src="/docs/5.3/assets/brand/bootstrap-logo.svg" alt="Logo" width="30" height="24" class="d-inline-block align-text-top">
      Bootstrap
    </a>
  </div>
</nav>
```

### Nav

Navbar navigation links build on our `.nav` options with their own modifier class and require the use of [toggler classes](#toggler) for proper responsive styling. **Navigation in navbars will also grow to occupy as much horizontal space as possible** to keep your navbar contents securely aligned.

Add the `.active` class on `.nav-link` to indicate the current page.

Please note that you should also add the `aria-current` attribute on the active `.nav-link`.

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
     &lt;nav class=&quot;navbar navbar-expand-lg bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Navbar&lt;/a&gt;
&lt;button aria-controls=&quot;navbarNav&quot; aria-expanded=&quot;false&quot; aria-label=&quot;Toggle navigation&quot; class=&quot;navbar-toggler&quot; data-bs-target=&quot;#navbarNav&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
&lt;span class=&quot;navbar-toggler-icon&quot;&gt;&lt;/span&gt;
&lt;/button&gt;
&lt;div class=&quot;collapse navbar-collapse&quot; id=&quot;navbarNav&quot;&gt;
&lt;ul class=&quot;navbar-nav&quot;&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;nav-link active&quot; href=&quot;#&quot;&gt;Home&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Features&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Pricing&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-disabled=&quot;true&quot; class=&quot;nav-link disabled&quot;&gt;Disabled&lt;/a&gt;
&lt;/li&gt;
&lt;/ul&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Navbar</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNav">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">Home</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Features</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Pricing</a>
        </li>
        <li class="nav-item">
          <a class="nav-link disabled" aria-disabled="true">Disabled</a>
        </li>
      </ul>
    </div>
  </div>
</nav>
```

And because we use classes for our navs, you can avoid the list-based approach entirely if you like.

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
     &lt;nav class=&quot;navbar navbar-expand-lg bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Navbar&lt;/a&gt;
&lt;button aria-controls=&quot;navbarNavAltMarkup&quot; aria-expanded=&quot;false&quot; aria-label=&quot;Toggle navigation&quot; class=&quot;navbar-toggler&quot; data-bs-target=&quot;#navbarNavAltMarkup&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
&lt;span class=&quot;navbar-toggler-icon&quot;&gt;&lt;/span&gt;
&lt;/button&gt;
&lt;div class=&quot;collapse navbar-collapse&quot; id=&quot;navbarNavAltMarkup&quot;&gt;
&lt;div class=&quot;navbar-nav&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;nav-link active&quot; href=&quot;#&quot;&gt;Home&lt;/a&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Features&lt;/a&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Pricing&lt;/a&gt;
&lt;a aria-disabled=&quot;true&quot; class=&quot;nav-link disabled&quot;&gt;Disabled&lt;/a&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Navbar</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
      <div class="navbar-nav">
        <a class="nav-link active" aria-current="page" href="#">Home</a>
        <a class="nav-link" href="#">Features</a>
        <a class="nav-link" href="#">Pricing</a>
        <a class="nav-link disabled" aria-disabled="true">Disabled</a>
      </div>
    </div>
  </div>
</nav>
```

You can also use dropdowns in your navbar. Dropdown menus require a wrapping element for positioning, so be sure to use separate and nested elements for `.nav-item` and `.nav-link` as shown below.

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
     &lt;nav class=&quot;navbar navbar-expand-lg bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Navbar&lt;/a&gt;
&lt;button aria-controls=&quot;navbarNavDropdown&quot; aria-expanded=&quot;false&quot; aria-label=&quot;Toggle navigation&quot; class=&quot;navbar-toggler&quot; data-bs-target=&quot;#navbarNavDropdown&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
&lt;span class=&quot;navbar-toggler-icon&quot;&gt;&lt;/span&gt;
&lt;/button&gt;
&lt;div class=&quot;collapse navbar-collapse&quot; id=&quot;navbarNavDropdown&quot;&gt;
&lt;ul class=&quot;navbar-nav&quot;&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;nav-link active&quot; href=&quot;#&quot;&gt;Home&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Features&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Pricing&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item dropdown&quot;&gt;
&lt;a aria-expanded=&quot;false&quot; class=&quot;nav-link dropdown-toggle&quot; data-bs-toggle=&quot;dropdown&quot; href=&quot;#&quot; role=&quot;button&quot;&gt;
            Dropdown link
          &lt;/a&gt;
&lt;ul class=&quot;dropdown-menu&quot;&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Another action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Something else here&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/li&gt;
&lt;/ul&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Navbar</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNavDropdown">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">Home</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Features</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Pricing</a>
        </li>
        <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Dropdown link
          </a>
          <ul class="dropdown-menu">
            <li><a class="dropdown-item" href="#">Action</a></li>
            <li><a class="dropdown-item" href="#">Another action</a></li>
            <li><a class="dropdown-item" href="#">Something else here</a></li>
          </ul>
        </li>
      </ul>
    </div>
  </div>
</nav>
```

### Forms

Place various form controls and components within a navbar:

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
     &lt;nav class=&quot;navbar bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;form class=&quot;d-flex&quot; role=&quot;search&quot;&gt;
&lt;input aria-label=&quot;Search&quot; class=&quot;form-control me-2&quot; placeholder=&quot;Search&quot; type=&quot;search&quot;/&gt;
&lt;button class=&quot;btn btn-outline-success&quot; type=&quot;submit&quot;&gt;Search&lt;/button&gt;
&lt;/form&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar bg-body-tertiary">
  <div class="container-fluid">
    <form class="d-flex" role="search">
      <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search"/>
      <button class="btn btn-outline-success" type="submit">Search</button>
    </form>
  </div>
</nav>
```

Immediate child elements of `.navbar` use flex layout and will default to `justify-content: space-between`. Use additional [flex utilities](/docs/5.3/utilities/flex) as needed to adjust this behavior.

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
     &lt;nav class=&quot;navbar bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot;&gt;Navbar&lt;/a&gt;
&lt;form class=&quot;d-flex&quot; role=&quot;search&quot;&gt;
&lt;input aria-label=&quot;Search&quot; class=&quot;form-control me-2&quot; placeholder=&quot;Search&quot; type=&quot;search&quot;/&gt;
&lt;button class=&quot;btn btn-outline-success&quot; type=&quot;submit&quot;&gt;Search&lt;/button&gt;
&lt;/form&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand">Navbar</a>
    <form class="d-flex" role="search">
      <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search"/>
      <button class="btn btn-outline-success" type="submit">Search</button>
    </form>
  </div>
</nav>
```

Input groups work, too. If your navbar is an entire form, or mostly a form, you can use the `<form>` element as the container and save some HTML.

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
     &lt;nav class=&quot;navbar bg-body-tertiary&quot;&gt;
&lt;form class=&quot;container-fluid&quot;&gt;
&lt;div class=&quot;input-group&quot;&gt;
&lt;span class=&quot;input-group-text&quot; id=&quot;basic-addon1&quot;&gt;@&lt;/span&gt;
&lt;input aria-describedby=&quot;basic-addon1&quot; aria-label=&quot;Username&quot; class=&quot;form-control&quot; placeholder=&quot;Username&quot; type=&quot;text&quot;/&gt;
&lt;/div&gt;
&lt;/form&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar bg-body-tertiary">
  <form class="container-fluid">
    <div class="input-group">
      <span class="input-group-text" id="basic-addon1">@</span>
      <input type="text" class="form-control" placeholder="Username" aria-label="Username" aria-describedby="basic-addon1"/>
    </div>
  </form>
</nav>
```

Various buttons are supported as part of these navbar forms, too. This is also a great reminder that vertical alignment utilities can be used to align different sized elements.

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
     &lt;nav class=&quot;navbar bg-body-tertiary&quot;&gt;
&lt;form class=&quot;container-fluid justify-content-start&quot;&gt;
&lt;button class=&quot;btn btn-outline-success me-2&quot; type=&quot;button&quot;&gt;Main button&lt;/button&gt;
&lt;button class=&quot;btn btn-sm btn-outline-secondary&quot; type=&quot;button&quot;&gt;Smaller button&lt;/button&gt;
&lt;/form&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar bg-body-tertiary">
  <form class="container-fluid justify-content-start">
    <button class="btn btn-outline-success me-2" type="button">Main button</button>
    <button class="btn btn-sm btn-outline-secondary" type="button">Smaller button</button>
  </form>
</nav>
```

### Text

Navbars may contain bits of text with the help of `.navbar-text`. This class adjusts vertical alignment and horizontal spacing for strings of text.

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
     &lt;nav class=&quot;navbar bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;span class=&quot;navbar-text&quot;&gt;
      Navbar text with an inline element
    &lt;/span&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar bg-body-tertiary">
  <div class="container-fluid">
    <span class="navbar-text">
      Navbar text with an inline element
    </span>
  </div>
</nav>
```

Mix and match with other components and utilities as needed.

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
     &lt;nav class=&quot;navbar navbar-expand-lg bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Navbar w/ text&lt;/a&gt;
&lt;button aria-controls=&quot;navbarText&quot; aria-expanded=&quot;false&quot; aria-label=&quot;Toggle navigation&quot; class=&quot;navbar-toggler&quot; data-bs-target=&quot;#navbarText&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
&lt;span class=&quot;navbar-toggler-icon&quot;&gt;&lt;/span&gt;
&lt;/button&gt;
&lt;div class=&quot;collapse navbar-collapse&quot; id=&quot;navbarText&quot;&gt;
&lt;ul class=&quot;navbar-nav me-auto mb-2 mb-lg-0&quot;&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;nav-link active&quot; href=&quot;#&quot;&gt;Home&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Features&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Pricing&lt;/a&gt;
&lt;/li&gt;
&lt;/ul&gt;
&lt;span class=&quot;navbar-text&quot;&gt;
        Navbar text with an inline element
      &lt;/span&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Navbar w/ text</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarText">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">Home</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Features</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Pricing</a>
        </li>
      </ul>
      <span class="navbar-text">
        Navbar text with an inline element
      </span>
    </div>
  </div>
</nav>
```

## Color schemes

**New dark navbars in v5.3.0 —** We’ve deprecated `.navbar-dark` in favor of the new `data-bs-theme="dark"`. Add `data-bs-theme="dark"` to the `.navbar` to enable a component-specific color mode. [Learn more about our color modes.](/docs/5.3/customize/color-modes)

---

Navbar themes are easier than ever thanks to Bootstrap’s combination of Sass and CSS variables. The default is our “light navbar” for use with light background colors, but you can also apply `data-bs-theme="dark"` to the `.navbar` parent for dark background colors. Then, customize with `.bg-*` and additional utilities.

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
    
&lt;nav class=&quot;navbar navbar-expand-lg bg-dark border-bottom border-body&quot; data-bs-theme=&quot;dark&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Navbar&lt;/a&gt;
&lt;button aria-controls=&quot;navbarColor01&quot; aria-expanded=&quot;false&quot; aria-label=&quot;Toggle navigation&quot; class=&quot;navbar-toggler&quot; data-bs-target=&quot;#navbarColor01&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
&lt;span class=&quot;navbar-toggler-icon&quot;&gt;&lt;/span&gt;
&lt;/button&gt;
&lt;div class=&quot;collapse navbar-collapse&quot; id=&quot;navbarColor01&quot;&gt;
&lt;ul class=&quot;navbar-nav me-auto mb-2 mb-lg-0&quot;&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;nav-link active&quot; href=&quot;#&quot;&gt;Home&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Features&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Pricing&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;About&lt;/a&gt;
&lt;/li&gt;
&lt;/ul&gt;
&lt;form class=&quot;d-flex&quot; role=&quot;search&quot;&gt;
&lt;input aria-label=&quot;Search&quot; class=&quot;form-control me-2&quot; placeholder=&quot;Search&quot; type=&quot;search&quot;/&gt;
&lt;button class=&quot;btn btn-outline-light&quot; type=&quot;submit&quot;&gt;Search&lt;/button&gt;
&lt;/form&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/nav&gt;
&lt;nav class=&quot;navbar navbar-expand-lg bg-primary&quot; data-bs-theme=&quot;dark&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Navbar&lt;/a&gt;
&lt;button aria-controls=&quot;navbarColor02&quot; aria-expanded=&quot;false&quot; aria-label=&quot;Toggle navigation&quot; class=&quot;navbar-toggler&quot; data-bs-target=&quot;#navbarColor02&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
&lt;span class=&quot;navbar-toggler-icon&quot;&gt;&lt;/span&gt;
&lt;/button&gt;
&lt;div class=&quot;collapse navbar-collapse&quot; id=&quot;navbarColor02&quot;&gt;
&lt;ul class=&quot;navbar-nav me-auto mb-2 mb-lg-0&quot;&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;nav-link active&quot; href=&quot;#&quot;&gt;Home&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Features&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Pricing&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;About&lt;/a&gt;
&lt;/li&gt;
&lt;/ul&gt;
&lt;form class=&quot;d-flex&quot; role=&quot;search&quot;&gt;
&lt;input aria-label=&quot;Search&quot; class=&quot;form-control me-2&quot; placeholder=&quot;Search&quot; type=&quot;search&quot;/&gt;
&lt;button class=&quot;btn btn-outline-light&quot; type=&quot;submit&quot;&gt;Search&lt;/button&gt;
&lt;/form&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/nav&gt;
&lt;nav class=&quot;navbar navbar-expand-lg&quot; data-bs-theme=&quot;light&quot; style=&quot;background-color: #e3f2fd;&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Navbar&lt;/a&gt;
&lt;button aria-controls=&quot;navbarColor03&quot; aria-expanded=&quot;false&quot; aria-label=&quot;Toggle navigation&quot; class=&quot;navbar-toggler&quot; data-bs-target=&quot;#navbarColor03&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
&lt;span class=&quot;navbar-toggler-icon&quot;&gt;&lt;/span&gt;
&lt;/button&gt;
&lt;div class=&quot;collapse navbar-collapse&quot; id=&quot;navbarColor03&quot;&gt;
&lt;ul class=&quot;navbar-nav me-auto mb-2 mb-lg-0&quot;&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;nav-link active&quot; href=&quot;#&quot;&gt;Home&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Features&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Pricing&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;About&lt;/a&gt;
&lt;/li&gt;
&lt;/ul&gt;
&lt;form class=&quot;d-flex&quot; role=&quot;search&quot;&gt;
&lt;input aria-label=&quot;Search&quot; class=&quot;form-control me-2&quot; placeholder=&quot;Search&quot; type=&quot;search&quot;/&gt;
&lt;button class=&quot;btn btn-outline-primary&quot; type=&quot;submit&quot;&gt;Search&lt;/button&gt;
&lt;/form&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/nav&gt;

&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

```html
<nav class="navbar bg-dark border-bottom border-body" data-bs-theme="dark">
  <!-- Navbar content -->
</nav>

<nav class="navbar bg-primary" data-bs-theme="dark">
  <!-- Navbar content -->
</nav>

<nav class="navbar" style="background-color: #e3f2fd;" data-bs-theme="light">
  <!-- Navbar content -->
</nav>
```

## Containers

Although it’s not required, you can wrap a navbar in a `.container` to center it on a page–though note that an inner container is still required. Or you can add a container inside the `.navbar` to only center the contents of a [fixed or static top navbar](#placement).

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
     &lt;div class=&quot;container&quot;&gt;
&lt;nav class=&quot;navbar navbar-expand-lg bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Navbar&lt;/a&gt;
&lt;/div&gt;
&lt;/nav&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="container">
  <nav class="navbar navbar-expand-lg bg-body-tertiary">
    <div class="container-fluid">
      <a class="navbar-brand" href="#">Navbar</a>
    </div>
  </nav>
</div>
```

Use any of the responsive containers to change how wide the content in your navbar is presented.

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
     &lt;nav class=&quot;navbar navbar-expand-lg bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-md&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Navbar&lt;/a&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-md">
    <a class="navbar-brand" href="#">Navbar</a>
  </div>
</nav>
```

## Placement

Use our [position utilities](/docs/5.3/utilities/position) to place navbars in non-static positions. Choose from fixed to the top, fixed to the bottom, stickied to the top (scrolls with the page until it reaches the top, then stays there), or stickied to the bottom (scrolls with the page until it reaches the bottom, then stays there).

Fixed navbars use `position: fixed`, meaning they’re pulled from the normal flow of the DOM and may require custom CSS (e.g., `padding-top` on the `<body>`) to prevent overlap with other elements.

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
     &lt;nav class=&quot;navbar bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Default&lt;/a&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Default</a>
  </div>
</nav>
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
     &lt;nav class=&quot;navbar fixed-top bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Fixed top&lt;/a&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar fixed-top bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Fixed top</a>
  </div>
</nav>
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
     &lt;nav class=&quot;navbar fixed-bottom bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Fixed bottom&lt;/a&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar fixed-bottom bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Fixed bottom</a>
  </div>
</nav>
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
     &lt;nav class=&quot;navbar sticky-top bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Sticky top&lt;/a&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar sticky-top bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Sticky top</a>
  </div>
</nav>
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
     &lt;nav class=&quot;navbar sticky-bottom bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Sticky bottom&lt;/a&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar sticky-bottom bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Sticky bottom</a>
  </div>
</nav>
```

## Scrolling

Add `.navbar-nav-scroll` to a `.navbar-nav` (or other navbar sub-component) to enable vertical scrolling within the toggleable contents of a collapsed navbar. By default, scrolling kicks in at `75vh` (or 75% of the viewport height), but you can override that with the local CSS custom property `--bs-navbar-height` or custom styles. At larger viewports when the navbar is expanded, content will appear as it does in a default navbar.

Please note that this behavior comes with a potential drawback of `overflow`—when setting `overflow-y: auto` (required to scroll the content here), `overflow-x` is the equivalent of `auto`, which will crop some horizontal content.

Here’s an example navbar using `.navbar-nav-scroll` with `style="--bs-scroll-height: 100px;"`, with some extra margin utilities for optimum spacing.

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
     &lt;nav class=&quot;navbar navbar-expand-lg bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Navbar scroll&lt;/a&gt;
&lt;button aria-controls=&quot;navbarScroll&quot; aria-expanded=&quot;false&quot; aria-label=&quot;Toggle navigation&quot; class=&quot;navbar-toggler&quot; data-bs-target=&quot;#navbarScroll&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
&lt;span class=&quot;navbar-toggler-icon&quot;&gt;&lt;/span&gt;
&lt;/button&gt;
&lt;div class=&quot;collapse navbar-collapse&quot; id=&quot;navbarScroll&quot;&gt;
&lt;ul class=&quot;navbar-nav me-auto my-2 my-lg-0 navbar-nav-scroll&quot; style=&quot;--bs-scroll-height: 100px;&quot;&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;nav-link active&quot; href=&quot;#&quot;&gt;Home&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Link&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item dropdown&quot;&gt;
&lt;a aria-expanded=&quot;false&quot; class=&quot;nav-link dropdown-toggle&quot; data-bs-toggle=&quot;dropdown&quot; href=&quot;#&quot; role=&quot;button&quot;&gt;
            Link
          &lt;/a&gt;
&lt;ul class=&quot;dropdown-menu&quot;&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Another action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;hr class=&quot;dropdown-divider&quot;/&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Something else here&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-disabled=&quot;true&quot; class=&quot;nav-link disabled&quot;&gt;Link&lt;/a&gt;
&lt;/li&gt;
&lt;/ul&gt;
&lt;form class=&quot;d-flex&quot; role=&quot;search&quot;&gt;
&lt;input aria-label=&quot;Search&quot; class=&quot;form-control me-2&quot; placeholder=&quot;Search&quot; type=&quot;search&quot;/&gt;
&lt;button class=&quot;btn btn-outline-success&quot; type=&quot;submit&quot;&gt;Search&lt;/button&gt;
&lt;/form&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Navbar scroll</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarScroll" aria-controls="navbarScroll" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarScroll">
      <ul class="navbar-nav me-auto my-2 my-lg-0 navbar-nav-scroll" style="--bs-scroll-height: 100px;">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">Home</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Link</a>
        </li>
        <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Link
          </a>
          <ul class="dropdown-menu">
            <li><a class="dropdown-item" href="#">Action</a></li>
            <li><a class="dropdown-item" href="#">Another action</a></li>
            <li><hr class="dropdown-divider"></li>
            <li><a class="dropdown-item" href="#">Something else here</a></li>
          </ul>
        </li>
        <li class="nav-item">
          <a class="nav-link disabled" aria-disabled="true">Link</a>
        </li>
      </ul>
      <form class="d-flex" role="search">
        <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search"/>
        <button class="btn btn-outline-success" type="submit">Search</button>
      </form>
    </div>
  </div>
</nav>
```

## Responsive behaviors

Navbars can use `.navbar-toggler`, `.navbar-collapse`, and `.navbar-expand{-sm|-md|-lg|-xl|-xxl}` classes to determine when their content collapses behind a button. In combination with other utilities, you can easily choose when to show or hide particular elements.

For navbars that never collapse, add the `.navbar-expand` class on the navbar. For navbars that always collapse, don’t add any `.navbar-expand` class.

### Toggler

Navbar togglers are left-aligned by default, but should they follow a sibling element like a `.navbar-brand`, they’ll automatically be aligned to the far right. Reversing your markup will reverse the placement of the toggler. Below are examples of different toggle styles.

With no `.navbar-brand` shown at the smallest breakpoint:

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
     &lt;nav class=&quot;navbar navbar-expand-lg bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;button aria-controls=&quot;navbarTogglerDemo01&quot; aria-expanded=&quot;false&quot; aria-label=&quot;Toggle navigation&quot; class=&quot;navbar-toggler&quot; data-bs-target=&quot;#navbarTogglerDemo01&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
&lt;span class=&quot;navbar-toggler-icon&quot;&gt;&lt;/span&gt;
&lt;/button&gt;
&lt;div class=&quot;collapse navbar-collapse&quot; id=&quot;navbarTogglerDemo01&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Hidden brand&lt;/a&gt;
&lt;ul class=&quot;navbar-nav me-auto mb-2 mb-lg-0&quot;&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;nav-link active&quot; href=&quot;#&quot;&gt;Home&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Link&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-disabled=&quot;true&quot; class=&quot;nav-link disabled&quot;&gt;Disabled&lt;/a&gt;
&lt;/li&gt;
&lt;/ul&gt;
&lt;form class=&quot;d-flex&quot; role=&quot;search&quot;&gt;
&lt;input aria-label=&quot;Search&quot; class=&quot;form-control me-2&quot; placeholder=&quot;Search&quot; type=&quot;search&quot;/&gt;
&lt;button class=&quot;btn btn-outline-success&quot; type=&quot;submit&quot;&gt;Search&lt;/button&gt;
&lt;/form&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarTogglerDemo01" aria-controls="navbarTogglerDemo01" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarTogglerDemo01">
      <a class="navbar-brand" href="#">Hidden brand</a>
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">Home</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Link</a>
        </li>
        <li class="nav-item">
          <a class="nav-link disabled" aria-disabled="true">Disabled</a>
        </li>
      </ul>
      <form class="d-flex" role="search">
        <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search"/>
        <button class="btn btn-outline-success" type="submit">Search</button>
      </form>
    </div>
  </div>
</nav>
```

With a brand name shown on the left and toggler on the right:

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
     &lt;nav class=&quot;navbar navbar-expand-lg bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Navbar&lt;/a&gt;
&lt;button aria-controls=&quot;navbarTogglerDemo02&quot; aria-expanded=&quot;false&quot; aria-label=&quot;Toggle navigation&quot; class=&quot;navbar-toggler&quot; data-bs-target=&quot;#navbarTogglerDemo02&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
&lt;span class=&quot;navbar-toggler-icon&quot;&gt;&lt;/span&gt;
&lt;/button&gt;
&lt;div class=&quot;collapse navbar-collapse&quot; id=&quot;navbarTogglerDemo02&quot;&gt;
&lt;ul class=&quot;navbar-nav me-auto mb-2 mb-lg-0&quot;&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;nav-link active&quot; href=&quot;#&quot;&gt;Home&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Link&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-disabled=&quot;true&quot; class=&quot;nav-link disabled&quot;&gt;Disabled&lt;/a&gt;
&lt;/li&gt;
&lt;/ul&gt;
&lt;form class=&quot;d-flex&quot; role=&quot;search&quot;&gt;
&lt;input aria-label=&quot;Search&quot; class=&quot;form-control me-2&quot; placeholder=&quot;Search&quot; type=&quot;search&quot;/&gt;
&lt;button class=&quot;btn btn-outline-success&quot; type=&quot;submit&quot;&gt;Search&lt;/button&gt;
&lt;/form&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Navbar</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarTogglerDemo02" aria-controls="navbarTogglerDemo02" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarTogglerDemo02">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">Home</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Link</a>
        </li>
        <li class="nav-item">
          <a class="nav-link disabled" aria-disabled="true">Disabled</a>
        </li>
      </ul>
      <form class="d-flex" role="search">
        <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search"/>
        <button class="btn btn-outline-success" type="submit">Search</button>
      </form>
    </div>
  </div>
</nav>
```

With a toggler on the left and brand name on the right:

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
     &lt;nav class=&quot;navbar navbar-expand-lg bg-body-tertiary&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;button aria-controls=&quot;navbarTogglerDemo03&quot; aria-expanded=&quot;false&quot; aria-label=&quot;Toggle navigation&quot; class=&quot;navbar-toggler&quot; data-bs-target=&quot;#navbarTogglerDemo03&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
&lt;span class=&quot;navbar-toggler-icon&quot;&gt;&lt;/span&gt;
&lt;/button&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Navbar&lt;/a&gt;
&lt;div class=&quot;collapse navbar-collapse&quot; id=&quot;navbarTogglerDemo03&quot;&gt;
&lt;ul class=&quot;navbar-nav me-auto mb-2 mb-lg-0&quot;&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;nav-link active&quot; href=&quot;#&quot;&gt;Home&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Link&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-disabled=&quot;true&quot; class=&quot;nav-link disabled&quot;&gt;Disabled&lt;/a&gt;
&lt;/li&gt;
&lt;/ul&gt;
&lt;form class=&quot;d-flex&quot; role=&quot;search&quot;&gt;
&lt;input aria-label=&quot;Search&quot; class=&quot;form-control me-2&quot; placeholder=&quot;Search&quot; type=&quot;search&quot;/&gt;
&lt;button class=&quot;btn btn-outline-success&quot; type=&quot;submit&quot;&gt;Search&lt;/button&gt;
&lt;/form&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarTogglerDemo03" aria-controls="navbarTogglerDemo03" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <a class="navbar-brand" href="#">Navbar</a>
    <div class="collapse navbar-collapse" id="navbarTogglerDemo03">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">Home</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Link</a>
        </li>
        <li class="nav-item">
          <a class="nav-link disabled" aria-disabled="true">Disabled</a>
        </li>
      </ul>
      <form class="d-flex" role="search">
        <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search"/>
        <button class="btn btn-outline-success" type="submit">Search</button>
      </form>
    </div>
  </div>
</nav>
```

### External content

Sometimes you want to use the collapse plugin to trigger a container element for content that structurally sits outside of the `.navbar` . Because our plugin works on the `id` and `data-bs-target` matching, that’s easily done!

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
     &lt;div class=&quot;collapse&quot; data-bs-theme=&quot;dark&quot; id=&quot;navbarToggleExternalContent&quot;&gt;
&lt;div class=&quot;bg-dark p-4&quot;&gt;
&lt;h5 class=&quot;text-body-emphasis h4&quot;&gt;Collapsed content&lt;/h5&gt;
&lt;span class=&quot;text-body-secondary&quot;&gt;Toggleable via the navbar brand.&lt;/span&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;nav class=&quot;navbar navbar-dark bg-dark&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;button aria-controls=&quot;navbarToggleExternalContent&quot; aria-expanded=&quot;false&quot; aria-label=&quot;Toggle navigation&quot; class=&quot;navbar-toggler&quot; data-bs-target=&quot;#navbarToggleExternalContent&quot; data-bs-toggle=&quot;collapse&quot; type=&quot;button&quot;&gt;
&lt;span class=&quot;navbar-toggler-icon&quot;&gt;&lt;/span&gt;
&lt;/button&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="collapse" id="navbarToggleExternalContent" data-bs-theme="dark">
  <div class="bg-dark p-4">
    <h5 class="text-body-emphasis h4">Collapsed content</h5>
    <span class="text-body-secondary">Toggleable via the navbar brand.</span>
  </div>
</div>
<nav class="navbar navbar-dark bg-dark">
  <div class="container-fluid">
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarToggleExternalContent" aria-controls="navbarToggleExternalContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
  </div>
</nav>
```

When you do this, we recommend including additional JavaScript to move the focus programmatically to the container when it is opened. Otherwise, keyboard users and users of assistive technologies will likely have a hard time finding the newly revealed content - particularly if the container that was opened comes *before* the toggler in the document’s structure. We also recommend making sure that the toggler has the `aria-controls` attribute, pointing to the `id` of the content container. In theory, this allows assistive technology users to jump directly from the toggler to the container it controls–but support for this is currently quite patchy.

### Offcanvas

Transform your expanding and collapsing navbar into an offcanvas drawer with the [offcanvas component](/docs/5.3/components/offcanvas). We extend both the offcanvas default styles and use our `.navbar-expand-*` classes to create a dynamic and flexible navigation sidebar.

In the example below, to create an offcanvas navbar that is always collapsed across all breakpoints, omit the `.navbar-expand-*` class entirely.

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
     &lt;nav class=&quot;navbar bg-body-tertiary fixed-top&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Offcanvas navbar&lt;/a&gt;
&lt;button aria-controls=&quot;offcanvasNavbar&quot; aria-label=&quot;Toggle navigation&quot; class=&quot;navbar-toggler&quot; data-bs-target=&quot;#offcanvasNavbar&quot; data-bs-toggle=&quot;offcanvas&quot; type=&quot;button&quot;&gt;
&lt;span class=&quot;navbar-toggler-icon&quot;&gt;&lt;/span&gt;
&lt;/button&gt;
&lt;div aria-labelledby=&quot;offcanvasNavbarLabel&quot; class=&quot;offcanvas offcanvas-end&quot; id=&quot;offcanvasNavbar&quot; tabindex=&quot;-1&quot;&gt;
&lt;div class=&quot;offcanvas-header&quot;&gt;
&lt;h5 class=&quot;offcanvas-title&quot; id=&quot;offcanvasNavbarLabel&quot;&gt;Offcanvas&lt;/h5&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;offcanvas&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;offcanvas-body&quot;&gt;
&lt;ul class=&quot;navbar-nav justify-content-end flex-grow-1 pe-3&quot;&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;nav-link active&quot; href=&quot;#&quot;&gt;Home&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Link&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item dropdown&quot;&gt;
&lt;a aria-expanded=&quot;false&quot; class=&quot;nav-link dropdown-toggle&quot; data-bs-toggle=&quot;dropdown&quot; href=&quot;#&quot; role=&quot;button&quot;&gt;
              Dropdown
            &lt;/a&gt;
&lt;ul class=&quot;dropdown-menu&quot;&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Another action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;
&lt;hr class=&quot;dropdown-divider&quot;/&gt;
&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Something else here&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/li&gt;
&lt;/ul&gt;
&lt;form class=&quot;d-flex mt-3&quot; role=&quot;search&quot;&gt;
&lt;input aria-label=&quot;Search&quot; class=&quot;form-control me-2&quot; placeholder=&quot;Search&quot; type=&quot;search&quot;/&gt;
&lt;button class=&quot;btn btn-outline-success&quot; type=&quot;submit&quot;&gt;Search&lt;/button&gt;
&lt;/form&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar bg-body-tertiary fixed-top">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Offcanvas navbar</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasNavbar" aria-controls="offcanvasNavbar" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="offcanvas offcanvas-end" tabindex="-1" id="offcanvasNavbar" aria-labelledby="offcanvasNavbarLabel">
      <div class="offcanvas-header">
        <h5 class="offcanvas-title" id="offcanvasNavbarLabel">Offcanvas</h5>
        <button type="button" class="btn-close" data-bs-dismiss="offcanvas" aria-label="Close"></button>
      </div>
      <div class="offcanvas-body">
        <ul class="navbar-nav justify-content-end flex-grow-1 pe-3">
          <li class="nav-item">
            <a class="nav-link active" aria-current="page" href="#">Home</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#">Link</a>
          </li>
          <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
              Dropdown
            </a>
            <ul class="dropdown-menu">
              <li><a class="dropdown-item" href="#">Action</a></li>
              <li><a class="dropdown-item" href="#">Another action</a></li>
              <li>
                <hr class="dropdown-divider">
              </li>
              <li><a class="dropdown-item" href="#">Something else here</a></li>
            </ul>
          </li>
        </ul>
        <form class="d-flex mt-3" role="search">
          <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search"/>
          <button class="btn btn-outline-success" type="submit">Search</button>
        </form>
      </div>
    </div>
  </div>
</nav>
```

To create an offcanvas navbar that expands into a normal navbar at a specific breakpoint like `lg`, use `.navbar-expand-lg`.

```html
<nav class="navbar navbar-expand-lg bg-body-tertiary fixed-top">
  <a class="navbar-brand" href="#">Offcanvas navbar</a>
  <button class="navbar-toggler" type="button" data-bs-toggle="offcanvas" data-bs-target="#navbarOffcanvasLg" aria-controls="navbarOffcanvasLg" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="offcanvas offcanvas-end" tabindex="-1" id="navbarOffcanvasLg" aria-labelledby="navbarOffcanvasLgLabel">
    ...
  </div>
</nav>
```

When using offcanvas in a dark navbar, be aware that you may need to have a dark background on the offcanvas content to avoid the text becoming illegible. In the example below, we add `.navbar-dark` and `.bg-dark` to the `.navbar`, `.text-bg-dark` to the `.offcanvas`, `.dropdown-menu-dark` to `.dropdown-menu`, and `.btn-close-white` to `.btn-close` for proper styling with a dark offcanvas.

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
     &lt;nav class=&quot;navbar navbar-dark bg-dark fixed-top&quot;&gt;
&lt;div class=&quot;container-fluid&quot;&gt;
&lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Offcanvas dark navbar&lt;/a&gt;
&lt;button aria-controls=&quot;offcanvasDarkNavbar&quot; aria-label=&quot;Toggle navigation&quot; class=&quot;navbar-toggler&quot; data-bs-target=&quot;#offcanvasDarkNavbar&quot; data-bs-toggle=&quot;offcanvas&quot; type=&quot;button&quot;&gt;
&lt;span class=&quot;navbar-toggler-icon&quot;&gt;&lt;/span&gt;
&lt;/button&gt;
&lt;div aria-labelledby=&quot;offcanvasDarkNavbarLabel&quot; class=&quot;offcanvas offcanvas-end text-bg-dark&quot; id=&quot;offcanvasDarkNavbar&quot; tabindex=&quot;-1&quot;&gt;
&lt;div class=&quot;offcanvas-header&quot;&gt;
&lt;h5 class=&quot;offcanvas-title&quot; id=&quot;offcanvasDarkNavbarLabel&quot;&gt;Dark offcanvas&lt;/h5&gt;
&lt;button aria-label=&quot;Close&quot; class=&quot;btn-close btn-close-white&quot; data-bs-dismiss=&quot;offcanvas&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;offcanvas-body&quot;&gt;
&lt;ul class=&quot;navbar-nav justify-content-end flex-grow-1 pe-3&quot;&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a aria-current=&quot;page&quot; class=&quot;nav-link active&quot; href=&quot;#&quot;&gt;Home&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item&quot;&gt;
&lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Link&lt;/a&gt;
&lt;/li&gt;
&lt;li class=&quot;nav-item dropdown&quot;&gt;
&lt;a aria-expanded=&quot;false&quot; class=&quot;nav-link dropdown-toggle&quot; data-bs-toggle=&quot;dropdown&quot; href=&quot;#&quot; role=&quot;button&quot;&gt;
              Dropdown
            &lt;/a&gt;
&lt;ul class=&quot;dropdown-menu dropdown-menu-dark&quot;&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Another action&lt;/a&gt;&lt;/li&gt;
&lt;li&gt;
&lt;hr class=&quot;dropdown-divider&quot;/&gt;
&lt;/li&gt;
&lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Something else here&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
&lt;/li&gt;
&lt;/ul&gt;
&lt;form class=&quot;d-flex mt-3&quot; role=&quot;search&quot;&gt;
&lt;input aria-label=&quot;Search&quot; class=&quot;form-control me-2&quot; placeholder=&quot;Search&quot; type=&quot;search&quot;/&gt;
&lt;button class=&quot;btn btn-success&quot; type=&quot;submit&quot;&gt;Search&lt;/button&gt;
&lt;/form&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/nav&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<nav class="navbar navbar-dark bg-dark fixed-top">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Offcanvas dark navbar</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasDarkNavbar" aria-controls="offcanvasDarkNavbar" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="offcanvas offcanvas-end text-bg-dark" tabindex="-1" id="offcanvasDarkNavbar" aria-labelledby="offcanvasDarkNavbarLabel">
      <div class="offcanvas-header">
        <h5 class="offcanvas-title" id="offcanvasDarkNavbarLabel">Dark offcanvas</h5>
        <button type="button" class="btn-close btn-close-white" data-bs-dismiss="offcanvas" aria-label="Close"></button>
      </div>
      <div class="offcanvas-body">
        <ul class="navbar-nav justify-content-end flex-grow-1 pe-3">
          <li class="nav-item">
            <a class="nav-link active" aria-current="page" href="#">Home</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#">Link</a>
          </li>
          <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
              Dropdown
            </a>
            <ul class="dropdown-menu dropdown-menu-dark">
              <li><a class="dropdown-item" href="#">Action</a></li>
              <li><a class="dropdown-item" href="#">Another action</a></li>
              <li>
                <hr class="dropdown-divider">
              </li>
              <li><a class="dropdown-item" href="#">Something else here</a></li>
            </ul>
          </li>
        </ul>
        <form class="d-flex mt-3" role="search">
          <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search"/>
          <button class="btn btn-success" type="submit">Search</button>
        </form>
      </div>
    </div>
  </div>
</nav>
```

## CSS

### Variables

Added in v5.2.0

As part of Bootstrap’s evolving CSS variables approach, navbars now use local CSS variables on `.navbar` for enhanced real-time customization. Values for the CSS variables are set via Sass, so Sass customization is still supported, too.

[scss/\_navbar.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_navbar.scss)

```html
--#{$prefix}navbar-padding-x: #{if($navbar-padding-x == null, 0, $navbar-padding-x)};
--#{$prefix}navbar-padding-y: #{$navbar-padding-y};
--#{$prefix}navbar-color: #{$navbar-light-color};
--#{$prefix}navbar-hover-color: #{$navbar-light-hover-color};
--#{$prefix}navbar-disabled-color: #{$navbar-light-disabled-color};
--#{$prefix}navbar-active-color: #{$navbar-light-active-color};
--#{$prefix}navbar-brand-padding-y: #{$navbar-brand-padding-y};
--#{$prefix}navbar-brand-margin-end: #{$navbar-brand-margin-end};
--#{$prefix}navbar-brand-font-size: #{$navbar-brand-font-size};
--#{$prefix}navbar-brand-color: #{$navbar-light-brand-color};
--#{$prefix}navbar-brand-hover-color: #{$navbar-light-brand-hover-color};
--#{$prefix}navbar-nav-link-padding-x: #{$navbar-nav-link-padding-x};
--#{$prefix}navbar-toggler-padding-y: #{$navbar-toggler-padding-y};
--#{$prefix}navbar-toggler-padding-x: #{$navbar-toggler-padding-x};
--#{$prefix}navbar-toggler-font-size: #{$navbar-toggler-font-size};
--#{$prefix}navbar-toggler-icon-bg: #{escape-svg($navbar-light-toggler-icon-bg)};
--#{$prefix}navbar-toggler-border-color: #{$navbar-light-toggler-border-color};
--#{$prefix}navbar-toggler-border-radius: #{$navbar-toggler-border-radius};
--#{$prefix}navbar-toggler-focus-width: #{$navbar-toggler-focus-width};
--#{$prefix}navbar-toggler-transition: #{$navbar-toggler-transition};
```

Some additional CSS variables are also present on `.navbar-nav`:

[scss/\_navbar.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_navbar.scss)

```html
--#{$prefix}nav-link-padding-x: 0;
--#{$prefix}nav-link-padding-y: #{$nav-link-padding-y};
@include rfs($nav-link-font-size, --#{$prefix}nav-link-font-size);
--#{$prefix}nav-link-font-weight: #{$nav-link-font-weight};
--#{$prefix}nav-link-color: var(--#{$prefix}navbar-color);
--#{$prefix}nav-link-hover-color: var(--#{$prefix}navbar-hover-color);
--#{$prefix}nav-link-disabled-color: var(--#{$prefix}navbar-disabled-color);
```

Customization through CSS variables can be seen on the `.navbar-dark` class where we override specific values without adding duplicate CSS selectors.

[scss/\_navbar.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_navbar.scss)

```html
--#{$prefix}navbar-color: #{$navbar-dark-color};
--#{$prefix}navbar-hover-color: #{$navbar-dark-hover-color};
--#{$prefix}navbar-disabled-color: #{$navbar-dark-disabled-color};
--#{$prefix}navbar-active-color: #{$navbar-dark-active-color};
--#{$prefix}navbar-brand-color: #{$navbar-dark-brand-color};
--#{$prefix}navbar-brand-hover-color: #{$navbar-dark-brand-hover-color};
--#{$prefix}navbar-toggler-border-color: #{$navbar-dark-toggler-border-color};
--#{$prefix}navbar-toggler-icon-bg: #{escape-svg($navbar-dark-toggler-icon-bg)};
```

### Sass variables

Variables for all navbars:

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$navbar-padding-y:                  $spacer * .5;
$navbar-padding-x:                  null;

$navbar-nav-link-padding-x:         .5rem;

$navbar-brand-font-size:            $font-size-lg;
// Compute the navbar-brand padding-y so the navbar-brand will have the same height as navbar-text and nav-link
$nav-link-height:                   $font-size-base * $line-height-base + $nav-link-padding-y * 2;
$navbar-brand-height:               $navbar-brand-font-size * $line-height-base;
$navbar-brand-padding-y:            ($nav-link-height - $navbar-brand-height) * .5;
$navbar-brand-margin-end:           1rem;

$navbar-toggler-padding-y:          .25rem;
$navbar-toggler-padding-x:          .75rem;
$navbar-toggler-font-size:          $font-size-lg;
$navbar-toggler-border-radius:      $btn-border-radius;
$navbar-toggler-focus-width:        $btn-focus-width;
$navbar-toggler-transition:         box-shadow .15s ease-in-out;

$navbar-light-color:                rgba(var(--#{$prefix}emphasis-color-rgb), .65);
$navbar-light-hover-color:          rgba(var(--#{$prefix}emphasis-color-rgb), .8);
$navbar-light-active-color:         rgba(var(--#{$prefix}emphasis-color-rgb), 1);
$navbar-light-disabled-color:       rgba(var(--#{$prefix}emphasis-color-rgb), .3);
$navbar-light-icon-color:           rgba($body-color, .75);
$navbar-light-toggler-icon-bg:      url("data:image/svg+xml,<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 30 30'><path stroke='#{$navbar-light-icon-color}' stroke-linecap='round' stroke-miterlimit='10' stroke-width='2' d='M4 7h22M4 15h22M4 23h22'/></svg>");
$navbar-light-toggler-border-color: rgba(var(--#{$prefix}emphasis-color-rgb), .15);
$navbar-light-brand-color:          $navbar-light-active-color;
$navbar-light-brand-hover-color:    $navbar-light-active-color;
```

Variables for the [dark navbar](#color-schemes):

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$navbar-dark-color:                 rgba($white, .55);
$navbar-dark-hover-color:           rgba($white, .75);
$navbar-dark-active-color:          $white;
$navbar-dark-disabled-color:        rgba($white, .25);
$navbar-dark-icon-color:            $navbar-dark-color;
$navbar-dark-toggler-icon-bg:       url("data:image/svg+xml,<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 30 30'><path stroke='#{$navbar-dark-icon-color}' stroke-linecap='round' stroke-miterlimit='10' stroke-width='2' d='M4 7h22M4 15h22M4 23h22'/></svg>");
$navbar-dark-toggler-border-color:  rgba($white, .1);
$navbar-dark-brand-color:           $navbar-dark-active-color;
$navbar-dark-brand-hover-color:     $navbar-dark-active-color;
```

### Sass loops

[Responsive navbar expand/collapse classes](#responsive-behaviors) (e.g., `.navbar-expand-lg`) are combined with the `$breakpoints` map and generated through a loop in `scss/_navbar.scss`.

[scss/\_navbar.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_navbar.scss)

```html
// Generate series of `.navbar-expand-*` responsive classes for configuring
// where your navbar collapses.
.navbar-expand {
  @each $breakpoint in map-keys($grid-breakpoints) {
    $next: breakpoint-next($breakpoint, $grid-breakpoints);
    $infix: breakpoint-infix($next, $grid-breakpoints);

    // stylelint-disable-next-line scss/selector-no-union-class-name
    &#{$infix} {
      @include media-breakpoint-up($next) {
        flex-wrap: nowrap;
        justify-content: flex-start;

        .navbar-nav {
          flex-direction: row;

          .dropdown-menu {
            position: absolute;
          }

          .nav-link {
            padding-right: var(--#{$prefix}navbar-nav-link-padding-x);
            padding-left: var(--#{$prefix}navbar-nav-link-padding-x);
          }
        }

        .navbar-nav-scroll {
          overflow: visible;
        }

        .navbar-collapse {
          display: flex !important; // stylelint-disable-line declaration-no-important
          flex-basis: auto;
        }

        .navbar-toggler {
          display: none;
        }

        .offcanvas {
          // stylelint-disable declaration-no-important
          position: static;
          z-index: auto;
          flex-grow: 1;
          width: auto !important;
          height: auto !important;
          visibility: visible !important;
          background-color: transparent !important;
          border: 0 !important;
          transform: none !important;
          @include box-shadow(none);
          @include transition(none);
          // stylelint-enable declaration-no-important

          .offcanvas-header {
            display: none;
          }

          .offcanvas-body {
            display: flex;
            flex-grow: 0;
            padding: 0;
            overflow-y: visible;
          }
        }
      }
    }
  }
}
```

