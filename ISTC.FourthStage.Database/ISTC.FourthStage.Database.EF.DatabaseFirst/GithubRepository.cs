namespace ISTC.FourthStage.Database.EF.DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GithubRepository")]
    public partial class GithubRepository
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GithubRepository()
        {
            GithubLanguages = new HashSet<GithubLanguage>();
        }

        public int Id { get; set; }

        public string Url { get; set; }

        public string Name { get; set; }

        public int CommitCount { get; set; }

        public int BranchCount { get; set; }

        public string Readme { get; set; }

        public int ProfileId { get; set; }

        public int? StarsCount { get; set; }

        public int? ContributorsCount { get; set; }

        public int? ForksCount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GithubLanguage> GithubLanguages { get; set; }

        public virtual GithubProfile GithubProfile { get; set; }
    }
}
