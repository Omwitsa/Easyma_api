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
    
    public partial class ag_Receipts
    {
        public long R_id { get; set; }
        public string R_No { get; set; }
        public string P_code { get; set; }
        public Nullable<System.DateTime> T_Date { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string S_No { get; set; }
        public Nullable<double> Qua { get; set; }
        public Nullable<double> S_Bal { get; set; }
        public string user_id { get; set; }
        public Nullable<System.DateTime> audit_date { get; set; }
        public Nullable<bool> Cash { get; set; }
        public string SNO { get; set; }
        public string Transby { get; set; }
        public string Idno { get; set; }
        public string mobile { get; set; }
        public string Remarks { get; set; }
        public string Branch { get; set; }
        public Nullable<decimal> SPRICE { get; set; }
        public Nullable<decimal> BPRICE { get; set; }
        public Nullable<int> AI { get; set; }
        public Nullable<long> Run { get; set; }
        public Nullable<decimal> Paid { get; set; }
        public Nullable<int> Completed { get; set; }
        public string salesrep { get; set; }
        public string saccocode { get; set; }
        public string Zone { get; set; }
    }
}
