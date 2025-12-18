
namespace INF04CzcionkaM
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        public int index = 0;
        private void btnProceed_Clicked(object sender, EventArgs e)
        {

            List<String> demoText = new List<String>{"Dzień dobry", "Good morning", "Buenos dias"};
            lblDemo.FontSize = sliderSize.Value;
            index = index >= demoText.Count-1 ? 0 : index + 1;
            lblDemo.Text = demoText.ElementAt(index);
        }
    }
}
