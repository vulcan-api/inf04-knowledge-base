# React - Bonus rzeczy stricte pod egzamin

Powrót na start -> [Start](../root.md)

## Map

Kojarzycie taki problem jak trzeba z listy wypisać elementy? To tutaj używamy mapa.

Docsy Mapa -> [Kliknij](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/map)

### Taki przykładowy kodzik

```jsx
function Greeting(props) {
  const lista = ["Kurs1", "Kurs2", "Kurs3"];

  return (
    <ol>
      {lista.map((element) => (
        <li key={element}>{element}</li>
      ))}
    </ul>
  );
}
```

### Teraz pora na omówienie

Na początku mamy listę elementów. Może być to również lista w `useState`.

```jsx
const lista = ["Kurs1", "Kurs2", "Kurs3"];
```

W trakcie returna wywołujemy mistycznego mapa. Jest to metoda tablicy z JavaScripta.

```jsx
{
  lista.map((element) => <li key={element}>{element}</li>);
}
```

Zacznijmy omówienie od dwóch klamerek w które zamknięty jest nasz map. Używamy ich, gdy w trakcie returna w React'cie chcemy wywołać jakiś kod js'a zamiast po prostu wpisać tam htmla.

Następnie odwołujemy się do naszego listy i wywołujemy na niej metodę map.

Metoda przyjmuje jeden argument. Funkcję strzałkową (albo zwykłą chb też może) (referencja do funkcji też wchodzi w grę).

```jsx
(element) => <li key={element}>{element}</li>;
```

Jak widzimy funckja posiada jeden argument - element. Możemy go sobie nazwać jak chcemy. To jest takie 'this' w obiektówce.

Możemy też dołożyć drugi argument, najczęściej nazywany i pod którego zostanie podpisany aktualny index.

```jsx
(element, index) => <li key={element}>{element}</li>;
```

Map przejdzie przez każdy element tablicy i zrobi z nim to co chcemy żeby zrobił. W naszym przypadku, stworzy li z elementem i zwróci go.

Funkcję możemy też zapisać z klamerkami jeśli chcemy wykonać jakąś operację na danych zamiast po prostu zwrócić jsx'a.

```jsx
(element) => {
  element = element + "!";
  return <li key={element}>{element}</li>;
};
```

Pamiętajmy jednak, gdy tak robimy, musimy dodać klauzulę return!

### Klucze

Wprawne oko zauważyło że do naszego `<li>` przypisałem klucz, tak zwany key. Do czego służy mistyczny klucz?

Mianowicie:

Przypisujemy klucz na wypadek zmian w liście. Wtedy react sprawdza, dla jakich kluczy musi znowy wymyślić element, a dla których będzie taki sam. Kwestia optymalizacji ale zwraca błąd.

Docsy kluczy -> [Kliknij](https://react.dev/learn/rendering-lists#keeping-list-items-in-order-with-key)

## Sort

A co jak dane mają być posortowane? JS ma super funkcję do sortowania tablic.

Docsy sortowania -> [Kliknij](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/sort)

### Przykład

```jsx
lista.sort((a, b) => a - b);
```

### Omówienie

Sort to kolejna metoda tablicy z JavaScripta. Przyjmuje ona funkcję strzałkową, która przyjmuje dwa argumenty - a i b. Tam podpisane są dwa kolejne argumenty listy, które są porównywane. Przykład kodu powyżej to wystarczająco do zapamiętania na egzamin. Pamiętajmy jednak, aby zamienić miejscami a i b w funkcji strzałkowej, aby móc posortować dane w kolejności od największego do najmniejszego.

Czyli tak

```jsx
lista.sort((a, b) => b - a);
```

I tutaj też możemy dać sobie klamerki i robić co chcemy ale pamiętamy o return

```jsx
lista.sort((a, b) => {
  console.log(a, b);
  return a - b;
});
```

## Filter

Jak był ten arkusz z galerią i radio inputami to używaliśmy metody filter do pokazania poprawnych danych na ekranie.

Docsy filter -> [Kliknij](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/filter)

### Jak to się pisze

```jsx
lista.filter((element) => element === "Kurs1");
```

### Jak to działa

Filter to kolejna metoda tablicy z JavaScripta. Przyjmuje ona funkcję strzałkową, która przyjmuje jeden argument - element. Następnie zajemy warunek pod jakim ma być pofiltrowany element. W naszym przypadku, jeśli element jest równy `Kurs1`, to zostanie zwrócony a reszta nie zostanie zwrócona.

Możemy też wstawić warunek logiczny

```jsx
lista = [1, 2, 3, 4, 5];
lista.filter((element) => element > 2);
```

Podobnie jak w poprzednich, możemy dodać klamerki, popisać co nam pasuje i DODAĆ RETURNA!

## Event handlery

Docsy event handlery -> [Kliknij](https://react.dev/learn/adding-interactivity)

### Przykład handlera onClick

```jsx
function Greeting(props) {
  function handleClick() {
    console.log("Kliknięto");
  }

  return <button onClick={handleClick}>Kliknij mnie</button>;
}
```

### Omówienie go

Event handlery to funkcje, które są wywoływane po zrobieniu czegoś z elementem. W naszym przypadku, funkcja handleClick jest wywoływana po kliknięciu na button. Mamy różne event handlery, np. onClick, onSubmit, onChange, onInput, onKeydown, onKeyup itd.

Docsy onClicka -> [Kliknij](https://developer.mozilla.org/en-US/docs/Web/API/Element/click_event)

Event handlery możemy wywoływać różnie. Jeśli nie przekazujemy argumentów to podajemy tylko nazwę funkcji.

```jsx
function Greeting(props) {
  function handleClick() {
    console.log("Kliknięto");
  }

  return <button onClick={handleClick}>Kliknij mnie</button>;
}
```

Jeśli przekazujemy argumenty to robimy funkcję strzałkową i w niej wywołujemy funkcję z argumentami.

```jsx
function Greeting(props) {
  function handleClick(imie) {
    console.log(`Nie klikaj ${imie}`);
  }

  return <button onClick={() => handleClick("Jacek")}>Kliknij mnie</button>;
}
```

To chyba tyle, jak czegoś nie ma to dajcie znać, dopiszę.

Powrót na start -> [Start](../root.md)
