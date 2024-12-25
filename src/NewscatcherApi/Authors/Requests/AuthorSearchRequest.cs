using System.Text.Json.Serialization;
using NewscatcherApi.Core;
using OneOf;

#nullable enable

namespace NewscatcherApi;

public record AuthorSearchRequest
{
    [JsonPropertyName("author_name")]
    public required string AuthorName { get; set; }

    [JsonPropertyName("not_author_name")]
    public string? NotAuthorName { get; set; }

    [JsonPropertyName("sources")]
    public object? Sources { get; set; }

    [JsonPropertyName("predefined_sources")]
    public object? PredefinedSources { get; set; }

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

    [JsonPropertyName("from_")]
    public OneOf<string, DateTime>? From { get; set; }

    [JsonPropertyName("to_")]
    public OneOf<string, DateTime>? To { get; set; }

    [JsonPropertyName("published_date_precision")]
    public string? PublishedDatePrecision { get; set; }

    [JsonPropertyName("by_parse_date")]
    public bool? ByParseDate { get; set; }

    [JsonPropertyName("sort_by")]
    public string? SortBy { get; set; }

    [JsonPropertyName("ranked_only")]
    public OneOf<string, bool>? RankedOnly { get; set; }

    [JsonPropertyName("from_rank")]
    public int? FromRank { get; set; }

    [JsonPropertyName("to_rank")]
    public int? ToRank { get; set; }

    [JsonPropertyName("is_headline")]
    public bool? IsHeadline { get; set; }

    [JsonPropertyName("is_opinion")]
    public bool? IsOpinion { get; set; }

    [JsonPropertyName("is_paid_content")]
    public bool? IsPaidContent { get; set; }

    [JsonPropertyName("parent_url")]
    public object? ParentUrl { get; set; }

    [JsonPropertyName("all_links")]
    public object? AllLinks { get; set; }

    [JsonPropertyName("all_domain_links")]
    public object? AllDomainLinks { get; set; }

    [JsonPropertyName("word_count_min")]
    public int? WordCountMin { get; set; }

    [JsonPropertyName("word_count_max")]
    public int? WordCountMax { get; set; }

    [JsonPropertyName("page")]
    public int? Page { get; set; }

    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    [JsonPropertyName("include_nlp_data")]
    public bool? IncludeNlpData { get; set; }

    [JsonPropertyName("has_nlp")]
    public bool? HasNlp { get; set; }

    [JsonPropertyName("theme")]
    public string? Theme { get; set; }

    [JsonPropertyName("not_theme")]
    public string? NotTheme { get; set; }

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

    [JsonPropertyName("iab_tags")]
    public object? IabTags { get; set; }

    [JsonPropertyName("not_iab_tags")]
    public object? NotIabTags { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
