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
    
    public partial class PartyPresidentCandidate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PartyPresidentCandidate()
        {
            this.PartyPresidentVotes = new HashSet<PartyPresidentVote>();
        }
    
        public int ID { get; set; }
        public int PartyPresidentVotingID { get; set; }
        public int CitizenID { get; set; }
    
        public virtual Citizen Citizen { get; set; }
        public virtual PartyPresidentVoting PartyPresidentVoting { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartyPresidentVote> PartyPresidentVotes { get; set; }
    }
}
