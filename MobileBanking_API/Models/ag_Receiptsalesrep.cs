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
    
    public partial class ag_Receiptsalesrep
    {
        public long id { get; set; }
        public long R_id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Paid { get; set; }
        public string user_id { get; set; }
        public Nullable<System.DateTime> audit_date { get; set; }
    }
}
