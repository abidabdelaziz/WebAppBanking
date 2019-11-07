using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public interface ICustAccountsRepository
    {

        Task<List<Customer>> GetCust();
        Task<Account> Get(int? id);
        Task<List<Account>> GetAccs(int id);
        Task<bool> Create(Account account);
        Task<bool> Delete(int id);
        bool AccountExists(int id);
    }
}
