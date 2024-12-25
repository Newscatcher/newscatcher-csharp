using System.Text.Json.Serialization;
using NewscatcherApi.Core;
using OneOf;

#nullable enable

namespace NewscatcherApi;

public record SourceResponse
{
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    [JsonPropertyName("sources")]
    public IEnumerable<OneOf<SourceInfo, string>> Sources { get; set; } =
        new List<OneOf<SourceInfo, string>>();

    [JsonPropertyName("user_input")]
    public object UserInput { get; set; } = new Dictionary<string, object?>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
