using Newtonsoft.Json;
using System;

namespace MyFirstApp.Models
{
    public class Info
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("pages")]
        public long Pages { get; set; }

        [JsonProperty("next")]
        public Uri Next { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }
    }
}
