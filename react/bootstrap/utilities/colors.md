Powrót -> [Start](./root.md)

Colors (Kolory) – Bootstrap 5.3

Narzędzia kolorów w Bootstrapie umożliwiają szybkie nadawanie koloru tekstu za pomocą klas pomocniczych. Służą one do wizualnego przekazywania znaczenia (np. sukces, błąd, ostrzeżenie) i są spójne z kolorami motywu Bootstrapa.

Bootstrap oferuje także specjalne klasy do kolorowania linków (.link-*), które obsługują stany :hover i :focus.

Accessibility (Dostępność)

⚠️ Ważne: Kolor nie powinien być jedynym nośnikiem informacji.
Użytkownicy czytników ekranu mogą nie zauważyć różnic kolorystycznych, dlatego:

znaczenie powinno wynikać także z treści tekstu,

należy zachować odpowiedni kontrast kolorów,

ewentualnie używać dodatkowego tekstu ukrytego klasą .visually-hidden.

Kolorowanie tekstu – klasy .text-*

Podstawowe klasy kolorów tekstu bazują na kolorach motywu:

.text-primary

.text-secondary

.text-success

.text-danger

.text-warning


mają lepszy kontrast,

są rekomendowane zamiast klasycznych .text-*.

Przykłady:

.text-primary-emphasis

.text-success-emphasis

.text-danger-emphasis

⚠️ Klasy .text-* nie reagują jeszcze na tryby kolorów – zostanie to poprawione w Bootstrapie v6.

Kolory tekstu „systemowe”

Bootstrap udostępnia też kolory zależne od motywu strony:

.text-body – domyślny kolor tekstu

.text-body-emphasis – wyróżniony tekst

.text-body-secondary – tekst drugorzędny

.text-body-tertiary – tekst pomocniczy

Są one szczególnie przydatne w trybie ciemnym i jasnym.

Kolory czyste i półprzezroczyste

Dostępne są również:

.text-black

.text-white

⚠️ Przestarzałe (deprecated):

.text-black-50

.text-white-50
(Zostaną usunięte w Bootstrapie v6 – zastępują je klasy przezroczystości)

.text-muted – przestarzałe

Klasa .text-muted została wycofana w Bootstrapie 5.3.
Jej rolę przejęła zmienna CSS --bs-secondary-color, lepiej wspierająca tryby kolorów.

Opacity – przezroczystość tekstu (od v5.1)

Od wersji 5.1 kolory tekstu są generowane przy użyciu zmiennych CSS, co umożliwia dynamiczną zmianę przezroczystości.

Jak to działa?

Przykład klasy .text-primary:

.text-primary {
  --bs-text-opacity: 1;
  color: rgba(var(--bs-primary-rgb), var(--bs-text-opacity));
}


Każda klasa .text-*:

używa zmiennej RGB (np. --bs-primary-rgb)

posiada lokalną zmienną --bs-text-opacity

nie przekazuje przezroczystości do elementów zagnieżdżonych

Zmiana przezroczystości – inline
<div class="text-primary" style="--bs-text-opacity: .5;">
  Tekst 50% przezroczystości
</div>

Gotowe klasy .text-opacity-*

Bootstrap oferuje:

.text-opacity-75

.text-opacity-50

.text-opacity-25

.text-opacity-100

Przykład:

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
    &lt;div class=&quot;text-primary&quot;&gt;This is default primary text&lt;/div&gt;
    &lt;div class=&quot;text-primary&quot; style=&quot;--bs-text-opacity: .5;&quot;&gt;This is 50% opacity primary text&lt;/div&gt;
    &lt;div class=&quot;text-success text-opacity-75&quot;&gt;This is 75% opacity success text&lt;/div&gt;
    &lt;div class=&quot;text-success text-opacity-50&quot;&gt;This is 50% opacity success text&lt;/div&gt;
    &lt;div class=&quot;text-success text-opacity-25&quot;&gt;This is 25% opacity success text&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="text-primary">This is default primary text</div>
<div class="text-primary" style="--bs-text-opacity: .5;">This is 50% opacity primary text</div>
<div class="text-success text-opacity-75">This is 75% opacity success text</div>
<div class="text-success text-opacity-50">This is 50% opacity success text</div>
<div class="text-success text-opacity-25">This is 25% opacity success text</div>
```

Specificity (specyficzność CSS)

Czasami klasy .text-* mogą nie działać z powodu większej specyficzności innych selektorów.
Rozwiązanie:

owiń treść w dodatkowy element z klasą .text-*

użyj bardziej semantycznego znacznika (<span>, <div>)

CSS i Sass – jak to działa „pod maską”
Zmienne Sass

Kolory pochodzą z palety:

$primary, $success, $danger, itd.

$white, $black, $gray-*

Mapy Sass

Bootstrap używa map:

$theme-colors

$theme-colors-text

$theme-colors-text-dark

Dzięki nim:

generowane są klasy .text-*

obsługiwane są tryby jasny / ciemny

możliwe jest tworzenie wersji *-emphasis

RGB i Utilities API

Kolory RGB są generowane dynamicznie i używane w Utilities API, co pozwala:

zmieniać przezroczystość

łatwo rozszerzać klasy

dostosowywać Bootstrap bez modyfikowania CSS ręcznie

Podsumowanie

.text-* – podstawowe kolory tekstu

.text-*-emphasis – zalecane, adaptacyjne

.text-body-* – kolory systemowe

.text-opacity-* – kontrola przezroczystości

klasy *-50 i .text-muted – przestarzałe

wszystko oparte o CSS variables i Sass
