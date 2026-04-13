using global::System.Text.Json.Serialization;
using NewscatcherApi.Core;
using OneOf;

namespace NewscatcherApi;

[Serializable]
public record GetSearchByLinkRequest
{
    /// <summary>
    /// The Newscatcher article ID (corresponds to the `_id` field in API response) or a list of article IDs to search for. To specify multiple IDs, use a comma-separated string.
    ///
    /// **Caution**: You can use either the `links` or the `ids` parameter, but not both at the same time.
    /// </summary>
    [JsonIgnore]
    public string? Ids { get; set; }

    /// <summary>
    /// The article link or list of article links to search for. To specify multiple links, use a comma-separated string.
    ///
    /// **Caution**: You can use either the `links` or the `ids` parameter, but not both at the same time.
    /// </summary>
    [JsonIgnore]
    public string? Links { get; set; }

    [JsonIgnore]
    public OneOf<DateTime, string>? From { get; set; }

    [JsonIgnore]
    public OneOf<DateTime, string>? To { get; set; }

    [JsonIgnore]
    public int? Page { get; set; }

    [JsonIgnore]
    public int? PageSize { get; set; }

    [JsonIgnore]
    public bool? RobotsCompliant { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
