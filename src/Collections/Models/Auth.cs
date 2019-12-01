namespace Postman.NET.Collections.Models
{
    public enum PostmanAuthType
    {
        noauth,
        basic,
        oauth1,
        oauth2,
        bearer,
        digest,
        apikey,
        awsv4, 
        hawk, 
        ntlm
    }

    public class Auth
    {
        public string Type { get; set; }

        public Parameter[] Apikey { get; set; }

        public Parameter[] Awsv4 { get; set; }

        public Parameter[] Basic { get; set; }

        public Parameter[] Bearer { get; set; }

        public Parameter[] Digest { get; set; }

        public Parameter[] Hawk { get; set; }

        public Parameter[] Ntlm { get; set; }

        public Parameter[] Oauth1 { get; set; }

        public Parameter[] Oauth2 { get; set; }
    }
}