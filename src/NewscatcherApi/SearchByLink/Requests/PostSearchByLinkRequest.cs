using global::System.Text.Json.Serialization;
using NewscatcherApi.Core;
using OneOf;

namespace NewscatcherApi;

[Serializable]
public record PostSearchByLinkRequest
{
    [JsonPropertyName("ids")]
    public OneOf<string, IEnumerable<string>>? Ids { get; set; }

    [JsonPropertyName("links")]
    public OneOf<string, IEnumerable<string>>? Links { get; set; }

    [JsonPropertyName("from_")]
    public OneOf<DateTime, string>? From { get; set; }

    [JsonPropertyName("to_")]
    public OneOf<string, DateTime>? To { get; set; }

    [JsonPropertyName("page")]
    public int? Page { get; set; }

    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    [JsonPropertyName("robots_compliant")]
    public bool? RobotsCompliant { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
