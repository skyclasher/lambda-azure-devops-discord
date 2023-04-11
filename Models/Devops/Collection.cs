using System.Text.Json.Serialization;

namespace AzureDevOpsDiscord.Models.Devops
{
    public class Collection
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
    }
}
