namespace ISTC.FourthStage.Database.EF.DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GithubLinkedinCrossTable")]
    public partial class GithubLinkedinCrossTable
    {
        public int Id { get; set; }

        public int GithubUserId { get; set; }

        public int LinkedinUserId { get; set; }
    }
}
