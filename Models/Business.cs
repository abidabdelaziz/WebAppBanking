﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    class Business : Account
    {
        public int OverDraft { get; set; } = 500;
    }
}
