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
    
    public partial class Event
    {
        public long ID { get; set; }
        public int EventTypeID { get; set; }
        public int Day { get; set; }
        public System.DateTime Time { get; set; }
    
        public virtual CountryEvent CountryEvent { get; set; }
        public virtual BattleEvent BattleEvent { get; set; }
        public virtual EventType EventType { get; set; }
        public virtual PartyEvent PartyEvent { get; set; }
        public virtual WarEvent WarEvent { get; set; }
    }
}
