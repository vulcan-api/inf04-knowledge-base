using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace INF04DomekM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public int likeCount = 0;
        private void btnLike_Clicked(object sender, EventArgs e)
        {
            likeCount++;
            lblCount.Text = $"{likeCount} polubień";
        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {
            if (likeCount > 0)
            likeCount--;
            lblCount.Text = $"{likeCount} polubień";
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            // ... 
        }
    }
}
