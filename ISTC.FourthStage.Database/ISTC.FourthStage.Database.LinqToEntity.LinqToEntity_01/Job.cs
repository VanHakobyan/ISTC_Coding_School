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
    
    public partial class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> Deadline { get; set; }
        public string EmploymentTerm { get; set; }
        public string TimeType { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Responsibilities { get; set; }
        public string RequiredQualifications { get; set; }
        public string ProfessionalSkills { get; set; }
        public string AdditionalInformation { get; set; }
        public string SoftSkills { get; set; }
        public int CompanyId { get; set; }
    
        public virtual Company Company { get; set; }
    }
}