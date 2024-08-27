using System.Windows.Input;
using TermProject.Business_Logic;
using TermProject.UI;


namespace TermProject.UI;

public partial class MenuPage : ContentPage
{
	private Manager _manager = new Manager();


	public MenuPage()                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
	{
		InitializeComponent();
		BindingContext = _manager.Pizzas;


	}


    private async void OnClickViewCart(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new TermProject.UI.ViewCart(_manager));
    }

    private void OnSelectingItem(object sender, SelectionChangedEventArgs e)
    {
		_manager.AddToOrder(((Pizza)PizzaCollection.SelectedItems));
		DisplayAlert("",$"{(Pizza)PizzaCollection.SelectedItems} added to cart","Ok");
    }
}