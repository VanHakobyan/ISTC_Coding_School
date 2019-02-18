namespace ISTC.FourthStage.Database.EF.DatabaseFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseFirst : DbContext
    {
        public DatabaseFirst()
            : base("name=DatabaseFirst")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<GithubLanguage> GithubLanguages { get; set; }
        public virtual DbSet<GithubLinkedinCrossTable> GithubLinkedinCrossTables { get; set; }
        public virtual DbSet<GithubProfile> GithubProfiles { get; set; }
        public virtual DbSet<GithubRepository> GithubRepositories { get; set; }
        public virtual DbSet<LinkedinEducation> LinkedinEducations { get; set; }
        public virtual DbSet<LinkedinExperience> LinkedinExperiences { get; set; }
        public virtual DbSet<LinkedinInterest> LinkedinInterests { get; set; }
        public virtual DbSet<LinkedinLanguage> LinkedinLanguages { get; set; }
        public virtual DbSet<LinkedinProfile> LinkedinProfiles { get; set; }
        public virtual DbSet<LinkedinSkill> LinkedinSkills { get; set; }
        public virtual DbSet<Proxy> Proxies { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GithubProfile>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<GithubProfile>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<GithubProfile>()
                .HasMany(e => e.GithubRepositories)
                .WithRequired(e => e.GithubProfile)
                .HasForeignKey(e => e.ProfileId);

            modelBuilder.Entity<GithubRepository>()
                .HasMany(e => e.GithubLanguages)
                .WithRequired(e => e.GithubRepository)
                .HasForeignKey(e => e.RepositoryId);

            modelBuilder.Entity<LinkedinEducation>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinEducation>()
                .Property(e => e.Time)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinEducation>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinExperience>()
                .Property(e => e.Company)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinExperience>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinExperience>()
                .Property(e => e.Time)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinExperience>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinInterest>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinLanguage>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinProfile>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinProfile>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinProfile>()
                .Property(e => e.Specialty)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinProfile>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinProfile>()
                .Property(e => e.Education)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinProfile>()
                .Property(e => e.Company)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinProfile>()
                .Property(e => e.Website)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinProfile>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinProfile>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinProfile>()
                .Property(e => e.Birthday)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinProfile>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<LinkedinProfile>()
                .HasMany(e => e.LinkedinEducations)
                .WithRequired(e => e.LinkedinProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LinkedinProfile>()
                .HasMany(e => e.LinkedinExperiences)
                .WithRequired(e => e.LinkedinProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LinkedinProfile>()
                .HasMany(e => e.LinkedinInterests)
                .WithRequired(e => e.LinkedinProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LinkedinProfile>()
                .HasMany(e => e.LinkedinLanguages)
                .WithRequired(e => e.LinkedinProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LinkedinProfile>()
                .HasMany(e => e.LinkedinSkills)
                .WithRequired(e => e.LinkedinProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LinkedinSkill>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
