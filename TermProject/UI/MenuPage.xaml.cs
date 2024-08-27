using System.Windows.Input;
using TermProject.Business_Logic;
using TermProject.UI;


namespace TermProject.UI;

public partial class MenuPage : ContentPage
{
	private Manager _manager = new Manager();
	public ICommand AddToCartCommand {  get; set; }


	public MenuPage()                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
	{
		InitializeComponent();
		BindingContext = this;
		AddToCartCommand = new Command<Pizza>(OnAddToCart);
        PizzaCollection.ItemsSource = _manager.Pizzas;
    }


	private void OnAddToCart(Pizza selectedPizza)
	{
		_manager.AddToOrder(selectedPizza);
		DisplayAlert("", $"{selectedPizza.Name} added to cart", "Ok");
	}

    private async void OnClickViewCart(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new TermProject.UI.ViewCart(_manager));
    }

}