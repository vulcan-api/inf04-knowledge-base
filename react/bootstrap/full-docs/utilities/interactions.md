> Źródło: [https://getbootstrap.com/docs/5.3/utilities/interactions](https://getbootstrap.com/docs/5.3/utilities/interactions)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/utilities/interactions.mdx "View and edit this file on GitHub")

# Interactions

Utility classes that change how users interact with contents of a website.

## Text selection

Change the way in which the content is selected when the user interacts with it.

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
     &lt;p class=&quot;user-select-all&quot;&gt;This paragraph will be entirely selected when clicked by the user.&lt;/p&gt;
&lt;p class=&quot;user-select-auto&quot;&gt;This paragraph has default select behavior.&lt;/p&gt;
&lt;p class=&quot;user-select-none&quot;&gt;This paragraph will not be selectable when clicked by the user.&lt;/p&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<p class="user-select-all">This paragraph will be entirely selected when clicked by the user.</p>
<p class="user-select-auto">This paragraph has default select behavior.</p>
<p class="user-select-none">This paragraph will not be selectable when clicked by the user.</p>
```

## Pointer events

Bootstrap provides `.pe-none` and `.pe-auto` classes to prevent or add element interactions.

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
     &lt;p&gt;&lt;a aria-disabled=&quot;true&quot; class=&quot;pe-none&quot; href=&quot;#&quot; tabindex=&quot;-1&quot;&gt;This link&lt;/a&gt; can not be clicked.&lt;/p&gt;
&lt;p&gt;&lt;a class=&quot;pe-auto&quot; href=&quot;#&quot;&gt;This link&lt;/a&gt; can be clicked (this is default behavior).&lt;/p&gt;
&lt;p class=&quot;pe-none&quot;&gt;&lt;a aria-disabled=&quot;true&quot; href=&quot;#&quot; tabindex=&quot;-1&quot;&gt;This link&lt;/a&gt; can not be clicked because the &lt;code&gt;pointer-events&lt;/code&gt; property is inherited from its parent. However, &lt;a class=&quot;pe-auto&quot; href=&quot;#&quot;&gt;this link&lt;/a&gt; has a &lt;code&gt;pe-auto&lt;/code&gt; class and can be clicked.&lt;/p&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<p><a href="#" class="pe-none" tabindex="-1" aria-disabled="true">This link</a> can not be clicked.</p>
<p><a href="#" class="pe-auto">This link</a> can be clicked (this is default behavior).</p>
<p class="pe-none"><a href="#" tabindex="-1" aria-disabled="true">This link</a> can not be clicked because the <code>pointer-events</code> property is inherited from its parent. However, <a href="#" class="pe-auto">this link</a> has a <code>pe-auto</code> class and can be clicked.</p>
```

The `.pe-none` class (and the `pointer-events` CSS property it sets) only prevents interactions with a pointer (mouse, stylus, touch). Links and controls with `.pe-none` are, by default, still focusable and actionable for keyboard users. To ensure that they are completely neutralized even for keyboard users, you may need to add further attributes such as `tabindex="-1"` (to prevent them from receiving keyboard focus) and `aria-disabled="true"` (to convey the fact they are effectively disabled to assistive technologies), and possibly use JavaScript to completely prevent them from being actionable.

If possible, the simpler solution is:

* For form controls, add the `disabled` HTML attribute.
* For links, remove the `href` attribute, making it a non-interactive anchor or placeholder link.

## CSS

### Sass utilities API

Interaction utilities are declared in our utilities API in `scss/_utilities.scss`. [Learn how to use the utilities API.](/docs/5.3/utilities/api#using-the-api)

[scss/\_utilities.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_utilities.scss)

```html
"user-select": (
  property: user-select,
  values: all auto none
),
"pointer-events": (
  property: pointer-events,
  class: pe,
  values: none auto,
),
```

