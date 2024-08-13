namespace TermProject.UI;

public partial class CheckOutPage : ContentPage
{
	public CheckOutPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        CheckImage.ScaleTo(1.5);
        Label.ScaleTo(1.5);

        await CheckImage.ScaleTo(0.5);
        await CheckImage.ScaleTo(1.5);
        await CheckImage.ScaleTo(0.5);
        await CheckImage.ScaleTo(1.5);
        await CheckImage.ScaleTo(0.5);
        await CheckImage.ScaleTo(1);

        HomeButton.FadeTo(1, length: 500);
        await HomeButton.ScaleTo(1);
    }

    private async void OnClickHomePage(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}