using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace ISTC.ThirdStage.Advance.ReflectionAttributes.A1
{
    //[JsonConverter(typeof(Person))]
    public class Person
    {
        [JsonPropertyAttribute("First Name")]
        public string FirstName { get; set; }

        [JsonProperty("Ազգանուն")]
        public string LastName { get; set; }

        [JsonProperty("Տարիք")]
        public int Age { get; set; }

        [JsonIgnore]
        public int PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
