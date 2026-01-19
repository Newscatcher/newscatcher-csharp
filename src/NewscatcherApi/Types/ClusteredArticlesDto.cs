using System.Text.Json;
using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[Serializable]
public record ClusteredArticlesDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
