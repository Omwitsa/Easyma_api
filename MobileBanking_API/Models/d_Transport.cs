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
    
    public partial class d_Transport
    {
        public long ID { get; set; }
        public string Trans_Code { get; set; }
        public Nullable<long> Sno { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<System.DateTime> startdate { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> DateInactivate { get; set; }
        public string auditid { get; set; }
        public Nullable<System.DateTime> auditdatetime { get; set; }
        public string isfrate { get; set; }
    }
}
