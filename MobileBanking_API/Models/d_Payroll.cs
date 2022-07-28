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
    
    public partial class d_Payroll
    {
        public long Id { get; set; }
        public Nullable<int> SNo { get; set; }
        public Nullable<decimal> Transport { get; set; }
        public Nullable<decimal> Agrovet { get; set; }
        public Nullable<decimal> Bonus { get; set; }
        public Nullable<decimal> TMShares { get; set; }
        public Nullable<decimal> FSA { get; set; }
        public Nullable<decimal> HShares { get; set; }
        public Nullable<decimal> Advance { get; set; }
        public Nullable<decimal> Others { get; set; }
        public Nullable<decimal> TDeductions { get; set; }
        public Nullable<double> KgsSupplied { get; set; }
        public Nullable<decimal> GPay { get; set; }
        public Nullable<decimal> NPay { get; set; }
        public Nullable<int> YYear { get; set; }
        public Nullable<int> MMonth { get; set; }
        public string Bank { get; set; }
        public string AccountNumber { get; set; }
        public string BBranch { get; set; }
        public string Trader { get; set; }
        public string SBranch { get; set; }
        public Nullable<System.DateTime> EndofPeriod { get; set; }
        public string auditid { get; set; }
        public Nullable<System.DateTime> auditdatetime { get; set; }
        public string mainaccno { get; set; }
        public string transportaccno { get; set; }
        public string agrovetaccno { get; set; }
        public string AIaccno { get; set; }
        public string tmsharesaccno { get; set; }
        public string fsaaccno { get; set; }
        public string hsharesaccno { get; set; }
        public string advanceaccno { get; set; }
        public string otheraccno { get; set; }
        public string netaccno { get; set; }
        public Nullable<decimal> subsidy { get; set; }
        public Nullable<decimal> CBO { get; set; }
        public string IdNo { get; set; }
        public decimal Tchp { get; set; }
        public decimal midmonth { get; set; }
        public Nullable<decimal> Deduct12 { get; set; }
        public Nullable<decimal> Mpesa { get; set; }
        public string SaccoCode { get; set; }
    }
}
