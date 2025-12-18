using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace INF04WeterynarzM
{
    public partial class MainPage : ContentPage
    {
        public List<string> animals = new List<string> { "Pies", "Kot", "Świnka morska"};
        public MainPage()
        {
            InitializeComponent();
            pickerAnimal.ItemsSource = animals;
        }

        private void btnOK_Clicked(object sender, EventArgs e)
        {
            String name = textName.Text;
            String issue = textIssue.Text;
            String animal = pickerAnimal.SelectedItem.ToString();
            String time = timePicker.Time.ToString();
           DisplayAlert("Zapisana wizyta", $"{name}, {animal}, {issue}, {time}", "OK");
        }

        private void pickerAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentAnimal = animals[pickerAnimal.SelectedIndex];
            switch(currentAnimal)
            {
                case "Pies":
                    sliderAge.Maximum = 20;
                    break;
                case "Kot":
                    sliderAge.Maximum = 18;
                    break;
                case "Świnka morska":
                    sliderAge.Maximum = 9;
                    break;
            }
        }
    }
}
