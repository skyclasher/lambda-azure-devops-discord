﻿using System.Text.Json.Serialization;

namespace AzureDevOpsDiscord.Models.Discord
{
    public class EmbedFooter
    {
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    }
}
