using Grocery.App.ViewModels;

namespace Grocery.App.Views;

public partial class GroceryListItemsView : ContentPage
{
	public GroceryListItemsView(GroceryListItemsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }

	public void SearchProducts(object sender, TextChangedEventArgs e)
	{
        // go to SearchProducts in viewmodel
        ((GroceryListItemsViewModel)BindingContext).SearchProducts(e.NewTextValue);
    }
}