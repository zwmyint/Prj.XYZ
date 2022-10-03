using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ExtraExtension
    {
        public string ExtensionName { get; set; }
        public string Value { get; set; }
        public ExtensionId[] ExtensionIDs { get; set; }
        public object Lines { get; set; }
    }
}
