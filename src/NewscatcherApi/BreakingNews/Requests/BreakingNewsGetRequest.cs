using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[Serializable]
public record BreakingNewsGetRequest
{
    /// <summary>
    /// The sorting order of the results. Possible values are:
    /// - `relevancy`: The most relevant results first.
    /// - `date`: The most recently published results first.
    /// - `rank`: The results from the highest-ranked sources first.
    /// </summary>
    [JsonIgnore]
    public BreakingNewsGetRequestSortBy? SortBy { get; set; }

    /// <summary>
    /// If true, limits the search to sources ranked in the top 1 million online websites. If false, includes unranked sources which are assigned a rank of 999999.
    /// </summary>
    [JsonIgnore]
    public bool? RankedOnly { get; set; }

    /// <summary>
    /// The lowest boundary of the rank of a news website to filter by. A lower rank indicates a more popular source.
    /// </summary>
    [JsonIgnore]
    public int? FromRank { get; set; }

    /// <summary>
    /// The highest boundary of the rank of a news website to filter by. A lower rank indicates a more popular source.
    /// </summary>
    [JsonIgnore]
    public int? ToRank { get; set; }

    /// <summary>
    /// The page number to scroll through the results. Use for pagination, as a single API response can return up to 1,000 articles.
    ///
    /// For details, see [How to paginate large datasets](https://www.newscatcherapi.com/docs/v3/documentation/how-to/paginate-large-datasets).
    /// </summary>
    [JsonIgnore]
    public int? Page { get; set; }

    /// <summary>
    /// The number of articles to return per page.
    /// </summary>
    [JsonIgnore]
    public int? PageSize { get; set; }

    [JsonIgnore]
    public int? TopNArticles { get; set; }

    [JsonIgnore]
    public bool? IncludeTranslationFields { get; set; }

    [JsonIgnore]
    public bool? IncludeNlpData { get; set; }

    [JsonIgnore]
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
    [JsonIgnore]
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
    [JsonIgnore]
    public string? NotTheme { get; set; }

    /// <summary>
    /// Filters articles that mention specific organization names, as identified by NLP analysis. To specify multiple organizations, use a comma-separated string. To search named entities in translations, combine with the translation options of the `search_in` parameter (e.g., `title_content_translated`).
    ///
    /// Example: `"Apple, Microsoft"`
    ///
    /// **Note**: The `ORG_entity_name` parameter is only available if NLP is included in your subscription plan.
    ///
    /// To learn more, see [Search by entity](/docs/v3/documentation/how-to/search-by-entity).
    /// </summary>
    [JsonIgnore]
    public string? OrgEntityName { get; set; }

    /// <summary>
    /// Filters articles that mention specific person names, as identified by NLP analysis. To specify multiple names, use a comma-separated string. To search named entities in translations, combine with the translation options of the `search_in` parameter (e.g., `title_content_translated`).
    ///
    /// Example: `"Elon Musk, Jeff Bezos"`
    ///
    /// **Note**: The `PER_entity_name` parameter is only available if NLP is included in your subscription plan.
    ///
    /// To learn more, see [Search by entity](/docs/v3/documentation/how-to/search-by-entity).
    /// </summary>
    [JsonIgnore]
    public string? PerEntityName { get; set; }

    /// <summary>
    /// Filters articles that mention specific location names, as identified by NLP analysis. To specify multiple locations, use a comma-separated string. To search named entities in translations, combine with the translation options of the `search_in` parameter (e.g., `title_content_translated`).
    ///
    /// Example: `"California, New York"`
    ///
    /// **Note**: The `LOC_entity_name` parameter is only available if NLP is included in your subscription plan.
    ///
    /// To learn more, see [Search by entity](/docs/v3/documentation/how-to/search-by-entity).
    /// </summary>
    [JsonIgnore]
    public string? LocEntityName { get; set; }

    /// <summary>
    /// Filters articles that mention other named entities not falling under person, organization, or location categories. Includes events, nationalities, products, works of art, and more. To specify multiple entities, use a comma-separated string. To search named entities in translations, combine with the translation options of the `search_in` parameter (e.g., `title_content_translated`).
    ///
    /// Example: `"Bitcoin, Blockchain"`
    ///
    /// **Note**: The `MISC_entity_name` parameter is only available if NLP is included in your subscription plan.
    ///
    /// To learn more, see [Search by entity](/docs/v3/documentation/how-to/search-by-entity).
    /// </summary>
    [JsonIgnore]
    public string? MiscEntityName { get; set; }

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
    [JsonIgnore]
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
    [JsonIgnore]
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
    [JsonIgnore]
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
    [JsonIgnore]
    public float? ContentSentimentMax { get; set; }

    /// <summary>
    /// If true, returns only articles/sources that comply with the publisher's robots.txt rules. If false, returns only articles/sources that do not comply with robots.txt rules. If omitted, returns all articles/sources regardless of compliance status.
    /// </summary>
    [JsonIgnore]
    public bool? RobotsCompliant { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
