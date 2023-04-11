using System.Text.Json.Serialization;

namespace AzureDevOpsDiscord.Models.Devops
{
    public class ResourceContainers
    {
        [JsonPropertyName("collection")]
        public Collection? Collection { get; set; }

        [JsonPropertyName("account")]
        public Account? Account { get; set; }

        [JsonPropertyName("project")]
        public Project? Project { get; set; }
    }
}
