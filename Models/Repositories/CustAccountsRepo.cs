using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.ViewModel;

namespace Models.Repositories
{
    class CustAccountsRepo
    {
        private readonly AppDbContext _context;

        public CustAccountsRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<CustAccountsVM> GetAccs(int id)
        {
            var customer = await _context.Customer.FirstOrDefaultAsync(m => m.Id == id);
            var custAccounts = new CustAccountsVM();
            custAccounts.Customer = customer;

            var orders = await _context.Accounts
                //.Where(o => o.Id == id)
                .ToListAsync<Account>();

            custAccounts.CustAccounts = orders;


            return custAccounts;
        }
    }
}
