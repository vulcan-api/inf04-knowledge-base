Powrót -> [Start](./root.md)

Tekst w Bootstrap

Bootstrap oferuje zestaw klas narzędziowych do formatowania tekstu, pozwalających kontrolować: wyrównanie, zawijanie, wielkość, wagę czcionki, styl i dekoracje. Dzięki nim można szybko dostosować wygląd tekstu w elementach HTML bez pisania własnego CSS.

Wyrównanie tekstu


Przykład

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
    &lt;div class=&quot;text-wrap bg-primary text-white mb-3&quot; style=&quot;width: 6rem;&quot;&gt;Ten tekst będzie się zawijał&lt;/div&gt;
    &lt;div class=&quot;text-nowrap bg-secondary text-white border&quot; style=&quot;width: 8rem;&quot;&gt;Ten tekst może wystawać poza rodzica&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="text-wrap" style="width: 6rem;">Ten tekst będzie się zawijał</div>
<div class="text-nowrap" style="width: 8rem;">Ten tekst może wystawać poza rodzica</div>
```

Przerywanie wyrazów (word break)

.text-break – zapobiega łamaniu layoutu przez długie ciągi znaków, ustawiając word-wrap: break-word i word-break: break-word.

Nie działa w językach RTL, np. w arabskim.

Przykład

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
    &lt;p class=&quot;text-break border&quot;&gt;mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm&lt;/p&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<p class="text-break">mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm</p>
```

Transformacje tekstu

.text-lowercase – zmiana na małe litery

.text-uppercase – zmiana na wielkie litery

.text-capitalize – zmiana pierwszej litery każdego wyrazu na wielką

Przykład

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
    &lt;p class=&quot;text-lowercase&quot;&gt;tekst małymi literami&lt;/p&gt;
    &lt;p class=&quot;text-uppercase&quot;&gt;TEKST WIELKIMI LITERAMI&lt;/p&gt;
    &lt;p class=&quot;text-capitalize&quot;&gt;Pierwsza litera każdego wyrazu&lt;/p&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<p class="text-lowercase">tekst małymi literami</p>
<p class="text-uppercase">TEKST WIELKIMI LITERAMI</p>
<p class="text-capitalize">Pierwsza litera każdego wyrazu</p>
```

Rozmiar czcionki

Klasy .fs-1 do .fs-6 umożliwiają szybką zmianę rozmiaru tekstu.

.fs-1 = największy, .fs-6 = najmniejszy.

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
    &lt;p class=&quot;fs-1&quot;&gt;Największy tekst (fs-1)&lt;/p&gt;
    &lt;p class=&quot;fs-2&quot;&gt;fs-2&lt;/p&gt;
    &lt;p class=&quot;fs-3&quot;&gt;fs-3&lt;/p&gt;
    &lt;p class=&quot;fs-4&quot;&gt;fs-4&lt;/p&gt;
    &lt;p class=&quot;fs-5&quot;&gt;fs-5&lt;/p&gt;
    &lt;p class=&quot;fs-6&quot;&gt;Najmniejszy tekst (fs-6)&lt;/p&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<p class="fs-1">Największy tekst</p>
<p class="fs-6">Najmniejszy tekst</p>
```

Waga czcionki i kursywa

.fw-* – zmienia wagę czcionki (fw-light, fw-normal, fw-bold itd.)

.fst-* – zmienia styl czcionki (fst-italic, fst-normal)

Przykład

<br>
<iframe width="100%" height="450" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;p class=&quot;fw-bold&quot;&gt;Tekst pogrubiony&lt;/p&gt;
    &lt;p class=&quot;fst-italic&quot;&gt;Tekst kursywą&lt;/p&gt;
    &lt;p class=&quot;lh-lg&quot;&gt;Tekst z większą wysokością linii. Ten tekst jest dłuższy, aby pokazać odstępy między liniami wyraźniej.&lt;/p&gt;
    &lt;p class=&quot;font-monospace&quot;&gt;Tekst w czcionce monospace&lt;/p&gt;
    &lt;p class=&quot;text-decoration-underline&quot;&gt;Podkreślony tekst&lt;/p&gt;
    &lt;p class=&quot;text-decoration-line-through&quot;&gt;Przekreślony tekst&lt;/p&gt;
    &lt;a href=&quot;#&quot; class=&quot;text-decoration-none&quot;&gt;Link bez dekoracji&lt;/a&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<p class="fw-bold">Tekst pogrubiony</p>
<p class="fst-italic">Tekst kursywą</p>
<p class="lh-lg">Tekst z większą wysokością linii</p>
<p class="font-monospace">Tekst w czcionce monospace</p>
<p class="text-decoration-underline">Podkreślony tekst</p>
<p class="text-decoration-line-through">Przekreślony tekst</p>
<a href="#" class="text-decoration-none">Link bez dekoracji</a>
```

CSS i Sass

Bootstrap definiuje zmienne Sass dla rodzin czcionek, wag, rozmiarów i wysokości linii.

Rozmiary czcionek są generowane z mapy $font-sizes, a kolory tekstu z $theme-colors-text.

Wszystkie powyższe klasy są dostępne dzięki Sass utilities API, które umożliwia łatwe tworzenie własnych wariantów i dostosowanie projektu.

Podsumowanie

Text utilities w Bootstrap pozwalają w prosty sposób:

ustawiać wyrównanie tekstu i zawijanie,

kontrolować rozmiar, wagę i styl czcionki,

zmieniać wysokość linii i rodzaj czcionki,

resetować kolor i dodawać dekoracje tekstu.

Dzięki nim formatowanie tekstu staje się szybkie, spójne i responsywne.
