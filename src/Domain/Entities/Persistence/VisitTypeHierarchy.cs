using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Persistence
{
    [Table("ATGN_VisitTypeHierarchy_MA")]
    public class VisitTypeHierarchy : AuditableEntity
    {
        [Key]
        public long OID { get; set; }
        public string VisitTypeName { get; set; }
        public string VisitTypeId { get; set; }
        public string VisitTypeIdType { get; set; }
        public string VisitTypeRank { get; set; }
        public string VisitGroupId { get; set; }
        public string VisitGroupRank { get; set; }
        public string VisitGroupCategory { get; set; }
        public bool? MergeableVisitTypeGroup { get; set; }
        public bool IsActive { get; set; }
    }
}
