using System.Text.Json.Serialization;
using NewscatcherApi.Core;
using OneOf;

#nullable enable

namespace NewscatcherApi;

public record SearchUrlPostRequest
{
    [JsonPropertyName("ids")]
    public OneOf<string, IEnumerable<string>>? Ids { get; set; }

    [JsonPropertyName("links")]
    public OneOf<string, IEnumerable<string>>? Links { get; set; }

    /// <summary>
    /// The starting point in time to search from. Accepts date-time strings in ISO 8601 format and plain text strings. The default time zone is UTC.
    ///
    /// Formats with examples:
    /// - YYYY-mm-ddTHH:MM:SS: `2024-07-01T00:00:00`
    /// - YYYY-MM-dd: `2024-07-01`
    /// - YYYY/mm/dd HH:MM:SS: `2024/07/01 00:00:00`
    /// - YYYY/mm/dd: `2024/07/01`
    /// - English phrases: `1 day ago`, `today`
    /// </summary>
    [JsonPropertyName("from_")]
    public OneOf<DateTime, string>? From { get; set; }

    /// <summary>
    /// The ending point in time to search up to. Accepts date-time strings in ISO 8601 format and plain text strings. The default time zone is UTC.
    ///
    /// Formats with examples:
    /// - YYYY-mm-ddTHH:MM:SS: `2024-07-01T00:00:00`
    /// - YYYY-MM-dd: `2024-07-01`
    /// - YYYY/mm/dd HH:MM:SS: `2024/07/01 00:00:00`
    /// - YYYY/mm/dd: `2024/07/01`
    /// - English phrases: `1 day ago`, `today`
    /// </summary>
    [JsonPropertyName("to_")]
    public OneOf<DateTime, string>? To { get; set; }

    [JsonPropertyName("page")]
    public int? Page { get; set; }

    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
