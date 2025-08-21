using System.Text.Json;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// A single item in the aggregations array containing a collection of time-based article counts.
/// </summary>
[Serializable]
public record AggregationItem
{
    /// <summary>
    /// Array of time frames and their corresponding article counts
    /// </summary>
    [JsonPropertyName("aggregation_count")]
    public IEnumerable<TimeFrameCount> AggregationCount { get; set; } = new List<TimeFrameCount>();

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
