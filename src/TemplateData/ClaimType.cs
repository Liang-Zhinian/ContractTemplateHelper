//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TemplateData
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClaimType
    {
        public ClaimType()
        {
            this.Claims = new HashSet<Claim>();
        }
    
        public int ClaimTypeId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Claim> Claims { get; set; }
    }
}
