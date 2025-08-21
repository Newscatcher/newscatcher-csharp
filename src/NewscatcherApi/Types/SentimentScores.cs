using System.Text.Json;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// Sentiment scores for the article's title and content.
/// </summary>
[Serializable]
public record SentimentScores
{
    /// <summary>
    /// The sentiment score for the article title (-1.0 to 1.0).
    /// </summary>
    [JsonPropertyName("title")]
    public float? Title { get; set; }

    /// <summary>
    /// The sentiment score for the article content (-1.0 to 1.0).
    /// </summary>
    [JsonPropertyName("content")]
    public float? Content { get; set; }

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
