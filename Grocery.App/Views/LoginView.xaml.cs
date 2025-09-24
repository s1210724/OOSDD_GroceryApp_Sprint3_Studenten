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
		//var viewModel = (LoginViewModel)BindingContext;
		//var registerViewModel = new RegisterViewModel(_authService, _global, _clientService);
		//Application.Current.MainPage = new RegisterView(registerViewModel);
		((LoginViewModel)BindingContext).GotoRegisterView();
    }
}