using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ViewModel
{
    public class CustAccountsVM
    {
        public Transaction CustTransaction { get; set; }
        public Account ActiveAccount { get; set; }
        public List<Account> CustAccounts { get; set; }
    }
}
