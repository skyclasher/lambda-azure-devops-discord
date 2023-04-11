using System.Text.Json.Serialization;

namespace AzureDevOpsDiscord.Models.Devops
{
    public class Account
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
    }
}
