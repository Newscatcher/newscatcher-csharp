using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[Serializable]
public record PostBreakingNewsRequest
{
    [JsonPropertyName("sort_by")]
    public SortBy? SortBy { get; set; }

    [JsonPropertyName("ranked_only")]
    public bool? RankedOnly { get; set; }

    [JsonPropertyName("from_rank")]
    public int? FromRank { get; set; }

    [JsonPropertyName("to_rank")]
    public int? ToRank { get; set; }

    [JsonPropertyName("page")]
    public int? Page { get; set; }

    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    [JsonPropertyName("top_n_articles")]
    public int? TopNArticles { get; set; }

    [JsonPropertyName("include_translation_fields")]
    public bool? IncludeTranslationFields { get; set; }

    [JsonPropertyName("include_nlp_data")]
    public bool? IncludeNlpData { get; set; }

    [JsonPropertyName("has_nlp")]
    public bool? HasNlp { get; set; }

    [JsonPropertyName("theme")]
    public string? Theme { get; set; }

    [JsonPropertyName("not_theme")]
    public string? NotTheme { get; set; }

    [JsonPropertyName("ORG_entity_name")]
    public string? OrgEntityName { get; set; }

    [JsonPropertyName("PER_entity_name")]
    public string? PerEntityName { get; set; }

    [JsonPropertyName("LOC_entity_name")]
    public string? LocEntityName { get; set; }

    [JsonPropertyName("MISC_entity_name")]
    public string? MiscEntityName { get; set; }

    [JsonPropertyName("title_sentiment_min")]
    public float? TitleSentimentMin { get; set; }

    [JsonPropertyName("title_sentiment_max")]
    public float? TitleSentimentMax { get; set; }

    [JsonPropertyName("content_sentiment_min")]
    public float? ContentSentimentMin { get; set; }

    [JsonPropertyName("content_sentiment_max")]
    public float? ContentSentimentMax { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
