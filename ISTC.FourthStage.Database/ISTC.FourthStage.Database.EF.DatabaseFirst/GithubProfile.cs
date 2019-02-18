namespace ISTC.FourthStage.Database.EF.DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GithubProfile")]
    public partial class GithubProfile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GithubProfile()
        {
            GithubRepositories = new HashSet<GithubRepository>();
        }

        public int Id { get; set; }

        [StringLength(200)]
        public string UserName { get; set; }

        public string Url { get; set; }

        public string Company { get; set; }

        public string Name { get; set; }

        public string Bio { get; set; }

        public string Location { get; set; }

        public string Email { get; set; }

        public string BlogOrWebsite { get; set; }

        public int StarsCount { get; set; }

        public string ImageUrl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GithubRepository> GithubRepositories { get; set; }
    }
}
