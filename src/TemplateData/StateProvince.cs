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
    
    public partial class StateProvince
    {
        public StateProvince()
        {
            this.Addresses = new HashSet<Address>();
            this.AdditionalDEBMargins = new HashSet<AdditionalDEBMargin>();
            this.ChannelPartnerFees = new HashSet<ChannelPartnerFee>();
            this.DebMargins = new HashSet<DebMargin>();
            this.OrgAssignments = new HashSet<OrgAssignment>();
            this.OrgStateSettings = new HashSet<OrgStateSetting>();
            this.OrgTermSettings = new HashSet<OrgTermSetting>();
            this.RateCodeMaps = new HashSet<RateCodeMap>();
            this.Regulatories = new HashSet<Regulatory>();
            this.UtilityServices = new HashSet<UtilityService>();
            this.StateProvinceCustomFieldMaps = new HashSet<StateProvinceCustomFieldMap>();
        }
    
        public int StateProvinceId { get; set; }
        public int CountryId { get; set; }
        public string StateOrProvinceCode { get; set; }
        public string Description { get; set; }
        public Nullable<int> RegionId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<decimal> TaxPct { get; set; }
        public bool IsZoned { get; set; }
        public bool HasProtected { get; set; }
    
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<AdditionalDEBMargin> AdditionalDEBMargins { get; set; }
        public virtual ICollection<ChannelPartnerFee> ChannelPartnerFees { get; set; }
        public virtual ICollection<DebMargin> DebMargins { get; set; }
        public virtual ICollection<OrgAssignment> OrgAssignments { get; set; }
        public virtual ICollection<OrgStateSetting> OrgStateSettings { get; set; }
        public virtual ICollection<OrgTermSetting> OrgTermSettings { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<RateCodeMap> RateCodeMaps { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<Regulatory> Regulatories { get; set; }
        public virtual ICollection<UtilityService> UtilityServices { get; set; }
        public virtual ICollection<StateProvinceCustomFieldMap> StateProvinceCustomFieldMaps { get; set; }
    }
}
