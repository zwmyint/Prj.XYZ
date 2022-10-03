using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Provider
    {
        public string ProviderName { get; set; }
        public string DepartmentName { get; set; }
        public string Time { get; set; }
        public string Duration { get; set; }
        public ProviderId[] ProviderIDs { get; set; }
        public DepartmentId[] DepartmentIDs { get; set; }
        public string[] Blocks { get; set; }
    }
}
