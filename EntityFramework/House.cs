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
    
    public partial class House
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public House()
        {
            this.HouseFurnitures = new HashSet<HouseFurniture>();
        }
    
        public long ID { get; set; }
        public int RegionID { get; set; }
        public int CitizenID { get; set; }
        public decimal Condition { get; set; }
    
        public virtual Citizen Citizen { get; set; }
        public virtual Region Region { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HouseFurniture> HouseFurnitures { get; set; }
        public virtual SellHouse SellHouse { get; set; }
    }
}
