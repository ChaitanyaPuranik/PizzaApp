using System.Windows.Input;
using TermProject.Business_Logic;

namespace TermProject.UI;

public partial class ViewCart : ContentPage
{
	Manager _manager;
	public ICommand RemoveFromCartCommand { get; set; }

	public ViewCart(Manager manager)
	{
		InitializeComponent();
		_manager = manager;
		RemoveFromCartCommand = new Command<Pizza>(OnRemoveFromCart);
        Bill _bill = new Bill(_manager);
		TotalPriceLabel.Text = $"$ {_bill.TotalPrice.ToString()}";
        BindingContext = this;
		PizzaCollection.ItemsSource = _manager.SelectedPizzas;
		ClearCartbuttonVisibility();
		TotalItemsLabel.Text = _manager.SelectedPizzas.Count.ToString();
	}

	private void ClearCartbuttonVisibility()
	{
		if(_manager.SelectedPizzas.Count == 0)
		{
			ClearCartButton.IsEnabled = false;
			ClearCartButton.IsVisible = false;
		}
	}

	private void OnRemoveFromCart(Pizza selectedPizza)
	{
		_manager.RemoveFromCart(selectedPizza);
        DisplayAlert("", $"{selectedPizza.Name} removed from cart", "Ok");

    }

    private async void OnClickGoToMenu(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }


    private void OnClickClearCart(object sender, EventArgs e)
    {
		_manager.SelectedPizzas.Clear();
    }

    private void OnTapCheckout(object sender, TappedEventArgs e)
    {
		Navigation.PushAsync(new TermProject.UI.CheckOutPage());
    }
}