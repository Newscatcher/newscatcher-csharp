using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record SourcesGetRequest
{
    /// <summary>
    /// The language(s) of the search. The only accepted format is the two-letter [ISO 639-1](https://en.wikipedia.org/wiki/ISO_639-1) code. To select multiple languages, use a comma-separated string.
    ///
    /// Example: `"en, es"`
    ///
    /// To learn more, see [Enumerated parameters &gt; Language](/docs/v3/api-reference/overview/enumerated-parameters#language-lang-and-not-lang).
    /// </summary>
    public string? Lang { get; set; }

    /// <summary>
    /// The countries where the news publisher is located. The accepted format is the two-letter [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) code. To select multiple countries, use a comma-separated string.
    ///
    /// Example: `"US, CA"`
    ///
    /// To learn more, see [Enumerated parameters &gt; Country](/docs/v3/api-reference/overview/enumerated-parameters#country-country-and-not-country).
    /// </summary>
    public string? Countries { get; set; }

    /// <summary>
    /// Predefined top news sources per country.
    ///
    /// Format: start with the word `top`, followed by the number of desired sources, and then the two-letter country code [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2). Multiple countries with the number of top sources can be specified as a comma-separated string.
    ///
    /// Examples:
    /// - `"top 100 US"`
    /// - `"top 33 AT"`
    /// - `"top 50 US, top 20 GB"`
    /// - `"top 33 AT, top 50 IT"`
    /// </summary>
    public string? PredefinedSources { get; set; }

    /// <summary>
    /// Word or phrase to search within the source names. To specify multiple values, use a comma-separated string.
    ///
    /// Example: `"sport, tech"`
    ///
    /// **Note**: The search doesn't require an exact match and returns sources containing the specified terms in their names. You can use any word or phrase, like `"sport"` or `"new york times"`. For example, `"sport"` returns sources such as `"Motorsport"`, `"Dot Esport"`, and `"Tuttosport"`.
    /// </summary>
    public string? SourceName { get; set; }

    /// <summary>
    /// The domain(s) of the news publication to search for.
    ///
    /// **Caution**:  When specifying the `source_url` parameter,
    /// you can only use `include_additional_info` as an extra parameter.
    /// </summary>
    public string? SourceUrl { get; set; }

    /// <summary>
    /// If true, returns the following additional datapoints about each news source:
    /// - `nb_articles_for_7d`: The number of articles published by the source in the last week.
    /// - `country`: Source country of origin.
    /// - `rank`: SEO rank.
    /// - `is_news_domain`: Boolean indicating if the source is a news domain.
    /// - `news_domain_type`: Type of news domain (e.g., "Original Content").
    /// - `news_type`: Category of news (e.g., "General News Outlets").
    /// </summary>
    public bool? IncludeAdditionalInfo { get; set; }

    /// <summary>
    /// If true, filters results to include only news domains.
    /// </summary>
    public bool? IsNewsDomain { get; set; }

    /// <summary>
    /// Filters results based on the news domain type. Possible values are:
    /// - `Original Content`: Sources that produce their own content.
    /// - `Aggregator`: Sources that collect content from various other sources.
    /// - `Press Releases`: Sources primarily publishing press releases.
    /// - `Republisher`: Sources that republish content from other sources.
    /// - `Other`: Sources that don't fit into main categories.
    /// </summary>
    public SourcesGetRequestNewsDomainType? NewsDomainType { get; set; }

    /// <summary>
    /// Filters results based on the news type. Multiple types can be specified using a comma-separated string.
    ///
    /// Example: `"General News Outlets,Tech News and Updates"`
    ///
    /// For a complete list of available news types, see [Enumerated parameters &gt; News type](/docs/v3/api-reference/overview/enumerated-parameters#news-type-news-type).
    /// </summary>
    public string? NewsType { get; set; }

    /// <summary>
    /// The lowest boundary of the rank of a news website to filter by. A lower rank indicates a more popular source.
    /// </summary>
    public int? FromRank { get; set; }

    /// <summary>
    /// The highest boundary of the rank of a news website to filter by. A lower rank indicates a more popular source.
    /// </summary>
    public int? ToRank { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
