namespace ISTC.FourthStage.Database.EF.DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysdiagram
    {
        [Required]
        [StringLength(128)]
        public string name { get; set; }

        public int principal_id { get; set; }

        [Key]
        public int diagram_id { get; set; }

        public int? version { get; set; }

        public byte[] definition { get; set; }
    }
}
