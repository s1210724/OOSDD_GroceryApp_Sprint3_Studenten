
using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Services
{
    public interface IAuthService
    {
        Client? Login(string email, string password);
        int GetCount();
        Client? Add(Client? client);
    }
}
