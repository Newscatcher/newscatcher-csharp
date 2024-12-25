using System.Text.Json.Serialization;
using NewscatcherApi.Core;
using OneOf;

#nullable enable

namespace NewscatcherApi;

public record SearchRequest
{
    [JsonPropertyName("q")]
    public required string Q { get; set; }

    [JsonPropertyName("search_in")]
    public string? SearchIn { get; set; }

    [JsonPropertyName("predefined_sources")]
    public object? PredefinedSources { get; set; }

    [JsonPropertyName("sources")]
    public object? Sources { get; set; }

    [JsonPropertyName("not_sources")]
    public object? NotSources { get; set; }

    [JsonPropertyName("lang")]
    public object? Lang { get; set; }

    [JsonPropertyName("not_lang")]
    public object? NotLang { get; set; }

    [JsonPropertyName("countries")]
    public object? Countries { get; set; }

    [JsonPropertyName("not_countries")]
    public object? NotCountries { get; set; }

    [JsonPropertyName("not_author_name")]
    public object? NotAuthorName { get; set; }

    [JsonPropertyName("from_")]
    public OneOf<string, DateTime>? From { get; set; }

    [JsonPropertyName("to_")]
    public OneOf<string, DateTime>? To { get; set; }

    [JsonPropertyName("published_date_precision")]
    public string? PublishedDatePrecision { get; set; }

    [JsonPropertyName("by_parse_date")]
    public OneOf<string, bool>? ByParseDate { get; set; }

    [JsonPropertyName("sort_by")]
    public string? SortBy { get; set; }

    [JsonPropertyName("ranked_only")]
    public OneOf<string, bool>? RankedOnly { get; set; }

    [JsonPropertyName("from_rank")]
    public OneOf<string, int>? FromRank { get; set; }

    [JsonPropertyName("to_rank")]
    public OneOf<string, int>? ToRank { get; set; }

    [JsonPropertyName("is_headline")]
    public OneOf<string, bool>? IsHeadline { get; set; }

    [JsonPropertyName("is_opinion")]
    public OneOf<string, bool>? IsOpinion { get; set; }

    [JsonPropertyName("is_paid_content")]
    public OneOf<string, bool>? IsPaidContent { get; set; }

    [JsonPropertyName("parent_url")]
    public object? ParentUrl { get; set; }

    [JsonPropertyName("all_links")]
    public object? AllLinks { get; set; }

    [JsonPropertyName("all_domain_links")]
    public object? AllDomainLinks { get; set; }

    [JsonPropertyName("word_count_min")]
    public OneOf<string, int>? WordCountMin { get; set; }

    [JsonPropertyName("word_count_max")]
    public OneOf<string, int>? WordCountMax { get; set; }

    [JsonPropertyName("page")]
    public OneOf<string, int>? Page { get; set; }

    [JsonPropertyName("page_size")]
    public OneOf<string, int>? PageSize { get; set; }

    [JsonPropertyName("clustering_variable")]
    public string? ClusteringVariable { get; set; }

    [JsonPropertyName("clustering_enabled")]
    public OneOf<string, bool>? ClusteringEnabled { get; set; }

    [JsonPropertyName("clustering_threshold")]
    public OneOf<double, string>? ClusteringThreshold { get; set; }

    [JsonPropertyName("include_nlp_data")]
    public OneOf<string, bool>? IncludeNlpData { get; set; }

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
    public double? TitleSentimentMin { get; set; }

    [JsonPropertyName("title_sentiment_max")]
    public double? TitleSentimentMax { get; set; }

    [JsonPropertyName("content_sentiment_min")]
    public double? ContentSentimentMin { get; set; }

    [JsonPropertyName("content_sentiment_max")]
    public double? ContentSentimentMax { get; set; }

    [JsonPropertyName("iptc_tags")]
    public object? IptcTags { get; set; }

    [JsonPropertyName("not_iptc_tags")]
    public object? NotIptcTags { get; set; }

    [JsonPropertyName("source_name")]
    public object? SourceName { get; set; }

    [JsonPropertyName("iab_tags")]
    public object? IabTags { get; set; }

    [JsonPropertyName("not_iab_tags")]
    public object? NotIabTags { get; set; }

    [JsonPropertyName("exclude_duplicates")]
    public bool? ExcludeDuplicates { get; set; }

    [JsonPropertyName("additional_domain_info")]
    public bool? AdditionalDomainInfo { get; set; }

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
