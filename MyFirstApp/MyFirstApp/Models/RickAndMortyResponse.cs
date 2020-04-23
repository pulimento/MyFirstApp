using Newtonsoft.Json;

namespace MyFirstApp.Models
{
    public class RickAndMortyResponse
    {
        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("results")]
        public Character[] Results { get; set; }
    }
}
