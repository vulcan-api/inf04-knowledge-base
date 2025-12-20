Powrót -> [Start](./root.md)

Position (pozycjonowanie elementów)

Narzędzia Position utilities w Bootstrapie umożliwiają szybkie i wygodne ustawianie pozycji elementów bez konieczności pisania własnego CSS. Są to skrócone klasy odpowiadające właściwości CSS position, top, right, bottom, left oraz transform.

Klasy pozycjonowania nie są responsywne – ich działanie nie zależy od breakpointów.

Wartości position

Bootstrap udostępnia gotowe klasy do ustawiania właściwości position:

position-static – domyślne pozycjonowanie (brak specjalnego pozycjonowania)

position-relative – pozycjonowanie względne (punkt odniesienia dla elementów absolutnych)


Właściwości:

top – górna krawędź

bottom – dolna krawędź

start – lewa krawędź (dla układu LTR)

end – prawa krawędź (dla układu LTR)

Dostępne wartości:

0 – 0%

50 – 50%

100 – 100%

Przykład

<br>
<iframe width="100%" height="250" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;position-relative bg-light border&quot; style=&quot;height: 200px;&quot;&gt;
        &lt;div class=&quot;position-absolute top-0 start-0 bg-dark p-2 text-white&quot;&gt;Top Start&lt;/div&gt;
        &lt;div class=&quot;position-absolute top-0 end-0 bg-dark p-2 text-white&quot;&gt;Top End&lt;/div&gt;
        &lt;div class=&quot;position-absolute top-50 start-50 bg-dark p-2 text-white&quot;&gt;Center&lt;/div&gt;
        &lt;div class=&quot;position-absolute bottom-50 end-50 bg-dark p-2 text-white&quot;&gt;Bottom End 50&lt;/div&gt;
        &lt;div class=&quot;position-absolute bottom-0 start-0 bg-dark p-2 text-white&quot;&gt;Bottom Start&lt;/div&gt;
        &lt;div class=&quot;position-absolute bottom-0 end-0 bg-dark p-2 text-white&quot;&gt;Bottom End&lt;/div&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="position-relative">
  <div class="position-absolute top-0 start-0"></div>
  <div class="position-absolute top-50 start-50"></div>
  <div class="position-absolute bottom-0 end-0"></div>
</div>
```


Element nadrzędny musi mieć position-relative, aby pozycjonowanie absolutne działało poprawnie.

Wyśrodkowywanie elementów

Bootstrap oferuje klasy transformacji do łatwego centrowania elementów.

.translate-middle

Klasa ta dodaje transformację:

transform: translate(-50%, -50%);


W połączeniu z top-50 i start-50 umożliwia idealne wyśrodkowanie elementu.

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
    &lt;div class=&quot;position-relative bg-light border&quot; style=&quot;height: 150px;&quot;&gt;
        &lt;div class=&quot;position-absolute top-50 start-50 translate-middle bg-primary p-3 text-white rounded&quot;&gt;Centered&lt;/div&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="position-absolute top-50 start-50 translate-middle"></div>
```

Wyśrodkowanie tylko w jednej osi

Dostępne są również klasy do centrowania tylko w jednej osi:

translate-middle-x – wyśrodkowanie w poziomie

translate-middle-y – wyśrodkowanie w pionie

Przykład
<div class="position-absolute top-0 start-50 translate-middle-x"></div>
<div class="position-absolute top-50 start-0 translate-middle-y"></div>

Przykłady praktyczne zastosowań

Klasy pozycjonowania są często wykorzystywane do:

znaczników powiadomień (badge),

liczników wiadomości,

wskaźników na przyciskach,

niestandardowych komponentów interfejsu.

Przykład – licznik wiadomości
<button class="btn btn-primary position-relative">
  Mails
  <span class="position-absolute top-0 start-100 translate-middle badge rounded-pill text-bg-secondary">
    +99
  </span>
</button>

Dostosowywanie (Sass)
Mapy Sass

Domyślne wartości pozycji są zdefiniowane w mapie Sass:

$position-values: (
  0: 0,
  50: 50%,
  100: 100%
);


Możesz dodać własne wartości, rozszerzając tę mapę.

Utilities API (CSS)

Klasy pozycjonowania są generowane za pomocą Utilities API w pliku:

scss/_utilities.scss


Bootstrap mapuje klasy na właściwości CSS:

position-* → position

top-*, bottom-*, start-*, end-*

translate-middle, translate-middle-x, translate-middle-y

Podsumowanie

Narzędzia Position utilities w Bootstrapie pozwalają:

szybko ustawiać pozycję elementów,

łatwo je centrować,

tworzyć zaawansowane układy bez pisania CSS,

rozszerzać funkcjonalność dzięki Sass.
