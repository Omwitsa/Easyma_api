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
    
    public partial class Tax
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Computation { get; set; }
        public string GlAccount { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public string Scope { get; set; }
        public Nullable<bool> Closed { get; set; }
        public string Personnel { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string SaccoCode { get; set; }
    }
}
