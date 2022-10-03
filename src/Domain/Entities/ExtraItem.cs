using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ExtraItem
    {
        public string ItemNumber { get; set; }
        public object Value { get; set; }
        public Line[] Lines { get; set; }
    }
}
