using TermProject.Business_Logic;


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
}