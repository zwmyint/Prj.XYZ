using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Persistence
{
    public class Logging
    {
        public long OID { get; set; }

        [MaxLength(450)]
        public string TransactionId { get; set; }
        [MaxLength(1000)]
        public string Resource { get; set; }
        [MaxLength(100)]
        public string ActionType { get; set; }
        
        public string Data { get; set; }
        [MaxLength(50)]
        public string StatusCode { get; set; }
        
        public string ErrorMessage { get; set; }
        [MaxLength(100)]
        public string Polyclinic { get; set; }
        [MaxLength(50)]
        public string PatientNRIC { get; set; }
        [MaxLength(50)]
        public string BusinessStatusCode { get; set; }
    }
}
