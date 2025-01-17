using System.Text.Json.Serialization;
using NewscatcherApi.Core;
using OneOf;

#nullable enable

namespace NewscatcherApi;

public record SourcesResponseDto
{
    /// <summary>
    /// A message indicating the result of the request.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// A list of news sources that match the specified criteria.
    /// </summary>
    [JsonPropertyName("sources")]
    public IEnumerable<OneOf<SourceInfo, string>> Sources { get; set; } =
        new List<OneOf<SourceInfo, string>>();

    /// <summary>
    /// The user input parameters for the request.
    /// </summary>
    [JsonPropertyName("user_input")]
    public object UserInput { get; set; } = new Dictionary<string, object?>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
