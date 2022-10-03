using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class VisitType
    {
        public string Name { get; set; }
        public bool IsPanel { get; set; }
        public Id[] IDs { get; set; }
    }
}
