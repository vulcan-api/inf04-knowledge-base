using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

class Program
{
        public static string Szyfruj(string tekst, int klucz)
        {
            klucz = klucz % 26; //klucz z przedziału 0 do 25
            char[] wynik = new char[tekst.Length]; 

            for (int i = 0; i < tekst.Length; i++)
            {
                char znak = tekst[i];   //rozbicie napisu na "tablice"

                if (znak >= 'a' && znak <= 'z')
                {
                    wynik[i] = (char)((znak - 'a' + klucz + 26) % 26 + 'a');

                //wynik[i] = (char)( ... ) zapewnia konwersje do typu char
                // znak - 'a'   zapewnia zamiane znaku na cyfre 'a' - 'a' = 0 , 'b' - 'a' = 1 , 'z' - 'a' = 25
                // + klucz      przesuwa o podany klucz 'a' → 0 + 3 = 3  ,  'x' → 23 + 3 = 26
                // + 26         zapewnia że liczby będą dodatnie
                // % 26         zapewnie że liczby nie wydją poza zakres
                // + 'a'        przywraca spowtorem do liter

            }
            else
                {
                    wynik[i] = znak;
                }
            }

            return new string(wynik);
        }


    static void Main()
    {
        Console.WriteLine("Podaj napis do zaszyfrowania:");
        string tekst = Console.ReadLine();      //zaczytanie napisu

        Console.WriteLine("Podaj klucz szyfrowania:");
        int klucz = Convert.ToInt32(Console.ReadLine());    //zaczytanie i przekonwertowanie klucza

        Console.WriteLine(Szyfruj(tekst, klucz));
    }
}