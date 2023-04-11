using System.Text.Json.Serialization;

namespace AzureDevOpsDiscord.Models.Devops
{
    public class Resource
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("_links")]
        public Links? Links { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("result")]
        public string? Result { get; set; }

        [JsonPropertyName("requestedFor")]
        public RequestUser? RequestedFor { get; set; }

        [JsonPropertyName("requestedBy")]
        public RequestUser? RequestedBy { get; set; }

        [JsonPropertyName("createdBy")]
        public RequestUser? CreatedBy { get; set; }

        [JsonPropertyName("sourceBranch")]
        public string? SourceBranch { get; set; }

        [JsonPropertyName("definition")]
        public Definition? Definition { get; set; }

        [JsonPropertyName("repository")]
        public Repository? Repository { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("sourceRefName")]
        public string? SourceRefName { get; set; }

        [JsonPropertyName("targetRefName")]
        public string? TargetRefName { get; set; }

        [JsonPropertyName("comment")]
        public Comment? Comment { get; set; }

        [JsonPropertyName("pullRequest")]
        public PullRequest? PullRequest { get; set; }

        [JsonPropertyName("pullRequestId")]
        public int PullRequestId { get; set; }
    }
}
