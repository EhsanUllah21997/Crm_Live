using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UModule.Database.EF;

namespace UModule.Database.Repositories
{
    public class ClientRepo
    {
        GenericRepository<Client> _clientRepository = new GenericRepository<Client>();
        public async Task<Client> GetClientByIdAsync(int id)
        {
            return await _clientRepository.GetByIdAsync(id);
        }

        public async Task<List<Client>> GetAllClientsAsync()
        {
            return await _clientRepository.GetAllAsync();
        }

        public async Task<Client> AddClientAsync(Client client)
        {
            return await _clientRepository.AddAsync(client);
        }

        public async Task<Client> UpdateClientAsync(Client client)
        {
            return await _clientRepository.UpdateAsync(client);
        }

        public async Task<Client> DeleteClientAsync(int id)
        {
            return await _clientRepository.DeleteAsync(id);
        }
    }

}