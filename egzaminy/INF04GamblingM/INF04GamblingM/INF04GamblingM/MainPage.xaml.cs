using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace INF04GamblingM
{
    public partial class MainPage : ContentPage
    {
        public int score = 0;
        public const int PHOTOCOUNT = 5;
        public MainPage()
        {
            InitializeComponent();
        }

        public static List<int> Randomize()
        {
            int throws = 5;
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
            }
            list.Add(sum); // Ostatni indeks jest sumą
            return list; 
        }

        private void btnRandomize_Clicked(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> results = Randomize();
            score += results[6];
            img1.Source = ImageSource.FromFile($"dice{results[0]}.png");
            img2.Source = ImageSource.FromFile($"dice{results[1]}.png");
            img3.Source = ImageSource.FromFile($"dice{results[2]}.png");
            img4.Source = ImageSource.FromFile($"dice{results[3]}.png");
            img5.Source = ImageSource.FromFile($"dice{results[4]}.png");
            lblCurrent.Text = $"Wynik tego losowania: {results[6]}";
            lblTotal.Text = $"Wynik gry: {score}";
        }

        private void btnReset_Clicked(object sender, EventArgs e)
        {
            score = 0;
                img1.Source = ImageSource.FromFile("question.png");
                img2.Source = ImageSource.FromFile("question.png");
                img3.Source = ImageSource.FromFile("question.png");
                img4.Source = ImageSource.FromFile("question.png");
                img5.Source = ImageSource.FromFile("question.png");
        }


    }
}
