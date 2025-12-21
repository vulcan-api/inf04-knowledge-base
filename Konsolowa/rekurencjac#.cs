// rekurencja - polega na wywołaniu przez funkcję samej siebie
// Zamiast liczyć wszystko naraz, dzieli problem na mniejsze części
using System;

// FUNKCJA suma
// - dostaje liczbę n
// - oblicza sumę liczb od 1 do n
// - robi to za pomocą rekurencji 


static long Suma(int n)
{
    // SPRAWDZENIE WARUNKU ZATRZYMANIA REKURENCJI
    // Jeżeli n jest mniejsze niż 1 (czyli 0 albo liczba ujemna)
    // to znaczy, że nie ma już liczb do dodawania
    if (n < 1)
        return 0;

    // JEŚLI WARUNEK WYŻEJ NIE ZOSTAŁ SPEŁNIONY:
    // - dodajemy aktualną wartość n
    // - wywołujemy funkcję Suma jeszcze raz, ale z (n - 1)
    // Czyli: Suma(5) = 5 + Suma(4)
    return n + Suma(n - 1);
}

static void Main()
{
    int n;  // zmienna, w której przechowamy liczbę podaną przez użytkownika

    // wypisujemy na ekran tekst, który prosi użytkownika o liczbę
    Console.Write("Podaj liczbe: ");

    // wczytujemy liczbę z klawiatury i zapisujemy ją do zmiennej n
    n = int.Parse(Console.ReadLine());

    // wywołujemy funkcję Suma(n)
    // obliczony wynik zostanie zwrócony przez funkcję i od razu wypisany na ekran
    Console.WriteLine("Suma " + n + " kolejnych liczb naturalnych wynosi "
                      + Suma(n));
}


// algorytm euklidesa
using System;

// Funkcja rekurencyjna obliczająca NWD 


static int NWD(int a, int b)
{
    // Jeżeli liczby NIE są sobie równe,
    // to liczymy dalej
    if (a != b)
        // REKURENCJA
        // jeśli a > b, to wywołujemy NWD(a - b, b)
        // jeśli b > a, to wywołujemy NWD(a, b - a)
        return NWD(
            a > b ? a - b : a,
            b > a ? b - a : b
        );

    // jeżeli a = b to zwracamy tę wartość jako wynik
    return a;
}

static void Main()
{
    int a, b;   // zmienne do przechowania dwóch liczb

    // prosimy użytkownika o podanie dwóch liczb
    Console.Write("Podaj dwie liczby: ");

    // wczytujemy dwie liczby z klawiatury
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());

    // wypisujemy wynik działania funkcji NWD
    Console.WriteLine("NWD(" + a + "," + b + ") = " + NWD(a, b));
}
