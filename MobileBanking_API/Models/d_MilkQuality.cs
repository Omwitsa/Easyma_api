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
    
    public partial class d_MilkQuality
    {
        public long id { get; set; }
        public string Sno { get; set; }
        public Nullable<System.DateTime> RejDate { get; set; }
        public Nullable<double> ApproxKgs { get; set; }
        public Nullable<double> DeKgs { get; set; }
        public Nullable<double> ContCpcity { get; set; }
        public string TTransporter { get; set; }
        public string Conttype { get; set; }
        public string TransMode { get; set; }
        public string Organoleptic { get; set; }
        public Nullable<int> Rez { get; set; }
        public Nullable<double> Lact { get; set; }
        public Nullable<double> PlateCount { get; set; }
        public string Alcohol { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public Nullable<double> PCheck { get; set; }
        public Nullable<double> Dramsk { get; set; }
        public string RejReasons { get; set; }
        public string auditid { get; set; }
        public Nullable<System.DateTime> auditdatetime { get; set; }
        public string code { get; set; }
        public string Branch { get; set; }
        public string Antibiotic { get; set; }
    }
}
