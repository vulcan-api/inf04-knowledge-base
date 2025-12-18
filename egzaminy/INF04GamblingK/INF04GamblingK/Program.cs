using System.ComponentModel;
using System.Security.Cryptography;

namespace INF04GamblingK
{
    class Program
    {
        /* *******************
         * nazwa: Randomize()
         * opis: Losuje 3-10 kostek oraz zwraca sumę punktów (punkty są sumowane dla numerów kostek wyrzuconych >= 2 razy)
         * parametry: brak
         * zwracany typ: brak
         *     
         * */
        public static void Randomize()
        {
            int throws = 0;
            bool continuation = true;
            while (continuation)
            {
                Console.WriteLine("Ile kostek chcesz rzucić? (3-10)");
                throws = int.Parse(Console.ReadLine());
                if (throws <= 10 && throws >= 3)
                {
                    continuation = false;
                }
            }
            Random rnd = new Random();
            int sum = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < throws; i++)
            {
                int randNum = rnd.Next(1, 7);
                if (list.Contains(randNum))
                {
                    sum += randNum;
                }
                list.Add(randNum);
                Console.WriteLine($"Kostka {i}: {randNum}");
            }
            Console.WriteLine($"Liczba uzyskanych punktów {sum}");
            Console.WriteLine("Jeszcze raz? T/N");
            String tryAgain = Console.ReadLine();
            tryAgain = tryAgain.ToUpper();
            if (tryAgain.Equals("T"))
            {
                Randomize();
            }
            else
            {
                Console.WriteLine("Dzięki za grę");
            }
        }

        public static void Main(string[] args)

        {

            Randomize();

        }
    }

}
