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
    
    public partial class d_OutletDispatch
    {
        public long Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Vehicle { get; set; }
        public string OutletName { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<long> Run { get; set; }
    }
}
