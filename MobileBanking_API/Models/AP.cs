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
    
    public partial class AP
    {
        public long pid { get; set; }
        public long P_No { get; set; }
        public string paidto { get; set; }
        public Nullable<decimal> p_amount { get; set; }
        public string curr { get; set; }
        public string Purpose { get; set; }
        public string accno { get; set; }
        public string particulars { get; set; }
        public Nullable<System.DateTime> p_date { get; set; }
        public string F_AccNo { get; set; }
        public Nullable<double> exchangerate { get; set; }
        public string checked_by { get; set; }
        public string chequeno { get; set; }
        public string chequestatus { get; set; }
        public Nullable<System.DateTime> Date_Collected { get; set; }
        public string Approvedby { get; set; }
        public Nullable<System.DateTime> ChequeDate { get; set; }
        public string Receivedby { get; set; }
        public string IDNo { get; set; }
        public string paymentmode { get; set; }
        public string auditid { get; set; }
        public Nullable<System.DateTime> auditdatetime { get; set; }
        public string P_accno { get; set; }
        public Nullable<bool> posted { get; set; }
        public string inv_no { get; set; }
        public Nullable<decimal> VAT { get; set; }
        public string Vat_accno { get; set; }
    }
}
