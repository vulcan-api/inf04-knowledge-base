using System;
using System.Collections.Generic;

class Program
{
    static bool CzyIstniejeWWierszu(List<int> row, int liczba)
    {
        foreach (var item in row)
        {
            if (item == liczba)
                return true;
        }
        return false;
    }

    /*
    **************************************

    nazwa funkcji :     CzyIstniejeWWierszu

    opis funkcji :      sprawdza czy istnieje już wartość którą chcemy wprowadzić w tym wierszu

    paramtry:           List<int> row , lista będąca wierszem w dwuwymiarowej liście tablica2D
                        int liczba , liczba pseudolosowa którą sprawdzamy czy istnieje w obecnej wersji listy

    zwracany typ :      typ boolean true lub false w zależności od tego czy liczba juz istnieje

    **************************************
    */
    static void Losuj(List<List<int>> tab, int ilosclosowan)
    {
        Random rand = new Random();

        for (int i = 0; i < ilosclosowan; i++)
        {
            while (tab[i].Count < 6)
            {
                int losowa = rand.Next(1, 50); // 1 do 49 włącznie
                if (!CzyIstniejeWWierszu(tab[i], losowa))
                {
                    tab[i].Add(losowa);
                }
            }
        }
    }

    /*
    **************************************

    nazwa funkcji :     Losuj

    opis funkcji :      odpowiada za wylosowanie i wpisanie do listy dwuwymiarowej danych pseudolosowych od 1 do 49

    paramtry:           List<List<int>> tab , referencja na dwuwymiarową listę którą uzupełniamy
                        int ilosclosowan , ilosc wierszy w dwuwymiarowej liście

    zwracany typ :      brak

    **************************************
    */
    static void Wyswietl(List<List<int>> tab)
    {
        int[] wystapienia = new int[50];

        for (int i = 0; i < tab.Count; ++i)
        {
            Console.Write("Losowanie " + (i + 1) + ": ");
            foreach (var liczba in tab[i])
            {
                Console.Write(liczba + " ");
                wystapienia[liczba]++;
            }
            Console.WriteLine();
        }

        for (int i = 1; i < 50; i++)
        {
            Console.WriteLine("Wystapienie liczby " + i + ": " + wystapienia[i]);
        }
    }

    /*
    **************************************

    nazwa funkcji :     Wyswietl

    opis funkcji :      odpowiada za wypisanie i policzenie wystąpień wylosowanych danych pseudolosowych od 1 do 49

    paramtry:           List<List<int>> tab , referencja na dwuwymiarową listę którą wypisujemy

    zwracany typ :      brak

    **************************************
    */
    static void Main()
    {
        Console.WriteLine("Ile wygenerowac losowań");
        int liczbaZestawuw = int.Parse(Console.ReadLine());

        List<List<int>> tablica2D = new List<List<int>>(liczbaZestawuw);
        for (int i = 0; i < liczbaZestawuw; i++)
        {
            tablica2D.Add(new List<int>());
        }

        Console.WriteLine("zestawy wylosowanych liczb :");
        Losuj(tablica2D, liczbaZestawuw);
        Wyswietl(tablica2D);
    }
}