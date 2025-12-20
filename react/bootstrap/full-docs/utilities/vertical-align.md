> Źródło: [https://getbootstrap.com/docs/5.3/utilities/vertical-align](https://getbootstrap.com/docs/5.3/utilities/vertical-align)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/utilities/vertical-align.mdx "View and edit this file on GitHub")

# Vertical alignment

Easily change the vertical alignment of inline, inline-block, inline-table, and table cell elements.

Change the alignment of elements with the [`vertical-alignment`](https://developer.mozilla.org/en-US/docs/Web/CSS/vertical-align) utilities. Please note that vertical-align only affects inline, inline-block, inline-table, and table cell elements.

Choose from `.align-baseline`, `.align-top`, `.align-middle`, `.align-bottom`, `.align-text-bottom`, and `.align-text-top` as needed.

To vertically center non-inline content (like `<div>`s and more), use our [flex box utilities](/docs/5.3/utilities/flex#align-items).

With inline elements:

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
     &lt;span class=&quot;align-baseline&quot;&gt;baseline&lt;/span&gt;
&lt;span class=&quot;align-top&quot;&gt;top&lt;/span&gt;
&lt;span class=&quot;align-middle&quot;&gt;middle&lt;/span&gt;
&lt;span class=&quot;align-bottom&quot;&gt;bottom&lt;/span&gt;
&lt;span class=&quot;align-text-top&quot;&gt;text-top&lt;/span&gt;
&lt;span class=&quot;align-text-bottom&quot;&gt;text-bottom&lt;/span&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<span class="align-baseline">baseline</span>
<span class="align-top">top</span>
<span class="align-middle">middle</span>
<span class="align-bottom">bottom</span>
<span class="align-text-top">text-top</span>
<span class="align-text-bottom">text-bottom</span>
```

With table cells:

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
     &lt;table style=&quot;height: 100px;&quot;&gt;
&lt;tbody&gt;
&lt;tr&gt;
&lt;td class=&quot;align-baseline&quot;&gt;baseline&lt;/td&gt;
&lt;td class=&quot;align-top&quot;&gt;top&lt;/td&gt;
&lt;td class=&quot;align-middle&quot;&gt;middle&lt;/td&gt;
&lt;td class=&quot;align-bottom&quot;&gt;bottom&lt;/td&gt;
&lt;td class=&quot;align-text-top&quot;&gt;text-top&lt;/td&gt;
&lt;td class=&quot;align-text-bottom&quot;&gt;text-bottom&lt;/td&gt;
&lt;/tr&gt;
&lt;/tbody&gt;
&lt;/table&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<table style="height: 100px;">
  <tbody>
    <tr>
      <td class="align-baseline">baseline</td>
      <td class="align-top">top</td>
      <td class="align-middle">middle</td>
      <td class="align-bottom">bottom</td>
      <td class="align-text-top">text-top</td>
      <td class="align-text-bottom">text-bottom</td>
    </tr>
  </tbody>
</table>
```

## CSS

### Sass utilities API

Vertical align utilities are declared in our utilities API in `scss/_utilities.scss`. [Learn how to use the utilities API.](/docs/5.3/utilities/api#using-the-api)

[scss/\_utilities.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_utilities.scss)

```html
"align": (
  property: vertical-align,
  class: align,
  values: baseline top middle bottom text-bottom text-top
),
```

