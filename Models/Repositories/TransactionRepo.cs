using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Models.Repositories
{

    // Class Implements the Transaction Repo and provides methods
    // The Transaction Repo is passed the dB Context in order to allow
    // methods to communicate with Model and therefore reflect changes
    //in dB
    public class TransactionRepo : ITransactionRepository
    {
        private AppDbContext _context;

        public TransactionRepo(AppDbContext ctx)
        {
            _context = ctx;
        }
        public async Task<Transaction> Get(int? id)
        {
            var transaction = await _context.Transactions
               .FirstOrDefaultAsync(m => m.Id == id);

            return transaction;
        }
        public async Task<List<Transaction>> Get()
        {
            var transaction = await _context.Transactions.ToListAsync();
            return transaction;
        }
        public async Task<bool> Create(Transaction transaction)
        {
            _context.Add(transaction);
            await _context.SaveChangesAsync();

            return true;
        }

        public bool TransactionExists(int id)
        {
            return _context.Transactions.Any(e => e.Id == id);
        }


    }
}
