namespace TUBES_FINAL.Model
{
    using Newtonsoft.Json;

    public class PersonModel
    {
        public PersonModel() { }

        public PersonModel(string personName, string personEmail, string personPassword)
        {
            PersonName = personName;
            PersonEmail = personEmail;
            PersonPassword = personPassword;
        }

        public PersonModel(string personID, string personName, string personEmail, string personPassword)
        {
            PersonID = personID;
            PersonName = personName;
            PersonEmail = personEmail;
            PersonPassword = personPassword;
        }

        [JsonProperty(Order = 1, PropertyName = "Id")]
        public string PersonID { get; set; }

        [JsonProperty(Order = 2, PropertyName = "Name")]
        public string PersonName { get; set; }

        [JsonProperty(Order = 5, PropertyName = "Email")]
        public string PersonEmail { get; set; }

        [JsonProperty(Order = 6, PropertyName = "Password")]
        public string PersonPassword { get; set; }

    }
}
