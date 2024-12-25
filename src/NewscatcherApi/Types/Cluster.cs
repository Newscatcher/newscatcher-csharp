using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record Cluster
{
    [JsonPropertyName("cluster_id")]
    public required string ClusterId { get; set; }

    [JsonPropertyName("cluster_size")]
    public required int ClusterSize { get; set; }

    [JsonPropertyName("articles")]
    public IEnumerable<object> Articles { get; set; } = new List<object>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
