using System.Text.Json.Serialization;
using NewscatcherApi.Core;
using OneOf;

#nullable enable

namespace NewscatcherApi;

public record ArticleResult
{
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("author")]
    public string? Author { get; set; }

    [JsonPropertyName("authors")]
    public OneOf<IEnumerable<string>, string>? Authors { get; set; }

    [JsonPropertyName("journalists")]
    public OneOf<IEnumerable<string>, string>? Journalists { get; set; }

    [JsonPropertyName("published_date")]
    public string? PublishedDate { get; set; }

    [JsonPropertyName("published_date_precision")]
    public string? PublishedDatePrecision { get; set; }

    [JsonPropertyName("updated_date")]
    public string? UpdatedDate { get; set; }

    [JsonPropertyName("updated_date_precision")]
    public string? UpdatedDatePrecision { get; set; }

    [JsonPropertyName("parse_date")]
    public string? ParseDate { get; set; }

    [JsonPropertyName("link")]
    public required string Link { get; set; }

    [JsonPropertyName("domain_url")]
    public required string DomainUrl { get; set; }

    [JsonPropertyName("full_domain_url")]
    public required string FullDomainUrl { get; set; }

    [JsonPropertyName("name_source")]
    public string? NameSource { get; set; }

    [JsonPropertyName("is_headline")]
    public string? IsHeadline { get; set; }

    [JsonPropertyName("paid_content")]
    public bool? PaidContent { get; set; }

    [JsonPropertyName("extraction_data")]
    public required string ExtractionData { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("rights")]
    public string? Rights { get; set; }

    [JsonPropertyName("rank")]
    public required int Rank { get; set; }

    [JsonPropertyName("media")]
    public string? Media { get; set; }

    [JsonPropertyName("language")]
    public string? Language { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("content")]
    public required string Content { get; set; }

    [JsonPropertyName("title_translated_en")]
    public string? TitleTranslatedEn { get; set; }

    [JsonPropertyName("content_translated_en")]
    public string? ContentTranslatedEn { get; set; }

    [JsonPropertyName("word_count")]
    public int? WordCount { get; set; }

    [JsonPropertyName("is_opinion")]
    public bool? IsOpinion { get; set; }

    [JsonPropertyName("twitter_account")]
    public string? TwitterAccount { get; set; }

    [JsonPropertyName("all_links")]
    public OneOf<IEnumerable<string>, string>? AllLinks { get; set; }

    [JsonPropertyName("all_domain_links")]
    public OneOf<IEnumerable<string>, string>? AllDomainLinks { get; set; }

    [JsonPropertyName("nlp")]
    public object? Nlp { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("score")]
    public required double Score { get; set; }

    [JsonPropertyName("similar_documents")]
    public IEnumerable<SimilarDocument>? SimilarDocuments { get; set; }

    [JsonPropertyName("custom_tags")]
    public object? CustomTags { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
