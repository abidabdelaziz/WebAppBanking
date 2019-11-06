using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    class CD : Account
    {
        [DataType(DataType.Date)]
        [Display(Name = "Maturity Date")]
        public DateTime Maturity { get; set; }
        public int Interest { get; set; } = 5;
    }
}
