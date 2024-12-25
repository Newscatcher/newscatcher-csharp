using System.Text.Json.Serialization;
using NewscatcherApi.Core;
using OneOf;

#nullable enable

namespace NewscatcherApi;

public record SearchUrlRequest
{
    [JsonPropertyName("ids")]
    public object? Ids { get; set; }

    [JsonPropertyName("links")]
    public object? Links { get; set; }

    [JsonPropertyName("from_")]
    public OneOf<string, DateTime>? From { get; set; }

    [JsonPropertyName("to_")]
    public OneOf<string, DateTime>? To { get; set; }

    [JsonPropertyName("page")]
    public int? Page { get; set; }

    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
