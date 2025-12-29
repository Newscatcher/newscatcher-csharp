using System.Text.Json;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;
using OneOf;

namespace NewscatcherApi;

/// <summary>
/// The data model representing a single article in the search results.
/// </summary>
[Serializable]
public record ArticleEntity : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The title of the article.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// The primary author of the article.
    /// </summary>
    [JsonPropertyName("author")]
    public string? Author { get; set; }

    /// <summary>
    /// A list of authors of the article.
    /// </summary>
    [JsonPropertyName("authors")]
    public OneOf<IEnumerable<string>, string>? Authors { get; set; }

    /// <summary>
    /// A list of journalists associated with the article.
    /// </summary>
    [JsonPropertyName("journalists")]
    public OneOf<IEnumerable<string>, string>? Journalists { get; set; }

    /// <summary>
    /// The date the article was published.
    /// </summary>
    [JsonPropertyName("published_date")]
    public string? PublishedDate { get; set; }

    /// <summary>
    /// The precision of the published date.
    /// </summary>
    [JsonPropertyName("published_date_precision")]
    public string? PublishedDatePrecision { get; set; }

    /// <summary>
    /// The date the article was last updated.
    /// </summary>
    [JsonPropertyName("updated_date")]
    public string? UpdatedDate { get; set; }

    /// <summary>
    /// The precision of the updated date.
    /// </summary>
    [JsonPropertyName("updated_date_precision")]
    public string? UpdatedDatePrecision { get; set; }

    /// <summary>
    /// The date the article was parsed.
    /// </summary>
    [JsonPropertyName("parse_date")]
    public string? ParseDate { get; set; }

    /// <summary>
    /// The URL link to the article.
    /// </summary>
    [JsonPropertyName("link")]
    public string? Link { get; set; }

    /// <summary>
    /// Indicates whether the article URL is canonical.
    /// </summary>
    [JsonPropertyName("canonical_url")]
    public bool? CanonicalUrl { get; set; }

    /// <summary>
    /// The domain URL of the article.
    /// </summary>
    [JsonPropertyName("domain_url")]
    public string? DomainUrl { get; set; }

    /// <summary>
    /// The full domain URL of the article.
    /// </summary>
    [JsonPropertyName("full_domain_url")]
    public string? FullDomainUrl { get; set; }

    /// <summary>
    /// The name of the source where the article was published.
    /// </summary>
    [JsonPropertyName("name_source")]
    public string? NameSource { get; set; }

    /// <summary>
    /// Indicates if the article is a headline.
    /// </summary>
    [JsonPropertyName("is_headline")]
    public bool? IsHeadline { get; set; }

    /// <summary>
    /// Indicates if the article is paid content.
    /// </summary>
    [JsonPropertyName("paid_content")]
    public bool? PaidContent { get; set; }

    /// <summary>
    /// The categorical URL of the article.
    /// </summary>
    [JsonPropertyName("parent_url")]
    public string? ParentUrl { get; set; }

    /// <summary>
    /// The country where the article was published.
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// The rights information for the article.
    /// </summary>
    [JsonPropertyName("rights")]
    public string? Rights { get; set; }

    /// <summary>
    /// The rank of the article's source.
    /// </summary>
    [JsonPropertyName("rank")]
    public int? Rank { get; set; }

    /// <summary>
    /// The media associated with the article.
    /// </summary>
    [JsonPropertyName("media")]
    public string? Media { get; set; }

    /// <summary>
    /// The language in which the article is written.
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// A brief description of the article.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The content of the article.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// English translation of the article title. Available when using the `search_in` parameter with the `title_translated` option or by setting the `include_translation_fields` parameter to `true`.
    /// </summary>
    [JsonPropertyName("title_translated_en")]
    public string? TitleTranslatedEn { get; set; }

    /// <summary>
    /// English translation of the article content. Available when using the `search_in` parameter with the `content_translated` option or by setting the `include_translation_fields` parameter to `true`.
    /// </summary>
    [JsonPropertyName("content_translated_en")]
    public string? ContentTranslatedEn { get; set; }

    /// <summary>
    /// The word count of the article.
    /// </summary>
    [JsonPropertyName("word_count")]
    public int? WordCount { get; set; }

    /// <summary>
    /// Indicates if the article is an opinion piece.
    /// </summary>
    [JsonPropertyName("is_opinion")]
    public bool? IsOpinion { get; set; }

    /// <summary>
    /// The Twitter account associated with the article.
    /// </summary>
    [JsonPropertyName("twitter_account")]
    public string? TwitterAccount { get; set; }

    /// <summary>
    /// A list of all URLs mentioned in the article.
    /// </summary>
    [JsonPropertyName("all_links")]
    public OneOf<IEnumerable<string>, string>? AllLinks { get; set; }

    /// <summary>
    /// A list of all domain URLs mentioned in the article.
    /// </summary>
    [JsonPropertyName("all_domain_links")]
    public OneOf<IEnumerable<string>, string>? AllDomainLinks { get; set; }

    [JsonPropertyName("nlp")]
    public NlpDataEntity? Nlp { get; set; }

    /// <summary>
    /// The unique identifier for the article.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The relevance score of the article.
    /// </summary>
    [JsonPropertyName("score")]
    public double? Score { get; set; }

    /// <summary>
    /// True if the article content can be safely accessed according to the publisher's robots.txt rules; false otherwise.
    /// </summary>
    [JsonPropertyName("robots_compliant")]
    public bool? RobotsCompliant { get; set; }

    /// <summary>
    /// An object that contains custom tags associated with an article, where each key is a taxonomy name, and the value is an array of tags.
    /// </summary>
    [JsonPropertyName("custom_tags")]
    public Dictionary<string, IEnumerable<string>>? CustomTags { get; set; }

    [JsonPropertyName("additional_domain_info")]
    public AdditionalDomainInfoEntity? AdditionalDomainInfo { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
