//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MobileBanking_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbbalance
    {
        public long id { get; set; }
        public string accno { get; set; }
        public string accname { get; set; }
        public decimal amount { get; set; }
        public string transtype { get; set; }
        public Nullable<bool> closed { get; set; }
        public Nullable<System.DateTime> Transdate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string auditid { get; set; }
        public Nullable<System.DateTime> auditdatetime { get; set; }
        public string AccType { get; set; }
        public string AccGroup { get; set; }
        public decimal BudgetAmount { get; set; }
        public decimal DR { get; set; }
        public decimal CR { get; set; }
        public decimal OBal { get; set; }
    }
}
