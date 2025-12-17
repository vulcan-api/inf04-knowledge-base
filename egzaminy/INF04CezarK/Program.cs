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
                }//przesunięcie o daną ilośc z klucza
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