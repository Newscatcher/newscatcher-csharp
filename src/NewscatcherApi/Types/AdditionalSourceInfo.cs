using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record AdditionalSourceInfo
{
    [JsonPropertyName("nb_articles_for_7d")]
    public int? NbArticlesFor7D { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("rank")]
    public int? Rank { get; set; }

    [JsonPropertyName("is_news_domain")]
    public bool? IsNewsDomain { get; set; }

    [JsonPropertyName("news_domain_type")]
    public string? NewsDomainType { get; set; }

    [JsonPropertyName("news_type")]
    public string? NewsType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
