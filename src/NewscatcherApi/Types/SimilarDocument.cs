using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record SimilarDocument
{
    /// <summary>
    /// The unique identifier of the similar document.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The relevance score of the similar document.
    /// </summary>
    [JsonPropertyName("score")]
    public required double Score { get; set; }

    /// <summary>
    /// The title of the similar document.
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>
    /// The link to the similar document.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
