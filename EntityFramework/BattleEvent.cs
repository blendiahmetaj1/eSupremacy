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
    
    public partial class BattleEvent
    {
        public long EventID { get; set; }
        public int BattleID { get; set; }
        public int BattleStatusID { get; set; }
    
        public virtual Battle Battle { get; set; }
        public virtual Event Event { get; set; }
        public virtual BattleStatus BattleStatus { get; set; }
    }
}
