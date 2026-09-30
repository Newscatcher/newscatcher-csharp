using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// A single item in the aggregations array containing a collection of time-based article counts.
/// </summary>
[Serializable]
public record AggregationItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Array of time frames and their corresponding article counts
    /// </summary>
    [JsonPropertyName("aggregation_count")]
    public IEnumerable<TimeFrameCount> AggregationCount { get; set; } = new List<TimeFrameCount>();

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
