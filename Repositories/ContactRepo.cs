using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UModule.Database.EF;

namespace UModule.Database.Repositories
{
    public class ContactRepo
    {
        GenericRepository<Contact> _clientRepository = new GenericRepository<Contact>();

        public Task<Contact> GetContactByIdAsync(int id)
        {
            return _clientRepository.GetByIdAsync(id);
        }

        public Task<List<Contact>> GetAllContactsAsync()
        {
            return _clientRepository.GetAllAsync();
        }

        public Task<Contact> AddContactAsync(Contact client)
        {
            return _clientRepository.AddAsync(client);
        }

        public Task<Contact> UpdateContactAsync(Contact client)
        {
            return _clientRepository.UpdateAsync(client);
        }

        public Task<Contact> DeleteContactAsync(int id)
        {
            return _clientRepository.DeleteAsync(id);
        }
    }
}

