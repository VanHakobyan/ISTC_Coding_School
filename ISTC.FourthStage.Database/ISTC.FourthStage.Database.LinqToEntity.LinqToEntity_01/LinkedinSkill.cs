//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISTC.FourthStage.Database.LinqToEntity.LinqToEntity_01
{
    using System;
    using System.Collections.Generic;
    
    public partial class LinkedinSkill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> EndorsedCount { get; set; }
        public int LinkedinProfileId { get; set; }
    
        public virtual LinkedinProfile LinkedinProfile { get; set; }
    }
}
