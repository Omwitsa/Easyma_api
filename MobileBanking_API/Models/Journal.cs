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
    
    public partial class Journal
    {
        public long JVID { get; set; }
        public string VNO { get; set; }
        public string ACCNO { get; set; }
        public string NAME { get; set; }
        public string NARATION { get; set; }
        public string TYPE { get; set; }
        public string MEMBERNO { get; set; }
        public string SHARETYPE { get; set; }
        public string Loanno { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public string TRANSTYPE { get; set; }
        public string AUDITID { get; set; }
        public Nullable<System.DateTime> TRANSDATE { get; set; }
        public System.DateTime AUDITDATE { get; set; }
        public bool POSTED { get; set; }
        public Nullable<System.DateTime> POSTEDDATE { get; set; }
    }
}
