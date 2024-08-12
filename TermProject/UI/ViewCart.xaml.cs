using TermProject.Business_Logic;

namespace TermProject.UI;

public partial class ViewCart : ContentPage
{
	Manager _manager;

	public ViewCart(Manager manager)
	{
		InitializeComponent();
		_manager = manager;
		BindingContext = _manager.SelectedPizzas;
		CheckIsCartEmpty();
	}

	public void CheckIsCartEmpty()
	{
		if(_manager.SelectedPizzas.Count == 0)
		{
			MenuListView.IsEnabled = false;
			MenuListView.IsVisible = false;

			EmptyButton.IsEnabled = true;
			EmptyButton.IsVisible = true;

			EmptyLabel.IsEnabled = true;
			EmptyLabel.IsVisible = true;
		}
		
	}

    private async void OnClickGoToMenu(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}