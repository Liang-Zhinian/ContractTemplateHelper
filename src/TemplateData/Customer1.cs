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
    
    public partial class Customer1
    {
        public Customer1()
        {
            this.Site1 = new HashSet<Site1>();
        }
    
        public int SnapShotCustomerId { get; set; }
        public System.DateTime SnapShotDateTime { get; set; }
        public string CustomerName { get; set; }
        public string LegalName { get; set; }
        public string Duns { get; set; }
        public Nullable<System.DateTime> EstimatedStartDate { get; set; }
        public Nullable<int> EstimatedTerm { get; set; }
        public Nullable<decimal> EstimatedAnnualVolumeMWh { get; set; }
        public bool IsKeyAccount { get; set; }
        public bool IsTaxExempt { get; set; }
        public int CountryId { get; set; }
        public string StateOrProvinceCode { get; set; }
        public string StateOrProvinceDesc { get; set; }
        public Nullable<int> RegionId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<decimal> TaxPct { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> ParentCustomerId { get; set; }
        public Nullable<decimal> HedgeCustomerId { get; set; }
        public string SalesLogixAccountNo { get; set; }
        public string OrgName { get; set; }
        public Nullable<bool> IsDirectEnergyOrg { get; set; }
        public Nullable<int> HedgeSalesEntityId { get; set; }
        public Nullable<decimal> MaxBrokerFee { get; set; }
        public Nullable<int> CreditStatusTypeId { get; set; }
        public Nullable<System.DateTime> CreditRequestDate { get; set; }
        public Nullable<System.DateTime> CreditApproveDate { get; set; }
        public Nullable<int> CreditScore { get; set; }
        public string CreditApplicationNo { get; set; }
        public Nullable<int> FinancialStressScore { get; set; }
        public Nullable<int> MaxApprovedTerm { get; set; }
        public string DetailCreditResponse { get; set; }
        public Nullable<int> EnteredByPersonId { get; set; }
        public Nullable<int> OwnedByPersonId { get; set; }
        public Nullable<decimal> ErmCustomerId { get; set; }
        public Nullable<decimal> MaxApprovedUsage { get; set; }
        public string EstimatedAggregateAnnualVolumeMWh { get; set; }
        public string FederalTaxId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PrimaryPhoneNumber { get; set; }
        public string PrimaryContactPhoneTypeName { get; set; }
        public string PrimaryDescription { get; set; }
        public bool IsPrimaryPhoneSmsEnabled { get; set; }
        public string SecondaryPhoneNumber { get; set; }
        public string SecondaryContactPhoneTypeName { get; set; }
        public string SecondaryDescription { get; set; }
        public Nullable<bool> IsSecondaryPhoneSmsEnabled { get; set; }
        public string JobTitle { get; set; }
        public int OfferId { get; set; }
        public int ContractId { get; set; }
        public int ActualCustomerId { get; set; }
        public Nullable<bool> HasInvoiceVerification { get; set; }
        public string FaxNumber { get; set; }
    
        public virtual ICollection<Site1> Site1 { get; set; }
    }
}
