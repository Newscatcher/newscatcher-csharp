using System.Text.Json;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[Serializable]
public record ClusteredArticlesDto
{
    /// <summary>
    /// The number of clusters in the search results.
    /// </summary>
    [JsonPropertyName("clusters_count")]
    public required int ClustersCount { get; set; }

    /// <summary>
    /// A list of clusters found in the search results.
    /// </summary>
    [JsonPropertyName("clusters")]
    public IEnumerable<ClusterEntity> Clusters { get; set; } = new List<ClusterEntity>();

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
