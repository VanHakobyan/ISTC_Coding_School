﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MonitoringEntities : DbContext
    {
        public MonitoringEntities()
            : base("name=MonitoringEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<GithubLanguage> GithubLanguages { get; set; }
        public virtual DbSet<GithubLinkedinCrossTable> GithubLinkedinCrossTables { get; set; }
        public virtual DbSet<GithubProfile> GithubProfiles { get; set; }
        public virtual DbSet<GithubRepository> GithubRepositories { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<LinkedinEducation> LinkedinEducations { get; set; }
        public virtual DbSet<LinkedinExperience> LinkedinExperiences { get; set; }
        public virtual DbSet<LinkedinInterest> LinkedinInterests { get; set; }
        public virtual DbSet<LinkedinLanguage> LinkedinLanguages { get; set; }
        public virtual DbSet<LinkedinProfile> LinkedinProfiles { get; set; }
        public virtual DbSet<LinkedinSkill> LinkedinSkills { get; set; }
        public virtual DbSet<Proxy> Proxies { get; set; }
    }
}
