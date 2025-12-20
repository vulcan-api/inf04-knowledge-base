Powrót -> [Start](./root.md)

Float – Bootstrap 5.3

Narzędzia Float w Bootstrapie umożliwiają szybkie ustawianie elementów po lewej lub prawej stronie albo całkowite wyłączenie opływania tekstu, przy użyciu właściwości CSS float.
Klasy te są responsywne i działają w oparciu o te same breakpointy, co system siatki Bootstrapa.

Przegląd (Overview)

Klasy float-*:

ustawiają float: left, float: right lub float: none,

automatycznie dostosowują się do szerokości ekranu,

zawierają !important, aby uniknąć problemów ze specyficznością CSS.

⚠️ Ważne:
Narzędzia float nie działają na elementach flexboxa (czyli elementach będących dziećmi kontenera .d-flex).

Podstawowe klasy float

Działają na wszystkich rozmiarach ekranów:

.float-start – element „pływa” po lewej stronie



lub dodać ją do elementu nadrzędnego.

Float responsywny (Responsive)

Bootstrap oferuje wersje responsywne dla każdej wartości float.
Klasy zaczynają działać od danego breakpointu wzwyż.

Format:

.float-{breakpoint}-{value}

Przykłady:
<div class="float-sm-end">Float od SM wzwyż</div>
<div class="float-md-end">Float od MD wzwyż</div>
<div class="float-lg-end">Float od LG wzwyż</div>


Oznacza to, że:

na mniejszych ekranach float nie działa,

na większych – zostaje aktywowany.

Lista wszystkich dostępnych klas
Bez breakpointów:

.float-start

.float-end

.float-none

Responsywne:

.float-sm-start, .float-sm-end, .float-sm-none

.float-md-start, .float-md-end, .float-md-none

.float-lg-start, .float-lg-end, .float-lg-none

.float-xl-start, .float-xl-end, .float-xl-none

.float-xxl-start, .float-xxl-end, .float-xxl-none

CSS i Sass
Utilities API (Sass)

Narzędzia float są generowane przez Utilities API w pliku:

scss/_utilities.scss


Definicja:

"float": (
  responsive: true,
  property: float,
  values: (
    start: left,
    end: right,
    none: none,
  )
),


Dzięki temu:

klasy są responsywne,

można je łatwo modyfikować lub rozszerzać w SCSS.

Kiedy używać floatów?

✔️ Dobre zastosowania:

opływanie tekstu wokół obrazów,

proste wyrównania w starszych layoutach,

drobne poprawki wizualne.

❌ Niezalecane:

budowanie całych layoutów (lepiej użyć Flexboxa lub Grid).

Podsumowanie

float-* → szybkie wyrównanie elementów

wsparcie dla breakpointów

nie działa z Flexboxem

przydatne głównie w prostych przypadkach

oparte na Utilities API Bootstrapa
