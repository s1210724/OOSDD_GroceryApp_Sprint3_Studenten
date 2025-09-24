
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Grocery.App.Views;
using Grocery.Core.Helpers;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using Grocery.Core.Services;

namespace Grocery.App.ViewModels
{
    public partial class RegisterViewModel : BaseViewModel
    {
        private readonly IAuthService _authService;
        private readonly GlobalViewModel _global;
        private readonly IClientService _clientService;

        [ObservableProperty]
        private string email = "newUser@mailserver.com";

        [ObservableProperty]
        private string password = "verrystrongpassw123456789";

        [ObservableProperty]
        private string name = "J.C. Cremer";

        public RegisterViewModel(IAuthService authService, GlobalViewModel global, IClientService clientService)
        { //_authService = App.Services.GetServices<IAuthService>().FirstOrDefault();
            _authService = authService;
            _global = global;
            _clientService = clientService;
        }

        [RelayCommand]
        private void Register()
        {
            // get amount of clients
            int Id = _clientService.GetCount();

            // create new client with given info and use count as id (count starts at one id's at 0 so no extra math needed
            Client newClient = new Client(
                Id,
                Name,
                Email,
                PasswordHelper.HashPassword(Password) // store hashed version of Password
            );

            // add client to client repository
            Client? addedClient = _clientService.Add(newClient);

            // go to login view if added successfully
            GotoLoginView();

        }

        [RelayCommand]
        public void GotoLoginView()
        {
            var LoginViewModel = new LoginViewModel(_authService, _global, _clientService);
            Application.Current.MainPage = new LoginView(LoginViewModel);
        }
    }
}
