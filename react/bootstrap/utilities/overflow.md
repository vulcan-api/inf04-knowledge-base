Powrót -> [Start](./root.md)

Overflow (przepełnienie zawartości)

Narzędzia Overflow utilities w Bootstrapie umożliwiają szybkie kontrolowanie tego, jak zachowuje się zawartość elementu, gdy nie mieści się ona w jego obszarze. Klasy te są skrótami do właściwości CSS overflow, overflow-x oraz overflow-y.

Domyślnie nie są responsywne (nie zmieniają się w zależności od breakpointów).

Klasy overflow

Klasy te ustawiają właściwość overflow jednocześnie w pionie i poziomie.

Dostępne wartości:

overflow-auto
Zawartość zostanie przewinięta tylko wtedy, gdy jest to konieczne (scroll pojawia się automatycznie).

overflow-hidden
Nadmiarowa zawartość zostaje ukryta (brak przewijania).


overflow-x-auto

overflow-x-hidden

overflow-x-visible

overflow-x-scroll

Zastosowanie:

przewijane tabele,

długie linie tekstu,

elementy typu code lub layouty poziome.

Przykład
<div class="overflow-x-auto">...</div>
<div class="overflow-x-hidden">...</div>
<div class="overflow-x-visible">...</div>
<div class="overflow-x-scroll">...</div>

overflow-y – przepełnienie w pionie

Klasy overflow-y-* kontrolują przepełnienie w osi pionowej (Y).

Dostępne klasy:

overflow-y-auto

overflow-y-hidden

overflow-y-visible

overflow-y-scroll

Zastosowanie:

przewijane panele,

listy elementów,

okna modalne i sekcje z ograniczoną wysokością.

Przykład
<div class="overflow-y-auto">...</div>
<div class="overflow-y-hidden">...</div>
<div class="overflow-y-visible">...</div>
<div class="overflow-y-scroll">...</div>

Dostosowywanie (Sass)

Za pomocą zmiennych Sass możesz dostosować dostępne wartości overflow, modyfikując zmienną:

$overflows


w pliku _variables.scss.

CSS i Sass Utilities API

Narzędzia overflow są zdefiniowane w Utilities API w pliku:

scss/_utilities.scss


Bootstrap mapuje klasy na właściwości CSS w następujący sposób:

overflow → overflow

overflow-x → overflow-x

overflow-y → overflow-y

Dostępne wartości:

auto

hidden

visible

scroll
