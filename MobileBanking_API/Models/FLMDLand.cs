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
    
    public partial class FLMDLand
    {
        public long Id { get; set; }
        public string Sno { get; set; }
        public string Location { get; set; }
        public string PlotNumber { get; set; }
        public Nullable<double> TotalAcres { get; set; }
        public Nullable<double> AcresCrops { get; set; }
        public Nullable<double> AcresBuilding { get; set; }
        public Nullable<double> AcresLivestock { get; set; }
        public Nullable<double> acresUnusedLand { get; set; }
        public string SaccoCode { get; set; }
    }
}
