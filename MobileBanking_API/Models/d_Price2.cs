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
    
    public partial class d_Price2
    {
        public long Id { get; set; }
        public string Sno { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string UserId { get; set; }
        public string Branch { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}
