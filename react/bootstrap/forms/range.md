Powrót -> [Start](./root.md)

> Źródło: [https://getbootstrap.com/docs/5.3/forms/range](https://getbootstrap.com/docs/5.3/forms/range)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/forms/range.mdx "View and edit this file on GitHub")

# Suwak (Range)

Używaj naszych niestandardowych suwaków (`range input`) dla spójnego stylu w różnych przeglądarkach i wbudowanej możliwości dostosowania.

**Na tej stronie**

* [Przegląd](#overview)
* [Wyłączone](#disabled)
* [Minimalna i maksymalna wartość](#min-and-max)
* [Kroki](#steps)
* [Wyświetlanie wartości](#output-value)
* [CSS](#css)
  + [Zmienne Sass](#sass-variables)

## Przegląd

Twórz niestandardowe kontrolki `<input type="range">` z klasą `.form-range`. Tor (tło) i uchwyt (thumb, wartość) są stylizowane tak, aby wyglądały tak samo w różnych przeglądarkach. Ponieważ tylko Firefox wspiera wypełnianie toru od lewej lub prawej strony uchwytu w celu wizualnego wskazania postępu, obecnie nie wspieramy tej funkcjonalności.

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
     &lt;label class=&quot;form-label&quot; for=&quot;range1&quot;&gt;Example range&lt;/label&gt;
&lt;input class=&quot;form-range&quot; id=&quot;range1&quot; type=&quot;range&quot;/&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<label for="range1" class="form-label">Example range</label>
<input type="range" class="form-range" id="range1">
```

## Wyłączone

Dodaj atrybut `disabled` do inputa, aby nadać mu wygląd przyciemniony, usunąć zdarzenia wskaźnika i uniemożliwić ustawienie fokusu.

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
     &lt;label class=&quot;form-label&quot; for=&quot;disabledRange&quot;&gt;Disabled range&lt;/label&gt;
&lt;input class=&quot;form-range&quot; disabled=&quot;&quot; id=&quot;disabledRange&quot; type=&quot;range&quot;/&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<label for="disabledRange" class="form-label">Disabled range</label>
<input type="range" class="form-range" id="disabledRange" disabled>
```

## Minimalna i maksymalna wartość

Suwaki mają domyślne wartości `min` i `max` — odpowiednio `0` i `100`. Możesz określić nowe wartości za pomocą atrybutów `min` i `max`.

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
     &lt;label class=&quot;form-label&quot; for=&quot;range2&quot;&gt;Example range&lt;/label&gt;
&lt;input class=&quot;form-range&quot; id=&quot;range2&quot; max=&quot;5&quot; min=&quot;0&quot; type=&quot;range&quot;/&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<label for="range2" class="form-label">Example range</label>
<input type="range" class="form-range" min="0" max="5" id="range2">
```

## Kroki

Domyślnie suwaki „przyciągają się” do wartości całkowitych. Aby zmienić ten sposób, możesz ustawić wartość `step`. W poniższym przykładzie zwiększamy liczbę kroków, używając `step="0.5"`.

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
     &lt;label class=&quot;form-label&quot; for=&quot;range3&quot;&gt;Example range&lt;/label&gt;
&lt;input class=&quot;form-range&quot; id=&quot;range3&quot; max=&quot;5&quot; min=&quot;0&quot; step=&quot;0.5&quot; type=&quot;range&quot;/&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<label for="range3" class="form-label">Example range</label>
<input type="range" class="form-range" min="0" max="5" step="0.5" id="range3">
```

## Wyświetlanie wartości

Wartość suwaka można wyświetlić za pomocą elementu `output` i niewielkiego skryptu JavaScript.


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
     &lt;label class=&quot;form-label&quot; for=&quot;range4&quot;&gt;Example range&lt;/label&gt;
&lt;input class=&quot;form-range&quot; id=&quot;range4&quot; max=&quot;100&quot; min=&quot;0&quot; type=&quot;range&quot; value=&quot;50&quot;/&gt;
&lt;output aria-hidden=&quot;true&quot; for=&quot;range4&quot; id=&quot;rangeValue&quot;&gt;&lt;/output&gt;
&lt;script&gt;
  // This is an example script, please modify as needed
  const rangeInput = document.getElementById(&#x27;range4&#x27;);
  const rangeOutput = document.getElementById(&#x27;rangeValue&#x27;);

  // Set initial value
  rangeOutput.textContent = rangeInput.value;

  rangeInput.addEventListener(&#x27;input&#x27;, function() {
    rangeOutput.textContent = this.value;
  });
&lt;/script&gt; 
&lt;/body&gt;
&lt;/html&gt;
"></iframe>
<br>

html

```html
<label for="range4" class="form-label">Example range</label>
<input type="range" class="form-range" min="0" max="100" value="50" id="range4">
<output for="range4" id="rangeValue" aria-hidden="true"></output>

<script>
  // This is an example script, please modify as needed
  const rangeInput = document.getElementById('range4');
  const rangeOutput = document.getElementById('rangeValue');

  // Set initial value
  rangeOutput.textContent = rangeInput.value;

  rangeInput.addEventListener('input', function() {
    rangeOutput.textContent = this.value;
  });
</script>
```

## CSS

### Zmienne Sass

[scss/\_variables.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_variables.scss)

```html
$form-range-track-width:          100%;
$form-range-track-height:         .5rem;
$form-range-track-cursor:         pointer;
$form-range-track-bg:             var(--#{$prefix}secondary-bg);
$form-range-track-border-radius:  1rem;
$form-range-track-box-shadow:     var(--#{$prefix}box-shadow-inset);

$form-range-thumb-width:                   1rem;
$form-range-thumb-height:                  $form-range-thumb-width;
$form-range-thumb-bg:                      $component-active-bg;
$form-range-thumb-border:                  0;
$form-range-thumb-border-radius:           1rem;
$form-range-thumb-box-shadow:              0 .1rem .25rem rgba($black, .1);
$form-range-thumb-focus-box-shadow:        0 0 0 1px $body-bg, $input-focus-box-shadow;
$form-range-thumb-focus-box-shadow-width:  $input-focus-width; // For focus box shadow issue in Edge
$form-range-thumb-active-bg:               tint-color($component-active-bg, 70%);
$form-range-thumb-disabled-bg:             var(--#{$prefix}secondary-color);
$form-range-thumb-transition:              background-color .15s ease-in-out, border-color .15s ease-in-out, box-shadow .15s ease-in-out;
```


