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
    
    public partial class d_TransportersPayRoll
    {
        public long id { get; set; }
        public string Code { get; set; }
        public Nullable<double> QntySup { get; set; }
        public Nullable<decimal> Amnt { get; set; }
        public Nullable<decimal> Subsidy { get; set; }
        public Nullable<decimal> GrossPay { get; set; }
        public Nullable<decimal> Agrovet { get; set; }
        public Nullable<decimal> TMShares { get; set; }
        public Nullable<decimal> FSA { get; set; }
        public Nullable<decimal> HShares { get; set; }
        public Nullable<decimal> Advance { get; set; }
        public Nullable<decimal> AI { get; set; }
        public Nullable<decimal> Others { get; set; }
        public Nullable<decimal> Totaldeductions { get; set; }
        public Nullable<decimal> NetPay { get; set; }
        public string BankName { get; set; }
        public string AccNo { get; set; }
        public string Branch { get; set; }
        public Nullable<int> MMonth { get; set; }
        public Nullable<int> YYear { get; set; }
        public string AuditId { get; set; }
        public Nullable<System.DateTime> Auditdatetime { get; set; }
        public Nullable<System.DateTime> EndPeriod { get; set; }
        public Nullable<double> rate { get; set; }
        public Nullable<int> frate { get; set; }
        public string isfrate { get; set; }
    }
}
