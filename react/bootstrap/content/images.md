Powrót -> [Start](./root.md)

> Źródło: [https://getbootstrap.com/docs/5.3/content/images](https://getbootstrap.com/docs/5.3/content/images)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/content/images.mdx "View and edit this file on GitHub")

# Obrazy

Dokumentacja oraz przykłady pokazujące, jak włączyć responsywne zachowanie obrazów (tak, aby nigdy nie były szersze niż ich element nadrzędny) oraz jak dodać do nich lekkie style — wszystko za pomocą klas.

## Na tej stronie

---

* [Responsywne obrazy](#responsywne-obrazy)
* [Miniatury obrazów](#miniatury-obrazów)
* [Wyrównywanie obrazów](#wyrównywanie-obrazów)
* [Picture](#picture)
* [CSS](#css)
  + [Zmienne Sass](#zmienne-sass)

## Responsywne obrazy

Obrazy w Bootstrap są responsywne dzięki klasie `.img-fluid`. Klasa ta ustawia `max-width: 100%;` oraz `height: auto;` na obrazie, dzięki czemu skaluje się on wraz z szerokością elementu nadrzędnego.
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
     &lt;svg aria-label=&quot;Placeholder: Responsive image&quot; class=&quot;bd-placeholder-img bd-placeholder-img-lg img-fluid&quot; height=&quot;250&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;100%&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#868e96&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#dee2e6&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;Responsive image&lt;/text&gt;&lt;/svg&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<img src="..." class="img-fluid" alt="...">
```

## Miniatury obrazów

Oprócz  [narzędzi do zaokrąglania obramowania](/docs/5.3/utilities/borders)(border-radius), możesz użyć klasy `.img-thumbnail`, aby nadać obrazowi wygląd miniatury z zaokrąglonym obramowaniem o grubości 1px.

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
     &lt;svg aria-label=&quot;A generic square placeholder image with a white border around it, making it resemble a photograph taken with an old instant camera: 200x200&quot; class=&quot;bd-placeholder-img img-thumbnail&quot; height=&quot;200&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;200&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;A generic square placeholder image with a white border around it, making it resemble a photograph taken with an old instant camera&lt;/title&gt;&lt;rect fill=&quot;#868e96&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#dee2e6&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;200x200&lt;/text&gt;&lt;/svg&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<img src="..." class="img-thumbnail" alt="...">
```

## Aligning images

Obrazy można wyrównywać za pomocą [klas pomocniczych `float`](/docs/5.3/utilities/float) lub [klas wyrównania tekstu](/docs/5.3/utilities/text#text-alignment). Obrazy blokowe (`block-level`) można wyśrodkować przy użyciu [narzędzia marginesów `.mx-auto`](/docs/5.3/utilities/spacing#horizontal-centering).


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
     &lt;svg aria-label=&quot;Placeholder: 200x200&quot; class=&quot;bd-placeholder-img rounded float-start&quot; height=&quot;200&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;200&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#868e96&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#dee2e6&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;200x200&lt;/text&gt;&lt;/svg&gt;
&lt;svg aria-label=&quot;Placeholder: 200x200&quot; class=&quot;bd-placeholder-img rounded float-end&quot; height=&quot;200&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;200&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#868e96&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#dee2e6&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;200x200&lt;/text&gt;&lt;/svg&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<img src="..." class="rounded float-start" alt="...">
<img src="..." class="rounded float-end" alt="...">
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
     &lt;svg aria-label=&quot;Placeholder: 200x200&quot; class=&quot;bd-placeholder-img rounded mx-auto d-block&quot; height=&quot;200&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;200&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#868e96&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#dee2e6&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;200x200&lt;/text&gt;&lt;/svg&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<img src="..." class="rounded mx-auto d-block" alt="...">
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
     &lt;div class=&quot;text-center&quot;&gt;
&lt;svg aria-label=&quot;Placeholder: 200x200&quot; class=&quot;bd-placeholder-img rounded&quot; height=&quot;200&quot; preserveaspectratio=&quot;xMidYMid slice&quot; role=&quot;img&quot; width=&quot;200&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect fill=&quot;#868e96&quot; height=&quot;100%&quot; width=&quot;100%&quot;&gt;&lt;/rect&gt;&lt;text dy=&quot;.3em&quot; fill=&quot;#dee2e6&quot; x=&quot;50%&quot; y=&quot;50%&quot;&gt;200x200&lt;/text&gt;&lt;/svg&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="text-center">
  <img src="..." class="rounded" alt="...">
</div>
```

## Picture

Jeżeli używasz elementu `<picture>` do zdefiniowania wielu elementów `<source>` dla jednego `<img>`, upewnij się, że klasy `.img-*` są dodane do znacznika `<img>`, a nie do `<picture>`.

```html
<picture>
  <source srcset="..." type="image/svg+xml">
  <img src="..." class="img-fluid img-thumbnail" alt="...">
</picture>
```

## CSS

### Zmienne Sass

Dostępne są zmienne Sass przeznaczone do miniatur obrazów.

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$thumbnail-padding:                 .25rem;
$thumbnail-bg:                      var(--#{$prefix}body-bg);
$thumbnail-border-width:            var(--#{$prefix}border-width);
$thumbnail-border-color:            var(--#{$prefix}border-color);
$thumbnail-border-radius:           var(--#{$prefix}border-radius);
$thumbnail-box-shadow:              var(--#{$prefix}box-shadow-sm);
```


>Komentarz:
Powyższe zmienne Sass pozwalają kontrolować wygląd miniatur obrazów w Bootstrap, w tym odstępy wewnętrzne, kolor tła, obramowanie, promień zaokrąglenia rogów oraz cień. Można je nadpisać w swoim projekcie, aby dostosować styl miniatur do własnych potrzeb.





