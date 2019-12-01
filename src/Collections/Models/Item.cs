using Newtonsoft.Json;

namespace Collections.Models
{
    public class Item
    {
        public string Name { get; set; }

        [JsonProperty("item")]
        public Item[] Items { get; set; }

        public Request Request { get; set; }
    }
}
