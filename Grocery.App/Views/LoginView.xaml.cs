using Grocery.App.ViewModels;
using Grocery.Core.Interfaces.Services;

namespace Grocery.App.Views;

public partial class LoginView : ContentPage
{
    private readonly IAuthService _authService;
    private readonly GlobalViewModel _global;
    public LoginView(LoginViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

	private void GotoRegisterView(object sender, EventArgs e)
	{
		var viewModel = (LoginViewModel)BindingContext;
		var registerViewModel = new RegisterViewModel(_authService, _global);
		Application.Current.MainPage = new RegisterView(registerViewModel);
    }
}