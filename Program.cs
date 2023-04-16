using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization.SystemTextJson;
using AzureDevOpsDiscord.Extensions;
using AzureDevOpsDiscord.Models.Devops;
using System.Text.Json;
using System.Text.Json.Serialization;

[assembly: LambdaSerializer(typeof(SourceGeneratorLambdaJsonSerializer<AzureDevOpsDiscord.HttpApiJsonSerializerContext>))]
namespace AzureDevOpsDiscord
{
    [JsonSerializable(typeof(APIGatewayHttpApiV2ProxyRequest))]
    [JsonSerializable(typeof(APIGatewayHttpApiV2ProxyResponse))]
    public partial class HttpApiJsonSerializerContext : JsonSerializerContext
    {
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public async Task<APIGatewayHttpApiV2ProxyResponse> Handler(APIGatewayHttpApiV2ProxyRequest apiProxyEvent, ILambdaContext context)
        {
            try
            {
                // Keep this log for now to capture created/close sprint to find the bug on created sprint
                Console.WriteLine(JsonSerializer.Serialize(apiProxyEvent));
                Console.WriteLine(apiProxyEvent.Body);
                BodyRequest bodyRequest = JsonSerializer.Deserialize<BodyRequest>(apiProxyEvent.Body)!;

                if (bodyRequest != null && !string.IsNullOrEmpty(bodyRequest.EventType))
                {
                    string title = string.Empty;
                    string desc = string.Empty;
                    string? author = string.Empty;
                    string? link = string.Empty;
                    int color = 0;
                    if (bodyRequest.EventType.Contains("build"))
                    {
                        title = $"{bodyRequest.DetailedMessage?.Text}";
                        desc = $"**Azure Devops Build: {bodyRequest.Resource?.Definition?.Name}**\nBuild {bodyRequest.Resource?.Result}\nBranch: {bodyRequest.Resource?.SourceBranch}";
                        color = 15277667;
                        author = bodyRequest?.Resource?.RequestedBy?.DisplayName == "Microsoft.VisualStudio.Services.TFS" ? bodyRequest?.Resource?.RequestedFor?.DisplayName : bodyRequest?.Resource?.RequestedBy?.DisplayName;
                        link = bodyRequest?.Resource?.Links?.Web?.Href;

                        if (bodyRequest?.Resource?.Result == "succeeded")
                        {
                            color = 3066993;
                        }
                    }

                    if (bodyRequest!.EventType.Contains("pullrequest"))
                    {
                        title = $"{bodyRequest.Message?.Markdown}";
                        desc = $"**Azure Devops Pull Request: {bodyRequest?.Resource?.Repository?.Name}**\nStatus: {bodyRequest?.Resource?.Status?.FirstCharToUpper()}\nSource Branch: {bodyRequest?.Resource?.SourceRefName}\nTarget Branch: {bodyRequest?.Resource?.TargetRefName}";
                        color = 3447003;
                        author = bodyRequest?.Resource?.CreatedBy?.DisplayName;
                        link = bodyRequest?.Resource?.Links?.Web?.Href;

                        if (bodyRequest!.EventType == "git.pullrequest.created")
                        {
                            title = $"Pull Request #{bodyRequest?.Resource?.PullRequestId} Created";

                        }

                        if (bodyRequest!.EventType == "git.pullrequest.updated")
                        {
                            title = $"Pull Request #{bodyRequest?.Resource?.PullRequestId} Updated";
                            desc = $"**Azure Devops Pull Request: {bodyRequest?.Resource?.Repository?.Name}**\n{bodyRequest?.Message?.Markdown}";

                            if (bodyRequest!.Message!.Markdown!.Contains("rejected") || bodyRequest.Message.Markdown.Contains("approved"))
                            {
                                color = 15277667;
                                if (bodyRequest.Message.Markdown.Contains("approved"))
                                {
                                    color = 3066993;
                                }
                            }
                        }

                        if (bodyRequest.EventType.Contains("git-pullrequest-comment-event"))
                        {
                            title = $"Pull Request #{bodyRequest?.Resource?.PullRequest?.PullRequestId} Commented";
                            desc = $"**Azure Devops Pull Request: {bodyRequest?.Resource?.PullRequest?.Repository?.Name}**\n{bodyRequest?.Message?.Markdown}";
                        }

                    }

                    bool isCallSuccess = await DiscordWebhook.SendDiscordWebhook(title, link, desc, author, color);
                    if (!isCallSuccess)
                    {
                        return new APIGatewayHttpApiV2ProxyResponse
                        {
                            Body = "Call to discord server is unccessfull",
                            StatusCode = 501,
                        };
                    }
                }

                return new APIGatewayHttpApiV2ProxyResponse
                {
                    StatusCode = 200,
                };
            }
            catch (Exception ex)
            {
                return new APIGatewayHttpApiV2ProxyResponse
                {
                    Body = ex.Message,
                    StatusCode = 500,
                };
            }
        }
    }
}