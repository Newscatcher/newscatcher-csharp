using System.Text.Json;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// The data model for additional information about a news source.
/// </summary>
[Serializable]
public record AdditionalSourceInfo
{
    /// <summary>
    /// The number of articles published by the source in the last seven days.
    /// </summary>
    [JsonPropertyName("nb_articles_for_7d")]
    public int? NbArticlesFor7D { get; set; }

    /// <summary>
    /// The country of origin of the news source.
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// The SEO rank of the news source.
    /// </summary>
    [JsonPropertyName("rank")]
    public int? Rank { get; set; }

    /// <summary>
    /// Indicates whether the source is a news domain.
    /// </summary>
    [JsonPropertyName("is_news_domain")]
    public bool? IsNewsDomain { get; set; }

    /// <summary>
    /// The type of news domain.
    /// </summary>
    [JsonPropertyName("news_domain_type")]
    public string? NewsDomainType { get; set; }

    /// <summary>
    /// The category of news provided by the source.
    /// </summary>
    [JsonPropertyName("news_type")]
    public string? NewsType { get; set; }

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
