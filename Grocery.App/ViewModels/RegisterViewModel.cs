
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
        private string email = "user3@mail.com";

        [ObservableProperty]
        private string password = "user3";

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
            int Id = _authService.GetCount();

            // create new client with given info and use count as id (count starts at one id's at 0 so no extra math needed
            Client newClient = new Client(
                Id,
                Name,
                Email,
                PasswordHelper.HashPassword(Password) // store hashed version of Password
            );

            // add client to client repository
            Client? addedClient = _authService.Add(newClient);

            // now log in to system with new account and initiate main AppShell
            Client? authenticatedClient = _authService.Login(Email, Password);
            _global.Client = authenticatedClient;
            Application.Current.MainPage = new AppShell();
        }
    }
}
