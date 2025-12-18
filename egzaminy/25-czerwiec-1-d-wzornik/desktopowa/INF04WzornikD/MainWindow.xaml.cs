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

namespace INF04WzornikD
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

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            BrushConverter converter = new BrushConverter();
            byte red = Convert.ToByte(sliderR.Value);
            byte green = Convert.ToByte(sliderG.Value);
            byte blue = Convert.ToByte(sliderB.Value);
            Color color = Color.FromRgb(red, green, blue);
            SolidColorBrush brush = new SolidColorBrush(color);
            rect.Fill = brush;
            outputText.Background = brush;
            outputText.Content = $"{red}, {green}, {blue}";

        }
    }
}