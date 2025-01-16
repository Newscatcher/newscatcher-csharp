using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record AdditionalDomainInfoEntity
{
    /// <summary>
    /// Indicates whether the domain is a news domain.
    /// </summary>
    [JsonPropertyName("is_news_domain")]
    public bool? IsNewsDomain { get; set; }

    /// <summary>
    /// The type of news content provided by the domain.
    /// </summary>
    [JsonPropertyName("news_type")]
    public string? NewsType { get; set; }

    /// <summary>
    /// The type of news domain.
    /// </summary>
    [JsonPropertyName("news_domain_type")]
    public string? NewsDomainType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
