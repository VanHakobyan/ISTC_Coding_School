namespace ISTC.FourthStage.Database.EF.DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LinkedinEducation")]
    public partial class LinkedinEducation
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }

        public int LinkedinProfileId { get; set; }

        public string Title { get; set; }

        public virtual LinkedinProfile LinkedinProfile { get; set; }
    }
}
