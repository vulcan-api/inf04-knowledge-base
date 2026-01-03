# Instrukcja dodania testów jednostkowych xUnit do projektu WPF 

## 1. Informacje wstępne

Projekt **ArkuszCezar** (na którym jest przykład) jest aplikacją desktopową WPF napisaną w technologii **.NET 8 (net8.0-windows7.0)**.  
Celem  jest pokazanie, jak dodać i uruchomić **testy jednostkowe xUnit** dla logiki szyfru Cezara.

---

## 2. Dodanie projektu testowego xUnit

1. Otwórz rozwiązanie **ArkuszCezar** w Visual Studio
2. Kliknij **PPM na Solution**
3. Wybierz **Add → New Project**
4. Wybierz **xUnit Test Project (.NET)**
5. Nazwij projekt: <NazwaArkusza>.Tests   // w tym przypadku bedzie to ArkuszCezar.Tests

![](testy01.png)

## 3. Dodanie referencji do projektu WPF

1. Kliknij **PPM na ArkuszCezar.Tests**
2. Następnie **Add → Project Reference**

![](testy02.png)

Będziemy testowac funkcję `public static string Szyfruj(string tekst, int klucz)`

```csharp
namespace ArkuszCezar.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string tekst = "abc";
            int klucz = 3;

            string wynik = MainWindow.Szyfruj(tekst, klucz); // mainwindow ponwieważ funkcja szyfruj jest w klasie main window

            Assert.Equal("def", wynik);
        }
        //kolejne test w analogiczny sposob
    }
}

```

![](testy04.png)
![](testy03.png)


