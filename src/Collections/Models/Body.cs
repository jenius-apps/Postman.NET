namespace Collections.Models
{
    public class Body
    {
        public string Mode { get; set; }

        public string Raw { get; set; }

        public BodyOptions Options { get; set; }

        public FormData[] Formdata { get; set; }

        public Parameter[] Urlencoded { get; set; }

        public FileAttachment File { get; set; }
    }
}