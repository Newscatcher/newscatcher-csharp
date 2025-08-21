using System.Text.Json.Serialization;
using NewscatcherApi.Core;
using OneOf;

namespace NewscatcherApi;

[Serializable]
public record SearchUrlGetRequest
{
    /// <summary>
    /// The Newscatcher article ID (corresponds to the `_id` field in API response) or a list of article IDs to search for. To specify multiple IDs, use a comma-separated string.
    ///
    /// Example: `"1234567890abcdef, abcdef1234567890"`
    ///
    /// **Caution**: You can use either the `links` or the `ids` parameter, but not both at the same time.
    /// </summary>
    [JsonIgnore]
    public string? Ids { get; set; }

    /// <summary>
    /// The article link or list of article links to search for. To specify multiple links, use a comma-separated string.
    ///
    /// Example: `"https://example.com/article1, https://example.com/article2"`
    ///
    /// **Caution**: You can use either the `links` or the `ids` parameter, but not both at the same time.
    /// </summary>
    [JsonIgnore]
    public string? Links { get; set; }

    [JsonIgnore]
    public OneOf<DateTime, string>? From { get; set; }

    [JsonIgnore]
    public OneOf<DateTime, string>? To { get; set; }

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
