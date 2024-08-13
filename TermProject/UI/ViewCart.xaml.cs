using TermProject.Business_Logic;

namespace TermProject.UI;

public partial class ViewCart : ContentPage
{
	Manager _manager;

	public ViewCart(Manager manager)
	{
		InitializeComponent();
		_manager = manager;
        Bill _bill = new Bill(_manager);
		TotalPriceLabel.Text = $"$ {_bill.TotalPrice.ToString()}";
        BindingContext = _manager.SelectedPizzas;
		CheckIsCartEmpty();
		ClearCartbuttonVisibility();
		TotalItemsLabel.Text = _manager.SelectedPizzas.Count.ToString();
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

	private void ClearCartbuttonVisibility()
	{
		if(_manager.SelectedPizzas.Count == 0)
		{
			ClearCartButton.IsEnabled = false;
			ClearCartButton.IsVisible = false;
		}
	}

    private async void OnClickGoToMenu(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }

    private void RemoveOnTap(object sender, SelectedItemChangedEventArgs e)
    {
		_manager.Remove((Pizza)MenuListView.SelectedItem);
		CheckIsCartEmpty();
    }

    private void OnClickClearCart(object sender, EventArgs e)
    {
		_manager.SelectedPizzas.Clear();
		CheckIsCartEmpty();
    }

    private void OnTapCheckout(object sender, TappedEventArgs e)
    {
		Navigation.PushAsync(new TermProject.UI.CheckOutPage());
    }
}