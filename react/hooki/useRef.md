# React - Hooki - useRef

Powrót do poprzedniej lektury -> [Hooki](./root.md)

Docsy -> [Kliknij](https://react.dev/reference/react/useRef)

## Użycie hooka useRef

```jsx
import { useRef } from "react";

function JakisKomponent(props) {
  const inputRef = useRef(null);

  return (
    <>
      <input ref={inputRef} />
      <button onClick={() => inputRef.current.focus()}>Focus</button>
    </>
  );
}
```

Ten przykład pokazuje jak użyć hooka useRef tak, aby uzytkownik po kliknięciu przycisku od razu wszedł w edycję inputa.

Hook należy zaimportować. Następnie wywołujemy go wewnątrz komponentu ([przeczytaj zasady hooków](./root.md#zasady-hooków)).
Hook przyjmuje jeden argument:

- wartość początkową (można zostawić puste, wiedza dlaczego nie przyda się na egzaminie)

Następnie destrukturyzujemy zwróconą listę zmiennych (całą jedną zmienną), i używamy w naszym komponencie.

Konwencja nazewnictwa:

- Do czego użyjemy referencji + Ref. W naszym przypadku inputRef.

## Opis hooka

Hook useRef pozwala nam na stworzenie referencji do elementu DOM lub komponentu React. Noi fajnie ale po co? Przydatne jest to w przypadku gdy mamy jeden checkbox i chcemy wiedzieć czy jest zaznaczony czy nie. Dodajemy do niego referencje, a następnie w zmiennej checkboRef.current.checked możemy sprawdzić czy jest zaznaczony czy nie. Możliwości useRefa są duże, polecam zapoznać się z przykładami w dokumentacji (link u góry strony).

Powrót na start -> [Start](../root.md)
