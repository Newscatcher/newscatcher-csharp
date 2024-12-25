using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record SourcesRequest
{
    [JsonPropertyName("lang")]
    public object? Lang { get; set; }

    [JsonPropertyName("countries")]
    public object? Countries { get; set; }

    [JsonPropertyName("predefined_sources")]
    public object? PredefinedSources { get; set; }

    [JsonPropertyName("include_additional_info")]
    public bool? IncludeAdditionalInfo { get; set; }

    [JsonPropertyName("from_rank")]
    public int? FromRank { get; set; }

    [JsonPropertyName("to_rank")]
    public int? ToRank { get; set; }

    [JsonPropertyName("source_name")]
    public object? SourceName { get; set; }

    [JsonPropertyName("source_url")]
    public object? SourceUrl { get; set; }

    [JsonPropertyName("is_news_domain")]
    public bool? IsNewsDomain { get; set; }

    [JsonPropertyName("news_domain_type")]
    public object? NewsDomainType { get; set; }

    [JsonPropertyName("news_type")]
    public object? NewsType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
