using System.Text.Json.Serialization;

namespace AzureDevOpsDiscord.Models.Devops
{
    public class Repository
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("project")]
        public Project? Project { get; set; }

        [JsonPropertyName("defaultBranch")]
        public string? DefaultBranch { get; set; }

        [JsonPropertyName("remoteUrl")]
        public string? RemoteUrl { get; set; }
    }
}
