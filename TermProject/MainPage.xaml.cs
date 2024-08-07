using TermProject.UI;

namespace TermProject
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnTapGetStarted(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new TermProject.UI.HomePage());
        }
    }

}
