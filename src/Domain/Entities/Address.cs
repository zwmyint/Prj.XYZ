﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Address
    {
        public string[] Street { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HouseNumber { get; set; }
        public string District { get; set; }
        public string Building { get; set; }
        public string Floor { get; set; }
        public string Unit { get; set; }
    }
}
