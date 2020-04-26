using Newtonsoft.Json;
using Postman.NET.Collections.Models;
using Xunit;

namespace Tests.Models
{
    public class DeserializationTests
    {
        [Theory]
        [InlineData("{\"src\":[\"/C:/path/to/file.json\",\"/C:/path/to/file.json\"]}")]
        [InlineData("{\"src\":[]}")]
        [InlineData("{\"src\":\"/C:/path/to/file.json\"}")]
        public void FormDataSrc(string json)
        {
            var item = JsonConvert.DeserializeObject<FormData>(json);
            Assert.True(item.Src is string[]);
        }
    }
}
