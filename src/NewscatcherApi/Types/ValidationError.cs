using System.Text.Json.Serialization;
using NewscatcherApi.Core;
using OneOf;

#nullable enable

namespace NewscatcherApi;

public record ValidationError
{
    [JsonPropertyName("loc")]
    public IEnumerable<OneOf<string, int>> Loc { get; set; } = new List<OneOf<string, int>>();

    [JsonPropertyName("msg")]
    public required string Msg { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
