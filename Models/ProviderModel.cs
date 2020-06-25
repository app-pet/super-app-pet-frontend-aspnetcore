using Newtonsoft.Json;
using System.Collections.Generic;

namespace SuperAppPet.Models
{
    public class RootProviderObject
    {
        [JsonProperty("docs")]
        public List<ProviderModel> Docs { get; set; }
    }
    public class ProviderModel
    {
        [JsonProperty("services")]
        public string[] Services { get; set; }

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

    public class ProviderDTO
    {
        [JsonProperty("services")]
        public string[] Services { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}