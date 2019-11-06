using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }
        public string City { get; set; }

        [StringLength(maximumLength: 2)]
        public string State { get; set; }
        [Range(18, 100)]
        public int Age { get; set; }
        public string pWord { get; set; }

        public List<Account> Accounts { get; set; }
    }
}
