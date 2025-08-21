using System.Text.Json;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// Additional information about the domain of the article.
/// </summary>
[Serializable]
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
