//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class NormalJobOffer
    {
        public int ID { get; set; }
        public decimal Salary { get; set; }
        public int StartDay { get; set; }
    
        public virtual JobOffer JobOffer { get; set; }
    }
}
