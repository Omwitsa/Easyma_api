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
    
    public partial class UserAccount
    {
        public long USERid { get; set; }
        public string UserName { get; set; }
        public string UserLoginIDs { get; set; }
        public string Password { get; set; }
        public string UserGroup { get; set; }
        public string PassExpire { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<long> SUPERUSER { get; set; }
        public string AssignGl { get; set; }
        public string branchcode { get; set; }
        public string levels { get; set; }
        public Nullable<bool> Authorize { get; set; }
        public string Status { get; set; }
        public string Branch { get; set; }
        public string sign { get; set; }
        public Nullable<int> Phone { get; set; }
        public Nullable<bool> Reset { get; set; }
        public Nullable<int> AccessLevel { get; set; }
    }
}
