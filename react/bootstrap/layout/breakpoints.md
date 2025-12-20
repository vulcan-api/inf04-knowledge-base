Powrót -> [Start](./root.md)



# Breakpoints

Punkty przerwania (breakpoints) to konfigurowalne szerokości, które określają, jak zachowuje się responsywny układ w zależności od rozmiaru urządzenia lub widoku (viewport) w Bootstrapie. Innymi słowami, zmiennia się css w zależności od szerokości naszego ekranu. Dodane np. do container zmienii jego np. szerokość w zależności od wielkości okna.

Na tej stronie
   
**On this page**

---

* [Core concepts](#core-concepts)
* [Available breakpoints](#available-breakpoints)


## Core concepts

* **Punkty przerwania są podstawowymi elementami responsywnego projektowania.** Używaj ich do kontrolowania momentu, w którym układ strony powinien się dostosować do konkretnego rozmiaru urządzenia lub widoku.
* **Używaj media queries do projektowania CSS według breakpointów..** Media queries to funkcja CSS, która pozwala warunkowo stosować style w zależności od parametrów przeglądarki i systemu operacyjnego. Najczęściej używamy `min-width` w zapytaniach medialnych.
* **Mobile first i responsywność są celem.** CSS Bootstrapa stosuje minimalną liczbę stylów dla najmniejszego breakpointu, a następnie dodaje kolejne style dla większych urządzeń. Optymalizuje to CSS, poprawia czas renderowania i zapewnia lepsze doświadczenie użytkownika.

## Dostępne breakpoints

Bootstrap zawiera sześć domyślnych punktów przerwania (nazywanych też poziomami siatki), które służą do budowania responsywnych układów. Można je modyfikować, jeśli korzystasz z plików źródłowych Sass.

| Breakpoint | Class infix | Dimensions |
| --- | --- | --- |
| Extra small | *None* | <576px |
| Small | `sm` | ≥576px |
| Medium | `md` | ≥768px |
| Large | `lg` | ≥992px |
| Extra large | `xl` | ≥1200px |
| Extra extra large | `xxl` | ≥1400px |

Każdy breakpoint został dobrany tak, aby wygodnie mieścił kontenery o szerokościach będących wielokrotnością 12. Reprezentują one popularne rozmiary urządzeń i viewportów, ale nie są przypisane do każdego możliwego przypadku. Zamiast tego zapewniają solidną i spójną bazę do budowy układów na niemal każde urządzenie.

Te breakpointy można konfigurować w Sass — znajdują się w mapie Sass w pliku`_variables.scss`.



```html
$grid-breakpoints: (
  xs: 0,
  sm: 576px,
  md: 768px,
  lg: 992px,
  xl: 1200px,
  xxl: 1400px
);
```




