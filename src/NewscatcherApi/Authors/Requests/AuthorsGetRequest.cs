using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record AuthorsGetRequest
{
    /// <summary>
    /// The name of the author to search for. This parameter returns exact matches only.
    /// </summary>
    public required string AuthorName { get; set; }

    /// <summary>
    /// The list of author names to exclude from your search. To exclude articles by specific authors, use a comma-separated string.
    ///
    /// Example: `"John Doe, Jane Doe"`
    /// </summary>
    public string? NotAuthorName { get; set; }

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
    /// One or more news sources to narrow down the search. The format must be a domain URL. Subdomains, such as `finance.yahoo.com`, are also acceptable.To specify multiple sources, use a comma-separated string.
    ///
    /// Examples:
    /// - `"nytimes.com"`
    /// - `"theguardian.com, finance.yahoo.com"`
    /// </summary>
    public string? Sources { get; set; }

    /// <summary>
    /// The news sources to exclude from the search. To exclude multiple sources, use a comma-separated string.
    ///
    /// Example: `"cnn.com, wsj.com"`
    /// </summary>
    public string? NotSources { get; set; }

    /// <summary>
    /// The language(s) of the search. The only accepted format is the two-letter [ISO 639-1](https://en.wikipedia.org/wiki/ISO_639-1) code. To select multiple languages, use a comma-separated string.
    ///
    /// Example: `"en, es"`
    ///
    /// To learn more, see [Enumerated parameters &gt; Language](/docs/v3/api-reference/overview/enumerated-parameters#language-lang-and-not-lang).
    /// </summary>
    public string? Lang { get; set; }

    /// <summary>
    /// The language(s) to exclude from the search. The accepted format is the two-letter [ISO 639-1](https://en.wikipedia.org/wiki/ISO_639-1) code. To exclude multiple languages, use a comma-separated string.
    ///
    /// Example: `"fr, de"`
    ///
    /// To learn more, see [Enumerated parameters &gt; Language](/docs/v3/api-reference/overview/enumerated-parameters#language-lang-and-not-lang).
    /// </summary>
    public string? NotLang { get; set; }

    /// <summary>
    /// The countries where the news publisher is located. The accepted format is the two-letter [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) code. To select multiple countries, use a comma-separated string.
    ///
    /// Example: `"US, CA"`
    ///
    /// To learn more, see [Enumerated parameters &gt; Country](/docs/v3/api-reference/overview/enumerated-parameters#country-country-and-not-country).
    /// </summary>
    public string? Countries { get; set; }

    /// <summary>
    /// The publisher location countries to exclude from the search. The accepted format is the two-letter [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) code. To exclude multiple countries, use a comma-separated string.
    ///
    /// Example:`"US, CA"`
    ///
    /// To learn more, see [Enumerated parameters &gt; Country](/docs/v3/api-reference/overview/enumerated-parameters#country-country-and-not-country).
    /// </summary>
    public string? NotCountries { get; set; }

    /// <summary>
    /// The starting point in time to search from. Accepts date-time strings in ISO 8601 format and plain text. The default time zone is UTC.
    ///
    /// Formats with examples:
    /// - YYYY-mm-ddTHH:MM:SS: `2024-07-01T00:00:00`
    /// - YYYY-MM-dd: `2024-07-01`
    /// - YYYY/mm/dd HH:MM:SS: `2024/07/01 00:00:00`
    /// - YYYY/mm/dd: `2024/07/01`
    /// - English phrases: `1 day ago`, `today`
    ///
    /// **Note**: By default, applied to the publication date of the article. To use the article's parse date instead, set the `by_parse_date` parameter to `true`.
    /// </summary>
    public DateTime? From { get; set; }

    /// <summary>
    /// The ending point in time to search up to. Accepts date-time strings in ISO 8601 format and plain text. The default time zone is UTC.
    ///
    /// Formats with examples:
    /// - YYYY-mm-ddTHH:MM:SS: `2024-07-01T00:00:00`
    /// - YYYY-MM-dd: `2024-07-01`
    /// - YYYY/mm/dd HH:MM:SS: `2024/07/01 00:00:00`
    /// - YYYY/mm/dd: `2024/07/01`
    /// - English phrases: `1 day ago`, `today`
    ///
    /// **Note**: By default, applied to the publication date of the article. To use the article's parse date instead, set the `by_parse_date` parameter to `true`.
    /// </summary>
    public DateTime? To { get; set; }

    /// <summary>
    /// The precision of the published date. There are three types:
    /// - `full`: The day and time of an article is correctly identified with the appropriate timezone.
    /// - `timezone unknown`: The day and time of an article is correctly identified without timezone.
    /// - `date`: Only the day is identified without an exact time.
    /// </summary>
    public AuthorsGetRequestPublishedDatePrecision? PublishedDatePrecision { get; set; }

    /// <summary>
    /// If true, the `from_` and `to_` parameters use article parse dates instead of published dates. Additionally, the `parse_date` variable is added to the output for each article object.
    /// </summary>
    public bool? ByParseDate { get; set; }

    /// <summary>
    /// The sorting order of the results. Possible values are:
    /// - `relevancy`: The most relevant results first.
    /// - `date`: The most recently published results first.
    /// - `rank`: The results from the highest-ranked sources first.
    /// </summary>
    public AuthorsGetRequestSortBy? SortBy { get; set; }

    /// <summary>
    /// If true, limits the search to sources ranked in the top 1 million online websites. If false, includes unranked sources which are assigned a rank of 999999.
    /// </summary>
    public bool? RankedOnly { get; set; }

    /// <summary>
    /// The lowest boundary of the rank of a news website to filter by. A lower rank indicates a more popular source.
    /// </summary>
    public int? FromRank { get; set; }

    /// <summary>
    /// The highest boundary of the rank of a news website to filter by. A lower rank indicates a more popular source.
    /// </summary>
    public int? ToRank { get; set; }

    /// <summary>
    /// If true, only returns articles that were posted on the home page of a given news domain.
    /// </summary>
    public bool? IsHeadline { get; set; }

    /// <summary>
    /// If true, returns only opinion pieces. If false, excludes opinion-based articles and returns news only.
    /// </summary>
    public bool? IsOpinion { get; set; }

    /// <summary>
    /// If false, returns only articles that have publicly available complete content. Some publishers partially block content, so this setting ensures that only full articles are retrieved.
    /// </summary>
    public bool? IsPaidContent { get; set; }

    /// <summary>
    /// The categorical URL(s) to filter your search. To filter your search by multiple categorical URLs, use a comma-separated string.
    ///
    /// Example: `"wsj.com/politics, wsj.com/tech"`
    /// </summary>
    public string? ParentUrl { get; set; }

    /// <summary>
    /// The complete URL(s) mentioned in the article. For multiple URLs, use a comma-separated string.
    ///
    /// Example: `"https://aiindex.stanford.edu/report, https://www.stateof.ai"`
    ///
    /// For more details, see [Search by URL](/docs/v3/documentation/how-to/search-by-url).
    /// </summary>
    public string? AllLinks { get; set; }

    /// <summary>
    /// The domain(s) mentioned in the article. For multiple domains, use a comma-separated string.
    ///
    /// Example: `"who.int, nih.gov"`
    ///
    /// For more details, see [Search by URL](/docs/v3/documentation/how-to/search-by-url).
    /// </summary>
    public string? AllDomainLinks { get; set; }

    /// <summary>
    /// The minimum number of words an article must contain. To be used for avoiding articles with small content.
    /// </summary>
    public int? WordCountMin { get; set; }

    /// <summary>
    /// The maximum number of words an article can contain. To be used for avoiding articles with large content.
    /// </summary>
    public int? WordCountMax { get; set; }

    /// <summary>
    /// The page number to scroll through the results. Use for pagination, as a single API response can return up to 1,000 articles.
    ///
    /// For details, see [How to paginate large datasets](https://www.newscatcherapi.com/docs/v3/documentation/how-to/paginate-large-datasets).
    /// </summary>
    public int? Page { get; set; }

    /// <summary>
    /// The number of articles to return per page.
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// If true, includes an NLP layer with each article in the response. This layer provides enhanced information such as theme classification, article summary, sentiment analysis, tags, and named entity recognition.
    ///
    /// The NLP layer includes:
    /// - Theme: General topic of the article.
    /// - Summary: A concise overview of the article content.
    /// - Sentiment: Separate scores for title and content (range: -1 to 1).
    /// - Named entities: Identified persons (PER), organizations (ORG), locations (LOC), and miscellaneous entities (MISC).
    /// - IPTC tags: Standardized news category tags.
    /// - IAB tags: Content categories for digital advertising.
    ///
    /// **Note**: The `include_nlp_data` parameter is only available if NLP is included in your subscription plan.
    ///
    /// To learn more, see [NLP features](/docs/v3/documentation/guides-and-concepts/nlp-features).
    /// </summary>
    public bool? IncludeNlpData { get; set; }

    /// <summary>
    /// If true, filters the results to include only articles with an NLP layer. This allows you to focus on articles that have been processed with advanced NLP techniques.
    ///
    /// **Note**: The `has_nlp` parameter is only available if NLP is included in your subscription plan.
    ///
    /// To learn more, see [NLP features](/docs/v3/documentation/guides-and-concepts/nlp-features).
    /// </summary>
    public bool? HasNlp { get; set; }

    /// <summary>
    /// Filters articles based on their general topic, as determined by NLP analysis. To select multiple themes, use a comma-separated string.
    ///
    /// Example: `"Finance, Tech"`
    ///
    /// **Note**: The `theme` parameter is only available if NLP is included in your subscription plan.
    ///
    /// To learn more, see [NLP features](/docs/v3/documentation/guides-and-concepts/nlp-features).
    ///
    /// Available options: `Business`, `Economics`, `Entertainment`, `Finance`, `Health`, `Politics`, `Science`, `Sports`, `Tech`, `Crime`, `Financial Crime`, `Lifestyle`, `Automotive`, `Travel`, `Weather`, `General`.
    /// </summary>
    public string? Theme { get; set; }

    /// <summary>
    /// Inverse of the `theme` parameter. Excludes articles based on their general topic, as determined by NLP analysis. To exclude multiple themes, use a comma-separated string.
    ///
    /// Example: `"Crime, Tech"`
    ///
    /// **Note**: The `not_theme` parameter is only available if NLP is included in your subscription plan.
    ///
    /// To learn more, see [NLP features](/docs/v3/documentation/guides-and-concepts/nlp-features).
    /// </summary>
    public string? NotTheme { get; set; }

    /// <summary>
    /// The name of person, organization, location, product or other named entity to search for. To specify multiple names use a comma-separated string.
    ///
    /// Example: `"Tesla, Amazon"`
    /// </summary>
    public string? NerName { get; set; }

    /// <summary>
    /// Filters articles based on the minimum sentiment score of their titles.
    ///
    /// Range is `-1.0` to `1.0`, where:
    /// - Negative values indicate negative sentiment.
    /// - Positive values indicate positive sentiment.
    /// - Values close to 0 indicate neutral sentiment.
    ///
    /// **Note**: The `title_sentiment_min` parameter is only available if NLP is included in your subscription plan.
    ///
    /// To learn more, see [NLP features](/docs/v3/documentation/guides-and-concepts/nlp-features).
    /// </summary>
    public float? TitleSentimentMin { get; set; }

    /// <summary>
    /// Filters articles based on the maximum sentiment score of their titles.
    ///
    /// Range is `-1.0` to `1.0`, where:
    /// - Negative values indicate negative sentiment.
    /// - Positive values indicate positive sentiment.
    /// - Values close to 0 indicate neutral sentiment.
    ///
    /// **Note**: The `title_sentiment_max` parameter is only available if NLP is included in your subscription plan.
    ///
    /// To learn more, see [NLP features](/docs/v3/documentation/guides-and-concepts/nlp-features).
    /// </summary>
    public float? TitleSentimentMax { get; set; }

    /// <summary>
    /// Filters articles based on the minimum sentiment score of their content.
    ///
    /// Range is `-1.0` to `1.0`, where:
    /// - Negative values indicate negative sentiment.
    /// - Positive values indicate positive sentiment.
    /// - Values close to 0 indicate neutral sentiment.
    ///
    /// **Note**: The `content_sentiment_min` parameter is only available if NLP is included in your subscription plan.
    ///
    /// To learn more, see [NLP features](/docs/v3/documentation/guides-and-concepts/nlp-features).
    /// </summary>
    public float? ContentSentimentMin { get; set; }

    /// <summary>
    /// Filters articles based on the maximum sentiment score of their content.
    ///
    /// Range is `-1.0` to `1.0`, where:
    /// - Negative values indicate negative sentiment.
    /// - Positive values indicate positive sentiment.
    /// - Values close to 0 indicate neutral sentiment.
    ///
    /// **Note**: The `content_sentiment_max` parameter is only available if NLP is included in your subscription plan.
    ///
    /// To learn more, see [NLP features](/docs/v3/documentation/guides-and-concepts/nlp-features).
    /// </summary>
    public float? ContentSentimentMax { get; set; }

    /// <summary>
    /// Filters articles based on International Press Telecommunications Council (IPTC) media topic tags. To specify multiple IPTC tags, use a comma-separated string of tag IDs.
    ///
    /// Example: `"20000199, 20000209"`
    ///
    /// **Note**: The `iptc_tags` parameter is only available if tags are included in your subscription plan.
    ///
    /// To learn more, see [IPTC Media Topic NewsCodes](https://www.iptc.org/std/NewsCodes/treeview/mediatopic/mediatopic-en-GB.html).
    /// </summary>
    public string? IptcTags { get; set; }

    /// <summary>
    /// Inverse of the `iptc_tags` parameter. Excludes articles based on International Press Telecommunications Council (IPTC) media topic tags. To specify multiple IPTC tags to exclude, use a comma-separated string of tag IDs.
    ///
    /// Example: `"20000205, 20000209"`
    ///
    /// **Note**: The `not_iptc_tags` parameter is only available if tags are included in your subscription plan.
    ///
    /// To learn more, see [IPTC Media Topic NewsCodes](https://www.iptc.org/std/NewsCodes/treeview/mediatopic/mediatopic-en-GB.html).
    /// </summary>
    public string? NotIptcTags { get; set; }

    /// <summary>
    /// Filters articles based on Interactive Advertising Bureau (IAB) content categories. These tags provide a standardized taxonomy for digital advertising content categorization. To specify multiple IAB categories, use a comma-separated string.
    ///
    /// Example: `"Business, Events"`
    ///
    /// **Note**: The `iab_tags` parameter is only available if tags are included in your subscription plan.
    ///
    /// To learn more, see the [IAB Content taxonomy](https://iabtechlab.com/standards/content-taxonomy/).
    /// </summary>
    public string? IabTags { get; set; }

    /// <summary>
    /// Inverse of the `iab_tags` parameter. Excludes articles based on Interactive Advertising Bureau (IAB) content categories. These tags provide a standardized taxonomy for digital advertising content categorization. To specify multiple IAB categories to exclude, use a comma-separated string.
    ///
    /// Example: `"Agriculture, Metals"`
    ///
    /// **Note**: The `not_iab_tags` parameter is only available if tags are included in your subscription plan.
    ///
    /// To learn more, see the [IAB Content taxonomy](https://iabtechlab.com/standards/content-taxonomy/).
    /// </summary>
    public string? NotIabTags { get; set; }

    /// <summary>
    /// Filters articles based on provided taxonomy that is tailored to your specific needs and is accessible only with your API key. To specify tags, use the following pattern:
    ///
    /// - `custom_tags.taxonomy=Tag1,Tag2,Tag3`, where `taxonomy` is the taxonomy name and `Tag1,Tag2,Tag3` is a comma-separated list of tags.
    ///
    /// Example: `custom_tags.industry="Manufacturing, Supply Chain, Logistics"`
    ///
    /// To learn more, see the [Custom tags](/docs/v3/documentation/guides-and-concepts/custom-tags).
    /// </summary>
    public string? CustomTags { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
