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
    
    public partial class AUDITTABLE
    {
        public long AUDITID { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> LoginDate { get; set; }
        public string LoginTime { get; set; }
        public string UserTransaction { get; set; }
        public string LogoffTime { get; set; }
        public string moduleid { get; set; }
    }
}
