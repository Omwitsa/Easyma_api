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
    
    public partial class d_tmpTransEnquery
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> TransDate { get; set; }
        public string SNo { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<decimal> CR { get; set; }
        public Nullable<decimal> DR { get; set; }
        public Nullable<decimal> Bal { get; set; }
        public string sacco { get; set; }
        public string Branch { get; set; }
    }
}
