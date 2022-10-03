using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Persistence
{
    [Table("ATGN_Setting_MA")]
    public class Setting : AuditableEntity
    {
        [Key]
        public int OID { get; set; }
        public string SettingKey { get; set; }
        public string SettingValue { get; set; }
        public string SettingCategory { get; set; }
        public bool IsActive { get; set; }
    }
}
