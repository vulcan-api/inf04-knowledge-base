Powrót -> [Start](./root.md)

Opacity (przezroczystość)

Narzędzia Opacity w Bootstrapie umożliwiają kontrolowanie poziomu przezroczystości elementów HTML za pomocą właściwości CSS opacity.

Właściwość opacity określa stopień widoczności elementu:

1 – element jest całkowicie nieprzezroczysty (100% widoczny),

0.5 – element jest widoczny w 50%,

0 – element jest całkowicie przezroczysty (niewidoczny).

Użycie klas .opacity-{wartość}

Aby ustawić przezroczystość elementu, wystarczy dodać odpowiednią klasę .opacity-{value}.

Dostępne klasy:

opacity-100 – 100% widoczności,

opacity-75 – 75% widoczności,

opacity-50 – 50% widoczności,

oznaczania elementów nieaktywnych,

efektów wizualnych (np. animacje, hover),

stopniowego ukrywania lub pokazywania elementów.

⚠️ Uwaga dotycząca dostępności:
Niska przezroczystość może znacząco obniżyć czytelność tekstu i kontrast kolorów, co utrudnia korzystanie z interfejsu osobom z wadami wzroku.

CSS i Sass Utilities API

Klasy związane z przezroczystością są zdefiniowane w Utilities API w pliku:

scss/_utilities.scss


Bootstrap mapuje klasy na wartości CSS w następujący sposób:

opacity-0 → opacity: 0

opacity-25 → opacity: 0.25

opacity-50 → opacity: 0.5

opacity-75 → opacity: 0.75

opacity-100 → opacity: 1

Dzięki Utilities API możesz łatwo rozszerzyć lub zmodyfikować te wartości w konfiguracji Sass.
