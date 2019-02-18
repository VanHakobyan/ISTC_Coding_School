namespace ISTC.FourthStage.Database.EF.DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LinkedinProfile")]
    public partial class LinkedinProfile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LinkedinProfile()
        {
            LinkedinEducations = new HashSet<LinkedinEducation>();
            LinkedinExperiences = new HashSet<LinkedinExperience>();
            LinkedinInterests = new HashSet<LinkedinInterest>();
            LinkedinLanguages = new HashSet<LinkedinLanguage>();
            LinkedinSkills = new HashSet<LinkedinSkill>();
        }

        public int Id { get; set; }

        [StringLength(200)]
        public string Username { get; set; }

        [Required]
        public string FullName { get; set; }

        public string Specialty { get; set; }

        public string Location { get; set; }

        public string Education { get; set; }

        public string Company { get; set; }

        public int? ConnectionCount { get; set; }

        public string Website { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Birthday { get; set; }

        public DateTime? Connected { get; set; }

        public string ImageUrl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LinkedinEducation> LinkedinEducations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LinkedinExperience> LinkedinExperiences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LinkedinInterest> LinkedinInterests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LinkedinLanguage> LinkedinLanguages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LinkedinSkill> LinkedinSkills { get; set; }
    }
}
