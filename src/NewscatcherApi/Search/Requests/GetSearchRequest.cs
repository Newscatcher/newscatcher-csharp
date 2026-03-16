using System.Text.Json.Serialization;
using NewscatcherApi.Core;
using OneOf;

namespace NewscatcherApi;

[Serializable]
public record GetSearchRequest
{
    [JsonIgnore]
    public required string Q { get; set; }

    [JsonIgnore]
    public string? SearchIn { get; set; }

    [JsonIgnore]
    public bool? IncludeTranslationFields { get; set; }

    /// <summary>
    /// Predefined top news sources per country.
    ///
    /// Format: start with the word `top`, followed by the number of desired sources, and then the two-letter country code [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2).
    ///
    /// Multiple countries with the number of top sources can be specified as a comma-separated string.
    /// </summary>
    [JsonIgnore]
    public string? PredefinedSources { get; set; }

    /// <summary>
    /// Word or phrase to search within the source names. To specify multiple values, use a comma-separated string.
    ///
    /// **Note**: The search doesn't require an exact match and returns sources containing the specified terms in their names. You can use any word or phrase, like `"sport"` or `"new york times"`. For example, `"sport"` returns sources such as `"Motorsport"`, `"Dot Esport"`, and `"Tuttosport"`.
    /// </summary>
    [JsonIgnore]
    public string? SourceName { get; set; }

    /// <summary>
    /// One or more news sources to narrow down the search. The format must be a domain URL. Subdomains, such as `finance.yahoo.com`, are also acceptable.To specify multiple sources, use a comma-separated string.
    /// </summary>
    [JsonIgnore]
    public string? Sources { get; set; }

    /// <summary>
    /// The news sources to exclude from the search. To exclude multiple sources, use a comma-separated string.
    /// </summary>
    [JsonIgnore]
    public string? NotSources { get; set; }

    /// <summary>
    /// The language(s) of the search. The only accepted format is the two-letter [ISO 639-1](https://en.wikipedia.org/wiki/ISO_639-1) code. To select multiple languages, use a comma-separated string.
    ///
    /// To learn more, see [Enumerated parameters &gt; Language](https://www.newscatcherapi.com/docs/news-api/api-reference/enumerated-parameters#language-lang-and-not-lang).
    /// </summary>
    [JsonIgnore]
    public string? Lang { get; set; }

    /// <summary>
    /// The language(s) to exclude from the search. The accepted format is the two-letter [ISO 639-1](https://en.wikipedia.org/wiki/ISO_639-1) code. To exclude multiple languages, use a comma-separated string.
    ///
    /// To learn more, see [Enumerated parameters &gt; Language](https://www.newscatcherapi.com/docs/news-api/api-reference/enumerated-parameters#language-lang-and-not-lang).
    /// </summary>
    [JsonIgnore]
    public string? NotLang { get; set; }

    /// <summary>
    /// The countries where the news publisher is located. The accepted format is the two-letter [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) code. To select multiple countries, use a comma-separated string.
    ///
    /// To learn more, see [Enumerated parameters &gt; Country](https://www.newscatcherapi.com/docs/news-api/api-reference/enumerated-parameters#country-country-and-not-country).
    /// </summary>
    [JsonIgnore]
    public string? Countries { get; set; }

    /// <summary>
    /// The publisher location countries to exclude from the search. The accepted format is the two-letter [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) code. To exclude multiple countries, use a comma-separated string.
    ///
    /// To learn more, see [Enumerated parameters &gt; Country](https://www.newscatcherapi.com/docs/news-api/api-reference/enumerated-parameters#country-country-and-not-country).
    /// </summary>
    [JsonIgnore]
    public string? NotCountries { get; set; }

    /// <summary>
    /// The list of author names to exclude from your search. To exclude articles by specific authors, use a comma-separated string.
    /// </summary>
    [JsonIgnore]
    public string? NotAuthorName { get; set; }

    [JsonIgnore]
    public OneOf<DateTime, string>? From { get; set; }

    [JsonIgnore]
    public OneOf<DateTime, string>? To { get; set; }

    [JsonIgnore]
    public string? PublishedDatePrecision { get; set; }

    [JsonIgnore]
    public bool? ByParseDate { get; set; }

    [JsonIgnore]
    public SortBy? SortBy { get; set; }

    [JsonIgnore]
    public bool? RankedOnly { get; set; }

    [JsonIgnore]
    public int? FromRank { get; set; }

    [JsonIgnore]
    public int? ToRank { get; set; }

    [JsonIgnore]
    public bool? IsHeadline { get; set; }

    [JsonIgnore]
    public bool? IsOpinion { get; set; }

    [JsonIgnore]
    public bool? IsPaidContent { get; set; }

    /// <summary>
    /// The categorical URL(s) to filter your search. To filter your search by multiple categorical URLs, use a comma-separated string.
    /// </summary>
    [JsonIgnore]
    public string? ParentUrl { get; set; }

    /// <summary>
    /// The complete URL(s) mentioned in the article. For multiple URLs, use a comma-separated string.
    ///
    /// For more details, see [Search by URL](https://www.newscatcherapi.com/docs/news-api/how-to/search-by-url).
    /// </summary>
    [JsonIgnore]
    public string? AllLinks { get; set; }

    /// <summary>
    /// The domain(s) mentioned in the article. For multiple domains, use a comma-separated string.
    ///
    /// For more details, see [Search by URL](https://www.newscatcherapi.com/docs/news-api/how-to/search-by-url).
    /// </summary>
    [JsonIgnore]
    public string? AllDomainLinks { get; set; }

    /// <summary>
    /// The text content of links mentioned in the article. Searches for links where the anchor text contains the specified terms. For multiple terms, use a comma-separated string.
    ///
    /// **Note**: When this parameter is used, the response includes the `all_links_data` field with detailed link information.
    ///
    /// To learn more, see [Search by URL](https://www.newscatcherapi.com/docs/news-api/how-to/search-by-url).
    /// </summary>
    [JsonIgnore]
    public string? AllLinksText { get; set; }

    [JsonIgnore]
    public bool? AdditionalDomainInfo { get; set; }

    [JsonIgnore]
    public bool? IsNewsDomain { get; set; }

    [JsonIgnore]
    public NewsDomainType? NewsDomainType { get; set; }

    /// <summary>
    /// Filters results based on the news type. Multiple types can be specified using a comma-separated string.
    ///
    /// For a complete list of available news types, see [Enumerated parameters &gt; News type](https://www.newscatcherapi.com/docs/news-api/api-reference/enumerated-parameters#news-type-news-type).
    /// </summary>
    [JsonIgnore]
    public string? NewsType { get; set; }

    [JsonIgnore]
    public int? WordCountMin { get; set; }

    [JsonIgnore]
    public int? WordCountMax { get; set; }

    [JsonIgnore]
    public int? Page { get; set; }

    [JsonIgnore]
    public int? PageSize { get; set; }

    [JsonIgnore]
    public bool? ClusteringEnabled { get; set; }

    [JsonIgnore]
    public ClusteringVariable? ClusteringVariable { get; set; }

    [JsonIgnore]
    public float? ClusteringThreshold { get; set; }

    [JsonIgnore]
    public bool? IncludeNlpData { get; set; }

    [JsonIgnore]
    public bool? HasNlp { get; set; }

    [JsonIgnore]
    public string? Theme { get; set; }

    [JsonIgnore]
    public string? NotTheme { get; set; }

    [JsonIgnore]
    public string? OrgEntityName { get; set; }

    [JsonIgnore]
    public string? PerEntityName { get; set; }

    [JsonIgnore]
    public string? LocEntityName { get; set; }

    [JsonIgnore]
    public string? MiscEntityName { get; set; }

    [JsonIgnore]
    public float? TitleSentimentMin { get; set; }

    [JsonIgnore]
    public float? TitleSentimentMax { get; set; }

    [JsonIgnore]
    public float? ContentSentimentMin { get; set; }

    [JsonIgnore]
    public float? ContentSentimentMax { get; set; }

    /// <summary>
    /// Filters articles based on International Press Telecommunications Council (IPTC) media topic tags. To specify multiple IPTC tags, use a comma-separated string of tag IDs.
    ///
    /// **Note**: The `iptc_tags` parameter is only available in the `v3_nlp_iptc_tags` subscription plan.
    ///
    /// To learn more, see [IPTC Media Topic NewsCodes](https://www.iptc.org/std/NewsCodes/treeview/mediatopic/mediatopic-en-GB.html).
    /// </summary>
    [JsonIgnore]
    public string? IptcTags { get; set; }

    /// <summary>
    /// Inverse of the `iptc_tags` parameter. Excludes articles based on International Press Telecommunications Council (IPTC) media topic tags. To specify multiple IPTC tags to exclude, use a comma-separated string of tag IDs.
    ///
    /// **Note**: The `not_iptc_tags` parameter is only available in the `v3_nlp_iptc_tags` subscription plan.
    ///
    /// To learn more, see [IPTC Media Topic NewsCodes](https://www.iptc.org/std/NewsCodes/treeview/mediatopic/mediatopic-en-GB.html).
    /// </summary>
    [JsonIgnore]
    public string? NotIptcTags { get; set; }

    /// <summary>
    /// Filters articles based on Interactive Advertising Bureau (IAB) content categories. These tags provide a standardized taxonomy for digital advertising content categorization. To specify multiple IAB categories, use a comma-separated string.
    ///
    /// **Note**: The `iab_tags` parameter is only available in the `v3_nlp_iptc_tags` subscription plan.
    ///
    /// To learn more, see the [IAB Content taxonomy](https://iabtechlab.com/standards/content-taxonomy/).
    /// </summary>
    [JsonIgnore]
    public string? IabTags { get; set; }

    /// <summary>
    /// Inverse of the `iab_tags` parameter. Excludes articles based on Interactive Advertising Bureau (IAB) content categories. These tags provide a standardized taxonomy for digital advertising content categorization. To specify multiple IAB categories to exclude, use a comma-separated string.
    ///
    /// **Note**: The `not_iab_tags` parameter is only available in the `v3_nlp_iptc_tags` subscription plan.
    ///
    /// To learn more, see the [IAB Content taxonomy](https://iabtechlab.com/standards/content-taxonomy/).
    /// </summary>
    [JsonIgnore]
    public string? NotIabTags { get; set; }

    /// <summary>
    /// Filters articles based on provided taxonomy that is tailored to your specific needs and is accessible only with your API key. To specify tags, use the following pattern:
    ///
    /// - `custom_tags.taxonomy=Tag1,Tag2`, where `taxonomy` is the taxonomy name and `Tag1,Tag2` is a comma-separated list of tag names.
    ///
    /// Example: `custom_tags.industry="Manufacturing,Logistics"`
    ///
    /// To learn more, see the [Custom tags](https://www.newscatcherapi.com/docs/news-api/guides-and-concepts/custom-tags).
    /// </summary>
    [JsonIgnore]
    public string? CustomTags { get; set; }

    [JsonIgnore]
    public bool? ExcludeDuplicates { get; set; }

    [JsonIgnore]
    public bool? RobotsCompliant { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
