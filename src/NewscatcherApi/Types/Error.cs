using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record Error
{
    /// <summary>
    /// A detailed description of the error.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// The HTTP status code of the error.
    /// </summary>
    [JsonPropertyName("status_code")]
    public required int StatusCode { get; set; }

    /// <summary>
    /// A short description of the status code.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
