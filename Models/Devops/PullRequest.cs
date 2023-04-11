using System.Text.Json.Serialization;

namespace AzureDevOpsDiscord.Models.Devops
{
    public class PullRequest
    {
        [JsonPropertyName("repository")]
        public Repository? Repository { get; set; }

        [JsonPropertyName("pullRequestId")]
        public int PullRequestId { get; set; }

        [JsonPropertyName("codeReviewId")]
        public int CodeReviewId { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("creationDate")]
        public DateTime CreationDate { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("sourceRefName")]
        public string? SourceRefName { get; set; }

        [JsonPropertyName("targetRefName")]
        public string? TargetRefName { get; set; }

        [JsonPropertyName("mergeStatus")]
        public string? MergeStatus { get; set; }

        [JsonPropertyName("isDraft")]
        public bool IsDraft { get; set; }

        [JsonPropertyName("supportsIterations")]
        public bool SupportsIterations { get; set; }

    }
}
