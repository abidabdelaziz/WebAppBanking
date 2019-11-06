using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dBClassLibrary
{
    public class Class1
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
        [Range(18, 60)]
        public int Age { get; set; }

        public List<Order> Orders { get; set; }
    }
}
