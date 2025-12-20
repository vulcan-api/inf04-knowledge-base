Powrót -> [Start](./root.md)

Widoczność elementów (Visibility)

Bootstrap pozwala kontrolować widoczność elementów bez zmiany ich właściwości display.

Za pomocą klas narzędziowych możemy ustawić właściwość CSS visibility.

Elementy z klasą .invisible są ukryte wizualnie, ale nadal zajmują miejsce na stronie i nie wpływają na układ.

Ukrycie elementu dotyczy również technologii wspomagających, takich jak czytniki ekranu.

Dostępne klasy

.visible – element widoczny

.invisible – element ukryty

Przykład użycia:

<br>
<iframe width="100%" height="150" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;visible border p-2 mb-2&quot;&gt;Ten element jest widoczny&lt;/div&gt;
    &lt;div class=&quot;invisible border p-2&quot;&gt;Ten element jest niewidoczny&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="visible">Ten element jest widoczny</div>
<div class="invisible">Ten element jest niewidoczny</div>
```

CSS tych klas:

.visible {
  visibility: visible !important;
}
.invisible {
  visibility: hidden !important;
}

CSS i Sass

Klasy do sterowania widocznością są zdefiniowane w Sass utilities API:

"visibility": (
  property: visibility,
  class: null,
  values: (
    visible: visible,
    invisible: hidden,
  )
),


Dzięki temu można łatwo korzystać z gotowych klas do kontrolowania widoczności elementów bez zmiany ich miejsca w układzie strony.

Podsumowanie:
Klasami .visible i .invisible w Bootstrap można ukrywać lub pokazywać elementy, zachowując przy tym ich miejsce w układzie strony, co daje większą elastyczność niż zwykłe display: none.
