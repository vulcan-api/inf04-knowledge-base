Powrót -> [Start](./root.md)

> Źródło: [https://getbootstrap.com/docs/5.3/forms/overview](https://getbootstrap.com/docs/5.3/forms/overview)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/forms/overview.mdx "View and edit this file on GitHub")

# Formularze

Przykłady i wytyczne dotyczące stylów elementów formularzy, opcji układu oraz komponentów niestandardowych do tworzenia szerokiej gamy formularzy.

Na tej stronie

**Na tej stronie**

---

* [Przegląd](#overview)
* [Formularze wyłączone](#disabled-forms)
* [Dostępność](#accessibility)
* [CSS](#css)
  + [Zmienne Sass](#sass-variables)

[**Formularz kontrolny** Stylizuj pola tekstowe i textarea z obsługą wielu stanów.](/docs/5.3/forms/form-control/)

[**Select** Ulepsz domyślne elementy select przeglądarki, nadając im niestandardowy wygląd początkowy.](/docs/5.3/forms/select/)

[**Checks & radios** Użyj niestandardowych przycisków radiowych i checkboxów w formularzach do wybierania opcji.](/docs/5.3/forms/checks-radios/)

[**Range** Zastąp domyślne suwaki przeglądarki własną wersją.](/docs/5.3/forms/range/)

[**Grupa inputów** Dodaj etykiety i przyciski do swoich pól, aby zwiększyć wartość semantyczną.](/docs/5.3/forms/input-group/)

[**Floating labels** Twórz proste i eleganckie etykiety formularzy, które unoszą się nad polami wejściowymi.](/docs/5.3/forms/floating-labels/)

[**Układ** Twórz formularze inline, poziome lub oparte na skomplikowanej siatce.](/docs/5.3/forms/layout/)

[**Walidacja** Waliduj swoje formularze za pomocą niestandardowych lub natywnych zachowań i stylów.](/docs/5.3/forms/validation/)

## Przegląd

Formularze Bootstrap rozszerzają [nasze style formularzy Reboot](/docs/5.3/content/reboot#forms) za pomocą klas. Użyj tych klas, aby skorzystać z ich niestandardowego wyglądu dla bardziej spójnego renderowania w różnych przeglądarkach i urządzeniach.

Upewnij się, że używasz odpowiedniego atrybutu `type` dla wszystkich inputów (np. `email` dla adresu email lub `number` dla danych liczbowych), aby skorzystać z nowych kontrolek wejściowych, takich jak weryfikacja email czy wybór liczb.

Poniżej szybki przykład pokazujący style formularzy Bootstrap. Kontynuuj czytanie, aby dowiedzieć się o wymaganych klasach, układzie formularzy i innych opcjach.

<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
    &lt;style&gt;
        body { padding: 1rem; background-color: #fff; }
        .dropdown-menu { position: absolute !important; }
        .bd-example { margin: 0; border: none; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body&gt;
     &lt;form&gt;
&lt;div class=&quot;mb-3&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;exampleInputEmail1&quot;&gt;Email address&lt;/label&gt;
&lt;input aria-describedby=&quot;emailHelp&quot; class=&quot;form-control&quot; id=&quot;exampleInputEmail1&quot; type=&quot;email&quot;/&gt;
&lt;div class=&quot;form-text&quot; id=&quot;emailHelp&quot;&gt;We&#x27;ll never share your email with anyone else.&lt;/div&gt;
&lt;/div&gt;
&lt;div class=&quot;mb-3&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;exampleInputPassword1&quot;&gt;Password&lt;/label&gt;
&lt;input class=&quot;form-control&quot; id=&quot;exampleInputPassword1&quot; type=&quot;password&quot;/&gt;
&lt;/div&gt;
&lt;div class=&quot;mb-3 form-check&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;exampleCheck1&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;exampleCheck1&quot;&gt;Check me out&lt;/label&gt;
&lt;/div&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;submit&quot;&gt;Submit&lt;/button&gt;
&lt;/form&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<form>
  <div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Email address</label>
    <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">
    <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
  </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Password</label>
    <input type="password" class="form-control" id="exampleInputPassword1">
  </div>
  <div class="mb-3 form-check">
    <input type="checkbox" class="form-check-input" id="exampleCheck1">
    <label class="form-check-label" for="exampleCheck1">Check me out</label>
  </div>
  <button type="submit" class="btn btn-primary">Submit</button>
</form>
```

## Formularze wyłączone

Dodaj atrybut `disabled` do pola, aby uniemożliwić interakcję użytkownika i sprawić, że będzie wyglądało na jaśniejsze.

```html
<input class="form-control" id="disabledInput" type="text" placeholder="Disabled input here..." disabled>
```

Dodaj atrybut `disabled` do `<fieldset>`, aby wyłączyć wszystkie kontrolki w jego obrębie. Przeglądarki traktują wszystkie natywne kontrolki formularzy (`<input>`, `<select>` i `<button>`) wewnątrz `<fieldset disabled>` jako wyłączone, uniemożliwiając zarówno interakcję klawiatury, jak i myszki.

Jednak jeśli formularz zawiera niestandardowe elementy przypominające przyciski, np. `<a class="btn btn-*">...</a>`, te elementy otrzymają jedynie styl `pointer-events: none`, co oznacza, że nadal są możliwe do ustawienia fokusu i obsługi klawiatury. W tym przypadku należy ręcznie zmodyfikować te kontrolki, dodając `tabindex="-1"` oraz `aria-disabled="disabled"`.

<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
    &lt;style&gt;
        body { padding: 1rem; background-color: #fff; }
        .dropdown-menu { position: absolute !important; }
        .bd-example { margin: 0; border: none; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body&gt;
     &lt;form&gt;
&lt;fieldset disabled=&quot;&quot;&gt;
&lt;legend&gt;Disabled fieldset example&lt;/legend&gt;
&lt;div class=&quot;mb-3&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;disabledTextInput&quot;&gt;Disabled input&lt;/label&gt;
&lt;input class=&quot;form-control&quot; id=&quot;disabledTextInput&quot; placeholder=&quot;Disabled input&quot; type=&quot;text&quot;/&gt;
&lt;/div&gt;
&lt;div class=&quot;mb-3&quot;&gt;
&lt;label class=&quot;form-label&quot; for=&quot;disabledSelect&quot;&gt;Disabled select menu&lt;/label&gt;
&lt;select class=&quot;form-select&quot; id=&quot;disabledSelect&quot;&gt;
&lt;option&gt;Disabled select&lt;/option&gt;
&lt;/select&gt;
&lt;/div&gt;
&lt;div class=&quot;mb-3&quot;&gt;
&lt;div class=&quot;form-check&quot;&gt;
&lt;input class=&quot;form-check-input&quot; disabled=&quot;&quot; id=&quot;disabledFieldsetCheck&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;disabledFieldsetCheck&quot;&gt;
          Can’t check this
        &lt;/label&gt;
&lt;/div&gt;
&lt;/div&gt;
&lt;button class=&quot;btn btn-primary&quot; type=&quot;submit&quot;&gt;Submit&lt;/button&gt;
&lt;/fieldset&gt;
&lt;/form&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<form>
  <fieldset disabled>
    <legend>Disabled fieldset example</legend>
    <div class="mb-3">
      <label for="disabledTextInput" class="form-label">Disabled input</label>
      <input type="text" id="disabledTextInput" class="form-control" placeholder="Disabled input">
    </div>
    <div class="mb-3">
      <label for="disabledSelect" class="form-label">Disabled select menu</label>
      <select id="disabledSelect" class="form-select">
        <option>Disabled select</option>
      </select>
    </div>
    <div class="mb-3">
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="disabledFieldsetCheck" disabled>
        <label class="form-check-label" for="disabledFieldsetCheck">
          Can’t check this
        </label>
      </div>
    </div>
    <button type="submit" class="btn btn-primary">Submit</button>
  </fieldset>
</form>
```

## Dostępność

Upewnij się, że wszystkie kontrolki formularzy mają odpowiednią nazwę dostępną dla technologii wspomagających, aby ich przeznaczenie mogło być przekazane użytkownikom. Najprostszym sposobem jest użycie elementu `<label>` lub – w przypadku przycisków – umieszczenie wystarczająco opisowego tekstu w `<button>...</button>`.

Jeżeli nie można użyć widocznego `<label>` lub odpowiedniego tekstu, są alternatywne sposoby zapewnienia dostępnej nazwy:

* `<label>` ukryty przy użyciu klasy `.visually-hidden`
* Odniesienie do istniejącego elementu jako etykiety za pomocą `aria-labelledby`
* Dodanie atrybutu `title`
* Ręczne ustawienie dostępnej nazwy na elemencie za pomocą `aria-label`

Jeśli żadna z powyższych metod nie jest zastosowana, technologie wspomagające mogą użyć atrybutu `placeholder` jako nazwy dostępnej dla `<input>` i `<textarea>`. Zaleca się jednak stosowanie widocznych etykiet dla lepszej dostępności i użyteczności.

## CSS

Wiele zmiennych formularzy jest ustawionych na poziomie ogólnym, aby mogły być używane i rozszerzane przez poszczególne komponenty formularzy. Najczęściej spotkasz je jako `$input-btn-*` i `$input-*`.

### Zmienne Sass

Zmienne `$input-btn-*` są współdzielone globalnie między [przyciskami](/docs/5.3/components/buttons) a komponentami formularzy. Często są ponownie przypisywane do zmiennych specyficznych dla komponentów.

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$input-btn-padding-y:         .375rem;
$input-btn-padding-x:         .75rem;
$input-btn-font-family:       null;
$input-btn-font-size:         $font-size-base;
$input-btn-line-height:       $line-height-base;

$input-btn-focus-width:         $focus-ring-width;
$input-btn-focus-color-opacity: $focus-ring-opacity;
$input-btn-focus-color:         $focus-ring-color;
$input-btn-focus-blur:          $focus-ring-blur;
$input-btn-focus-box-shadow:    $focus-ring-box-shadow;

$input-btn-padding-y-sm:      .25rem;
$input-btn-padding-x-sm:      .5rem;
$input-btn-font-size-sm:      $font-size-sm;

$input-btn-padding-y-lg:      .5rem;
$input-btn-padding-x-lg:      1rem;
$input-btn-font-size-lg:      $font-size-lg;

$input-btn-border-width:      var(--#{$prefix}border-width);
```


