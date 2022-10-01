using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Persistence
{
    public abstract class AuditableEntity
    {
        [MaxLength(50)]
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }

        [MaxLength(50)]
        public string LastModifiedBy { get; set; }
        public DateTime LastModified { get; set; }

    }
}
