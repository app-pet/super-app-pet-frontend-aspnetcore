using Newtonsoft.Json;
using System.Collections.Generic;

namespace SuperAppPet.Models
{
    public class RootObject
    {
        [JsonProperty("docs")]
        public List<UserModel> Docs { get; set; }
    }
    public class UserModel
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class UserDTO
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}