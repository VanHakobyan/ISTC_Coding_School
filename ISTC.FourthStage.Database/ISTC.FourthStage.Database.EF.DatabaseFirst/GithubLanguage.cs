namespace ISTC.FourthStage.Database.EF.DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GithubLanguage")]
    public partial class GithubLanguage
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Percent { get; set; }

        public int RepositoryId { get; set; }

        public virtual GithubRepository GithubRepository { get; set; }
    }
}
