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
    
    public partial class CustomerBalance
    {
        public long customerbalanceid { get; set; }
        public string CustomerNo { get; set; }
        public string IDNo { get; set; }
        public string PayrollNo { get; set; }
        public string AccName { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> AvailableBalance { get; set; }
        public string AccNO { get; set; }
        public string TransDescription { get; set; }
        public Nullable<System.DateTime> TransDate { get; set; }
        public Nullable<decimal> Commission { get; set; }
        public string ChequeNo { get; set; }
        public string Period { get; set; }
        public Nullable<bool> Posted { get; set; }
        public Nullable<bool> Locked { get; set; }
        public string transType { get; set; }
        public Nullable<bool> Status { get; set; }
        public string vno { get; set; }
        public string Auditid { get; set; }
        public System.DateTime auditdate { get; set; }
        public string moduleid { get; set; }
        public string accd { get; set; }
        public Nullable<System.DateTime> valuedate { get; set; }
        public Nullable<decimal> actualbalance { get; set; }
        public Nullable<bool> Cash { get; set; }
        public string bcode { get; set; }
        public Nullable<bool> rebuild { get; set; }
        public string Transno { get; set; }
        public Nullable<bool> reconciled { get; set; }
        public string transfers { get; set; }
        public Nullable<int> dregard { get; set; }
        public string s_code { get; set; }
    }
}
