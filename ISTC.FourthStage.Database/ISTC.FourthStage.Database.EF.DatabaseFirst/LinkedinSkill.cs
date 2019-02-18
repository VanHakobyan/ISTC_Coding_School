namespace ISTC.FourthStage.Database.EF.DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LinkedinSkill")]
    public partial class LinkedinSkill
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? EndorsedCount { get; set; }

        public int LinkedinProfileId { get; set; }

        public virtual LinkedinProfile LinkedinProfile { get; set; }
    }
}
