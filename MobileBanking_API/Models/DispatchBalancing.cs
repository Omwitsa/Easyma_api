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
    
    public partial class DispatchBalancing
    {
        public long Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Intake { get; set; }
        public Nullable<decimal> Dispatch { get; set; }
        public Nullable<decimal> CF { get; set; }
        public Nullable<decimal> BF { get; set; }
        public Nullable<decimal> Actuals { get; set; }
        public Nullable<decimal> Spillage { get; set; }
        public Nullable<decimal> Rejects { get; set; }
        public Nullable<decimal> Varriance { get; set; }
        public string Saccocode { get; set; }
    }
}