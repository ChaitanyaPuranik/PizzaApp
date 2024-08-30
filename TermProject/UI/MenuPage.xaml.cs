using System.Windows.Input;
using TermProject.Business_Logic;
using TermProject.UI;


namespace TermProject.UI;

public partial class MenuPage : ContentPage
{
    private Manager _manager = new Manager();

    public ICommand AddToCartCommand { get; set; }
    public ICommand IncreaseQuantityCommand { get; set; }
    public ICommand DecreaseQuantityCommand { get; set; }

    public MenuPage()
    {
        InitializeComponent();
        BindingContext = this;
        PizzaCollection.ItemsSource = _manager.Pizzas;

        AddToCartCommand = new Command<Pizza>(OnAddToCart);
        IncreaseQuantityCommand = new Command<Pizza>(IncreaseQuantity);
        DecreaseQuantityCommand = new Command<Pizza>(DecreaseQuantity);
    }

    private void OnAddToCart(Pizza selectedPizza)
    {
        _manager.AddToOrder(selectedPizza);
        DisplayAlert("", $"{selectedPizza.Name} added to cart", "Ok");

        selectedPizza.IsAddButtonVisible = false;
        selectedPizza.IsQuantityControlsVisible = true;
        selectedPizza.Quantity = 1; // Start with quantity 1
    }

    private void IncreaseQuantity(Pizza selectedPizza)
    {
        selectedPizza.Quantity += 1;
    }

    private void DecreaseQuantity(Pizza selectedPizza)
    {
        if (selectedPizza.Quantity > 1)
        {
            selectedPizza.Quantity -= 1;
        }
    }


    private async void OnClickViewCart(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewCart(_manager));
    }
}


