# React - Komponenty

Powrót na start -> [Start](../root.md)

Docsy -> [Kliknij](https://react.dev/learn/your-first-component)

## Rodzaje komponentów w React

W React rozróżniamy 2 rodzaje komponentów. Klasowe oraz funkcyjne. Klasowe były używane kiedyś, ale to przeżytek. Niewygodnie się to pisało ale dla ciekawostki, wstawię tutaj info o tym. Obecnie, standardem jest korzystanie z komponentów funkcyjnych.

### Komponenty klasowe

Przykład komponentu:

```jsx
class Greeting extends Component {
  render() {
    return <h1>Hello, {this.props.name}!</h1>;
  }
}
```

Przykład wywołania komponentu:

```jsx
<Greeting name="Taylor" />
```

### Komponenty funkcyjne (te normalne)

Przykład komponentu:

```jsx
function Greeting(props) {
  return <h1>Hello, {props.name}!</h1>;
}
```

Przykład wywołania komponentu (to się akurat nie zmienia):

```jsx
<Greeting name="Taylor" />
```

### Tworząc komponenty pamiętamy o kilku rzeczach

- Nazwy komponentów zapisujemy z dużej litery, inaczej interpreter myśli, że są to zwykłe funkcje.

Przykład:

```jsx
function Greeting(props) {...}
```

zamiast

```jsx
function greeting(props) {...}
```

Tak, to jest wazne.

- Komponenty zwracają htmla, jest to część formatu jsx. (taka jajofuzja jsa i xmla)

```jsx
function Greeting(props) {
  return <h1>Hello, {props.name}!</h1>;
}
```

Jak dobrze wiemy, zwrócić funkcją w js, możemy naraz jeden element. Co gdy chcemy zwrócić dwa divy jako "siblings", jednym komponentem?

Nic prostszego, używamy czegoś takiego jak React Fragment.

```jsx
function Greeting(props) {
  return (
    <>
      <h1>Hello, {props.name}!</h1>
      <h2>Nice to meet you!</h2>
    </>
  );
}
```

Disclaimer: W starszych wersjach reacta, zamiast pustych tagów (<></>) spotkamy element

```jsx
<React.Fragment></React.Fragment>
```

To normalne, tak się to robiło w poprzednich wersjach. Później to uproszczono.

- Jeśli tworzymy komponenty w innym pliku, musimy je wyeksportować. (Raczej nie pojawi sie na egzaminie ale kto wie)

Przykład:

```jsx
function Greeting(props) {
  return <h1>Hello, {props.name}!</h1>;
}

export default Greeting;
```

lub

```jsx
export default function Greeting(props) {
  return <h1>Hello, {props.name}!</h1>;
}
```

- Na marginesie

W React do nadawania klas używamy className, zamiast html'owego class. Dlaczego? Proste. W JS keyword class już coś robił, gdy zrobili reacta.

Przykład:

```jsx
function Greeting(props) {
  return <h1 className="jajo">Hello, {props.name}!</h1>;
}
```

zamiast

```jsx
function Greeting(props) {
  return <h1 class="jajo">Hello, {props.name}!</h1>;
}
```

Na razie to tyle. Zapraszam do dalszej lektury. Rozkład jazdy -> [Hooki](../hooki/root.md).
