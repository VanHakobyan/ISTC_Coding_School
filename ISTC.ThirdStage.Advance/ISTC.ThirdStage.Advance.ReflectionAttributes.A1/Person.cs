using Newtonsoft.Json;

namespace ISTC.ThirdStage.Advance.ReflectionAttributes.A1
{
    public class Person
    {
        [JsonProperty("Անուն")]
        public string FirstName { get; set; }
        [JsonProperty("Ազգանուն")]
        public string LastName { get; set; }
        [JsonProperty("Տարիք")]
        public int Age { get; set; }
        [JsonIgnore]
        public int PhoneNumber { get; set; }
    }
}
