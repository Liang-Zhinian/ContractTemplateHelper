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
    
    public partial class Customer
    {
        public Customer()
        {
            this.Contacts = new HashSet<Contact>();
            this.CreditHistories = new HashSet<CreditHistory>();
            this.Customer1 = new HashSet<Customer>();
            this.CustomerDocuments = new HashSet<CustomerDocument>();
            this.Sites = new HashSet<Site>();
        }
    
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string LegalName { get; set; }
        public string DUNS { get; set; }
        public Nullable<System.DateTime> EstimatedStartDate { get; set; }
        public Nullable<int> EstimatedTerm { get; set; }
        public Nullable<decimal> EstimatedAnnualVolumeMWh { get; set; }
        public string EstimatedAggregateAnnualVolumeMWh { get; set; }
        public Nullable<long> MaxApprovedUsage { get; set; }
        public bool IsKeyAccount { get; set; }
        public bool IsTaxExempt { get; set; }
        public int AddressId { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> ParentCustomerId { get; set; }
        public Nullable<decimal> HedgeCustomerId { get; set; }
        public string SalesLogixAccountNo { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> ModifyUserId { get; set; }
        public Nullable<int> OrgId { get; set; }
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
        public string FederalTaxId { get; set; }
        public Nullable<decimal> HedgeCustProsId { get; set; }
        public Nullable<System.DateTime> OrgAssignmentDate { get; set; }
        public Nullable<bool> HasInvoiceVerification { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<CreditHistory> CreditHistories { get; set; }
        public virtual CreditStatusType CreditStatusType { get; set; }
        public virtual ICollection<Customer> Customer1 { get; set; }
        public virtual Customer Customer2 { get; set; }
        public virtual ICollection<CustomerDocument> CustomerDocuments { get; set; }
        public virtual ICollection<Site> Sites { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Person Person { get; set; }
        public virtual Person Person1 { get; set; }
    }
}
