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
    
    public partial class OrgAssignment
    {
        public int OrgAssignmentId { get; set; }
        public int PersonId { get; set; }
        public int OrgId { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<decimal> MaxFeeOverride { get; set; }
        public Nullable<int> StateProvinceId { get; set; }
    
        public virtual Organization Organization { get; set; }
        public virtual Person Person { get; set; }
        public virtual StateProvince StateProvince { get; set; }
    }
}