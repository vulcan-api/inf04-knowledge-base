using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using INF04AGD_K;

namespace INF04AGD_M
{
    public partial class MainPage : ContentPage
    {
        bool czyWlaczone = false;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnZatwierdz_Clicked(object sender, EventArgs e)
        {
            int nrPrania = int.Parse(entryPralka.Text);
            if (nrPrania > 0 && nrPrania < 13)
            {
                lblWynikP.Text = $"Numer prania: {nrPrania}";
            }
            else
            {
                lblWynikP.Text = "Nieprawidlowy numer prania";
            }

        }

        private void btnWlacz_Clicked(object sender, EventArgs e)
        {
            czyWlaczone = !czyWlaczone;
            string statusOdkurzacza = "";
            if (czyWlaczone)
            {
                czyWlaczone = true;
                btnWlacz.Text = "Wylącz";
                statusOdkurzacza += "Odkurzacz wlaczony";
            }
            else
            {
                czyWlaczone = false;
                btnWlacz.Text = "Wlącz";
                statusOdkurzacza += "Odkurzacz wylaczony";
            }
            lblWynikO.Text = statusOdkurzacza + "\n Status: Naladowany"; 
        }
    }
}
