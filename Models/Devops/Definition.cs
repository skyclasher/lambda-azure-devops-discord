using System.Text.Json.Serialization;

namespace AzureDevOpsDiscord.Models.Devops
{
    public class Definition
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("uri")]
        public string? Uri { get; set; }

        [JsonPropertyName("path")]
        public string? Path { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("queueStatus")]
        public string? QueueStatus { get; set; }

        [JsonPropertyName("revision")]
        public int Revision { get; set; }
    }
}
