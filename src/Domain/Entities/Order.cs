using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order
    {
        public string OrderingDate { get; set; }
        public string ProcedureName { get; set; }
        public string Priority { get; set; }
        public string Class { get; set; }
        public string StandingStatus { get; set; }
        public string Status { get; set; }
        public string ExpirationDate { get; set; }
        public string AuthorizingProviderName { get; set; }
        public string EncounterProviderName { get; set; }
        public string[] Comments { get; set; }
        public string ProcedureCategoryName { get; set; }
        public string[] SchedulingInstructions { get; set; }
        public string ExpectedDate { get; set; }
        public string OrderingProviderName { get; set; }
        public string ReferringProviderName { get; set; }
        public string OrderingUserName { get; set; }
        public string[] SchedulingNotes { get; set; }
        public string DepartmentName { get; set; }
        public string OriginalChildCount { get; set; }
        public string UnreleasedChildCount { get; set; }
        public Id[] IDs { get; set; }
        public ProcedureId[] ProcedureIDs { get; set; }
        public AuthorizingProviderId[] AuthorizingProviderIDs { get; set; }
        public EncounterProviderId[] EncounterProviderIDs { get; set; }
        public ProcedureCategoryId[] ProcedureCategoryIDs { get; set; }
        public OrderingProviderId[] OrderingProviderIDs { get; set; }
        public ReferringProviderId[] ReferringProviderIDs { get; set; }
        public OrderingUserId[] OrderingUserIDs { get; set; }
        //public string[] Diagnoses { get; set; }
        public DepartmentId[] DepartmentIDs { get; set; }
        public VisitType[] VisitTypes { get; set; }
    }
}
