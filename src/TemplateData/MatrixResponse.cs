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
    
    public partial class MatrixResponse
    {
        public int MatrixResponseId { get; set; }
        public int MatrixRequestId { get; set; }
        public System.Guid MatrixOfferGuid { get; set; }
        public Nullable<decimal> MatrixUsageMonth1 { get; set; }
        public Nullable<decimal> MatrixUsageMonth2 { get; set; }
        public Nullable<decimal> MatrixUsageMonth3 { get; set; }
        public Nullable<decimal> MatrixUsageMonth4 { get; set; }
        public Nullable<decimal> MatrixUsageMonth5 { get; set; }
        public Nullable<decimal> MatrixUsageMonth6 { get; set; }
        public Nullable<decimal> MatrixUsageMonth7 { get; set; }
        public Nullable<decimal> MatrixUsageMonth8 { get; set; }
        public Nullable<decimal> MatrixUsageMonth9 { get; set; }
        public Nullable<decimal> MatrixUsageMonth10 { get; set; }
        public Nullable<decimal> MatrixUsageMonth11 { get; set; }
        public Nullable<decimal> MatrixUsageMonth12 { get; set; }
        public Nullable<decimal> MatrixPrice { get; set; }
        public Nullable<decimal> MatrixLoss { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> ModifyUserId { get; set; }
        public Nullable<decimal> ScaledAnnualUsage { get; set; }
    
        public virtual MatrixRequest MatrixRequest { get; set; }
    }
}
