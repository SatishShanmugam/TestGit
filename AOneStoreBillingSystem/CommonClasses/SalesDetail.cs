//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommonClasses
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesDetail
    {
        public long Id { get; set; }
        public long BillNos { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public long Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string SalesDate { get; set; }
    }
}
