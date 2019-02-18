namespace ISTC.FourthStage.Database.EF.DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proxy")]
    public partial class Proxy
    {
        public int Id { get; set; }

        public string Country { get; set; }

        public string Ip { get; set; }

        public string Port { get; set; }

        public string Type { get; set; }
    }
}
