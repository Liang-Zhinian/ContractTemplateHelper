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
    
    public partial class SiteService1
    {
        public int SnapShotSiteServiceId { get; set; }
        public int SnapShotSiteId { get; set; }
        public string UtilityName { get; set; }
        public string UtilityAbrevation { get; set; }
        public string UtilityDuns { get; set; }
        public string ServiceTypeName { get; set; }
        public int UtilityCountryId { get; set; }
        public string UtilityStateCode { get; set; }
        public string UtilityStateDesc { get; set; }
        public string AccountNumberRegEx { get; set; }
        public string AccountNumberDescription { get; set; }
        public string AccountNumberMask { get; set; }
        public string IsoName { get; set; }
        public string IsoCode { get; set; }
        public string BillingAddressLine1 { get; set; }
        public string BillingAddressLine2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingStateOrProvinceCode { get; set; }
        public string BillingStateOrProvinceDesc { get; set; }
        public int BillingCountryId { get; set; }
        public string LoadFactorName { get; set; }
        public string LoadFactorDesc { get; set; }
        public string LdcAcctNumber { get; set; }
        public string RateCode { get; set; }
        public decimal Volume { get; set; }
        public string UomCode { get; set; }
        public string UomName { get; set; }
        public string VolumeTimePeriodCode { get; set; }
        public bool LoeInEffect { get; set; }
        public Nullable<System.DateTime> LoeExpirationDate { get; set; }
        public string ZoneCode { get; set; }
        public string VolumeTimePeriodMonth { get; set; }
        public bool IsActive { get; set; }
        public int ActualSiteServiceId { get; set; }
        public string MatrixRateCode { get; set; }
        public string HedgeRateCode { get; set; }
        public string EnrollmentTypeCode { get; set; }
        public string EnrollmentTypeName { get; set; }
        public Nullable<System.DateTime> EnrollmentDate { get; set; }
        public Nullable<System.DateTime> MonthlyVolumeDate { get; set; }
        public Nullable<long> MonthlyVolume { get; set; }
    
        public virtual Site1 Site1 { get; set; }
    }
}