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
    
    public partial class CONTRIB
    {
        public long ID { get; set; }
        public string MemberNo { get; set; }
        public System.DateTime ContrDate { get; set; }
        public Nullable<long> RefNo { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public decimal Commission { get; set; }
        public decimal Interest { get; set; }
        public double intRate { get; set; }
        public Nullable<decimal> ShareBal { get; set; }
        public string TransBy { get; set; }
        public string ChequeNo { get; set; }
        public string ReceiptNo { get; set; }
        public string Locked { get; set; }
        public string Posted { get; set; }
        public string Remarks { get; set; }
        public string AuditID { get; set; }
        public System.DateTime AuditTime { get; set; }
        public string sharescode { get; set; }
        public string TransactionNo { get; set; }
        public bool used { get; set; }
        public short fperiod { get; set; }
        public Nullable<System.DateTime> maturitydate { get; set; }
    }
}
