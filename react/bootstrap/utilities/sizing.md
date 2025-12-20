Powrót -> [Start](./root.md)

Sizing (rozmiary)

Bootstrap umożliwia łatwe ustawianie szerokości i wysokości elementów za pomocą klas narzędziowych. Można definiować rozmiary względem rodzica lub względem widoku (viewport).

Rozmiary względem rodzica

Dzięki klasom w-* i h-* można ustawiać szerokość i wysokość elementów jako procent wartości rodzica lub automatycznie:

Klasy szerokości:

w-25 – 25% szerokości rodzica

w-50 – 50% szerokości rodzica

w-75 – 75% szerokości rodzica

w-100 – 100% szerokości rodzica

w-auto – szerokość automatyczna

Klasy wysokości:

h-25 – 25% wysokości rodzica

h-50 – 50% wysokości rodzica

h-75 – 75% wysokości rodzica

h-100 – 100% wysokości rodzica

h-auto – wysokość automatyczna

Dodatkowo można stosować max-width i max-height (mw-100, mh-100) do ograniczenia maksymalnych wymiarów elementu.

Rozmiary względem widoku (viewport)

Bootstrap umożliwia ustawianie rozmiarów elementów względem całego widoku przeglądarki:

vw-100 – szerokość 100vw

"max-width": (property: max-width, class: mw, values: 100),
"height": (property: height, class: h, values: 25 50 75 100 auto),
"max-height": (property: max-height, class: mh, values: 100),
"viewport-width": (property: width, class: vw, values: 100),
"min-viewport-width": (property: min-width, class: min-vw, values: 100),
"viewport-height": (property: height, class: vh, values: 100),
"min-viewport-height": (property: min-height, class: min-vh, values: 100)

Podsumowanie

Korzystając z Sizing utilities, można w prosty sposób:

ustawiać szerokość i wysokość elementów w procentach rodzica lub w jednostkach widoku,

ograniczać maksymalne wymiary,

tworzyć elastyczne i responsywne układy bez konieczności pisania własnego CSS.
