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
    
    public partial class Swift_Messages
    {
        public long ID { get; set; }
        public int SaccoCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public int msgstatus { get; set; }
        public System.DateTime Auditdate { get; set; }
    }
}
