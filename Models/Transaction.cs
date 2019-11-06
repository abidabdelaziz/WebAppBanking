using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Transaction
    {
        public int CustomerId { get; set; }

        public int toAccountId {get; set;}

        public string toAccType { get; set; }

        public int fromAccountId { get; set; }

        public string fromAccType { get; set; }
        public int tranSum { get; set; }

        public DateTime timeStamp { get; set; }

    }
}
