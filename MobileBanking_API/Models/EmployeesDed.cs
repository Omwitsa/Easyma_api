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
    
    public partial class EmployeesDed
    {
        public long Id { get; set; }
        public string Empno { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Deduction { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; }
        public string AuditId { get; set; }
        public string saccocode { get; set; }
    }
}
