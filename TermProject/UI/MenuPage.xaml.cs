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
		RightSideListView.BindingContext = _manager.Pizzas2;
		LeftSideListView.BindingContext = _manager.Pizzas1;


	}

    private void OnClickAdd(object sender, SelectedItemChangedEventArgs e)
    {
		
		_manager.AddToOrder((Pizza)LeftSideListView.SelectedItem);
		DisplayAlert("Success",$"{LeftSideListView.SelectedItem} added to Cart","Ok");

	}

    private void OnClickAddPizza(object sender, SelectedItemChangedEventArgs e)
    {
        _manager.AddToOrder((Pizza)RightSideListView.SelectedItem);
        DisplayAlert("Success", $"{RightSideListView.SelectedItem} added to Cart", "Ok");
    }

    private async void OnClickViewCart(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new TermProject.UI.ViewCart(_manager));
    }
}