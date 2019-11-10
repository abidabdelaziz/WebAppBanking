using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public interface IAccountRepository
    {
        Task<Account> Get(int? id);
        Task<List<Account>> Get();
        Task<bool> Create(Account account);
        Task<bool> Delete(int id);
        bool AccountExists(int id);
    }
}
