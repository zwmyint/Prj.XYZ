using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Persistence
{
    [Table("ATGN_Users_MA")]
    public class User : AuditableEntity
    {
        [Key]
        public long OID { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string Hashed { get; set; }
        public bool IsActive { get; set; }
    }
}
