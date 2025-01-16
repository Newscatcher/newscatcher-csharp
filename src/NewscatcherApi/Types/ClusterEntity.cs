using System.Text.Json.Serialization;
using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record ClusterEntity
{
    /// <summary>
    /// The unique identifier for the cluster.
    /// </summary>
    [JsonPropertyName("cluster_id")]
    public required string ClusterId { get; set; }

    /// <summary>
    /// The number of articles in the cluster.
    /// </summary>
    [JsonPropertyName("cluster_size")]
    public required int ClusterSize { get; set; }

    /// <summary>
    /// A list of articles in the cluster.
    /// </summary>
    [JsonPropertyName("articles")]
    public IEnumerable<ArticleEntity> Articles { get; set; } = new List<ArticleEntity>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
