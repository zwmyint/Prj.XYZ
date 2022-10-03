using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Persistence
{
    [Table("ATGN_SolutionReport_TX")]
    public class SolutionReport : AuditableEntity
    {
        [Key]
        public long OID { get; set; }
        [MaxLength(100)]
        public string PolyCode { get; set; }
        [MaxLength(50)]
        public string BusinessStatusCode { get; set; }
        [MaxLength(10)]
        public string TransactionYear { get; set; }
        [MaxLength(10)]
        public string TransactionMonth { get; set; }
    }
}
