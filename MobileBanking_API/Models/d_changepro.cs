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
    
    public partial class d_changepro
    {
        public long ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<double> Quantity { get; set; }
        public string user { get; set; }
        public Nullable<double> PPrice { get; set; }
        public Nullable<double> SPrice { get; set; }
        public Nullable<double> Balance { get; set; }
        public string Branch { get; set; }
    }
}
