using System.Text.Json.Serialization;
using NewscatcherApi.Core;
using OneOf;

#nullable enable

namespace NewscatcherApi;

public record AuthorsPostRequest
{
    [JsonPropertyName("author_name")]
    public required string AuthorName { get; set; }

    [JsonPropertyName("not_author_name")]
    public OneOf<string, IEnumerable<string>>? NotAuthorName { get; set; }

    [JsonPropertyName("predefined_sources")]
    public OneOf<string, IEnumerable<string>>? PredefinedSources { get; set; }

    [JsonPropertyName("sources")]
    public OneOf<string, IEnumerable<string>>? Sources { get; set; }

    [JsonPropertyName("not_sources")]
    public OneOf<string, IEnumerable<string>>? NotSources { get; set; }

    [JsonPropertyName("lang")]
    public OneOf<string, IEnumerable<string>>? Lang { get; set; }

    [JsonPropertyName("not_lang")]
    public OneOf<string, IEnumerable<string>>? NotLang { get; set; }

    [JsonPropertyName("countries")]
    public OneOf<string, IEnumerable<string>>? Countries { get; set; }

    [JsonPropertyName("not_countries")]
    public OneOf<string, IEnumerable<string>>? NotCountries { get; set; }

    [JsonPropertyName("from_")]
    public OneOf<DateTime, string>? From { get; set; }

    [JsonPropertyName("to_")]
    public OneOf<DateTime, string>? To { get; set; }

    [JsonPropertyName("published_date_precision")]
    public PublishedDatePrecision? PublishedDatePrecision { get; set; }

    [JsonPropertyName("by_parse_date")]
    public bool? ByParseDate { get; set; }

    [JsonPropertyName("sort_by")]
    public SortBy? SortBy { get; set; }

    [JsonPropertyName("ranked_only")]
    public bool? RankedOnly { get; set; }

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
    public OneOf<string, IEnumerable<string>>? ParentUrl { get; set; }

    [JsonPropertyName("all_links")]
    public OneOf<string, IEnumerable<string>>? AllLinks { get; set; }

    [JsonPropertyName("all_domain_links")]
    public OneOf<string, IEnumerable<string>>? AllDomainLinks { get; set; }

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
    public OneOf<string, IEnumerable<string>>? Theme { get; set; }

    [JsonPropertyName("not_theme")]
    public OneOf<string, IEnumerable<string>>? NotTheme { get; set; }

    [JsonPropertyName("ner_name")]
    public string? NerName { get; set; }

    [JsonPropertyName("title_sentiment_min")]
    public float? TitleSentimentMin { get; set; }

    [JsonPropertyName("title_sentiment_max")]
    public float? TitleSentimentMax { get; set; }

    [JsonPropertyName("content_sentiment_min")]
    public float? ContentSentimentMin { get; set; }

    [JsonPropertyName("content_sentiment_max")]
    public float? ContentSentimentMax { get; set; }

    [JsonPropertyName("iptc_tags")]
    public OneOf<string, IEnumerable<string>>? IptcTags { get; set; }

    [JsonPropertyName("not_iptc_tags")]
    public OneOf<string, IEnumerable<string>>? NotIptcTags { get; set; }

    [JsonPropertyName("iab_tags")]
    public OneOf<string, IEnumerable<string>>? IabTags { get; set; }

    [JsonPropertyName("not_iab_tags")]
    public OneOf<string, IEnumerable<string>>? NotIabTags { get; set; }

    [JsonPropertyName("custom_tags")]
    public OneOf<string, IEnumerable<string>>? CustomTags { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
