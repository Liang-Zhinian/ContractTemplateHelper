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
    
    public partial class OfferSheet
    {
        public OfferSheet()
        {
            this.ContractDocuments = new HashSet<ContractDocument>();
            this.OfferSheetPricings = new HashSet<OfferSheetPricing>();
        }
    
        public int OfferSheetId { get; set; }
        public System.DateTime PresentedDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> ModifyUserId { get; set; }
    
        public virtual ICollection<ContractDocument> ContractDocuments { get; set; }
        public virtual ICollection<OfferSheetPricing> OfferSheetPricings { get; set; }
    }
}
