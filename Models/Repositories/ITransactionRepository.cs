using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    interface ITransactionRepository
    {
        Task<Transaction> Get(int? id);
        Task<List<Transaction>> Get();
        Task<bool> Create(Transaction transaction);
        bool TransactionExists(int id);

    }
}
