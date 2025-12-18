using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace INF04PracownikD
{
    
    public partial class MainWindow : Window
    {
        public String pass = String.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            String name = txtName.Text;
            String lname = txtLname.Text;
            String role = cmbRole.Text;
            MessageBox.Show($"Dane pracownika: {name} {lname} {role}. Haslo: {pass}");
        }

        private void btnPass_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            String charList = "abcdefghijklmnopqerstuvyxzABCDEFGHIJKLMNOPRQSTUVXYZ";
            String numbers = "0123456789";
            String specialChars = " !@#$%^&*()_+-=";
            int passLen = int.Parse(txtChar.Text);
            if (letterFlag.IsChecked == true)
            {
                for (int i = 0; i < passLen - 2; i++)
                {
                    pass += charList[rnd.Next(0, charList.Length - 1)];

                }
            }

            if (numbersFlag.IsChecked == true)
            {
                pass += numbers[rnd.Next(0, specialChars.Length - 1)];
            }
            if (specialsFlag.IsChecked == true)
            {
                pass += specialChars[rnd.Next(0, specialChars.Length - 1)];
            }
         
            MessageBox.Show($"Wygenerowane haslo: {pass}");
        }
    }
}