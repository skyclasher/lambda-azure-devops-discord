using System.Text.Json.Serialization;

namespace AzureDevOpsDiscord.Models.Devops
{

    public class Links
    {
        [JsonPropertyName("self")]
        public Url? Self { get; set; }

        [JsonPropertyName("web")]
        public Url? Web { get; set; }

        [JsonPropertyName("sourceVersionDisplayUri")]
        public Url? SourceVersionDisplayUri { get; set; }

        [JsonPropertyName("timeline")]
        public Url? Timeline { get; set; }

        [JsonPropertyName("badge")]
        public Url? Badge { get; set; }

        [JsonPropertyName("avatar")]
        public Url? Avatar { get; set; }
    }

    public class Url
    {
        [JsonPropertyName("href")]
        public string? Href { get; set; }
    }
}
