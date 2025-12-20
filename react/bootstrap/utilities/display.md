Powrót -> [Start](./root.md)

Display property – Bootstrap 5.3

Narzędzia display w Bootstrapie umożliwiają szybkie i responsywne sterowanie właściwością CSS display dla elementów HTML. Dzięki nim można łatwo pokazywać, ukrywać lub zmieniać sposób wyświetlania elementów (np. block, flex, none) bez pisania własnego CSS.

Obsługiwane są:

najczęściej używane wartości display,

warianty responsywne (dla różnych rozmiarów ekranów),

specjalne klasy do sterowania widocznością podczas drukowania.

Jak to działa (How it works)

Bootstrap udostępnia zestaw klas pomocniczych, które zmieniają wartość właściwości CSS display
.
Nie wszystkie możliwe wartości display są obsługiwane – tylko te najczęściej używane w praktyce.

Klasy można łączyć ze sobą, aby uzyskać różne efekty w zależności od rozmiaru ekranu lub trybu (ekran / druk).

Nazewnictwo klas (Notation)
Klasy bez breakpointów

Klasy, które działają na wszystkich rozmiarach ekranów (od xs wzwyż), nie zawierają skrótu breakpointu, ponieważ obowiązują od min-width: 0.

Format:

.d-{value}

Klasy responsywne

Dla breakpointów sm, md, lg, xl, xxl stosuje się format:

.d-{breakpoint}-{value}


📌 Przykłady:

.d-none

.d-md-block

.d-lg-flex

.d-xl-none

Dostępne wartości display

W klasach .d-* można używać następujących wartości:

none

inline

inline-block

block

grid

inline-grid

table

table-row

table-cell

flex

inline-flex

⚠️ Zakres tych wartości można zmienić, edytując zmienną $utilities w SCSS i ponownie kompilując Bootstrap.

Zasada działania breakpointów

Media queries w Bootstrapie działają od danego breakpointu wzwyż.

📌 Przykład:

<div class="d-lg-none"></div>


Element będzie:

widoczny na xs, sm, md
<span class="d-block p-2 text-bg-dark">d-block</span>

Elementy blokowe (każdy w nowej linii):

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
    &lt;span class=&quot;d-block p-2 text-bg-primary&quot;&gt;d-block&lt;/span&gt;
    &lt;span class=&quot;d-block p-2 text-bg-dark&quot;&gt;d-block&lt;/span&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<span class="d-block p-2 text-bg-primary">d-block</span>
<span class="d-block p-2 text-bg-dark">d-block</span>
```

Ukrywanie i pokazywanie elementów (Hiding elements)

Klasy display są często używane do responsywnego pokazywania i ukrywania elementów, zamiast tworzenia oddzielnych wersji strony dla różnych urządzeń.

Podstawowe ukrywanie

.d-none – ukrywa element na wszystkich ekranach

.d-{breakpoint}-none – ukrywa element od danego breakpointu wzwyż

Pokazywanie tylko na wybranych ekranach

Można łączyć klasy .d-none z .d-*-block (lub innymi wartościami).

📌 Przykład:

<div class="d-none d-md-block d-xl-none"></div>


Element:

ukryty na xs, sm

widoczny na md, lg

ukryty na xl, xxl

Najczęstsze kombinacje (tabela)
Zachowanie	Klasy
Ukryty wszędzie	.d-none
Ukryty tylko na xs	.d-none .d-sm-block
Ukryty tylko na sm	.d-sm-none .d-md-block
Ukryty tylko na md	.d-md-none .d-lg-block
Ukryty tylko na lg	.d-lg-none .d-xl-block
Ukryty tylko na xl	.d-xl-none .d-xxl-block
Ukryty tylko na xxl	.d-xxl-none
Widoczny wszędzie	.d-block
Widoczny tylko na xs	.d-block .d-sm-none
Widoczny tylko na sm	.d-none .d-sm-block .d-md-none
Widoczny tylko na md	.d-none .d-md-block .d-lg-none
Widoczny tylko na lg	.d-none .d-lg-block .d-xl-none
Widoczny tylko na xl	.d-none .d-xl-block .d-xxl-none
Widoczny tylko na xxl	.d-none .d-xxl-block
Display podczas drukowania (Display in print)

Bootstrap umożliwia zmianę display tylko na wydruku, za pomocą klas .d-print-*.

Dostępne klasy:

.d-print-none

.d-print-inline

.d-print-inline-block

.d-print-block

.d-print-grid

.d-print-inline-grid

.d-print-table

.d-print-table-row

.d-print-table-cell

.d-print-flex

.d-print-inline-flex

📌 Klasy dla druku można łączyć z klasami responsywnymi.

Przykład:
<div class="d-print-none">Widoczne tylko na ekranie</div>
<div class="d-none d-print-block">Widoczne tylko na wydruku</div>
<div class="d-none d-lg-block d-print-block">
  Widoczne na dużych ekranach i zawsze na wydruku
</div>

CSS i Sass
Utilities API (Sass)

Klasy display są zdefiniowane w Utilities API w pliku:

scss/_utilities.scss


Fragment konfiguracji:

"display": (
  responsive: true,
  print: true,
  property: display,
  class: d,
  values: inline inline-block block grid inline-grid table table-row table-cell flex inline-flex none
),


Dzięki temu:

klasy są generowane automatycznie,

obsługują breakpointy i druk,

można je łatwo rozszerzać lub modyfikować w SCSS.

Podsumowanie

.d-* – szybka kontrola właściwości display

obsługa responsywności i drukowania

możliwość łączenia klas

idealne do ukrywania i pokazywania elementów bez JS

oparte na Utilities API i zmiennych SCSS
