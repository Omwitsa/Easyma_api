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
    
    public partial class d_TransMode
    {
        public long Id { get; set; }
        public string TransCode { get; set; }
        public string Transport { get; set; }
        public string AuditId { get; set; }
        public Nullable<System.DateTime> Auditdatetime { get; set; }
        public Nullable<double> RATE { get; set; }
    }
}
