using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Models.Repositories
{

    // Class Implements the Cutomer Repo and provides methods
    // The Customer Repo is passed the dB Context in order to allow
    // methods to communicate with Model and therefore reflect changes
    //in dB
    public class AccountRepo : IAccountRepository
    {
        private AppDbContext _context;

        public AccountRepo(AppDbContext ctx)
        {
            _context = ctx;
        }
        public async Task<Account> Get(int? id)
        {
            var account = await _context.Accounts.FirstOrDefaultAsync();
               //.FirstOrDefaultAsync(m => m.Id == id);

            return account;
        }
        public async Task<List<Account>> Get()
        {
            var accounts = await _context.Accounts.ToListAsync();
            return accounts;
        }
        public async Task<bool> Create(Account account)
        {
            //Logic To Create Specific Account and add that to dB
            _context.Add(account);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var account = await this.Get((int?)id);
            _context.Accounts.Remove(account);
            await _context.SaveChangesAsync();

            return true;
        }

        public bool AccountExists(int id)
        {
            return _context.Accounts.Any(e => e.Id == "qq");
        }


    }
}
