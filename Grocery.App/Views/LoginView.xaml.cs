using Grocery.App.ViewModels;
using Grocery.Core.Interfaces.Services;

namespace Grocery.App.Views;

public partial class LoginView : ContentPage
{
    private readonly IAuthService _authService;
    private readonly GlobalViewModel _global;
	private readonly IClientService _clientService;
    public LoginView(LoginViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

	private void GotoRegisterView(object sender, EventArgs e)
	{
        // call function in view model
        ((LoginViewModel)BindingContext).GotoRegisterView();
    }
}