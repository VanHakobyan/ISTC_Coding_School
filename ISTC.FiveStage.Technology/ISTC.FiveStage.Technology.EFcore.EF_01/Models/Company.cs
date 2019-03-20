using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISTC.FiveStage.Technology.EFcore.EF_01.Models
{
    public partial class Company
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public string About { get; set; }
        [StringLength(150)]
        public string Industry { get; set; }
    }
}
