using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record LatestHeadlinesResponse
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("total_hits")]
    public required int TotalHits { get; set; }

    [JsonPropertyName("page")]
    public required int Page { get; set; }

    [JsonPropertyName("total_pages")]
    public required int TotalPages { get; set; }

    [JsonPropertyName("page_size")]
    public required int PageSize { get; set; }

    [JsonPropertyName("articles")]
    public IEnumerable<object> Articles { get; set; } = new List<object>();

    [JsonPropertyName("user_input")]
    public object UserInput { get; set; } = new Dictionary<string, object?>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
