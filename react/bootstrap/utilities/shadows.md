Powrót -> [Start](./root.md)

Shadows (cienie)

Bootstrap umożliwia dodawanie i usuwanie cieni dla elementów za pomocą klas narzędziowych box-shadow. Dzięki nim można szybko nadać elementom głębię i wyróżnić je wizualnie.

Przykłady zastosowania

Bootstrap udostępnia cztery podstawowe klasy cieni:

shadow-lg – większy cień
    
Przykład w HTML:

<br>
<iframe width="100%" height="350" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;shadow-none p-3 mb-5 bg-body-tertiary rounded&quot;&gt;Brak cienia&lt;/div&gt;
    &lt;div class=&quot;shadow-sm p-3 mb-5 bg-body-tertiary rounded&quot;&gt;Mały cień&lt;/div&gt;
    &lt;div class=&quot;shadow p-3 mb-5 bg-body-tertiary rounded&quot;&gt;Standardowy cień&lt;/div&gt;
    &lt;div class=&quot;shadow-lg p-3 mb-5 bg-body-tertiary rounded&quot;&gt;Duży cień&lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="shadow-none p-3 mb-5 bg-body-tertiary rounded">Brak cienia</div>
<div class="shadow-sm p-3 mb-5 bg-body-tertiary rounded">Mały cień</div>
<div class="shadow p-3 mb-5 bg-body-tertiary rounded">Standardowy cień</div>
<div class="shadow-lg p-3 mb-5 bg-body-tertiary rounded">Duży cień</div>
```
shadow-none – brak cienia

W Bootstrapie cienie są definiowane przy użyciu zmiennych Sass, co pozwala je łatwo modyfikować:

$box-shadow:       0 .5rem 1rem rgba($black, .15);
$box-shadow-sm:    0 .125rem .25rem rgba($black, .075);
$box-shadow-lg:    0 1rem 3rem rgba($black, .175);
$box-shadow-inset: inset 0 1px 2px rgba($black, .075);

Utilities API

Klasy shadow są generowane w Utilities API Bootstrap (scss/_utilities.scss) i mapowane na właściwość CSS box-shadow:

"shadow": (
  property: box-shadow,
  class: shadow,
  values: (
    null: var(--#{$prefix}box-shadow),
    sm: var(--#{$prefix}box-shadow-sm),
    lg: var(--#{$prefix}box-shadow-lg),
    none: none,
  )
),

Podsumowanie

Dzięki Shadow utilities w Bootstrapie można:

szybko dodawać różnej wielkości cienie do elementów,

usuwać cień jednym kliknięciem (shadow-none),

dostosowywać wygląd cieni za pomocą zmiennych Sass,

w prosty sposób wzbogacać interfejs wizualny bez dodatkowego CSS.
