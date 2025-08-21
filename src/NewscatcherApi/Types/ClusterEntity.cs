using System.Text.Json;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// The data model representing a single cluster of articles.
/// </summary>
[Serializable]
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
