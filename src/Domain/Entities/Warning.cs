﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Warning
    {
        public int WarningCode { get; set; }
        public string[] WarningText { get; set; }
    }
}
