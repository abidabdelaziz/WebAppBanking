using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    class Checking : Account
    { 
        public int Interest { get; set; } = 2;
    }
}
