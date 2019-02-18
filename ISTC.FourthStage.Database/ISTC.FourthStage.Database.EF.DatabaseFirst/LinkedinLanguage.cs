namespace ISTC.FourthStage.Database.EF.DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LinkedinLanguage")]
    public partial class LinkedinLanguage
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int LinkedinProfileId { get; set; }

        public virtual LinkedinProfile LinkedinProfile { get; set; }
    }
}
