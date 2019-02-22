using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISTC.FourthStage.Database.DataAnnotation.DA_01
{
    [Table("Person")]
    public class People
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required, MaxLength(200, ErrorMessage = "Name max value is 200!!")]
        public string FirstName { get; set; }

        [Required, MinLength(2)]
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }

        [Range(typeof(int), "0", "120",
            ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public int? Age { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
    }
}
