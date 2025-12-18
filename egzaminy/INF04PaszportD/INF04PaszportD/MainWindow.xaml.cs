using System.Diagnostics.Eventing.Reader;
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

namespace INF04PaszportD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            String fname = inFname.Text;
            String lname = inLname.Text;
            String eyes = "";
            if (rbBlue.IsChecked == true)
            {
                eyes += "niebieski";
            }
            if (rbGreen.IsChecked == true)
            {
                eyes += "zielony";          
            }
            if (rbHazel.IsChecked == true)
            {
                eyes += "piwny";
            }
            if (eyes.Equals(""))
            {
                eyes = "nie podano";
            }
                MessageBox.Show($"{fname} {lname} kolor oczu: {eyes}", "Dodano paszport");
        }

        private void inNum_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            string num = inNum.Text;
            List<string>availableValues = new List<string> {"000", "111", "222", "333"};
            if (availableValues.Contains(num))
            {
                imgFace.Source = new BitmapImage(new Uri($"{num}-zdjecie.png", UriKind.Relative));
                imgFinger.Source = new BitmapImage(new Uri($"{num}-odcisk.jpg", UriKind.Relative));
            }
        }
    }
}