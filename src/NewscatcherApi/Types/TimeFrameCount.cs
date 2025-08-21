using System.Text.Json;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// Represents the article count for a specific time frame.
/// </summary>
[Serializable]
public record TimeFrameCount
{
    /// <summary>
    /// The timestamp for the aggregation period in format "YYYY-MM-DD HH:mm:ss"
    /// </summary>
    [JsonPropertyName("time_frame")]
    public required DateTime TimeFrame { get; set; }

    /// <summary>
    /// The number of articles published during this time frame
    /// </summary>
    [JsonPropertyName("article_count")]
    public required int ArticleCount { get; set; }

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
