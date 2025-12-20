# Jak utworzyc aplikacje w react

Otwieramy terminal przechodzimy tak gdzie chcemy utworzyc aplikacje po czym wpisujemy tak:

```bash
    npx create-react-app nazwa
```

Po czym wpisujemy:

```bash
    cd nazwa
    npm start
```

gdy serwer sie uruchomi wchodzimy do przegladarki i wpisuejmy

## localhost:3000

# Aby dodac bs do naszej aplikacji dodajemy 2 linijki w pliku App,js

```jsx
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min.js";
```

teraz juz powinno wszystko dzialac

# BS

```jsx
import "bootstrap/dist/css/bootstrap.css";

function App() {
  return (
    <div className="container mt-4">
      {/* ================= GRID ================= */}
      {/* Grid – układ strony oparty na wierszach i kolumnach */}
      <h2>Grid</h2>
      <div className="row">
        <div className="col bg-light border">Kolumna 1</div>
        <div className="col bg-light border">Kolumna 2</div>
        <div className="col bg-light border">Kolumna 3</div>
      </div>

      {/* ================= BUTTONS ================= */}
      {/* Przyciski – różne kolory i style */}
      <h2 className="mt-4">Buttons</h2>
      <button className="btn btn-primary me-2">Primary</button>
      <button className="btn btn-success me-2">Success</button>
      <button className="btn btn-danger">Danger</button>

      {/* ================= FORMS ================= */}
      {/* Formularze – inputy, selecty, checkboxy */}
      <h2 className="mt-4">Forms</h2>
      <div className="form-group mb-2">
        <label>Imię</label>
        <input type="text" className="form-control" />
      </div>
      <div className="form-group mb-2">
        <label>Wybierz opcję</label>
        <select className="form-select">
          <option>A</option>
          <option>B</option>
        </select>
      </div>
      <div className="form-check form-switch">
        <input className="form-check-input" type="checkbox" />
        <label className="form-check-label">Aktywny</label>
      </div>

      {/* ================= TYPOGRAPHY ================= */}
      {/* Teksty – wyrównanie, pogrubienie, kolor */}
      <h2 className="mt-4">Typography</h2>
      <p className="text-center fw-bold text-primary">
        Wyśrodkowany, pogrubiony tekst
      </p>

      {/* ================= CARD ================= */}
      {/* Card – karta z treścią (np. produkt, post) */}
      <h2 className="mt-4">Card</h2>
      <div className="card" style={{ width: "18rem" }}>
        <div className="card-body">
          <h5 className="card-title">Tytuł</h5>
          <p className="card-text">Treść karty</p>
          <button className="btn btn-primary">Akcja</button>
        </div>
      </div>

      {/* ================= IMAGES ================= */}
      {/* Obrazy – responsywne, zaokrąglone */}
      <h2 className="mt-4">Images</h2>
      <img
        src="https://via.placeholder.com/150"
        className="img-fluid rounded"
        alt="przyklad"
      />

      {/* ================= TABLE ================= */}
      {/* Tabele – dane w wierszach */}
      <h2 className="mt-4">Table</h2>
      <table className="table table-striped">
        <thead>
          <tr>
            <th>#</th>
            <th>Nazwa</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td>1</td>
            <td>Element A</td>
          </tr>
          <tr>
            <td>2</td>
            <td>Element B</td>
          </tr>
        </tbody>
      </table>

      {/* ================= ALERT ================= */}
      {/* Alert – komunikaty */}
      <h2 className="mt-4">Alert</h2>
      <div className="alert alert-success">Operacja zakończona sukcesem</div>

      {/* ================= LIST GROUP ================= */}
      {/* Listy elementów */}
      <h2 className="mt-4">List group</h2>
      <ul className="list-group">
        <li className="list-group-item">Element 1</li>
        <li className="list-group-item">Element 2</li>
      </ul>

      {/* ================= BADGE ================= */}
      {/* Badge – mała etykieta */}
      <h2 className="mt-4">Badge</h2>
      <span className="badge bg-primary">Nowe</span>

      {/* ================= FLEX ================= */}
      {/* Flex – ustawianie elementów */}
      <h2 className="mt-4">Flex</h2>
      <div className="d-flex justify-content-between bg-light p-2">
        <span>Lewo</span>
        <span>Prawo</span>
      </div>

      {/* ================= SPACING ================= */}
      {/* Spacing – marginesy i padding */}
      <h2 className="mt-4">Spacing</h2>
      <div className="bg-warning p-3 mt-2">Padding i margines</div>
    </div>
  );
}

export default App;
```

# Rozwiązany egzamin z galerią zdjeć

```jsx
// Import hooka useState z Reacta – pozwala przechowywać dane w komponencie
import { useState } from "react";

// Import własnych stylów CSS
import "./App.css";

// Import stylów Bootstrap (ładny wygląd)
import "bootstrap/dist/css/bootstrap.css";

// Główna funkcja aplikacji
function App() {
  // Stan określający, czy mają być pokazane ZWIERZĘTA
  const [showAnimals, setShowAnimals] = useState(true);

  // Stan określający, czy mają być pokazane KWIATY
  const [showFlowers, setShowFlowers] = useState(true);

  // Stan określający, czy mają być pokazane SAMOCHODY
  const [showCars, setShowCars] = useState(true);

  // Stan przechowujący TABLICĘ ZDJĘĆ
  const [photos, setPhotos] = useState([
    // Każdy obiekt to jedno zdjęcie
    { id: 0, alt: "Mak", filename: "obraz1.jpg", category: 1, downloads: 35 },
    {
      id: 1,
      alt: "Bukiet",
      filename: "obraz2.jpg",
      category: 1,
      downloads: 43,
    },
    {
      id: 2,
      alt: "Dalmatyńczyk",
      filename: "obraz3.jpg",
      category: 2,
      downloads: 2,
    },
    {
      id: 3,
      alt: "Świnka morska",
      filename: "obraz4.jpg",
      category: 2,
      downloads: 53,
    },
    {
      id: 4,
      alt: "Rotwailer",
      filename: "obraz5.jpg",
      category: 2,
      downloads: 43,
    },
    { id: 5, alt: "Audi", filename: "obraz6.jpg", category: 3, downloads: 11 },
    { id: 6, alt: "kotki", filename: "obraz7.jpg", category: 2, downloads: 22 },
    { id: 7, alt: "Róża", filename: "obraz8.jpg", category: 1, downloads: 33 },
    {
      id: 8,
      alt: "Świnka morska",
      filename: "obraz9.jpg",
      category: 2,
      downloads: 123,
    },
    {
      id: 9,
      alt: "Foksterier",
      filename: "obraz10.jpg",
      category: 2,
      downloads: 22,
    },
    {
      id: 10,
      alt: "Szczeniak",
      filename: "obraz11.jpg",
      category: 2,
      downloads: 12,
    },
    {
      id: 11,
      alt: "Garbus",
      filename: "obraz12.jpg",
      category: 3,
      downloads: 321,
    },
  ]);

  // Tworzymy nową tablicę zdjęć na podstawie zaznaczonych kategorii
  const filteredPhotos = photos.filter((p) => {
    // Jeśli zdjęcie jest kwiatem i opcja "Kwiaty" jest włączona – pokaż
    if (p.category === 1 && showFlowers) {
      return true;
    }
    // Jeśli zdjęcie jest zwierzęciem i opcja "Zwierzęta" jest włączona – pokaż
    else if (p.category === 2 && showAnimals) {
      return true;
    }
    // Jeśli zdjęcie jest samochodem i opcja "Samochody" jest włączona – pokaż
    else if (p.category === 3 && showCars) {
      return true;
    }

    // W przeciwnym razie – nie pokazuj zdjęcia
    return false;
  });

  // Funkcja zwiększająca liczbę pobrań zdjęcia
  function updateDownloads(id) {
    // Tworzymy kopię tablicy zdjęć (ważne w React)
    const newPhotos = [...photos];

    // Szukamy zdjęcia o podanym id
    for (const p of newPhotos) {
      if (p.id === id) {
        // Zwiększamy liczbę pobrań o 1
        p.downloads++;
        break;
      }
    }

    // Zapisujemy nową tablicę zdjęć do stanu
    setPhotos(newPhotos);
  }

  // JSX – to, co zobaczymy na stronie
  return (
    <>
      {/* Tytuł strony */}
      <h1>Kategorie zdjęć</h1>

      {/* Checkbox: KWIATY */}
      <div className="form-check form-check-inline form-switch">
        <input
          type="checkbox"
          name="flowers"
          id="flowers"
          className="form-check-input"
          checked={showFlowers} // stan checkboxa
          onChange={() => setShowFlowers(!showFlowers)} // zmiana stanu
        />
        <label htmlFor="flowers" className="form-check-label">
          Kwiaty
        </label>
      </div>

      {/* Checkbox: ZWIERZĘTA */}
      <div className="form-check form-check-inline form-switch">
        <input
          type="checkbox"
          name="animals"
          id="animals"
          className="form-check-input"
          checked={showAnimals}
          onChange={() => setShowAnimals(!showAnimals)}
        />
        <label htmlFor="animals" className="form-check-label">
          Zwierzęta
        </label>
      </div>

      {/* Checkbox: SAMOCHODY */}
      <div className="form-check form-check-inline form-switch">
        <input
          type="checkbox"
          name="cars"
          id="cars"
          className="form-check-input"
          checked={showCars}
          onChange={() => setShowCars(!showCars)}
        />
        <label htmlFor="cars" className="form-check-label">
          Samochody
        </label>
      </div>

      {/* Kontener na zdjęcia */}
      <div className="row">
        {filteredPhotos.map((p) => (
          <div key={p.id} className="col">
            {/* Wyświetlenie obrazka */}
            <img
              src={"assets/" + p.filename}
              alt={p.alt}
              className="rounded"
              style={{ margin: "5px" }}
            />

            {/* Liczba pobrań */}
            <h4>Pobrań: {p.downloads}</h4>

            {/* Przycisk zwiększający liczbę pobrań */}
            <button
              className="btn btn-success"
              onClick={() => updateDownloads(p.id)}
            >
              Pobierz
            </button>
          </div>
        ))}
      </div>
    </>
  );
}

// Eksport komponentu, aby mógł być użyty w index.js
export default App;
```

# Rozwiazany egzamin z wypisywaniem do konsoli

```jsx
// Import pliku CSS z własnymi stylami aplikacji
import "./App.css";

// Import gotowych stylów Bootstrap (ładne formularze, przyciski itd.)
import "bootstrap/dist/css/bootstrap.css";

// Główna funkcja aplikacji React
function App() {
  // Funkcja uruchamiana po wysłaniu formularza
  function onSubmit(event) {
    // Zatrzymuje domyślne zachowanie formularza (odświeżenie strony)
    event.preventDefault();

    // Pobiera tekst wpisany w pole input o nazwie "filmTitle"
    const title = event.target.elements.filmTitle.value;

    // Pobiera wybraną wartość z listy select o nazwie "filmType"
    const type = event.target.elements.filmType.value;

    // Wyświetla w konsoli tytuł i rodzaj filmu
    console.log(`tytul: ${title}, rodzaj: ${type}`);
  }

  // Zwracany JSX – czyli to, co zobaczymy na stronie
  return (
    <>
      {/* Formularz, który po wysłaniu wywoła funkcję onSubmit */}
      <form onSubmit={onSubmit} method="post">
        {/* Grupa formularza – tytuł filmu */}
        <div className="form-group">
          {/* Etykieta opisująca pole input */}
          <label htmlFor="filmTitle">Tytuł filmu</label>

          {/* Pole tekstowe do wpisania tytułu filmu */}
          <input
            type="text" // Typ pola – tekst
            name="filmTitle" // Nazwa pola (używana w JS)
            id="filmTitle" // Id pola (łączy się z label)
            className="form-control" // Klasa Bootstrapa dla wyglądu
          />
        </div>

        {/* Grupa formularza – rodzaj filmu */}
        <div className="form-group">
          {/* Etykieta dla listy wyboru */}
          <label htmlFor="filmType">Rodzaj</label>

          {/* Lista rozwijana (select) */}
          <select
            name="filmType" // Nazwa pola
            id="filmType" // Id pola
            className="form-control" // Styl Bootstrapa
          >
            {/* Pusta opcja – domyślna */}
            <option></option>

            {/* Opcja: Komedia */}
            <option value="1">Komedia</option>

            {/* Opcja: Obyczajowy */}
            <option value="2">Obyczajowy</option>

            {/* Opcja: Sensacyjny */}
            <option value="3">Sensacyjny</option>

            {/* Opcja: Horror */}
            <option value="4">Horror</option>
          </select>
        </div>

        {/* Grupa z przyciskiem */}
        <div className="form-group">
          {/* Przycisk wysyłający formularz */}
          <button
            type="submit" // Typ submit – wysyła formularz
            className="btn btn-primary" // Styl Bootstrapa
          >
            Dodaj
          </button>
        </div>
      </form>
    </>
  );
}

// Eksport komponentu App, aby mógł być użyty w innych plikach
export default App;
```

# Rozwiazany egzamin z wypisywaniem do konsoli

```jsx
// Import hooka useRef z React – pozwala tworzyć referencje do elementów DOM
import { useRef } from "react";

// Import własnego pliku CSS (wygląd strony)
import "./App.css";

// Import stylów Bootstrap (ładne formularze, przyciski itd.)
import "bootstrap/dist/css/bootstrap.css";

// Główna funkcja aplikacji
function App() {
  // Tablica z nazwami kursów
  const kursy = [
    "Programowanie w C#",
    "Angular dla początkujących",
    "Kurs Django",
  ];

  // Tworzymy referencję do pola Imię i Nazwisko
  const imieNazwiskoRef = useRef();

  // Tworzymy referencję do pola Numer Kursu
  const numerKursuRef = useRef();

  // Funkcja uruchamiana po wysłaniu formularza
  function handleSubmit(event) {
    // Zatrzymuje domyślne odświeżanie strony po wysłaniu formularza
    event.preventDefault();

    // Pobranie wartości z pola Imię i Nazwisko
    const imienazwisko = imieNazwiskoRef.current.value;
    console.log(imienazwisko); // Wyświetlenie w konsoli

    // Pobranie wartości z pola Numer Kursu
    const numerkursu = numerKursuRef.current.value;

    // Pobranie kursu z tablicy na podstawie numeru
    const kurs = kursy[numerkursu - 1]; // -1 bo tablica liczy od 0

    // Sprawdzenie czy kurs istnieje
    if (kurs !== undefined) {
      console.log(kurs); // Wyświetlenie nazwy kursu
    } else {
      console.log("Nieprawidłowy numer kursu"); // Obsługa błędu
    }
  }

  // JSX – to, co zobaczymy na stronie
  return (
    <>
      {/* Wyświetlenie liczby kursów */}
      <h2>Liczba kursów: {kursy.length}</h2>

      {/* Lista kursów w formie numerowanej */}
      <ol>
        {kursy.map((kurs, index) => (
          <li key={index}>{kurs}</li> // Każdy kurs w <li>
        ))}
      </ol>

      {/* Formularz zapisujący do kursu */}
      <form onSubmit={handleSubmit}>
        {/* Pole Imię i Nazwisko */}
        <div className="form-group">
          <label htmlFor="imienazwisko">Imię i nazwisko:</label>
          <input
            type="text" // Typ pola – tekst
            id="imienazwisko" // Id pola
            name="imienazwisko" // Nazwa pola
            className="form-control" // Styl Bootstrapa
            ref={imieNazwiskoRef} // Referencja do pola
          />
        </div>

        {/* Pole Numer Kursu */}
        <div className="form-group">
          <label htmlFor="numerkursu">Numer kursu:</label>
          <input
            type="number" // Typ pola – liczba
            id="numerkursu"
            name="numerkursu"
            className="form-control"
            ref={numerKursuRef} // Referencja do pola
          />
        </div>

        {/* Przycisk wysyłający formularz */}
        <div className="form-group mt-3">
          <button type="submit" className="btn btn-primary">
            Zapisz do kursu
          </button>
        </div>
      </form>
    </>
  );
}

// Eksport komponentu App, aby można było użyć go w innych plikach
export default App;
```
