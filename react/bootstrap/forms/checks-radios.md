# Checks and radios

Twórz spójne checkboxy i przyciski radiowe działające we wszystkich przeglądarkach i na wszystkich urządzeniach dzięki całkowicie przebudowanemu komponentowi checks w Bootstrapie.

Na tej stronie
   
**Na tej stronie**

---

* [Approach](#approach)
* [Checks](#checks)
  + [Indeterminate](#indeterminate)
  + [Disabled](#disabled)
* [Radios](#radios)
  + [Disabled](#disabled-1)
* [Switches](#switches)
  + [Native switches](#native-switches)
* [Default (stacked)](#default-stacked)
* [Inline](#inline)
* [Reverse](#reverse)
* [Without labels](#without-labels)
* [Toggle buttons](#toggle-buttons)
  + [Checkbox toggle buttons](#checkbox-toggle-buttons)
  + [Radio toggle buttons](#radio-toggle-buttons)
  + [Outlined styles](#outlined-styles)
* [CSS](#css)
  + [Sass variables](#sass-variables)

## Approach

Domyślne checkboxy i przyciski radiowe przeglądarki są zastępowane za pomocą klasy `.form-check`,- zestawu klas dla obu typów pól, który poprawia układ i zachowanie elementów HTML oraz zapewnia większe możliwości personalizacji i spójność między przeglądarkami.

Checkboxy służą do wyboru jednej lub wielu opcji z listy, natomiast przyciski radiowe pozwalają wybrać jedną opcję spośród wielu.

Strukturalnie elementy `<input>`s and `<label>`ssą rodzeństwem (sibling elements), a nie `<input>` umieszczonym wewnątrz `<label>`. Wymaga to jawnego użycia atrybutów `id` i `for`  aby powiązać je ze sobą. Bootstrap wykorzystuje selektor rodzeństwa (`~`) do obsługi stanów takich jak `:checked` czy `:disabled`. Po połączeniu z klasą `.form-check-label` możliwe jest łatwe stylowanie tekstu etykiety w zależności od stanu pola.

Checkboxy używają niestandardowych ikon Bootstrap do oznaczania stanu zaznaczonego lub nieokreślonego.

## Checks

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
     &lt;div class=&quot;form-check&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;checkDefault&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;checkDefault&quot;&gt;
    Default checkbox
  &lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check&quot;&gt;
&lt;input checked=&quot;&quot; class=&quot;form-check-input&quot; id=&quot;checkChecked&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;checkChecked&quot;&gt;
    Checked checkbox
  &lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="form-check">
  <input class="form-check-input" type="checkbox" value="" id="checkDefault">
  <label class="form-check-label" for="checkDefault">
    Default checkbox
  </label>
</div>
<div class="form-check">
  <input class="form-check-input" type="checkbox" value="" id="checkChecked" checked>
  <label class="form-check-label" for="checkChecked">
    Checked checkbox
  </label>
</div>
```

### Indeterminate

Checkboxy mogą używać pseudoklasy `:indeterminate` , jeśli stan ten zostanie ustawiony ręcznie za pomocą JavaScriptu (HTML nie posiada atrybutu do jego określenia).

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
     &lt;div class=&quot;form-check&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;checkIndeterminate&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;checkIndeterminate&quot;&gt;
    Indeterminate checkbox
  &lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="form-check">
  <input class="form-check-input" type="checkbox" value="" id="checkIndeterminate">
  <label class="form-check-label" for="checkIndeterminate">
    Indeterminate checkbox
  </label>
</div>
```

### Disabled

Dodanie atrybutu `disabled` powoduje automatyczne zastosowanie jaśniejszego stylu dla powiązanej etykiety `<label>`aby wizualnie wskazać, że pole jest nieaktywne.
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
     &lt;div class=&quot;form-check&quot;&gt;
&lt;input class=&quot;form-check-input&quot; disabled=&quot;&quot; id=&quot;checkIndeterminateDisabled&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;checkIndeterminateDisabled&quot;&gt;
    Disabled indeterminate checkbox
  &lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check&quot;&gt;
&lt;input class=&quot;form-check-input&quot; disabled=&quot;&quot; id=&quot;checkDisabled&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;checkDisabled&quot;&gt;
    Disabled checkbox
  &lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check&quot;&gt;
&lt;input checked=&quot;&quot; class=&quot;form-check-input&quot; disabled=&quot;&quot; id=&quot;checkCheckedDisabled&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;checkCheckedDisabled&quot;&gt;
    Disabled checked checkbox
  &lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="form-check">
  <input class="form-check-input" type="checkbox" value="" id="checkIndeterminateDisabled" disabled>
  <label class="form-check-label" for="checkIndeterminateDisabled">
    Disabled indeterminate checkbox
  </label>
</div>
<div class="form-check">
  <input class="form-check-input" type="checkbox" value="" id="checkDisabled" disabled>
  <label class="form-check-label" for="checkDisabled">
    Disabled checkbox
  </label>
</div>
<div class="form-check">
  <input class="form-check-input" type="checkbox" value="" id="checkCheckedDisabled" checked disabled>
  <label class="form-check-label" for="checkCheckedDisabled">
    Disabled checked checkbox
  </label>
</div>
```

## Radios
Przyciski radiowe działają podobnie do checkboxów, ale pozwalają wybrać tylko jedną opcję w obrębie tej samej grupy
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
     &lt;div class=&quot;form-check&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;radioDefault1&quot; name=&quot;radioDefault&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;radioDefault1&quot;&gt;
    Default radio
  &lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check&quot;&gt;
&lt;input checked=&quot;&quot; class=&quot;form-check-input&quot; id=&quot;radioDefault2&quot; name=&quot;radioDefault&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;radioDefault2&quot;&gt;
    Default checked radio
  &lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="form-check">
  <input class="form-check-input" type="radio" name="radioDefault" id="radioDefault1">
  <label class="form-check-label" for="radioDefault1">
    Default radio
  </label>
</div>
<div class="form-check">
  <input class="form-check-input" type="radio" name="radioDefault" id="radioDefault2" checked>
  <label class="form-check-label" for="radioDefault2">
    Default checked radio
  </label>
</div>
```

### Disabled

Podobnie jak w przypadku checkboxów, atrybut `disabled` dezaktywuje pole i odpowiednio styluje etykietę.
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
     &lt;div class=&quot;form-check&quot;&gt;
&lt;input class=&quot;form-check-input&quot; disabled=&quot;&quot; id=&quot;radioDisabled&quot; name=&quot;radioDisabled&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;radioDisabled&quot;&gt;
    Disabled radio
  &lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check&quot;&gt;
&lt;input checked=&quot;&quot; class=&quot;form-check-input&quot; disabled=&quot;&quot; id=&quot;radioCheckedDisabled&quot; name=&quot;radioDisabled&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;radioCheckedDisabled&quot;&gt;
    Disabled checked radio
  &lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="form-check">
  <input class="form-check-input" type="radio" name="radioDisabled" id="radioDisabled" disabled>
  <label class="form-check-label" for="radioDisabled">
    Disabled radio
  </label>
</div>
<div class="form-check">
  <input class="form-check-input" type="radio" name="radioDisabled" id="radioCheckedDisabled" checked disabled>
  <label class="form-check-label" for="radioCheckedDisabled">
    Disabled checked radio
  </label>
</div>
```

## Switches

Przełącznik używa tego samego HTML co checkbox, ale z dodatkową klasą `.form-switch` aby wyglądał jak suwak (toggle).

Zaleca się użycie`role="switch"` aby technologie asystujące (np. czytniki ekranu) poprawnie interpretowały charakter kontrolki. W starszych technologiach zostanie ona odczytana jako zwykły checkbox.

Przełączniki również obsługują atrybut `disabled`

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
     &lt;div class=&quot;form-check form-switch&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;switchCheckDefault&quot; role=&quot;switch&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;switchCheckDefault&quot;&gt;Default switch checkbox input&lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check form-switch&quot;&gt;
&lt;input checked=&quot;&quot; class=&quot;form-check-input&quot; id=&quot;switchCheckChecked&quot; role=&quot;switch&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;switchCheckChecked&quot;&gt;Checked switch checkbox input&lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check form-switch&quot;&gt;
&lt;input class=&quot;form-check-input&quot; disabled=&quot;&quot; id=&quot;switchCheckDisabled&quot; role=&quot;switch&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;switchCheckDisabled&quot;&gt;Disabled switch checkbox input&lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check form-switch&quot;&gt;
&lt;input checked=&quot;&quot; class=&quot;form-check-input&quot; disabled=&quot;&quot; id=&quot;switchCheckCheckedDisabled&quot; role=&quot;switch&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;switchCheckCheckedDisabled&quot;&gt;Disabled checked switch checkbox input&lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="form-check form-switch">
  <input class="form-check-input" type="checkbox" role="switch" id="switchCheckDefault">
  <label class="form-check-label" for="switchCheckDefault">Default switch checkbox input</label>
</div>
<div class="form-check form-switch">
  <input class="form-check-input" type="checkbox" role="switch" id="switchCheckChecked" checked>
  <label class="form-check-label" for="switchCheckChecked">Checked switch checkbox input</label>
</div>
<div class="form-check form-switch">
  <input class="form-check-input" type="checkbox" role="switch" id="switchCheckDisabled" disabled>
  <label class="form-check-label" for="switchCheckDisabled">Disabled switch checkbox input</label>
</div>
<div class="form-check form-switch">
  <input class="form-check-input" type="checkbox" role="switch" id="switchCheckCheckedDisabled" checked disabled>
  <label class="form-check-label" for="switchCheckCheckedDisabled">Disabled checked switch checkbox input</label>
</div>
```

### Native switches

Dla mobilnego Safari (iOS 17.4+) można dodać atrybut `switch` aby uzyskać haptyczne sprzężenie zwrotne (wibracje) podobne do natywnych przełączników iOS.

Bootstrap nie zmienia stylu po dodaniu tego atrybutu — wszystkie przełączniki i tak korzystają z własnych stylów.

W Safari 17.4+ (macOS i iOS) natywne przełączniki HTML są obsługiwane, a inne przeglądarki wyświetlą standardowy checkbox.
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
     &lt;div class=&quot;form-check form-switch&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;checkNativeSwitch&quot; switch=&quot;&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;checkNativeSwitch&quot;&gt;
    Native switch haptics
  &lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="form-check form-switch">
  <input class="form-check-input" type="checkbox" value="" id="checkNativeSwitch" switch>
  <label class="form-check-label" for="checkNativeSwitch">
    Native switch haptics
  </label>
</div>
```



## Default (stacked)

Domyślnie checkboxy i przyciski radiowe będą układane pionowo jeden pod drugim, jeśli są bezpośrednimi elementami rodzeństwa z klasą `.form-check`.

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
     &lt;div class=&quot;form-check&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;defaultCheck1&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;defaultCheck1&quot;&gt;
    Default checkbox
  &lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check&quot;&gt;
&lt;input class=&quot;form-check-input&quot; disabled=&quot;&quot; id=&quot;defaultCheck2&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;defaultCheck2&quot;&gt;
    Disabled checkbox
  &lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="form-check">
  <input class="form-check-input" type="checkbox" value="" id="defaultCheck1">
  <label class="form-check-label" for="defaultCheck1">
    Default checkbox
  </label>
</div>
<div class="form-check">
  <input class="form-check-input" type="checkbox" value="" id="defaultCheck2" disabled>
  <label class="form-check-label" for="defaultCheck2">
    Disabled checkbox
  </label>
</div>
```

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
     &lt;div class=&quot;form-check&quot;&gt;
&lt;input checked=&quot;&quot; class=&quot;form-check-input&quot; id=&quot;exampleRadios1&quot; name=&quot;exampleRadios&quot; type=&quot;radio&quot; value=&quot;option1&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;exampleRadios1&quot;&gt;
    Default radio
  &lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;exampleRadios2&quot; name=&quot;exampleRadios&quot; type=&quot;radio&quot; value=&quot;option2&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;exampleRadios2&quot;&gt;
    Second default radio
  &lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check&quot;&gt;
&lt;input class=&quot;form-check-input&quot; disabled=&quot;&quot; id=&quot;exampleRadios3&quot; name=&quot;exampleRadios&quot; type=&quot;radio&quot; value=&quot;option3&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;exampleRadios3&quot;&gt;
    Disabled radio
  &lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="form-check">
  <input class="form-check-input" type="radio" name="exampleRadios" id="exampleRadios1" value="option1" checked>
  <label class="form-check-label" for="exampleRadios1">
    Default radio
  </label>
</div>
<div class="form-check">
  <input class="form-check-input" type="radio" name="exampleRadios" id="exampleRadios2" value="option2">
  <label class="form-check-label" for="exampleRadios2">
    Second default radio
  </label>
</div>
<div class="form-check">
  <input class="form-check-input" type="radio" name="exampleRadios" id="exampleRadios3" value="option3" disabled>
  <label class="form-check-label" for="exampleRadios3">
    Disabled radio
  </label>
</div>
```

## Inline

Aby umieścić checkboxy lub przyciski radiowe w jednej linii poziomej, dodaj klasę `.form-check-inline` do`.form-check`.

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
     &lt;div class=&quot;form-check form-check-inline&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;inlineCheckbox1&quot; type=&quot;checkbox&quot; value=&quot;option1&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;inlineCheckbox1&quot;&gt;1&lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check form-check-inline&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;inlineCheckbox2&quot; type=&quot;checkbox&quot; value=&quot;option2&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;inlineCheckbox2&quot;&gt;2&lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check form-check-inline&quot;&gt;
&lt;input class=&quot;form-check-input&quot; disabled=&quot;&quot; id=&quot;inlineCheckbox3&quot; type=&quot;checkbox&quot; value=&quot;option3&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;inlineCheckbox3&quot;&gt;3 (disabled)&lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="form-check form-check-inline">
  <input class="form-check-input" type="checkbox" id="inlineCheckbox1" value="option1">
  <label class="form-check-label" for="inlineCheckbox1">1</label>
</div>
<div class="form-check form-check-inline">
  <input class="form-check-input" type="checkbox" id="inlineCheckbox2" value="option2">
  <label class="form-check-label" for="inlineCheckbox2">2</label>
</div>
<div class="form-check form-check-inline">
  <input class="form-check-input" type="checkbox" id="inlineCheckbox3" value="option3" disabled>
  <label class="form-check-label" for="inlineCheckbox3">3 (disabled)</label>
</div>
```

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
     &lt;div class=&quot;form-check form-check-inline&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;inlineRadio1&quot; name=&quot;inlineRadioOptions&quot; type=&quot;radio&quot; value=&quot;option1&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;inlineRadio1&quot;&gt;1&lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check form-check-inline&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;inlineRadio2&quot; name=&quot;inlineRadioOptions&quot; type=&quot;radio&quot; value=&quot;option2&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;inlineRadio2&quot;&gt;2&lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check form-check-inline&quot;&gt;
&lt;input class=&quot;form-check-input&quot; disabled=&quot;&quot; id=&quot;inlineRadio3&quot; name=&quot;inlineRadioOptions&quot; type=&quot;radio&quot; value=&quot;option3&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;inlineRadio3&quot;&gt;3 (disabled)&lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="form-check form-check-inline">
  <input class="form-check-input" type="radio" name="inlineRadioOptions" id="inlineRadio1" value="option1">
  <label class="form-check-label" for="inlineRadio1">1</label>
</div>
<div class="form-check form-check-inline">
  <input class="form-check-input" type="radio" name="inlineRadioOptions" id="inlineRadio2" value="option2">
  <label class="form-check-label" for="inlineRadio2">2</label>
</div>
<div class="form-check form-check-inline">
  <input class="form-check-input" type="radio" name="inlineRadioOptions" id="inlineRadio3" value="option3" disabled>
  <label class="form-check-label" for="inlineRadio3">3 (disabled)</label>
</div>
```

## Reverse

Użyj klasy `.form-check-reverse` aby przenieść checkboxy, przyciski radiowe lub przełączniki na przeciwną stronę względem etykiety.

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
     &lt;div class=&quot;form-check form-check-reverse&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;reverseCheck1&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;reverseCheck1&quot;&gt;
    Reverse checkbox
  &lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check form-check-reverse&quot;&gt;
&lt;input class=&quot;form-check-input&quot; disabled=&quot;&quot; id=&quot;reverseCheck2&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;reverseCheck2&quot;&gt;
    Disabled reverse checkbox
  &lt;/label&gt;
&lt;/div&gt;
&lt;div class=&quot;form-check form-switch form-check-reverse&quot;&gt;
&lt;input class=&quot;form-check-input&quot; id=&quot;switchCheckReverse&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;form-check-label&quot; for=&quot;switchCheckReverse&quot;&gt;Reverse switch checkbox input&lt;/label&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div class="form-check form-check-reverse">
  <input class="form-check-input" type="checkbox" value="" id="reverseCheck1">
  <label class="form-check-label" for="reverseCheck1">
    Reverse checkbox
  </label>
</div>
<div class="form-check form-check-reverse">
  <input class="form-check-input" type="checkbox" value="" id="reverseCheck2" disabled>
  <label class="form-check-label" for="reverseCheck2">
    Disabled reverse checkbox
  </label>
</div>

<div class="form-check form-switch form-check-reverse">
  <input class="form-check-input" type="checkbox" id="switchCheckReverse">
  <label class="form-check-label" for="switchCheckReverse">Reverse switch checkbox input</label>
</div>
```

## Without labels

Jeśli checkbox lub radio nie ma tekstowej etykiety, pomiń `.form-check` **Pamiętaj jednak o dostępności** — należy zapewnić nazwę dostępną dla czytników ekranu, np. za pomocą  `aria-label`.

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
     &lt;div&gt;
&lt;input aria-label=&quot;...&quot; class=&quot;form-check-input&quot; id=&quot;checkboxNoLabel&quot; type=&quot;checkbox&quot; value=&quot;&quot;/&gt;
&lt;/div&gt;
&lt;div&gt;
&lt;input aria-label=&quot;...&quot; class=&quot;form-check-input&quot; id=&quot;radioNoLabel1&quot; name=&quot;radioNoLabel&quot; type=&quot;radio&quot; value=&quot;&quot;/&gt;
&lt;/div&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<div>
  <input class="form-check-input" type="checkbox" id="checkboxNoLabel" value="" aria-label="...">
</div>

<div>
  <input class="form-check-input" type="radio" name="radioNoLabel" id="radioNoLabel1" value="" aria-label="...">
</div>
```

## Toggle buttons

Można tworzyć checkboxy i przyciski radiowe wyglądające jak przyciski, używając klas `.btn` zamiast `.form-check-label`.
Takie przyciski można grupować przy użyciu komponentu Button group.

### Checkbox toggle buttons

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
     &lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; id=&quot;btn-check&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;btn btn-primary&quot; for=&quot;btn-check&quot;&gt;Single toggle&lt;/label&gt;
&lt;input autocomplete=&quot;off&quot; checked=&quot;&quot; class=&quot;btn-check&quot; id=&quot;btn-check-2&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;btn btn-primary&quot; for=&quot;btn-check-2&quot;&gt;Checked&lt;/label&gt;
&lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; disabled=&quot;&quot; id=&quot;btn-check-3&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;btn btn-primary&quot; for=&quot;btn-check-3&quot;&gt;Disabled&lt;/label&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<input type="checkbox" class="btn-check" id="btn-check" autocomplete="off">
<label class="btn btn-primary" for="btn-check">Single toggle</label>

<input type="checkbox" class="btn-check" id="btn-check-2" checked autocomplete="off">
<label class="btn btn-primary" for="btn-check-2">Checked</label>

<input type="checkbox" class="btn-check" id="btn-check-3" autocomplete="off" disabled>
<label class="btn btn-primary" for="btn-check-3">Disabled</label>
```

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
     &lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; id=&quot;btn-check-4&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;btn&quot; for=&quot;btn-check-4&quot;&gt;Single toggle&lt;/label&gt;
&lt;input autocomplete=&quot;off&quot; checked=&quot;&quot; class=&quot;btn-check&quot; id=&quot;btn-check-5&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;btn&quot; for=&quot;btn-check-5&quot;&gt;Checked&lt;/label&gt;
&lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; disabled=&quot;&quot; id=&quot;btn-check-6&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;btn&quot; for=&quot;btn-check-6&quot;&gt;Disabled&lt;/label&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<input type="checkbox" class="btn-check" id="btn-check-4" autocomplete="off">
<label class="btn" for="btn-check-4">Single toggle</label>

<input type="checkbox" class="btn-check" id="btn-check-5" checked autocomplete="off">
<label class="btn" for="btn-check-5">Checked</label>

<input type="checkbox" class="btn-check" id="btn-check-6" autocomplete="off" disabled>
<label class="btn" for="btn-check-6">Disabled</label>
```

Checkboxy zachowują się logicznie jak checkboxy, ale wizualnie wyglądają jak przyciski.



### Radio toggle buttons
Działają jak klasyczne przyciski radiowe — tylko jedna opcja może być aktywna w grupie.
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
     &lt;input autocomplete=&quot;off&quot; checked=&quot;&quot; class=&quot;btn-check&quot; id=&quot;option1&quot; name=&quot;options&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;btn btn-secondary&quot; for=&quot;option1&quot;&gt;Checked&lt;/label&gt;
&lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; id=&quot;option2&quot; name=&quot;options&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;btn btn-secondary&quot; for=&quot;option2&quot;&gt;Radio&lt;/label&gt;
&lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; disabled=&quot;&quot; id=&quot;option3&quot; name=&quot;options&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;btn btn-secondary&quot; for=&quot;option3&quot;&gt;Disabled&lt;/label&gt;
&lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; id=&quot;option4&quot; name=&quot;options&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;btn btn-secondary&quot; for=&quot;option4&quot;&gt;Radio&lt;/label&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<input type="radio" class="btn-check" name="options" id="option1" autocomplete="off" checked>
<label class="btn btn-secondary" for="option1">Checked</label>

<input type="radio" class="btn-check" name="options" id="option2" autocomplete="off">
<label class="btn btn-secondary" for="option2">Radio</label>

<input type="radio" class="btn-check" name="options" id="option3" autocomplete="off" disabled>
<label class="btn btn-secondary" for="option3">Disabled</label>

<input type="radio" class="btn-check" name="options" id="option4" autocomplete="off">
<label class="btn btn-secondary" for="option4">Radio</label>
```

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
     &lt;input autocomplete=&quot;off&quot; checked=&quot;&quot; class=&quot;btn-check&quot; id=&quot;option5&quot; name=&quot;options-base&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;btn&quot; for=&quot;option5&quot;&gt;Checked&lt;/label&gt;
&lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; id=&quot;option6&quot; name=&quot;options-base&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;btn&quot; for=&quot;option6&quot;&gt;Radio&lt;/label&gt;
&lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; disabled=&quot;&quot; id=&quot;option7&quot; name=&quot;options-base&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;btn&quot; for=&quot;option7&quot;&gt;Disabled&lt;/label&gt;
&lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; id=&quot;option8&quot; name=&quot;options-base&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;btn&quot; for=&quot;option8&quot;&gt;Radio&lt;/label&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<input type="radio" class="btn-check" name="options-base" id="option5" autocomplete="off" checked>
<label class="btn" for="option5">Checked</label>

<input type="radio" class="btn-check" name="options-base" id="option6" autocomplete="off">
<label class="btn" for="option6">Radio</label>

<input type="radio" class="btn-check" name="options-base" id="option7" autocomplete="off" disabled>
<label class="btn" for="option7">Disabled</label>

<input type="radio" class="btn-check" name="options-base" id="option8" autocomplete="off">
<label class="btn" for="option8">Radio</label>
```

### Outlined styles

Obsługiwane są wszystkie warianty `.btn`, w tym style obrysowane `btn-outline-*`

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
     &lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; id=&quot;btn-check-outlined&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;btn btn-outline-primary&quot; for=&quot;btn-check-outlined&quot;&gt;Single toggle&lt;/label&gt;&lt;br/&gt;
&lt;input autocomplete=&quot;off&quot; checked=&quot;&quot; class=&quot;btn-check&quot; id=&quot;btn-check-2-outlined&quot; type=&quot;checkbox&quot;/&gt;
&lt;label class=&quot;btn btn-outline-secondary&quot; for=&quot;btn-check-2-outlined&quot;&gt;Checked&lt;/label&gt;&lt;br/&gt;
&lt;input autocomplete=&quot;off&quot; checked=&quot;&quot; class=&quot;btn-check&quot; id=&quot;success-outlined&quot; name=&quot;options-outlined&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;btn btn-outline-success&quot; for=&quot;success-outlined&quot;&gt;Checked success radio&lt;/label&gt;
&lt;input autocomplete=&quot;off&quot; class=&quot;btn-check&quot; id=&quot;danger-outlined&quot; name=&quot;options-outlined&quot; type=&quot;radio&quot;/&gt;
&lt;label class=&quot;btn btn-outline-danger&quot; for=&quot;danger-outlined&quot;&gt;Danger radio&lt;/label&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<input type="checkbox" class="btn-check" id="btn-check-outlined" autocomplete="off">
<label class="btn btn-outline-primary" for="btn-check-outlined">Single toggle</label><br>

<input type="checkbox" class="btn-check" id="btn-check-2-outlined" checked autocomplete="off">
<label class="btn btn-outline-secondary" for="btn-check-2-outlined">Checked</label><br>

<input type="radio" class="btn-check" name="options-outlined" id="success-outlined" autocomplete="off" checked>
<label class="btn btn-outline-success" for="success-outlined">Checked success radio</label>

<input type="radio" class="btn-check" name="options-outlined" id="danger-outlined" autocomplete="off">
<label class="btn btn-outline-danger" for="danger-outlined">Danger radio</label>
```



