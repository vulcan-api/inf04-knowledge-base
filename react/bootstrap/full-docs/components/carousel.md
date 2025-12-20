> Źródło: [https://getbootstrap.com/docs/5.3/components/carousel](https://getbootstrap.com/docs/5.3/components/carousel)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/components/carousel.mdx "View and edit this file on GitHub")

# Carousel

A slideshow component for cycling through elements—images or slides of text—like a carousel.

On this page
   
**On this page**

---

* [How it works](#how-it-works)
* [Basic examples](#basic-examples)
  + [Indicators](#indicators)
  + [Captions](#captions)
  + [Crossfade](#crossfade)
* [Autoplaying carousels](#autoplaying-carousels)
  + [Individual .carousel-item interval](#individual-carousel-item-interval)
  + [Autoplaying carousels without controls](#autoplaying-carousels-without-controls)
* [Disable touch swiping](#disable-touch-swiping)
* [Dark variant](#dark-variant)
* [Custom transition](#custom-transition)
* [CSS](#css)
  + [Sass variables](#sass-variables)
* [Usage](#usage)
  + [Via data attributes](#via-data-attributes)
  + [Via JavaScript](#via-javascript)
  + [Options](#options)
  + [Methods](#methods)
  + [Events](#events)

## How it works

* The carousel is a slideshow for cycling through a series of content, built with CSS 3D transforms and a bit of JavaScript. It works with a series of images, text, or custom markup. It also includes support for previous/next controls and indicators.
* For performance reasons, **carousels must be manually initialized** using the [carousel constructor method](#methods). Without initialization, some of the event listeners (specifically, the events needed touch/swipe support) will not be registered until a user has explicitly activated a control or indicator.

  The only exception are [autoplaying carousels](#autoplaying-carousels) with the `data-bs-ride="carousel"` attribute as these are initialized automatically on page load. If you’re using autoplaying carousels with the data attribute, **don’t explicitly initialize the same carousels with the constructor method.**
* Nested carousels are not supported. You should also be aware that carousels in general can often cause usability and accessibility challenges.

The animation effect of this component is dependent on the `prefers-reduced-motion` media query. See the [reduced motion section of our accessibility documentation](/docs/5.3/getting-started/accessibility/#reduced-motion).

## Basic examples

Here is a basic example of a carousel with three slides. Note the previous/next controls. We recommend using `<button>` elements, but you can also use `<a>` elements with `role="button"`.

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
     &lt;div class=&quot;carousel slide&quot; id=&quot;carouselExample&quot;&gt;
&lt;div class=&quot;carousel-inner&quot;&gt;
&lt;div class=&quot;carousel-item active&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: First slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#777&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#555&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;First slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Second slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#666&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#444&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Second slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Third slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#555&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#333&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Third slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;button class=&quot;carousel-control-prev&quot; data-bs-slide=&quot;prev&quot; data-bs-target=&quot;#carouselExample&quot; type=&quot;button&quot;&gt;
&lt;span aria-hidden=&quot;true&quot; class=&quot;carousel-control-prev-icon&quot;&gt;&lt;/span&gt;
&lt;span class=&quot;visually-hidden&quot;&gt;Previous&lt;/span&gt;
&lt;/button&gt;
&lt;button class=&quot;carousel-control-next&quot; data-bs-slide=&quot;next&quot; data-bs-target=&quot;#carouselExample&quot; type=&quot;button&quot;&gt;
&lt;span aria-hidden=&quot;true&quot; class=&quot;carousel-control-next-icon&quot;&gt;&lt;/span&gt;
&lt;span class=&quot;visually-hidden&quot;&gt;Next&lt;/span&gt;
&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div id="carouselExample" class="carousel slide">
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="..." class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExample" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>
```

Carousels don’t automatically normalize slide dimensions. As such, you may need to use additional utilities or custom styles to appropriately size content. While carousels support previous/next controls and indicators, they’re not explicitly required. Add and customize as you see fit.

**You must add the `.active` class to one of the slides**, otherwise the carousel will not be visible. Also be sure to set a unique `id` on the `.carousel` for optional controls, especially if you’re using multiple carousels on a single page. Control and indicator elements must have a `data-bs-target` attribute (or `href` for links) that matches the `id` of the `.carousel` element.

### Indicators

You can add indicators to the carousel, alongside the previous/next controls. The indicators let users jump directly to a particular slide.

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
     &lt;div class=&quot;carousel slide&quot; id=&quot;carouselExampleIndicators&quot;&gt;
&lt;div class=&quot;carousel-indicators&quot;&gt;
&lt;button aria-current=&quot;true&quot; aria-label=&quot;Slide 1&quot; class=&quot;active&quot; data-bs-slide-to=&quot;0&quot; data-bs-target=&quot;#carouselExampleIndicators&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;button aria-label=&quot;Slide 2&quot; data-bs-slide-to=&quot;1&quot; data-bs-target=&quot;#carouselExampleIndicators&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;button aria-label=&quot;Slide 3&quot; data-bs-slide-to=&quot;2&quot; data-bs-target=&quot;#carouselExampleIndicators&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-inner&quot;&gt;
&lt;div class=&quot;carousel-item active&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: First slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#777&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#555&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;First slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Second slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#666&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#444&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Second slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Third slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#555&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#333&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Third slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;button class=&quot;carousel-control-prev&quot; data-bs-slide=&quot;prev&quot; data-bs-target=&quot;#carouselExampleIndicators&quot; type=&quot;button&quot;&gt;
&lt;span aria-hidden=&quot;true&quot; class=&quot;carousel-control-prev-icon&quot;&gt;&lt;/span&gt;
&lt;span class=&quot;visually-hidden&quot;&gt;Previous&lt;/span&gt;
&lt;/button&gt;
&lt;button class=&quot;carousel-control-next&quot; data-bs-slide=&quot;next&quot; data-bs-target=&quot;#carouselExampleIndicators&quot; type=&quot;button&quot;&gt;
&lt;span aria-hidden=&quot;true&quot; class=&quot;carousel-control-next-icon&quot;&gt;&lt;/span&gt;
&lt;span class=&quot;visually-hidden&quot;&gt;Next&lt;/span&gt;
&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div id="carouselExampleIndicators" class="carousel slide">
  <div class="carousel-indicators">
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
  </div>
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="..." class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>
```

### Captions

You can add captions to your slides with the `.carousel-caption` element within any `.carousel-item`. They can be easily hidden on smaller viewports, as shown below, with optional [display utilities](/docs/5.3/utilities/display). We hide them initially with `.d-none` and bring them back on medium-sized devices with `.d-md-block`.

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
     &lt;div class=&quot;carousel slide&quot; id=&quot;carouselExampleCaptions&quot;&gt;
&lt;div class=&quot;carousel-indicators&quot;&gt;
&lt;button aria-current=&quot;true&quot; aria-label=&quot;Slide 1&quot; class=&quot;active&quot; data-bs-slide-to=&quot;0&quot; data-bs-target=&quot;#carouselExampleCaptions&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;button aria-label=&quot;Slide 2&quot; data-bs-slide-to=&quot;1&quot; data-bs-target=&quot;#carouselExampleCaptions&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;button aria-label=&quot;Slide 3&quot; data-bs-slide-to=&quot;2&quot; data-bs-target=&quot;#carouselExampleCaptions&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-inner&quot;&gt;
&lt;div class=&quot;carousel-item active&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: First slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#777&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#555&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;First slide&lt;/text&gt;&lt;/svg&gt;
&lt;div class=&quot;carousel-caption d-none d-md-block&quot;&gt;
&lt;h5&gt;First slide label&lt;/h5&gt;
&lt;p&gt;Some representative placeholder content for the first slide.&lt;/p&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Second slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#666&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#444&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Second slide&lt;/text&gt;&lt;/svg&gt;
&lt;div class=&quot;carousel-caption d-none d-md-block&quot;&gt;
&lt;h5&gt;Second slide label&lt;/h5&gt;
&lt;p&gt;Some representative placeholder content for the second slide.&lt;/p&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Third slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#555&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#333&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Third slide&lt;/text&gt;&lt;/svg&gt;
&lt;div class=&quot;carousel-caption d-none d-md-block&quot;&gt;
&lt;h5&gt;Third slide label&lt;/h5&gt;
&lt;p&gt;Some representative placeholder content for the third slide.&lt;/p&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;button class=&quot;carousel-control-prev&quot; data-bs-slide=&quot;prev&quot; data-bs-target=&quot;#carouselExampleCaptions&quot; type=&quot;button&quot;&gt;
&lt;span aria-hidden=&quot;true&quot; class=&quot;carousel-control-prev-icon&quot;&gt;&lt;/span&gt;
&lt;span class=&quot;visually-hidden&quot;&gt;Previous&lt;/span&gt;
&lt;/button&gt;
&lt;button class=&quot;carousel-control-next&quot; data-bs-slide=&quot;next&quot; data-bs-target=&quot;#carouselExampleCaptions&quot; type=&quot;button&quot;&gt;
&lt;span aria-hidden=&quot;true&quot; class=&quot;carousel-control-next-icon&quot;&gt;&lt;/span&gt;
&lt;span class=&quot;visually-hidden&quot;&gt;Next&lt;/span&gt;
&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div id="carouselExampleCaptions" class="carousel slide">
  <div class="carousel-indicators">
    <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
    <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="1" aria-label="Slide 2"></button>
    <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="2" aria-label="Slide 3"></button>
  </div>
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="..." class="d-block w-100" alt="...">
      <div class="carousel-caption d-none d-md-block">
        <h5>First slide label</h5>
        <p>Some representative placeholder content for the first slide.</p>
      </div>
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
      <div class="carousel-caption d-none d-md-block">
        <h5>Second slide label</h5>
        <p>Some representative placeholder content for the second slide.</p>
      </div>
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
      <div class="carousel-caption d-none d-md-block">
        <h5>Third slide label</h5>
        <p>Some representative placeholder content for the third slide.</p>
      </div>
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>
```

### Crossfade

Add `.carousel-fade` to your carousel to animate slides with a fade transition instead of a slide. Depending on your carousel content (e.g., text only slides), you may want to add `.bg-body` or some custom CSS to the `.carousel-item`s for proper crossfading.

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
     &lt;div class=&quot;carousel slide carousel-fade&quot; id=&quot;carouselExampleFade&quot;&gt;
&lt;div class=&quot;carousel-inner&quot;&gt;
&lt;div class=&quot;carousel-item active&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: First slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#777&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#555&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;First slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Second slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#666&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#444&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Second slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Third slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#555&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#333&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Third slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;button class=&quot;carousel-control-prev&quot; data-bs-slide=&quot;prev&quot; data-bs-target=&quot;#carouselExampleFade&quot; type=&quot;button&quot;&gt;
&lt;span aria-hidden=&quot;true&quot; class=&quot;carousel-control-prev-icon&quot;&gt;&lt;/span&gt;
&lt;span class=&quot;visually-hidden&quot;&gt;Previous&lt;/span&gt;
&lt;/button&gt;
&lt;button class=&quot;carousel-control-next&quot; data-bs-slide=&quot;next&quot; data-bs-target=&quot;#carouselExampleFade&quot; type=&quot;button&quot;&gt;
&lt;span aria-hidden=&quot;true&quot; class=&quot;carousel-control-next-icon&quot;&gt;&lt;/span&gt;
&lt;span class=&quot;visually-hidden&quot;&gt;Next&lt;/span&gt;
&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div id="carouselExampleFade" class="carousel slide carousel-fade">
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="..." class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleFade" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleFade" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>
```

## Autoplaying carousels

You can make your carousels autoplay on page load by setting the `ride` option to `carousel`. Autoplaying carousels automatically pause while hovered with the mouse. This behavior can be controlled with the `pause` option. In browsers that support the [Page Visibility API](https://www.w3.org/TR/page-visibility/), the carousel will stop cycling when the webpage is not visible to the user (such as when the browser tab is inactive, or when the browser window is minimized).

For accessibility reasons, we recommend avoiding the use of autoplaying carousels. If your page does include an autoplaying carousel, we recommend providing an additional button or control to explicitly pause/stop the carousel.

See [WCAG 2.2 Success Criterion 2.2.2 Pause, Stop, Hide](https://www.w3.org/TR/WCAG/#pause-stop-hide).

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
     &lt;div class=&quot;carousel slide&quot; data-bs-ride=&quot;carousel&quot; id=&quot;carouselExampleAutoplaying&quot;&gt;
&lt;div class=&quot;carousel-inner&quot;&gt;
&lt;div class=&quot;carousel-item active&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: First slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#777&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#555&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;First slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Second slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#666&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#444&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Second slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Third slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#555&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#333&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Third slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;button class=&quot;carousel-control-prev&quot; data-bs-slide=&quot;prev&quot; data-bs-target=&quot;#carouselExampleAutoplaying&quot; type=&quot;button&quot;&gt;
&lt;span aria-hidden=&quot;true&quot; class=&quot;carousel-control-prev-icon&quot;&gt;&lt;/span&gt;
&lt;span class=&quot;visually-hidden&quot;&gt;Previous&lt;/span&gt;
&lt;/button&gt;
&lt;button class=&quot;carousel-control-next&quot; data-bs-slide=&quot;next&quot; data-bs-target=&quot;#carouselExampleAutoplaying&quot; type=&quot;button&quot;&gt;
&lt;span aria-hidden=&quot;true&quot; class=&quot;carousel-control-next-icon&quot;&gt;&lt;/span&gt;
&lt;span class=&quot;visually-hidden&quot;&gt;Next&lt;/span&gt;
&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div id="carouselExampleAutoplaying" class="carousel slide" data-bs-ride="carousel">
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="..." class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleAutoplaying" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleAutoplaying" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>
```

When the `ride` option is set to `true`, rather than `carousel`, the carousel won’t automatically start to cycle on page load. Instead, it will only start after the first user interaction.

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
     &lt;div class=&quot;carousel slide&quot; data-bs-ride=&quot;true&quot; id=&quot;carouselExampleRide&quot;&gt;
&lt;div class=&quot;carousel-inner&quot;&gt;
&lt;div class=&quot;carousel-item active&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: First slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#777&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#555&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;First slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Second slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#666&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#444&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Second slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Third slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#555&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#333&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Third slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;button class=&quot;carousel-control-prev&quot; data-bs-slide=&quot;prev&quot; data-bs-target=&quot;#carouselExampleRide&quot; type=&quot;button&quot;&gt;
&lt;span aria-hidden=&quot;true&quot; class=&quot;carousel-control-prev-icon&quot;&gt;&lt;/span&gt;
&lt;span class=&quot;visually-hidden&quot;&gt;Previous&lt;/span&gt;
&lt;/button&gt;
&lt;button class=&quot;carousel-control-next&quot; data-bs-slide=&quot;next&quot; data-bs-target=&quot;#carouselExampleRide&quot; type=&quot;button&quot;&gt;
&lt;span aria-hidden=&quot;true&quot; class=&quot;carousel-control-next-icon&quot;&gt;&lt;/span&gt;
&lt;span class=&quot;visually-hidden&quot;&gt;Next&lt;/span&gt;
&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div id="carouselExampleRide" class="carousel slide" data-bs-ride="true">
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="..." class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleRide" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleRide" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>
```

### Individual `.carousel-item` interval

Add `data-bs-interval=""` to a `.carousel-item` to change the amount of time to delay between automatically cycling to the next item.

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
     &lt;div class=&quot;carousel slide&quot; data-bs-ride=&quot;carousel&quot; id=&quot;carouselExampleInterval&quot;&gt;
&lt;div class=&quot;carousel-inner&quot;&gt;
&lt;div class=&quot;carousel-item active&quot; data-bs-interval=&quot;10000&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: First slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#777&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#555&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;First slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot; data-bs-interval=&quot;2000&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Second slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#666&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#444&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Second slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Third slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#555&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#333&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Third slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;button class=&quot;carousel-control-prev&quot; data-bs-slide=&quot;prev&quot; data-bs-target=&quot;#carouselExampleInterval&quot; type=&quot;button&quot;&gt;
&lt;span aria-hidden=&quot;true&quot; class=&quot;carousel-control-prev-icon&quot;&gt;&lt;/span&gt;
&lt;span class=&quot;visually-hidden&quot;&gt;Previous&lt;/span&gt;
&lt;/button&gt;
&lt;button class=&quot;carousel-control-next&quot; data-bs-slide=&quot;next&quot; data-bs-target=&quot;#carouselExampleInterval&quot; type=&quot;button&quot;&gt;
&lt;span aria-hidden=&quot;true&quot; class=&quot;carousel-control-next-icon&quot;&gt;&lt;/span&gt;
&lt;span class=&quot;visually-hidden&quot;&gt;Next&lt;/span&gt;
&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div id="carouselExampleInterval" class="carousel slide" data-bs-ride="carousel">
  <div class="carousel-inner">
    <div class="carousel-item active" data-bs-interval="10000">
      <img src="..." class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item" data-bs-interval="2000">
      <img src="..." class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleInterval" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleInterval" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>
```

### Autoplaying carousels without controls

Here’s a carousel with slides only. Note the presence of the `.d-block` and `.w-100` on carousel images to prevent browser default image alignment.

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
     &lt;div class=&quot;carousel slide&quot; data-bs-ride=&quot;carousel&quot; id=&quot;carouselExampleSlidesOnly&quot;&gt;
&lt;div class=&quot;carousel-inner&quot;&gt;
&lt;div class=&quot;carousel-item active&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: First slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#777&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#555&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;First slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Second slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#666&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#444&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Second slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Third slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#555&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#333&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Third slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div id="carouselExampleSlidesOnly" class="carousel slide" data-bs-ride="carousel">
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="..." class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
    </div>
  </div>
</div>
```

## Disable touch swiping

Carousels support swiping left/right on touchscreen devices to move between slides. This can be disabled by setting the `touch` option to `false`.

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
     &lt;div class=&quot;carousel slide&quot; data-bs-touch=&quot;false&quot; id=&quot;carouselExampleControlsNoTouching&quot;&gt;
&lt;div class=&quot;carousel-inner&quot;&gt;
&lt;div class=&quot;carousel-item active&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: First slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#777&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#555&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;First slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Second slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#666&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#444&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Second slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Third slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#555&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#333&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Third slide&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;button class=&quot;carousel-control-prev&quot; data-bs-slide=&quot;prev&quot; data-bs-target=&quot;#carouselExampleControlsNoTouching&quot; type=&quot;button&quot;&gt;
&lt;span aria-hidden=&quot;true&quot; class=&quot;carousel-control-prev-icon&quot;&gt;&lt;/span&gt;
&lt;span class=&quot;visually-hidden&quot;&gt;Previous&lt;/span&gt;
&lt;/button&gt;
&lt;button class=&quot;carousel-control-next&quot; data-bs-slide=&quot;next&quot; data-bs-target=&quot;#carouselExampleControlsNoTouching&quot; type=&quot;button&quot;&gt;
&lt;span aria-hidden=&quot;true&quot; class=&quot;carousel-control-next-icon&quot;&gt;&lt;/span&gt;
&lt;span class=&quot;visually-hidden&quot;&gt;Next&lt;/span&gt;
&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div id="carouselExampleControlsNoTouching" class="carousel slide" data-bs-touch="false">
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="..." class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleControlsNoTouching" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleControlsNoTouching" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>
```

## Dark variant

Deprecated in v5.3.0 

Add `.carousel-dark` to the `.carousel` for darker controls, indicators, and captions. Controls are inverted compared to their default white fill with the `filter` CSS property. Captions and controls have additional Sass variables that customize the `color` and `background-color`.

**Heads up!** Dark variants for components were deprecated in v5.3.0 with the introduction of color modes.
Instead of adding `.carousel-dark`, set `data-bs-theme="dark"` on the root element, a parent
wrapper, or the component itself.

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
     &lt;div class=&quot;carousel carousel-dark slide&quot; id=&quot;carouselExampleDark&quot;&gt;
&lt;div class=&quot;carousel-indicators&quot;&gt;
&lt;button aria-current=&quot;true&quot; aria-label=&quot;Slide 1&quot; class=&quot;active&quot; data-bs-slide-to=&quot;0&quot; data-bs-target=&quot;#carouselExampleDark&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;button aria-label=&quot;Slide 2&quot; data-bs-slide-to=&quot;1&quot; data-bs-target=&quot;#carouselExampleDark&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;button aria-label=&quot;Slide 3&quot; data-bs-slide-to=&quot;2&quot; data-bs-target=&quot;#carouselExampleDark&quot; type=&quot;button&quot;&gt;&lt;/button&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-inner&quot;&gt;
&lt;div class=&quot;carousel-item active&quot; data-bs-interval=&quot;10000&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: First slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#f5f5f5&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#aaa&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;First slide&lt;/text&gt;&lt;/svg&gt;
&lt;div class=&quot;carousel-caption d-none d-md-block&quot;&gt;
&lt;h5&gt;First slide label&lt;/h5&gt;
&lt;p&gt;Some representative placeholder content for the first slide.&lt;/p&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot; data-bs-interval=&quot;2000&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Second slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#eee&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#bbb&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Second slide&lt;/text&gt;&lt;/svg&gt;
&lt;div class=&quot;carousel-caption d-none d-md-block&quot;&gt;
&lt;h5&gt;Second slide label&lt;/h5&gt;
&lt;p&gt;Some representative placeholder content for the second slide.&lt;/p&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;carousel-item&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: Third slide&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg d-block w-100&quot; height=&quot;400&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;800&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#e5e5e5&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#999&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Third slide&lt;/text&gt;&lt;/svg&gt;
&lt;div class=&quot;carousel-caption d-none d-md-block&quot;&gt;
&lt;h5&gt;Third slide label&lt;/h5&gt;
&lt;p&gt;Some representative placeholder content for the third slide.&lt;/p&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;button class=&quot;carousel-control-prev&quot; data-bs-slide=&quot;prev&quot; data-bs-target=&quot;#carouselExampleDark&quot; type=&quot;button&quot;&gt;
&lt;span aria-hidden=&quot;true&quot; class=&quot;carousel-control-prev-icon&quot;&gt;&lt;/span&gt;
&lt;span class=&quot;visually-hidden&quot;&gt;Previous&lt;/span&gt;
&lt;/button&gt;
&lt;button class=&quot;carousel-control-next&quot; data-bs-slide=&quot;next&quot; data-bs-target=&quot;#carouselExampleDark&quot; type=&quot;button&quot;&gt;
&lt;span aria-hidden=&quot;true&quot; class=&quot;carousel-control-next-icon&quot;&gt;&lt;/span&gt;
&lt;span class=&quot;visually-hidden&quot;&gt;Next&lt;/span&gt;
&lt;/button&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div id="carouselExampleDark" class="carousel carousel-dark slide">
  <div class="carousel-indicators">
    <button type="button" data-bs-target="#carouselExampleDark" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
    <button type="button" data-bs-target="#carouselExampleDark" data-bs-slide-to="1" aria-label="Slide 2"></button>
    <button type="button" data-bs-target="#carouselExampleDark" data-bs-slide-to="2" aria-label="Slide 3"></button>
  </div>
  <div class="carousel-inner">
    <div class="carousel-item active" data-bs-interval="10000">
      <img src="..." class="d-block w-100" alt="...">
      <div class="carousel-caption d-none d-md-block">
        <h5>First slide label</h5>
        <p>Some representative placeholder content for the first slide.</p>
      </div>
    </div>
    <div class="carousel-item" data-bs-interval="2000">
      <img src="..." class="d-block w-100" alt="...">
      <div class="carousel-caption d-none d-md-block">
        <h5>Second slide label</h5>
        <p>Some representative placeholder content for the second slide.</p>
      </div>
    </div>
    <div class="carousel-item">
      <img src="..." class="d-block w-100" alt="...">
      <div class="carousel-caption d-none d-md-block">
        <h5>Third slide label</h5>
        <p>Some representative placeholder content for the third slide.</p>
      </div>
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleDark" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleDark" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>
```

## Custom transition

The transition duration of `.carousel-item` can be changed with the `$carousel-transition-duration` Sass variable before compiling or custom styles if you’re using the compiled CSS. If multiple transitions are applied, make sure the transform transition is defined first (e.g. `transition: transform 2s ease, opacity .5s ease-out`).

## CSS

### Sass variables

Variables for all carousels:

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$carousel-control-color:             $white;
$carousel-control-width:             15%;
$carousel-control-opacity:           .5;
$carousel-control-hover-opacity:     .9;
$carousel-control-transition:        opacity .15s ease;
$carousel-control-icon-filter:       null;

$carousel-indicator-width:           30px;
$carousel-indicator-height:          3px;
$carousel-indicator-hit-area-height: 10px;
$carousel-indicator-spacer:          3px;
$carousel-indicator-opacity:         .5;
$carousel-indicator-active-bg:       $white;
$carousel-indicator-active-opacity:  1;
$carousel-indicator-transition:      opacity .6s ease;

$carousel-caption-width:             70%;
$carousel-caption-color:             $white;
$carousel-caption-padding-y:         1.25rem;
$carousel-caption-spacer:            1.25rem;

$carousel-control-icon-width:        2rem;

$carousel-control-prev-icon-bg:      url("data:image/svg+xml,<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 16 16' fill='#{$carousel-control-color}'><path d='M11.354 1.646a.5.5 0 0 1 0 .708L5.707 8l5.647 5.646a.5.5 0 0 1-.708.708l-6-6a.5.5 0 0 1 0-.708l6-6a.5.5 0 0 1 .708 0'/></svg>");
$carousel-control-next-icon-bg:      url("data:image/svg+xml,<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 16 16' fill='#{$carousel-control-color}'><path d='M4.646 1.646a.5.5 0 0 1 .708 0l6 6a.5.5 0 0 1 0 .708l-6 6a.5.5 0 0 1-.708-.708L10.293 8 4.646 2.354a.5.5 0 0 1 0-.708'/></svg>");

$carousel-transition-duration:       .6s;
$carousel-transition:                transform $carousel-transition-duration ease-in-out; // Define transform transition first if using multiple transitions (e.g., `transform 2s ease, opacity .5s ease-out`)
```

Variables for the [dark carousel](#dark-variant):

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$carousel-dark-indicator-active-bg:  $black; // Deprecated in v5.3.4
$carousel-dark-caption-color:        $black; // Deprecated in v5.3.4
$carousel-dark-control-icon-filter:  invert(1) grayscale(100); // Deprecated in v5.3.4
```

## Usage

### Via data attributes

Use data attributes to easily control the position of the carousel. `data-bs-slide` accepts the keywords `prev` or `next`, which alters the slide position relative to its current position. Alternatively, use `data-bs-slide-to` to pass a raw slide index to the carousel `data-bs-slide-to="2"`, which shifts the slide position to a particular index beginning with `0`.

### Via JavaScript

Call carousel manually with:

```html
const carousel = new bootstrap.Carousel('#myCarousel')
```

### Options

As options can be passed via data attributes or JavaScript, you can append an option name to `data-bs-`, as in `data-bs-animation="{value}"`. Make sure to change the case type of the option name from “*camelCase*” to “*kebab-case*” when passing the options via data attributes. For example, use `data-bs-custom-class="beautifier"` instead of `data-bs-customClass="beautifier"`.

As of Bootstrap 5.2.0, all components support an **experimental** reserved data attribute `data-bs-config` that can house simple component configuration as a JSON string. When an element has `data-bs-config='{"delay":0, "title":123}'` and `data-bs-title="456"` attributes, the final `title` value will be `456` and the separate data attributes will override values given on `data-bs-config`. In addition, existing data attributes are able to house JSON values like `data-bs-delay='{"show":0,"hide":150}'`.

The final configuration object is the merged result of `data-bs-config`, `data-bs-`, and `js object` where the latest given key-value overrides the others.

| Name | Type | Default | Description |
| --- | --- | --- | --- |
| `interval` | number | `5000` | The amount of time to delay between automatically cycling an item. |
| `keyboard` | boolean | `true` | Whether the carousel should react to keyboard events. |
| `pause` | string, boolean | `"hover"` | If set to `"hover"`, pauses the cycling of the carousel on `mouseenter` and resumes the cycling of the carousel on `mouseleave`. If set to `false`, hovering over the carousel won’t pause it. On touch-enabled devices, when set to `"hover"`, cycling will pause on `touchend` (once the user finished interacting with the carousel) for two intervals, before automatically resuming. This is in addition to the mouse behavior. |
| `ride` | string, boolean | `false` | If set to `true`, autoplays the carousel after the user manually cycles the first item. If set to `"carousel"`, autoplays the carousel on load. |
| `touch` | boolean | `true` | Whether the carousel should support left/right swipe interactions on touchscreen devices. |
| `wrap` | boolean | `true` | Whether the carousel should cycle continuously or have hard stops. |

### Methods

**All API methods are asynchronous and start a transition.** They return to the caller as soon as the transition is started, but before it ends. In addition, a method call on a transitioning component will be ignored. [Learn more in our JavaScript docs.](/docs/5.3/getting-started/javascript/#asynchronous-functions-and-transitions)

You can create a carousel instance with the carousel constructor, and pass on any additional options. For example, to manually initialize an autoplaying carousel (assuming you’re not using the `data-bs-ride="carousel"` attribute in the markup itself) with a specific interval and with touch support disabled, you can use:

```html
const myCarouselElement = document.querySelector('#myCarousel')

const carousel = new bootstrap.Carousel(myCarouselElement, {
  interval: 2000,
  touch: false
})
```

| Method | Description |
| --- | --- |
| `cycle` | Starts cycling through the carousel items from left to right. |
| `dispose` | Destroys an element’s carousel. (Removes stored data on the DOM element) |
| `getInstance` | Static method which allows you to get the carousel instance associated to a DOM element. You can use it like this: `bootstrap.Carousel.getInstance(element)`. |
| `getOrCreateInstance` | Static method which returns a carousel instance associated to a DOM element, or creates a new one in case it wasn’t initialized. You can use it like this: `bootstrap.Carousel.getOrCreateInstance(element)`. |
| `next` | Cycles to the next item. **Returns to the caller before the next item has been shown** (e.g., before the `slid.bs.carousel` event occurs). |
| `nextWhenVisible` | Don’t cycle carousel to next when the page, the carousel, or the carousel’s parent aren’t visible. **Returns to the caller before the target item has been shown**. |
| `pause` | Stops the carousel from cycling through items. |
| `prev` | Cycles to the previous item. **Returns to the caller before the previous item has been shown** (e.g., before the `slid.bs.carousel` event occurs). |
| `to` | Cycles the carousel to a particular frame (0 based, similar to an array). **Returns to the caller before the target item has been shown** (e.g., before the `slid.bs.carousel` event occurs). |

### Events

Bootstrap’s carousel class exposes two events for hooking into carousel functionality. Both events have the following additional properties:

* `direction`: The direction in which the carousel is sliding (either `"left"` or `"right"`).
* `relatedTarget`: The DOM element that is being slid into place as the active item.
* `from`: The index of the current item
* `to`: The index of the next item

All carousel events are fired at the carousel itself (i.e. at the `<div class="carousel">`).

| Event type | Description |
| --- | --- |
| `slid.bs.carousel` | Fired when the carousel has completed its slide transition. |
| `slide.bs.carousel` | Fires immediately when the `slide` instance method is invoked. |

```html
const myCarousel = document.getElementById('myCarousel')

myCarousel.addEventListener('slide.bs.carousel', event => {
  // do something...
})
```

