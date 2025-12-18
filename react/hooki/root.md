# React - Hooki

Powrót na start -> [Start](../root.md)

Docsy -> [Kliknij](https://react.dev/reference/react/hooks)

## Hooki w React

W dużym skrócie, hooki to funckje reacta które działają w tle dla naszych korzyści. Mogą operować stanem, powodować odświeżenie interfejsu, lub przechować ważne dla nas dane w zewnętrznej pamięci programu, po za komponentem.

### Wywoływanie hooków

Hook należy zaimportować z biblioteki React, a następnie wywołać go tak, jak zwykłą funkcję. Hooki zazwyczaj (chyba zawsze ale niewiem) zwracają nam listę zmiennych bądź metod, którymi możemy operować. Robimy prostą destrukturyzację tych danych, nadając im aliasy. Jeśli przeraziły cię ostatnie zdania, zaufaj mi, to tylko brzmi skomplikowanie, wytłumaczę ci wszystko krok po kroku.

### Przykład użycia hooka useState

```jsx
import { useState } from "react";

function Greeting(props) {
  const [name, _setName] = useState("Kamil Ślimak");

  return (
    <>
      <h1>Hello, {name}!</h1>
      <h2>Nice to meet you!</h2>
    </>
  );
}
```

## Zasady Hooków

To jest ważne mordo, poczytaj serio.

Docsy -> [Kliknij](https://react.dev/reference/rules/rules-of-hooks)

### Pierwsza i najważniejsza zasada

Hooki zawsze wywołujemy we wnętrzu komponentu. Jeśli zrobisz inaczej, interpreter zinterpretuje twoje uzębienie.

Przykład błędu:

```jsx
import { useState } from "react";

const [name, _setName] = useState("Kamil Ślimak");

function Greeting(props) {

    return (...);
}
```

Przykład poprawnego kodu:

```jsx
import { useState } from "react";

function Greeting(props) {
    const [name, _setName] = useState("Kamil Ślimak");

    return (...);
}
```

### Druga i mniej ważna ale dalej zasada

Hooki deklarujemy zawsze w scopie głównej funkcji komponentu. Nie w pętli która znajduje się gdzieś w ciele funkcji-komponentu. Nie w bloku try/catch. Nie w funkcji w funkcji-komponencie. Ale w głównym scopie.

Przykład poprawnego użycia:

```jsx
import { useState } from "react";

function Greeting(props) {
    const [name, _setName] = useState("Kamil Ślimak");

    return (...);
}
```

Przykład użycia jak cwel:

```jsx
import { useState } from "react";

function Greeting(props) {
    function jestemCwelemINieZnamZasad() {
        const [name, _setName] = useState("Cwel Cweliński Pierwszy");
    }

    return (...);
}
```

Kolejny przykład złego użycia:

```jsx
import { useState } from "react";

function Greeting(props) {
    try (nie być cwelem) {
        ...
    } catch {
        const [name, _setName] = useState("Cwel Cweliński Drugi");
    }

    return (...);
}
```

## Omówienie każdego z hooków pojedyńczo

Omówimy sobie każdy ważny dla nas hook. Na początku będą przykłady ich wywołania, na szybką ściąge a potem dokładny opis.

Oto lista:

- [useState](./useState.md)
- [useEffect](./useEffect.md)
- [useRef](./useRef.md)
