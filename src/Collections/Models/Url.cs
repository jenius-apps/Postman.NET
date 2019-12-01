namespace Collections.Models
{
    public class Url
    {
        public string Raw { get; set; }

        public string Protocol { get; set; }

        public string[] Host { get; set; }

        public string[] Path { get; set; }

        public Query[] Query { get; set; }

        public Variable[] Variable { get; set; }
    }
}
