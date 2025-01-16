using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
