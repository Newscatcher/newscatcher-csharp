using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record AggregationItem
{
    /// <summary>
    /// Array of time frames and their corresponding article counts
    /// </summary>
    [JsonPropertyName("aggregation_count")]
    public IEnumerable<TimeFrameCount> AggregationCount { get; set; } = new List<TimeFrameCount>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
