namespace TUBES_FINAL.Model
{
    using Newtonsoft.Json;
    public class StudentModel: PersonModel
    {
        public StudentModel() { }
        
        public StudentModel(string personName, string personEmail, string personPassword, string studentNIM, string studentYear) : base(personName, personEmail, personPassword)
        {
            StudentNIM = studentNIM;
            StudentYear = studentYear;
        }

        public StudentModel(string personID, string personName, string personEmail, string personPassword, string studentNIM, string studentYear) : base(personID, personName, personEmail, personPassword)
        {
            StudentNIM = studentNIM;
            StudentYear = studentYear;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        [JsonProperty(Order = 3, PropertyName = "NIM")]
        public string StudentNIM { get; set; }

        [JsonProperty(Order = 4, PropertyName = "Year")]
        public string StudentYear { get; set; }
               
    }

}
