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
    
    public partial class CongressVoting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CongressVoting()
        {
            this.CongressVotingComments = new HashSet<CongressVotingComment>();
            this.CongressVotingReservedMoneys = new HashSet<CongressVotingReservedMoney>();
            this.CongressVotes = new HashSet<CongressVote>();
            this.CountryVotingEvents = new HashSet<CountryVotingEvent>();
        }
    
        public int ID { get; set; }
        public int CountryID { get; set; }
        public int CreatorID { get; set; }
        public int VotingTypeID { get; set; }
        public string CreatorMessage { get; set; }
        public int CommentRestrictionID { get; set; }
        public int StartDay { get; set; }
        public System.DateTime StartTime { get; set; }
        public string Argument1 { get; set; }
        public string Argument2 { get; set; }
        public int VotingStatusID { get; set; }
        public int VotingLength { get; set; }
        public string Argument3 { get; set; }
        public Nullable<int> RejectionReasonID { get; set; }
    
        public virtual Citizen Citizen { get; set; }
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongressVotingComment> CongressVotingComments { get; set; }
        public virtual CongressVotingRejectionReason CongressVotingRejectionReason { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongressVotingReservedMoney> CongressVotingReservedMoneys { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongressVote> CongressVotes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CountryVotingEvent> CountryVotingEvents { get; set; }
    }
}
