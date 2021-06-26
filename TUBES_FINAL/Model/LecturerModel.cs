namespace TUBES_FINAL.Model
{
    using Newtonsoft.Json;
    public class LecturerModel: PersonModel
    {
        public LecturerModel() { }

        public LecturerModel(string personName, string personEmail, string personPassword, string lecturerNIDN) : base(personName, personEmail, personPassword)
        {
            LecturerNIDN = lecturerNIDN;
        }

        public LecturerModel(string personID, string personName, string personEmail, string personPassword, string lecturerNIDN) : base(personID, personName, personEmail, personPassword)
        {
            LecturerNIDN = lecturerNIDN;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        [JsonProperty(Order = 3, PropertyName = "NIDN")]
        public string LecturerNIDN { get; set; }
                
    }
}
