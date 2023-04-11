using System.Text.Json.Serialization;

namespace AzureDevOpsDiscord.Models.Devops
{
    public class BodyRequest
    {
        [JsonPropertyName("subscriptionId")]
        public Guid SubscriptionId { get; set; }

        [JsonPropertyName("notificationId")]
        public int NotificationId { get; set; }

        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }

        [JsonPropertyName("publisherId")]
        public string? PublisherId { get; set; }

        [JsonPropertyName("message")]
        public Message? Message { get; set; }

        [JsonPropertyName("detailedMessage")]
        public Message? DetailedMessage { get; set; }

        [JsonPropertyName("resource")]
        public Resource? Resource { get; set; }

        [JsonPropertyName("resourceVersion")]
        public string? ResourceVersion { get; set; }

        [JsonPropertyName("resourceContainers")]
        public ResourceContainers? ResourceContainers { get; set; }

        [JsonPropertyName("createdDate")]
        public DateTime CreatedDate { get; set; }
    }
}
