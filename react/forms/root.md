# React - Obsługa Formularzy

Powrót na start -> [Start](../root.md)

Docsy -> [Kliknij](https://react.dev/reference/react-dom/components/form)

## Jak robimy formularze w React

```jsx
function Formularz() {
  return (
    <form>
      <input type="text" name="input1" />
      <button type="submit">Wyślij</button>
    </form>
  );
}
```

### Omówienie

Formularz to komponent, który jest zwracany z funkcji renderującej. W naszym przypadku, zwracamy formularz z inputem i przyciskiem.

Chcemy obsłużyć przypadek gdy user submituje formularz. Co wtedy? Jak zebrać te dane?

Spokojnie uspokajam was, to łatwe.

```jsx
function Formularz() {
  function onSubmit(e) {
    e.preventDefault();
    const inputs = event.currentTarget.elements;
    console.log(inputs.input1.value);
  }

  return (
    <form onSubmit={onSubmit}>
      <input type="text" name="input1" />
      <button type="submit">Wyślij</button>
    </form>
  );
}
```

Jak widzimy mamy podpiętą funkcję `onSubmit` do formularza. Wtedy, gdy użytkownik wysyła formularz, funkcja ta jest wywoływana.

Do funkcji automatycznie trafia jeden argument - event. Następuje mistyczne `e.preventDefault()`, które uniemożliwia domyślne zachowanie formularza, czyli przeładowanie strony.

Następnie tworzymy zmienną `inputs`, która przechowuje wszystkie inputy z formularza. Dzięki `currentTarget` możemy odnieść się do formularza, a dzięki `elements` możemy odnieść się do inputów.

Potem ich wartości zgarniamy po `name.value` gdzie name to name podpisany jako parametr do inputa w formularzu.

```jsx
const inputs = event.currentTarget.elements;
console.log(inputs.input1.value);
```

I to tyle wsm.

W tej funkcji robimy co chcemy z tym. Może np. wysłać do backendu, może np. zwrócić do useState, może np. zwrócić do useState i wysłać do backendu. Jak ci się widzi.

## Alternatywy

### useRef

Możemy ustawić sobie referencje do inputów

```jsx
function Formularz() {
  const inputRef = useRef(null);

  function onSubmit(e) {
    e.preventDefault();
    console.log(inputRef.current.value);
  }

  return (
    <form onSubmit={onSubmit}>
      <input type="text" name="input1" ref={inputRef} />
      <button type="submit">Wyślij</button>
    </form>
  );
}
```

### useState

Możemy sobie podpiąć state pod inputa

```jsx
function Formularz() {
  const [inputValue, setInputValue] = useState("");

  function onSubmit(e) {
    e.preventDefault();
    console.log(inputValue);
  }

  return (
    <form onSubmit={onSubmit}>
      <input
        type="text"
        name="input1"
        value={inputValue}
        onChange={(e) => setInputValue(e.target.value)}
      />
      <button type="submit">Wyślij</button>
    </form>
  );
}
```

Wszystkie wersje robią to samo - co ci wygodniej.

Powrót na start -> [Start](../root.md)
