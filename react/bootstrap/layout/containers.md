Powrót -> [Start](./root.md)



# Containers

Containers są podstawowym elementem Bootstrapa, który zawiera, dodaje odstępy i wyrównuje treść w obrębie danego urządzenia lub viewportu.
Na tej stronie
   
**Na tej stronie**

---

* [How they work](#how-they-work)
* [Default container](#default-container)
* [Responsive containers](#responsive-containers)
* [Fluid containers](#fluid-containers)
* [CSS](#css)
  + [Sass variables](#sass-variables)
  + [Sass mixins](#sass-mixins)

## How they work

Kontenery są najbardziej podstawowym elementem layoutu w Bootstrapie i są **wymagane przy korzystaniu z domyślnego systemu siatki**. Służą do przechowywania treści, dodawania wewnętrznych odstępów oraz (czasami) do jej wyśrodkowania.Kontenery mogą być zagnieżdżane, ale większość layoutów tego nie wymaga.

Bootstrap oferuje trzy rodzaje kontenerów:

* `.container`, ustawia`max-width` dla każdego breakpointu
* `.container-{breakpoint}`, ma `width: 100%` aż do wskazanego breakpointu
* `.container-fluid` ma `width: 100%` na wszystkich breakpointach("wypełnia" przestrzeń)

Poniższa tabela pokazuje, jak `max-width`  poszczególnych `.container` u `.container-fluid` zmienia się na różnych breakpointach.

See them in action and compare them in our [Grid example](/docs/5.3/examples/grid/#containers).

|  | Extra small <576px | Small ≥576px | Medium ≥768px | Large ≥992px | X-Large ≥1200px | XX-Large ≥1400px |
| --- | --- | --- | --- | --- | --- | --- |
| `.container` | 100% | 540px | 720px | 960px | 1140px | 1320px |
| `.container-sm` | 100% | 540px | 720px | 960px | 1140px | 1320px |
| `.container-md` | 100% | 100% | 720px | 960px | 1140px | 1320px |
| `.container-lg` | 100% | 100% | 100% | 960px | 1140px | 1320px |
| `.container-xl` | 100% | 100% | 100% | 100% | 1140px | 1320px |
| `.container-xxl` | 100% | 100% | 100% | 100% | 100% | 1320px |
| `.container-fluid` | 100% | 100% | 100% | 100% | 100% | 100% |

## Default container

Domyślna klasa `.container` to responsywny kontener o stałej szerokości, co oznacza, że jego `max-width` zmienia się na każdym breakpointcie.

```html
<div class="container">
  <!-- Content here -->
</div>
```

## Responsive containers

Kontenery responsywne pozwalają określić klasę, która ma 100% szerokości do danego breakpointu, a po jego przekroczeniu otrzymuje stałe `max-width` `.container-sm` ma 100% szerokości aż do breakpointu`sm` a następnie skaluje się wraz z `md`, `lg`, `xl`, i `xxl`.

```html
<div class="container-sm">100% wide until small breakpoint</div>
<div class="container-md">100% wide until medium breakpoint</div>
<div class="container-lg">100% wide until large breakpoint</div>
<div class="container-xl">100% wide until extra large breakpoint</div>
<div class="container-xxl">100% wide until extra extra large breakpoint</div>
```

## Fluid containers

Użyj `.container-fluid` aby uzyskać kontener o pełnej szerokości, zajmujący cały viewport.

```html
<div class="container-fluid">
  ...
</div>
```


