using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Services
{
    public interface IClientService
    {
        public Client? Get(string email);

        public Client? GetId(int id);

        public int GetCount();

        public Client? Add(Client client);

        public List<Client> GetAll();
    }
}
