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
    
    public partial class CountryVotingEvent
    {
        public long EventID { get; set; }
        public int VotingID { get; set; }
        public int VotingStatusID { get; set; }
    
        public virtual CongressVoting CongressVoting { get; set; }
        public virtual CountryEvent CountryEvent { get; set; }
        public virtual VotingStatus VotingStatus { get; set; }
    }
}
