using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Line
    {
        public int LineNumber { get; set; }
        public string Value { get; set; }
        public object Sublines { get; set; }
    }
}
