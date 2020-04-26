namespace Postman.NET.Collections.Models
{
    public class FormData
    {
        public string Key { get; set; }

        public string Value { get; set; }

        public string ContentType { get; set; }

        public string Type { get; set; }

        public string[] Src { get; set; }

        public bool Disabled { get; set; }
    }
}