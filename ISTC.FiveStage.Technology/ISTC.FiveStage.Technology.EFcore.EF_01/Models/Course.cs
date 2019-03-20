using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISTC.FiveStage.Technology.EFcore.EF_01.Models
{
    public partial class Course
    {
        public Course()
        {
            Student = new HashSet<Student>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(350)]
        public string Name { get; set; }
        public int Hours { get; set; }

        [InverseProperty("Course")]
        public virtual ICollection<Student> Student { get; set; }
    }
}
