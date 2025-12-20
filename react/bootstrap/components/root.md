Powrót -> [Start](../../root.md) | [Bootstrap](../root.md)

# Alerts
to komponent służący do wyświetlania komunikatów dla użytkownika, takich jak informacja, sukces, ostrzeżenie lub błąd. Najczęściej używa się go do pokazania wyniku jakiejś akcji, np. zapisania danych albo wystąpienia błędu. Każdy alert musi mieć klasę alert oraz dodatkową klasę określającą jego rodzaj, np. alert-success (sukces), alert-danger (błąd), alert-warning (ostrzeżenie) lub alert-info (informacja). Podstawowy alert wygląda tak:
```html
<div class="alert alert-success" role="alert">
  Dane zapisane poprawnie!
</div>
```
Do alertu można dodawać linki (z klasą alert-link), nagłówki, paragrafy oraz linie oddzielające, co pozwala wyświetlać bardziej rozbudowane komunikaty. Alert może być także zamykany przez użytkownika – w tym celu dodaje się klasy alert-dismissible, fade i show oraz przycisk z klasą btn-close i atrybutem data-bs-dismiss="alert". Przykład zamykanego alertu:

<br>
<iframe width="100%" height="200" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;alert alert-success&quot; role=&quot;alert&quot;&gt;
      Dane zapisane poprawnie!
    &lt;/div&gt;
    &lt;div class=&quot;alert alert-danger alert-dismissible fade show&quot; role=&quot;alert&quot;&gt;
      Błąd logowania!
      &lt;button type=&quot;button&quot; class=&quot;btn-close&quot; data-bs-dismiss=&quot;alert&quot; aria-label=&quot;Close&quot;&gt;&lt;/button&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="alert alert-danger alert-dismissible fade show" role="alert">
  Błąd logowania!
  <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
</div>
```
# BUTTONS
to komponent służący do wywoływania akcji (np. wysyłanie formularzy, otwieranie modali, nawigacja). Każdy przycisk musi mieć klasę .btn, która nadaje podstawowy styl, oraz dodatkową klasę wariantu określającą wygląd i znaczenie, np. .btn-primary, .btn-success, .btn-danger. Dostępne są także przyciski obrysowane .btn-outline-*, które nie mają wypełnienia i są używane do mniej istotnych akcji. Rozmiar przycisku można zmienić klasami .btn-lg (duży) i .btn-sm (mały). Przycisk można wyłączyć za pomocą atrybutu disabled (dla `<button>`) lub klasy .disabled i aria-disabled="true" (dla `<a>`). Bootstrap pozwala stosować przyciski nie tylko jako `<button>`, ale także jako `<a>` i `<input>`. Przyciski na całą szerokość kontenera tworzy się najczęściej przez d-grid. Dostępne są też przyciski przełączane (toggle), które zmieniają stan po kliknięciu dzięki data-bs-toggle="button".
<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;mb-2&quot;&gt;
        &lt;button class=&quot;btn btn-primary&quot;&gt;Primary&lt;/button&gt;
        &lt;button class=&quot;btn btn-outline-secondary btn-sm&quot;&gt;Anuluj&lt;/button&gt;
        &lt;button class=&quot;btn btn-success btn-lg&quot;&gt;Zapisz&lt;/button&gt;
        &lt;button class=&quot;btn btn-danger&quot; disabled&gt;Usuń&lt;/button&gt;
    &lt;/div&gt;

    &lt;div class=&quot;d-grid gap-2 mt-2&quot;&gt;
      &lt;button class=&quot;btn btn-primary&quot;&gt;Przycisk blokowy&lt;/button&gt;
    &lt;/div&gt;
    
    &lt;button class=&quot;btn btn-primary mt-2&quot; data-bs-toggle=&quot;button&quot;&gt;
      Toggle
    &lt;/button&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<button class="btn btn-primary">Primary</button>
<button class="btn btn-outline-secondary btn-sm">Anuluj</button>
<button class="btn btn-success btn-lg">Zapisz</button>
<button class="btn btn-danger" disabled>Usuń</button>

<div class="d-grid gap-2 mt-2">
  <button class="btn btn-primary">Przycisk blokowy</button>
</div>

<button class="btn btn-primary mt-2" data-bs-toggle="button">
  Toggle
</button>
```
# BUTTON GROUP
grupuje kilka przycisków w jedną całość (poziomo lub pionowo), dzięki czemu wyglądają i działają jak jeden komponent.

Najważniejsze klasy:
.btn-group – grupa przycisków (pozioma)
.btn-group-vertical – grupa pionowa
.btn – pojedynczy przycisk
.btn-outline-* – przyciski z obramowaniem
.btn-group-sm / .btn-group-lg – rozmiar grupy
role="group" + aria-label – dostępność (ważne na egzamin)
## Przykład prostego kodu
<br>
<iframe width="100%" height="150" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;btn-group&quot; role=&quot;group&quot; aria-label=&quot;Przykladowa grupa&quot;&gt;
      &lt;button type=&quot;button&quot; class=&quot;btn btn-primary&quot;&gt;Lewy&lt;/button&gt;
      &lt;button type=&quot;button&quot; class=&quot;btn btn-primary&quot;&gt;Środek&lt;/button&gt;
      &lt;button type=&quot;button&quot; class=&quot;btn btn-primary&quot;&gt;Prawy&lt;/button&gt;
    &lt;/div&gt;
    
    &lt;div class=&quot;btn-group btn-group-sm mt-2&quot; role=&quot;group&quot; aria-label=&quot;Grupa outline&quot;&gt;
      &lt;button class=&quot;btn btn-outline-secondary&quot;&gt;1&lt;/button&gt;
      &lt;button class=&quot;btn btn-outline-secondary&quot;&gt;2&lt;/button&gt;
      &lt;button class=&quot;btn btn-outline-secondary&quot;&gt;3&lt;/button&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="btn-group" role="group" aria-label="Przykladowa grupa">
  <button type="button" class="btn btn-primary">Lewy</button>
  <button type="button" class="btn btn-primary">Środek</button>
  <button type="button" class="btn btn-primary">Prawy</button>
</div>
```
## Przykład z obramowaniem i rozmiarem
```html 
<div class="btn-group btn-group-sm" role="group" aria-label="Grupa outline">
  <button class="btn btn-outline-secondary">1</button>
  <button class="btn btn-outline-secondary">2</button>
  <button class="btn btn-outline-secondary">3</button>
</div>
```
# CARD
o uniwersalny komponent służący do wyświetlania treści w estetycznym „kafelku”. Używa się go do prezentowania informacji takich jak tytuł, opis, obrazek, lista czy przyciski (np. karta produktu, posta, użytkownika). Podstawą jest kontener .card, a zawartość umieszcza się w .card-body. Card może mieć nagłówek (.card-header), stopkę (.card-footer), obraz (.card-img-top) oraz przyciski i linki. Jest responsywny i łatwy do stylowania klasami Bootstrapa.
## Najprostszy przykład
<br>
<iframe width="100%" height="450" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;card mb-3&quot; style=&quot;width: 18rem;&quot;&gt;
      &lt;div class=&quot;card-body&quot;&gt;
        &lt;h5 class=&quot;card-title&quot;&gt;Tytuł karty&lt;/h5&gt;
        &lt;p class=&quot;card-text&quot;&gt;Krótki opis zawartości karty.&lt;/p&gt;
        &lt;a href=&quot;#&quot; class=&quot;btn btn-primary&quot;&gt;Akcja&lt;/a&gt;
      &lt;/div&gt;
    &lt;/div&gt;

    &lt;div class=&quot;card&quot; style=&quot;width: 18rem;&quot;&gt;
      &lt;svg class=&quot;bd-placeholder-img card-img-top&quot; width=&quot;100%&quot; height=&quot;180&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot; role=&quot;img&quot; aria-label=&quot;Placeholder: Image cap&quot; preserveAspectRatio=&quot;xMidYMid slice&quot; focusable=&quot;false&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect width=&quot;100%&quot; height=&quot;100%&quot; fill=&quot;#868e96&quot;&gt;&lt;/rect&gt;&lt;text x=&quot;50%&quot; y=&quot;50%&quot; fill=&quot;#dee2e6&quot; dy=&quot;.3em&quot;&gt;Image cap&lt;/text&gt;&lt;/svg&gt;
      &lt;div class=&quot;card-body&quot;&gt;
        &lt;h5 class=&quot;card-title&quot;&gt;Produkt&lt;/h5&gt;
        &lt;p class=&quot;card-text&quot;&gt;Opis produktu i obrazek powyżej.&lt;/p&gt;
      &lt;/div&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="card" style="width: 18rem;">
  <div class="card-body">
    <h5 class="card-title">Tytuł karty</h5>
    <p class="card-text">Krótki opis zawartości karty.</p>
    <a href="#" class="btn btn-primary">Akcja</a>
  </div>
</div>
```
## Card z obrazkiem
```html
<div class="card" style="width: 18rem;">
  <img src="img.jpg" class="card-img-top" alt="obrazek">
  <div class="card-body">
    <h5 class="card-title">Produkt</h5>
    <p class="card-text">Opis produktu.</p>
  </div>
</div>
```
# Carousel
tCarousel służy do wyświetlania serii slajdów (obrazów, tekstów lub dowolnego HTML-a) w jednym miejscu. Slajdy mogą zmieniać się automatycznie albo po kliknięciu przycisków.

Jak działa:
.carousel – główny kontener,
.carousel-inner – przechowuje slajdy,
.carousel-item – pojedynczy slajd,
jeden slajd MUSI mieć .active, inaczej nic się nie wyświetli,
przyciski carousel-control-prev/next sterują zmianą slajdów,
JavaScript Bootstrapa obsługuje animacje i zdarzenia,

<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div id=&quot;carouselExample&quot; class=&quot;carousel slide&quot;&gt;
      &lt;div class=&quot;carousel-inner&quot;&gt;
        &lt;div class=&quot;carousel-item active&quot;&gt;
          &lt;svg class=&quot;bd-placeholder-img d-block w-100&quot; width=&quot;800&quot; height=&quot;200&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot; role=&quot;img&quot; aria-label=&quot;Placeholder: First slide&quot; preserveAspectRatio=&quot;xMidYMid slice&quot; focusable=&quot;false&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect width=&quot;100%&quot; height=&quot;100%&quot; fill=&quot;#777&quot;&gt;&lt;/rect&gt;&lt;text x=&quot;50%&quot; y=&quot;50%&quot; fill=&quot;#555&quot; dy=&quot;.3em&quot;&gt;First slide&lt;/text&gt;&lt;/svg&gt;
        &lt;/div&gt;
        &lt;div class=&quot;carousel-item&quot;&gt;
          &lt;svg class=&quot;bd-placeholder-img d-block w-100&quot; width=&quot;800&quot; height=&quot;200&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot; role=&quot;img&quot; aria-label=&quot;Placeholder: Second slide&quot; preserveAspectRatio=&quot;xMidYMid slice&quot; focusable=&quot;false&quot;&gt;&lt;title&gt;Placeholder&lt;/title&gt;&lt;rect width=&quot;100%&quot; height=&quot;100%&quot; fill=&quot;#666&quot;&gt;&lt;/rect&gt;&lt;text x=&quot;50%&quot; y=&quot;50%&quot; fill=&quot;#444&quot; dy=&quot;.3em&quot;&gt;Second slide&lt;/text&gt;&lt;/svg&gt;
        &lt;/div&gt;
      &lt;/div&gt;

      &lt;button class=&quot;carousel-control-prev&quot; type=&quot;button&quot; data-bs-target=&quot;#carouselExample&quot; data-bs-slide=&quot;prev&quot;&gt;
        &lt;span class=&quot;carousel-control-prev-icon&quot; aria-hidden=&quot;true&quot;&gt;&lt;/span&gt;
        &lt;span class=&quot;visually-hidden&quot;&gt;Previous&lt;/span&gt;
      &lt;/button&gt;
      &lt;button class=&quot;carousel-control-next&quot; type=&quot;button&quot; data-bs-target=&quot;#carouselExample&quot; data-bs-slide=&quot;next&quot;&gt;
        &lt;span class=&quot;carousel-control-next-icon&quot; aria-hidden=&quot;true&quot;&gt;&lt;/span&gt;
        &lt;span class=&quot;visually-hidden&quot;&gt;Next&lt;/span&gt;
      &lt;/button&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div id="carouselExample" class="carousel slide">
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="img1.jpg" class="d-block w-100" alt="Slide 1"></img>
    </div>
    <div class="carousel-item">
      <img src="img2.jpg" class="d-block w-100" alt="Slide 2"></img>
    </div>
  </div>

  <button class="carousel-control-prev"
          data-bs-target="#carouselExample"
          data-bs-slide="prev">
  </button>

  <button class="carousel-control-next"
          data-bs-target="#carouselExample"
          data-bs-slide="next">
  </button>
</div>
```
# Close button
Close button to uniwersalny przycisk zamykania, np. alertów, modali, toastów.

Jak działa:
.btn-close to tylko ikona przycisku,
sam przycisk nic nie zamyka, musi być użyty wewnątrz komponentu, który obsługuje zamykanie,
aria-label jest wymagany dla dostępności,
<br>
<iframe width="100%" height="80" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;button type=&quot;button&quot; class=&quot;btn-close&quot; aria-label=&quot;Close&quot;&gt;&lt;/button&gt;
    &lt;div class=&quot;bg-dark p-2 mt-2&quot;&gt;
         &lt;button type=&quot;button&quot; class=&quot;btn-close btn-close-white&quot; aria-label=&quot;Close&quot;&gt;&lt;/button&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<button type="button"
        class="btn-close"
        aria-label="Close">
</button>
```
# Collapse
Collapse umożliwia zwijanie i rozwijanie treści (ukrywanie/pokazywanie elementów).

Jak działa:
element z .collapse jest ukryty,
przycisk lub link z data-bs-toggle="collapse" steruje widocznością,
animacja zmienia height (lub width przy wersji poziomej),
<br>
<iframe width="100%" height="200" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;button class=&quot;btn btn-primary mb-2&quot; type=&quot;button&quot; data-bs-toggle=&quot;collapse&quot; data-bs-target=&quot;#collapseExample&quot; aria-expanded=&quot;false&quot; aria-controls=&quot;collapseExample&quot;&gt;
      Pokaż / Ukryj
    &lt;/button&gt;
    &lt;div class=&quot;collapse&quot; id=&quot;collapseExample&quot;&gt;
      &lt;div class=&quot;card card-body&quot;&gt;
        Ukryta treść, która się rozwija.
      &lt;/div&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<button class="btn btn-primary"
        data-bs-toggle="collapse"
        data-bs-target="#example"
        aria-expanded="false" 
        aria-controls="collapseExample">
  Pokaż / Ukryj
</button>

<div id="example" class="collapse">
  <div class="card card-body">
    Ukryta treść
  </div>
</div>
```
# Dropdown
Dropdown wyświetla rozwijane menu po kliknięciu przycisku lub linku.

Jak działa:
.dropdown-toggle uruchamia menu,
.dropdown-menu zawiera elementy menu,
Bootstrap używa Popper.js do pozycjonowania,
menu otwiera się po kliknięciu, nie po najechaniu,
<br>
<iframe width="100%" height="250" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;dropdown&quot;&gt;
      &lt;button class=&quot;btn btn-secondary dropdown-toggle&quot; type=&quot;button&quot; data-bs-toggle=&quot;dropdown&quot; aria-expanded=&quot;false&quot;&gt;
        Menu
      &lt;/button&gt;
      &lt;ul class=&quot;dropdown-menu&quot;&gt;
        &lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Opcja 1&lt;/a&gt;&lt;/li&gt;
        &lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Opcja 2&lt;/a&gt;&lt;/li&gt;
        &lt;li&gt;&lt;a class=&quot;dropdown-item&quot; href=&quot;#&quot;&gt;Inna akcja&lt;/a&gt;&lt;/li&gt;
      &lt;/ul&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="dropdown">
  <button class="btn btn-secondary dropdown-toggle"
          data-bs-toggle="dropdown">
    Menu
  </button>

  <ul class="dropdown-menu">
    <li><a class="dropdown-item" href="#">Opcja 1</a></li>
    <li><a class="dropdown-item" href="#">Opcja 2</a></li>
  </ul>
</div>
```
# List group
służy do wyświetlania list elementów (tekstu, linków, przycisków) w spójnym stylu.

Jak działa:
.list-group – kontener,
.list-group-item – pojedynczy element,
.active oznacza aktualnie wybrany element,
.disabled blokuje interakcję,
<br>
<iframe width="100%" height="200" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;ul class=&quot;list-group&quot; style=&quot;max-width: 400px;&quot;&gt;
      &lt;li class=&quot;list-group-item active&quot; aria-current=&quot;true&quot;&gt;Aktywny&lt;/li&gt;
      &lt;li class=&quot;list-group-item&quot;&gt;Element&lt;/li&gt;
      &lt;li class=&quot;list-group-item disabled&quot; aria-disabled=&quot;true&quot;&gt;Zablokowany&lt;/li&gt;
      &lt;li class=&quot;list-group-item&quot;&gt;Kolejny element&lt;/li&gt;
    &lt;/ul&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<ul class="list-group">
  <li class="list-group-item active">Aktywny</li>
  <li class="list-group-item">Element</li>
  <li class="list-group-item">Element</li>
</ul>
```
# Navbar
Navbar to główny pasek nawigacyjny strony, w pełni responsywny.

Jak działa:
.navbar – główny kontener,
.navbar-expand-lg – określa moment zwijania,
.navbar-toggler + Collapse obsługują wersję mobilną,
może zawierać dropdowny, formularze, logo,
<br>
<iframe width="100%" height="300" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
    &lt;script src=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js&quot;&gt;&lt;/script&gt;
&lt;/head&gt;
&lt;body class=&quot;p-0&quot;&gt;
    &lt;nav class=&quot;navbar navbar-expand-lg bg-body-tertiary&quot;&gt;
      &lt;div class=&quot;container-fluid&quot;&gt;
        &lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Logo&lt;/a&gt;
        &lt;button class=&quot;navbar-toggler&quot; type=&quot;button&quot; data-bs-toggle=&quot;collapse&quot; data-bs-target=&quot;#navbarTogglerDemo02&quot; aria-controls=&quot;navbarTogglerDemo02&quot; aria-expanded=&quot;false&quot; aria-label=&quot;Toggle navigation&quot;&gt;
          &lt;span class=&quot;navbar-toggler-icon&quot;&gt;&lt;/span&gt;
        &lt;/button&gt;
        &lt;div class=&quot;collapse navbar-collapse&quot; id=&quot;navbarTogglerDemo02&quot;&gt;
          &lt;ul class=&quot;navbar-nav me-auto mb-2 mb-lg-0&quot;&gt;
            &lt;li class=&quot;nav-item&quot;&gt;
              &lt;a class=&quot;nav-link active&quot; aria-current=&quot;page&quot; href=&quot;#&quot;&gt;Home&lt;/a&gt;
            &lt;/li&gt;
            &lt;li class=&quot;nav-item&quot;&gt;
              &lt;a class=&quot;nav-link&quot; href=&quot;#&quot;&gt;Link&lt;/a&gt;
            &lt;/li&gt;
            &lt;li class=&quot;nav-item&quot;&gt;
              &lt;a class=&quot;nav-link disabled&quot; aria-disabled=&quot;true&quot;&gt;Disabled&lt;/a&gt;
            &lt;/li&gt;
          &lt;/ul&gt;
          &lt;form class=&quot;d-flex&quot; role=&quot;search&quot;&gt;
            &lt;input class=&quot;form-control me-2&quot; type=&quot;search&quot; placeholder=&quot;Search&quot; aria-label=&quot;Search&quot;&gt;
            &lt;button class=&quot;btn btn-outline-success&quot; type=&quot;submit&quot;&gt;Search&lt;/button&gt;
          &lt;/form&gt;
        &lt;/div&gt;
      &lt;/div&gt;
    &lt;/nav&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Logo</a>

    <button class="navbar-toggler"
            data-bs-toggle="collapse"
            data-bs-target="#menu">
      <span class="navbar-toggler-icon"></span>
    </button>

    <div class="collapse navbar-collapse" id="menu">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link active">Home</a>
        </li>
      </ul>
    </div>
  </div>
</nav>
```
# Progress
Progress pokazuje postęp operacji (np. ładowania).

Jak działa:
.progress to kontener,
.progress-bar to pasek,
szerokość (width) określa procent,
aria-* poprawiają dostępność,
<br>
<iframe width="100%" height="100" style="border: 1px solid #dee2e6; border-radius: 4px; resize: vertical; overflow: auto;" srcdoc="
&lt;!DOCTYPE html&gt;
&lt;html lang=&quot;en&quot;&gt;
&lt;head&gt;
    &lt;meta charset=&quot;utf-8&quot;&gt;
    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
    &lt;link href=&quot;https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css&quot; rel=&quot;stylesheet&quot;&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;div class=&quot;progress&quot; role=&quot;progressbar&quot; aria-label=&quot;Basic example&quot; aria-valuenow=&quot;0&quot; aria-valuemin=&quot;0&quot; aria-valuemax=&quot;100&quot;&gt;
      &lt;div class=&quot;progress-bar&quot; style=&quot;width: 0%&quot;&gt;&lt;/div&gt;
    &lt;/div&gt;
    &lt;div class=&quot;progress mt-3&quot; role=&quot;progressbar&quot; aria-label=&quot;Example with label&quot; aria-valuenow=&quot;25&quot; aria-valuemin=&quot;0&quot; aria-valuemax=&quot;100&quot;&gt;
      &lt;div class=&quot;progress-bar&quot; style=&quot;width: 25%&quot;&gt;25%&lt;/div&gt;
    &lt;/div&gt;
    &lt;div class=&quot;progress mt-3&quot; role=&quot;progressbar&quot; aria-label=&quot;Example with label&quot; aria-valuenow=&quot;60&quot; aria-valuemin=&quot;0&quot; aria-valuemax=&quot;100&quot;&gt;
      &lt;div class=&quot;progress-bar&quot; style=&quot;width: 60%&quot;&gt;60%&lt;/div&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<div class="progress" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100">
  <div class="progress-bar" style="width: 60%">
    60%
  </div>
</div>
```
# Scrollspy
Scrollspy automatycznie podświetla aktywne linki w menu na podstawie pozycji przewijania strony.

Jak działa:
kontener z data-bs-spy="scroll" obserwuje scroll,
data-bs-target wskazuje menu,
linki muszą prowadzić do id sekcji,
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
        .scrollspy-example { position: relative; height: 200px; margin-top: .5rem; overflow: auto; }
    &lt;/style&gt;
&lt;/head&gt;
&lt;body class=&quot;p-3&quot;&gt;
    &lt;nav id=&quot;navbar-example2&quot; class=&quot;navbar bg-body-tertiary px-3 mb-3&quot;&gt;
      &lt;a class=&quot;navbar-brand&quot; href=&quot;#&quot;&gt;Menu&lt;/a&gt;
      &lt;ul class=&quot;nav nav-pills&quot;&gt;
        &lt;li class=&quot;nav-item&quot;&gt;
          &lt;a class=&quot;nav-link&quot; href=&quot;#scrollspyHeading1&quot;&gt;Sekcja 1&lt;/a&gt;
        &lt;/li&gt;
        &lt;li class=&quot;nav-item&quot;&gt;
          &lt;a class=&quot;nav-link&quot; href=&quot;#scrollspyHeading2&quot;&gt;Sekcja 2&lt;/a&gt;
        &lt;/li&gt;
      &lt;/ul&gt;
    &lt;/nav&gt;
    &lt;div data-bs-spy=&quot;scroll&quot; data-bs-target=&quot;#navbar-example2&quot; data-bs-root-margin=&quot;0px 0px -40%&quot; data-bs-smooth-scroll=&quot;true&quot; class=&quot;scrollspy-example bg-light p-3 rounded-2&quot; tabindex=&quot;0&quot;&gt;
      &lt;h4 id=&quot;scrollspyHeading1&quot;&gt;Sekcja 1&lt;/h4&gt;
      &lt;p&gt;To jest treść sekcji 1. Przewiń w dół, aby zobaczyć efekt scrollspy.&lt;/p&gt;
      &lt;p&gt;Więcej tekstu...&lt;/p&gt;
      &lt;p&gt;Więcej tekstu...&lt;/p&gt;
      &lt;p&gt;Więcej tekstu...&lt;/p&gt;
      &lt;h4 id=&quot;scrollspyHeading2&quot;&gt;Sekcja 2&lt;/h4&gt;
      &lt;p&gt;To jest treść sekcji 2. Teraz aktywny powinien być drugi link.&lt;/p&gt;
      &lt;p&gt;Więcej tekstu...&lt;/p&gt;
      &lt;p&gt;Więcej tekstu...&lt;/p&gt;
      &lt;p&gt;Więcej tekstu...&lt;/p&gt;
    &lt;/div&gt;
&lt;/body&gt;
&lt;/html&gt;
"></iframe>

```html
<nav id="menu">
  <a href="#sekcja1">Sekcja 1</a>
  <a href="#sekcja2">Sekcja 2</a>
</nav>

<div data-bs-spy="scroll"
     data-bs-target="#menu"
     tabindex="0">
  <h4 id="sekcja1">Sekcja 1</h4>
  <h4 id="sekcja2">Sekcja 2</h4>
</div>
```
