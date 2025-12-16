using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace INF04RejestracjaM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnConfirm_Clicked(object sender, EventArgs e)
        {
            string email = emailIn.Text;
            string pswd = pswdIn.Text;
            string repswd = repswdIn.Text;
            if (email.Contains("@"))
            {
                if (String.Equals(pswd, repswd))
                {
                    welcomeLbl.Text = $"Witaj {email}";
                }
                else
                {
                    welcomeLbl.Text = "Hasła się różnią";
                }
            }
            else
            {
                welcomeLbl.Text = "Podany email jest nieprawidłowy";
            }
        }
    }
}
