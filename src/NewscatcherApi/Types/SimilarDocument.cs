using System.Text.Json;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// The data model for a similar document in the `Search similar` articles request.
/// </summary>
[Serializable]
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
