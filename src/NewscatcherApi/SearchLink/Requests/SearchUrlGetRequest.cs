using NewscatcherApi.Core;
using OneOf;

#nullable enable

namespace NewscatcherApi;

public record SearchUrlGetRequest
{
    /// <summary>
    /// The Newscatcher article ID (corresponds to the `_id` field in API response) or a list of article IDs to search for. To specify multiple IDs, use a comma-separated string.
    ///
    /// Example: `"1234567890abcdef, abcdef1234567890"`
    ///
    /// **Caution**: You can use either the `links` or the `ids` parameter, but not both at the same time.
    /// </summary>
    public string? Ids { get; set; }

    /// <summary>
    /// The article link or list of article links to search for. To specify multiple links, use a comma-separated string.
    ///
    /// Example: `"https://example.com/article1, https://example.com/article2"`
    ///
    /// **Caution**: You can use either the `links` or the `ids` parameter, but not both at the same time.
    /// </summary>
    public string? Links { get; set; }

    public OneOf<DateTime, string>? From { get; set; }

    public OneOf<DateTime, string>? To { get; set; }

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
