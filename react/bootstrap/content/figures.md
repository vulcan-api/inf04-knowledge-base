Powrót -> [Start](./root.md)

> Źródło: [https://getbootstrap.com/docs/5.3/content/figures](https://getbootstrap.com/docs/5.3/content/figures)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/content/figures.mdx "View and edit this file on GitHub")

# Figures

Dokumentacja oraz przykłady dotyczące wyświetlania powiązanych obrazów i tekstu za pomocą komponentu **figure** w Bootstrapie.

## Na tej stronie

- [CSS](#css)
  - [Zmienne Sass](#zmienne-sass)

---

Zawsze gdy potrzebujesz wyświetlić fragment treści — na przykład obraz z opcjonalnym podpisem — rozważ użycie elementu `<figure>`.

Użyj dołączonych klas `.figure`, `.figure-img` oraz `.figure-caption`, aby zapewnić podstawowe style dla elementów HTML5 `<figure>` i `<figcaption>`. Obrazy wewnątrz figur nie mają jawnie określonego rozmiaru, dlatego pamiętaj, aby dodać klasę `.img-fluid` do elementu `<img>`, aby był responsywny.

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
     &lt;figure class=&quot;figure&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: 400x300&quot; class=&quot;bd-placeholder-img figure-img img-fluid rounded&quot; height=&quot;300&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;400&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#868e96&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#dee2e6&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;400x300&lt;/text&gt;&lt;/svg&gt;
&lt;figcaption class=&quot;figure-caption&quot;&gt;A caption for the above image.&lt;/figcaption&gt;
&lt;/figure&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<figure class="figure">
  <img src="..." class="figure-img img-fluid rounded" alt="...">
  <figcaption class="figure-caption">A caption for the above image.</figcaption>
</figure>
```
> **Komentarz:** Klasa `.img-fluid` sprawia, że obraz skaluje się wraz z szerokością kontenera, a `.rounded` dodaje zaokrąglone rogi.

---

Wyrównanie podpisu figury jest bardzo proste dzięki naszym [narzędziom do formatowania tekstu](/docs/5.3/utilities/text#text-alignment).

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
     &lt;figure class=&quot;figure&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: 400x300&quot; class=&quot;bd-placeholder-img figure-img img-fluid rounded&quot; height=&quot;300&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;400&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#868e96&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#dee2e6&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;400x300&lt;/text&gt;&lt;/svg&gt;
&lt;figcaption class=&quot;figure-caption text-end&quot;&gt;A caption for the above image.&lt;/figcaption&gt;
&lt;/figure&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<figure class="figure">
  <img src="..." class="figure-img img-fluid rounded" alt="...">
  <figcaption class="figure-caption text-end">A caption for the above image.</figcaption>
</figure>
```

## CSS

### Zmienne Sass

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$figure-caption-font-size:          $small-font-size;
$figure-caption-color:              var(--#{$prefix}secondary-color);
```

> **Wyjaśnienie:**
> - `$figure-caption-font-size` określa rozmiar czcionki podpisu figury i domyślnie korzysta z mniejszego rozmiaru tekstu.
> - `$figure-caption-color` ustawia kolor podpisu na pomocniczy kolor motywu Bootstrapa (secondary color).



