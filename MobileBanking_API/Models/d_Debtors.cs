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
    
    public partial class d_Debtors
    {
        public long ID { get; set; }
        public string DCode { get; set; }
        public string DName { get; set; }
        public string CertNo { get; set; }
        public string Locations { get; set; }
        public Nullable<System.DateTime> TregDate { get; set; }
        public string email { get; set; }
        public string Phoneno { get; set; }
        public string Town { get; set; }
        public string Address { get; set; }
        public Nullable<double> Subsidy { get; set; }
        public string Accno { get; set; }
        public string Bcode { get; set; }
        public string BBranch { get; set; }
        public Nullable<bool> Active { get; set; }
        public string TBranch { get; set; }
        public string auditid { get; set; }
        public Nullable<System.DateTime> auditdatetime { get; set; }
        public Nullable<decimal> price { get; set; }
        public string AccDr { get; set; }
        public string AccCr { get; set; }
        public Nullable<double> crate { get; set; }
        public string drcess { get; set; }
        public string crcess { get; set; }
        public bool capp { get; set; }
    }
}
