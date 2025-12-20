Powrót -> [Start](./root.md)

Wyrównanie pionowe (Vertical alignment)

Bootstrap umożliwia łatwą zmianę wyrównania pionowego elementów typu inline, inline-block, inline-table oraz komórek tabeli (table cell).

Wyrównanie pionowe kontroluje właściwość CSS vertical-align
.

Używa się do tego klas narzędziowych:

.align-baseline – wyrównanie do linii bazowej tekstu

.align-top – wyrównanie do górnej krawędzi elementu nadrzędnego

.align-middle – wyrównanie do środka linii tekstu

.align-bottom – wyrównanie do dolnej krawędzi elementu nadrzędnego

.align-text-top – wyrównanie do górnej krawędzi czcionki w linii

.align-text-bottom – wyrównanie do dolnej krawędzi czcionki w linii

Wyrównanie pionowe elementów inline

<br>
<iframe width="100%" height="150" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;style&gt;
        span { border: 1px solid #dee2e6; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;span class=&quot;align-baseline&quot;&gt;baseline&lt;/span&gt;
    &lt;span class=&quot;align-top&quot;&gt;top&lt;/span&gt;
    &lt;span class=&quot;align-middle&quot;&gt;middle&lt;/span&gt;
    &lt;span class=&quot;align-bottom&quot;&gt;bottom&lt;/span&gt;
    &lt;span class=&quot;align-text-top&quot;&gt;text-top&lt;/span&gt;
    &lt;span class=&quot;align-text-bottom&quot;&gt;text-bottom&lt;/span&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<span class="align-baseline">baseline</span>
<span class="align-top">top</span>
<span class="align-middle">middle</span>
<span class="align-bottom">bottom</span>
<span class="align-text-top">text-top</span>
<span class="align-text-bottom">text-bottom</span>
```

Klasy te działają na elementach span, img i innych elementach inline.

Wyrównanie pionowe w komórkach tabeli

<br>
<iframe width="100%" height="200" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;table class=&quot;table table-bordered&quot; style=&quot;height: 100px;&quot;&gt;
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




Można wyrównać pionowo zawartość komórek tabeli za pomocą tych samych klas.

Wyrównanie pionowe dla bloków nie-inline

Aby wyśrodkować nie-inline elementy (np. `<div>`), należy użyć narzędzi Flexbox
.

CSS i Sass

Klasy wyrównania pionowego są zdefiniowane w Sass utilities API:

"align": (
  property: vertical-align,
  class: align,
  values: baseline top middle bottom text-bottom text-top
),


Dzięki temu można łatwo tworzyć własne warianty i korzystać z gotowych klas do wyrównania pionowego.

Podsumowanie:
Klasami .align-* w Bootstrap możemy szybko i wygodnie ustawiać wyrównanie pionowe elementów inline, inline-block, inline-table oraz komórek tabeli, bez potrzeby pisania własnego CSS.
