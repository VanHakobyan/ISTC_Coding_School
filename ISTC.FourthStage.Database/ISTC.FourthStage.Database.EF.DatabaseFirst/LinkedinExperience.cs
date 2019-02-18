namespace ISTC.FourthStage.Database.EF.DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LinkedinExperience")]
    public partial class LinkedinExperience
    {
        public int Id { get; set; }

        public string Company { get; set; }

        public string Title { get; set; }

        public string Time { get; set; }

        public int LinkedinProfileId { get; set; }

        public string Location { get; set; }

        public virtual LinkedinProfile LinkedinProfile { get; set; }
    }
}
