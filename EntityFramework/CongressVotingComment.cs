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
    
    public partial class CongressVotingComment
    {
        public int ID { get; set; }
        public int CongressVotingID { get; set; }
        public int Day { get; set; }
        public System.DateTime Time { get; set; }
        public string Message { get; set; }
        public int CitizenID { get; set; }
    
        public virtual Citizen Citizen { get; set; }
        public virtual CongressVoting CongressVoting { get; set; }
    }
}
