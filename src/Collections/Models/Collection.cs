using Newtonsoft.Json;

namespace Postman.NET.Collections.Models
{
    public class Collection
    {
        public Info Info { get; set; }

        [JsonProperty("item")]
        public Item[] Items { get; set; }

        public Variable[] Variable { get; set; }

        public Auth Auth { get; set; }
    }
}
