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
    
    public partial class ag_Receipts1
    {
        public int R_id { get; set; }
        public Nullable<double> R_No { get; set; }
        public string P_code { get; set; }
        public Nullable<System.DateTime> T_Date { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string S_No { get; set; }
        public Nullable<double> Qua { get; set; }
        public Nullable<double> S_Bal { get; set; }
        public string user_id { get; set; }
        public Nullable<System.DateTime> audit_date { get; set; }
    }
}
