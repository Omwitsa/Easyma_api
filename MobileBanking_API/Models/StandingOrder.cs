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
    
    public partial class StandingOrder
    {
        public long Id { get; set; }
        public string Sno { get; set; }
        public Nullable<System.DateTime> TransDate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Description { get; set; }
        public string AuditId { get; set; }
        public Nullable<System.DateTime> Auditdatetime { get; set; }
        public string SaccoCode { get; set; }
    }
}