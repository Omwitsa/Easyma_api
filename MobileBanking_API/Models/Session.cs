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
    
    public partial class Session
    {
        public long id { get; set; }
        public string session_ID { get; set; }
        public string dtime { get; set; }
        public Nullable<System.DateTime> dDate { get; set; }
        public string Activity { get; set; }
        public string Status { get; set; }
    }
}
