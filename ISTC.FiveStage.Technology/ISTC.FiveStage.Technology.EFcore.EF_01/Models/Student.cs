using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISTC.FiveStage.Technology.EFcore.EF_01.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        [Required]
        [StringLength(350)]
        public string Name { get; set; }
        public byte? Age { get; set; }
        public int? CourseId { get; set; }
        public int? EndYear { get; set; }

        [ForeignKey("CourseId")]
        [InverseProperty("Student")]
        public virtual Course Course { get; set; }
    }
}
