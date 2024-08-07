using TermProject.UI;

namespace TermProject
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnTapGetStarted(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new TermProject.UI.MenuPage());
        }
    }

}
