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
    
    public partial class TransportersBalancing
    {
        public long Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Transporter { get; set; }
        public string Quantity { get; set; }
        public string ActualBal { get; set; }
        public string Rejects { get; set; }
        public string Spillage { get; set; }
        public string Varriance { get; set; }
        public string Code { get; set; }
    }
}
