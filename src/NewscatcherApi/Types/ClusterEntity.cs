using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// The data model representing a single cluster of articles.
/// </summary>
[Serializable]
public record ClusterEntity : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
