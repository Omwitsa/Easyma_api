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
    
    public partial class RefundDetail
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> RefundId { get; set; }
        public string Product { get; set; }
        public string Lable { get; set; }
        public string GlAccount { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Tax { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
    
        public virtual Refund Refund { get; set; }
    }
}
