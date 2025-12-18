namespace INF04CzcionkaK
{


    public class Program
    {

        public static void BubbleSort(List<int> list, int length)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        list[j] = list[j] ^ list[j + 1];
                        list[j + 1] = list[j] ^ list[j + 1];
                        list[j] = list[j] ^ list[j + 1];
                    }
                }
            }
            Console.WriteLine("Posortowana tablica: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]}, ");
            }

        }

        public static void Main(string[] args)
        {
            Random random = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(random.Next(0, 1000));
            }
            BubbleSort(list, list.Count);
        }

    }
}