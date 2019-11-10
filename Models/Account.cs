using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Account
    {
        [Required]
        [Display(Name ="Account ID")]
        public string Id { get; set; }

        public string CustomerId { get; set; } 

        [Required]
        [Display(Name = "Date")]
        public DateTime OpenDate { get; set; }

        [Required]
        public int Sum { get; set; }

        [Required]
        [Display(Name = "Account Type")]
        public string accType { get; set; }


    }
}