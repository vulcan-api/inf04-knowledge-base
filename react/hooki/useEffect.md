# React - Hooki - useEffect

Powrót do poprzedniej lektury -> [Hooki](./root.md)

Docsy -> [Kliknij](https://react.dev/reference/react/useEffect)

## Użycie hooka useEffect

```jsx
import { useEffect } from "react";

function Greeting(props) {

  useEffect(() => {
    const handleKeyPress = (event) => {
      console.log(event.key);
    };

    window.addEventListener("keypress", handleKeyPress);
    return () => {
      window.removeEventListener("keypress",handleKeyPress);
    };
  }, []);

  return (...);
}
```

Hook należy zaimportować. Następnie wywołujemy go wewnątrz komponentu ([przeczytaj zasady hooków](./root.md#zasady-hooków)).
Hook przyjmuje dwie argumenty:

- funkcję, która będzie wywoływana po renderowaniu komponentu (handleKeyPress)
- tablicę zmiennych, które będą monitorowane (w naszym przypadku, pusta tablica)

Jeśli tablica jest pusta, hook będzie wywoływany tylko raz, po pierwszym renderowaniu komponentu.

Jeśli nie podamy tablicy, hook będzie wywoływany po każdym renderowaniu komponentu.

## Opis hooka

Hook jest używany do wywoływania funkcji po renderowaniu komponentu. W powyższym przykładzie, dodajemy event listener do okna przeglądarki, który będzie wywoływany po naciśnięciu klawisza. Tutaj, jedynie wypisuje on w konsoli naciśnięty klawisz, ale możliwości są ogromne. Hooka tego używamy głównie do pobierania danych z backendu, czego na egzaminie (raczej) nie doświadczymy, ale ta wiedza może się przydać w przyszłości.

Zastanawia was pewnie co oznacza ten return:

```jsx
return () => {
  window.removeEventListener("keypress", handleKeyPress);
};
```

Praktyka jest taka, że jeśli używamy w event listenerze funkcji, która jest zdefiniowana wewnątrz hooka, to musimy zwrócić funkcję, która będzie usuwać ten event listener. W przeciwnym wypadku funkcja dalej by działała, nawet gdyby użytkownik przeszedł na inną część naszej aplikacji - chyba tego nie chcemy.

Czytaj dalej -> [useRef](./useRef.md)
