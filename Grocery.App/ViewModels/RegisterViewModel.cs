
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.App.ViewModels
{
    public partial class RegisterViewModel : BaseViewModel
    {
        private readonly IAuthService _authService;
        private readonly GlobalViewModel _global;

        [ObservableProperty]
        private string email = "user3@mail.com";

        [ObservableProperty]
        private string password = "user3";

        [ObservableProperty]
        private string name = "J.C. Cremer";

        public RegisterViewModel(IAuthService authService, GlobalViewModel global)
        { //_authService = App.Services.GetServices<IAuthService>().FirstOrDefault();
            _authService = authService;
            _global = global;
        }

        [RelayCommand]
        private void Register()
        {
            //Client? registeredClient = _authService.Register(Name, Email, Password);
            //if (registeredClient != null)
            //{
            //    Application.Current.MainPage = new AppShell();
            //    _global.Client = registeredClient;
            //}
            //else
            //{
            //    // Show error message
            //}
        }
    }
}
