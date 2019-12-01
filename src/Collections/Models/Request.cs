namespace Postman.NET.Collections.Models
{
    public class Request
    {
        public Auth Auth { get; set; }

        public string Method { get; set; }

        public Parameter[] Header { get; set; }

        public Body Body { get; set; }

        public Url Url { get; set; }
    }
}
