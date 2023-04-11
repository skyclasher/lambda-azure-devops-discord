using System.Text.Json.Serialization;

namespace AzureDevOpsDiscord.Models.Devops
{
    public class Project
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
    }
}
