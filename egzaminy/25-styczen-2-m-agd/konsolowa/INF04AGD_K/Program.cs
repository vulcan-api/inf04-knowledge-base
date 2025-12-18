using System.Security.Cryptography.X509Certificates;

namespace INF04AGD_K
{ 
    abstract class Urzadzenie
    {
        /* ********
         * nazwa: WyswietlKomunikat
         * opis: Wyświetla komunikat
         * parametry: brak
         * zwracany typ i opis: brak
         * autor: 06#######4
         * 
         * ********** */
        public virtual void WyswietlKomunikat(String komunikat)
        {
            Console.WriteLine($"{komunikat}");
        }
    }
    class Pralka : Urzadzenie
    {
        private int nrPrania = 0;

        /* ********
    * nazwa: setProgram
    * opis: Ustawia wartość dla nrPrania
    * parametry: int program 
    * zwracany typ i opis: Ustawia wartość "program" dla zmiennej nrPrania. Zwraca nowy nrPrania
    * autor: 06#######4
    * 
    * ********** */
        public int setProgram(int program)
        {
            if (program >= 1 && program <= 12)
            {
                nrPrania = program;
                Console.WriteLine("Program został ustawiony");
                return nrPrania;
            }
            else
            {
                Console.WriteLine("Podano niepoprawny numer programu");
                return -1;
            }
            
        }
    }
    class Odkurzacz : Urzadzenie
    {
        private bool stanOdkurzacz = false;

        /* ********
    * nazwa: on
    * opis: Ustawia wartość stanOdkurzacz na true
    * parametry: brak
    * zwracany typ i opis: brak, Wyświetla komunikat o włączeniu odkurzacza
    * autor: 06#######4
    * 
    * ********** */
        public void on()
        {

            if (!stanOdkurzacz)
            {
                stanOdkurzacz = true;
                WyswietlKomunikat("Odkurzacz włączono");
            }
            else return; 

        }
        /* ********
    * nazwa: off
    * opis: Wyłącza odkurzacz (zmienia zmienna stanOdkurzacz na false
    * parametry: brak
    * zwracany typ i opis: brak. Wyświetla komunikat o wyłączeniu odkurzacza
    * autor: 06#######4
    * 
    * ********** */
        public void off()
        {
            if (stanOdkurzacz)
            {
                WyswietlKomunikat("Odkurzacz wyłączono");
                stanOdkurzacz = false;
            }
            else return; 
        }
        public override void WyswietlKomunikat(string komunikat)
        {
          if (stanOdkurzacz)
            {
                Console.WriteLine(komunikat);
            }
          else
            {
                return;
            }
        }
    }
    class Program
    {
       public static void Main(string[] args)
        {
            Odkurzacz odkurzacz = new Odkurzacz();
            Pralka pralka = new Pralka();
            Console.WriteLine("Podaj numer prania: ");
            int program = int.Parse(Console.ReadLine());
            pralka.setProgram(program);
            odkurzacz.on();
            odkurzacz.on();
            odkurzacz.on();
            odkurzacz.WyswietlKomunikat("Odkurzacz wyładował się");
            odkurzacz.off();
        }

    }

}