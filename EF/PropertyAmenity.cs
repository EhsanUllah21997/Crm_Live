//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UModule.Database.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class PropertyAmenity
    {
        public int AmenityID { get; set; }
        public Nullable<int> PropertyID { get; set; }
        public string AmenityName { get; set; }
        public string Specifications { get; set; }
        public string WarrantyInformation { get; set; }
    
        public virtual Property Property { get; set; }
    }
}