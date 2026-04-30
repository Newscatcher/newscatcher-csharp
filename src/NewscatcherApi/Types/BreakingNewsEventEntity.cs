using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

/// <summary>
/// The data model representing a breaking news event with its associated articles.
/// </summary>
[Serializable]
public record BreakingNewsEventEntity : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Unique identifier for the breaking news event/cluster.
    /// </summary>
    [JsonPropertyName("event_id")]
    public required string EventId { get; set; }

    /// <summary>
    /// Number of articles in this breaking news cluster.
    /// </summary>
    [JsonPropertyName("articles_count")]
    public required int ArticlesCount { get; set; }

    /// <summary>
    /// The articles associated with this breaking news event.
    /// </summary>
    [JsonPropertyName("articles")]
    public IEnumerable<BreakingNewsArticleEntity> Articles { get; set; } =
        new List<BreakingNewsArticleEntity>();

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
