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
    
    public partial class tbl_menus
    {
        public long Id { get; set; }
        public string Menu { get; set; }
        public string Alias { get; set; }
        public Nullable<bool> Enabled { get; set; }
        public Nullable<System.DateTime> RegDate { get; set; }
    }
}
