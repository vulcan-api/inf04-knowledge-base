> Źródło: [https://getbootstrap.com/docs/5.3/helpers/colored-links](https://getbootstrap.com/docs/5.3/helpers/colored-links)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/helpers/colored-links.mdx "View and edit this file on GitHub")

# Colored links

Colored links with hover states

On this page
   
**On this page**

---

* [Link colors](#link-colors)
* [Link utilities](#link-utilities)

## Link colors

You can use the `.link-*` classes to colorize links. Unlike the [`.text-*` classes](/docs/5.3/utilities/colors), these classes have a `:hover` and `:focus` state. Some of the link styles use a relatively light foreground color, and should only be used on a dark background in order to have sufficient contrast.

**Heads up!** `.link-body-emphasis` is currently the only colored link that adapts to color modes. It’s treated as a special case until v6 arrives and we can more thoroughly rebuild our theme colors for color modes. Until then, it’s a unique, high-contrast link color with custom `:hover` and `:focus` styles. However, it still responds to the new link utilities.

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
     &lt;p&gt;&lt;a class=&quot;link-primary&quot; href=&quot;#&quot;&gt;Primary link&lt;/a&gt;&lt;/p&gt;
&lt;p&gt;&lt;a class=&quot;link-secondary&quot; href=&quot;#&quot;&gt;Secondary link&lt;/a&gt;&lt;/p&gt;
&lt;p&gt;&lt;a class=&quot;link-success&quot; href=&quot;#&quot;&gt;Success link&lt;/a&gt;&lt;/p&gt;
&lt;p&gt;&lt;a class=&quot;link-danger&quot; href=&quot;#&quot;&gt;Danger link&lt;/a&gt;&lt;/p&gt;
&lt;p&gt;&lt;a class=&quot;link-warning&quot; href=&quot;#&quot;&gt;Warning link&lt;/a&gt;&lt;/p&gt;
&lt;p&gt;&lt;a class=&quot;link-info&quot; href=&quot;#&quot;&gt;Info link&lt;/a&gt;&lt;/p&gt;
&lt;p&gt;&lt;a class=&quot;link-light&quot; href=&quot;#&quot;&gt;Light link&lt;/a&gt;&lt;/p&gt;
&lt;p&gt;&lt;a class=&quot;link-dark&quot; href=&quot;#&quot;&gt;Dark link&lt;/a&gt;&lt;/p&gt;
&lt;p&gt;&lt;a class=&quot;link-body-emphasis&quot; href=&quot;#&quot;&gt;Emphasis link&lt;/a&gt;&lt;/p&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<p><a href="#" class="link-primary">Primary link</a></p>
<p><a href="#" class="link-secondary">Secondary link</a></p>
<p><a href="#" class="link-success">Success link</a></p>
<p><a href="#" class="link-danger">Danger link</a></p>
<p><a href="#" class="link-warning">Warning link</a></p>
<p><a href="#" class="link-info">Info link</a></p>
<p><a href="#" class="link-light">Light link</a></p>
<p><a href="#" class="link-dark">Dark link</a></p>
<p><a href="#" class="link-body-emphasis">Emphasis link</a></p>
```

**Accessibility tip:** Using color to add meaning only provides a visual indication, which will not be conveyed to users of assistive technologies like screen readers. Please ensure the meaning is obvious from the content itself (e.g., the visible text with a [*sufficient* color contrast](/docs/5.3/getting-started/accessibility/#color-contrast)) or is included through alternative means, such as additional text hidden with the `.visually-hidden` class.

## Link utilities

Added in v5.3.0

Colored links can also be modified by our [link utilities](/docs/5.3/utilities/link/).

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
     &lt;p&gt;&lt;a class=&quot;link-primary link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover&quot; href=&quot;#&quot;&gt;Primary link&lt;/a&gt;&lt;/p&gt;
&lt;p&gt;&lt;a class=&quot;link-secondary link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover&quot; href=&quot;#&quot;&gt;Secondary link&lt;/a&gt;&lt;/p&gt;
&lt;p&gt;&lt;a class=&quot;link-success link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover&quot; href=&quot;#&quot;&gt;Success link&lt;/a&gt;&lt;/p&gt;
&lt;p&gt;&lt;a class=&quot;link-danger link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover&quot; href=&quot;#&quot;&gt;Danger link&lt;/a&gt;&lt;/p&gt;
&lt;p&gt;&lt;a class=&quot;link-warning link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover&quot; href=&quot;#&quot;&gt;Warning link&lt;/a&gt;&lt;/p&gt;
&lt;p&gt;&lt;a class=&quot;link-info link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover&quot; href=&quot;#&quot;&gt;Info link&lt;/a&gt;&lt;/p&gt;
&lt;p&gt;&lt;a class=&quot;link-light link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover&quot; href=&quot;#&quot;&gt;Light link&lt;/a&gt;&lt;/p&gt;
&lt;p&gt;&lt;a class=&quot;link-dark link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover&quot; href=&quot;#&quot;&gt;Dark link&lt;/a&gt;&lt;/p&gt;
&lt;p&gt;&lt;a class=&quot;link-body-emphasis link-offset-2 link-underline-opacity-25 link-underline-opacity-75-hover&quot; href=&quot;#&quot;&gt;Emphasis link&lt;/a&gt;&lt;/p&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<p><a href="#" class="link-primary link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover">Primary link</a></p>
<p><a href="#" class="link-secondary link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover">Secondary link</a></p>
<p><a href="#" class="link-success link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover">Success link</a></p>
<p><a href="#" class="link-danger link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover">Danger link</a></p>
<p><a href="#" class="link-warning link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover">Warning link</a></p>
<p><a href="#" class="link-info link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover">Info link</a></p>
<p><a href="#" class="link-light link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover">Light link</a></p>
<p><a href="#" class="link-dark link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover">Dark link</a></p>
<p><a href="#" class="link-body-emphasis link-offset-2 link-underline-opacity-25 link-underline-opacity-75-hover">Emphasis link</a></p>
```

