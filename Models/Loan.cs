using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    class Loan : Account
    {
        public int Interest { get; set; } = 4;
    }
}
