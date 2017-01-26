namespace TestTAF.DataModel
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class TestSettings
    {
        [JsonProperty("BrowserUnderTest")]
        public Browser Browser { get; set; }
    }
}