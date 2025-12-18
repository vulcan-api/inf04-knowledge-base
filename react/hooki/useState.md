# React - Hooki - useState

Powrót do poprzedniej lektury -> [Hooki](./root.md)

Docsy -> [Kliknij](https://react.dev/reference/react/useState)

## Użycie hooka useState

```jsx
import { useState } from "react";

function Greeting(props) {
  const [name, setName] = useState("Kamil Ślimak");

  return (
    <>
      <h1>Hello, {name}!</h1>
      <h2>Nice to meet you!</h2>
    </>
  );
}
```

Hook należy zaimportować. Następnie wywołujemy go wewnątrz komponentu ([przeczytaj zasady hooków](./root.md#zasady-hooków)), destrukturyzujemy zwróconą listę zmiennych, i używamy w naszym komponencie.

Konwencja nazewnictwa:

- Pierwsza zmienna jest zmienną stanu
- Druga zmienna jest funkcją ustawiania stanu

Nazwy możecie sobie wpisać jakie chcecie, ale taka jest konwencja aby druga zmienna miała nazwę set + nazwa zmiennej stanu (tej pierwszej). W tym przypadku name i setName.

## Opis hooka

Najpierw zacznijmy od tego, czym jest stan w reactcie. Możemy go uznać za obiekt klucz-wartość, który jest przechowywany w pamięci komponentu. Gdy stan się zmieni, react pomyśli sobie że pewnie ma wyświetlić co innego i dobrze pomyśli. Wyrenderuje komponent jeszcze raz.

Wróćmy do przykładu z powyżej.

```jsx
const [name, setName] = useState("Kamil Ślimak");
```

Jak widzimy, mamy tutaj zmienną stanu o nazwie name. W dalszej części komponentu wyświetlamy ją wewnątrz h1.

```jsx
return (
  <>
    <h1>Hello, {name}!</h1>
    <h2>Nice to meet you!</h2>
  </>
);
```

Gdyby zmienna zmieniła się z podstawowej wartości, jaką jest "Kamil Ślimak" i została by na przykład odwrócona kolejność liter, wówczas react wyrenderowałby komponent ponownie, aby być pewnym, że użytkownik widzi najnowsze wartości.

### Zmiana wartości stanu

Robimy to tak:

```js
setName(name.reverse());
```

Dla znających ten żart, nie sprawi kłopotu odgadnięcie, że po odwróceniu ciąg znaków pozostanie taki sam (jeśli zignorujemy białe znaki i wielkość liter). Ale React zauważy, że wartość się zmieniła i wyrenderuje komponent ponownie.

Czytaj dalej -> [useEffect](./useEffect.md)
