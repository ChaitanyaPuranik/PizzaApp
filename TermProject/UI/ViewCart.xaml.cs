using Microsoft.UI.Xaml.Controls;
using System.Windows.Input;
using TermProject.Business_Logic;

namespace TermProject.UI;

public partial class ViewCart : ContentPage
{
	private Manager _manager;
	private Bill _bill;
	public ICommand RemoveFromCartCommand { get; set; }
	
	public ViewCart(Manager manager)
	{
		InitializeComponent();
		RemoveFromCartCommand = new Command<Pizza>(OnRemoveFromCart);
		_manager = manager;
        _bill = new Bill(_manager);
		
		BillLabel.Text = $"""
			Items: {_manager.SelectedPizzas.Count()}
			Items Price: ${_bill.ItemsPrice}
			HST(13%): ${_bill.HST}
			Total Price: ${_bill.TotalPrice}
			""";
        
		BindingContext = this;
		PizzaCollection.ItemsSource = _manager.SelectedPizzas;
		ClearCartbuttonVisibility();
    }

	private void ClearCartbuttonVisibility()
	{
		if(_manager.SelectedPizzas.Count == 0)
		{
			ClearCartButton.IsEnabled = false;
			ClearCartButton.IsVisible = false;

			EmptyButton.IsEnabled = true;
			EmptyButton.IsVisible = true;
			EmptyLabel.IsEnabled = true;
			EmptyLabel.IsVisible = true;
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

    private void OnClickCheckOut(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TermProject.UI.CheckOutPage());
    }
}