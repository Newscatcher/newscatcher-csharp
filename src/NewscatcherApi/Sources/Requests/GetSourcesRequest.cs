using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[Serializable]
public record GetSourcesRequest
{
    /// <summary>
    /// The language(s) of the search. The only accepted format is the two-letter [ISO 639-1](https://en.wikipedia.org/wiki/ISO_639-1) code. To select multiple languages, use a comma-separated string.
    ///
    /// To learn more, see [Enumerated parameters &gt; Language](https://www.newscatcherapi.com/docs/news-api/api-reference/enumerated-parameters#language-lang-and-not-lang).
    /// </summary>
    [JsonIgnore]
    public string? Lang { get; set; }

    /// <summary>
    /// The countries where the news publisher is located. The accepted format is the two-letter [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) code. To select multiple countries, use a comma-separated string.
    ///
    /// To learn more, see [Enumerated parameters &gt; Country](https://www.newscatcherapi.com/docs/news-api/api-reference/enumerated-parameters#country-country-and-not-country).
    /// </summary>
    [JsonIgnore]
    public string? Countries { get; set; }

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
    /// The domain(s) of the news publication to search for.
    ///
    /// **Caution**:  When specifying the `source_url` parameter,
    /// you can only use `include_additional_info` as an extra parameter.
    /// </summary>
    [JsonIgnore]
    public string? SourceUrl { get; set; }

    [JsonIgnore]
    public bool? IncludeAdditionalInfo { get; set; }

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
    public int? FromRank { get; set; }

    [JsonIgnore]
    public int? ToRank { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
