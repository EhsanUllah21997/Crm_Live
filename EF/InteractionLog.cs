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
    
    public partial class InteractionLog
    {
        public int InteractionID { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<int> ContactID { get; set; }
        public Nullable<System.DateTime> InteractionDateTime { get; set; }
        public string InteractionType { get; set; }
        public string InteractionDetails { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
