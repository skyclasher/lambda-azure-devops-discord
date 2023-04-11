using System.Text.Json.Serialization;

namespace AzureDevOpsDiscord.Models.Devops
{
    public class Comment
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("parentCommentId")]
        public int ParentCommentId { get; set; }

        [JsonPropertyName("author")]
        public RequestUser? Author { get; set; }

        [JsonPropertyName("content")]
        public string? Content { get; set; }

        [JsonPropertyName("publishedDate")]
        public DateTime PublishedDate { get; set; }

        [JsonPropertyName("lastUpdatedDate")]
        public DateTime LastUpdatedDate { get; set; }

        [JsonPropertyName("lastContentUpdatedDate")]
        public DateTime LastContentUpdatedDate { get; set; }

        [JsonPropertyName("commentType")]
        public string? CommentType { get; set; }

        [JsonPropertyName("_links")]
        public Links? Links { get; set; }
    }
}
