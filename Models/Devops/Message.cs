using System.Text.Json.Serialization;

namespace AzureDevOpsDiscord.Models.Devops
{
    public class Message
    {
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        [JsonPropertyName("html")]
        public string? Html { get; set; }

        [JsonPropertyName("markdown")]
        public string? Markdown { get; set; }
    }
}
