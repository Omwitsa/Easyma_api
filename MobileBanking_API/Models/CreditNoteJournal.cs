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
    
    public partial class CreditNoteJournal
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> CreditNoteId { get; set; }
        public string GlAccount { get; set; }
        public string Label { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
    
        public virtual CreditNote CreditNote { get; set; }
    }
}