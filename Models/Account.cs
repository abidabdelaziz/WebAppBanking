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
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public DateTime OpenDate { get; set; }

        [Required]
        public int Sum { get; set; }

        [Required]
        public string accType { get; set; }

        public virtual Customer Customer { get; set; }

    }
}