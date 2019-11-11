using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Transaction
    {
        public int CustomerId { get; set; }
        [Display(Name = "To Account : ID")]
        public int toAccountId {get; set;}

        public int Id { get; set; }

        [Display(Name = "To Account Type")]
        public string toAccType { get; set; }
        [Display(Name = "From Account : ID")]
        public int fromAccountId { get; set; }
        [Display(Name = "From Account Type")]
        public string fromAccType { get; set; }
        [Display(Name = "Amount")]
        public int tranSum { get; set; }
        [Display(Name = "Transaction Type")]
        public string transType { get; set; }

        public DateTime timeStamp { get; set; }

    }
}
