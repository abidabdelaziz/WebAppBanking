using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ViewModel
{
    class CustAccountsVM
    {
        public Customer Customer { get; set; }
        public List<Account> CustAccounts { get; set; }
    }
}
