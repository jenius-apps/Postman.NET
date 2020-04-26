using Newtonsoft.Json.Linq;
using System.Linq;

namespace Postman.NET.Collections.Models
{
    public class FormData
    {
        public string Key { get; set; }

        public string Value { get; set; }

        public string ContentType { get; set; }

        public string Type { get; set; }

        /// <summary>
        /// String list of file paths.
        /// </summary>
        public object Src
        {
            get
            {
                if (_src is JArray a)
                {
                    return a.Select(x => x.ToString()).ToArray();
                }
                else if (_src is string s)
                {
                    return new string[] { s };
                }
                else
                {
                    return _src;
                }
            }
            set => _src = value;
        }
        private object _src;

        public bool Disabled { get; set; }
    }
}