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
    
    public partial class ag_Products4
    {
        public long Id { get; set; }
        public string p_code { get; set; }
        public string p_name { get; set; }
        public Nullable<double> S_No { get; set; }
        public Nullable<double> Qin { get; set; }
        public Nullable<double> Qout { get; set; }
        public Nullable<System.DateTime> Date_Entered { get; set; }
        public Nullable<System.DateTime> Last_D_Updated { get; set; }
        public string user_id { get; set; }
        public Nullable<System.DateTime> audit_date { get; set; }
        public Nullable<double> o_bal { get; set; }
        public string SupplierID { get; set; }
        public string Serialized { get; set; }
        public string unserialized { get; set; }
        public Nullable<int> seria { get; set; }
        public Nullable<decimal> pprice { get; set; }
        public Nullable<decimal> sprice { get; set; }
        public string Branch { get; set; }
        public string DRACCNO { get; set; }
        public string CRACCNO { get; set; }
        public Nullable<int> AI { get; set; }
        public string saccocode { get; set; }
        public Nullable<bool> Approved { get; set; }
    }
}
