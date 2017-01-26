namespace TestTAF.DataModel
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Browser
    {
        Chrome,

        FF
    }
}