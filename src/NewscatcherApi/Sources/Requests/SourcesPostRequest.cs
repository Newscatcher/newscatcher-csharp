using System.Text.Json.Serialization;
using NewscatcherApi.Core;
using OneOf;

#nullable enable

namespace NewscatcherApi;

public record SourcesPostRequest
{
    [JsonPropertyName("lang")]
    public OneOf<string, IEnumerable<string>>? Lang { get; set; }

    [JsonPropertyName("countries")]
    public OneOf<string, IEnumerable<string>>? Countries { get; set; }

    [JsonPropertyName("predefined_sources")]
    public OneOf<string, IEnumerable<string>>? PredefinedSources { get; set; }

    [JsonPropertyName("source_name")]
    public OneOf<string, IEnumerable<string>>? SourceName { get; set; }

    [JsonPropertyName("source_url")]
    public OneOf<string, IEnumerable<string>>? SourceUrl { get; set; }

    [JsonPropertyName("include_additional_info")]
    public bool? IncludeAdditionalInfo { get; set; }

    [JsonPropertyName("is_news_domain")]
    public bool? IsNewsDomain { get; set; }

    [JsonPropertyName("news_domain_type")]
    public NewsDomainType? NewsDomainType { get; set; }

    [JsonPropertyName("news_type")]
    public OneOf<string, IEnumerable<string>>? NewsType { get; set; }

    [JsonPropertyName("from_rank")]
    public int? FromRank { get; set; }

    [JsonPropertyName("to_rank")]
    public int? ToRank { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
